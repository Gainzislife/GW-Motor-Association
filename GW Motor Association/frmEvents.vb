Public Class frmEvents
    ' Go back to main menu
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Visible = False
        displayEvents()
        frmMain.Show()
    End Sub

    ' Load the form with all race titles in listbox
    Private Sub frmEvents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayEvents()
    End Sub

    ' A method to show all the events in RaceEventsList
    Public Sub displayEvents()
        Me.Controls.Clear()
        InitializeComponent()
        For Each race As RaceEvent In frmMain.RaceEventsList
            lsbEvents.Items.Add(race)
        Next
    End Sub

    ' Reload the form and it's controls
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        displayEvents()
    End Sub

    ' Show selected item's details in textbox
    Private Sub lsbEvents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsbEvents.SelectedIndexChanged
        Dim race As RaceEvent = lsbEvents.SelectedItem

        If lsbEvents.SelectedIndex > -1 Then
            ' Race cannot be deleted if it has results
            If race.hasResults Then
                btnDelete.Enabled = False
            End If

            ' Show the text in textbox if it is not deleted
            Try
                txtDisplay.Text = race.GetDisplayText()
            Catch ex As Exception
                txtDisplay.Text = ""
            End Try
        End If

    End Sub

    ' Delete the selected item from listbox and from RaceEventsList
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        frmMain.RaceEventsList.RemoveAt(lsbEvents.SelectedIndex)

        lsbEvents.Items.Remove(lsbEvents.SelectedItem)

        lsbEvents.ClearSelected()

        displayEvents()
    End Sub

    ' Display a panel with controls to change the selected event details
    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        pnlModify.Visible = True

        Dim race As RaceEvent = lsbEvents.SelectedItem()

        txtTitle.Text = race.getTitle()
        txtRegFee.Text = race.getRegistrationFee()
        txtLocation.Text = race.getLocation()
        nudLaps.Value = race.getNumLaps()
        Dim eventDate As String = race.getEventDate()
        dtpDate.Value = CDate(eventDate)
    End Sub

    ' Update the selected event details and refresh controls
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim race As RaceEvent = lsbEvents.SelectedItem()

        race.setTitle(txtTitle.Text)
        race.setEventDate(dtpDate.Value.ToShortDateString)
        race.setRegistrationFee(txtRegFee.Text)
        race.setLocation(txtLocation.Text)
        race.setNumLaps(nudLaps.Value)

        pnlModify.Visible = False

        displayEvents()
    End Sub
End Class