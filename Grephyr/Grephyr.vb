Imports Microsoft.VisualBasic.PowerPacks

Public Class Grephyr

    Public canvas As New ShapeContainer

    Private nodeCount As Integer = 1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RootNode2.label.Text = "Root"
    End Sub

    Private Sub CircleText2_MouseDown(sender As Object, e As MouseEventArgs) Handles RootNode.MouseDown

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddNode.Show()
    End Sub
End Class
