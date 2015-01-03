Public Class PlayerInfo

    Public p As Player
    Private Sub PlayerInfo_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            lblCash.Text = "$" & p.Cash
            lblPlayerName.Text = p.Name
            BackPannel.BackColor = p.BackColour
        Catch ex As Exception

        End Try

    End Sub
End Class
