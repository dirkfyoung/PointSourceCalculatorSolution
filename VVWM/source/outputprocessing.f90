module outputprocessing

    contains
    

    subroutine output_processor(chem_index)
    use utilities
    use variables
    use noninputvariables, ONLY: num_records,    &
                                 mavg1_store ,   &    !array of daily avg. mass 
                                 m1_store,       & 
                                 v,              &    !array of daily volumes 
                                 num_years,      &
                                 k_burial,       &
                                 k_aer_aq,       &
                                 k_flow,         &
                                 k_hydro,        &
                                 k_photo,        &
                                 k_volatile,     &
                                 k_anaer_aq,     &
                                 gamma_1,        &
                                 gamma_2,        &
                                 fw1,            &
                                 fw2,            &
                                 aq1_store,      &   !beginning day after app concentration in water column
                                 aq2_store,      &
                                 aqconc_avg1,    &   !average daily concentration (after app)
                                 aqconc_avg2,    &
                                 daily_depth,    &
                                 runoff_total ,  &
                                 erosion_total,  &
                                 spray_total ,   &
                                 firstday, firstmon,startday1900,Sediment_conversion_factor, &
                                 Wet_sediment_conversion_factor, &
                                 Daily_Avg_Runoff, Daily_avg_flow_out, &
                                 initial_fw1,initial_fdoc1,initial_fsed1,initial_fbio1,Cap1_to_Total
                                                                                          
                                        
    implicit none
    integer, intent(in) :: chem_index

    real:: simulation_average
    
    real :: xxx  !local variable
    
    real,dimension(num_records) :: Total_Water_Concentration_ppb

 !   real(8),dimension(num_records)::c1
 !   real(8),dimension(num_records)::cavgw

 ! ***********OPPTS ***********************************
    real,dimension(num_records):: conc_total
    real,dimension(num_records):: c_avgX                  
    real,dimension(num_records):: Total_benthic_equivalent
    
    integer :: i    
    integer ::date_time(8)
    real :: convert                    !conversion factor kg/m3 
    
    real :: Total_Mass

    integer :: CoC_Max_conseq
    real ::  fraction_CoC_exceed
    
    integer,dimension(num_years) ::  first_annual_dates !array of yearly first dates (absolute days).
                                    ! First date is the calendar day of start of simulation 
    first_annual_dates= 0

   
    !*********Change all units to ppb******************
    
    convert = 1000000.
   ! aqconc_avg1= aqconc_avg1*convert  !now taken care of with local variable
    aqconc_avg2= aqconc_avg2*convert
   ! aq1_store= aq1_store*convert
    
    !****Put Water Column Concentrations into total Concentrations
    conc_total = aqconc_avg1*convert/fw1
    

    call date_and_time(VALUES = date_time)
    
    !***** TIME SERIES ********************************************
    write(12, '("col 1: Daily Depth (m)" )')
    write(12, '(''col 2: Daily Average Total Water Column Conc., ug/L '')')
    write(12, '(''col 3: Daily Average Dissolved Pore Water Conc. in Benthic Zone, ug/L'')'     )
    write(12,'( ''col 4: Daily Average Dissolved Water Column Conc. , ug/L, (Col 1 x '', G14.8, ")" )') , initial_fw1
    write(12,'( ''col 5: Daily Average Total Benthic Conc. , ug/L, (Col 3 x '', G14.8, ")" )') , (Sediment_conversion_factor*1000.)
    
    
    write(12,*)  startday1900, "= Start Day (number of days since 1900)"
    do i =1, num_records
         write(12,'(6ES15.4)') daily_depth(i), conc_total(i), aqconc_avg2(i),  conc_total(i)*initial_fw1, aqconc_avg2(i)* (Sediment_conversion_factor*1000.)
    end do
    !********************************************************************************

    !*********************** WATER COLUMN HEADER ************************************
    Write(11,'(A)') "Variable Volume Water Model"
    
    write(11,'(A)') trim(additional_info_1)  
    write(11,'(A)') trim(additional_info_2)
    write(11,'(A)') trim(additional_info_3)
    
    write(11,*) 
    write(11,'(" Performed on: ", i2,"/",i2,"/",i4,2x,"at " ,i2,":",i2) ') &
                   date_time(2),date_time(3),date_time(1),date_time(5),date_time(6)
    
    write(11,*) "Chemical ID: ", trim(chemical_id)
    write(11,*) "Scenario_ID: ", trim(scenario_id)
    
    write(11,*)  '*******************************************'
    write(11, '('' Instantaneous Peak (ppb)    = '', G10.3)'  ) maxval(aq1_store*convert/fw1)   !Now total conc in ppb
    write(11, '('' Simulation Average (ppb)    = '', G10.3)'  ) sum(conc_total)/num_records
    write(11, '(A80)') '*********************************************************************************'
    write(11, '(A80)') '       Total Water Column Concentration (Dissolved Suspended)  & Toxicity        '
    write(11, '(A80)') '    Concentration          Max    Fraction of Days   Most Consecutive    CoC     '       
    write(11, '(A80)') '      Averaging            ug/L    Exceeding CoC      Days Above CoC     ug/L    '
    write(11,*)
    !***********************************************************************************
    
    do i = 1,  number_of_endpoints
      call window_average(conc_total,endpoint_times(i),num_records,c_avgX)
      if (is_toxAnalysis) then
      call Tox_analysis(num_records, c_avgX,  endpoint_values(i) , fraction_CoC_exceed, CoC_Max_conseq)
          write(11, '(I4,''-day Average Max    = '', G10.3, F9.3, 7x, I8, 8x,F10.2)'  )endpoint_times(i), maxval(c_avgX), fraction_CoC_exceed,CoC_Max_conseq,endpoint_values(i)
      else
          write(11, '(I4,''-day Average Max    = '', G10.3, ''      --              --              --'')'  )endpoint_times(i), maxval(c_avgX)
      end if
    end do
    
    !*****************************  BENTHIC HEADER ************************************************
    write(11, '(A80)') '*********************************************************************************'
    write(11, '(A80)') '                Benthic Pore Water Concentration & Toxicity                      '
    write(11, '(A80)') '    Concentration          Max    Fraction of Days   Most Consecutive    CoC     '       
    write(11, '(A80)') '      Averaging            ug/L    Exceeding CoC      Days Above CoC     ug/L    '
    write(11,*)
    !********************************************************************************************

     do i = 1,  number_of_benthic_endpoints 
        call window_average(aqconc_avg2, benthic_endpoint_times(i),num_records,c_avgX)
        if (is_toxAnalysis) then
            call Tox_analysis(num_records, c_avgX, benthic_endpoint_values(i), fraction_CoC_exceed, CoC_Max_conseq)
            write(11, '(I4,''-day Average Max    = '', G10.3, F9.3, 7x, I8, 8x,F10.2)'  )benthic_endpoint_times(i), maxval(c_avgX), fraction_CoC_exceed,CoC_Max_conseq, benthic_endpoint_values(i)
        else 
            write(11, '(I4,''-day Average Max    = '', G10.3, ''      --              --              --'')'  )benthic_endpoint_times(i), maxval(c_avgX)
        end if
     end do

 write(11, '(A80)') '*********************************************************************************'
 Write(11,*) "            Pore Water Concentration Conversion Factors"
 Write(11,*)   
 write(11, '('' Dry Benthic Conversion Factor = '', G10.3,'' Pore water (ug/L) to (total mass,ug)/(dry sed mass,kg)'')')&
        (Sediment_conversion_factor*1000.)
  
 write(11, '('' Wet Benthic Conversion Factor = '', G10.3,'' Pore water (ug/L) to (total mass,ug)/(wet sed mass,kg)'')')&
        Wet_sediment_conversion_factor*1000.
 Write(11,*)

 
  !********************************** TOTAL BENTHIC HEADER ************************************* 
  write(11, '(A80)') '*********************************************************************************'
  write(11, '(A80)') '           Benthic Total-Per-Dry-Sediment Concentration & Toxicity               '
  write(11, '(A80)') '    Concentration          Max    Fraction of Days   Most Consecutive    CoC     '       
  write(11, '(A80)') '      Averaging            ug/kg   Exceeding CoC      Days Above CoC     ug/kg    '
  Write(11,*) 
  !**************************************************************************************************
  
  
  Total_benthic_equivalent = (Sediment_conversion_factor*1000.)*aqconc_avg2  !I am just converting the benthic coc into pore water equivalent
 
  
   do i = 1,  number_of_benthic_endpoints 
        call window_average(Total_benthic_equivalent, benthic_endpoint_times(i),num_records,c_avgX)
        if (is_toxAnalysis) then
            call Tox_analysis(num_records, c_avgX, benthic_total_endpoint_values(i), fraction_CoC_exceed, CoC_Max_conseq)
            write(11, '(I4,''-day Average Max    = '', G10.3, F9.3, 7x, I8, 8x,F10.2)'  )benthic_endpoint_times(i), maxval(c_avgX), fraction_CoC_exceed,CoC_Max_conseq,benthic_total_endpoint_values(i)
        else 
            write(11,'(I4,''-day Average Max    = '', G10.3, ''      --              --              --'')'  )benthic_endpoint_times(i), maxval(c_avgX)
        end if
   end do
   
  
  write(11, '(A80)') '*********************************************************************************'
  Write(11,*) "                    Relative Distributions"
  write(*,*)
  write(11, '('' Aqueous Phase Fraction in Water Column         = '', F11.8)'  )  initial_fw1
  write(11, '('' SS-Sorbed Phase Fraction in Water Column       = '', F11.8)'  )  initial_fsed1
  write(11, '('' DOC-Phase Fraction in Water Column             = '', F11.8)'  )  initial_fdoc1
  write(11, '('' Bio-Phase Fraction in Water Column             = '', F11.8)'  )  initial_fbio1
  
  write(11, '('' Aqueous Phase Fraction in Benthic Region       = '', F11.8)'  )  fw2
  write(11, '('' Water Column to Whole System                   = '', F11.8)'  )  Cap1_to_Total
   
  
  write (11,*)
  write(11, '(A80)') '*********************************************************************************'
  write (11,*) '     Effective compartment halflives averaged over simulation duration'
  
   xxx = sum(k_flow)
   if (xxx > 0.) then
        write (11,'('' washout halflife (days)                        = '', G11.3)'  ) 0.69314/(xxx/num_records)/86400
   else
        write (11,*) "zero washout                                   =    --"
   end if
    
   xxx = sum(k_aer_aq)
   if (xxx > 0.) then
        write (11,'('' water col metab halflife (days)                = '', G11.3)'  ) 0.69314/(xxx/num_records)/86400  
   else
        write (11,*) "zero metabolism in water column                =    --"
   end if
    

    xxx = sum(k_hydro*fw1)  
    if (xxx > 0.) then
        write (11,'('' hydrolysis halflife (days)                     = '', G11.3)' ) 0.69314/(xxx/num_records)/86400

    else
        write (11,*) "zero hydrolysis                                =    --"
    end if
   
    xxx =  sum(k_photo*fw1)
    if (xxx > 0.) then
        write (11,'('' photolysis halflife (days)                     = '', G11.3)'  ) 0.69314/(xxx/num_records)/86400
    else
        write (11,*) "zero photolysis                                =    --"
    end if    
    

    xxx =  sum(k_volatile*fw1)
    if (xxx > 0.) then
        write (11,'('' volatile halflife (days)                       = '', G11.3)'  )   0.69314/(xxx/num_records)/86400
    else
        write (11,*) "zero volatility                                =    --"
    end if      
    
    
    
    
    xxx =  sum(gamma_1)
    if (xxx > 0.) then
        write (11,'('' total water col halflife (days)                = '', G11.3)'  ) 0.69314/(xxx/num_records)/86400

    else
        write (11,*) "zero degradation in water column               =    --"
    end if    
    
        write (11,*)
    
    
    xxx = sum(k_burial)
    if (xxx > 0.) then
        write (11,'('' burial halflife (days)                         = '', G11.3)'  ) 0.69314/(xxx/num_records)/86400
    else
        write (11,*) "zero burial                                    =    --"
    end if
    
    xxx = sum(k_anaer_aq)
    if (xxx > 0.) then
        write (11,'('' benthic metab halflife (days)                  = '', G11.3)'  ) 0.69314/(xxx/num_records)/86400
    else
        write (11,*) "zero benthic metab                             =    --"
    end if
    
       xxx = sum(k_hydro*fw2)
    if (xxx > 0.) then
        write (11,'('' benthic hydrolysis halflife (days)             = '', G11.3)'  ) 0.69314/(xxx/num_records)/86400
    else 
        write (11,*) "zero benthic hydrolysis                        =    --"
    end if 
    
    
    xxx = sum(gamma_2)
    if (xxx > 0.) then
        write (11,'('' total benthic halflife (days)                  = '', G11.3)'  ) 0.69314/(xxx/num_records)/86400
    else
        write (11,*) "zero benthic total degradation                 =    --"
    end if 
    write (11,*)
 
    write (11,*) "***************************************************************************" 
    write (11,*) "              Flow in/out Characteristics of Waterbody "  
    
    Write (11,'('' Average Daily ZTS Runoff Into Waterbody (m3/s)     = '', G11.3)'  ) Daily_Avg_Runoff
    Write (11,'('' Baseflow Into Waterbody (m3/s)                     = '', G11.3)'  ) baseflow
    Write (11,'('' Average Daily Flow Out of Waterbody (m3/s)         = '', G11.3)'  ) Daily_avg_flow_out
    
    end subroutine output_processor


!***********************************************************************************************************    
    subroutine WriteInputs(aer_aq,temp_ref_aer,anae_aq ,temp_ref_anae,photo,rflat,hydro,koc,mwt,vapr,sol,temp_ref_hydrol)
        use variables
        implicit none
        real, intent(in) :: aer_aq,temp_ref_aer,anae_aq ,temp_ref_anae,photo,rflat,hydro,koc,mwt,vapr,sol,temp_ref_hydrol


!      open (UNIT = 11, FILE = (trim(outputfilename) // "Output.txt"), STATUS = 'old', POSITION = 'append', IOSTAT = ierror)
               
        write(11,*) "********************************************************"
        write(11,*) "                   INPUTS " 
        write(11,*) "Chemical ID        : ",  trim(chemical_id)
        write(11,*) "Weather File       : ",  trim(metfilename)
        write(11,*) "Mass Input Schedule: ",  trim(metfilename)
        
        write(11,*) "Is Schedule Used?  Offset     On      Off     Mass (kg/d)"
        write(11,'(L10, I14, I9,I9,F10.3)') useschedule(1),offset(1)  ,days_on(1) ,days_off(1) , mass_released(1)      
        write(11,'(L10, I14, I9,I9,F10.3)') useschedule(2),offset(2)  ,days_on(2) ,days_off(2) , mass_released(2)          
        write(11,'(L10, I14, I9,I9,F10.3)') useschedule(3),offset(3)  ,days_on(3) ,days_off(3) , mass_released(3)        
        write(11,'('' watershed area for PRZM5  (m2)  = '', G11.3)'  ) afield
        
        write(11,'(" Is Time Series File Used:",L2,", FILE: ", A)') is_read_timeseries, trim(timeseriesfilename)
        write(11,'(" Is PRZM5 File Used:      ",L2,", FILE: ", A)') is_ReadZts, trim(ztsfilename)
        
        write(11,'('' oc partitioning coef (ml/g)    = '', G11.3)'  ) koc  
        write(11,'('' effective Kd (ml/g)            = '', G11.3)'  ) koc*FROC2
        write(11,'('' water degradation rate (1/s)   = '', G11.3)'  ) aer_aq
        write(11,'('' ref. temp. water (C)           = '', G11.3)'  ) temp_ref_aer
        
        write(11,'('' benthic degradation rate (1/s) = '', G11.3)'  ) anae_aq 
        write(11,'('' ref. temp. benthic (C)         = '', G11.3)'  ) temp_ref_anae
        write(11,'('' Q ten value                    = '', G11.3)'  ) QT
        write(11,'('' photolysis  rate (1/s)         = '', G11.3)'  ) photo
        write(11,'('' ref. lat. photolysis (degree)  = '', G11.3)'  ) rflat
        write(11,'('' hydrolysis rate  (1/s)         = '', G11.3)'  ) hydro
        write(11,'('' ref. temp hydrolysis  (C)      = '', G11.3)'  ) temp_ref_hydrol
        
        write(11,'('' molecular wt                   = '', G11.3)'  ) mwt
        write(11,'('' vapor pressure (torr)          = '', G11.3)'  ) vapr
        write(11,'('' solubility (mg/L)              = '', G11.3)'  ) sol
        write(11,'('' Henrys Constant (atm m3/mol)   = '', G11.3)'  ) henry_Constant 
        write(11,'('' water body area, L x W  (m2)   = '', G11.3)'  ) area
        write(11,'('' depth (m)                      = '', G11.3)'  ) depth_max
        write(11,'('' mass transfer coefficient (m/s)= '', G11.3)'  ) D_over_dx
        write(11,'('' benthic depth (m)              = '', G11.3)'  ) benthic_depth
        write(11,'('' benthic porosity               = '', G11.3)'  ) porosity
        write(11,'('' benthic bulk density (g/cm3)   = '', G11.3)'  ) bulk_density
        write(11,'('' OC frcation in benthic sed     = '', G11.3)'  ) FROC2
        write(11,'('' DOC in benthic (mg/L)          = '', G11.3)'  ) DOC2
        write(11,'('' benthic biomass  (g/m2)        = '', G11.3)'  ) bnmas
        write(11,'('' DFAC                           = '', G11.3)'  ) DFAC
        write(11,'('' SS  (mg/L)                     = '', G11.3)'  ) SUSED
        write(11,'('' chlorophyll  (mg/L)            = '', G11.3)'  ) CHL  
        write(11,'('' OC frcation in water column SS = '', G11.3)'  ) FROC1
        write(11,'('' DOC in water column (mg/L)     = '', G11.3)'  ) DOC1
        write(11,'('' biomass in water column (mg/L) = '', G11.3)'  ) PLMAS
          !  write(11,'(I4,8X, A)') SimTypeFlag, " 1=vvwm, 2=usepa pond, 3 = usepa reservoir, 4 = const vol no flow, 5 = const vol w/flow " 
      !  write(11,*)            burialflag, " T = burial, else no burial"    
        
        
    end subroutine WriteInputs
 !***********************************************************************************************************    


!***************************************************************
subroutine pick_max (num_years,num_records,bounds,c, output)
!    !this subroutine choses the maximum values of subsets of the vector c
!    !the subsets are defined by the vector "bounds"
!    !maximum values of "c" are chosen from within the c indices defined by "bounds"
!    !output is delivered in the vector "output"
    implicit none
    integer, intent(in) :: num_records
    integer, intent(in) :: num_years
    integer, intent(in) :: bounds(num_years)
    real, intent(in), dimension(num_records) :: c
    real, intent(out),dimension(num_years) :: output

    integer :: i

    forall (i = 1: num_years-1) output(i) = maxval( c(bounds(i):bounds(i+1)-1) )
    
    output(num_years)= maxval( c(bounds(num_years):num_records) )

end subroutine pick_max

!***************************************************************
subroutine percent90(c_in, n, c_out, lowYearFlag)
    !CALCULATES THE 90TH PERCENTILES
    implicit none

    integer,intent(in) :: n                        !number of items in list
    real, intent(in), dimension(n):: c_in    !list of items
    real,intent(out):: c_out                    !output of 90th centile of peaks
    real:: f,DEC      
    integer:: m    
    real,dimension(n):: c_sorted
    integer, intent(out) :: LowYearFlag  !if n is less than 10, returns max value and LowYearFlag =1
    LowYearFlag =0

    call hpsort(n,c_sorted, c_in)  !returns a sorted array

    f = 0.9*(n+1)
    m=int(f)
    DEC = f-m      
    
   if (n<10)then
      c_out = c_sorted(n)
      LowYearFlag = 1
   else 
    c_out = c_sorted(m)+DEC*(c_sorted(m+1)-c_sorted(m))
   end if

end subroutine percent90
!***************************************************************



!****************************************************************
subroutine hpsort(n,ra,b)
!  from numerical recipes  (should be upgraded to new f90 routine)
    implicit none
    integer,intent(in):: n
    real,intent(out),dimension(n)::ra !ordered output array
    real,intent(in),dimension(n):: b  !original unordered input array

    integer i,ir,j,l
    real rra
    
    ra=b    ! this added to conserve original order

    if (n.lt.2) return

    l=n/2+1
    ir=n
10    continue
    if(l.gt.1)then 
    l=l-1
    rra=ra(l)
    else 
    rra=ra(ir)    
    ra(ir)=ra(1)
    ir=ir-1
    if(ir.eq.1)then 
    ra(1)=rra 
    return
    endif
    endif
    i=l 
    j=l+l
20    if(j.le.ir)then 
        if(j.lt.ir)then
            if(ra(j).lt.ra(j+1))j=j+1 
        endif
        if(rra.lt.ra(j))then 
            ra(i)=ra(j)
            i=j
            j=j+j
        else 
            j=ir+1
        endif
        goto 20
        endif
    ra(i)=rra
    goto 10
end subroutine hpsort
!***********************************************************

subroutine Tox_analysis(num_records, conc_series, coc, fraction_exceed,max_consequtive )

integer, intent(in) :: num_records
real, dimension(num_records), intent(in) :: conc_series  !conc array of daily conc
real, intent(in) :: coc                  !target concentration of concern
real, intent(out) :: fraction_exceed

integer, intent(out) :: max_consequtive  !maximaum number of consequetive days with conc above coc

integer:: count_coc        !total number of days with concentration above coc
integer :: consequtive_counter
integer :: hold

integer :: i

count_coc = 0
consequtive_counter = 0
max_consequtive = 0

do i = 1, num_records
    
   if (conc_series(i) >= coc) then
       count_coc= count_coc+1
       consequtive_counter = consequtive_counter+1 
       if (consequtive_counter >max_consequtive) max_consequtive = consequtive_counter       
   else
       consequtive_counter = 0
       
   end if
end do

   fraction_exceed = real(count_coc)/real(num_records)


end subroutine



    end module outputprocessing
    

!!******EFED SPECIFIC ************************************
!    call find_first_annual_dates (num_years, first_annual_dates ) 
!    call pick_max(num_years,num_records, first_annual_dates,aqconc_avg1,c1_max)
!    call pick_max(num_years,num_records, first_annual_dates,c4,c4_max)
!    call pick_max(num_years,num_records, first_annual_dates,c21,c21_max)
!    call pick_max(num_years,num_records, first_annual_dates,c60,c60_max)
!    call pick_max(num_years,num_records, first_annual_dates,c90,c90_max)
!    call pick_max(num_years,num_records, first_annual_dates,benthic_c21,benthic_c21_max)
!
!    !treat the 365 day average somewhat differently:
!    !In this case, we simply are calculating the average for the 365 day forward from the
!    !day of application
!    do concurrent (i=1:num_years-1) 
!        c365_max(i) = c365(first_annual_dates(i)+365)  
!    end do
!    c365_max(num_years) = c365(num_records)
!         !****ECalculate Acute values *******************
!    call pick_max(num_years,num_records, first_annual_dates,aq1_store, peak)
!    call pick_max(num_years,num_records, first_annual_dates,aq2_store, benthic_peak)
!        
!    call percent90( c1_max,num_years, c1_90, lowyearflag)
!    call percent90(peak,num_years, peak_90, lowyearflag)
!    call percent90( c4_max,num_years, c4_90, lowyearflag)
!    call percent90(c21_max,num_years, c21_90, lowyearflag)
!    call percent90(c60_max,num_years, c60_90, lowyearflag)
!    call percent90(c90_max,num_years, c90_90, lowyearflag)
!    call percent90(c365_max,num_years, c365_90, lowyearflag)
!    
!    call percent90(benthic_peak,num_years, benthic_peak_90, lowyearflag)
!    call percent90(benthic_c21_max,num_years, benthic_c21_90, lowyearflag)
!*****************************************