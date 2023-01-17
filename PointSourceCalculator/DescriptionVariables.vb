Public Class DescriptionVariables
    Private Sub New()
        'Empty constructor to prevent instantiation of this purely static class
    End Sub

    Public Const VersionNumber As String = "1.06"
    Public Const Characterization_1 As String = "Point Source Calculator (version " & VersionNumber & "): Calculations by the VVWM"
    Public Const Characterization_2 As String = "United States Environmental Protection Agency"
    Public Const Characterization_3 As String = "Office of Chemical Safety and Pollution Prevention"


    Public const About_info As String = Characterization_1 & vbNewLine &
                                        "Contact:  Dirk F. Young" & vbNewLine &
                                         Characterization_2 & vbNewLine &
                                        "young.dirk@epa.gov"

End Class
