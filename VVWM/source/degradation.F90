module degradation
contains


subroutine gamma_one
   !%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
   !This subroutine calculates the Gamma_1 --the overall littoral degradation rate
   !metabloism is coded to accept sorbed phase degradation independently, but 
   !standard water bodies equate sorbed and aqueous metabloism rate
   !%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
   use nonInputVariables, Only: num_records,  &
                                 k_aer_aq,    &  !input aqueous-phase aerobic rate (per sec), see meatabolism.f90
                                 k_aer_s,     &  !input aqueous-phase aerobic rate (per sec), see meatabolism.f90
                                 k_volatile,  &  !input volatilization rate (per sec), see volatilization.f90
                                 k_hydro,     &  !input aqueous-phase hydrolysis rate (per sec), see hydrolysis.f90
                                 k_flow,      &  !input washout rate (per sec), see volumeandwashout.f90   
                                 k_photo,     &                               
                                 fw1,         &  !fraction of solute in water phase, see solute_holding_capacity.f90
                                 gamma_1         !output overall aqueous-phase first-order rate littoral (per sec)
                                                           
  implicit none

  gamma_1 = k_flow+ (k_photo + k_hydro +k_volatile) *fw1  +k_aer_aq*fw1 + k_aer_s*(1.-fw1)
  
  
    !The following makes a minimum super low value in order to avoid numerical difficulties
    where (gamma_1 <= 1e-18) 
        gamma_1 = 1e-18  !not quite zero, as this will prevent some numerical problems if all degradation is zero,
                         !Note: issues observed at 1e-20, spikey conc profile 
    end where


end subroutine gamma_one



subroutine gamma_two
use nonInputVariables, Only: num_records,     & 
                                 k_hydro,     & 
                                 k_anaer_aq,  &
                                 k_anaer_s,   &
                                 k_burial,    &         !mass rate of burial (1/s)
                                 fw2,         &
                                 gamma_2         !OUTPUT
!%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    !This subroutine calcualtes the overall rates for given
    ! the individual rates for all processes
!%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
   implicit none

   gamma_2  = k_anaer_aq*fw2 +k_anaer_s*(1.-fw2)+ k_hydro*fw2 + k_burial

end subroutine gamma_two




subroutine photolysis (RFLAT,photo,latitude)
   !%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
   !calculates photolysis rate, creates a vector k_photo of daily photolysis rates, Rates vary due to depth only
   !K_photo in per sec
   !%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    use variables, ONLY:SUSED,CHL,DOC1,CLOUD,dfac
    use nonInputVariables, Only: num_records,temp_avg,daily_depth,k_photo  !output photolysi rate (per sec)
    implicit none

    real,intent(in):: RFLAT,photo,latitude

    real:: A
                    
    real,dimension(num_records) :: term3
    real term1,term2,term4

    A= 0.141 +101.*CHL+6.25*DOC1 +.34*SUSED   !EXAMS 2.98 section 2.3.3.2.2
    
    term1 = 191700.+87050.*cos(0.0349*latitude)    !latitude correction
    term2 = 191700.+87050.*cos(0.0349*RFLAT)
    
    term3 = (1.-exp(-dfac*daily_depth*A))/dfac/daily_depth/A
    term4 = 1.-0.056*cloud
    
    k_photo = photo*term1/term2*term3*term4  !effective photolysis rate (per sec)
    
    where (temp_avg <= 0.0) !eliminate volatilization and photolysis when the pond freezes
     k_photo = 0.
    end where    
    

    !if (photo == 0.0) then !A photo half life is Zero signals that chem is Stable (Rate = 0)
    !    k_photo = 0.  
    !else
    !    A= 0.141 +101.*CHL+6.25*DOC1 +.34*SUSED   !EXAMS 2.98 section 2.3.3.2.2
    !    
    !    term1 = 191700.+87050.*cos(0.0349*latitude)    !latitude correction
    !    term2 = 191700.+87050.*cos(0.0349*RFLAT)
    !    
    !    term3 = (1.-exp(-dfac*daily_depth*A))/dfac/daily_depth/A
    !    term4 = 1.-0.056*cloud
    !    
    !    KDP  = 8.0225368e-6/photo !KDP  = 0.69314718/photo/24/3600.  !EXAMS parameter (per sec)
    !    k_photo = KDP*term1/term2*term3*term4  !effective photolysis rate (per sec)
    !    
    !    where (temp_avg <= 0) !eliminate volatilization and photolysis when the pond freezes
    !     k_photo = 0.
    !    end where    
    ! end if
    
end subroutine photolysis


!%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
subroutine hydrolysis(hydro,temp_ref_hydrol)
  !calculates the daily hydrolysis rate adjusting for temperature
  !NEW for OPPTS: Temperature Adjustment

  use variables, ONLY:  minimum_depth, QT
  use nonInputVariables, Only: num_records, &
                               daily_depth, &
                               temp_avg, &
                               k_hydro        ! output hydrolysis rate (per sec)
  
  implicit none
  real,intent(in) :: hydro           !local rate
  real,intent(in) :: temp_ref_hydrol !local temp ref for rate
  
  

  k_hydro  = hydro*QT**((temp_avg - temp_ref_hydrol)/10.) 
  

  
    !if (hydro==0) then
  !    k_hydro  = 0.   !out of convention, the half life of zero signifies stability
  !else
  !   k_hydro  = 0.69314718/hydro/86400.*QT**((temp_avg - temp_ref_hydrol)/10.)  
  !endif
!Since the field is supposed to be unflooded when depth is minimum depth, we will eliminmate hydrolysis since 
!we are saying that no water exists in the benthic during this period.
  where (daily_depth <= minimum_depth*1.001) k_hydro = 0.
           
  
end subroutine hydrolysis
!%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%




!%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
subroutine metabolism (metabolism_ref_rate, benthic_metabolism_ref_rate, metabolism_ref_temp ,benthic_metabolism_ref_temp)
  !%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
  !This subroutine calculates the first-order metabolic degradation rate, given the 
  ! half life inputs for areobic and anaerobic sorbed and aqueous phases.
  !%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    use variables, ONLY: QT
    use nonInputVariables, Only: num_records,  &
                                 k_aer_aq,     &   !output of aqueous-phase aerobic metabolism rate (per sec)
                                 k_anaer_aq,   &   !output of aqueous-phase anaerobic metabolism rate (per sec)
                                 k_aer_s,      &   !output of sorbed-phase aerobic metabolism rate (per sec)
                                 k_anaer_s,    &  !output of sorbed-phase anaerobic metabolism rate (per sec)
                                 temp_avg         !temperature (in this case it has already been processed to be 30 day average)
                                 
    implicit none                      
    real, intent(in) :: metabolism_ref_rate, metabolism_ref_temp
    real, intent(in) :: benthic_metabolism_ref_rate, benthic_metabolism_ref_temp
    
    k_aer_aq = metabolism_ref_rate*QT**((temp_avg - metabolism_ref_temp)/10.)     !now using rates instead of half lives    
    k_aer_s  = k_aer_aq   
    
    k_anaer_aq = benthic_metabolism_ref_rate*QT**((temp_avg - benthic_metabolism_ref_temp)/10.) !effective aq metab rate (per sec)
    k_anaer_s  = k_anaer_aq    
    
    
end subroutine metabolism
!%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%



subroutine volatilization(MWT,SOL,VAPR,wind_height)
!this subroutine calculates the effective first-order volatilization rate

use variables, ONLY: area, no_volatilization,henry_Constant,estimate_henry,heat_of_henry,henry_ref_temp
use nonInputVariables, Only: num_records, &
                             k_volatile,  &     !output: effective first-order decay rate due to volatilization
                             wind,        &     !input: wind speed (m/s),measured at wind_height
                             temp_avg,    &     !input: temperature (C)
                             v                  !input: array of daily pond volume (m3)
implicit none



real,intent(in):: wind_height !height of wind measurement (m)
real,intent(in):: MWT,SOL,VAPR

!real(8), dimension(num_records) :: KO2            !exams parameter, but in m/s
!real(8), dimension(num_records) :: K_overall    !overall resistance

real, allocatable, dimension(:) :: RL  !changed to allocatable bnecause of stack problems
real, allocatable, dimension(:) :: RG
real, allocatable, dimension(:) :: U    !wind speed adjusted to 10m above surface

!real(8), dimension(num_records) :: RL            !liquid phase resistance
!real(8), dimension(num_records) :: RG            !gas phase resistance
!real(8), dimension(num_records) :: VW            !p.36 EXAMS (eq 2.82)
real :: R            ! gas constant
real :: HENRY        !Henry's constant
real, allocatable, dimension(:) :: Henry_temp

integer :: i
real, parameter :: R_JKmol = 8.314

If (no_volatilization) then !NO Volatilization: EXIT  ROUTINE 
    k_volatile = 0.0 
    return
end if



allocate (Henry_temp(num_records) )
allocate (RL(num_records) )
allocate (RG(num_records) )
allocate (U(num_records) )


if (estimate_henry) then
    HENRY = VAPR/760./(SOL/MWT)            !EXAMS p188 version 2.98
else 
    HENRY = henry_Constant
end if


!Calculate Temperature Adjustment for Henry's Law

Henry_temp =  HENRY*exp(-heat_of_henry/R_JKmol*(1.0/(temp_avg+273.0) -1.0/(henry_ref_temp+273.0)))

R=    8.2057e-5                        !gas constant (atm m3/mol)


!******calculate liquid resistance*********
!    U = 4./log10(wind_height*1000.)*wind  !adjust wind ht to 10m (see paragraph under eqn 2-85)
!    where (U < 5.5)                    !default conditions p.36
!        KO2 = 4.19e-6*sqrt(U)            !m/s
!    elsewhere (U>=5.5)
!        KO2 = 3.2e-7*U*U                !m/s
!    end where
!    KO2 =KO2*1.024**(temp_avg-20.)            !temp adjustment p. 36
!    RL = 1./KO2/sqrt(32./MWT)            !(s/m) EXAMS (eq 2-77)

!******Rewrite calculate liquid resistance*********
 !if (chem_index==2) then
 !    where (wind<0.0001)wind = 0.0001
 !end if

 
    U = 4./log10(wind_height*1000.)*wind  !adjust wind ht to 10m (see paragraph under eqn 2-85)

    where (U < 5.5)                 !default conditions p.36
        RL = 4.19e-6*sqrt(U)        !m/s, RL Is really KO2, just trying to save some memory
    elsewhere (U>=5.5)
        RL = 3.2e-7*U*U             !m/s
    end where


    where (wind > .0009)!when there is no wind, there is no volatilization. Bypass to prevent divide by zero.
                        !Note: this worked with intel compiler: Divide by zero resulted in infinite RL, 
                        !subseuent divide by infinite RL equaled zero k_volatile. 
                        !Added this where construct just in case this is not universal.
                        
       RL =RL*1.024**(temp_avg-20.)            !temp adjustment p. 36
       RL = 1./RL/sqrt(32./MWT)                !(s/m) EXAMS (eq 2-77)
    
       
       
       
       !******calculate gas resistance*****************************************
       !    wind_10cm = U/2.    !convert to wind speed at 10 cm
       ! VW = 0.1857+5.68*U                                    !(m/hr) EXAMS 2-82 optimized
       ! RG = R*(temp_avg+273.15)/VW/HENRY/sqrt(18./MWT)        !(hr/m) EXAMS 2-76
  
       RG = R*(temp_avg+273.15)/(0.1857+5.68*U)/Henry_temp/sqrt(18./MWT)
       RG = RG*3600.                                        !(s/m)
       !************************************************************************
       !K_overall = 1./(RL+RG)                            !(m/s)  EXAMS 2-78
       !k_volatile = AREA*K_overall/v                    !per sec                                      
       k_volatile = AREA /(RL+RG)/v                         !per sec
    elsewhere  
       k_volatile = 0.0
    end where
    

    
    where (temp_avg <= 0.) !eliminate volatilization when the pond freezes
        k_volatile = 0.0 
    end where

  
    
    
end subroutine volatilization



end module