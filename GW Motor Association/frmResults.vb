Public Class frmResults

    ' Method to reload everything on this form and populate comboboxes
    Public Sub fillCombobox()
        Me.Controls.Clear()
        InitializeComponent()

        ' Display each member saved in MemberList in the combobox
        For Each member As Member In frmMain.MemberList
            cbxSelectMember.Items.Add(member)
        Next

        ' Display each race saved in RaceEventsList in the combobox
        For Each race As RaceEvent In frmMain.RaceEventsList
            cbxSelectRace.Items.Add(race.ToString())
        Next
    End Sub

    ' Show results for a member when they are selected from the combobox
    Private Sub cbxSelectMember_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSelectMember.SelectedIndexChanged
        Dim member As Member = cbxSelectMember.SelectedItem()

        ' Loop through all results recorded - ResultList
        For Each result As Result In frmMain.ResultList
            ' If the member number in result matches the selected member's number in the combobox
            If member.getMemberNumber = result.getMember Then
                ' Display the result in the listbox
                lsbHistory.Items.Add(result.ToString())
            End If
        Next

        ' Shows the panel where races can be selected for the current member
        pnlDisplay.Visible = True
    End Sub

    ' Go back to main form
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Visible = False
        frmMain.Show()
    End Sub

    ' Populate the form when it loads
    Private Sub frmResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillCombobox()
    End Sub

    ' Show the panel where results can be entered for the selected member
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSelectRace.SelectedIndexChanged
        pnlResult.Visible = True
    End Sub

    ' Add the result to the selected member for the selected race
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim race As RaceEvent = frmMain.RaceEventsList(cbxSelectRace.SelectedIndex())
        Dim member As Member = frmMain.MemberList(cbxSelectMember.SelectedIndex())

        For Each result As Result In frmMain.ResultList
            If result.getEvent = race.getTitle And result.getMember = member.getMemberNumber Then
                MsgBox("Member already has result for that event.")
                Return
            End If
        Next
        frmMain.ResultList.Add(New Result(race, member, nudResult.Value))

        race.hasResults = True
        member.hasHistory = True

        Me.Visible = False
        frmMain.Show()
    End Sub
End Class