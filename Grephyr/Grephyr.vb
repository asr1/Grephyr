Imports Microsoft.VisualBasic.PowerPacks
Imports System.Xml.Serialization
Imports System.IO

Public Class Grephyr

    Public canvas As New ShapeContainer

    Friend WithEvents save As New System.Windows.Forms.SaveFileDialog

    Private nodeCount As Integer = 1

    Private Sub callsave()
        save.ShowDialog()
        'Save each object
        If Not save.FileName = "" Then

            Dim objStreamWriter As New StreamWriter(save.FileName)
            For Each cont In Me.Controls


                If TypeOf cont Is CircleText Then
                    Try
                        Dim serializer As New XmlSerializer(cont.GetType)
                        serializer.Serialize(objStreamWriter, DirectCast(cont, CircleText))
                    Catch ex As System.InvalidOperationException
                        MsgBox(ex.InnerException.ToString)
                    End Try
                End If
              
            Next
            objStreamWriter.Close()

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RootNode2.label.Text = "Root"
        canvas.Parent = Me
    End Sub


    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        AddNode.Show()
    End Sub

    Private Sub Grephyr_ResizeEnd(sender As Object, e As EventArgs) Handles MyBase.ResizeEnd
        Me.ctrlPanel.Location = New Point(Me.Width - ctrlPanel.Width - 40, 12)
    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles Savebtn.Click
        'System.Threading.Thread.CurrentThread.SetApartmentState(System.Threading.ApartmentState.STA)
        save.Filter = "Grephyr File|*.gzy"
        save.Title = "Select a file to save"
        'Have to make this in a separate thread.
        Dim trd As System.Threading.Thread
        trd = New Threading.Thread(New System.Threading.ThreadStart(AddressOf callsave))
        trd.SetApartmentState(Threading.ApartmentState.STA)
        trd.Start()

    End Sub

    Private Sub Grephyr_Scroll(sender As Object, e As ScrollEventArgs) Handles MyBase.Scroll
        Me.ctrlPanel.Location = New Point(Me.ClientSize.Width - ctrlPanel.Width - 40, Me.Height - Me.ClientSize.Height - ctrlPanel.Height)
    End Sub
End Class
