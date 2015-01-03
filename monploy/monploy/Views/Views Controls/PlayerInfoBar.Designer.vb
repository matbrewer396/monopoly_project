<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayerInfoBar
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
        Me.PlayerInfo1 = New monploy.PlayerInfo()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PlayerInfo2 = New monploy.PlayerInfo()
        Me.PlayerInfo3 = New monploy.PlayerInfo()
        Me.PlayerInfo4 = New monploy.PlayerInfo()
        Me.PlayerInfo5 = New monploy.PlayerInfo()
        Me.PlayerInfo6 = New monploy.PlayerInfo()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PlayerInfo1
        '
        Me.PlayerInfo1.Location = New System.Drawing.Point(3, 3)
        Me.PlayerInfo1.Name = "PlayerInfo1"
        Me.PlayerInfo1.Size = New System.Drawing.Size(161, 157)
        Me.PlayerInfo1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.PlayerInfo1)
        Me.FlowLayoutPanel1.Controls.Add(Me.PlayerInfo2)
        Me.FlowLayoutPanel1.Controls.Add(Me.PlayerInfo3)
        Me.FlowLayoutPanel1.Controls.Add(Me.PlayerInfo4)
        Me.FlowLayoutPanel1.Controls.Add(Me.PlayerInfo5)
        Me.FlowLayoutPanel1.Controls.Add(Me.PlayerInfo6)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1004, 168)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'PlayerInfo2
        '
        Me.PlayerInfo2.Location = New System.Drawing.Point(170, 3)
        Me.PlayerInfo2.Name = "PlayerInfo2"
        Me.PlayerInfo2.Size = New System.Drawing.Size(161, 157)
        Me.PlayerInfo2.TabIndex = 1
        '
        'PlayerInfo3
        '
        Me.PlayerInfo3.Location = New System.Drawing.Point(337, 3)
        Me.PlayerInfo3.Name = "PlayerInfo3"
        Me.PlayerInfo3.Size = New System.Drawing.Size(161, 157)
        Me.PlayerInfo3.TabIndex = 2
        '
        'PlayerInfo4
        '
        Me.PlayerInfo4.Location = New System.Drawing.Point(504, 3)
        Me.PlayerInfo4.Name = "PlayerInfo4"
        Me.PlayerInfo4.Size = New System.Drawing.Size(161, 157)
        Me.PlayerInfo4.TabIndex = 3
        '
        'PlayerInfo5
        '
        Me.PlayerInfo5.Location = New System.Drawing.Point(671, 3)
        Me.PlayerInfo5.Name = "PlayerInfo5"
        Me.PlayerInfo5.Size = New System.Drawing.Size(161, 157)
        Me.PlayerInfo5.TabIndex = 4
        '
        'PlayerInfo6
        '
        Me.PlayerInfo6.Location = New System.Drawing.Point(838, 3)
        Me.PlayerInfo6.Name = "PlayerInfo6"
        Me.PlayerInfo6.Size = New System.Drawing.Size(161, 157)
        Me.PlayerInfo6.TabIndex = 5
        '
        'PlayerInfoBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "PlayerInfoBar"
        Me.Size = New System.Drawing.Size(1004, 168)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PlayerInfo1 As monploy.PlayerInfo
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents PlayerInfo2 As monploy.PlayerInfo
    Friend WithEvents PlayerInfo3 As monploy.PlayerInfo
    Friend WithEvents PlayerInfo4 As monploy.PlayerInfo
    Friend WithEvents PlayerInfo5 As monploy.PlayerInfo
    Friend WithEvents PlayerInfo6 As monploy.PlayerInfo

End Class
