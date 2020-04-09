Public Class Result
    ' ATTRIBUTES
    Private race As RaceEvent
    Private member As Member
    Private result As Integer

    ' Constructor
    Public Sub New(newRace As RaceEvent, newMember As Member, newResult As Integer)
        race = newRace
        member = newMember
        result = newResult
    End Sub

    ' METHODS
    ' Override the ToString function to give better output
    Public Overrides Function ToString() As String
        Dim text As String = "Race: " & race.getTitle & ", Result: " & result

        Return text
    End Function

    ' Get the member number for the result
    Public Function getMember() As String
        Return member.getMemberNumber()
    End Function

    ' Set the result
    Public Sub setResult(value As Integer)
        result = value
    End Sub

    ' Get the race title
    Public Function getEvent() As String
        Return race.getTitle
    End Function

    ' Get the result
    Public Function getResult() As String
        Return result
    End Function


End Class
