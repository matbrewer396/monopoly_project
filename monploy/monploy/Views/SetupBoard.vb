﻿Public Class SetupBoard
    Dim dtAviableIcons As DataTable = PlayerIcon.AvaibleIcons
    Dim LoadPlayer As New List(Of Player)

    Private Sub SetupBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbIcon.DataSource = dtAviableIcons
        cmbIcon.DisplayMember = "name"
        cmbIcon.ValueMember = "name"
    End Sub

    Private Sub btnAddPlayer_Click(sender As Object, e As EventArgs) Handles btnAddPlayer.Click

        If Not NameIsAvaiable(txtPlayerName.Text) Then
            MsgBox("Name is already taken, please use a different name.", MsgBoxStyle.Critical, "Name Already Taken")
            Exit Sub
        End If
        LoadPlayer.Add(New Player(txtPlayerName.Text, New PlayerIcon(dtAviableIcons.Rows.Find(cmbIcon.SelectedValue).Item("name") _
                                                                     , dtAviableIcons.Rows.Find(cmbIcon.SelectedValue).Item("path"))))
        lstPlayer.Items.Add(txtPlayerName.Text)
        lblNumOfPlayer.Text = "Number of Player: " & LoadPlayer.Count
    End Sub

    Function NameIsAvaiable(name) As Boolean

        For Each p As Player In LoadPlayer
            If p.name = name Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub btnStartGame_Click(sender As Object, e As EventArgs) Handles btnStartGame.Click
        If txtGameName.Text.Length < 3 Then
            MsgBox("Game name is not validated", MsgBoxStyle.Critical, "Game Name")
        End If

        If LoadPlayer.Count < 2 Then
            MsgBox("More then two player is requied.", MsgBoxStyle.Critical, "More Players")
        End If

        If LoadPlayer.Count > 6 Then
            MsgBox("max of 6 player", MsgBoxStyle.Critical, "Too Many Players")
        End If

        Dim b As New Board(txtPlayerName.Name, LoadPlayer)

        Dim boardForm As New frmBoard(b)
        boardForm.Show()
        Me.Dispose()

    End Sub
End Class