Option Explicit On
Option Strict On
Option Compare Text
Imports System.Data.Common

Module ProgramFlow
    Sub Main()
        Dim firstNumber As Integer
        Dim getOutOfHere As Boolean = False
        Dim userInput As String

        Do
            Console.WriteLine("Enter a number")
            Console.WriteLine("Enter Q to Quit")
            userInput = Console.ReadLine()
            Console.WriteLine()

            Try
                firstNumber = CInt(userInput)
                getOutOfHere = True
            Catch ex As Exception
                If userInput = "q" Then
                    Console.WriteLine("You have Quit the program")
                    getOutOfHere = True
                Else
                    Console.WriteLine($"{userInput} is not a valid number")
                    Console.WriteLine($"Please enter a valid number")
                End If
            End Try

        Loop Until getOutOfHere = True

        Console.WriteLine()

        Console.WriteLine($"First Number = {firstNumber}")



    End Sub

End Module
