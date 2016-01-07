Imports Microsoft.VisualBasic.PowerPacks

Public Class Grephyr

    Public canvas As New ShapeContainer

    Friend WithEvents save As New System.Windows.Forms.SaveFileDialog

    Private nodeCount As Integer = 1

    Private Sub callsave()
        Save.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RootNode2.label.Text = "Root"
        canvas.Parent = Me
    End Sub

    Private Sub CircleText2_MouseDown(sender As Object, e As MouseEventArgs) Handles RootNode.MouseDown

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddNode.Show()
    End Sub

    Private Sub Grephyr_ResizeEnd(sender As Object, e As EventArgs) Handles MyBase.ResizeEnd
        Me.ctrlPanel.Location = New Point(Me.Width - ctrlPanel.Width - 40, 12)
    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles Savebtn.Click
        'System.Threading.Thread.CurrentThread.SetApartmentState(System.Threading.ApartmentState.STA)
        save.Filter = "Grephyr File|*.gzy"
        save.Title = "Test"
        Dim trd As System.Threading.Thread
        trd = New Threading.Thread(New System.Threading.ThreadStart(AddressOf callsave))
        trd.SetApartmentState(Threading.ApartmentState.STA)
        trd.Start()

    End Sub

    Private Sub Grephyr_Scroll(sender As Object, e As ScrollEventArgs) Handles MyBase.Scroll
        Me.ctrlPanel.Location = New Point(Me.ClientSize.Width - ctrlPanel.Width - 40, Me.Height - Me.ClientSize.Height - ctrlPanel.Height)
    End Sub
End Class
