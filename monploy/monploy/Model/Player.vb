Public Class Player

    Private _name As String
    Public Property name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _Icon As PlayerIcon
    Public Property Icon() As PlayerIcon
        Get
            Return _Icon
        End Get
        Set(ByVal value As PlayerIcon)
            _Icon = value
        End Set
    End Property

    Sub New(name As String, icon As PlayerIcon)
        Me._name = name
        Me._Icon = icon
    End Sub



End Class
