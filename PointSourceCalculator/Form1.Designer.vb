<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label20 As System.Windows.Forms.Label
        Dim Label22 As System.Windows.Forms.Label
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RetrieveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScenarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RetrieveScenarioMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveScenarioMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PointSourceCalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ChemTab = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.HenryRefTempBox = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.EstimateHenry = New System.Windows.Forms.RadioButton()
        Me.gotHenry = New System.Windows.Forms.RadioButton()
        Me.NoVolatilization = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.heatHenryBox = New System.Windows.Forms.TextBox()
        Me.henryBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.solBox = New System.Windows.Forms.TextBox()
        Me.vpBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mwtBox = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.TimeSeriesFileBox = New System.Windows.Forms.TextBox()
        Me.UseTimeSeries = New System.Windows.Forms.CheckBox()
        Me.BrowseTimeSeries = New System.Windows.Forms.Button()
        Me.orReadZTS = New System.Windows.Forms.CheckBox()
        Me.is_SpecifiedMass = New System.Windows.Forms.CheckBox()
        Me.use3 = New System.Windows.Forms.CheckBox()
        Me.use2 = New System.Windows.Forms.CheckBox()
        Me.use1 = New System.Windows.Forms.CheckBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.offsetBox3 = New System.Windows.Forms.TextBox()
        Me.massReleaseBox3 = New System.Windows.Forms.TextBox()
        Me.daysOffBox3 = New System.Windows.Forms.TextBox()
        Me.daysOnBox3 = New System.Windows.Forms.TextBox()
        Me.offsetBox2 = New System.Windows.Forms.TextBox()
        Me.massReleaseBox2 = New System.Windows.Forms.TextBox()
        Me.daysOffBox2 = New System.Windows.Forms.TextBox()
        Me.daysOnBox2 = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.offsetBox1 = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.BrowseZTS = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.WatershedAreaBox = New System.Windows.Forms.TextBox()
        Me.ZTSFileBox = New System.Windows.Forms.TextBox()
        Me.massReleaseBox1 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.daysOffBox1 = New System.Windows.Forms.TextBox()
        Me.daysOnBox1 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.chemIdBox = New System.Windows.Forms.TextBox()
        Me.RefTempBenthBox = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.benthicBox = New System.Windows.Forms.TextBox()
        Me.RefTempHydrBox = New System.Windows.Forms.TextBox()
        Me.RefLatBox = New System.Windows.Forms.TextBox()
        Me.RefTempWaterBox = New System.Windows.Forms.TextBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.isKoc = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.hydrolBox = New System.Windows.Forms.TextBox()
        Me.photoBox = New System.Windows.Forms.TextBox()
        Me.waterMetabBox = New System.Windows.Forms.TextBox()
        Me.sorptionBox = New System.Windows.Forms.TextBox()
        Me.Toxicity = New System.Windows.Forms.TabPage()
        Me.UserDefinedDaysWater = New System.Windows.Forms.TextBox()
        Me.CoCTotalUserBox = New System.Windows.Forms.TextBox()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.UserDefinedDaysBenthic = New System.Windows.Forms.TextBox()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.CocPoreWaterUserBox = New System.Windows.Forms.TextBox()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.CoCTotal1Box = New System.Windows.Forms.TextBox()
        Me.CoCTotal3Box = New System.Windows.Forms.TextBox()
        Me.CoCTotal60Box = New System.Windows.Forms.TextBox()
        Me.CoCTotal28Box = New System.Windows.Forms.TextBox()
        Me.CoCTotal7Box = New System.Windows.Forms.TextBox()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.CocUserWaterBox = New System.Windows.Forms.TextBox()
        Me.CocPoreWater1box = New System.Windows.Forms.TextBox()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.CocPoreWater3box = New System.Windows.Forms.TextBox()
        Me.CoC2box = New System.Windows.Forms.TextBox()
        Me.CoC1box = New System.Windows.Forms.TextBox()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.CocPoreWater60box = New System.Windows.Forms.TextBox()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.CocPoreWater28box = New System.Windows.Forms.TextBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.CocPoreWater7box = New System.Windows.Forms.TextBox()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Coc28box = New System.Windows.Forms.TextBox()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.CoC60box = New System.Windows.Forms.TextBox()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.Coc21box = New System.Windows.Forms.TextBox()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Coc7box = New System.Windows.Forms.TextBox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.CoC4box = New System.Windows.Forms.TextBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.CoC3box = New System.Windows.Forms.TextBox()
        Me.isToxicityAnalysis = New System.Windows.Forms.CheckBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Scenario2Tab = New System.Windows.Forms.TabPage()
        Me.GetWeather = New System.Windows.Forms.Button()
        Me.weatherBox = New System.Windows.Forms.TextBox()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.benthicdepthBox = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.massXferBox = New System.Windows.Forms.TextBox()
        Me.biomass2Box = New System.Windows.Forms.TextBox()
        Me.scenarioIdBox = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DOC2Box = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.foc2Box = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lengthBox = New System.Windows.Forms.TextBox()
        Me.bdBox = New System.Windows.Forms.TextBox()
        Me.porosityBox = New System.Windows.Forms.TextBox()
        Me.depthBox = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.constFlowBox = New System.Windows.Forms.TextBox()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.widthBox = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.is_ConstFlow = New System.Windows.Forms.RadioButton()
        Me.ssBox = New System.Windows.Forms.TextBox()
        Me.noBaseFlow = New System.Windows.Forms.RadioButton()
        Me.Biomass1Box = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.foc1Box = New System.Windows.Forms.TextBox()
        Me.dfacBox = New System.Windows.Forms.TextBox()
        Me.ChlorophyllBox = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.DOC1Box = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.UserDaysBenthic = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.totalCocExceedUser = New System.Windows.Forms.TextBox()
        Me.totalconcUser = New System.Windows.Forms.TextBox()
        Me.totalconc7 = New System.Windows.Forms.TextBox()
        Me.totalconc1 = New System.Windows.Forms.TextBox()
        Me.totalCocExceed3 = New System.Windows.Forms.TextBox()
        Me.totalconc3 = New System.Windows.Forms.TextBox()
        Me.totalCocExceed60 = New System.Windows.Forms.TextBox()
        Me.totalconc60 = New System.Windows.Forms.TextBox()
        Me.totalCocExceed28 = New System.Windows.Forms.TextBox()
        Me.totalconc28 = New System.Windows.Forms.TextBox()
        Me.Label105 = New System.Windows.Forms.Label()
        Me.totalCocExceed7 = New System.Windows.Forms.TextBox()
        Me.totalCocExceed1 = New System.Windows.Forms.TextBox()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.pwcocUserExceed = New System.Windows.Forms.TextBox()
        Me.pwconcUserbox = New System.Windows.Forms.TextBox()
        Me.UserDaysWater = New System.Windows.Forms.Label()
        Me.cocUserexceed = New System.Windows.Forms.TextBox()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.concUserBox = New System.Windows.Forms.TextBox()
        Me.pwconc7box = New System.Windows.Forms.TextBox()
        Me.pwconc1box = New System.Windows.Forms.TextBox()
        Me.conc7box = New System.Windows.Forms.TextBox()
        Me.conc1box = New System.Windows.Forms.TextBox()
        Me.pwcoc3exceed = New System.Windows.Forms.TextBox()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.pwconc3box = New System.Windows.Forms.TextBox()
        Me.pwcoc60exceed = New System.Windows.Forms.TextBox()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.pwconc60box = New System.Windows.Forms.TextBox()
        Me.pwcoc28exceed = New System.Windows.Forms.TextBox()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.pwconc28box = New System.Windows.Forms.TextBox()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.pwcoc7exceed = New System.Windows.Forms.TextBox()
        Me.pwcoc1exceed = New System.Windows.Forms.TextBox()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.coc21exceed = New System.Windows.Forms.TextBox()
        Me.coc60exceed = New System.Windows.Forms.TextBox()
        Me.coc28exceed = New System.Windows.Forms.TextBox()
        Me.coc2exceed = New System.Windows.Forms.TextBox()
        Me.coc4exceed = New System.Windows.Forms.TextBox()
        Me.coc3exceed = New System.Windows.Forms.TextBox()
        Me.coc7exceed = New System.Windows.Forms.TextBox()
        Me.coc1exceed = New System.Windows.Forms.TextBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.conc21box = New System.Windows.Forms.TextBox()
        Me.conc60box = New System.Windows.Forms.TextBox()
        Me.conc28box = New System.Windows.Forms.TextBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.conc2box = New System.Windows.Forms.TextBox()
        Me.conc4box = New System.Windows.Forms.TextBox()
        Me.conc3box = New System.Windows.Forms.TextBox()
        Me.CopyGraph = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label116 = New System.Windows.Forms.Label()
        Me.Label115 = New System.Windows.Forms.Label()
        Me.Label114 = New System.Windows.Forms.Label()
        Me.Label113 = New System.Windows.Forms.Label()
        Me.Label112 = New System.Windows.Forms.Label()
        Me.Label111 = New System.Windows.Forms.Label()
        Me.Label110 = New System.Windows.Forms.Label()
        Me.Label109 = New System.Windows.Forms.Label()
        Me.Label108 = New System.Windows.Forms.Label()
        Me.benthicTotalOut = New System.Windows.Forms.TextBox()
        Me.benthicHydrolysisOut = New System.Windows.Forms.TextBox()
        Me.benthicMetabolismOut = New System.Windows.Forms.TextBox()
        Me.photolysisOut = New System.Windows.Forms.TextBox()
        Me.hydrolysisOut = New System.Windows.Forms.TextBox()
        Me.TotalOut = New System.Windows.Forms.TextBox()
        Me.volatileOut = New System.Windows.Forms.TextBox()
        Me.metabolismOut = New System.Windows.Forms.TextBox()
        Me.washoutOut = New System.Windows.Forms.TextBox()
        Me.Label107 = New System.Windows.Forms.Label()
        Me.Label106 = New System.Windows.Forms.Label()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.bioPhase1 = New System.Windows.Forms.TextBox()
        Me.docPhase1 = New System.Windows.Forms.TextBox()
        Me.aqPhaseTotal = New System.Windows.Forms.TextBox()
        Me.aqPhase2 = New System.Windows.Forms.TextBox()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.wetConversionBox = New System.Windows.Forms.TextBox()
        Me.dryConversionBox = New System.Windows.Forms.TextBox()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.ssPhase1 = New System.Windows.Forms.TextBox()
        Me.AqPhase1 = New System.Windows.Forms.TextBox()
        Me.Run = New System.Windows.Forms.Button()
        Me.SaveAllInputsDialog = New System.Windows.Forms.SaveFileDialog()
        Me.workingDirectoryBox = New System.Windows.Forms.TextBox()
        Me.ioFamilyNameBox = New System.Windows.Forms.TextBox()
        Me.GetWeatherDialog = New System.Windows.Forms.OpenFileDialog()
        Me.GetAllInputsDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BrowseZTSDialog = New System.Windows.Forms.OpenFileDialog()
        Me.BrowseTimeSeriesDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveScenarioDialog = New System.Windows.Forms.SaveFileDialog()
        Me.RetrieveScenarioDialog = New System.Windows.Forms.OpenFileDialog()
        Me.FlowAveraging = New System.Windows.Forms.TextBox()
        Me.Label117 = New System.Windows.Forms.Label()
        Label20 = New System.Windows.Forms.Label()
        Label22 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.ChemTab.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Toxicity.SuspendLayout()
        Me.Scenario2Tab.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label20
        '
        Label20.AutoSize = True
        Label20.Location = New System.Drawing.Point(12, 783)
        Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label20.Name = "Label20"
        Label20.Size = New System.Drawing.Size(125, 17)
        Label20.TabIndex = 3
        Label20.Text = "Working Directory:"
        '
        'Label22
        '
        Label22.AutoSize = True
        Label22.Location = New System.Drawing.Point(1, 827)
        Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label22.Name = "Label22"
        Label22.Size = New System.Drawing.Size(138, 17)
        Label22.TabIndex = 5
        Label22.Text = "Outfile Family Name:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ScenarioToolStripMenuItem, Me.PointSourceCalculatorToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(775, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RetrieveToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'RetrieveToolStripMenuItem
        '
        Me.RetrieveToolStripMenuItem.Name = "RetrieveToolStripMenuItem"
        Me.RetrieveToolStripMenuItem.Size = New System.Drawing.Size(168, 26)
        Me.RetrieveToolStripMenuItem.Text = "Retrieve All"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(168, 26)
        Me.SaveToolStripMenuItem.Text = "Save All"
        '
        'ScenarioToolStripMenuItem
        '
        Me.ScenarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RetrieveScenarioMenuItem, Me.SaveScenarioMenuItem})
        Me.ScenarioToolStripMenuItem.Name = "ScenarioToolStripMenuItem"
        Me.ScenarioToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.ScenarioToolStripMenuItem.Text = "Scenario"
        '
        'RetrieveScenarioMenuItem
        '
        Me.RetrieveScenarioMenuItem.Name = "RetrieveScenarioMenuItem"
        Me.RetrieveScenarioMenuItem.Size = New System.Drawing.Size(146, 26)
        Me.RetrieveScenarioMenuItem.Text = "Retrieve"
        '
        'SaveScenarioMenuItem
        '
        Me.SaveScenarioMenuItem.Name = "SaveScenarioMenuItem"
        Me.SaveScenarioMenuItem.Size = New System.Drawing.Size(146, 26)
        Me.SaveScenarioMenuItem.Text = "Save"
        '
        'PointSourceCalculatorToolStripMenuItem
        '
        Me.PointSourceCalculatorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.PointSourceCalculatorToolStripMenuItem.Name = "PointSourceCalculatorToolStripMenuItem"
        Me.PointSourceCalculatorToolStripMenuItem.Size = New System.Drawing.Size(176, 24)
        Me.PointSourceCalculatorToolStripMenuItem.Text = "Point Source Calculator"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(133, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.ChemTab)
        Me.TabControl1.Controls.Add(Me.Toxicity)
        Me.TabControl1.Controls.Add(Me.Scenario2Tab)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 32)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(773, 738)
        Me.TabControl1.TabIndex = 1
        '
        'ChemTab
        '
        Me.ChemTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChemTab.Controls.Add(Me.GroupBox2)
        Me.ChemTab.Controls.Add(Me.Label47)
        Me.ChemTab.Controls.Add(Me.Label46)
        Me.ChemTab.Controls.Add(Me.Label45)
        Me.ChemTab.Controls.Add(Me.Label44)
        Me.ChemTab.Controls.Add(Me.Label43)
        Me.ChemTab.Controls.Add(Me.Label42)
        Me.ChemTab.Controls.Add(Me.Label41)
        Me.ChemTab.Controls.Add(Me.Label40)
        Me.ChemTab.Controls.Add(Me.GroupBox1)
        Me.ChemTab.Controls.Add(Me.Label19)
        Me.ChemTab.Controls.Add(Me.chemIdBox)
        Me.ChemTab.Controls.Add(Me.RefTempBenthBox)
        Me.ChemTab.Controls.Add(Me.Label18)
        Me.ChemTab.Controls.Add(Me.benthicBox)
        Me.ChemTab.Controls.Add(Me.RefTempHydrBox)
        Me.ChemTab.Controls.Add(Me.RefLatBox)
        Me.ChemTab.Controls.Add(Me.RefTempWaterBox)
        Me.ChemTab.Controls.Add(Me.RadioButton2)
        Me.ChemTab.Controls.Add(Me.isKoc)
        Me.ChemTab.Controls.Add(Me.Label4)
        Me.ChemTab.Controls.Add(Me.Label3)
        Me.ChemTab.Controls.Add(Me.Label2)
        Me.ChemTab.Controls.Add(Me.Label1)
        Me.ChemTab.Controls.Add(Me.hydrolBox)
        Me.ChemTab.Controls.Add(Me.photoBox)
        Me.ChemTab.Controls.Add(Me.waterMetabBox)
        Me.ChemTab.Controls.Add(Me.sorptionBox)
        Me.ChemTab.Location = New System.Drawing.Point(4, 25)
        Me.ChemTab.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChemTab.Name = "ChemTab"
        Me.ChemTab.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChemTab.Size = New System.Drawing.Size(765, 709)
        Me.ChemTab.TabIndex = 0
        Me.ChemTab.Text = "Chemical"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label55)
        Me.GroupBox2.Controls.Add(Me.HenryRefTempBox)
        Me.GroupBox2.Controls.Add(Me.Label54)
        Me.GroupBox2.Controls.Add(Me.Label53)
        Me.GroupBox2.Controls.Add(Me.Label52)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.EstimateHenry)
        Me.GroupBox2.Controls.Add(Me.gotHenry)
        Me.GroupBox2.Controls.Add(Me.NoVolatilization)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.heatHenryBox)
        Me.GroupBox2.Controls.Add(Me.henryBox)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.solBox)
        Me.GroupBox2.Controls.Add(Me.vpBox)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.mwtBox)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(11, 178)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox2.Size = New System.Drawing.Size(577, 194)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Volatilization"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(249, 161)
        Me.Label55.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(149, 18)
        Me.Label55.TabIndex = 53
        Me.Label55.Text = "Reference Temp (°C)"
        '
        'HenryRefTempBox
        '
        Me.HenryRefTempBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HenryRefTempBox.Location = New System.Drawing.Point(420, 156)
        Me.HenryRefTempBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.HenryRefTempBox.Name = "HenryRefTempBox"
        Me.HenryRefTempBox.Size = New System.Drawing.Size(79, 23)
        Me.HenryRefTempBox.TabIndex = 52
        Me.HenryRefTempBox.Tag = "heat of Henry."
        Me.ToolTip1.SetToolTip(Me.HenryRefTempBox, "Can get from EPISUITE")
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(208, 103)
        Me.Label54.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(189, 18)
        Me.Label54.TabIndex = 51
        Me.Label54.Text = "Henry's const (atm m³/mol)"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(23, 116)
        Me.Label53.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(133, 18)
        Me.Label53.TabIndex = 50
        Me.Label53.Text = "Use Henry's Const"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(9, 73)
        Me.Label52.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(164, 18)
        Me.Label52.TabIndex = 49
        Me.Label52.Text = "Estimate Henry's Const"
        Me.ToolTip1.SetToolTip(Me.Label52, "Estimate from: VP*MWT/SOL/760")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(31, 28)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 18)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "No Volatilization"
        '
        'EstimateHenry
        '
        Me.EstimateHenry.AutoSize = True
        Me.EstimateHenry.Location = New System.Drawing.Point(76, 92)
        Me.EstimateHenry.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EstimateHenry.Name = "EstimateHenry"
        Me.EstimateHenry.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.EstimateHenry.Size = New System.Drawing.Size(17, 16)
        Me.EstimateHenry.TabIndex = 47
        Me.EstimateHenry.UseVisualStyleBackColor = True
        '
        'gotHenry
        '
        Me.gotHenry.AutoSize = True
        Me.gotHenry.Location = New System.Drawing.Point(76, 135)
        Me.gotHenry.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gotHenry.Name = "gotHenry"
        Me.gotHenry.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.gotHenry.Size = New System.Drawing.Size(17, 16)
        Me.gotHenry.TabIndex = 46
        Me.gotHenry.UseVisualStyleBackColor = True
        '
        'NoVolatilization
        '
        Me.NoVolatilization.AutoSize = True
        Me.NoVolatilization.Checked = True
        Me.NoVolatilization.Location = New System.Drawing.Point(76, 48)
        Me.NoVolatilization.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NoVolatilization.Name = "NoVolatilization"
        Me.NoVolatilization.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NoVolatilization.Size = New System.Drawing.Size(17, 16)
        Me.NoVolatilization.TabIndex = 45
        Me.NoVolatilization.TabStop = True
        Me.NoVolatilization.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(251, 135)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(150, 18)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Heat of Henry (J/mol)"
        '
        'heatHenryBox
        '
        Me.heatHenryBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.heatHenryBox.Location = New System.Drawing.Point(420, 132)
        Me.heatHenryBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.heatHenryBox.Name = "heatHenryBox"
        Me.heatHenryBox.Size = New System.Drawing.Size(79, 23)
        Me.heatHenryBox.TabIndex = 13
        Me.heatHenryBox.Tag = "heat of Henry."
        Me.ToolTip1.SetToolTip(Me.heatHenryBox, "Can get from EPISUITE")
        '
        'henryBox
        '
        Me.henryBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.henryBox.Location = New System.Drawing.Point(420, 102)
        Me.henryBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.henryBox.Name = "henryBox"
        Me.henryBox.Size = New System.Drawing.Size(79, 23)
        Me.henryBox.TabIndex = 12
        Me.henryBox.Tag = "Henry's constant."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(287, 76)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 18)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Solubility (mg/L)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(253, 52)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 18)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Vapor Pressure (torr)"
        '
        'solBox
        '
        Me.solBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.solBox.Location = New System.Drawing.Point(420, 73)
        Me.solBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.solBox.Name = "solBox"
        Me.solBox.Size = New System.Drawing.Size(79, 23)
        Me.solBox.TabIndex = 11
        Me.solBox.Tag = "solubility."
        '
        'vpBox
        '
        Me.vpBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vpBox.Location = New System.Drawing.Point(420, 48)
        Me.vpBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.vpBox.Name = "vpBox"
        Me.vpBox.Size = New System.Drawing.Size(79, 23)
        Me.vpBox.TabIndex = 10
        Me.vpBox.Tag = "vapor pressure."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(276, 27)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Molecular Weight"
        '
        'mwtBox
        '
        Me.mwtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mwtBox.Location = New System.Drawing.Point(420, 23)
        Me.mwtBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mwtBox.Name = "mwtBox"
        Me.mwtBox.Size = New System.Drawing.Size(79, 23)
        Me.mwtBox.TabIndex = 9
        Me.mwtBox.Tag = "molecular weight."
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(333, 100)
        Me.Label47.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(23, 18)
        Me.Label47.TabIndex = 44
        Me.Label47.Text = "@"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(333, 126)
        Me.Label46.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(23, 18)
        Me.Label46.TabIndex = 43
        Me.Label46.Text = "@"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(333, 151)
        Me.Label45.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(23, 18)
        Me.Label45.TabIndex = 42
        Me.Label45.Text = "@"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(333, 74)
        Me.Label44.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(23, 18)
        Me.Label44.TabIndex = 41
        Me.Label44.Text = "@"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(417, 151)
        Me.Label43.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(25, 18)
        Me.Label43.TabIndex = 40
        Me.Label43.Text = "°C"
        Me.ToolTip1.SetToolTip(Me.Label43, "Temperature refernce for" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "water column degradation")
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(417, 126)
        Me.Label42.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(25, 18)
        Me.Label42.TabIndex = 39
        Me.Label42.Text = "°C"
        Me.ToolTip1.SetToolTip(Me.Label42, "Temperature refernce for" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "water column degradation")
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(417, 100)
        Me.Label41.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(65, 18)
        Me.Label41.TabIndex = 38
        Me.Label41.Text = "°Latitude"
        Me.ToolTip1.SetToolTip(Me.Label41, "Temperature refernce for" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "water column degradation")
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(417, 74)
        Me.Label40.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(25, 18)
        Me.Label40.TabIndex = 37
        Me.Label40.Text = "°C"
        Me.ToolTip1.SetToolTip(Me.Label40, "Temperature refernce for" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "water column degradation")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label92)
        Me.GroupBox1.Controls.Add(Me.TimeSeriesFileBox)
        Me.GroupBox1.Controls.Add(Me.UseTimeSeries)
        Me.GroupBox1.Controls.Add(Me.BrowseTimeSeries)
        Me.GroupBox1.Controls.Add(Me.orReadZTS)
        Me.GroupBox1.Controls.Add(Me.is_SpecifiedMass)
        Me.GroupBox1.Controls.Add(Me.use3)
        Me.GroupBox1.Controls.Add(Me.use2)
        Me.GroupBox1.Controls.Add(Me.use1)
        Me.GroupBox1.Controls.Add(Me.Label51)
        Me.GroupBox1.Controls.Add(Me.offsetBox3)
        Me.GroupBox1.Controls.Add(Me.massReleaseBox3)
        Me.GroupBox1.Controls.Add(Me.daysOffBox3)
        Me.GroupBox1.Controls.Add(Me.daysOnBox3)
        Me.GroupBox1.Controls.Add(Me.offsetBox2)
        Me.GroupBox1.Controls.Add(Me.massReleaseBox2)
        Me.GroupBox1.Controls.Add(Me.daysOffBox2)
        Me.GroupBox1.Controls.Add(Me.daysOnBox2)
        Me.GroupBox1.Controls.Add(Me.Label50)
        Me.GroupBox1.Controls.Add(Me.offsetBox1)
        Me.GroupBox1.Controls.Add(Me.Label49)
        Me.GroupBox1.Controls.Add(Me.Label48)
        Me.GroupBox1.Controls.Add(Me.BrowseZTS)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.WatershedAreaBox)
        Me.GroupBox1.Controls.Add(Me.ZTSFileBox)
        Me.GroupBox1.Controls.Add(Me.massReleaseBox1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.daysOffBox1)
        Me.GroupBox1.Controls.Add(Me.daysOnBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(21, 380)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(567, 319)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mass Release Schedule"
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label92.Location = New System.Drawing.Point(9, 169)
        Me.Label92.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(69, 18)
        Me.Label92.TabIndex = 58
        Me.Label92.Text = "Path/File:"
        Me.Label92.Visible = False
        '
        'TimeSeriesFileBox
        '
        Me.TimeSeriesFileBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeSeriesFileBox.Location = New System.Drawing.Point(89, 167)
        Me.TimeSeriesFileBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TimeSeriesFileBox.Name = "TimeSeriesFileBox"
        Me.TimeSeriesFileBox.Size = New System.Drawing.Size(472, 23)
        Me.TimeSeriesFileBox.TabIndex = 57
        Me.TimeSeriesFileBox.Tag = "time series file."
        Me.TimeSeriesFileBox.Visible = False
        '
        'UseTimeSeries
        '
        Me.UseTimeSeries.AutoSize = True
        Me.UseTimeSeries.Location = New System.Drawing.Point(8, 139)
        Me.UseTimeSeries.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UseTimeSeries.Name = "UseTimeSeries"
        Me.UseTimeSeries.Size = New System.Drawing.Size(201, 22)
        Me.UseTimeSeries.TabIndex = 56
        Me.UseTimeSeries.Text = "Use a Time Series File"
        Me.UseTimeSeries.UseVisualStyleBackColor = True
        '
        'BrowseTimeSeries
        '
        Me.BrowseTimeSeries.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrowseTimeSeries.Location = New System.Drawing.Point(245, 135)
        Me.BrowseTimeSeries.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BrowseTimeSeries.Name = "BrowseTimeSeries"
        Me.BrowseTimeSeries.Size = New System.Drawing.Size(136, 31)
        Me.BrowseTimeSeries.TabIndex = 55
        Me.BrowseTimeSeries.Text = "Browse for File"
        Me.BrowseTimeSeries.UseVisualStyleBackColor = True
        Me.BrowseTimeSeries.Visible = False
        '
        'orReadZTS
        '
        Me.orReadZTS.AutoSize = True
        Me.orReadZTS.Location = New System.Drawing.Point(8, 226)
        Me.orReadZTS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.orReadZTS.Name = "orReadZTS"
        Me.orReadZTS.Size = New System.Drawing.Size(208, 22)
        Me.orReadZTS.TabIndex = 54
        Me.orReadZTS.Text = "Use PRZM5 Output File"
        Me.orReadZTS.UseVisualStyleBackColor = True
        '
        'is_SpecifiedMass
        '
        Me.is_SpecifiedMass.AutoSize = True
        Me.is_SpecifiedMass.Location = New System.Drawing.Point(8, 47)
        Me.is_SpecifiedMass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.is_SpecifiedMass.Name = "is_SpecifiedMass"
        Me.is_SpecifiedMass.Size = New System.Drawing.Size(131, 22)
        Me.is_SpecifiedMass.TabIndex = 53
        Me.is_SpecifiedMass.Text = "Specify Mass"
        Me.is_SpecifiedMass.UseVisualStyleBackColor = True
        '
        'use3
        '
        Me.use3.AutoSize = True
        Me.use3.Location = New System.Drawing.Point(161, 98)
        Me.use3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.use3.Name = "use3"
        Me.use3.Size = New System.Drawing.Size(18, 17)
        Me.use3.TabIndex = 52
        Me.use3.UseVisualStyleBackColor = True
        '
        'use2
        '
        Me.use2.AutoSize = True
        Me.use2.Location = New System.Drawing.Point(161, 74)
        Me.use2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.use2.Name = "use2"
        Me.use2.Size = New System.Drawing.Size(18, 17)
        Me.use2.TabIndex = 51
        Me.use2.UseVisualStyleBackColor = True
        '
        'use1
        '
        Me.use1.AutoSize = True
        Me.use1.Location = New System.Drawing.Point(161, 49)
        Me.use1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.use1.Name = "use1"
        Me.use1.Size = New System.Drawing.Size(18, 17)
        Me.use1.TabIndex = 50
        Me.use1.UseVisualStyleBackColor = True
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(151, 27)
        Me.Label51.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(35, 18)
        Me.Label51.TabIndex = 49
        Me.Label51.Text = "Use"
        '
        'offsetBox3
        '
        Me.offsetBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.offsetBox3.Location = New System.Drawing.Point(213, 95)
        Me.offsetBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.offsetBox3.Name = "offsetBox3"
        Me.offsetBox3.Size = New System.Drawing.Size(59, 23)
        Me.offsetBox3.TabIndex = 48
        Me.offsetBox3.Tag = "offset 3."
        Me.ToolTip1.SetToolTip(Me.offsetBox3, "Number of ±days to delay the application sequence. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "An offset of zero will start" &
        " the sequence on the first" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "day of the simulation.")
        '
        'massReleaseBox3
        '
        Me.massReleaseBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.massReleaseBox3.Location = New System.Drawing.Point(441, 95)
        Me.massReleaseBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.massReleaseBox3.Name = "massReleaseBox3"
        Me.massReleaseBox3.Size = New System.Drawing.Size(105, 23)
        Me.massReleaseBox3.TabIndex = 46
        Me.massReleaseBox3.Tag = "mass released 3."
        Me.ToolTip1.SetToolTip(Me.massReleaseBox3, "Daily mass released on ""Days On"".")
        '
        'daysOffBox3
        '
        Me.daysOffBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.daysOffBox3.Location = New System.Drawing.Point(355, 95)
        Me.daysOffBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.daysOffBox3.Name = "daysOffBox3"
        Me.daysOffBox3.Size = New System.Drawing.Size(59, 23)
        Me.daysOffBox3.TabIndex = 47
        Me.daysOffBox3.Tag = "days off 3."
        Me.ToolTip1.SetToolTip(Me.daysOffBox3, "Number of consequetive days" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "when no mass is released.")
        '
        'daysOnBox3
        '
        Me.daysOnBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.daysOnBox3.Location = New System.Drawing.Point(281, 95)
        Me.daysOnBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.daysOnBox3.Name = "daysOnBox3"
        Me.daysOnBox3.Size = New System.Drawing.Size(59, 23)
        Me.daysOnBox3.TabIndex = 45
        Me.daysOnBox3.Tag = "days on 3."
        '
        'offsetBox2
        '
        Me.offsetBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.offsetBox2.Location = New System.Drawing.Point(213, 70)
        Me.offsetBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.offsetBox2.Name = "offsetBox2"
        Me.offsetBox2.Size = New System.Drawing.Size(59, 23)
        Me.offsetBox2.TabIndex = 44
        Me.offsetBox2.Tag = "offset 2."
        Me.ToolTip1.SetToolTip(Me.offsetBox2, "Number of ±days to delay the application sequence." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "An offset of zero will start " &
        "the sequence on the first" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "day of the simulation. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'massReleaseBox2
        '
        Me.massReleaseBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.massReleaseBox2.Location = New System.Drawing.Point(441, 70)
        Me.massReleaseBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.massReleaseBox2.Name = "massReleaseBox2"
        Me.massReleaseBox2.Size = New System.Drawing.Size(105, 23)
        Me.massReleaseBox2.TabIndex = 42
        Me.massReleaseBox2.Tag = "mass released 2."
        Me.ToolTip1.SetToolTip(Me.massReleaseBox2, "Daily mass released on ""Days On"".")
        '
        'daysOffBox2
        '
        Me.daysOffBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.daysOffBox2.Location = New System.Drawing.Point(355, 70)
        Me.daysOffBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.daysOffBox2.Name = "daysOffBox2"
        Me.daysOffBox2.Size = New System.Drawing.Size(59, 23)
        Me.daysOffBox2.TabIndex = 43
        Me.daysOffBox2.Tag = "days off 2."
        Me.ToolTip1.SetToolTip(Me.daysOffBox2, "Number of consequetive days" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "when no mass is released.")
        '
        'daysOnBox2
        '
        Me.daysOnBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.daysOnBox2.Location = New System.Drawing.Point(281, 70)
        Me.daysOnBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.daysOnBox2.Name = "daysOnBox2"
        Me.daysOnBox2.Size = New System.Drawing.Size(59, 23)
        Me.daysOnBox2.TabIndex = 41
        Me.daysOnBox2.Tag = "days on 2."
        Me.ToolTip1.SetToolTip(Me.daysOnBox2, "Number of consequetive days" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "when mass is released.")
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(215, 26)
        Me.Label50.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(48, 18)
        Me.Label50.TabIndex = 40
        Me.Label50.Text = "Offset"
        Me.ToolTip1.SetToolTip(Me.Label50, "Number of ±days to delay application sequence. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "An offset of zero will start the" &
        " sequence on the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "first day of the simulation. ")
        '
        'offsetBox1
        '
        Me.offsetBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.offsetBox1.Location = New System.Drawing.Point(213, 46)
        Me.offsetBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.offsetBox1.Name = "offsetBox1"
        Me.offsetBox1.Size = New System.Drawing.Size(59, 23)
        Me.offsetBox1.TabIndex = 39
        Me.offsetBox1.Tag = "offset 1."
        Me.ToolTip1.SetToolTip(Me.offsetBox1, "Number of ±days to delay the application sequence. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "An offset of zero will start" &
        " the sequence on the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "first day of the simulation.")
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(9, 255)
        Me.Label49.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(69, 18)
        Me.Label49.TabIndex = 38
        Me.Label49.Text = "Path/File:"
        Me.Label49.Visible = False
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(12, 283)
        Me.Label48.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(146, 18)
        Me.Label48.TabIndex = 37
        Me.Label48.Text = "Watershed Area (m²)"
        Me.Label48.Visible = False
        '
        'BrowseZTS
        '
        Me.BrowseZTS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrowseZTS.Location = New System.Drawing.Point(247, 222)
        Me.BrowseZTS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BrowseZTS.Name = "BrowseZTS"
        Me.BrowseZTS.Size = New System.Drawing.Size(136, 31)
        Me.BrowseZTS.TabIndex = 11
        Me.BrowseZTS.Text = "Browse for File"
        Me.BrowseZTS.UseVisualStyleBackColor = True
        Me.BrowseZTS.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(439, 26)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 18)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Mass (kg/day)"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.ToolTip1.SetToolTip(Me.Label12, "Daily mass released on ""Days On"".")
        '
        'WatershedAreaBox
        '
        Me.WatershedAreaBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WatershedAreaBox.Location = New System.Drawing.Point(180, 282)
        Me.WatershedAreaBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.WatershedAreaBox.Name = "WatershedAreaBox"
        Me.WatershedAreaBox.Size = New System.Drawing.Size(200, 23)
        Me.WatershedAreaBox.TabIndex = 36
        Me.WatershedAreaBox.Tag = "watershed area."
        Me.ToolTip1.SetToolTip(Me.WatershedAreaBox, "Area corresponding to the ZTS file.")
        Me.WatershedAreaBox.Visible = False
        '
        'ZTSFileBox
        '
        Me.ZTSFileBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZTSFileBox.Location = New System.Drawing.Point(89, 254)
        Me.ZTSFileBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ZTSFileBox.Name = "ZTSFileBox"
        Me.ZTSFileBox.Size = New System.Drawing.Size(472, 23)
        Me.ZTSFileBox.TabIndex = 12
        Me.ZTSFileBox.Tag = "ZTS file."
        Me.ZTSFileBox.Visible = False
        '
        'massReleaseBox1
        '
        Me.massReleaseBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.massReleaseBox1.Location = New System.Drawing.Point(441, 46)
        Me.massReleaseBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.massReleaseBox1.Name = "massReleaseBox1"
        Me.massReleaseBox1.Size = New System.Drawing.Size(105, 23)
        Me.massReleaseBox1.TabIndex = 15
        Me.massReleaseBox1.Tag = "mass released 1."
        Me.ToolTip1.SetToolTip(Me.massReleaseBox1, "Daily mass released on ""Days On"".")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(352, 26)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 18)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Days Off"
        Me.ToolTip1.SetToolTip(Me.Label11, "Number of consequetive days" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "when no mass is released")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(277, 26)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 18)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Days On"
        Me.ToolTip1.SetToolTip(Me.Label10, "Number of consequetive days" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "when mass is released.")
        '
        'daysOffBox1
        '
        Me.daysOffBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.daysOffBox1.Location = New System.Drawing.Point(355, 46)
        Me.daysOffBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.daysOffBox1.Name = "daysOffBox1"
        Me.daysOffBox1.Size = New System.Drawing.Size(59, 23)
        Me.daysOffBox1.TabIndex = 16
        Me.daysOffBox1.Tag = "days off 1."
        Me.ToolTip1.SetToolTip(Me.daysOffBox1, "Number of consequetive days" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "when no mass is released.")
        '
        'daysOnBox1
        '
        Me.daysOnBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.daysOnBox1.Location = New System.Drawing.Point(281, 46)
        Me.daysOnBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.daysOnBox1.Name = "daysOnBox1"
        Me.daysOnBox1.Size = New System.Drawing.Size(59, 23)
        Me.daysOnBox1.TabIndex = 14
        Me.daysOnBox1.Tag = "days on 1."
        Me.ToolTip1.SetToolTip(Me.daysOnBox1, "Number of consequetive days" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "when mass is released.")
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(133, 11)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(88, 18)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "Chemical ID"
        Me.ToolTip1.SetToolTip(Me.Label19, "Optional information")
        '
        'chemIdBox
        '
        Me.chemIdBox.Location = New System.Drawing.Point(245, 7)
        Me.chemIdBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chemIdBox.Name = "chemIdBox"
        Me.chemIdBox.Size = New System.Drawing.Size(315, 22)
        Me.chemIdBox.TabIndex = 32
        '
        'RefTempBenthBox
        '
        Me.RefTempBenthBox.Location = New System.Drawing.Point(363, 148)
        Me.RefTempBenthBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RefTempBenthBox.Name = "RefTempBenthBox"
        Me.RefTempBenthBox.Size = New System.Drawing.Size(49, 22)
        Me.RefTempBenthBox.TabIndex = 8
        Me.RefTempBenthBox.Tag = "benthic reference temperature."
        Me.ToolTip1.SetToolTip(Me.RefTempBenthBox, "Reference temperature for benthic halflife.")
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(65, 151)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(150, 18)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "Benthic Halflife (days)"
        Me.ToolTip1.SetToolTip(Me.Label18, "Whole system benthic halflife.")
        '
        'benthicBox
        '
        Me.benthicBox.Location = New System.Drawing.Point(245, 148)
        Me.benthicBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.benthicBox.Name = "benthicBox"
        Me.benthicBox.Size = New System.Drawing.Size(79, 22)
        Me.benthicBox.TabIndex = 7
        Me.benthicBox.Tag = "benthic halflife."
        Me.ToolTip1.SetToolTip(Me.benthicBox, "Whole system benthic halflife." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Independent of hydrolysis.")
        '
        'RefTempHydrBox
        '
        Me.RefTempHydrBox.Location = New System.Drawing.Point(363, 122)
        Me.RefTempHydrBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RefTempHydrBox.Name = "RefTempHydrBox"
        Me.RefTempHydrBox.Size = New System.Drawing.Size(49, 22)
        Me.RefTempHydrBox.TabIndex = 6
        Me.RefTempHydrBox.Tag = "hydrolysis reference temperature."
        Me.ToolTip1.SetToolTip(Me.RefTempHydrBox, "Reference temperature for hydrolysis halflife.")
        '
        'RefLatBox
        '
        Me.RefLatBox.Location = New System.Drawing.Point(363, 96)
        Me.RefLatBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RefLatBox.Name = "RefLatBox"
        Me.RefLatBox.Size = New System.Drawing.Size(49, 22)
        Me.RefLatBox.TabIndex = 4
        Me.RefLatBox.Tag = "photolysis refernce latitude"
        Me.ToolTip1.SetToolTip(Me.RefLatBox, "Reference latitude for photolysis halflife.")
        '
        'RefTempWaterBox
        '
        Me.RefTempWaterBox.Location = New System.Drawing.Point(363, 70)
        Me.RefTempWaterBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RefTempWaterBox.Name = "RefTempWaterBox"
        Me.RefTempWaterBox.Size = New System.Drawing.Size(49, 22)
        Me.RefTempWaterBox.TabIndex = 2
        Me.RefTempWaterBox.Tag = "water halflife reference temperature."
        Me.ToolTip1.SetToolTip(Me.RefTempWaterBox, "Reference temperature for water halflife.")
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(396, 41)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton2.Size = New System.Drawing.Size(47, 22)
        Me.RadioButton2.TabIndex = 15
        Me.RadioButton2.Text = "Kd"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'isKoc
        '
        Me.isKoc.AutoSize = True
        Me.isKoc.CausesValidation = False
        Me.isKoc.Checked = True
        Me.isKoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.isKoc.Location = New System.Drawing.Point(329, 41)
        Me.isKoc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.isKoc.Name = "isKoc"
        Me.isKoc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.isKoc.Size = New System.Drawing.Size(56, 22)
        Me.isKoc.TabIndex = 14
        Me.isKoc.TabStop = True
        Me.isKoc.Text = "Koc"
        Me.isKoc.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.isKoc.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 126)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Hydrolysis Halflife (days)"
        Me.ToolTip1.SetToolTip(Me.Label4, "Effective hydrolysis. ")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 100)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Photolysis Halflife (days)"
        Me.ToolTip1.SetToolTip(Me.Label3, "Near-surface photolysis. ")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 74)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Water Column Halflife (days)"
        Me.ToolTip1.SetToolTip(Me.Label2, "Acts on all forms of chemical in " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the water coulmn.  Independent" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of hydrolysis " &
        "and photolysis.")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Sorption Coefficient (ml/g)"
        '
        'hydrolBox
        '
        Me.hydrolBox.Location = New System.Drawing.Point(245, 122)
        Me.hydrolBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.hydrolBox.Name = "hydrolBox"
        Me.hydrolBox.Size = New System.Drawing.Size(79, 22)
        Me.hydrolBox.TabIndex = 5
        Me.hydrolBox.Tag = "hydrolysis."
        Me.ToolTip1.SetToolTip(Me.hydrolBox, "Effective hydrolysis. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Acts only on aqueous phase" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in both the ater column and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
        "benthic region.")
        '
        'photoBox
        '
        Me.photoBox.Location = New System.Drawing.Point(245, 96)
        Me.photoBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.photoBox.Name = "photoBox"
        Me.photoBox.Size = New System.Drawing.Size(79, 22)
        Me.photoBox.TabIndex = 3
        Me.photoBox.Tag = "photolysis."
        Me.ToolTip1.SetToolTip(Me.photoBox, "Near-surface photolysis. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Acts obnly on aqueous phase component.")
        '
        'waterMetabBox
        '
        Me.waterMetabBox.Location = New System.Drawing.Point(245, 70)
        Me.waterMetabBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.waterMetabBox.Name = "waterMetabBox"
        Me.waterMetabBox.Size = New System.Drawing.Size(79, 22)
        Me.waterMetabBox.TabIndex = 1
        Me.waterMetabBox.Tag = "water halflife."
        Me.ToolTip1.SetToolTip(Me.waterMetabBox, "Acts on all forms of chemical in ")
        '
        'sorptionBox
        '
        Me.sorptionBox.Location = New System.Drawing.Point(245, 39)
        Me.sorptionBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.sorptionBox.Name = "sorptionBox"
        Me.sorptionBox.Size = New System.Drawing.Size(79, 22)
        Me.sorptionBox.TabIndex = 0
        Me.sorptionBox.Tag = "sorption coefficient."
        Me.ToolTip1.SetToolTip(Me.sorptionBox, "Linear sorption coefficient.")
        '
        'Toxicity
        '
        Me.Toxicity.BackColor = System.Drawing.Color.Lavender
        Me.Toxicity.Controls.Add(Me.UserDefinedDaysWater)
        Me.Toxicity.Controls.Add(Me.CoCTotalUserBox)
        Me.Toxicity.Controls.Add(Me.Label97)
        Me.Toxicity.Controls.Add(Me.UserDefinedDaysBenthic)
        Me.Toxicity.Controls.Add(Me.Label98)
        Me.Toxicity.Controls.Add(Me.CocPoreWaterUserBox)
        Me.Toxicity.Controls.Add(Me.Label96)
        Me.Toxicity.Controls.Add(Me.Label95)
        Me.Toxicity.Controls.Add(Me.CoCTotal1Box)
        Me.Toxicity.Controls.Add(Me.CoCTotal3Box)
        Me.Toxicity.Controls.Add(Me.CoCTotal60Box)
        Me.Toxicity.Controls.Add(Me.CoCTotal28Box)
        Me.Toxicity.Controls.Add(Me.CoCTotal7Box)
        Me.Toxicity.Controls.Add(Me.Label94)
        Me.Toxicity.Controls.Add(Me.Label93)
        Me.Toxicity.Controls.Add(Me.CocUserWaterBox)
        Me.Toxicity.Controls.Add(Me.CocPoreWater1box)
        Me.Toxicity.Controls.Add(Me.Label84)
        Me.Toxicity.Controls.Add(Me.CocPoreWater3box)
        Me.Toxicity.Controls.Add(Me.CoC2box)
        Me.Toxicity.Controls.Add(Me.CoC1box)
        Me.Toxicity.Controls.Add(Me.Label85)
        Me.Toxicity.Controls.Add(Me.Label79)
        Me.Toxicity.Controls.Add(Me.CocPoreWater60box)
        Me.Toxicity.Controls.Add(Me.Label78)
        Me.Toxicity.Controls.Add(Me.Label59)
        Me.Toxicity.Controls.Add(Me.CocPoreWater28box)
        Me.Toxicity.Controls.Add(Me.Label58)
        Me.Toxicity.Controls.Add(Me.CocPoreWater7box)
        Me.Toxicity.Controls.Add(Me.Label73)
        Me.Toxicity.Controls.Add(Me.Coc28box)
        Me.Toxicity.Controls.Add(Me.Label72)
        Me.Toxicity.Controls.Add(Me.CoC60box)
        Me.Toxicity.Controls.Add(Me.Label71)
        Me.Toxicity.Controls.Add(Me.Coc21box)
        Me.Toxicity.Controls.Add(Me.Label70)
        Me.Toxicity.Controls.Add(Me.Coc7box)
        Me.Toxicity.Controls.Add(Me.Label69)
        Me.Toxicity.Controls.Add(Me.CoC4box)
        Me.Toxicity.Controls.Add(Me.Label68)
        Me.Toxicity.Controls.Add(Me.CoC3box)
        Me.Toxicity.Controls.Add(Me.isToxicityAnalysis)
        Me.Toxicity.Controls.Add(Me.Label61)
        Me.Toxicity.Controls.Add(Me.Label60)
        Me.Toxicity.Controls.Add(Me.Label39)
        Me.Toxicity.Location = New System.Drawing.Point(4, 25)
        Me.Toxicity.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Toxicity.Name = "Toxicity"
        Me.Toxicity.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Toxicity.Size = New System.Drawing.Size(765, 709)
        Me.Toxicity.TabIndex = 1
        Me.Toxicity.Text = "Toxicity"
        '
        'UserDefinedDaysWater
        '
        Me.UserDefinedDaysWater.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserDefinedDaysWater.Location = New System.Drawing.Point(237, 281)
        Me.UserDefinedDaysWater.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UserDefinedDaysWater.Name = "UserDefinedDaysWater"
        Me.UserDefinedDaysWater.Size = New System.Drawing.Size(45, 24)
        Me.UserDefinedDaysWater.TabIndex = 35
        Me.UserDefinedDaysWater.Tag = "user-defined water days."
        Me.UserDefinedDaysWater.Text = "90"
        Me.UserDefinedDaysWater.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CoCTotalUserBox
        '
        Me.CoCTotalUserBox.Location = New System.Drawing.Point(432, 576)
        Me.CoCTotalUserBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CoCTotalUserBox.Name = "CoCTotalUserBox"
        Me.CoCTotalUserBox.Size = New System.Drawing.Size(99, 22)
        Me.CoCTotalUserBox.TabIndex = 48
        Me.CoCTotalUserBox.Tag = "toxicity CoC."
        Me.CoCTotalUserBox.Text = "0.0"
        Me.CoCTotalUserBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label97.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label97.Location = New System.Drawing.Point(52, 580)
        Me.Label97.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(98, 18)
        Me.Label97.TabIndex = 47
        Me.Label97.Text = "User Defined:"
        '
        'UserDefinedDaysBenthic
        '
        Me.UserDefinedDaysBenthic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserDefinedDaysBenthic.Location = New System.Drawing.Point(169, 576)
        Me.UserDefinedDaysBenthic.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UserDefinedDaysBenthic.Name = "UserDefinedDaysBenthic"
        Me.UserDefinedDaysBenthic.Size = New System.Drawing.Size(45, 24)
        Me.UserDefinedDaysBenthic.TabIndex = 46
        Me.UserDefinedDaysBenthic.Tag = "user-defined toxicity benthic days."
        Me.UserDefinedDaysBenthic.Text = "90"
        Me.UserDefinedDaysBenthic.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label98.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label98.Location = New System.Drawing.Point(212, 580)
        Me.Label98.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(67, 18)
        Me.Label98.TabIndex = 45
        Me.Label98.Text = "-Day Avg"
        '
        'CocPoreWaterUserBox
        '
        Me.CocPoreWaterUserBox.Location = New System.Drawing.Point(305, 576)
        Me.CocPoreWaterUserBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CocPoreWaterUserBox.Name = "CocPoreWaterUserBox"
        Me.CocPoreWaterUserBox.Size = New System.Drawing.Size(99, 22)
        Me.CocPoreWaterUserBox.TabIndex = 44
        Me.CocPoreWaterUserBox.Tag = "toxicity CoC."
        Me.CocPoreWaterUserBox.Text = "0.0"
        Me.CocPoreWaterUserBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label96.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label96.Location = New System.Drawing.Point(428, 412)
        Me.Label96.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(113, 34)
        Me.Label96.TabIndex = 43
        Me.Label96.Text = "Total/Dry Sed " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    (μg/kg)"
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label95.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label95.Location = New System.Drawing.Point(300, 412)
        Me.Label95.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(95, 34)
        Me.Label95.TabIndex = 42
        Me.Label95.Text = "Pore Water " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   (μg/L)"
        '
        'CoCTotal1Box
        '
        Me.CoCTotal1Box.Location = New System.Drawing.Point(432, 448)
        Me.CoCTotal1Box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CoCTotal1Box.Name = "CoCTotal1Box"
        Me.CoCTotal1Box.Size = New System.Drawing.Size(99, 22)
        Me.CoCTotal1Box.TabIndex = 41
        Me.CoCTotal1Box.Tag = "toxicity CoC."
        Me.CoCTotal1Box.Text = "0.0"
        Me.CoCTotal1Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CoCTotal3Box
        '
        Me.CoCTotal3Box.Location = New System.Drawing.Point(432, 473)
        Me.CoCTotal3Box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CoCTotal3Box.Name = "CoCTotal3Box"
        Me.CoCTotal3Box.Size = New System.Drawing.Size(99, 22)
        Me.CoCTotal3Box.TabIndex = 40
        Me.CoCTotal3Box.Tag = "toxicity CoC."
        Me.CoCTotal3Box.Text = "0.0"
        Me.CoCTotal3Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CoCTotal60Box
        '
        Me.CoCTotal60Box.Location = New System.Drawing.Point(432, 546)
        Me.CoCTotal60Box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CoCTotal60Box.Name = "CoCTotal60Box"
        Me.CoCTotal60Box.Size = New System.Drawing.Size(99, 22)
        Me.CoCTotal60Box.TabIndex = 39
        Me.CoCTotal60Box.Tag = "toxicity CoC."
        Me.CoCTotal60Box.Text = "0.0"
        Me.CoCTotal60Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CoCTotal28Box
        '
        Me.CoCTotal28Box.Location = New System.Drawing.Point(432, 522)
        Me.CoCTotal28Box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CoCTotal28Box.Name = "CoCTotal28Box"
        Me.CoCTotal28Box.Size = New System.Drawing.Size(99, 22)
        Me.CoCTotal28Box.TabIndex = 38
        Me.CoCTotal28Box.Tag = "toxicity CoC."
        Me.CoCTotal28Box.Text = "0.0"
        Me.CoCTotal28Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CoCTotal7Box
        '
        Me.CoCTotal7Box.Location = New System.Drawing.Point(432, 497)
        Me.CoCTotal7Box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CoCTotal7Box.Name = "CoCTotal7Box"
        Me.CoCTotal7Box.Size = New System.Drawing.Size(99, 22)
        Me.CoCTotal7Box.TabIndex = 37
        Me.CoCTotal7Box.Tag = "toxicity CoC."
        Me.CoCTotal7Box.Text = "0.0"
        Me.CoCTotal7Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label94.Location = New System.Drawing.Point(116, 284)
        Me.Label94.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(98, 18)
        Me.Label94.TabIndex = 36
        Me.Label94.Text = "User Defined:"
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label93.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label93.Location = New System.Drawing.Point(281, 284)
        Me.Label93.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(67, 18)
        Me.Label93.TabIndex = 34
        Me.Label93.Text = "-Day Avg"
        '
        'CocUserWaterBox
        '
        Me.CocUserWaterBox.Location = New System.Drawing.Point(375, 281)
        Me.CocUserWaterBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CocUserWaterBox.Name = "CocUserWaterBox"
        Me.CocUserWaterBox.Size = New System.Drawing.Size(99, 22)
        Me.CocUserWaterBox.TabIndex = 33
        Me.CocUserWaterBox.Tag = "toxicity CoC."
        Me.CocUserWaterBox.Text = "0.0"
        Me.CocUserWaterBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CocPoreWater1box
        '
        Me.CocPoreWater1box.Location = New System.Drawing.Point(304, 448)
        Me.CocPoreWater1box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CocPoreWater1box.Name = "CocPoreWater1box"
        Me.CocPoreWater1box.Size = New System.Drawing.Size(99, 22)
        Me.CocPoreWater1box.TabIndex = 32
        Me.CocPoreWater1box.Tag = "toxicity CoC."
        Me.CocPoreWater1box.Text = "0.0"
        Me.CocPoreWater1box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label84.Location = New System.Drawing.Point(144, 476)
        Me.Label84.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(128, 18)
        Me.Label84.TabIndex = 31
        Me.Label84.Text = "3-Day Benthic Avg"
        '
        'CocPoreWater3box
        '
        Me.CocPoreWater3box.Location = New System.Drawing.Point(304, 473)
        Me.CocPoreWater3box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CocPoreWater3box.Name = "CocPoreWater3box"
        Me.CocPoreWater3box.Size = New System.Drawing.Size(99, 22)
        Me.CocPoreWater3box.TabIndex = 30
        Me.CocPoreWater3box.Tag = "toxicity CoC."
        Me.CocPoreWater3box.Text = "0.0"
        Me.CocPoreWater3box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CoC2box
        '
        Me.CoC2box.Location = New System.Drawing.Point(375, 103)
        Me.CoC2box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CoC2box.Name = "CoC2box"
        Me.CoC2box.Size = New System.Drawing.Size(99, 22)
        Me.CoC2box.TabIndex = 29
        Me.CoC2box.Tag = "toxicity CoC."
        Me.CoC2box.Text = "0.0"
        Me.CoC2box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CoC1box
        '
        Me.CoC1box.Location = New System.Drawing.Point(375, 79)
        Me.CoC1box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CoC1box.Name = "CoC1box"
        Me.CoC1box.Size = New System.Drawing.Size(99, 22)
        Me.CoC1box.TabIndex = 28
        Me.CoC1box.Tag = "toxicity CoC."
        Me.CoC1box.Text = "0.0"
        Me.CoC1box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label85.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label85.Location = New System.Drawing.Point(136, 52)
        Me.Label85.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(406, 20)
        Me.Label85.TabIndex = 27
        Me.Label85.Text = "Water Column Concentration of Concern (μg/L)"
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label79.Location = New System.Drawing.Point(271, 379)
        Me.Label79.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(294, 20)
        Me.Label79.TabIndex = 25
        Me.Label79.Text = "Benthic Concentration of Concern"
        '
        'CocPoreWater60box
        '
        Me.CocPoreWater60box.Location = New System.Drawing.Point(304, 546)
        Me.CocPoreWater60box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CocPoreWater60box.Name = "CocPoreWater60box"
        Me.CocPoreWater60box.Size = New System.Drawing.Size(99, 22)
        Me.CocPoreWater60box.TabIndex = 24
        Me.CocPoreWater60box.Tag = "toxicity CoC."
        Me.CocPoreWater60box.Text = "0.0"
        Me.CocPoreWater60box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label78.Location = New System.Drawing.Point(144, 452)
        Me.Label78.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(128, 18)
        Me.Label78.TabIndex = 23
        Me.Label78.Text = "1-Day Benthic Avg"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label59.Location = New System.Drawing.Point(140, 526)
        Me.Label59.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(130, 18)
        Me.Label59.TabIndex = 22
        Me.Label59.Text = "28-Day benthicAvg"
        '
        'CocPoreWater28box
        '
        Me.CocPoreWater28box.Location = New System.Drawing.Point(304, 522)
        Me.CocPoreWater28box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CocPoreWater28box.Name = "CocPoreWater28box"
        Me.CocPoreWater28box.Size = New System.Drawing.Size(99, 22)
        Me.CocPoreWater28box.TabIndex = 21
        Me.CocPoreWater28box.Tag = "toxicity CoC."
        Me.CocPoreWater28box.Text = "0.0"
        Me.CocPoreWater28box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label58.Location = New System.Drawing.Point(135, 550)
        Me.Label58.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(136, 18)
        Me.Label58.TabIndex = 20
        Me.Label58.Text = "60-Day Benthic Avg"
        '
        'CocPoreWater7box
        '
        Me.CocPoreWater7box.Location = New System.Drawing.Point(304, 497)
        Me.CocPoreWater7box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CocPoreWater7box.Name = "CocPoreWater7box"
        Me.CocPoreWater7box.Size = New System.Drawing.Size(99, 22)
        Me.CocPoreWater7box.TabIndex = 19
        Me.CocPoreWater7box.Tag = "toxicity CoC."
        Me.CocPoreWater7box.Text = "0.0"
        Me.CocPoreWater7box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label73.Location = New System.Drawing.Point(263, 230)
        Me.Label73.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(83, 18)
        Me.Label73.TabIndex = 18
        Me.Label73.Text = "28-Day Avg"
        '
        'Coc28box
        '
        Me.Coc28box.Location = New System.Drawing.Point(375, 226)
        Me.Coc28box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Coc28box.Name = "Coc28box"
        Me.Coc28box.Size = New System.Drawing.Size(99, 22)
        Me.Coc28box.TabIndex = 17
        Me.Coc28box.Tag = "toxicity CoC."
        Me.Coc28box.Text = "0.0"
        Me.Coc28box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label72.Location = New System.Drawing.Point(263, 255)
        Me.Label72.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(83, 18)
        Me.Label72.TabIndex = 16
        Me.Label72.Text = "60-Day Avg"
        '
        'CoC60box
        '
        Me.CoC60box.Location = New System.Drawing.Point(375, 251)
        Me.CoC60box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CoC60box.Name = "CoC60box"
        Me.CoC60box.Size = New System.Drawing.Size(99, 22)
        Me.CoC60box.TabIndex = 15
        Me.CoC60box.Tag = "toxicity CoC."
        Me.CoC60box.Text = "0.0"
        Me.CoC60box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label71.Location = New System.Drawing.Point(263, 206)
        Me.Label71.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(83, 18)
        Me.Label71.TabIndex = 14
        Me.Label71.Text = "21-Day Avg"
        '
        'Coc21box
        '
        Me.Coc21box.Location = New System.Drawing.Point(375, 202)
        Me.Coc21box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Coc21box.Name = "Coc21box"
        Me.Coc21box.Size = New System.Drawing.Size(99, 22)
        Me.Coc21box.TabIndex = 13
        Me.Coc21box.Tag = "toxicity CoC."
        Me.Coc21box.Text = "0.0"
        Me.Coc21box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label70.Location = New System.Drawing.Point(272, 181)
        Me.Label70.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(75, 18)
        Me.Label70.TabIndex = 12
        Me.Label70.Text = "7-Day Avg"
        '
        'Coc7box
        '
        Me.Coc7box.Location = New System.Drawing.Point(375, 177)
        Me.Coc7box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Coc7box.Name = "Coc7box"
        Me.Coc7box.Size = New System.Drawing.Size(99, 22)
        Me.Coc7box.TabIndex = 11
        Me.Coc7box.Tag = "toxicity CoC."
        Me.Coc7box.Text = "0.0"
        Me.Coc7box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label69.Location = New System.Drawing.Point(272, 156)
        Me.Label69.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(75, 18)
        Me.Label69.TabIndex = 10
        Me.Label69.Text = "4-Day Avg"
        '
        'CoC4box
        '
        Me.CoC4box.Location = New System.Drawing.Point(375, 153)
        Me.CoC4box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CoC4box.Name = "CoC4box"
        Me.CoC4box.Size = New System.Drawing.Size(99, 22)
        Me.CoC4box.TabIndex = 9
        Me.CoC4box.Tag = "toxicity CoC."
        Me.CoC4box.Text = "0.0"
        Me.CoC4box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label68.Location = New System.Drawing.Point(272, 132)
        Me.Label68.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(75, 18)
        Me.Label68.TabIndex = 8
        Me.Label68.Text = "3-Day Avg"
        '
        'CoC3box
        '
        Me.CoC3box.Location = New System.Drawing.Point(375, 128)
        Me.CoC3box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CoC3box.Name = "CoC3box"
        Me.CoC3box.Size = New System.Drawing.Size(99, 22)
        Me.CoC3box.TabIndex = 7
        Me.CoC3box.Tag = "toxicity CoC."
        Me.CoC3box.Text = "0.0"
        Me.CoC3box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'isToxicityAnalysis
        '
        Me.isToxicityAnalysis.AutoSize = True
        Me.isToxicityAnalysis.Location = New System.Drawing.Point(257, 22)
        Me.isToxicityAnalysis.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.isToxicityAnalysis.Name = "isToxicityAnalysis"
        Me.isToxicityAnalysis.Size = New System.Drawing.Size(155, 21)
        Me.isToxicityAnalysis.TabIndex = 6
        Me.isToxicityAnalysis.Text = "Do Toxicity Analysis"
        Me.isToxicityAnalysis.UseVisualStyleBackColor = True
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label61.Location = New System.Drawing.Point(144, 501)
        Me.Label61.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(128, 18)
        Me.Label61.TabIndex = 5
        Me.Label61.Text = "7-Day Benthic Avg"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label60.Location = New System.Drawing.Point(272, 107)
        Me.Label60.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(75, 18)
        Me.Label60.TabIndex = 4
        Me.Label60.Text = "2-Day Avg"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label39.Location = New System.Drawing.Point(219, 85)
        Me.Label39.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(125, 18)
        Me.Label39.TabIndex = 0
        Me.Label39.Text = "Acute (1 Day Avg)"
        '
        'Scenario2Tab
        '
        Me.Scenario2Tab.BackColor = System.Drawing.Color.Wheat
        Me.Scenario2Tab.Controls.Add(Me.Label117)
        Me.Scenario2Tab.Controls.Add(Me.FlowAveraging)
        Me.Scenario2Tab.Controls.Add(Me.GetWeather)
        Me.Scenario2Tab.Controls.Add(Me.weatherBox)
        Me.Scenario2Tab.Controls.Add(Me.Label81)
        Me.Scenario2Tab.Controls.Add(Me.benthicdepthBox)
        Me.Scenario2Tab.Controls.Add(Me.Label21)
        Me.Scenario2Tab.Controls.Add(Me.massXferBox)
        Me.Scenario2Tab.Controls.Add(Me.biomass2Box)
        Me.Scenario2Tab.Controls.Add(Me.scenarioIdBox)
        Me.Scenario2Tab.Controls.Add(Me.Label25)
        Me.Scenario2Tab.Controls.Add(Me.Label37)
        Me.Scenario2Tab.Controls.Add(Me.Label17)
        Me.Scenario2Tab.Controls.Add(Me.DOC2Box)
        Me.Scenario2Tab.Controls.Add(Me.Label34)
        Me.Scenario2Tab.Controls.Add(Me.Label16)
        Me.Scenario2Tab.Controls.Add(Me.Label29)
        Me.Scenario2Tab.Controls.Add(Me.foc2Box)
        Me.Scenario2Tab.Controls.Add(Me.Label15)
        Me.Scenario2Tab.Controls.Add(Me.Label27)
        Me.Scenario2Tab.Controls.Add(Me.Label30)
        Me.Scenario2Tab.Controls.Add(Me.lengthBox)
        Me.Scenario2Tab.Controls.Add(Me.bdBox)
        Me.Scenario2Tab.Controls.Add(Me.porosityBox)
        Me.Scenario2Tab.Controls.Add(Me.depthBox)
        Me.Scenario2Tab.Controls.Add(Me.Label28)
        Me.Scenario2Tab.Controls.Add(Me.constFlowBox)
        Me.Scenario2Tab.Controls.Add(Me.Label82)
        Me.Scenario2Tab.Controls.Add(Me.widthBox)
        Me.Scenario2Tab.Controls.Add(Me.Label31)
        Me.Scenario2Tab.Controls.Add(Me.is_ConstFlow)
        Me.Scenario2Tab.Controls.Add(Me.ssBox)
        Me.Scenario2Tab.Controls.Add(Me.noBaseFlow)
        Me.Scenario2Tab.Controls.Add(Me.Biomass1Box)
        Me.Scenario2Tab.Controls.Add(Me.Label26)
        Me.Scenario2Tab.Controls.Add(Me.Label36)
        Me.Scenario2Tab.Controls.Add(Me.foc1Box)
        Me.Scenario2Tab.Controls.Add(Me.dfacBox)
        Me.Scenario2Tab.Controls.Add(Me.ChlorophyllBox)
        Me.Scenario2Tab.Controls.Add(Me.Label35)
        Me.Scenario2Tab.Controls.Add(Me.Label32)
        Me.Scenario2Tab.Controls.Add(Me.Label33)
        Me.Scenario2Tab.Controls.Add(Me.DOC1Box)
        Me.Scenario2Tab.Location = New System.Drawing.Point(4, 25)
        Me.Scenario2Tab.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Scenario2Tab.Name = "Scenario2Tab"
        Me.Scenario2Tab.Size = New System.Drawing.Size(765, 709)
        Me.Scenario2Tab.TabIndex = 2
        Me.Scenario2Tab.Text = "Scenario"
        '
        'GetWeather
        '
        Me.GetWeather.Location = New System.Drawing.Point(51, 42)
        Me.GetWeather.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GetWeather.Name = "GetWeather"
        Me.GetWeather.Size = New System.Drawing.Size(105, 28)
        Me.GetWeather.TabIndex = 23
        Me.GetWeather.Text = "Get Weather"
        Me.GetWeather.UseVisualStyleBackColor = True
        '
        'weatherBox
        '
        Me.weatherBox.Location = New System.Drawing.Point(179, 44)
        Me.weatherBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.weatherBox.Name = "weatherBox"
        Me.weatherBox.Size = New System.Drawing.Size(369, 22)
        Me.weatherBox.TabIndex = 22
        Me.weatherBox.Tag = "Weather File"
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.Location = New System.Drawing.Point(392, 342)
        Me.Label81.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(150, 17)
        Me.Label81.TabIndex = 59
        Me.Label81.Text = "Benthic Parameters"
        '
        'benthicdepthBox
        '
        Me.benthicdepthBox.Location = New System.Drawing.Point(484, 368)
        Me.benthicdepthBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.benthicdepthBox.Name = "benthicdepthBox"
        Me.benthicdepthBox.Size = New System.Drawing.Size(63, 22)
        Me.benthicdepthBox.TabIndex = 58
        Me.benthicdepthBox.Tag = "benthic depth."
        Me.benthicdepthBox.Text = "0.05"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(72, 16)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(81, 17)
        Me.Label21.TabIndex = 21
        Me.Label21.Text = "Scenario ID"
        '
        'massXferBox
        '
        Me.massXferBox.Location = New System.Drawing.Point(343, 551)
        Me.massXferBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.massXferBox.Name = "massXferBox"
        Me.massXferBox.Size = New System.Drawing.Size(63, 22)
        Me.massXferBox.TabIndex = 46
        Me.massXferBox.Text = "1e-8"
        '
        'biomass2Box
        '
        Me.biomass2Box.Location = New System.Drawing.Point(484, 491)
        Me.biomass2Box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.biomass2Box.Name = "biomass2Box"
        Me.biomass2Box.Size = New System.Drawing.Size(63, 22)
        Me.biomass2Box.TabIndex = 56
        Me.biomass2Box.Tag = "benthic biomass."
        Me.biomass2Box.Text = "0.006"
        '
        'scenarioIdBox
        '
        Me.scenarioIdBox.Location = New System.Drawing.Point(179, 12)
        Me.scenarioIdBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.scenarioIdBox.Name = "scenarioIdBox"
        Me.scenarioIdBox.Size = New System.Drawing.Size(369, 22)
        Me.scenarioIdBox.TabIndex = 20
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(115, 555)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(205, 17)
        Me.Label25.TabIndex = 45
        Me.Label25.Text = "Mass Transfer Coefficient (m/s)"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(317, 496)
        Me.Label37.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(157, 17)
        Me.Label37.TabIndex = 55
        Me.Label37.Text = "Benthic Biomass (g/m2)"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(167, 142)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 17)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Length (m)"
        Me.ToolTip1.SetToolTip(Me.Label17, "Default length is 30 m , but should  represents flowing water dispersivity")
        '
        'DOC2Box
        '
        Me.DOC2Box.Location = New System.Drawing.Point(484, 466)
        Me.DOC2Box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DOC2Box.Name = "DOC2Box"
        Me.DOC2Box.Size = New System.Drawing.Size(63, 22)
        Me.DOC2Box.TabIndex = 53
        Me.DOC2Box.Tag = "benthic DOC."
        Me.DOC2Box.Text = "5.0"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(339, 470)
        Me.Label34.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(134, 17)
        Me.Label34.TabIndex = 54
        Me.Label34.Text = "Benthic DOC (mg/L)"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(172, 114)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 17)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Depth (m)"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(353, 373)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(122, 17)
        Me.Label29.TabIndex = 57
        Me.Label29.Text = "Benthic Depth (m)"
        '
        'foc2Box
        '
        Me.foc2Box.Location = New System.Drawing.Point(484, 442)
        Me.foc2Box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.foc2Box.Name = "foc2Box"
        Me.foc2Box.Size = New System.Drawing.Size(63, 22)
        Me.foc2Box.TabIndex = 48
        Me.foc2Box.Tag = "benthic foc."
        Me.foc2Box.Text = "0.04"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(173, 87)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 17)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Width (m)"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(395, 447)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(78, 17)
        Me.Label27.TabIndex = 47
        Me.Label27.Text = "Benthic foc"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(335, 422)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(135, 17)
        Me.Label30.TabIndex = 52
        Me.Label30.Text = "Bulk Density (g/cm³)"
        '
        'lengthBox
        '
        Me.lengthBox.Location = New System.Drawing.Point(253, 137)
        Me.lengthBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lengthBox.Name = "lengthBox"
        Me.lengthBox.Size = New System.Drawing.Size(125, 22)
        Me.lengthBox.TabIndex = 16
        Me.lengthBox.Tag = "length."
        Me.ToolTip1.SetToolTip(Me.lengthBox, "Length of Water body. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Should consider dispersivity" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "when choosing this value fo" &
        "r" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a flowing water body.")
        '
        'bdBox
        '
        Me.bdBox.Location = New System.Drawing.Point(484, 417)
        Me.bdBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bdBox.Name = "bdBox"
        Me.bdBox.Size = New System.Drawing.Size(63, 22)
        Me.bdBox.TabIndex = 51
        Me.bdBox.Tag = "bulk density."
        Me.bdBox.Text = "1.35"
        '
        'porosityBox
        '
        Me.porosityBox.Location = New System.Drawing.Point(484, 393)
        Me.porosityBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.porosityBox.Name = "porosityBox"
        Me.porosityBox.Size = New System.Drawing.Size(63, 22)
        Me.porosityBox.TabIndex = 49
        Me.porosityBox.Tag = "benthic porosity."
        Me.porosityBox.Text = "0.50"
        '
        'depthBox
        '
        Me.depthBox.Location = New System.Drawing.Point(253, 110)
        Me.depthBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.depthBox.Name = "depthBox"
        Me.depthBox.Size = New System.Drawing.Size(125, 22)
        Me.depthBox.TabIndex = 15
        Me.depthBox.Tag = "depth."
        Me.ToolTip1.SetToolTip(Me.depthBox, "Depth of water body.")
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(365, 398)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(110, 17)
        Me.Label28.TabIndex = 50
        Me.Label28.Text = "Benthic Porosity"
        '
        'constFlowBox
        '
        Me.constFlowBox.Location = New System.Drawing.Point(347, 185)
        Me.constFlowBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.constFlowBox.Name = "constFlowBox"
        Me.constFlowBox.Size = New System.Drawing.Size(124, 22)
        Me.constFlowBox.TabIndex = 7
        Me.constFlowBox.Tag = "constant flow rate."
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.Location = New System.Drawing.Point(87, 342)
        Me.Label82.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(197, 17)
        Me.Label82.TabIndex = 44
        Me.Label82.Text = "Water Column Parameters"
        '
        'widthBox
        '
        Me.widthBox.Location = New System.Drawing.Point(253, 82)
        Me.widthBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.widthBox.Name = "widthBox"
        Me.widthBox.Size = New System.Drawing.Size(125, 22)
        Me.widthBox.TabIndex = 14
        Me.widthBox.Tag = "width."
        Me.ToolTip1.SetToolTip(Me.widthBox, "Width of water body")
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(47, 400)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(160, 17)
        Me.Label31.TabIndex = 34
        Me.Label31.Text = "Water ColumnSS (mg/L)"
        '
        'is_ConstFlow
        '
        Me.is_ConstFlow.AutoSize = True
        Me.is_ConstFlow.Location = New System.Drawing.Point(100, 186)
        Me.is_ConstFlow.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.is_ConstFlow.Name = "is_ConstFlow"
        Me.is_ConstFlow.Size = New System.Drawing.Size(237, 21)
        Me.is_ConstFlow.TabIndex = 9
        Me.is_ConstFlow.TabStop = True
        Me.is_ConstFlow.Text = "Use Constant Flow Rate (m³/day)"
        Me.is_ConstFlow.UseVisualStyleBackColor = True
        '
        'ssBox
        '
        Me.ssBox.Location = New System.Drawing.Point(217, 395)
        Me.ssBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ssBox.Name = "ssBox"
        Me.ssBox.Size = New System.Drawing.Size(63, 22)
        Me.ssBox.TabIndex = 35
        Me.ssBox.Tag = "SS."
        Me.ssBox.Text = "30"
        '
        'noBaseFlow
        '
        Me.noBaseFlow.AutoSize = True
        Me.noBaseFlow.Location = New System.Drawing.Point(100, 222)
        Me.noBaseFlow.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.noBaseFlow.Name = "noBaseFlow"
        Me.noBaseFlow.Size = New System.Drawing.Size(119, 21)
        Me.noBaseFlow.TabIndex = 10
        Me.noBaseFlow.TabStop = True
        Me.noBaseFlow.Text = "No Base Flow "
        Me.noBaseFlow.UseVisualStyleBackColor = True
        '
        'Biomass1Box
        '
        Me.Biomass1Box.Location = New System.Drawing.Point(217, 494)
        Me.Biomass1Box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Biomass1Box.Name = "Biomass1Box"
        Me.Biomass1Box.Size = New System.Drawing.Size(63, 22)
        Me.Biomass1Box.TabIndex = 43
        Me.Biomass1Box.Tag = "water column biomass."
        Me.Biomass1Box.Text = "0.4"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(87, 449)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(120, 17)
        Me.Label26.TabIndex = 33
        Me.Label26.Text = "Water Column foc"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(9, 498)
        Me.Label36.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(199, 17)
        Me.Label36.TabIndex = 42
        Me.Label36.Text = "Water Column Biomass (mg/L)"
        '
        'foc1Box
        '
        Me.foc1Box.Location = New System.Drawing.Point(217, 444)
        Me.foc1Box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.foc1Box.Name = "foc1Box"
        Me.foc1Box.Size = New System.Drawing.Size(63, 22)
        Me.foc1Box.TabIndex = 32
        Me.foc1Box.Tag = "water column foc."
        Me.foc1Box.Text = "0.04"
        '
        'dfacBox
        '
        Me.dfacBox.Location = New System.Drawing.Point(217, 370)
        Me.dfacBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dfacBox.Name = "dfacBox"
        Me.dfacBox.Size = New System.Drawing.Size(63, 22)
        Me.dfacBox.TabIndex = 40
        Me.dfacBox.Tag = "DFAC."
        Me.dfacBox.Text = "1.19"
        '
        'ChlorophyllBox
        '
        Me.ChlorophyllBox.Location = New System.Drawing.Point(217, 420)
        Me.ChlorophyllBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChlorophyllBox.Name = "ChlorophyllBox"
        Me.ChlorophyllBox.Size = New System.Drawing.Size(63, 22)
        Me.ChlorophyllBox.TabIndex = 36
        Me.ChlorophyllBox.Tag = "chlorophyll."
        Me.ChlorophyllBox.Text = "0.005"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(163, 375)
        Me.Label35.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(44, 17)
        Me.Label35.TabIndex = 41
        Me.Label35.Text = "DFAC"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(87, 425)
        Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(123, 17)
        Me.Label32.TabIndex = 37
        Me.Label32.Text = "Chlorophyll (mg/L)"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(31, 474)
        Me.Label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(176, 17)
        Me.Label33.TabIndex = 39
        Me.Label33.Text = "Water Column DOC (mg/L)"
        '
        'DOC1Box
        '
        Me.DOC1Box.Location = New System.Drawing.Point(217, 469)
        Me.DOC1Box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DOC1Box.Name = "DOC1Box"
        Me.DOC1Box.Size = New System.Drawing.Size(63, 22)
        Me.DOC1Box.TabIndex = 38
        Me.DOC1Box.Tag = "water column DOC."
        Me.DOC1Box.Text = "5.0"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage1.Controls.Add(Me.UserDaysBenthic)
        Me.TabPage1.Controls.Add(Me.Label77)
        Me.TabPage1.Controls.Add(Me.Label104)
        Me.TabPage1.Controls.Add(Me.totalCocExceedUser)
        Me.TabPage1.Controls.Add(Me.totalconcUser)
        Me.TabPage1.Controls.Add(Me.totalconc7)
        Me.TabPage1.Controls.Add(Me.totalconc1)
        Me.TabPage1.Controls.Add(Me.totalCocExceed3)
        Me.TabPage1.Controls.Add(Me.totalconc3)
        Me.TabPage1.Controls.Add(Me.totalCocExceed60)
        Me.TabPage1.Controls.Add(Me.totalconc60)
        Me.TabPage1.Controls.Add(Me.totalCocExceed28)
        Me.TabPage1.Controls.Add(Me.totalconc28)
        Me.TabPage1.Controls.Add(Me.Label105)
        Me.TabPage1.Controls.Add(Me.totalCocExceed7)
        Me.TabPage1.Controls.Add(Me.totalCocExceed1)
        Me.TabPage1.Controls.Add(Me.Label103)
        Me.TabPage1.Controls.Add(Me.Label102)
        Me.TabPage1.Controls.Add(Me.Label101)
        Me.TabPage1.Controls.Add(Me.pwcocUserExceed)
        Me.TabPage1.Controls.Add(Me.pwconcUserbox)
        Me.TabPage1.Controls.Add(Me.UserDaysWater)
        Me.TabPage1.Controls.Add(Me.cocUserexceed)
        Me.TabPage1.Controls.Add(Me.Label99)
        Me.TabPage1.Controls.Add(Me.concUserBox)
        Me.TabPage1.Controls.Add(Me.pwconc7box)
        Me.TabPage1.Controls.Add(Me.pwconc1box)
        Me.TabPage1.Controls.Add(Me.conc7box)
        Me.TabPage1.Controls.Add(Me.conc1box)
        Me.TabPage1.Controls.Add(Me.pwcoc3exceed)
        Me.TabPage1.Controls.Add(Me.Label86)
        Me.TabPage1.Controls.Add(Me.pwconc3box)
        Me.TabPage1.Controls.Add(Me.pwcoc60exceed)
        Me.TabPage1.Controls.Add(Me.Label83)
        Me.TabPage1.Controls.Add(Me.pwconc60box)
        Me.TabPage1.Controls.Add(Me.pwcoc28exceed)
        Me.TabPage1.Controls.Add(Me.Label80)
        Me.TabPage1.Controls.Add(Me.pwconc28box)
        Me.TabPage1.Controls.Add(Me.Label76)
        Me.TabPage1.Controls.Add(Me.pwcoc7exceed)
        Me.TabPage1.Controls.Add(Me.pwcoc1exceed)
        Me.TabPage1.Controls.Add(Me.Label75)
        Me.TabPage1.Controls.Add(Me.Label74)
        Me.TabPage1.Controls.Add(Me.coc21exceed)
        Me.TabPage1.Controls.Add(Me.coc60exceed)
        Me.TabPage1.Controls.Add(Me.coc28exceed)
        Me.TabPage1.Controls.Add(Me.coc2exceed)
        Me.TabPage1.Controls.Add(Me.coc4exceed)
        Me.TabPage1.Controls.Add(Me.coc3exceed)
        Me.TabPage1.Controls.Add(Me.coc7exceed)
        Me.TabPage1.Controls.Add(Me.coc1exceed)
        Me.TabPage1.Controls.Add(Me.Label67)
        Me.TabPage1.Controls.Add(Me.Label66)
        Me.TabPage1.Controls.Add(Me.Label65)
        Me.TabPage1.Controls.Add(Me.conc21box)
        Me.TabPage1.Controls.Add(Me.conc60box)
        Me.TabPage1.Controls.Add(Me.conc28box)
        Me.TabPage1.Controls.Add(Me.Label64)
        Me.TabPage1.Controls.Add(Me.Label63)
        Me.TabPage1.Controls.Add(Me.Label62)
        Me.TabPage1.Controls.Add(Me.conc2box)
        Me.TabPage1.Controls.Add(Me.conc4box)
        Me.TabPage1.Controls.Add(Me.conc3box)
        Me.TabPage1.Controls.Add(Me.CopyGraph)
        Me.TabPage1.Controls.Add(Me.Chart1)
        Me.TabPage1.Controls.Add(Me.Label38)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Size = New System.Drawing.Size(765, 709)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Results"
        '
        'UserDaysBenthic
        '
        Me.UserDaysBenthic.AutoSize = True
        Me.UserDaysBenthic.ForeColor = System.Drawing.Color.SaddleBrown
        Me.UserDaysBenthic.Location = New System.Drawing.Point(295, 204)
        Me.UserDaysBenthic.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UserDaysBenthic.Name = "UserDaysBenthic"
        Me.UserDaysBenthic.Size = New System.Drawing.Size(16, 17)
        Me.UserDaysBenthic.TabIndex = 92
        Me.UserDaysBenthic.Text = "?"
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label77.Location = New System.Drawing.Point(509, 10)
        Me.Label77.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(73, 20)
        Me.Label77.TabIndex = 91
        Me.Label77.Text = "Benthic"
        '
        'Label104
        '
        Me.Label104.AutoSize = True
        Me.Label104.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label104.Location = New System.Drawing.Point(661, 37)
        Me.Label104.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(78, 34)
        Me.Label104.TabIndex = 90
        Me.Label104.Text = "Days >CoC" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  (Fraction)"
        '
        'totalCocExceedUser
        '
        Me.totalCocExceedUser.Location = New System.Drawing.Point(665, 198)
        Me.totalCocExceedUser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.totalCocExceedUser.Name = "totalCocExceedUser"
        Me.totalCocExceedUser.Size = New System.Drawing.Size(72, 22)
        Me.totalCocExceedUser.TabIndex = 89
        '
        'totalconcUser
        '
        Me.totalconcUser.Location = New System.Drawing.Point(580, 198)
        Me.totalconcUser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.totalconcUser.Name = "totalconcUser"
        Me.totalconcUser.Size = New System.Drawing.Size(72, 22)
        Me.totalconcUser.TabIndex = 88
        '
        'totalconc7
        '
        Me.totalconc7.Location = New System.Drawing.Point(580, 122)
        Me.totalconc7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.totalconc7.Name = "totalconc7"
        Me.totalconc7.Size = New System.Drawing.Size(72, 22)
        Me.totalconc7.TabIndex = 87
        '
        'totalconc1
        '
        Me.totalconc1.Location = New System.Drawing.Point(580, 73)
        Me.totalconc1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.totalconc1.Name = "totalconc1"
        Me.totalconc1.Size = New System.Drawing.Size(72, 22)
        Me.totalconc1.TabIndex = 86
        '
        'totalCocExceed3
        '
        Me.totalCocExceed3.Location = New System.Drawing.Point(665, 97)
        Me.totalCocExceed3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.totalCocExceed3.Name = "totalCocExceed3"
        Me.totalCocExceed3.Size = New System.Drawing.Size(72, 22)
        Me.totalCocExceed3.TabIndex = 85
        '
        'totalconc3
        '
        Me.totalconc3.Location = New System.Drawing.Point(580, 97)
        Me.totalconc3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.totalconc3.Name = "totalconc3"
        Me.totalconc3.Size = New System.Drawing.Size(72, 22)
        Me.totalconc3.TabIndex = 84
        '
        'totalCocExceed60
        '
        Me.totalCocExceed60.Location = New System.Drawing.Point(665, 171)
        Me.totalCocExceed60.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.totalCocExceed60.Name = "totalCocExceed60"
        Me.totalCocExceed60.Size = New System.Drawing.Size(72, 22)
        Me.totalCocExceed60.TabIndex = 83
        '
        'totalconc60
        '
        Me.totalconc60.Location = New System.Drawing.Point(580, 171)
        Me.totalconc60.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.totalconc60.Name = "totalconc60"
        Me.totalconc60.Size = New System.Drawing.Size(72, 22)
        Me.totalconc60.TabIndex = 82
        '
        'totalCocExceed28
        '
        Me.totalCocExceed28.Location = New System.Drawing.Point(665, 146)
        Me.totalCocExceed28.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.totalCocExceed28.Name = "totalCocExceed28"
        Me.totalCocExceed28.Size = New System.Drawing.Size(72, 22)
        Me.totalCocExceed28.TabIndex = 81
        '
        'totalconc28
        '
        Me.totalconc28.Location = New System.Drawing.Point(580, 146)
        Me.totalconc28.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.totalconc28.Name = "totalconc28"
        Me.totalconc28.Size = New System.Drawing.Size(72, 22)
        Me.totalconc28.TabIndex = 80
        '
        'Label105
        '
        Me.Label105.AutoSize = True
        Me.Label105.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label105.Location = New System.Drawing.Point(569, 38)
        Me.Label105.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(91, 34)
        Me.Label105.TabIndex = 79
        Me.Label105.Text = "Total Benthic" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    (μg/kg)"
        '
        'totalCocExceed7
        '
        Me.totalCocExceed7.Location = New System.Drawing.Point(665, 122)
        Me.totalCocExceed7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.totalCocExceed7.Name = "totalCocExceed7"
        Me.totalCocExceed7.Size = New System.Drawing.Size(72, 22)
        Me.totalCocExceed7.TabIndex = 78
        '
        'totalCocExceed1
        '
        Me.totalCocExceed1.Location = New System.Drawing.Point(665, 73)
        Me.totalCocExceed1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.totalCocExceed1.Name = "totalCocExceed1"
        Me.totalCocExceed1.Size = New System.Drawing.Size(72, 22)
        Me.totalCocExceed1.TabIndex = 77
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label103.Location = New System.Drawing.Point(451, 38)
        Me.Label103.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(78, 34)
        Me.Label103.TabIndex = 76
        Me.Label103.Text = "Days >CoC" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  (Fraction)"
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label102.ForeColor = System.Drawing.Color.Blue
        Me.Label102.Location = New System.Drawing.Point(117, 5)
        Me.Label102.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(128, 20)
        Me.Label102.TabIndex = 75
        Me.Label102.Text = "Water Column"
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label101.Location = New System.Drawing.Point(311, 204)
        Me.Label101.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(64, 17)
        Me.Label101.TabIndex = 74
        Me.Label101.Text = "-day Avg"
        '
        'pwcocUserExceed
        '
        Me.pwcocUserExceed.Location = New System.Drawing.Point(455, 199)
        Me.pwcocUserExceed.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pwcocUserExceed.Name = "pwcocUserExceed"
        Me.pwcocUserExceed.Size = New System.Drawing.Size(72, 22)
        Me.pwcocUserExceed.TabIndex = 73
        '
        'pwconcUserbox
        '
        Me.pwconcUserbox.Location = New System.Drawing.Point(377, 199)
        Me.pwconcUserbox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pwconcUserbox.Name = "pwconcUserbox"
        Me.pwconcUserbox.Size = New System.Drawing.Size(72, 22)
        Me.pwconcUserbox.TabIndex = 72
        '
        'UserDaysWater
        '
        Me.UserDaysWater.AutoSize = True
        Me.UserDaysWater.ForeColor = System.Drawing.Color.Blue
        Me.UserDaysWater.Location = New System.Drawing.Point(16, 272)
        Me.UserDaysWater.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UserDaysWater.Name = "UserDaysWater"
        Me.UserDaysWater.Size = New System.Drawing.Size(16, 17)
        Me.UserDaysWater.TabIndex = 71
        Me.UserDaysWater.Text = "?"
        '
        'cocUserexceed
        '
        Me.cocUserexceed.Location = New System.Drawing.Point(192, 267)
        Me.cocUserexceed.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cocUserexceed.Name = "cocUserexceed"
        Me.cocUserexceed.Size = New System.Drawing.Size(72, 22)
        Me.cocUserexceed.TabIndex = 70
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.ForeColor = System.Drawing.Color.Blue
        Me.Label99.Location = New System.Drawing.Point(32, 272)
        Me.Label99.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(66, 17)
        Me.Label99.TabIndex = 69
        Me.Label99.Text = "-Day Avg"
        '
        'concUserBox
        '
        Me.concUserBox.Location = New System.Drawing.Point(105, 267)
        Me.concUserBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.concUserBox.Name = "concUserBox"
        Me.concUserBox.Size = New System.Drawing.Size(72, 22)
        Me.concUserBox.TabIndex = 68
        '
        'pwconc7box
        '
        Me.pwconc7box.Location = New System.Drawing.Point(377, 123)
        Me.pwconc7box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pwconc7box.Name = "pwconc7box"
        Me.pwconc7box.Size = New System.Drawing.Size(72, 22)
        Me.pwconc7box.TabIndex = 67
        '
        'pwconc1box
        '
        Me.pwconc1box.Location = New System.Drawing.Point(377, 74)
        Me.pwconc1box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pwconc1box.Name = "pwconc1box"
        Me.pwconc1box.Size = New System.Drawing.Size(72, 22)
        Me.pwconc1box.TabIndex = 66
        '
        'conc7box
        '
        Me.conc7box.Location = New System.Drawing.Point(105, 166)
        Me.conc7box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.conc7box.Name = "conc7box"
        Me.conc7box.Size = New System.Drawing.Size(72, 22)
        Me.conc7box.TabIndex = 65
        '
        'conc1box
        '
        Me.conc1box.Location = New System.Drawing.Point(105, 68)
        Me.conc1box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.conc1box.Name = "conc1box"
        Me.conc1box.Size = New System.Drawing.Size(72, 22)
        Me.conc1box.TabIndex = 64
        '
        'pwcoc3exceed
        '
        Me.pwcoc3exceed.Location = New System.Drawing.Point(455, 98)
        Me.pwcoc3exceed.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pwcoc3exceed.Name = "pwcoc3exceed"
        Me.pwcoc3exceed.Size = New System.Drawing.Size(72, 22)
        Me.pwcoc3exceed.TabIndex = 63
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label86.Location = New System.Drawing.Point(303, 103)
        Me.Label86.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(72, 17)
        Me.Label86.TabIndex = 62
        Me.Label86.Text = "3-day Avg"
        '
        'pwconc3box
        '
        Me.pwconc3box.Location = New System.Drawing.Point(377, 98)
        Me.pwconc3box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pwconc3box.Name = "pwconc3box"
        Me.pwconc3box.Size = New System.Drawing.Size(72, 22)
        Me.pwconc3box.TabIndex = 61
        '
        'pwcoc60exceed
        '
        Me.pwcoc60exceed.Location = New System.Drawing.Point(455, 172)
        Me.pwcoc60exceed.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pwcoc60exceed.Name = "pwcoc60exceed"
        Me.pwcoc60exceed.Size = New System.Drawing.Size(72, 22)
        Me.pwcoc60exceed.TabIndex = 51
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label83.Location = New System.Drawing.Point(295, 177)
        Me.Label83.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(80, 17)
        Me.Label83.TabIndex = 60
        Me.Label83.Text = "60-day Avg"
        '
        'pwconc60box
        '
        Me.pwconc60box.Location = New System.Drawing.Point(377, 172)
        Me.pwconc60box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pwconc60box.Name = "pwconc60box"
        Me.pwconc60box.Size = New System.Drawing.Size(72, 22)
        Me.pwconc60box.TabIndex = 49
        '
        'pwcoc28exceed
        '
        Me.pwcoc28exceed.Location = New System.Drawing.Point(455, 148)
        Me.pwcoc28exceed.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pwcoc28exceed.Name = "pwcoc28exceed"
        Me.pwcoc28exceed.Size = New System.Drawing.Size(72, 22)
        Me.pwcoc28exceed.TabIndex = 48
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label80.Location = New System.Drawing.Point(295, 153)
        Me.Label80.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(80, 17)
        Me.Label80.TabIndex = 47
        Me.Label80.Text = "28-day Avg"
        '
        'pwconc28box
        '
        Me.pwconc28box.Location = New System.Drawing.Point(377, 148)
        Me.pwconc28box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pwconc28box.Name = "pwconc28box"
        Me.pwconc28box.Size = New System.Drawing.Size(72, 22)
        Me.pwconc28box.TabIndex = 46
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label76.Location = New System.Drawing.Point(373, 39)
        Me.Label76.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(80, 34)
        Me.Label76.TabIndex = 44
        Me.Label76.Text = "Pore Water" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    (μg/L)"
        '
        'pwcoc7exceed
        '
        Me.pwcoc7exceed.Location = New System.Drawing.Point(455, 123)
        Me.pwcoc7exceed.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pwcoc7exceed.Name = "pwcoc7exceed"
        Me.pwcoc7exceed.Size = New System.Drawing.Size(72, 22)
        Me.pwcoc7exceed.TabIndex = 43
        '
        'pwcoc1exceed
        '
        Me.pwcoc1exceed.Location = New System.Drawing.Point(455, 74)
        Me.pwcoc1exceed.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pwcoc1exceed.Name = "pwcoc1exceed"
        Me.pwcoc1exceed.Size = New System.Drawing.Size(72, 22)
        Me.pwcoc1exceed.TabIndex = 42
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.ForeColor = System.Drawing.Color.Blue
        Me.Label75.Location = New System.Drawing.Point(99, 34)
        Me.Label75.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(80, 34)
        Me.Label75.TabIndex = 41
        Me.Label75.Text = "Total Conc." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   (μg/L)"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.ForeColor = System.Drawing.Color.Blue
        Me.Label74.Location = New System.Drawing.Point(188, 36)
        Me.Label74.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(82, 34)
        Me.Label74.TabIndex = 40
        Me.Label74.Text = "Days > CoC" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " (Fraction)"
        '
        'coc21exceed
        '
        Me.coc21exceed.Location = New System.Drawing.Point(192, 191)
        Me.coc21exceed.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.coc21exceed.Name = "coc21exceed"
        Me.coc21exceed.Size = New System.Drawing.Size(72, 22)
        Me.coc21exceed.TabIndex = 39
        '
        'coc60exceed
        '
        Me.coc60exceed.Location = New System.Drawing.Point(192, 240)
        Me.coc60exceed.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.coc60exceed.Name = "coc60exceed"
        Me.coc60exceed.Size = New System.Drawing.Size(72, 22)
        Me.coc60exceed.TabIndex = 38
        '
        'coc28exceed
        '
        Me.coc28exceed.Location = New System.Drawing.Point(192, 215)
        Me.coc28exceed.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.coc28exceed.Name = "coc28exceed"
        Me.coc28exceed.Size = New System.Drawing.Size(72, 22)
        Me.coc28exceed.TabIndex = 37
        '
        'coc2exceed
        '
        Me.coc2exceed.Location = New System.Drawing.Point(192, 92)
        Me.coc2exceed.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.coc2exceed.Name = "coc2exceed"
        Me.coc2exceed.Size = New System.Drawing.Size(72, 22)
        Me.coc2exceed.TabIndex = 36
        '
        'coc4exceed
        '
        Me.coc4exceed.Location = New System.Drawing.Point(192, 142)
        Me.coc4exceed.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.coc4exceed.Name = "coc4exceed"
        Me.coc4exceed.Size = New System.Drawing.Size(72, 22)
        Me.coc4exceed.TabIndex = 35
        '
        'coc3exceed
        '
        Me.coc3exceed.Location = New System.Drawing.Point(192, 117)
        Me.coc3exceed.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.coc3exceed.Name = "coc3exceed"
        Me.coc3exceed.Size = New System.Drawing.Size(72, 22)
        Me.coc3exceed.TabIndex = 34
        '
        'coc7exceed
        '
        Me.coc7exceed.Location = New System.Drawing.Point(192, 166)
        Me.coc7exceed.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.coc7exceed.Name = "coc7exceed"
        Me.coc7exceed.Size = New System.Drawing.Size(72, 22)
        Me.coc7exceed.TabIndex = 32
        '
        'coc1exceed
        '
        Me.coc1exceed.Location = New System.Drawing.Point(192, 68)
        Me.coc1exceed.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.coc1exceed.Name = "coc1exceed"
        Me.coc1exceed.Size = New System.Drawing.Size(72, 22)
        Me.coc1exceed.TabIndex = 31
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.ForeColor = System.Drawing.Color.Blue
        Me.Label67.Location = New System.Drawing.Point(16, 245)
        Me.Label67.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(82, 17)
        Me.Label67.TabIndex = 30
        Me.Label67.Text = "60-Day Avg"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.ForeColor = System.Drawing.Color.Blue
        Me.Label66.Location = New System.Drawing.Point(16, 220)
        Me.Label66.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(82, 17)
        Me.Label66.TabIndex = 29
        Me.Label66.Text = "28-Day Avg"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.ForeColor = System.Drawing.Color.Blue
        Me.Label65.Location = New System.Drawing.Point(16, 196)
        Me.Label65.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(82, 17)
        Me.Label65.TabIndex = 28
        Me.Label65.Text = "21-Day Avg"
        '
        'conc21box
        '
        Me.conc21box.Location = New System.Drawing.Point(105, 191)
        Me.conc21box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.conc21box.Name = "conc21box"
        Me.conc21box.Size = New System.Drawing.Size(72, 22)
        Me.conc21box.TabIndex = 27
        '
        'conc60box
        '
        Me.conc60box.Location = New System.Drawing.Point(105, 240)
        Me.conc60box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.conc60box.Name = "conc60box"
        Me.conc60box.Size = New System.Drawing.Size(72, 22)
        Me.conc60box.TabIndex = 26
        '
        'conc28box
        '
        Me.conc28box.Location = New System.Drawing.Point(105, 215)
        Me.conc28box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.conc28box.Name = "conc28box"
        Me.conc28box.Size = New System.Drawing.Size(72, 22)
        Me.conc28box.TabIndex = 25
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.ForeColor = System.Drawing.Color.Blue
        Me.Label64.Location = New System.Drawing.Point(24, 145)
        Me.Label64.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(74, 17)
        Me.Label64.TabIndex = 24
        Me.Label64.Text = "4-Day Avg"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.ForeColor = System.Drawing.Color.Blue
        Me.Label63.Location = New System.Drawing.Point(24, 121)
        Me.Label63.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(74, 17)
        Me.Label63.TabIndex = 23
        Me.Label63.Text = "3-Day Avg"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.ForeColor = System.Drawing.Color.Blue
        Me.Label62.Location = New System.Drawing.Point(24, 96)
        Me.Label62.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(74, 17)
        Me.Label62.TabIndex = 22
        Me.Label62.Text = "2-Day Avg"
        '
        'conc2box
        '
        Me.conc2box.Location = New System.Drawing.Point(105, 92)
        Me.conc2box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.conc2box.Name = "conc2box"
        Me.conc2box.Size = New System.Drawing.Size(72, 22)
        Me.conc2box.TabIndex = 21
        '
        'conc4box
        '
        Me.conc4box.Location = New System.Drawing.Point(105, 142)
        Me.conc4box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.conc4box.Name = "conc4box"
        Me.conc4box.Size = New System.Drawing.Size(72, 22)
        Me.conc4box.TabIndex = 20
        '
        'conc3box
        '
        Me.conc3box.Location = New System.Drawing.Point(105, 117)
        Me.conc3box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.conc3box.Name = "conc3box"
        Me.conc3box.Size = New System.Drawing.Size(72, 22)
        Me.conc3box.TabIndex = 19
        '
        'CopyGraph
        '
        Me.CopyGraph.AutoEllipsis = True
        Me.CopyGraph.Location = New System.Drawing.Point(21, 326)
        Me.CopyGraph.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CopyGraph.Name = "CopyGraph"
        Me.CopyGraph.Size = New System.Drawing.Size(100, 34)
        Me.CopyGraph.TabIndex = 12
        Me.CopyGraph.Text = "Copy Graph"
        Me.CopyGraph.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea1.AxisX.Title = "Days"
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.Title = "Daily Avg Concentration (μg/L)"
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Alignment = System.Drawing.StringAlignment.Far
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(11, 320)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.Chart1.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.Blue, System.Drawing.Color.SaddleBrown}
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series1.Legend = "Legend1"
        Series1.Name = "Water Column (Total)"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series2.Legend = "Legend1"
        Series2.Name = "Pore Water"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(725, 377)
        Me.Chart1.TabIndex = 11
        Me.Chart1.Text = "Chart1"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label38.Location = New System.Drawing.Point(303, 128)
        Me.Label38.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(72, 17)
        Me.Label38.TabIndex = 9
        Me.Label38.Text = "7-day Avg"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label24.Location = New System.Drawing.Point(303, 79)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 17)
        Me.Label24.TabIndex = 7
        Me.Label24.Text = "1-day Avg"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(24, 171)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 17)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "7-Day Avg"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(21, 73)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 17)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "1-Day Avg"
        Me.ToolTip1.SetToolTip(Me.Label13, "Peak concentration considering that mass enters water body uniformly over the day" &
        ".")
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Label116)
        Me.TabPage2.Controls.Add(Me.Label115)
        Me.TabPage2.Controls.Add(Me.Label114)
        Me.TabPage2.Controls.Add(Me.Label113)
        Me.TabPage2.Controls.Add(Me.Label112)
        Me.TabPage2.Controls.Add(Me.Label111)
        Me.TabPage2.Controls.Add(Me.Label110)
        Me.TabPage2.Controls.Add(Me.Label109)
        Me.TabPage2.Controls.Add(Me.Label108)
        Me.TabPage2.Controls.Add(Me.benthicTotalOut)
        Me.TabPage2.Controls.Add(Me.benthicHydrolysisOut)
        Me.TabPage2.Controls.Add(Me.benthicMetabolismOut)
        Me.TabPage2.Controls.Add(Me.photolysisOut)
        Me.TabPage2.Controls.Add(Me.hydrolysisOut)
        Me.TabPage2.Controls.Add(Me.TotalOut)
        Me.TabPage2.Controls.Add(Me.volatileOut)
        Me.TabPage2.Controls.Add(Me.metabolismOut)
        Me.TabPage2.Controls.Add(Me.washoutOut)
        Me.TabPage2.Controls.Add(Me.Label107)
        Me.TabPage2.Controls.Add(Me.Label106)
        Me.TabPage2.Controls.Add(Me.Label100)
        Me.TabPage2.Controls.Add(Me.bioPhase1)
        Me.TabPage2.Controls.Add(Me.docPhase1)
        Me.TabPage2.Controls.Add(Me.aqPhaseTotal)
        Me.TabPage2.Controls.Add(Me.aqPhase2)
        Me.TabPage2.Controls.Add(Me.Label91)
        Me.TabPage2.Controls.Add(Me.Label90)
        Me.TabPage2.Controls.Add(Me.Label89)
        Me.TabPage2.Controls.Add(Me.wetConversionBox)
        Me.TabPage2.Controls.Add(Me.dryConversionBox)
        Me.TabPage2.Controls.Add(Me.Label88)
        Me.TabPage2.Controls.Add(Me.Label56)
        Me.TabPage2.Controls.Add(Me.Label87)
        Me.TabPage2.Controls.Add(Me.Label57)
        Me.TabPage2.Controls.Add(Me.Label23)
        Me.TabPage2.Controls.Add(Me.ssPhase1)
        Me.TabPage2.Controls.Add(Me.AqPhase1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage2.Size = New System.Drawing.Size(765, 709)
        Me.TabPage2.TabIndex = 4
        Me.TabPage2.Text = "More Info"
        '
        'Label116
        '
        Me.Label116.AutoSize = True
        Me.Label116.Location = New System.Drawing.Point(193, 498)
        Me.Label116.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(215, 17)
        Me.Label116.TabIndex = 38
        Me.Label116.Text = "Benthic Hydrolysis Halflife (days)"
        '
        'Label115
        '
        Me.Label115.AutoSize = True
        Me.Label115.Location = New System.Drawing.Point(224, 523)
        Me.Label115.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label115.Name = "Label115"
        Me.Label115.Size = New System.Drawing.Size(182, 17)
        Me.Label115.TabIndex = 37
        Me.Label115.Text = "Total Benthic Halflife (days)"
        '
        'Label114
        '
        Me.Label114.AutoSize = True
        Me.Label114.Location = New System.Drawing.Point(185, 474)
        Me.Label114.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(221, 17)
        Me.Label114.TabIndex = 36
        Me.Label114.Text = "Benthic Metabolism Halflife (days)"
        '
        'Label113
        '
        Me.Label113.AutoSize = True
        Me.Label113.Location = New System.Drawing.Point(187, 439)
        Me.Label113.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label113.Name = "Label113"
        Me.Label113.Size = New System.Drawing.Size(220, 17)
        Me.Label113.TabIndex = 35
        Me.Label113.Text = "Total water Column Halflife (days)"
        '
        'Label112
        '
        Me.Label112.AutoSize = True
        Me.Label112.Location = New System.Drawing.Point(245, 366)
        Me.Label112.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(164, 17)
        Me.Label112.TabIndex = 34
        Me.Label112.Text = "Hydrolysis Halflife (days)"
        '
        'Label111
        '
        Me.Label111.AutoSize = True
        Me.Label111.Location = New System.Drawing.Point(245, 390)
        Me.Label111.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(163, 17)
        Me.Label111.TabIndex = 33
        Me.Label111.Text = "Photolysis Halflife (days)"
        '
        'Label110
        '
        Me.Label110.AutoSize = True
        Me.Label110.Location = New System.Drawing.Point(263, 415)
        Me.Label110.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(145, 17)
        Me.Label110.TabIndex = 32
        Me.Label110.Text = "Volatile Halflife (days)"
        '
        'Label109
        '
        Me.Label109.AutoSize = True
        Me.Label109.Location = New System.Drawing.Point(195, 341)
        Me.Label109.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(212, 17)
        Me.Label109.TabIndex = 31
        Me.Label109.Text = "Water Metabolism Halflife (days)"
        '
        'Label108
        '
        Me.Label108.AutoSize = True
        Me.Label108.Location = New System.Drawing.Point(251, 316)
        Me.Label108.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(155, 17)
        Me.Label108.TabIndex = 30
        Me.Label108.Text = "Washout Halflife (days)"
        '
        'benthicTotalOut
        '
        Me.benthicTotalOut.Location = New System.Drawing.Point(428, 518)
        Me.benthicTotalOut.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.benthicTotalOut.Name = "benthicTotalOut"
        Me.benthicTotalOut.Size = New System.Drawing.Size(132, 22)
        Me.benthicTotalOut.TabIndex = 29
        '
        'benthicHydrolysisOut
        '
        Me.benthicHydrolysisOut.Location = New System.Drawing.Point(428, 494)
        Me.benthicHydrolysisOut.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.benthicHydrolysisOut.Name = "benthicHydrolysisOut"
        Me.benthicHydrolysisOut.Size = New System.Drawing.Size(132, 22)
        Me.benthicHydrolysisOut.TabIndex = 26
        '
        'benthicMetabolismOut
        '
        Me.benthicMetabolismOut.Location = New System.Drawing.Point(428, 469)
        Me.benthicMetabolismOut.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.benthicMetabolismOut.Name = "benthicMetabolismOut"
        Me.benthicMetabolismOut.Size = New System.Drawing.Size(132, 22)
        Me.benthicMetabolismOut.TabIndex = 25
        '
        'photolysisOut
        '
        Me.photolysisOut.Location = New System.Drawing.Point(428, 385)
        Me.photolysisOut.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.photolysisOut.Name = "photolysisOut"
        Me.photolysisOut.Size = New System.Drawing.Size(132, 22)
        Me.photolysisOut.TabIndex = 24
        '
        'hydrolysisOut
        '
        Me.hydrolysisOut.Location = New System.Drawing.Point(428, 361)
        Me.hydrolysisOut.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.hydrolysisOut.Name = "hydrolysisOut"
        Me.hydrolysisOut.Size = New System.Drawing.Size(132, 22)
        Me.hydrolysisOut.TabIndex = 23
        '
        'TotalOut
        '
        Me.TotalOut.Location = New System.Drawing.Point(428, 434)
        Me.TotalOut.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TotalOut.Name = "TotalOut"
        Me.TotalOut.Size = New System.Drawing.Size(132, 22)
        Me.TotalOut.TabIndex = 22
        '
        'volatileOut
        '
        Me.volatileOut.Location = New System.Drawing.Point(428, 410)
        Me.volatileOut.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.volatileOut.Name = "volatileOut"
        Me.volatileOut.Size = New System.Drawing.Size(132, 22)
        Me.volatileOut.TabIndex = 21
        '
        'metabolismOut
        '
        Me.metabolismOut.Location = New System.Drawing.Point(428, 336)
        Me.metabolismOut.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.metabolismOut.Name = "metabolismOut"
        Me.metabolismOut.Size = New System.Drawing.Size(132, 22)
        Me.metabolismOut.TabIndex = 20
        '
        'washoutOut
        '
        Me.washoutOut.Location = New System.Drawing.Point(428, 311)
        Me.washoutOut.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.washoutOut.Name = "washoutOut"
        Me.washoutOut.Size = New System.Drawing.Size(132, 22)
        Me.washoutOut.TabIndex = 19
        '
        'Label107
        '
        Me.Label107.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label107.Location = New System.Drawing.Point(277, 567)
        Me.Label107.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(128, 22)
        Me.Label107.TabIndex = 18
        Me.Label107.Text = "Conversions"
        '
        'Label106
        '
        Me.Label106.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label106.Location = New System.Drawing.Point(185, 286)
        Me.Label106.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(312, 22)
        Me.Label106.TabIndex = 17
        Me.Label106.Text = "Effective Dissipation Processes"
        '
        'Label100
        '
        Me.Label100.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label100.Location = New System.Drawing.Point(169, 27)
        Me.Label100.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(345, 22)
        Me.Label100.TabIndex = 0
        Me.Label100.Text = "Chemical Tendency for Distribution"
        '
        'bioPhase1
        '
        Me.bioPhase1.Location = New System.Drawing.Point(428, 140)
        Me.bioPhase1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bioPhase1.Name = "bioPhase1"
        Me.bioPhase1.Size = New System.Drawing.Size(132, 22)
        Me.bioPhase1.TabIndex = 11
        '
        'docPhase1
        '
        Me.docPhase1.Location = New System.Drawing.Point(428, 116)
        Me.docPhase1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.docPhase1.Name = "docPhase1"
        Me.docPhase1.Size = New System.Drawing.Size(132, 22)
        Me.docPhase1.TabIndex = 10
        '
        'aqPhaseTotal
        '
        Me.aqPhaseTotal.Location = New System.Drawing.Point(428, 190)
        Me.aqPhaseTotal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.aqPhaseTotal.Name = "aqPhaseTotal"
        Me.aqPhaseTotal.Size = New System.Drawing.Size(132, 22)
        Me.aqPhaseTotal.TabIndex = 9
        '
        'aqPhase2
        '
        Me.aqPhase2.Location = New System.Drawing.Point(428, 165)
        Me.aqPhase2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.aqPhase2.Name = "aqPhase2"
        Me.aqPhase2.Size = New System.Drawing.Size(132, 22)
        Me.aqPhase2.TabIndex = 8
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label91.Location = New System.Drawing.Point(163, 193)
        Me.Label91.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(226, 18)
        Me.Label91.TabIndex = 7
        Me.Label91.Text = "Water Column to Whole System "
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.Location = New System.Drawing.Point(85, 169)
        Me.Label90.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(289, 18)
        Me.Label90.TabIndex = 6
        Me.Label90.Text = "Aqueous Phase Fraction in Benthic Region"
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.Location = New System.Drawing.Point(132, 144)
        Me.Label89.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(250, 18)
        Me.Label89.TabIndex = 5
        Me.Label89.Text = "Bio-Phase Fraction in Water Column"
        '
        'wetConversionBox
        '
        Me.wetConversionBox.Location = New System.Drawing.Point(460, 620)
        Me.wetConversionBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.wetConversionBox.Name = "wetConversionBox"
        Me.wetConversionBox.Size = New System.Drawing.Size(72, 22)
        Me.wetConversionBox.TabIndex = 14
        '
        'dryConversionBox
        '
        Me.dryConversionBox.Location = New System.Drawing.Point(460, 596)
        Me.dryConversionBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dryConversionBox.Name = "dryConversionBox"
        Me.dryConversionBox.Size = New System.Drawing.Size(72, 22)
        Me.dryConversionBox.TabIndex = 13
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.Location = New System.Drawing.Point(121, 119)
        Me.Label88.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(262, 18)
        Me.Label88.TabIndex = 4
        Me.Label88.Text = "DOC-Phase Fraction in Water Column"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(116, 625)
        Me.Label56.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(323, 17)
        Me.Label56.TabIndex = 15
        Me.Label56.Text = "Pore Water (μg/L) to Total / Wet Sediment (μg/kg)"
        Me.ToolTip1.SetToolTip(Me.Label56, "Total chemical mass in benthic per mass of dry sediment. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Includes  chemical mas" &
        "s in pore water.")
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label87.Location = New System.Drawing.Point(77, 95)
        Me.Label87.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(300, 18)
        Me.Label87.TabIndex = 3
        Me.Label87.Text = "SS-Sorbed Phase Fraction in Water Column"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(121, 601)
        Me.Label57.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(320, 17)
        Me.Label57.TabIndex = 16
        Me.Label57.Text = "Pore Water (μg/L) to Total / Dry Sediment (μg/kg)"
        Me.ToolTip1.SetToolTip(Me.Label57, "Total chemical mass in benthic per mass of dry sediment. ")
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(93, 70)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(285, 18)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Aqueous Phase Fraction in Water Column"
        '
        'ssPhase1
        '
        Me.ssPhase1.Location = New System.Drawing.Point(428, 91)
        Me.ssPhase1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ssPhase1.Name = "ssPhase1"
        Me.ssPhase1.Size = New System.Drawing.Size(132, 22)
        Me.ssPhase1.TabIndex = 1
        '
        'AqPhase1
        '
        Me.AqPhase1.Location = New System.Drawing.Point(428, 66)
        Me.AqPhase1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AqPhase1.Name = "AqPhase1"
        Me.AqPhase1.Size = New System.Drawing.Size(132, 22)
        Me.AqPhase1.TabIndex = 0
        '
        'Run
        '
        Me.Run.Location = New System.Drawing.Point(665, 778)
        Me.Run.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Run.Name = "Run"
        Me.Run.Size = New System.Drawing.Size(104, 59)
        Me.Run.TabIndex = 2
        Me.Run.Text = "RUN"
        Me.Run.UseVisualStyleBackColor = True
        '
        'workingDirectoryBox
        '
        Me.workingDirectoryBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.workingDirectoryBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.workingDirectoryBox.Location = New System.Drawing.Point(144, 783)
        Me.workingDirectoryBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.workingDirectoryBox.Multiline = True
        Me.workingDirectoryBox.Name = "workingDirectoryBox"
        Me.workingDirectoryBox.ReadOnly = True
        Me.workingDirectoryBox.Size = New System.Drawing.Size(336, 34)
        Me.workingDirectoryBox.TabIndex = 4
        '
        'ioFamilyNameBox
        '
        Me.ioFamilyNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ioFamilyNameBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ioFamilyNameBox.Location = New System.Drawing.Point(144, 827)
        Me.ioFamilyNameBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ioFamilyNameBox.Name = "ioFamilyNameBox"
        Me.ioFamilyNameBox.ReadOnly = True
        Me.ioFamilyNameBox.Size = New System.Drawing.Size(336, 15)
        Me.ioFamilyNameBox.TabIndex = 6
        '
        'SaveScenarioDialog
        '
        Me.SaveScenarioDialog.Filter = "Scenario files|*.scn|All files|*.*"
        '
        'RetrieveScenarioDialog
        '
        Me.RetrieveScenarioDialog.Filter = "Scenario files|*.scn|All files|*.*"
        '
        'FlowAveraging
        '
        Me.FlowAveraging.Location = New System.Drawing.Point(267, 267)
        Me.FlowAveraging.Name = "FlowAveraging"
        Me.FlowAveraging.Size = New System.Drawing.Size(53, 22)
        Me.FlowAveraging.TabIndex = 60
        Me.FlowAveraging.Text = "1"
        '
        'Label117
        '
        Me.Label117.AutoSize = True
        Me.Label117.Location = New System.Drawing.Point(113, 267)
        Me.Label117.Name = "Label117"
        Me.Label117.Size = New System.Drawing.Size(148, 17)
        Me.Label117.TabIndex = 61
        Me.Label117.Text = "Flow Averaging (days)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 881)
        Me.Controls.Add(Me.ioFamilyNameBox)
        Me.Controls.Add(Label22)
        Me.Controls.Add(Me.workingDirectoryBox)
        Me.Controls.Add(Label20)
        Me.Controls.Add(Me.Run)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ChemTab.ResumeLayout(False)
        Me.ChemTab.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Toxicity.ResumeLayout(False)
        Me.Toxicity.PerformLayout()
        Me.Scenario2Tab.ResumeLayout(False)
        Me.Scenario2Tab.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RetrieveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScenarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RetrieveScenarioMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveScenarioMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents ChemTab As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mwtBox As System.Windows.Forms.TextBox
    Friend WithEvents hydrolBox As System.Windows.Forms.TextBox
    Friend WithEvents photoBox As System.Windows.Forms.TextBox
    Friend WithEvents waterMetabBox As System.Windows.Forms.TextBox
    Friend WithEvents sorptionBox As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents massReleaseBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents daysOffBox1 As System.Windows.Forms.TextBox
    Friend WithEvents daysOnBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents heatHenryBox As System.Windows.Forms.TextBox
    Friend WithEvents henryBox As System.Windows.Forms.TextBox
    Friend WithEvents RefTempHydrBox As System.Windows.Forms.TextBox
    Friend WithEvents RefLatBox As System.Windows.Forms.TextBox
    Friend WithEvents RefTempWaterBox As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents isKoc As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents solBox As System.Windows.Forms.TextBox
    Friend WithEvents vpBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lengthBox As System.Windows.Forms.TextBox
    Friend WithEvents depthBox As System.Windows.Forms.TextBox
    Friend WithEvents widthBox As System.Windows.Forms.TextBox
    Friend WithEvents ZTSFileBox As System.Windows.Forms.TextBox
    Friend WithEvents BrowseZTS As System.Windows.Forms.Button
    Friend WithEvents noBaseFlow As System.Windows.Forms.RadioButton
    Friend WithEvents is_ConstFlow As System.Windows.Forms.RadioButton
    Friend WithEvents constFlowBox As System.Windows.Forms.TextBox
    Friend WithEvents Scenario2Tab As System.Windows.Forms.TabPage
    Friend WithEvents Run As System.Windows.Forms.Button
    Friend WithEvents RefTempBenthBox As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents benthicBox As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents chemIdBox As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents scenarioIdBox As System.Windows.Forms.TextBox
    Friend WithEvents SaveAllInputsDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents workingDirectoryBox As System.Windows.Forms.TextBox
    Friend WithEvents ioFamilyNameBox As System.Windows.Forms.TextBox
    Friend WithEvents GetWeather As System.Windows.Forms.Button
    Friend WithEvents weatherBox As System.Windows.Forms.TextBox
    Friend WithEvents GetWeatherDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GetAllInputsDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents benthicdepthBox As System.Windows.Forms.TextBox
    Friend WithEvents massXferBox As System.Windows.Forms.TextBox
    Friend WithEvents biomass2Box As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents DOC2Box As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents foc2Box As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents bdBox As System.Windows.Forms.TextBox
    Friend WithEvents porosityBox As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents ssBox As System.Windows.Forms.TextBox
    Friend WithEvents Biomass1Box As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents foc1Box As System.Windows.Forms.TextBox
    Friend WithEvents dfacBox As System.Windows.Forms.TextBox
    Friend WithEvents ChlorophyllBox As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents DOC1Box As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents BrowseZTSDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents WatershedAreaBox As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents use3 As System.Windows.Forms.CheckBox
    Friend WithEvents use2 As System.Windows.Forms.CheckBox
    Friend WithEvents use1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents offsetBox3 As System.Windows.Forms.TextBox
    Friend WithEvents massReleaseBox3 As System.Windows.Forms.TextBox
    Friend WithEvents daysOffBox3 As System.Windows.Forms.TextBox
    Friend WithEvents daysOnBox3 As System.Windows.Forms.TextBox
    Friend WithEvents offsetBox2 As System.Windows.Forms.TextBox
    Friend WithEvents massReleaseBox2 As System.Windows.Forms.TextBox
    Friend WithEvents daysOffBox2 As System.Windows.Forms.TextBox
    Friend WithEvents daysOnBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents offsetBox1 As System.Windows.Forms.TextBox
    Friend WithEvents orReadZTS As System.Windows.Forms.CheckBox
    Friend WithEvents is_SpecifiedMass As System.Windows.Forms.CheckBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents EstimateHenry As System.Windows.Forms.RadioButton
    Friend WithEvents gotHenry As System.Windows.Forms.RadioButton
    Friend WithEvents NoVolatilization As System.Windows.Forms.RadioButton
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents HenryRefTempBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents CopyGraph As System.Windows.Forms.Button
    Friend WithEvents wetConversionBox As System.Windows.Forms.TextBox
    Friend WithEvents dryConversionBox As System.Windows.Forms.TextBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Toxicity As System.Windows.Forms.TabPage
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents isToxicityAnalysis As System.Windows.Forms.CheckBox
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Coc7box As System.Windows.Forms.TextBox
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents CoC4box As System.Windows.Forms.TextBox
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents CoC3box As System.Windows.Forms.TextBox
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents conc21box As System.Windows.Forms.TextBox
    Friend WithEvents conc60box As System.Windows.Forms.TextBox
    Friend WithEvents conc28box As System.Windows.Forms.TextBox
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents conc2box As System.Windows.Forms.TextBox
    Friend WithEvents conc4box As System.Windows.Forms.TextBox
    Friend WithEvents conc3box As System.Windows.Forms.TextBox
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents CoC60box As System.Windows.Forms.TextBox
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Coc21box As System.Windows.Forms.TextBox
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Coc28box As System.Windows.Forms.TextBox
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents pwcoc7exceed As System.Windows.Forms.TextBox
    Friend WithEvents pwcoc1exceed As System.Windows.Forms.TextBox
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents coc21exceed As System.Windows.Forms.TextBox
    Friend WithEvents coc60exceed As System.Windows.Forms.TextBox
    Friend WithEvents coc28exceed As System.Windows.Forms.TextBox
    Friend WithEvents coc2exceed As System.Windows.Forms.TextBox
    Friend WithEvents coc4exceed As System.Windows.Forms.TextBox
    Friend WithEvents coc3exceed As System.Windows.Forms.TextBox
    Friend WithEvents coc7exceed As System.Windows.Forms.TextBox
    Friend WithEvents coc1exceed As System.Windows.Forms.TextBox
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents CocPoreWater60box As System.Windows.Forms.TextBox
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents CocPoreWater28box As System.Windows.Forms.TextBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents CocPoreWater7box As System.Windows.Forms.TextBox
    Friend WithEvents pwcoc60exceed As System.Windows.Forms.TextBox
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents pwconc60box As System.Windows.Forms.TextBox
    Friend WithEvents pwcoc28exceed As System.Windows.Forms.TextBox
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents pwconc28box As System.Windows.Forms.TextBox
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents CoC2box As System.Windows.Forms.TextBox
    Friend WithEvents CoC1box As System.Windows.Forms.TextBox
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents CocPoreWater3box As System.Windows.Forms.TextBox
    Friend WithEvents CocPoreWater1box As System.Windows.Forms.TextBox
    Friend WithEvents pwcoc3exceed As System.Windows.Forms.TextBox
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents pwconc3box As System.Windows.Forms.TextBox
    Friend WithEvents conc7box As System.Windows.Forms.TextBox
    Friend WithEvents conc1box As System.Windows.Forms.TextBox
    Friend WithEvents pwconc7box As System.Windows.Forms.TextBox
    Friend WithEvents pwconc1box As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ssPhase1 As System.Windows.Forms.TextBox
    Friend WithEvents AqPhase1 As System.Windows.Forms.TextBox
    Friend WithEvents bioPhase1 As System.Windows.Forms.TextBox
    Friend WithEvents docPhase1 As System.Windows.Forms.TextBox
    Friend WithEvents aqPhaseTotal As System.Windows.Forms.TextBox
    Friend WithEvents aqPhase2 As System.Windows.Forms.TextBox
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label92 As System.Windows.Forms.Label
    Friend WithEvents TimeSeriesFileBox As System.Windows.Forms.TextBox
    Friend WithEvents UseTimeSeries As System.Windows.Forms.CheckBox
    Friend WithEvents BrowseTimeSeries As System.Windows.Forms.Button
    Friend WithEvents BrowseTimeSeriesDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label96 As System.Windows.Forms.Label
    Friend WithEvents Label95 As System.Windows.Forms.Label
    Friend WithEvents CoCTotal1Box As System.Windows.Forms.TextBox
    Friend WithEvents CoCTotal3Box As System.Windows.Forms.TextBox
    Friend WithEvents CoCTotal60Box As System.Windows.Forms.TextBox
    Friend WithEvents CoCTotal28Box As System.Windows.Forms.TextBox
    Friend WithEvents CoCTotal7Box As System.Windows.Forms.TextBox
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents UserDefinedDaysWater As System.Windows.Forms.TextBox
    Friend WithEvents Label93 As System.Windows.Forms.Label
    Friend WithEvents CocUserWaterBox As System.Windows.Forms.TextBox
    Friend WithEvents CoCTotalUserBox As System.Windows.Forms.TextBox
    Friend WithEvents Label97 As System.Windows.Forms.Label
    Friend WithEvents UserDefinedDaysBenthic As System.Windows.Forms.TextBox
    Friend WithEvents Label98 As System.Windows.Forms.Label
    Friend WithEvents CocPoreWaterUserBox As System.Windows.Forms.TextBox
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Label104 As System.Windows.Forms.Label
    Friend WithEvents totalCocExceedUser As System.Windows.Forms.TextBox
    Friend WithEvents totalconcUser As System.Windows.Forms.TextBox
    Friend WithEvents totalconc7 As System.Windows.Forms.TextBox
    Friend WithEvents totalconc1 As System.Windows.Forms.TextBox
    Friend WithEvents totalCocExceed3 As System.Windows.Forms.TextBox
    Friend WithEvents totalconc3 As System.Windows.Forms.TextBox
    Friend WithEvents totalCocExceed60 As System.Windows.Forms.TextBox
    Friend WithEvents totalconc60 As System.Windows.Forms.TextBox
    Friend WithEvents totalCocExceed28 As System.Windows.Forms.TextBox
    Friend WithEvents totalconc28 As System.Windows.Forms.TextBox
    Friend WithEvents Label105 As System.Windows.Forms.Label
    Friend WithEvents totalCocExceed7 As System.Windows.Forms.TextBox
    Friend WithEvents totalCocExceed1 As System.Windows.Forms.TextBox
    Friend WithEvents Label103 As System.Windows.Forms.Label
    Friend WithEvents Label102 As System.Windows.Forms.Label
    Friend WithEvents Label101 As System.Windows.Forms.Label
    Friend WithEvents pwcocUserExceed As System.Windows.Forms.TextBox
    Friend WithEvents pwconcUserbox As System.Windows.Forms.TextBox
    Friend WithEvents UserDaysWater As System.Windows.Forms.Label
    Friend WithEvents cocUserexceed As System.Windows.Forms.TextBox
    Friend WithEvents Label99 As System.Windows.Forms.Label
    Friend WithEvents concUserBox As System.Windows.Forms.TextBox
    Friend WithEvents UserDaysBenthic As System.Windows.Forms.Label
    Friend WithEvents Label116 As System.Windows.Forms.Label
    Friend WithEvents Label115 As System.Windows.Forms.Label
    Friend WithEvents Label114 As System.Windows.Forms.Label
    Friend WithEvents Label113 As System.Windows.Forms.Label
    Friend WithEvents Label112 As System.Windows.Forms.Label
    Friend WithEvents Label111 As System.Windows.Forms.Label
    Friend WithEvents Label110 As System.Windows.Forms.Label
    Friend WithEvents Label109 As System.Windows.Forms.Label
    Friend WithEvents Label108 As System.Windows.Forms.Label
    Friend WithEvents benthicTotalOut As System.Windows.Forms.TextBox
    Friend WithEvents benthicHydrolysisOut As System.Windows.Forms.TextBox
    Friend WithEvents benthicMetabolismOut As System.Windows.Forms.TextBox
    Friend WithEvents photolysisOut As System.Windows.Forms.TextBox
    Friend WithEvents hydrolysisOut As System.Windows.Forms.TextBox
    Friend WithEvents TotalOut As System.Windows.Forms.TextBox
    Friend WithEvents volatileOut As System.Windows.Forms.TextBox
    Friend WithEvents metabolismOut As System.Windows.Forms.TextBox
    Friend WithEvents washoutOut As System.Windows.Forms.TextBox
    Friend WithEvents Label107 As System.Windows.Forms.Label
    Friend WithEvents Label106 As System.Windows.Forms.Label
    Friend WithEvents Label100 As System.Windows.Forms.Label
    Friend WithEvents PointSourceCalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveScenarioDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents RetrieveScenarioDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label117 As Label
    Friend WithEvents FlowAveraging As TextBox
End Class
