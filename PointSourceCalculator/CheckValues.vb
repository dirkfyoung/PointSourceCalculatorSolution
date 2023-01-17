Module CheckValues


    Function DoesFileExist(ByVal name As TextBox) As Boolean

        DoesFileExist = True
        name.BackColor = Color.White

        If Not System.IO.File.Exists(name.Text) Then
            MsgBox("File does not exist:  " & name.Tag)
            name.BackColor = Color.Orange
            Return False
        End If


    End Function


    Public Function TestForZero(ByVal name As TextBox)
        TestForZero = True
        If name.Text = 0.0 Then
            MsgBox("Half-life value is too small for " & name.Tag & " Leave box empty if you have no value")
            name.BackColor = Color.Orange
            Return False
        End If
    End Function




    Function TestIntegers(ByVal name As TextBox) As Boolean
        Dim TestNumber As Integer
        Dim TestReal As Single
        name.BackColor = Color.White


        'test to see if its  a number
        TestIntegers = True
        Try
            TestNumber = name.Text
        Catch ex As Exception
            MsgBox("Check the value for " & name.Tag)
            name.BackColor = Color.Orange
            Return False
        End Try



        'testIntegers Today see if its an integer

        TestReal = name.Text
        If TestReal - TestNumber > 0.01 Then
            MsgBox("Check the value for " & name.Tag)
            name.BackColor = Color.Orange
            Return False
        End If



    End Function

    Function TestRealNumbers(ByVal name As TextBox) As Boolean
        Dim TestNumber As Double
        TestRealNumbers = True
        name.BackColor = Color.White
        Try
            TestNumber = name.Text
        Catch ex As Exception
            MsgBox("Check the value for " & name.Tag)
            name.BackColor = Color.Orange
            Return False
        End Try

    End Function

    Function TestRealNumbers(ByVal name As TextBox, ByVal except As String) As Boolean
        'this overload will allow exceptions to the real number requirement, For example the null string would
        'indicate a zero rate of degradation if box is left blank
        Dim TestNumber As Double
        TestRealNumbers = True
        name.BackColor = Color.White

        If name.Text = except Then
            Return True
        Else
            Try
                TestNumber = name.Text
            Catch ex As Exception
                MsgBox("Check the value for " & name.Tag)
                name.BackColor = Color.Orange
                Return False
            End Try
        End If

    End Function

    Sub ZeroCheck(ByVal name As TextBox)
        Dim MaxHalfLifeMessage As String
        MaxHalfLifeMessage = "A zero Half Life in this program is a flag for a stable compound. Default half Life is 1e8 for "

        If name.Text = 0 Then
            name.Text = "1e8"
            MsgBox(MaxHalfLifeMessage & name.Tag)
        End If
    End Sub



    Function CalendarCheck(ByVal dayBox As TextBox, ByVal monthBox As TextBox) As Boolean

        Dim monthtest As Integer
        Dim daytest As Integer
        dayBox.BackColor = Color.White
        monthBox.BackColor = Color.White
        CalendarCheck = True

        Try
            monthtest = Convert.ToInt16(monthBox.Text)
        Catch
            MsgBox("  Check " & monthBox.Tag)
            monthBox.BackColor = Color.Orange
            Return False
        End Try


        Try
            daytest = Convert.ToInt16(dayBox.Text)
        Catch
            MsgBox(" Check " & dayBox.Tag)
            dayBox.BackColor = Color.Orange
            Return False
        End Try

        If monthtest > 12 Or monthtest < 1 Then
            MsgBox("The following month is not posssible: " & monthBox.Tag)
            monthBox.BackColor = Color.Orange
            Return False
        End If

        Select Case monthtest
            Case 1, 3, 5, 7, 8, 10, 12
                If daytest > 31 Or daytest < 1 Then
                    MsgBox("Bad day for " & dayBox.Tag)
                    dayBox.BackColor = Color.Orange
                    Return False
                End If
            Case 2
                If daytest > 28 Or daytest < 1 Then
                    MsgBox("Bad day for " & dayBox.Tag)
                    dayBox.BackColor = Color.Orange
                    Return False
                End If
            Case 4, 6, 9, 11
                If daytest > 30 Or daytest < 1 Then
                    MsgBox("Bad day for " & dayBox.Tag)
                    dayBox.BackColor = Color.Orange
                    Return False
                End If
            Case Else
                MsgBox("Month does not exist on Earth calendar for " & monthBox.Tag)

                monthBox.BackColor = Color.Orange
                Return False
        End Select

        CalendarCheck = 1
    End Function


End Module
