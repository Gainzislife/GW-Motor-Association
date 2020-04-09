Public Class frmAddMembers

    ' Variable to save gender as String
    Dim gender As String = ""

    Private Sub refreshFrom()
        ' Clear all fields
        edtFirstName.Text = ""
        edtLastName.Text = ""
        dtpBirthDate.Value = dtpBirthDate.MaxDate
        rbnMale.Checked = False
        rbnFemale.Checked = False
        ' dtpCurrentDate.Value = DateTime.Now
    End Sub

    ' Show main form
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Visible = False

        refreshFrom()

        frmMain.Show()
    End Sub

    ' Add member to MemberList
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If edtFirstName.Text = "" Then
            MsgBox("Please enter first name.")
        ElseIf edtLastName.Text = "" Then
            MsgBox("Please enter last name.")
        ElseIf gender = "" Then
            MsgBox("Please select a gender.")
        Else
            ' Add the member to MemberList with entered details
            frmMain.MemberList.Add(New Member(edtFirstName.Text, edtLastName.Text, dtpBirthDate.Value.ToShortDateString, gender, dtpCurrentDate.Value.ToShortDateString))

            refreshFrom()

            ' Go back to main menu
            Me.Visible = False
            frmMain.Show()
        End If

    End Sub

    ' Check if female radiobutton is selected
    Private Sub rbnFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rbnFemale.CheckedChanged
        gender = "Female"
    End Sub

    ' Check is male radiobutoon is selected
    Private Sub rbnMale_CheckedChanged(sender As Object, e As EventArgs) Handles rbnMale.CheckedChanged
        gender = "Male"
    End Sub
End Class