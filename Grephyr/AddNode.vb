Public Class AddNode



    Private Sub comboChange(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles fromList.SelectedIndexChanged, toList.SelectedIndexChanged

        Dim box As ComboBox = CType(sender, ComboBox)

        'Determine which combobox we're dealing with
        ' Dim name As String = CType(sender, ComboBox).Name



        For Each cont As Control In Grephyr.Controls
            If TypeOf cont Is CircleText Then
                If CType(cont, CircleText).label.Text = box.SelectedItem Then
                    cont.BackgroundImage = My.Resources.GrephyrSelected 'Selected
                End If
            End If
        Next




    End Sub

    Private Sub AddNode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Same handler for both code
        'AddHandler fromList.SelectedIndexChanged, AddressOf comboChange
        'AddHandler toList.SelectedIndexChanged, AddressOf comboChange

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
                cont.BackgroundImage = My.Resources.Grephyr4 'Normal
            End If
        Next
        Me.Hide()
    End Sub


    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        For Each cont As Control In Grephyr.Controls
            If TypeOf cont Is CircleText Then
                cont.BackgroundImage = My.Resources.Grephyr4 'Normal
            End If
        Next


        'TODO position relative to from
        If fromList.SelectedItem = "[New Node]" Then
            Dim label As String = InputBox("What is the label of the new from node?")
            Grephyr.Controls.Add(New CircleText(label))
        End If
        If toList.SelectedItem = "[New Node]" Then
            Dim label As String = InputBox("What is the label of the new from node?")
            Grephyr.Controls.Add(New CircleText(label))
        End If




        Me.Hide()
    End Sub
End Class