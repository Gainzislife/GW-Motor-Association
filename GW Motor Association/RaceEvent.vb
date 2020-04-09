Public Class RaceEvent

    ' ATTRIBUTES
    Private title As String
    Private eventDate As String
    Private registrationFee As Integer
    Private location As String
    Private numLaps As Integer
    Public hasResults As Boolean

    ' Constructor for new race
    Public Sub New(newTitle As String, newDate As String, newFee As Integer, newLocation As String, newNumLaps As Integer)
        title = newTitle
        eventDate = newDate
        registrationFee = newFee
        location = newLocation
        numLaps = newNumLaps
        hasResults = False
    End Sub

    ' Constructor for race from file
    Public Sub New(newTitle As String, newDate As String, newFee As Integer, newLocation As String, newNumLaps As Integer, history As Boolean)
        title = newTitle
        eventDate = newDate
        registrationFee = newFee
        location = newLocation
        numLaps = newNumLaps
        hasResults = history
    End Sub

    ' METHODS
    ' Set the title
    Public Sub setTitle(value As String)
        title = value
    End Sub

    ' Get race title
    Public Function getTitle() As String
        Return title
    End Function

    ' Set the date
    Public Sub setEventDate(value As String)
        eventDate = value
    End Sub

    ' Get date
    Public Function getEventDate() As String
        Return eventDate
    End Function

    ' Set the fee
    Public Sub setRegistrationFee(value As Integer)
        registrationFee = value
    End Sub

    ' Get fee
    Public Function getRegistrationFee() As Integer
        Return registrationFee
    End Function

    ' Set the location
    Public Sub setLocation(value As String)
        location = value
    End Sub

    ' Get date
    Public Function getLocation() As String
        Return location
    End Function

    ' Set numLaps
    Public Sub setNumLaps(value As Integer)
        numLaps = value
    End Sub

    ' Get numLaps
    Public Function getNumLaps() As Integer
        Return numLaps
    End Function

    ' Get output text
    Public Function GetDisplayText() As String
        Dim text As String = "Name: " & title & vbCrLf & "Date: " & eventDate & vbCrLf & "Fee: R " & registrationFee & vbCrLf & "Location: " & location & vbCrLf & "# Laps: " & numLaps

        Return text
    End Function

    ' Override the ToString function to give better output
    Public Overrides Function ToString() As String
        Dim text As String = "Race Name: " & title

        Return text
    End Function
End Class
