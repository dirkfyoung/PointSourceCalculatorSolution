module variables
!Only variables that are imported in from the User Interface are kept in this module.  This rule is 
!intended to facilititate changing outthe interface, as only and all the parameters in this module need to be populated.
!Common variables that are calculated and used internally between routines are transported as arguments.

    implicit none
    save
    
    real, parameter :: DELT = 86400.  !seconds, simulation TIME INTERVAL IS ONE DAY
    
    !**********************************************************
    character(len=256) :: metfilename         !met file name
    character(len=256) :: outputfilename      !output file name
    character(len=50)  :: scenario_id
    character(len=10)  :: waterbodytext       !text for water body type (not an input)
    
    character(len=256) :: timeseriesfilename = "" !user specified flow file name
    character(len=256) :: ztsfilename     = ""    !user specified mass file name
    character(len=256) :: chemical_id         !used only for output
    
    
    character(len=256) :: Additional_Info_1  !used for descriptions in Output File
    character(len=256) :: Additional_Info_2
    character(len=256) :: Additional_Info_3
    
    
    !***********chemical inputs*****************************
    integer :: nchem          ! nchem = 1 parent only, =2 parent and 1 degradate, =3 parent and 2 degradates
    

    
    
    
    real :: aer_aq_all(3)             !input aqueous-phase aerobic halflife (days) delivered from window interface
    real :: temp_ref_aer_all(3)       !temp at which aerobic study conducted  
    
    real :: anae_aq_all(3)            !anaerobic aquatic
    real :: temp_ref_anae_all(3)      !temp at which anaerobic study conducted
    
    real :: hydro_all(3)              !input hydrolysis half life (days)
    real :: temp_ref_hydrol_all (3)   !Reference temperature for hydrolysis values
    
    real :: QT                        !EXAMS Q10 values eq. 2-133
    
    real :: photo_all(3)         !near-surface photolysis half life (days
    real :: RFLAT_all(3)         !input latitude for photolysis study   
       
    real :: koc_all(3)            !Koc value (ml/g)

    logical :: no_volatilization, estimate_henry, got_henry
    real :: MWT_all(3)              !molecular wt (g/mol)
    real :: VAPR_all(3)            !vapor pressure (torr)
    real :: SOL_all(3)             !solubility (mg/L)   
    
    real :: henry_constant
    real :: heat_of_henry
    real :: henry_ref_temp
    
    
    integer :: napp                  !number of applications per year
    integer :: appday(50) 
    integer :: appmon(50) 
    real :: apprate(50)    !kg/ha
   ! real :: spray(50)      !Fraction of application to be applied to waterbody area

    integer,allocatable,dimension(:) :: appdate_sim_ref  !simulation referenced app dates (first sim day = 1)
    real,allocatable,dimension(:) :: spray  !total spray mass into water column dates with appdate_sim_ref(first sim day = 1)
  
    
    
    real :: afield         !area of adjacent runoff-producing field(m2)    
    real :: area           !water body area (m2)     
    real :: depth_0        !initial water body depth
    real :: depth_max      !maximum water body depth
    
    integer :: SimTypeFlag    !1=vvwm,2 = USepa pond, 3 = usepa reservoir, 4=constant vol w/o flow, 5 = const vol w/flow
    logical :: burialflag    !true = burial, else no burial

    real:: D_over_dx 
    real:: PRBEN
    real:: benthic_depth
    real:: porosity     !volume water/total volume
    real:: bulk_density  !dry mass/total volume  g/ml
    real:: FROC2
    real:: DOC2
    real:: BNMAS
    real:: DFAC
    real:: SUSED
    real:: CHL
    real:: FROC1
    real:: DOC1
    real:: PLMAS

    real,parameter :: CLOUD = 0.
    real, parameter :: minimum_depth = 0.00001     !minimum water body depth

    
    real :: xAerobic(2)
    real :: xBenthic(2)
    real :: xPhoto(2)
    real :: xHydro(2)
 
    integer :: flow_averaging                
    real    :: baseflow !m3/day
    logical :: is_BaseFlow
    logical :: is_specifiedMass,is_read_timeseries, is_ReadZts
    
    logical :: useSchedule(3)
    integer :: offset(3)  
    integer :: days_on(3)     
    integer :: days_off(3) 
    real ::    mass_released(3)
    
    
    logical  :: is_toxAnalysis
    
    integer  ::  user_day_water, user_day_benthic
    real     ::  user_coc_water, user_coc_benthic, user_coc_benthic_tot
    
    integer               :: number_of_endpoints
    integer,dimension(20) :: endpoint_times  !concentrations used in output (ppb)
    real,dimension(20)    :: endpoint_values  !concentrations used in output (ppb)
    
    integer               :: number_of_benthic_endpoints
    integer,dimension(20) :: benthic_endpoint_times        !endpoint averaging times
    real,dimension(20)    :: benthic_endpoint_values       !benthic concentrations used in output (ppb)
    real,dimension(20)    :: benthic_total_endpoint_values !totalbenthic concentrations used in output (ppb)
    
    end module variables