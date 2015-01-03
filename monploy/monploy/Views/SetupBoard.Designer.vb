<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetupBoard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnStartGame = New System.Windows.Forms.Button()
        Me.txtGameName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstPlayer = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPlayerName = New System.Windows.Forms.TextBox()
        Me.cmbIcon = New System.Windows.Forms.ComboBox()
        Me.btnAddPlayer = New System.Windows.Forms.Button()
        Me.lblNumOfPlayer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStartGame
        '
        Me.btnStartGame.Location = New System.Drawing.Point(252, 172)
        Me.btnStartGame.Name = "btnStartGame"
        Me.btnStartGame.Size = New System.Drawing.Size(198, 23)
        Me.btnStartGame.TabIndex = 0
        Me.btnStartGame.Text = "Start Game"
        Me.btnStartGame.UseVisualStyleBackColor = True
        '
        'txtGameName
        '
        Me.txtGameName.Location = New System.Drawing.Point(88, 10)
        Me.txtGameName.Name = "txtGameName"
        Me.txtGameName.Size = New System.Drawing.Size(362, 20)
        Me.txtGameName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Game Name:"
        '
        'lstPlayer
        '
        Me.lstPlayer.FormattingEnabled = True
        Me.lstPlayer.Location = New System.Drawing.Point(16, 44)
        Me.lstPlayer.Name = "lstPlayer"
        Me.lstPlayer.Size = New System.Drawing.Size(218, 160)
        Me.lstPlayer.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(249, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Player Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(249, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Player Icon"
        '
        'txtPlayerName
        '
        Me.txtPlayerName.Location = New System.Drawing.Point(323, 41)
        Me.txtPlayerName.Name = "txtPlayerName"
        Me.txtPlayerName.Size = New System.Drawing.Size(127, 20)
        Me.txtPlayerName.TabIndex = 6
        '
        'cmbIcon
        '
        Me.cmbIcon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIcon.FormattingEnabled = True
        Me.cmbIcon.Location = New System.Drawing.Point(323, 73)
        Me.cmbIcon.Name = "cmbIcon"
        Me.cmbIcon.Size = New System.Drawing.Size(127, 21)
        Me.cmbIcon.TabIndex = 9
        '
        'btnAddPlayer
        '
        Me.btnAddPlayer.Location = New System.Drawing.Point(252, 100)
        Me.btnAddPlayer.Name = "btnAddPlayer"
        Me.btnAddPlayer.Size = New System.Drawing.Size(198, 23)
        Me.btnAddPlayer.TabIndex = 10
        Me.btnAddPlayer.Text = "Add Player"
        Me.btnAddPlayer.UseVisualStyleBackColor = True
        '
        'lblNumOfPlayer
        '
        Me.lblNumOfPlayer.AutoSize = True
        Me.lblNumOfPlayer.Location = New System.Drawing.Point(252, 153)
        Me.lblNumOfPlayer.Name = "lblNumOfPlayer"
        Me.lblNumOfPlayer.Size = New System.Drawing.Size(100, 13)
        Me.lblNumOfPlayer.TabIndex = 11
        Me.lblNumOfPlayer.Text = "Number of Player: 0"
        '
        'SetupBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 219)
        Me.Controls.Add(Me.lblNumOfPlayer)
        Me.Controls.Add(Me.btnAddPlayer)
        Me.Controls.Add(Me.cmbIcon)
        Me.Controls.Add(Me.txtPlayerName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstPlayer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtGameName)
        Me.Controls.Add(Me.btnStartGame)
        Me.Name = "SetupBoard"
        Me.Text = "New Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStartGame As System.Windows.Forms.Button
    Friend WithEvents txtGameName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstPlayer As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPlayerName As System.Windows.Forms.TextBox
    Friend WithEvents cmbIcon As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddPlayer As System.Windows.Forms.Button
    Friend WithEvents lblNumOfPlayer As System.Windows.Forms.Label
End Class
