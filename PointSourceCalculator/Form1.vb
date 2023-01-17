Public Class Form1


    Private Sub Run_Click(sender As System.Object, e As System.EventArgs) Handles Run.Click



        Dim appPath As String
        Dim vvwmInputFilename As String

        If Not AreValuesGood() Then Return

        appPath = My.Application.Info.DirectoryPath()

        vvwmInputFilename = workingDirectoryBox.Text & "VVMMinput.txt"
        CreateVvwmFile(vvwmInputFilename)

        Dim startInfo As New System.Diagnostics.ProcessStartInfo(appPath & "\vvwm.exe", """" & vvwmInputFilename & """")



        ' startInfo.WindowStyle = ProcessWindowStyle.Hidden
        System.Diagnostics.Process.Start(startInfo).WaitForExit()



        Try
            processOutput()
            makeGraph()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub


    Private Sub SaveToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Dim result As System.Windows.Forms.DialogResult
        Dim msg As String


        SaveAllInputsDialog.Filter = "All Point Source Input (*.PSI)|*.PSI|ALL Files (*.*)|*.*"

        SaveAllInputsDialog.InitialDirectory = Variables.WorkingDirectory


        result = SaveAllInputsDialog.ShowDialog
        If result = Windows.Forms.DialogResult.Cancel Then
            Return
        End If

        Variables.WorkingDirectory = System.IO.Path.GetDirectoryName(SaveAllInputsDialog.FileName) & "\"
        workingDirectoryBox.Text = Variables.WorkingDirectory

        Variables.ioFamilyFilename = System.IO.Path.GetFileNameWithoutExtension(SaveAllInputsDialog.FileName)
        ioFamilyNameBox.Text = Variables.ioFamilyFilename


        msg = SaveChemicalInputs() & SaveScenarioInputs()

        Try
            My.Computer.FileSystem.WriteAllText(SaveAllInputsDialog.FileName, msg, False, System.Text.Encoding.ASCII)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Function SaveChemicalInputs() As String

        Dim msg As String

        msg = "PSC Version: " & DescriptionVariables.VersionNumber
        msg = msg & vbNewLine & chemIdBox.Text
        msg = msg & vbNewLine
        msg = msg & vbNewLine & isKoc.Checked
        msg = msg & vbNewLine & sorptionBox.Text
        msg = msg & vbNewLine
        msg = msg & vbNewLine
        msg = msg & vbNewLine & waterMetabBox.Text & "," & RefTempWaterBox.Text
        msg = msg & vbNewLine & photoBox.Text & "," & RefLatBox.Text
        msg = msg & vbNewLine & hydrolBox.Text & "," & RefTempHydrBox.Text
        msg = msg & vbNewLine & benthicBox.Text & "," & RefTempBenthBox.Text
        msg = msg & vbNewLine

        msg = msg & vbNewLine & NoVolatilization.Checked & "," & EstimateHenry.Checked & "," & gotHenry.Checked
        msg = msg & vbNewLine & mwtBox.Text
        msg = msg & vbNewLine & vpBox.Text
        msg = msg & vbNewLine & solBox.Text

        msg = msg & vbNewLine & henryBox.Text
        msg = msg & vbNewLine & HenryRefTempBox.Text
        msg = msg & vbNewLine & heatHenryBox.Text
        msg = msg & vbNewLine

        msg = msg & vbNewLine & is_SpecifiedMass.Checked & "," & UseTimeSeries.Checked & "," & orReadZTS.Checked & ","
        msg = msg & vbNewLine & use1.Checked & "," & use2.Checked & "," & use3.Checked
        msg = msg & vbNewLine & offsetBox1.Text & "," & offsetBox2.Text & "," & offsetBox3.Text
        msg = msg & vbNewLine & daysOnBox1.Text & "," & daysOnBox2.Text & "," & daysOnBox3.Text
        msg = msg & vbNewLine & daysOffBox1.Text & "," & daysOffBox2.Text & "," & daysOffBox3.Text
        msg = msg & vbNewLine & massReleaseBox1.Text & "," & massReleaseBox2.Text & "," & massReleaseBox3.Text

        msg = msg & vbNewLine & TimeSeriesFileBox.Text

        msg = msg & vbNewLine & ZTSFileBox.Text
        msg = msg & vbNewLine & WatershedAreaBox.Text
        msg = msg & vbNewLine
        msg = msg & vbNewLine
        msg = msg & vbNewLine
        msg = msg & vbNewLine & WriteDesiredOutputInfo()

        msg = msg & vbNewLine
        Return msg
    End Function

    Private Function SaveScenarioInputs() As String
        Dim msg As String

        msg = "******** Scenario Inputs Follow:   ***********"
        msg = msg & vbNewLine & "PSC Version: " & DescriptionVariables.VersionNumber
        msg = msg & vbNewLine & scenarioIdBox.Text
        msg = msg & vbNewLine & weatherBox.Text
        msg = msg & vbNewLine

        msg = msg & vbNewLine & widthBox.Text
        msg = msg & vbNewLine & depthBox.Text
        msg = msg & vbNewLine & lengthBox.Text
        msg = msg & vbNewLine & FlowAveraging.Text
        msg = msg & vbNewLine
        msg = msg & vbNewLine & is_ConstFlow.Checked
        msg = msg & vbNewLine & constFlowBox.Text
        msg = msg & vbNewLine
        msg = msg & vbNewLine
        msg = msg & vbNewLine
        msg = msg & vbNewLine

        msg = msg & vbNewLine & dfacBox.Text
        msg = msg & vbNewLine & ssBox.Text
        msg = msg & vbNewLine & ChlorophyllBox.Text
        msg = msg & vbNewLine & foc1Box.Text
        msg = msg & vbNewLine & DOC1Box.Text
        msg = msg & vbNewLine & Biomass1Box.Text
        msg = msg & vbNewLine & benthicdepthBox.Text
        msg = msg & vbNewLine & porosityBox.Text
        msg = msg & vbNewLine & bdBox.Text
        msg = msg & vbNewLine & foc2Box.Text
        msg = msg & vbNewLine & DOC2Box.Text
        msg = msg & vbNewLine & biomass2Box.Text
        msg = msg & vbNewLine & massXferBox.Text



        Return msg
    End Function

    Private Sub GetWeather_Click(sender As System.Object, e As System.EventArgs) Handles GetWeather.Click
        Dim result As System.Windows.Forms.DialogResult
        GetWeatherDialog.Filter = "DVF files (*.DVF)|*.DVF|MET files (*.MET)|*.MET|All files (*.*)|*.*"

        If System.IO.Directory.Exists(Variables.weatherpath) Then
            GetWeatherDialog.InitialDirectory = Variables.weatherpath
        End If

        result = GetWeatherDialog.ShowDialog() 'display Open dialog box

        'Cancel button will cuase return without further execution
        If result = Windows.Forms.DialogResult.Cancel Then
            Return
        End If

        weatherBox.Text = GetWeatherDialog.FileName
        Variables.weatherpath = System.IO.Path.GetDirectoryName(GetWeatherDialog.FileName)

    End Sub

    Private Sub RetrieveToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RetrieveToolStripMenuItem.Click
        Dim result As System.Windows.Forms.DialogResult
        GetAllInputsDialog.Filter = "All Point Source Input (*.PSI)|*.PSI|ALL Files (*.*)|*.*"
        '  OpenFileDialog1.ShowDialog()

        GetAllInputsDialog.InitialDirectory = Variables.WorkingDirectory
        GetAllInputsDialog.FileName = ""

        result = GetAllInputsDialog.ShowDialog(Me)

        'Cancel button will cuase return without further execution
        If result = Windows.Forms.DialogResult.Cancel Then
            Return
        End If

        ' Dim ofile As New System.IO.StreamReader(OpenFileDialog1.FileName)


        Variables.WorkingDirectory = System.IO.Path.GetDirectoryName(GetAllInputsDialog.FileName) & "\"
        workingDirectoryBox.Text = Variables.WorkingDirectory


        'FamilyFileName = System.IO.Path.GetFileNameWithoutExtension(OpenFileDialog1.FileName)
        'ioFamilyNameBox.Text = FamilyFileName

        ioFamilyNameBox.Text = System.IO.Path.GetFileNameWithoutExtension(GetAllInputsDialog.FileName)


        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(GetAllInputsDialog.FileName)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")

            loadChemicalInputs(MyReader)
            loadScenarioInputs(MyReader)

        End Using


    End Sub

    Private Sub loadChemicalInputs(ByVal ofile As Microsoft.VisualBasic.FileIO.TextFieldParser)
        Dim currentrow As String()

        Try
            ofile.ReadLine()                           'Line 1: version number line
            chemIdBox.Text = ofile.ReadLine()          'Line 2: Chemical ID
            ofile.ReadLine()
            isKoc.Checked = ofile.ReadLine()
            sorptionBox.Text = ofile.ReadLine()        'Line 5: Sorption Coefficient Value
            ofile.ReadLine()
            ofile.ReadLine()

            currentrow = ofile.ReadFields()
            waterMetabBox.Text = currentrow(0)
            RefTempWaterBox.Text = currentrow(1)

            currentrow = ofile.ReadFields()
            photoBox.Text = currentrow(0)
            RefLatBox.Text = currentrow(1)

            currentrow = ofile.ReadFields()
            hydrolBox.Text = currentrow(0)
            RefTempHydrBox.Text = currentrow(1)

            currentrow = ofile.ReadFields()
            benthicBox.Text = currentrow(0)
            RefTempBenthBox.Text = currentrow(1)


            ofile.ReadLine()
            currentrow = ofile.ReadFields()
            NoVolatilization.Checked = currentrow(0)
            EstimateHenry.Checked = currentrow(1)
            gotHenry.Checked = currentrow(2)

            mwtBox.Text = ofile.ReadLine()
            vpBox.Text = ofile.ReadLine()
            solBox.Text = ofile.ReadLine()

            henryBox.Text = ofile.ReadLine()
            HenryRefTempBox.Text = ofile.ReadLine()
            heatHenryBox.Text = ofile.ReadLine()
            ofile.ReadLine()

            currentrow = ofile.ReadFields()               'Line 21
            is_SpecifiedMass.Checked = currentrow(0)
            UseTimeSeries.Checked = currentrow(1)
            orReadZTS.Checked = currentrow(2)

            currentrow = ofile.ReadFields()               'Line 22
            use1.Checked = currentrow(0)
            use2.Checked = currentrow(1)
            use3.Checked = currentrow(2)

            currentrow = ofile.ReadFields()
            offsetBox1.Text = currentrow(0)
            offsetBox2.Text = currentrow(1)
            offsetBox3.Text = currentrow(2)

            currentrow = ofile.ReadFields()
            daysOnBox1.Text = currentrow(0)
            daysOnBox2.Text = currentrow(1)
            daysOnBox3.Text = currentrow(2)

            currentrow = ofile.ReadFields()
            daysOffBox1.Text = currentrow(0)
            daysOffBox2.Text = currentrow(1)
            daysOffBox3.Text = currentrow(2)


            currentrow = ofile.ReadFields()
            massReleaseBox1.Text = currentrow(0)
            massReleaseBox2.Text = currentrow(1)
            massReleaseBox3.Text = currentrow(2)

            TimeSeriesFileBox.Text = ofile.ReadLine()    'Line 27

            ZTSFileBox.Text = ofile.ReadLine()           'Line 28
            WatershedAreaBox.Text = ofile.ReadLine()     'Line 29
            ofile.ReadLine()
            ofile.ReadLine()
            ofile.ReadLine()
            ofile.ReadLine()   'holds description
            ofile.ReadLine()   'holds number of endpoints for water column (not used in GUI at this time)

            currentrow = ofile.ReadFields()
            UserDefinedDaysWater.Text = currentrow(8)

            ofile.ReadLine()
            currentrow = ofile.ReadFields()   'holds number of endpoints for benthic (not used in GUI at this time)
            UserDefinedDaysBenthic.Text = currentrow(5)

            isToxicityAnalysis.Checked = ofile.ReadLine()

            currentrow = ofile.ReadFields()
            CoC1box.Text = currentrow(0)
            CoC2box.Text = currentrow(1)
            CoC3box.Text = currentrow(2)
            CoC4box.Text = currentrow(3)
            Coc7box.Text = currentrow(4)
            Coc21box.Text = currentrow(5)
            Coc28box.Text = currentrow(6)
            CoC60box.Text = currentrow(7)
            CocUserWaterBox.Text = currentrow(8)


            currentrow = ofile.ReadFields()
            CocPoreWater1box.Text = currentrow(0)
            CocPoreWater3box.Text = currentrow(1)
            CocPoreWater7box.Text = currentrow(2)
            CocPoreWater28box.Text = currentrow(3)
            CocPoreWater60box.Text = currentrow(4)
            CocPoreWaterUserBox.Text = currentrow(5)

            currentrow = ofile.ReadFields()
            CoCTotal1Box.Text = currentrow(0)
            CoCTotal3Box.Text = currentrow(1)
            CoCTotal7Box.Text = currentrow(2)
            CoCTotal28Box.Text = currentrow(3)
            CoCTotal60Box.Text = currentrow(4)
            CoCTotalUserBox.Text = currentrow(5)

            ofile.ReadLine()

        Catch ex As Exception
            MsgBox("Check input File version. Failed at chem inputs.")
            Return
        End Try



    End Sub

    Private Sub loadScenarioInputs(ByVal ofile As Microsoft.VisualBasic.FileIO.TextFieldParser)
        Try
            ofile.ReadLine()                           'Line 1 "******** Scenario Inputs Follow:   ***********"
            ofile.ReadLine()                           'Line 2 Version Number
            scenarioIdBox.Text = ofile.ReadLine()
            weatherBox.Text = ofile.ReadLine()
            ofile.ReadLine()

            widthBox.Text = ofile.ReadLine()
            depthBox.Text = ofile.ReadLine()
            lengthBox.Text = ofile.ReadLine()
            FlowAveraging.Text = ofile.ReadLine()
            ofile.ReadLine()

            is_ConstFlow.Checked = ofile.ReadLine()
            If Not (is_ConstFlow.Checked) Then
                noBaseFlow.Checked = True
            End If
            constFlowBox.Text = ofile.ReadLine()
            ofile.ReadLine()
            ofile.ReadLine()
            ofile.ReadLine()
            ofile.ReadLine()


            dfacBox.Text = ofile.ReadLine()
            ssBox.Text = ofile.ReadLine()
            ChlorophyllBox.Text = ofile.ReadLine()
            foc1Box.Text = ofile.ReadLine()
            DOC1Box.Text = ofile.ReadLine()
            Biomass1Box.Text = ofile.ReadLine()
            benthicdepthBox.Text = ofile.ReadLine()
            porosityBox.Text = ofile.ReadLine()
            bdBox.Text = ofile.ReadLine()
            foc2Box.Text = ofile.ReadLine()
            DOC2Box.Text = ofile.ReadLine()
            biomass2Box.Text = ofile.ReadLine()
            massXferBox.Text = ofile.ReadLine()





        Catch ex As Exception
            MsgBox(ex.Message & "Failed at scenario inputs.")
            Return
        End Try

    End Sub

    Private Sub processOutput()

        Dim filename As String

        filename = workingDirectoryBox.Text & Trim(ioFamilyNameBox.Text) & "_" & Trim(scenarioIdBox.Text) & "_Parent.txt"

        Try

            Using reader As New Microsoft.VisualBasic.FileIO.TextFieldParser(filename)

                reader.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.FixedWidth


                Dim number As Single
                Dim currentrow As String()


                Dim maxPeak As Single = 0.0

                'skip the Header Lines
                For i As Integer = 1 To 15
                    reader.ReadLine()
                Next


                reader.SetFieldWidths(26, 10, 9, -1)

                currentrow = reader.ReadFields()
                number = currentrow(1)
                conc1box.Text = number
                coc1exceed.Text = currentrow(2)


                currentrow = reader.ReadFields()
                number = currentrow(1)
                conc2box.Text = number
                coc2exceed.Text = currentrow(2)

                currentrow = reader.ReadFields()
                number = currentrow(1)
                conc3box.Text = number
                coc3exceed.Text = currentrow(2)

                currentrow = reader.ReadFields()
                number = currentrow(1)
                conc4box.Text = number
                coc4exceed.Text = currentrow(2)

                currentrow = reader.ReadFields()
                number = currentrow(1)
                conc7box.Text = number
                coc7exceed.Text = currentrow(2)

                currentrow = reader.ReadFields()
                number = currentrow(1)
                conc21box.Text = number
                coc21exceed.Text = currentrow(2)

                currentrow = reader.ReadFields()
                number = currentrow(1)
                conc28box.Text = number
                coc28exceed.Text = currentrow(2)

                currentrow = reader.ReadFields()
                number = currentrow(1)
                conc60box.Text = number
                coc60exceed.Text = currentrow(2)

                currentrow = reader.ReadFields()
                number = currentrow(1)
                concUserBox.Text = number
                cocUserexceed.Text = currentrow(2)
                UserDaysWater.Text = UserDefinedDaysWater.Text


                reader.ReadLine()
                reader.ReadLine()
                reader.ReadLine()
                reader.ReadLine()
                reader.ReadLine()

                currentrow = reader.ReadFields()
                number = currentrow(1)
                pwconc1box.Text = number
                pwcoc1exceed.Text = currentrow(2)

                currentrow = reader.ReadFields()
                number = currentrow(1)
                pwconc3box.Text = number
                pwcoc3exceed.Text = currentrow(2)

                currentrow = reader.ReadFields()
                number = currentrow(1)
                pwconc7box.Text = number
                pwcoc7exceed.Text = currentrow(2)

                currentrow = reader.ReadFields()
                number = currentrow(1)
                pwconc28box.Text = number
                pwcoc28exceed.Text = currentrow(2)

                currentrow = reader.ReadFields()
                number = currentrow(1)
                pwconc60box.Text = number
                pwcoc60exceed.Text = currentrow(2)

                currentrow = reader.ReadFields()
                number = currentrow(1)
                pwconcUserbox.Text = number
                pwcocUserExceed.Text = currentrow(2)

                UserDaysBenthic.Text = UserDefinedDaysBenthic.Text



                reader.ReadLine()
                reader.ReadLine()
                reader.ReadLine()

                reader.SetFieldWidths(33, 10, -1)
                currentrow = reader.ReadFields()
                dryConversionBox.Text = currentrow(1)

                currentrow = reader.ReadFields()
                wetConversionBox.Text = currentrow(1)

                reader.ReadLine()
                reader.ReadLine()
                reader.ReadLine()
                reader.ReadLine()
                reader.ReadLine()
                reader.ReadLine()

                reader.SetFieldWidths(26, 10, 9, -1)

                currentrow = reader.ReadFields()
                number = currentrow(1)
                totalconc1.Text = number
                totalCocExceed1.Text = currentrow(2)

                currentrow = reader.ReadFields()
                number = currentrow(1)
                totalconc3.Text = number
                totalCocExceed3.Text = currentrow(2)

                currentrow = reader.ReadFields()
                number = currentrow(1)
                totalconc7.Text = number
                totalCocExceed7.Text = currentrow(2)

                currentrow = reader.ReadFields()
                number = currentrow(1)
                totalconc28.Text = number
                totalCocExceed28.Text = currentrow(2)

                currentrow = reader.ReadFields()
                number = currentrow(1)
                totalconc60.Text = number
                totalCocExceed60.Text = currentrow(2)

                currentrow = reader.ReadFields()
                number = currentrow(1)
                totalconcUser.Text = number
                totalCocExceedUser.Text = currentrow(2)

                reader.ReadLine()
                reader.ReadLine()


                reader.SetFieldWidths(51, -1)

                currentrow = reader.ReadFields()
                AqPhase1.Text = currentrow(1)

                currentrow = reader.ReadFields()
                ssPhase1.Text = currentrow(1)

                currentrow = reader.ReadFields()
                docPhase1.Text = currentrow(1)

                currentrow = reader.ReadFields()
                bioPhase1.Text = currentrow(1)

                currentrow = reader.ReadFields()
                aqPhase2.Text = currentrow(1)

                currentrow = reader.ReadFields()
                aqPhaseTotal.Text = currentrow(1)

                reader.ReadLine()
                reader.ReadLine()
                reader.ReadLine()

                currentrow = reader.ReadFields()
                washoutOut.Text = currentrow(1)

                currentrow = reader.ReadFields()
                metabolismOut.Text = currentrow(1)

                currentrow = reader.ReadFields()
                hydrolysisOut.Text = currentrow(1)

                currentrow = reader.ReadFields()
                photolysisOut.Text = currentrow(1)

                currentrow = reader.ReadFields()
                volatileOut.Text = currentrow(1)

                currentrow = reader.ReadFields()
                TotalOut.Text = currentrow(1)

                reader.ReadLine()
                reader.ReadLine()

                currentrow = reader.ReadFields()
                benthicMetabolismOut.Text = currentrow(1)


                currentrow = reader.ReadFields()
                benthicHydrolysisOut.Text = currentrow(1)

                currentrow = reader.ReadFields()
                benthicTotalOut.Text = currentrow(1)

            End Using

        Catch ex As Exception

            MsgBox("Error could be in the Scenario ID naming you used.  Do not use characters that could be interpreted as directory descriptors such as '\' and ':'." &
                   ex.Message & "  Post processing aborted.")
        End Try

    End Sub

    Private Sub makeGraph()
        Dim filename As String
        filename = workingDirectoryBox.Text & Trim(ioFamilyNameBox.Text) & "_" & Trim(scenarioIdBox.Text) & "_Parent_daily.txt"

        Using reader As New Microsoft.VisualBasic.FileIO.TextFieldParser(filename)
            Dim currentrow As String()

            reader.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.FixedWidth
            reader.SetFieldWidths(15, 15, 15, -1)

            reader.ReadLine() 'skip 6 lines
            reader.ReadLine()
            reader.ReadLine()
            reader.ReadLine()
            reader.ReadLine()
            reader.ReadLine()

            'clear all point from previous run
            Chart1.Series("Water Column (Total)").Points.Clear()
            Chart1.Series("Pore Water").Points.Clear()

            While Not reader.EndOfData
                currentrow = reader.ReadFields()

                Chart1.Series("Water Column (Total)").Points.AddY(currentrow(1))
                Chart1.Series("Pore Water").Points.AddY(currentrow(2))
            End While

        End Using



    End Sub

    Private Sub CreateVvwmFile(ByVal filename As String)
        Dim msg As String

        msg = workingDirectoryBox.Text & ioFamilyNameBox.Text
        msg = msg & vbNewLine & DescriptionVariables.Characterization_1
        msg = msg & vbNewLine & DescriptionVariables.Characterization_2
        msg = msg & vbNewLine & DescriptionVariables.Characterization_3

        msg = msg & vbNewLine & chemIdBox.Text

        msg = msg & vbNewLine & "1"
        msg = msg & vbNewLine & isKoc.Checked
        msg = msg & vbNewLine & sorptionBox.Text

        msg = msg & vbNewLine & HalflifeToRate(waterMetabBox)             ' waterMetabBox.Text
        msg = msg & vbNewLine & NumberFiller(RefTempWaterBox)

        msg = msg & vbNewLine & HalflifeToRate(benthicBox)
        msg = msg & vbNewLine & NumberFiller(RefTempBenthBox)

        'msg = msg & vbNewLine & photoBox.Text
        'msg = msg & vbNewLine & RefLatBox.Text

        msg = msg & vbNewLine & HalflifeToRate(photoBox)
        msg = msg & vbNewLine & NumberFiller(RefLatBox)

        msg = msg & vbNewLine & HalflifeToRate(hydrolBox)
        msg = msg & vbNewLine & NumberFiller(RefTempHydrBox)

        'msg = msg & vbNewLine & hydrolBox.Text
        'msg = msg & vbNewLine & RefTempHydrBox.Text

        msg = msg & vbNewLine
        msg = msg & vbNewLine
        msg = msg & vbNewLine
        msg = msg & vbNewLine & NoVolatilization.Checked & "," & EstimateHenry.Checked & "," & gotHenry.Checked
        msg = msg & vbNewLine & mwtBox.Text
        msg = msg & vbNewLine & vpBox.Text
        msg = msg & vbNewLine & solBox.Text

        msg = msg & vbNewLine & henryBox.Text
        msg = msg & vbNewLine & heatHenryBox.Text
        msg = msg & vbNewLine & HenryRefTempBox.Text

        msg = msg & vbNewLine & "0,0"  'molar conversions
        msg = msg & vbNewLine & "0,0"
        msg = msg & vbNewLine & "0,0"
        msg = msg & vbNewLine & "0,0"
        msg = msg & vbNewLine & "2.0"  'Q10

        msg = msg & vbNewLine & is_SpecifiedMass.Checked & "," & UseTimeSeries.Checked & "," & orReadZTS.Checked

        msg = msg & vbNewLine & use1.Checked
        msg = msg & vbNewLine & offsetBox1.Text
        msg = msg & vbNewLine & daysOnBox1.Text
        msg = msg & vbNewLine & daysOffBox1.Text
        msg = msg & vbNewLine & massReleaseBox1.Text

        msg = msg & vbNewLine & use2.Checked
        msg = msg & vbNewLine & offsetBox2.Text
        msg = msg & vbNewLine & daysOnBox2.Text
        msg = msg & vbNewLine & daysOffBox2.Text
        msg = msg & vbNewLine & massReleaseBox2.Text

        msg = msg & vbNewLine & use3.Checked
        msg = msg & vbNewLine & offsetBox3.Text
        msg = msg & vbNewLine & daysOnBox3.Text
        msg = msg & vbNewLine & daysOffBox3.Text
        msg = msg & vbNewLine & massReleaseBox3.Text

        msg = msg & vbNewLine & TimeSeriesFileBox.Text


        msg = msg & vbNewLine & ZTSFileBox.Text
        msg = msg & vbNewLine & WatershedAreaBox.Text    'area of field


        msg = msg & vbNewLine & "0"  'napp
        msg = msg & vbNewLine  'dates for spray
        msg = msg & vbNewLine  'spray mass

        msg = msg & vbNewLine & scenarioIdBox.Text
        msg = msg & vbNewLine & weatherBox.Text
        msg = msg & vbNewLine
        msg = msg & vbNewLine
        msg = msg & vbNewLine
        msg = msg & vbNewLine & "FALSE"
        msg = msg & vbNewLine
        msg = msg & vbNewLine
        msg = msg & vbNewLine
        msg = msg & vbNewLine


        msg = msg & vbNewLine & massXferBox.Text
        msg = msg & vbNewLine & "0.5"
        msg = msg & vbNewLine & benthicdepthBox.Text
        msg = msg & vbNewLine & porosityBox.Text
        msg = msg & vbNewLine & bdBox.Text
        msg = msg & vbNewLine & foc2Box.Text
        msg = msg & vbNewLine & DOC2Box.Text
        msg = msg & vbNewLine & biomass2Box.Text
        msg = msg & vbNewLine & dfacBox.Text
        msg = msg & vbNewLine & ssBox.Text
        msg = msg & vbNewLine & ChlorophyllBox.Text
        msg = msg & vbNewLine & foc1Box.Text
        msg = msg & vbNewLine & DOC1Box.Text
        msg = msg & vbNewLine & Biomass1Box.Text
        msg = msg & vbNewLine
        msg = msg & vbNewLine
        msg = msg & vbNewLine

        msg = msg & vbNewLine & "5"  'Simulation Type

        msg = msg & vbNewLine & Convert.ToString(Convert.ToSingle(widthBox.Text) * Convert.ToSingle(lengthBox.Text))
        msg = msg & vbNewLine & depthBox.Text
        msg = msg & vbNewLine & depthBox.Text
        msg = msg & vbNewLine & FlowAveraging.Text 'flow averaging

        msg = msg & vbNewLine & is_ConstFlow.Checked

        If is_ConstFlow.Checked Then
            msg = msg & vbNewLine & Convert.ToSingle(constFlowBox.Text)
        Else
            msg = msg & vbNewLine & "0.0"
        End If


        msg = msg & vbNewLine & WriteDesiredOutputInfo()

        System.IO.Directory.SetCurrentDirectory(workingDirectoryBox.Text)
        My.Computer.FileSystem.WriteAllText(filename, msg, False, System.Text.Encoding.ASCII)

    End Sub

    Private Function WriteDesiredOutputInfo() As String
        Dim msg As String


        msg = "******* Output Info Follows:  *************"

        msg = msg & vbNewLine & "9"
        msg = msg & vbNewLine & "1,2,3,4,7,21,28,60," & UserDefinedDaysWater.Text & ","
        msg = msg & vbNewLine & "6"
        msg = msg & vbNewLine & "1,3,7,28,60," & UserDefinedDaysBenthic.Text & ","
        msg = msg & vbNewLine & isToxicityAnalysis.Checked
        msg = msg & vbNewLine & CoC1box.Text & "," & CoC2box.Text & "," & CoC3box.Text & "," & CoC4box.Text & "," &
                    Coc7box.Text & "," & Coc21box.Text & "," & Coc28box.Text & "," & CoC60box.Text & "," & CocUserWaterBox.Text & ","

        msg = msg & vbNewLine & CocPoreWater1box.Text & "," & CocPoreWater3box.Text & "," & CocPoreWater7box.Text & "," &
                    CocPoreWater28box.Text & "," & CocPoreWater60box.Text & "," & CocPoreWaterUserBox.Text & ","

        msg = msg & vbNewLine & CoCTotal1Box.Text & "," & CoCTotal3Box.Text & "," & CoCTotal7Box.Text & "," &
            CoCTotal28Box.Text & "," & CoCTotal60Box.Text & "," & CoCTotalUserBox.Text & ","

        msg = msg & vbNewLine

        Return msg

    End Function

    Private Function AreValuesGood() As Boolean
        AreValuesGood = True

        'Check whether the user has specified an input file and a directory specifying where to save output
        'This is done by either saving a ne inpit file or retrieving an old input file
        Dim inputname As String
        inputname = workingDirectoryBox.Text & "/" & ioFamilyNameBox.Text & ".psi"
        If Not System.IO.File.Exists(inputname) Then
            MsgBox("You must first use File/Save All or File/Retrieve All to specify an input/output location")
            Return False
        End If

        If TestRealNumbers(sorptionBox) = False Then Return False

        'New: degradation rates are transferred to the VVWM instaed of halfives
        ' this gets rid of the Zero halflife flag, which is counterintuitive if you think about it

        If TestRealNumbers(waterMetabBox, "") = False Then Return False
        If waterMetabBox.Text = "" Then
            If TestRealNumbers(RefTempWaterBox, "") = False Then Return False
        Else
            If TestForZero(waterMetabBox) = False Then Return False
            If TestRealNumbers(RefTempWaterBox) = False Then Return False
        End If

        'If TestRealNumbers(photoBox, "") = False Then Return False
        'If photoBox.Text = "" Then
        '    If TestRealNumbers(RefLatBox, "") = False Then Return False
        'Else
        '    If TestRealNumbers(RefLatBox) = False Then Return False
        'End If

        If TestRealNumbers(photoBox, "") = False Then Return False
        If photoBox.Text = "" Then
            If TestRealNumbers(RefLatBox, "") = False Then Return False
        Else
            If TestForZero(photoBox) = False Then Return False
            If TestRealNumbers(RefLatBox) = False Then Return False
        End If





        'If TestRealNumbers(hydrolBox, "") = False Then Return False
        'If hydrolBox.Text = "" Then
        '    If TestRealNumbers(RefTempHydrBox, "") = False Then Return False
        'Else
        '    If TestRealNumbers(RefTempHydrBox) = False Then Return False
        'End If


        If TestRealNumbers(hydrolBox, "") = False Then Return False
        If hydrolBox.Text = "" Then
            If TestRealNumbers(RefTempHydrBox, "") = False Then Return False
        Else
            If TestForZero(hydrolBox) = False Then Return False
            If TestRealNumbers(RefTempHydrBox) = False Then Return False
        End If




        'If TestRealNumbers(benthicBox, "") = False Then Return False
        'If benthicBox.Text = "" Then
        '    If TestRealNumbers(RefTempBenthBox, "") = False Then Return False
        'Else
        '    If TestRealNumbers(RefTempBenthBox) = False Then Return False
        'End If

        If TestRealNumbers(benthicBox, "") = False Then Return False
        If benthicBox.Text = "" Then
            If TestRealNumbers(RefTempBenthBox, "") = False Then Return False
        Else
            If TestForZero(benthicBox) = False Then Return False
            If TestRealNumbers(RefTempBenthBox) = False Then Return False
        End If



        If EstimateHenry.Checked Then
            If TestRealNumbers(mwtBox) = False Then Return False
            If TestRealNumbers(vpBox) = False Then Return False
            If TestRealNumbers(solBox) = False Then Return False
            If TestRealNumbers(heatHenryBox) = False Then Return False
            If TestRealNumbers(HenryRefTempBox) = False Then Return False

        End If


        If gotHenry.Checked Then
            If TestRealNumbers(mwtBox) = False Then Return False
            If TestRealNumbers(henryBox) = False Then Return False
            If TestRealNumbers(heatHenryBox) = False Then Return False
            If TestRealNumbers(HenryRefTempBox) = False Then Return False
        End If


        If is_SpecifiedMass.Checked Then

            If use1.Checked Then
                If TestIntegers(offsetBox1) = False Then Return False
                If TestIntegers(daysOnBox1) = False Then Return False
                If TestIntegers(daysOffBox1) = False Then Return False
                If TestRealNumbers(massReleaseBox1) = False Then Return False
            End If


            If use2.Checked Then
                If TestIntegers(offsetBox2) = False Then Return False
                If TestIntegers(daysOnBox2) = False Then Return False
                If TestIntegers(daysOffBox2) = False Then Return False
                If TestRealNumbers(massReleaseBox2) = False Then Return False
            End If

            If use3.Checked Then
                If TestIntegers(offsetBox3) = False Then Return False
                If TestIntegers(daysOnBox3) = False Then Return False
                If TestIntegers(daysOffBox3) = False Then Return False
                If TestRealNumbers(massReleaseBox3) = False Then Return False
            End If
        End If


        If DoesFileExist(weatherBox) = False Then Return False


        If orReadZTS.Checked Then
            If DoesFileExist(ZTSFileBox) = False Then Return False
            If TestRealNumbers(WatershedAreaBox) = False Then Return False
        End If


        If UseTimeSeries.Checked Then
            If DoesFileExist(TimeSeriesFileBox) = False Then Return False
        End If


        If TestRealNumbers(widthBox) = False Then Return False
        If TestRealNumbers(depthBox) = False Then Return False
        If TestRealNumbers(lengthBox) = False Then Return False

        If TestIntegers(FlowAveraging) = False Then Return False

        If is_ConstFlow.Checked Then
            If TestRealNumbers(constFlowBox) = False Then Return False
        End If



        If TestIntegers(UserDefinedDaysWater) = False Then Return False
        If TestIntegers(UserDefinedDaysBenthic) = False Then Return False



        If isToxicityAnalysis.Checked Then
            If TestRealNumbers(CoC1box) = False Then Return False
            If TestRealNumbers(CoC2box) = False Then Return False
            If TestRealNumbers(CoC3box) = False Then Return False
            If TestRealNumbers(CoC4box) = False Then Return False
            If TestRealNumbers(Coc7box) = False Then Return False
            If TestRealNumbers(Coc21box) = False Then Return False
            If TestRealNumbers(Coc28box) = False Then Return False
            If TestRealNumbers(CoC60box) = False Then Return False
            If TestRealNumbers(CocUserWaterBox) = False Then Return False

            If TestRealNumbers(CocPoreWater1box) = False Then Return False
            If TestRealNumbers(CocPoreWater3box) = False Then Return False
            If TestRealNumbers(CocPoreWater7box) = False Then Return False
            If TestRealNumbers(CocPoreWater28box) = False Then Return False
            If TestRealNumbers(CocPoreWater60box) = False Then Return False
            If TestRealNumbers(CocPoreWaterUserBox) = False Then Return False

            If TestRealNumbers(CoCTotal1Box) = False Then Return False
            If TestRealNumbers(CoCTotal3Box) = False Then Return False
            If TestRealNumbers(CoCTotal7Box) = False Then Return False
            If TestRealNumbers(CoCTotal28Box) = False Then Return False
            If TestRealNumbers(CoCTotal60Box) = False Then Return False
            If TestRealNumbers(CoCTotalUserBox) = False Then Return False

        End If


    End Function

    Private Sub BrowseZTS_Click(sender As System.Object, e As System.EventArgs) Handles BrowseZTS.Click

        Dim result As System.Windows.Forms.DialogResult
        BrowseZTSDialog.Filter = "ZTS files (*.ZTS)|*.ZTS|TXT files (*.TXT)|*.TXT|All files (*.*)|*.*"

        If System.IO.Directory.Exists(Variables.ZTSpath) Then
            BrowseZTSDialog.InitialDirectory = Variables.ZTSpath
        End If

        result = BrowseZTSDialog.ShowDialog() 'display Open dialog box

        'Cancel button will cuase return without further execution
        If result = Windows.Forms.DialogResult.Cancel Then
            Return
        End If

        ZTSFileBox.Text = BrowseZTSDialog.FileName
        Variables.ZTSpath = System.IO.Path.GetDirectoryName(BrowseZTSDialog.FileName)

    End Sub

    Private Sub BrowseTimeSeries_Click(sender As System.Object, e As System.EventArgs) Handles BrowseTimeSeries.Click

        Dim result As System.Windows.Forms.DialogResult
        BrowseTimeSeriesDialog.Filter = "TSF files (*.TSF)|*.TSF|TXT files (*.TXT)|*.TXT|All files (*.*)|*.*"

        If System.IO.Directory.Exists(Variables.TSFpath) Then
            BrowseTimeSeriesDialog.InitialDirectory = Variables.TSFpath
        End If

        result = BrowseTimeSeriesDialog.ShowDialog() 'display Open dialog box

        'Cancel button will cuase return without further execution
        If result = Windows.Forms.DialogResult.Cancel Then
            Return
        End If

        TimeSeriesFileBox.Text = BrowseTimeSeriesDialog.FileName
        Variables.TSFpath = System.IO.Path.GetDirectoryName(BrowseTimeSeriesDialog.FileName)


    End Sub

    Private Sub orReadZTS_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles orReadZTS.CheckedChanged
        If orReadZTS.Checked Then
            BrowseZTS.Visible = True
            Label48.Visible = True
            WatershedAreaBox.Visible = True
            Label49.Visible = True
            ZTSFileBox.Visible = True
        Else
            BrowseZTS.Visible = False
            Label48.Visible = False
            WatershedAreaBox.Visible = False
            Label49.Visible = False
            ZTSFileBox.Visible = False



        End If
    End Sub

    Private Sub UseTimeSeries_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles UseTimeSeries.CheckedChanged
        If UseTimeSeries.Checked Then
            TimeSeriesFileBox.Visible = True
            Label92.Visible = True
            BrowseTimeSeries.Visible = True
        Else
            TimeSeriesFileBox.Visible = False
            Label92.Visible = False
            BrowseTimeSeries.Visible = False
        End If
    End Sub

    Private Sub NoVolatilization_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles NoVolatilization.CheckedChanged

        If NoVolatilization.Checked Then
            mwtBox.Enabled = False
            vpBox.Enabled = False
            solBox.Enabled = False
            henryBox.Enabled = False
            heatHenryBox.Enabled = False
            HenryRefTempBox.Enabled = False

            mwtBox.Font = New Font(mwtBox.Font, mwtBox.Font.Style Or FontStyle.Strikeout)
            vpBox.Font = New Font(vpBox.Font, vpBox.Font.Style Or FontStyle.Strikeout)
            solBox.Font = New Font(solBox.Font, solBox.Font.Style Or FontStyle.Strikeout)
            henryBox.Font = New Font(henryBox.Font, henryBox.Font.Style Or FontStyle.Strikeout)
            heatHenryBox.Font = New Font(heatHenryBox.Font, heatHenryBox.Font.Style Or FontStyle.Strikeout)
            HenryRefTempBox.Font = New Font(HenryRefTempBox.Font, HenryRefTempBox.Font.Style Or FontStyle.Strikeout)

        End If

    End Sub

    Private Sub EstimateHenry_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles EstimateHenry.CheckedChanged
        If EstimateHenry.Checked Then
            mwtBox.Enabled = True
            vpBox.Enabled = True
            solBox.Enabled = True
            henryBox.Enabled = False
            heatHenryBox.Enabled = True
            HenryRefTempBox.Enabled = True


            mwtBox.Font = New Font(mwtBox.Font, mwtBox.Font.Style And Not FontStyle.Strikeout)
            vpBox.Font = New Font(vpBox.Font, vpBox.Font.Style And Not FontStyle.Strikeout)
            solBox.Font = New Font(solBox.Font, solBox.Font.Style And Not FontStyle.Strikeout)
            henryBox.Font = New Font(henryBox.Font, henryBox.Font.Style Or FontStyle.Strikeout)
            heatHenryBox.Font = New Font(heatHenryBox.Font, heatHenryBox.Font.Style And Not FontStyle.Strikeout)
            HenryRefTempBox.Font = New Font(HenryRefTempBox.Font, HenryRefTempBox.Font.Style And Not FontStyle.Strikeout)





        End If
    End Sub

    Private Sub gotHenry_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles gotHenry.CheckedChanged

        If gotHenry.Checked Then
            mwtBox.Enabled = True
            vpBox.Enabled = False
            solBox.Enabled = False
            henryBox.Enabled = True
            heatHenryBox.Enabled = True
            HenryRefTempBox.Enabled = True

            mwtBox.Font = New Font(mwtBox.Font, mwtBox.Font.Style And Not FontStyle.Strikeout)
            vpBox.Font = New Font(vpBox.Font, vpBox.Font.Style Or FontStyle.Strikeout)
            solBox.Font = New Font(solBox.Font, solBox.Font.Style Or FontStyle.Strikeout)
            henryBox.Font = New Font(henryBox.Font, henryBox.Font.Style And Not FontStyle.Strikeout)
            heatHenryBox.Font = New Font(heatHenryBox.Font, heatHenryBox.Font.Style And Not FontStyle.Strikeout)
            HenryRefTempBox.Font = New Font(HenryRefTempBox.Font, HenryRefTempBox.Font.Style And Not FontStyle.Strikeout)


        End If

    End Sub

    Private Sub CopyGraph_Click(sender As System.Object, e As System.EventArgs) Handles CopyGraph.Click
        ' Create a memory stream to save the chart image    
        Dim stream As New System.IO.MemoryStream()

        ' Save the chart image to the stream    
        Chart1.SaveImage(stream, System.Drawing.Imaging.ImageFormat.Bmp)

        ' Create a bitmap using the stream    
        Dim bmp As New Bitmap(stream)

        ' Save the bitmap to the clipboard    
        Clipboard.SetDataObject(bmp)
    End Sub

    Private Sub isToxicityAnalysis_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles isToxicityAnalysis.CheckedChanged
        If isToxicityAnalysis.Checked Then
            CoC1box.Enabled = True
            CoC2box.Enabled = True
            CocPoreWater1box.Enabled = True
        Else
            CoC1box.Enabled = False
            CoC2box.Enabled = False
            CocPoreWater1box.Enabled = False
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox(DescriptionVariables.About_info)
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Me.Text = DescriptionVariables.Characterization_1
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub SaveScenarioMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveScenarioMenuItem.Click
        Dim result As DialogResult
        Dim msg As String



        result = SaveScenarioDialog.ShowDialog
        If result = Windows.Forms.DialogResult.Cancel Then
            Return
        End If

        msg = SaveScenarioInputs()

        Try
            My.Computer.FileSystem.WriteAllText(SaveScenarioDialog.FileName, msg, False, System.Text.Encoding.ASCII)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub RetrieveScenarioMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetrieveScenarioMenuItem.Click

        Dim result As DialogResult


        result = RetrieveScenarioDialog.ShowDialog()
        If result = Windows.Forms.DialogResult.Cancel Then
            Return
        End If

        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(RetrieveScenarioDialog.FileName)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")

            loadScenarioInputs(MyReader)

        End Using


    End Sub
End Class
