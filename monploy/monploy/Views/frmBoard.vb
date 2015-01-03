Public Class frmBoard
    Dim b As Board
    Public Sub New(_b As Board)
        InitializeComponent()
        b = _b
    End Sub

    Private Sub frmBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As New FrmFirstRoll(b.Players)

        f.ShowDialog()


    End Sub

 
End Class
