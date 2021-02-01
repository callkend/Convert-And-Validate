'Kendall Callister
'RCET0265
'Spring 2021
'ConvertAndValidate
'https://github.com/callkend/Convert-And-Validate.git

Option Explicit On
Option Strict On

Module ConvertAndValidate
    Sub Main()
        Dim userInput As String
        Dim validated As String
        Dim convertedInteger As Integer
        Console.WriteLine("Enter String to be converted to a Integer")
        userInput = Console.ReadLine()
        validated = ValidateAndConvert(userInput, convertedInteger)
        If validated = String.Empty Then
            Console.WriteLine($"Integer = {convertedInteger}")
        Else
            Console.WriteLine($"User Input {validated}")
        End If
        Console.ReadLine()
    End Sub

    Function ValidateAndConvert(convertThisString As String, ByRef toThisInterger As Integer) As String
        Try
            toThisInterger = CInt(convertThisString)
            Return String.Empty
        Catch ex As Exception
            If convertThisString = "" Then
                Return "is empty"
            Else
                Return "must contain number"
            End If

        End Try
    End Function
End Module
