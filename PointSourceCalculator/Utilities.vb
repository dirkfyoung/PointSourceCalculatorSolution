Module Utilities
    Public Function HalflifeToRate(ByVal name As TextBox) As Single
        If name.Text = "" Then
            HalflifeToRate = 0.0
        Else
            HalflifeToRate = 0.00000802253681 / Convert.ToSingle(name.Text)     ' 0.69314718/halflife/86400.
        End If
    End Function


    Public Function NumberFiller(ByVal name As TextBox) As Single
        If name.Text = "" Then
            NumberFiller = 0.0                  'filler for fortran read
        Else
            NumberFiller = name.Text
        End If
    End Function
End Module
