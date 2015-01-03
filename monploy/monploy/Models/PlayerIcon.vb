Public Class PlayerIcon

    Private _name As String
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _path As String
    Public Property Path() As String
        Get
            Return _path
        End Get
        Set(ByVal value As String)
            _path = value
        End Set
    End Property

    Sub New(name As String, path As String)
        Me._name = name
        Me._path = path
    End Sub

    Shared Function AvaibleIcons() As DataTable
        'load icon
        Dim r As New DataTable("AvaibleIcons")
        r.Columns.Add("Name")
        r.Columns.Add("Path")
        Dim keyColumn(0) As DataColumn
        keyColumn(0) = r.Columns("Name")
        r.PrimaryKey = keyColumn

        
        Dim row As DataRow


        row = r.NewRow()
        row("Name") = "Car"
        row("path") = "Image\car.jpeg"
        r.Rows.Add(row)

        row = r.NewRow()
        row("Name") = "Boat"
        row("path") = "Image\boat.jpeg"
        r.Rows.Add(row)
        Return r
    End Function



End Class
