<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFirstRoll
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
        Me.PlayerInfoBar1 = New monploy.PlayerInfoBar(players)
        Me.DicePic1 = New monploy.DicePic()
        Me.DicePic2 = New monploy.DicePic()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PlayerInfoBar1
        '
        Me.PlayerInfoBar1.Location = New System.Drawing.Point(66, 257)
        Me.PlayerInfoBar1.Name = "PlayerInfoBar1"
        Me.PlayerInfoBar1.Size = New System.Drawing.Size(1004, 150)
        Me.PlayerInfoBar1.TabIndex = 0
        '
        'DicePic1
        '
        Me.DicePic1.Dice = monploy.Roll.Dices.ONE
        Me.DicePic1.DiceType = monploy.Roll.Dices.ONE
        Me.DicePic1.Location = New System.Drawing.Point(420, 53)
        Me.DicePic1.Name = "DicePic1"
        Me.DicePic1.Size = New System.Drawing.Size(100, 101)
        Me.DicePic1.TabIndex = 1
        '
        'DicePic2
        '
        Me.DicePic2.Dice = monploy.Roll.Dices.ONE
        Me.DicePic2.DiceType = monploy.Roll.Dices.ONE
        Me.DicePic2.Location = New System.Drawing.Point(565, 53)
        Me.DicePic2.Name = "DicePic2"
        Me.DicePic2.Size = New System.Drawing.Size(100, 101)
        Me.DicePic2.TabIndex = 2
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(398, 198)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(293, 23)
        Me.btnRoll.TabIndex = 3
        Me.btnRoll.Text = "Player: Roll"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'FrmFirstRoll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1143, 419)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.DicePic2)
        Me.Controls.Add(Me.DicePic1)
        Me.Controls.Add(Me.PlayerInfoBar1)
        Me.Name = "FrmFirstRoll"
        Me.Text = "First Roll"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PlayerInfoBar1 As monploy.PlayerInfoBar
    Friend WithEvents DicePic1 As monploy.DicePic
    Friend WithEvents DicePic2 As monploy.DicePic
    Friend WithEvents btnRoll As System.Windows.Forms.Button
End Class
