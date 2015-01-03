Public Class PlayerInfoBar



    Public Sub New(p As List(Of Player))
        InitializeComponent()
        Try
            PlayerInfo1.p = p(0)
            PlayerInfo2.p = p(1)
            PlayerInfo3.p = p(2)
            PlayerInfo4.p = p(3)
            PlayerInfo5.p = p(4)
            PlayerInfo6.p = p(5)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



End Class
