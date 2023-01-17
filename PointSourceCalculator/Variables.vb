Public Class Variables

    Private Shared a As String
    Public Shared Property WorkingDirectory As String
        Get
            Return a
        End Get

        Set(value As String)
            a = value
        End Set
    End Property

    Private Shared b As String
    Public Shared Property ioFamilyFilename As String
        Get
            Return b
        End Get

        Set(value As String)
            b = value
        End Set
    End Property


    Private Shared c As String
    Public Shared Property weatherpath As String
        Get
            Return c
        End Get

        Set(value As String)
            c = value
        End Set
    End Property



    Private Shared d As String
    Public Shared Property ZTSpath As String
        Get
            Return d
        End Get

        Set(value As String)
            d = value
        End Set
    End Property


    Private Shared e As String
    Public Shared Property TSFpath As String
        Get
            Return e
        End Get

        Set(value As String)
            e = value
        End Set
    End Property


End Class
