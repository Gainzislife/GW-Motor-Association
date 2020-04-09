Public Class frmMembers
    ' Go back to main form
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Visible = False
        displayMembers()
        frmMain.Show()
    End Sub

    ' A method to show all the members in member list
    Public Sub displayMembers()
        Me.Controls.Clear()
        InitializeComponent()
        For Each member As Member In frmMain.MemberList
            lsbMembers.Items.Add(member)
        Next
    End Sub

    ' Display members in listbox when the form loads
    Private Sub frmMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayMembers()
    End Sub

    ' Reload the form and its controls
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        displayMembers()
    End Sub

    ' Show member details in textbox
    Private Sub lsbMembers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsbMembers.SelectedIndexChanged
        Dim member As Member = lsbMembers.SelectedItem()

        If lsbMembers.SelectedIndex > -1 Then
            ' Member cannot be deleted if they have results
            If member.hasHistory Then
                btnDelete.Enabled = False
            End If

            Try
                txtDisplay.Text = member.GetDisplayText()
            Catch ex As Exception
                txtDisplay.Text = ""
            End Try
        End If

    End Sub

    ' Remove a member from memberlist and from listbox
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        frmMain.MemberList.RemoveAt(lsbMembers.SelectedIndex)

        lsbMembers.Items.Remove(lsbMembers.SelectedItem)

        displayMembers()
    End Sub

    ' Display a panel and controls to change member details
    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        pnlModify.Visible = True

        Dim member As Member = lsbMembers.SelectedItem()

        txtFirstName.Text = member.getFirstName()
        txtLastName.Text = member.getLastName()
        dtpBirthDate.Value = CDate(member.getBirthDate)

        If member.getGender = "Male" Then
            rbnMale.Checked = True
        Else
            rbnFemale.Checked = True
        End If

        nudOutstandingFee.Value = CInt(member.getOutstandingFee())

    End Sub

    ' Update member details and refresh controls
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim member As Member = lsbMembers.SelectedItem()

        member.setFirstName(txtFirstName.Text)
        member.setLastName(txtLastName.Text)
        member.setBirthdate(dtpBirthDate.Value.ToShortDateString)

        Dim gender As String
        If rbnMale.Checked Then
            gender = "Male"
        Else
            gender = "Female"
        End If

        member.setGender(gender)
        member.setOutstandingFee(nudOutstandingFee.Value)

        pnlModify.Visible = False

        displayMembers()
    End Sub
End Class