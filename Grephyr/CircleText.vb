Public Class CircleText
    Private drag As Boolean = False
    Private xPos, yPos As Integer
    'Private oldLoc As Point
    Private circ As CircleText 'Reference object for old location

    ' Public neighbors() As CircleText 'Keep track of all neighbors

    Sub New(ByVal name As String)
        InitializeComponent()
        Me.label.Text = name
    End Sub

    Private Sub CircleText_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '   oldLoc =  = Me.Location
    End Sub

    Private Sub CircleText_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            drag = True
            'Update the old node
            circ = CType(sender, CircleText) 'Safe cast, we know what sender will be
            'The mouse's starting location may not be equal to the node's location
            xPos = e.X
            yPos = e.Y
        End If
        ' Me.DoDragDrop(Me.label.Text, DragDropEffects.Move)
    End Sub

    Private Sub CircleText_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            'Difference between old location and new
            Me.Location = New Point(circ.Location.X + e.X - xPos, circ.Location.Y + e.Y - yPos)
        End If
    End Sub

    Private Sub CircleText_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub

    Private Sub label_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
