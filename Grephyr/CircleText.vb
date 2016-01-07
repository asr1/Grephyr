Imports Microsoft.VisualBasic.PowerPacks

Public Class CircleText
    Private drag As Boolean = False
    Private xPos, yPos As Integer
    'Private oldLoc As Point
    Public cLoc As Point = New Point(Me.Location.X + Me.Width / 2, Me.Location.Y + Me.Height / 2) 'Center of the circle
    Private circ As CircleText 'Reference object for old location

    Public neighbors As New List(Of CircleText) 'Keep track of all neighbors
    Public lines As New List(Of LineShape)    'And lines
    Public selfs As New List(Of OvalShape) 'Add self loops

    Sub New(ByVal name As String)
        InitializeComponent()
        Me.label.Text = name
    End Sub

    Protected Overrides Sub finalize()
        'Remove lines on delete
        For Each line As LineShape In lines
            Grephyr.canvas.Shapes.Remove(line)
        Next

        For Each circ As OvalShape In selfs
            Grephyr.canvas.Shapes.Remove(circ)
        Next

    End Sub

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub CircleText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cLoc = New Point(Me.Location.X + Me.Width / 2, Me.Location.Y + Me.Height / 2)
    End Sub

    Private Sub CircleText_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            drag = True
            'Update the old node
            circ = DirectCast(sender, CircleText) 'Safe cast, we know what sender will be
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
            Me.cLoc = New Point(Me.Location.X + Me.Width / 2, Me.Location.Y + Me.Height / 2)

            'Delete all old lines and draw new ones in the new location
            For Each line As LineShape In Me.lines
                Grephyr.canvas.Shapes.Remove(line)
            Next

            For Each neighbor As CircleText In Me.neighbors
                Dim line As New LineShape
                line.Parent = Grephyr.canvas

                line.StartPoint = Me.cLoc
                line.EndPoint = neighbor.cLoc

                Me.lines.Add(line)
                neighbor.lines.Add(line)
            Next

            'Move each self shape
            For Each circ As OvalShape In Me.selfs
                circ.Location = cLoc
            Next

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
