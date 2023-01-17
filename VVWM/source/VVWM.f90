!***************************************************************************
! THIS IS THE ANALYTICAL SOLUTION TO THE EFED SUBSETS OF THE EXAMS MODEL. 
!
!
! Attempt was made to put all EXAMS partameters in CAPITAL LETTERS
! errors are reported in fort.11
!___________________________________________________________________________
subroutine VVWM
use variables, ONLY: simtypeflag, area, nchem,koc_all, hydro_all, photo_all, RFLAT_all, &
                    aer_aq_all,anae_aq_all,temp_ref_aer_all,temp_ref_anae_all, MWT_all,SOL_all,VAPR_all, &
                    outputfilename, DELT,scenario_id, simtypeflag,waterbodytext,is_specifiedMass,is_ReadZts,is_BaseFlow,&
                    temp_ref_hydrol_all

use degradation
use solute_capacity
use mass_transfer
use volumeAndwashout
use MassInputs
use ProcessMetfiles
use outputprocessing
use nonInputVariables, only:k_flow  , num_years
use ALLOCATIONmodule
use coreCalculations

implicit none              

!%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%


real, parameter :: wind_height= 6.     !height at which wind measurements are reported (m)

integer :: eof_met            !flag to idicate end of met file error
integer :: ierror            !met file open error flag

real ::   latitude !of scenario as taken from the metfile

!**local chemical properties****
integer :: chem_index
real :: koc,hydro,RFLAT,photo, MWT, SOL, VAPR,temp_ref_hydrol
real :: metabolism_ref_rate
real :: metabolism_ref_temp
real :: benthic_metabolism_ref_rate
real :: benthic_metabolism_ref_temp

!*************  Met file Calculations  *****************************************
! This routine counts the records in the metfile and gives a value to the num_records parameter
! in the module nonInputVariables.  Allocations then follow below using num_records.

    call count_met(ierror) !count met file records for array allocation
        if (ierror /=0) then
            write (11,*) 'can not find the met file'
            return
        end if

     call ALLOCATION

     call read_metfile(eof_met) 
        if (eof_met /=0) then
            write (11,*) 'error: met file is messed up'
            return
        end if

     call get_flow_and_mass
     
     call spraydrift
    
    !****************************************************************
    !Washout and volume calculations for individual cases
    


    select case (simtypeflag)
        case (3,5) !reservoir constant volume,flow
                call constant_volume_calc 
        case (2,4)  !pond constant volume, no flow
                call constant_volume_calc 
                k_flow=0.  !for this case zero out washout
        case (1) !variable volume, flow
                call volume_calc
        end select


       
        
    do chem_index= 1, nchem
        
       !create local variables
        koc   = koc_all(chem_index) 
        hydro = hydro_all(chem_index) 
        RFLAT = RFLAT_all(chem_index)
        photo = photo_all(chem_index)
            
 !   real:: metabolism_ref_rate, benthic_metabolism_ref_rate  !rates used in local calcs
        metabolism_ref_rate =  aer_aq_all(chem_index)
        metabolism_ref_temp = temp_ref_aer_all(chem_index)
        
        benthic_metabolism_ref_rate = anae_aq_all(chem_index)
        benthic_metabolism_ref_temp = temp_ref_anae_all(chem_index)  
        
        
        temp_ref_hydrol= temp_ref_hydrol_all(chem_index)  
        
        MWT =  MWT_all(chem_index)
        SOL =  SOL_all(chem_index)
        VAPR  =VAPR_all(chem_index)
       
      !*******************************************
        call solute_holding_capacity(koc)    
   
        call omega_mass_xfer
        call hydrolysis(hydro,temp_ref_hydrol) 
      
        call get_latitude (latitude)
        
        call photolysis(RFLAT,photo,latitude)
        call metabolism(metabolism_ref_rate, benthic_metabolism_ref_rate, metabolism_ref_temp ,benthic_metabolism_ref_temp)
              
        call burial_calc(koc)
        
      
        
        call volatilization(MWT,SOL,VAPR,wind_height)
            
          !********************************************
          !process the individual degradation rates into overall parameters:
        call gamma_one
        call gamma_two
          !**************************************************************
        
        call initial_conditions(chem_index)
       
        call MainLoop
       
        
        select case  (simtypeflag)
        case (3)  
            waterbodytext = "Reservoir"
        case (2)
            waterbodytext = "Pond"
        case (1,4,5)
            waterbodytext =  "Custom"
        end select
        
              
   select case (chem_index)
   case (1)
      open (UNIT=11, FILE=(trim(outputfilename) //"_"//trim(scenario_id) //"_Parent.txt"), &
            STATUS ='unknown',IOSTAT=ierror)
      open (UNIT=12,FILE=(trim(outputfilename) //"_"//trim(scenario_id) // "_Parent_daily.txt"), &
            STATUS='unknown',IOSTAT=ierror)
      

      
   case (2)  
      open (UNIT = 11, FILE = (trim(outputfilename) //"_"//trim(scenario_id)//"_"//trim(waterbodytext) // "_Degradate1.txt"), &
            STATUS = 'unknown', IOSTAT = ierror)
      open (UNIT= 12, FILE= (trim(outputfilename) //"_"//trim(scenario_id)//"_"//trim(waterbodytext) // "_Degradate1_daily.txt"), &
            STATUS = 'unknown', IOSTAT = ierror)
      
      
   case (3)
      open (UNIT = 11, FILE = (trim(outputfilename) //"_"//trim(scenario_id)//"_"//trim(waterbodytext) // "_Degradate2.txt"), &
           STATUS = 'unknown', IOSTAT = ierror)
      open (UNIT= 12,FILE = (trim(outputfilename) //"_"//trim(scenario_id)//"_"//trim(waterbodytext) // "_Degradate2_daily.txt"), &
           STATUS = 'unknown', IOSTAT = ierror)
      

   end select 
          
              

        if (nchem > chem_index) then     
              call DegradateProduction(chem_index) 
        end if
        
        call output_processor(chem_index)
        
      !  call output_processor_PEAK(chem_index)

        call WriteInputs(metabolism_ref_rate,metabolism_ref_temp, & 
            benthic_metabolism_ref_rate,benthic_metabolism_ref_temp,& 
            photo,rflat,hydro,koc,mwt,vapr,sol,temp_ref_hydrol)
        close (11) 
        
     
    !**********************************************************
  end do


end subroutine VVWM
