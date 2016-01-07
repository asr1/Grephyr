<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CircleText
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CircleText))
        Me.label = New System.Windows.Forms.TextBox()
        Me.SuspendLayout
        '
        'label
        '
        Me.label.BackColor = System.Drawing.Color.Yellow
        Me.label.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.label.Location = New System.Drawing.Point(51, 97)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(100, 13)
        Me.label.TabIndex = 2
        Me.label.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CircleText
        '
        Me.AccessibleName = "GraphNode"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImage = DirectCast(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Controls.Add(Me.label)
        Me.Name = "CircleText"
        Me.Size = New System.Drawing.Size(195, 193)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents label As System.Windows.Forms.TextBox

End Class
