<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DicePic
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
        Me.picDiceImage = New System.Windows.Forms.PictureBox()
        CType(Me.picDiceImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picDiceImage
        '
        Me.picDiceImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picDiceImage.ImageLocation = "C:\Users\matt\git\monopoly_project\monploy\monploy\resources\1 DICE.png"
        Me.picDiceImage.Location = New System.Drawing.Point(0, 0)
        Me.picDiceImage.Name = "picDiceImage"
        Me.picDiceImage.Size = New System.Drawing.Size(102, 102)
        Me.picDiceImage.TabIndex = 1
        Me.picDiceImage.TabStop = False
        '
        'DicePic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.picDiceImage)
        Me.Name = "DicePic"
        Me.Size = New System.Drawing.Size(102, 102)
        CType(Me.picDiceImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picDiceImage As System.Windows.Forms.PictureBox

End Class
