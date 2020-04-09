Public Class frmNewEvent

    Private Sub refreshForm()
        ' Reset the information
        txtTitle.Text = ""
        txtRegFee.Text = ""
        txtLocation.Text = ""
        nudLaps.Text = 1
        'dtpDate.Value = DateTime.Now
    End Sub

    ' Go back to main form and reset controls
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Visible = False

        refreshForm()

        frmMain.Show()
    End Sub

    ' Add event in events list and reset controls
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Add new event with entered details
        Dim newDate As String = dtpDate.Value.ToShortDateString
        frmMain.RaceEventsList.Add(New RaceEvent(txtTitle.Text, newDate, txtRegFee.Text, txtLocation.Text, nudLaps.Value))

        refreshForm()

        ' Go back to main menu
        Me.Visible = False
        frmMain.Show()
    End Sub
End Class