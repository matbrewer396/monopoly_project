<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayerInfo
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.BackPannel = New System.Windows.Forms.Panel()
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.lblCash = New System.Windows.Forms.Label()
        Me.BackPannel.SuspendLayout()
        Me.SuspendLayout()
        '
        'BackPannel
        '
        Me.BackPannel.BackColor = System.Drawing.Color.LightCoral
        Me.BackPannel.Controls.Add(Me.lblCash)
        Me.BackPannel.Controls.Add(Me.lblPlayerName)
        Me.BackPannel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BackPannel.Location = New System.Drawing.Point(0, 0)
        Me.BackPannel.Name = "BackPannel"
        Me.BackPannel.Size = New System.Drawing.Size(161, 157)
        Me.BackPannel.TabIndex = 0
        '
        'lblPlayerName
        '
        Me.lblPlayerName.AutoSize = True
        Me.lblPlayerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerName.Location = New System.Drawing.Point(9, 11)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(142, 31)
        Me.lblPlayerName.TabIndex = 0
        Me.lblPlayerName.Text = "No Player"
        '
        'lblCash
        '
        Me.lblCash.AutoSize = True
        Me.lblCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCash.Location = New System.Drawing.Point(24, 108)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(94, 31)
        Me.lblCash.TabIndex = 1
        Me.lblCash.Text = "$0000"
        '
        'PlayerInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BackPannel)
        Me.Name = "PlayerInfo"
        Me.Size = New System.Drawing.Size(161, 157)
        Me.BackPannel.ResumeLayout(False)
        Me.BackPannel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackPannel As System.Windows.Forms.Panel
    Friend WithEvents lblPlayerName As System.Windows.Forms.Label
    Friend WithEvents lblCash As System.Windows.Forms.Label

End Class
