Imports Microsoft.VisualBasic.PowerPacks

Public Class AddNode



    'The nodes selected by the dropdown
    Dim fromNode = New CircleText(""), toNode = New CircleText("")

    Private Sub comboChange(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles fromList.SelectedIndexChanged, toList.SelectedIndexChanged

        Dim box As ComboBox = CType(sender, ComboBox)

        For Each cont As Control In Grephyr.Controls
            If TypeOf cont Is CircleText Then
                If CType(cont, CircleText).label.Text = box.SelectedItem Then
                    'Select the correct node
                    cont.BackgroundImage = My.Resources.GrephyrSelected 'Selected
                    If box.Name = "fromList" Then
                        fromNode = cont
                    ElseIf box.Name = "toList" Then
                        toNode = cont
                    End If
                End If
            End If
        Next
    



    End Sub

    Private Sub AddNode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populate both comboboxes
        For Each cont As Control In Grephyr.Controls
            If TypeOf cont Is CircleText Then
                fromList.Items.Add(CType(cont, CircleText).label.Text)
                toList.Items.Add(CType(cont, CircleText).label.Text)
            End If
        Next
        fromList.Items.Add("[New Node]")
        toList.Items.Add("[New Node]")
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        For Each cont As Control In Grephyr.Controls
            If TypeOf cont Is CircleText Then
                cont.BackgroundImage = My.Resources.Grephyr 'Normal
            End If
        Next
        Me.Hide()
    End Sub


    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        For Each cont As Control In Grephyr.Controls
            If TypeOf cont Is CircleText Then
                cont.BackgroundImage = My.Resources.Grephyr 'Normal
            End If
        Next

        'TODO position relative to from

        Dim label = "", fromLabel = "", toLabel = ""

        'Add new nodes
        If fromList.SelectedItem = "[New Node]" Then
            'Use a space as the default to tell if they hit cancel or ok
            fromLabel = InputBox("What is the label of the new from node?", " ")
            If Not fromLabel = "" Then
                fromNode = New CircleText(fromLabel)
                Grephyr.Controls.Add(fromNode)
            End If
        End If

        If toList.SelectedItem = "[New Node]" Then
            toLabel = InputBox("What is the label of the new to node?", " ")
            If Not toLabel = "" Then
                toNode = New CircleText(toLabel)
                Grephyr.Controls.Add(toNode)
            End If
        End If

        'Drawline
        Dim canvas As New ShapeContainer
        canvas.Parent = Grephyr
        Dim line As New LineShape
        line.Parent = canvas

        line.StartPoint = fromNode.cloc
        line.EndPoint = toNode.cloc

        Me.Hide()
    End Sub
End Class