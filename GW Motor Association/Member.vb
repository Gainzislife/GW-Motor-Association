Public Class Member

    ' ATTRIBUTES
    Private number As String
    Private firstName As String
    Private lastName As String
    Private birthDate As String
    Private gender As String
    Private joinDate As String
    Private outstandingFee As Integer
    Public hasHistory As Boolean

    ' Constructor for new member
    Public Sub New(newFirstName As String, newLastName As String, newBirthDate As String, newGender As String, newJoinDate As String)
        firstName = newFirstName
        lastName = newLastName
        birthDate = newBirthDate
        gender = newGender
        joinDate = newJoinDate
        outstandingFee = 0
        hasHistory = False

        number = generateNumber(birthDate, joinDate)

    End Sub

    ' Constructor for members in file
    Public Sub New(newNumber As String, newFirstName As String, newLastName As String, newBirthDate As String, newGender As String, newJoinDate As String, outFee As Integer, history As Boolean)
        number = newNumber
        firstName = newFirstName
        lastName = newLastName
        birthDate = newBirthDate
        gender = newGender
        joinDate = newJoinDate
        outstandingFee = outFee
        hasHistory = history
    End Sub

    ' METHODS
    Private Function generateNumber(birthDate As String, joinDate As String) As String
        ' Variable to return new member number
        Dim memNum As String

        ' Three integers
        Dim rn1 As Integer
        Dim rn2 As Integer
        Dim rn3 As Integer

        ' Randomize numbers
        Randomize()

        ' Generate 3 single digit random numbers
        rn1 = Math.Ceiling(Rnd() * 9)
        rn2 = Math.Ceiling(Rnd() * 9)
        rn3 = Math.Ceiling(Rnd() * 9)

        ' Get numbers from dates without seperators
        Dim year As String = birthDate.Substring(0, 4)
        Dim month As String = birthDate.Substring(5, 2)
        Dim day As String = birthDate.Substring(8, 2)
        Dim joinYear As String = joinDate.Substring(2, 2)

        ' Variable to hold the total sum of the numbers
        Dim sum As Integer = 0

        ' Combine the random numbers into 1 string
        Dim rn As String = CStr(rn1) & CStr(rn2) & CStr(rn3)

        ' Combine all the numbers into 1 string
        memNum = joinYear & year & month & day & rn

        ' Loop through the number string and add each number to sum
        For Each i As String In memNum
            sum += CInt(i)
        Next

        ' Divide sum by 10 and keep the remainder
        Dim remainder As Integer = sum Mod 10

        ' Initialize result of check digit as 0
        Dim result As Integer = 0

        ' If the remainder is greater than zero, change check digit(result)
        If remainder > 0 Then
            result = 10 - remainder
        End If

        ' Add the check digit to the end of the number string
        memNum += CStr(result)

        Return memNum
    End Function

    ' Get the date that the member joined
    Public Function getJoinDate() As String
        Return joinDate
    End Function

    ' Validate the generated member number
    Private Function validateNumber(memberNum As String) As Boolean
        ' Variable to save sum of numbers
        Dim total As Integer

        ' Add each number to total
        For Each i As String In memberNum
            total += CInt(i)
        Next

        ' Remainder of total / 10 should be 0, else calculation of member number is incorrect
        If (total Mod 10 = 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    ' Get the member number
    Public Function getMemberNumber() As String
        Return number
    End Function

    ' Set the name of the member
    Public Sub setFirstName(value As String)
        firstName = value
    End Sub

    ' Get the name of the member
    Public Function getFirstName() As String
        Return firstName
    End Function

    ' Set the surname of the member
    Public Sub setLastName(value As String)
        lastName = value
    End Sub

    ' Get the surname of the member
    Public Function getLastName() As String
        Return lastName
    End Function

    ' Set the outstanding fee
    Public Sub setOutstandingFee(value As Integer)
        outstandingFee = value
    End Sub

    ' Get the outstanding fee
    Public Function getOutstandingFee() As Integer
        Return outstandingFee
    End Function

    ' Set the birth date
    Public Sub setBirthdate(value As String)
        birthDate = value
    End Sub

    ' Get the birth date
    Public Function getBirthDate() As String
        Return birthDate
    End Function

    ' Set the gender
    Public Sub setGender(value As String)
        gender = value
    End Sub

    ' Get the gender
    Public Function getGender() As String
        Return gender
    End Function

    ' Output details of the member in an easy to read way
    Public Function GetDisplayText() As String
        Dim text As String = "Name: " & firstName & " " & lastName & vbCrLf & "Number: " & number & vbCrLf & "Birth Date:" & birthDate & vbCrLf & "Gender: " & gender & vbCrLf & "Join Date: " & joinDate & vbCrLf & "Outstanding Fee: " & outstandingFee

        Return text
    End Function

    ' Override the ToString function to give better output
    Public Overrides Function ToString() As String
        Dim text As String = firstName & " " & lastName & ", " & number

        Return text
    End Function

End Class
