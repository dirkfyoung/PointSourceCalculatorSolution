Program StartupVVWM
!Purpose of the startup is to populate the Variable module.
!Command line to execute has one argument and is as follows:
! c:\> [name of this executable] ("path and file name of input file")
    use variables
    implicit none
    
    integer :: ierror,length,i,status
    character (len=256) command
    logical :: is_Koc

    
   !Initialization ******************************************
    aer_aq_all= 0.0    !if blank is read in for half life, a zero will be left and represents stability
    anae_aq_all= 0.0   !if blank is read in for half life, a zero will be left and represents stability
    hydro_all = 0.0
    photo_all=0.0
    offset = 0
 
    offset = 0
    days_on = 0    
    days_off = 0
    mass_released = 0.0
    !********************************************************************

    call get_command_argument(1,command,length)
    
    open (UNIT = 15, FILE = command, STATUS = 'old', IOSTAT = ierror)

    read(15,'(A256)') outputfilename             !Line 1  output file name
    read(15,'(A256)') Additional_Info_1          !charcacter data for output description
    read(15,'(A256)') Additional_Info_2
    read(15,'(A256)') Additional_Info_3
    

    
    read(15,'(A256)')  chemical_id                !Line 2
    
    
    read(15,*) nchem                              !Line 3
    read(15,*) is_Koc                             !Line 4 logical info used in GUI for Koc/Kd status,  True means Koc
    read(15,*) (koc_all(i),  i=1,nchem)           !Line 5 Koc (ml/g)    
    read(15,*) (aer_aq_all(i),i=1,nchem)          !Line 6 aerobic aquatic halflife(days)
    read(15,*) (temp_ref_aer_all(i),i=1,nchem)    !Line 7 ref temperature of aerobic(C)
    read(15,*) (anae_aq_all(i), i=1,nchem)        !Line 8 anaerobic aquatic halflife(days)
    read(15,*) (temp_ref_anae_all(i), i=1,nchem)  !Line 9 ref temperature of anaerobic(C)
    read(15,*) (photo_all(i),  i=1,nchem)         !Line 10 photolysis halflife(days)
    read(15,*) (RFLAT_all(i),  i=1,nchem)         !Line 11  latitude of photo study  
    read(15,*) (hydro_all(i),  i=1,nchem)         !Line 12  hydrolysis halflife (days)

    read(15,*) (temp_ref_hydrol_all(i),  i=1,nchem)   !Line 13 reserev for hydrol temper ref
    read(15,*) 
    read(15,*)  
    read(15,*) 

    read(15,*) no_volatilization, estimate_henry, got_henry    !Line 17   


   if (no_volatilization) then
     read(15,*)                                ! Line 18  this prevents reads of bad data i
     read(15,*)                                ! Line 19  
     read(15,*)                                ! Line 20 
     read(15,*)                                ! Line 21 
     read(15,*)                                ! Line 22 
     read(15,*)                                ! Line 23 
   else if (estimate_henry) then  
     read(15,*) (MWT_all(i),  i=1,nchem)       ! Line 18    !molecular wt   
     read(15,*) (VAPR_all(i),  i=1,nchem)      ! Line 19    !vapor pressure (torr)   
     read(15,*) (SOL_all(i),  i=1,nchem)       ! Line 20    solubilty (mg/L)
     read(15,*)                                ! Line 21 
     read(15,*) heat_of_henry                  ! Line 22 
     read(15,*) henry_ref_temp                 ! Line 23 
   else     
     read(15,*) (MWT_all(i),  i=1,nchem)       ! Line 18  
     read(15,*)                                ! Line 19 
     read(15,*)                                ! Line 20 
     read(15,*) henry_Constant                 ! Line 21 
     read(15,*) heat_of_henry                  ! Line 22 
     read(15,*) henry_ref_temp                 ! Line 23 
   end if
   

       

    read(15,*) (xAerobic(i),i=1,nchem-1)     !Line 24  molar conversion factor aerobic 
    read(15,*) (xBenthic(i),i=1,nchem-1)     !Line 25  molar conversion factor benthic  
    read(15,*) (xPhoto(i),  i=1,nchem-1)     !Line 26  molar conversion factor photolysis
    read(15,*) (xHydro(i),  i=1,nchem-1)     !Line 27  molar conversion factor hydrolysis 
    
    read(15,*)  QT                           !Line 28    


     
     
    !********** Mass Input ***********************
    read(15,*)   is_specifiedMass, is_read_timeseries, is_ReadZts    !Line 29 if true will use li  
 

    if (is_specifiedMass) then
         read(15,*) useschedule(1)             !Line 30
         if (useschedule(1)) then
             read(15,*) offset(1)              !Line 31
             read(15,*) days_on(1)             !Line 32
             read(15,*) days_off(1)            !Line 33
             read(15,*) mass_released(1)       !Line 34
         else
             read(15,*) 
             read(15,*)  
             read(15,*) 
             read(15,*) 
         end if
         
         read(15,*) useschedule(2)              !Line 35  
         if (useschedule(2)) then
             read(15,*) offset(2)               !Line 36
             read(15,*) days_on(2)              !Line 37
             read(15,*) days_off(2)             !Line 38
             read(15,*) mass_released(2)        !Line 39
         else
             read(15,*) 
             read(15,*)  
             read(15,*) 
             read(15,*) 
         end if
         
         read(15,*) useschedule(3)              !Line 40
         if (useschedule(3)) then
             read(15,*) offset(3)               !Line 41
             read(15,*) days_on(3)              !Line 42
             read(15,*) days_off(3)             !Line 43
             read(15,*) mass_released(3)        !Line 44
         else
             read(15,*) 
             read(15,*)  
             read(15,*) 
             read(15,*) 
         end if 
    else  
        do i=1,15
            read(15,*)
        end do   
    end if
    
    if (is_read_timeseries) then
        read(15,'(A256)')timeseriesfilename
    else 
        read(15,*)
    end if
    
    
    
    if (is_ReadZts) then
        read(15,'(A256)') ztsfilename         !Line 45
        read(15,*) afield                     !Line 46 area of adjacent runoff-producing field   
    else 
        read(15,*)
        read(15,*)
    end if
    
 
    read(15,*) napp                               !Line 47 number of spray apps, Used in EFED Applications forspray drift

    allocate (appdate_sim_ref(napp), STAT=status)
    allocate (spray(napp), STAT=status)

    read(15,*)(appdate_sim_ref(i),  i=1, napp)    !Line 48 series app days
    read(15,*) (spray(i), i=1, napp)              !Line 49

    
    read(15,'(A50)')   scenario_id           !Line 50  identifier for scenario, used for output file naming 
    read(15,'(A256)')  metfilename           !Line 51  met file name
    read(15,*)                               !Line 52  Unused     
    read(15,*)                               !Line 53  Unused      
    read(15,*)                               !Line 54  Unused      
    read(15,*) burialFlag                    !Line 55  TRUE = burial
  
    read(15,*)                               !Line 56 Unused
    read(15,*)                               !Line 57 Unused
    read(15,*)                               !Line 58 Unused
    read(15,*)                               !Line 59 Unused

    read(15,*) D_over_dx                     !Line 60
    read(15,*) PRBEN                         !Line 61
    read(15,*) benthic_depth                 !Line 62
    read(15,*) porosity                      !Line 63  volume water/total volume
    read(15,*) bulk_density                  !Line 64  dry mass/total volume  g/ml
    read(15,*) FROC2                         !Line 65  fraction oc in benthic sed
    read(15,*) DOC2                          !Line 66
    read(15,*) BNMAS                         !Line 67  
    read(15,*) DFAC                          !Line 68
    read(15,*) SUSED                         !Line 69  suspended soilids in water column
    read(15,*) CHL                           !Line 70
    read(15,*) FROC1                         !Line 71
    read(15,*) DOC1                          !Line 72
    read(15,*) PLMAS                         !Line 73

    read(15,*)               !Line 74 unused
    read(15,*)               !Line 75 unused
    read(15,*)               !Line 76 unused


    
!********************************************************************************
    read(15,*) simtypeflag  !SimTypeFlag Overide  !Line 77
       ! 1= vary volume w/ flowthrough, 2=const volume, no flowthrough, 3=const vol, flowthrough, 4 = const vol no flow, 5 = const vol, flow
       ! 2 & 3 For use with the USEPA pond and reservoir ( and other situations)

     If (.not. is_Koc)  then
           koc_all = koc_all/froc2   !This turns the Kd value into a Koc, which the model uses
     end if 

    read(15,*) area              !Line 78
    read(15,*) depth_0           !Line 79 initial water body depth
    read(15,*) depth_max         !Line 80 maximum water body depth

    read(15,*) flow_averaging    !Line 81 days used to average flow for special case reservoir
    read(15,*) is_BaseFlow    !Use base flow
    
    if (is_BaseFlow) then
       read(15,*) baseflow          !Line 83
    else 
       read(15,*) 
    end if
  
    
    read(15,*) !comment Line "******* Output Info Follows:  *************"
    
    read(15,*) number_of_endpoints
    read(15,*) (endpoint_times(i), i=1, number_of_endpoints)
    
    read(15,*) number_of_benthic_endpoints
    read(15,*) (benthic_endpoint_times(i), i=1, number_of_benthic_endpoints)

    read (15,*)  is_toxAnalysis
    
    read(15,*) (endpoint_values(i), i=1, number_of_endpoints)
    read(15,*) (benthic_endpoint_values(i), i=1, number_of_benthic_endpoints)
    read(15,*) (benthic_total_endpoint_values(i), i=1, number_of_benthic_endpoints)
  


close(15)
    



    call VVWM          

    

    
    
end program startupVVWM



