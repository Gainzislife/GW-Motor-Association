Imports System.IO

Public Class frmMain
    ' Save all race events in a list
    Public RaceEventsList As New List(Of RaceEvent)

    ' Save all members in a list
    Public MemberList As New List(Of Member)

    ' Save all race results in a list
    Public ResultList As New List(Of Result)

    ' Exit the application
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Try
            ' Write new data to files
            Dim eventPath As String = "C:\ICT3611\GW Motor Association\GW Motor Association\Events.txt"

            Dim eventOut As New StreamWriter(New FileStream(eventPath, FileMode.Create, FileAccess.Write))

            For Each ev As RaceEvent In RaceEventsList
                eventOut.WriteLine(ev.getTitle & "," & ev.getEventDate & "," & ev.getRegistrationFee & "," & ev.getLocation & "," & ev.getNumLaps & "," & CStr(ev.hasResults))
            Next

            eventOut.Close()
        Catch ex As Exception
            MsgBox("Error writing to file! events")
        End Try

        Try
            ' Write new data to files
            Dim memberPath As String = "C:\ICT3611\GW Motor Association\GW Motor Association\Members.txt"

            Dim memberOut As New StreamWriter(New FileStream(memberPath, FileMode.Create, FileAccess.Write))

            For Each mem As Member In MemberList
                memberOut.WriteLine(mem.getMemberNumber & "," & mem.getFirstName & "," & mem.getLastName & "," & mem.getBirthDate & "," & mem.getGender & "," & mem.getJoinDate & "," & mem.getOutstandingFee & "," & mem.hasHistory)
            Next

            memberOut.Close()
        Catch ex As Exception
            MsgBox("Error writing to file! members")
        End Try

        Try
            ' Write new data to files
            Dim resultPath As String = "C:\ICT3611\GW Motor Association\GW Motor Association\Results.txt"

            Dim resultOut As New StreamWriter(New FileStream(resultPath, FileMode.Create, FileAccess.Write))

            For Each re As Result In ResultList
                resultOut.WriteLine(re.getEvent() & "," & re.getMember() & "," & re.getResult())
            Next

            resultOut.Close()
        Catch ex As Exception
            MsgBox(ex.StackTrace)
            MsgBox("Error writing to file! results")
        End Try


        Me.Close()
    End Sub

    ' Go to the form to add new events
    Private Sub btnEvent_Click(sender As Object, e As EventArgs) Handles btnNewEvent.Click
        Me.Visible = False
        frmNewEvent.Show()
    End Sub

    ' Go to the form to add new members
    Private Sub btnMembers_Click(sender As Object, e As EventArgs) Handles btnNewMember.Click
        Me.Visible = False
        frmAddMembers.Show()
    End Sub

    ' Go to the form to view all events
    Private Sub btnViewEvents_Click(sender As Object, e As EventArgs) Handles btnViewEvents.Click
        Me.Visible = False
        frmEvents.displayEvents()
        frmEvents.Show()
    End Sub

    ' Go to the form to view all members
    Private Sub btnMembers_Click_1(sender As Object, e As EventArgs) Handles btnMembers.Click
        Me.Visible = False
        frmMembers.displayMembers()
        frmMembers.Show()
    End Sub

    ' Go to the form to view/add results
    Private Sub btnResults_Click(sender As Object, e As EventArgs) Handles btnResults.Click
        Me.Visible = False
        frmResults.fillCombobox()
        frmResults.Show()
    End Sub

    ' Do this when the form loads
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Read events from file
            Dim eventPath As String = "C:\ICT3611\GW Motor Association\GW Motor Association\Events.txt"

            Dim eR As New StreamReader(New FileStream(eventPath, FileMode.OpenOrCreate, FileAccess.Read))

            Do While eR.Peek <> -1
                Dim eRow As String = eR.ReadLine
                Dim eCols() As String = eRow.Split(CChar(","))
                Dim race As New RaceEvent(eCols(0), eCols(1), CInt(eCols(2)), eCols(3), CInt(eCols(4)), CBool(eCols(5)))
                RaceEventsList.Add(race)
            Loop

            eR.Close()
            ' Give notice if it was a reading error otherwise use default exception
        Catch err As IOException
            MsgBox("Cannot read from 'Events.txt'!")
        Catch ex As Exception
            MsgBox("'Events.txt' has no entries yet!")
        End Try

        Try
            ' Read members from file
            Dim memberPath As String = "C:\ICT3611\GW Motor Association\GW Motor Association\Members.txt"

            Dim mR As New StreamReader(New FileStream(memberPath, FileMode.OpenOrCreate, FileAccess.Read))

            Do While mR.Peek <> -1
                Dim mRow As String = mR.ReadLine
                Dim mCols() As String = mRow.Split(CChar(","))
                Dim member As New Member(mCols(0), mCols(1), mCols(2), mCols(3), mCols(4), mCols(5), CInt(mCols(6)), CBool(mCols(7)))

                MemberList.Add(member)
            Loop

            mR.Close()
            ' Give notice if it was a reading error otherwise use default exception
        Catch err As IOException
            MsgBox("Cannot read from 'Members.txt'!")
        Catch ex As Exception
            MsgBox("Trouble reading from 'Members.txt'")
        End Try

        Try
            ' Read results from file
            Dim resultPath As String = "C:\ICT3611\GW Motor Association\GW Motor Association\Results.txt"

            Dim rR As New StreamReader(New FileStream(resultPath, FileMode.OpenOrCreate, FileAccess.Read))

            ' Loop through file while there are items on each line
            Do While rR.Peek <> -1
                Dim rRow As String = rR.ReadLine
                Dim rCols() As String = rRow.Split(CChar(","))

                Dim resultRace As RaceEvent = Nothing

                For Each race As RaceEvent In RaceEventsList
                    If rCols(0) = race.getTitle Then
                        resultRace = race
                    End If
                Next

                Dim resultMember As Member = Nothing

                For Each member As Member In MemberList
                    If member.getMemberNumber = rCols(1) Then
                        resultMember = member
                    End If
                Next

                Try
                    Dim result As New Result(resultRace, resultMember, rCols(2))
                    ResultList.Add(result)
                Catch ex As Exception
                    MsgBox("Warning! No result for member or race.")
                End Try
            Loop

            rR.Close()
        ' Give notice if it was a reading error otherwise use default exception
        Catch err As IOException
            MsgBox("Cannot read from 'Results.txt'!")
        Catch ex As Exception
            MsgBox("'Results.txt' has no entries yet!")
        End Try


    End Sub
End Class
