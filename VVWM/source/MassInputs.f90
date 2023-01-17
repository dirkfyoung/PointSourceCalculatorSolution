module MassInputs

    contains

     subroutine get_flow_and_mass
          use nonInputVariables, Only:q_dailyFlow,ZTS_dailyFlow,Timeseries_dailyFlow, mass
          use variables, Only: baseflow,is_specifiedMass,is_read_timeseries,is_ReadZts,is_BaseFlow
          implicit none
          
          integer :: i
          
          mass= 0.0
          if (is_specifiedMass)   call add_user_spec_mass
          if (is_read_timeseries) call read_timeseries
          if (is_ReadZts)         call readzts   
          
          q_dailyFlow  =0.0     
          if (is_BaseFlow)        q_dailyFlow  = q_dailyFlow + baseflow/86400.0  !convert to seconds
          if (is_read_timeseries) q_dailyFlow  = q_dailyFlow + Timeseries_dailyFlow
          if (is_ReadZts )        q_dailyFlow  = q_dailyFlow + ZTS_dailyFlow
                
    end subroutine
    
    
    
    !*****************************************************************************************
    subroutine add_user_spec_mass()
     use nonInputVariables, Only: num_records,mass
       use variables, ONLY: days_on, days_off, mass_released ,useSchedule ,offset
        implicit none
        integer i, j, k
        
       do k = 1, 3  !number of different schemes
             if (useschedule(k)) then       
                  loop_a: do i=1 + offset(k),num_records, days_on(k) + days_off(k)  
                      do j=i, i+days_on(k)-1
                          if (j>num_records) exit loop_a  
                          if (j>=1)  mass(j,1,1) = mass(j,1,1)+ mass_released(k)          
                      end do     
                  end do loop_a
             end if            
       end do
       


    end subroutine add_user_spec_mass
    
    !*************************************************************************************************
    subroutine read_timeseries
    !this reads in both mass and daily flows.  Masses are summed here but flows are stored until combined later
       use variables, ONLY: timeseriesfilename
       use nonInputVariables, ONLY: mass, Timeseries_dailyFlow, num_records
       implicit none
       character :: dummy
       real :: dailyflow, dailymass
       integer :: i, ierror
       
       allocate(Timeseries_dailyFlow(num_records))

       open (UNIT=14,FILE= timeseriesfilename ,STATUS='old',ACTION='read',IOSTAT=ierror)
       if (ierror /=0) then
           write(11,*) "Could not find the Time Series File:", trim(timeseriesfilename)
           return
       end if
        
       i=0
       Timeseries_dailyFlow= 0.0
       dailymass = 0.0

       do while (.NOT. eof(14) .AND. i+1 <= num_records)
           i=i+1
           read (14,*) dummy,dummy,dummy, Timeseries_dailyFlow(i), dailymass  !flow read in as m3/day, dailymass as kg
           mass(i,1,1) =  mass(i,1,1) + dailymass   
       end do
      
       Timeseries_dailyFlow = Timeseries_dailyFlow/86400.  !convert to m3/sec
       
 
       
       
       
       
       

    end subroutine read_timeseries
    !**************************************************************************************************
    
    
    
    !**************************************************************************************************
    subroutine readzts
    use utilities
    use nonInputVariables, Only: num_records,   &
                                 burial,        &   !OUTPUT burial rate each day kg/s 
                                 num_years,     &   !INPUT
                                 runoff_total,  &
                                 erosion_total,  &
                                 Daily_Avg_Runoff, &
                                 mass         , & !OUTPUT array to hold runoff & erosion & spraydrift events
                                 ZTS_dailyFlow   !OUTPUT (m3/sec) array of daily flow     
    
    
    
    
    use variables, ONLY: area,    & !area of water body
                         afield,   &  !field area (m2)
                         outputfilename,  & !path and family name of przm output
                         nchem,ztsfilename
                         
    !****************************************************************
    !This subroutine reads the PRZM output file with ZTS subscript
    !It then reads in the file and puts pesticide spray drift and runoff mass into first
    !column of the array mass.
    !It returns all masses for the simulation in the array mass
    !It puts erosion pesticide mass into second column of 'mass'
    !It outputs daily runoff in m3/s in "q"
    !****************************************************************
    implicit none
        integer:: ierror    !file read errors
        integer :: i,j   
        character (len=5) :: dummy    
        real,dimension(num_records,2,3):: massZTS

        allocate(ZTS_dailyFlow(num_records))
        
        ZTS_dailyFlow= 0.0
        massZTS=0.0
        burial = 0.
        runoff_total = 0.0
        erosion_total =0.0
        
        open (UNIT=13,FILE= ztsfilename ,STATUS='old',ACTION='read',IOSTAT=ierror)
        if (ierror /=0)   write(11,*) "No ZTS FILE"
           
        read (13,*)
        read (13,*)
        read (13,*)
    
        do i=1, num_records 
             read (13,*,IOSTAT = ierror) dummy,dummy,dummy,ZTS_dailyFlow(i),burial(i),(massZTS(i,1,j),massZTS(i,2,j), j=1,nchem)            
             if (ierror /=0) exit
             !q is in  cm here.
        end do         
    

        
        
        
        massZTS= massZTS* AFIELD*10.  !converts to kg
   
        runoff_total(1:nchem) = sum(massZTS(:,1,1:nchem),1)
        erosion_total(1:nchem)= sum(massZTS(:,2,1:nchem),1)
  
        ZTS_dailyFlow = ZTS_dailyFlow *afield/8640000.    !m3/s :(cm/day) *(m2)* (m/100cm)* (day/86400s)  
        
        Daily_Avg_Runoff = sum(ZTS_dailyFlow )/num_records

        Burial = Burial*afield/864000.  !tonnes/day/ha  (ha/10000 m2)*(1000 kg/tonne)*(day/86400 sec)
              
        mass = mass + massZTS !add it to any previoulsly calculated mass put it into the variable module
        
        close (UNIT=13)
    end subroutine readzts

    
    
!%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    subroutine spraydrift
       use variables, only: napp, spray,appdate_sim_ref
       use nonInputVariables, only: mass, num_records,spray_total
                                                                              
       implicit none
       integer ::  i!,j, total_apps,status, counter,test
       
       !these hold the entire simulation of pesticide applications
       !they are indexed by the vector date_app
       !integer, allocatable, dimension(:) :: date_app
       !integer, allocatable, dimension(:) :: actual_date_app
        
       !real(8), allocatable, dimension(:) :: spray_app
       !real(8), allocatable, dimension(:) :: rate_app
       !real(8), allocatable, dimension(:) :: spray_vector
      

      ! total_apps = napp*num_years  
 
       !allocate (date_app(total_apps), STAT=status)  
       !allocate (spray_app(total_apps), STAT=status)
       !allocate (rate_app(total_apps), STAT=status)
   !    allocate (spray_vector(total_apps), STAT=status)
       
       spray_total= 0.0
       
       !years =  (/(i, i=(firstyear+1900),(firstyear+1900 +num_years-1))/)      
       !counter = 0
       !do i=1,num_years 
       !   do j=1,napp
       !       
       !       !test for applications that occur with weather files that do not start Jan 1.
       !       !prevents negative app dates
       !       if (counter == 0) then
       !           test = jd (years(i),appmon(j),appday(j))- startday1900+1
       !           if(test <=0) cycle
       !       end if
       !       
       !     counter = counter+1
       !     date_app(counter) = jd (years(i),appmon(j),appday(j))
       !     
       !     spray_app(counter) = spray(j)
       !     rate_app(counter) = apprate(j)
       !   end do      
       !end do
       
       
       
       do i=1, napp
    
           if (appdate_sim_ref(i) >0 .and. appdate_sim_ref(i) <=num_records) then
               mass(appdate_sim_ref(i), 1,1) =  mass(appdate_sim_ref(i), 1,1) + spray(i)         
               spray_total(1) =  spray_total(1) + spray(i)
           end if
       end do

       
       !allocate (actual_date_app(counter), STAT=status)  
       !allocate (spray_vector(counter), STAT=status)
       !
       !actual_date_app = date_app(1:counter) - startday1900+1 
       !spray_vector = rate_app(1:counter) *(area/10000.)*spray_app(1:counter)
       !
       !mass(actual_date_app, 1,1) =  mass(actual_date_app, 1,1) + spray_vector
       
     !  spray_total(1) = sum(spray_vector)

       !mass(date_app, 1,1) =  mass(date_app, 1,1) + rate_app *(area/10000.)*spray_app
       
    end subroutine spraydrift
!%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%    

!**********************************************************************************************
subroutine DegradateProduction(chem_index)
!when this routine is run, it calculates the production of degradate from parent
!Thus, the "index" refers to the parent chemical
      use nonInputVariables, ONLY: num_records,degradateProduced1,degradateProduced2,  &
                                    v1,v2    ,k_photo, k_hydro, k_aer_aq,capacity_1,  &
                                    aqconc_avg1,aqconc_avg2,k_anaer_aq,capacity_2 
      
      use variables, ONLY: xPhoto, xHydro, xAerobic,xBenthic,DELT, MWT_all
      implicit none               
      integer,intent(in) :: chem_index

      real :: MWTRatio
      
      MWTRatio = MWT_all(chem_index+1)/MWT_all(chem_index)

      degradateProduced1 = MWTRatio*(xPhoto(chem_index)*k_photo*v1 + xHydro(chem_index)*k_hydro*v1 + &
                            xAerobic(chem_index)*k_aer_aq*capacity_1)*aqconc_avg1*DELT
      
      
      degradateProduced2 = MWTRatio*(xHydro(chem_index)*k_hydro*v2 + xBenthic(chem_index)*k_anaer_aq*capacity_2)*aqconc_avg2*DELT 
             
      !Degradate production is delayed one time step to approximate the process and to maintain analytical solution for time step  
      degradateProduced1(2:num_records)= degradateProduced1(1:num_records-1)
      degradateProduced2(2:num_records)= degradateProduced2(1:num_records-1)
      degradateProduced1(1)= 0.
      degradateProduced2(1)= 0.

      
end subroutine DegradateProduction    
    
!######################################################################################
subroutine initial_conditions(chem_index)
       !THIS SUBROUTINE RETURNS VALUES FOR input masses into each compartment 
        use variables, ONLY: PRBEN
        use nonInputVariables, Only: num_records, mass,  & 
                                     m1_input,           & !OUTPUT mass added to littoral region (kg) 
                                     m2_input,           &       !OUTPUT mass added to bethic region (kg)
                                     degradateProduced1, &
                                     degradateProduced2
   
                                     !INPUT !mass(:,2)mass coming in by runoff and spraydrift (kg) 
                                     !INPUT mass(:,2) mass coming in on sediment (kg)
        implicit none      
        integer,intent(in) :: chem_index
        integer :: i

        
        !CALCULATE INPUT MASSES   
        
        m1_input = mass(:,1,chem_index) +(1.-PRBEN)*mass(:,2,chem_index)    !note: rfx includes spraydrift and runoff
        m2_input = PRBEN*mass(:,2,chem_index)
        
        
        

        

        !******* Add in any degradate mass produced by parent from subsequent parent run******
        if (chem_index>1) then                 !j=1 is the parent.  The following call is for the manual pesticide applications.
          m1_input = m1_input + degradateProduced1   
          m2_input = m2_input + degradateProduced2
        end if
        
end subroutine initial_conditions


end module MassInputs


