Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class FieldValidator

    Private PassLength = 5

    ' Define supported field types
    Public Enum FieldType
        NAME
        MONEY
        NUMBER
        LOCATION
        EMAIL
        PHONE
        PASSWORD
        DATEVALUE
    End Enum

    ' Structure to hold one validation entry
    Public Structure ValidationEntry
        Public TextBox As TextBox
        Public Label As Label
        Public Field As FieldType
    End Structure

    ' Add a new entry
    Public Sub AddEntry(txt As TextBox, lbl As Label, field As FieldType)
        Dim entry As New ValidationEntry With {
            .TextBox = txt,
            .Label = lbl,
            .Field = field
        }
        ValidationEntries.Add(entry)
    End Sub

    Public Sub AddEntry(txt As Guna.UI2.WinForms.Guna2TextBox, lbl As Label, field As FieldType)
        Dim textBox = New TextBox
        textBox.Text = txt.Text
        Dim entry As New ValidationEntry With {
            .TextBox = textBox,
            .Label = lbl,
            .Field = field
        }
        ValidationEntries.Add(entry)
    End Sub
    'Set years or days from today to DateTimePicker
    Public Sub AddEntry(dtp As Guna.UI2.WinForms.Guna2DateTimePicker, StartValue As Integer?, EndValue As Integer?, Optional CalculateInDays As Boolean = False)
        If StartValue IsNot Nothing Then
            If CalculateInDays Then
                dtp.MinDate = Today.AddDays(StartValue.Value)
            Else
                dtp.MinDate = Today.AddYears(StartValue.Value)
            End If
        End If

        If EndValue IsNot Nothing Then
            If CalculateInDays Then
                dtp.MaxDate = Today.AddDays(EndValue.Value)
            Else
                dtp.MaxDate = Today.AddYears(EndValue.Value)
            End If
        End If
    End Sub


    ' The collection of validation entries
    Private ValidationEntries As New List(Of ValidationEntry)


    ' Clear all entries
    Public Sub ClearEntries()
        ValidationEntries.Clear()
    End Sub
    ' Validate all entries
    Public Function ValidateAll() As Boolean
        Dim allValid As Boolean = True

        For Each entry In ValidationEntries
            Dim errorMessage As String = ValidateField(entry.TextBox, entry.Label, entry.Field)

            If errorMessage IsNot Nothing Then
                MsgBox(errorMessage)
                allValid = False
                Exit For
            End If
        Next

        Return allValid
    End Function

    ' Core validation logic (same as before)
    Private Function ValidateField(txt As TextBox, lbl As Label, field As FieldType) As String
        Dim input As String = txt.Text.Trim()
        Dim label As String = lbl.Text.Replace(":", "")
        Dim errorMessage As String = Nothing

        Select Case field
            Case FieldType.NAME
                If input.Length < 3 Then
                    errorMessage = $"The '{label}' filed cannot be less than 3 characters."
                ElseIf Not Regex.IsMatch(input, "^[a-zA-Z\s]+$") Then
                    errorMessage = $"The '{label}' filed must only contain letters and spaces."
                End If

            Case FieldType.PASSWORD
                If EstimateStrengthScore(input) < 5 Then
                    errorMessage = $"The '{label}' filed must not be less than {PassLength} characters, have upper and lower cases and contain a number. Adding a symbol makes it even stronger!."
                End If

            Case FieldType.MONEY
                Dim value As Decimal
                If Not Decimal.TryParse(input, value) OrElse value < 0D Then
                    errorMessage = $"Please enter a valid non-negative monetary amount in the '{label}' field."
                End If

            Case FieldType.NUMBER
                Dim number As Integer
                If Not Integer.TryParse(input, number) Then
                    errorMessage = $"Please enter a valid integer number in the '{label}' field."
                End If

            Case FieldType.LOCATION
                If input.Length Then
                    errorMessage = $"The '{label}' field cannot be less than 3 characters."
                End If

            Case FieldType.EMAIL
                If String.IsNullOrWhiteSpace(input) Then
                    errorMessage = $"The '{label}' field cannot be empty."
                ElseIf Not Regex.IsMatch(input, "^[^@\s]+@[^@\s]+\.[^@\s]+$") Then
                    errorMessage = $"Please enter a valid email address in the '{label}' field."
                End If

            Case FieldType.PHONE
                If String.IsNullOrWhiteSpace(input) Then
                    errorMessage = $"The '{label}' field cannot be empty."
                ElseIf Not Regex.IsMatch(input, "^\+?\d{7,15}$") Then
                    errorMessage = $"Please enter a valid phone number (7–15 digits, optional + prefix) in the '{label}' field."
                End If

            Case FieldType.DATEVALUE
                Dim dt As Date
                If Not Date.TryParse(input, dt) Then
                    errorMessage = $"Please enter a valid date in the '{label}' field."
                End If
        End Select

        Return errorMessage
    End Function



    Public Function EstimateStrengthScore(password As String) As Integer
        If String.IsNullOrEmpty(password) Then Return 0
        Dim score As Integer = 0
        If password.Length >= PassLength Then score += 1
        If Regex.IsMatch(password, "[A-Z]") AndAlso Regex.IsMatch(password, "[a-z]") Then score += 1
        If Regex.IsMatch(password, "\d") Then score += 1
        If Regex.IsMatch(password, "[^A-Za-z0-9]") Then score += 1
        If Not Regex.IsMatch(password, "(.)\1\1") Then score += 1
        Return score
    End Function

End Class
