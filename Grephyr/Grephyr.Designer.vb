<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Grephyr
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Grephyr))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Savebtn = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ctrlPanel = New System.Windows.Forms.Panel()
        Me.RootNode2 = New Global.Grephyr.CircleText()
        Me.ctrlPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Savebtn
        '
        Me.Savebtn.Location = New System.Drawing.Point(3, 32)
        Me.Savebtn.Name = "Savebtn"
        Me.Savebtn.Size = New System.Drawing.Size(75, 23)
        Me.Savebtn.TabIndex = 3
        Me.Savebtn.Text = "Save"
        Me.Savebtn.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(3, 61)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "[Line]"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ctrlPanel
        '
        Me.ctrlPanel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ctrlPanel.Controls.Add(Me.Button1)
        Me.ctrlPanel.Controls.Add(Me.Button3)
        Me.ctrlPanel.Controls.Add(Me.Savebtn)
        Me.ctrlPanel.Location = New System.Drawing.Point(860, 12)
        Me.ctrlPanel.Name = "ctrlPanel"
        Me.ctrlPanel.Size = New System.Drawing.Size(87, 91)
        Me.ctrlPanel.TabIndex = 5
        '
        'RootNode2
        '
        Me.RootNode2.AccessibleName = "GraphNode"
        Me.RootNode2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.RootNode2.BackColor = System.Drawing.Color.Transparent
        Me.RootNode2.BackgroundImage = CType(resources.GetObject("RootNode2.BackgroundImage"), System.Drawing.Image)
        Me.RootNode2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.RootNode2.Location = New System.Drawing.Point(165, 44)
        Me.RootNode2.Name = "RootNode2"
        Me.RootNode2.Size = New System.Drawing.Size(195, 193)
        Me.RootNode2.TabIndex = 6
        '
        'Grephyr
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(969, 534)
        Me.Controls.Add(Me.RootNode2)
        Me.Controls.Add(Me.ctrlPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Grephyr"
        Me.Text = "Grephyr"
        Me.ctrlPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RootNode As Global.Grephyr.CircleText
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Savebtn As System.Windows.Forms.Button
    Friend WithEvents ctrlPanel As System.Windows.Forms.Panel
    Friend WithEvents RootNode2 As Global.Grephyr.CircleText

End Class
