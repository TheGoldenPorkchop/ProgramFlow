Option Explicit On
Option Strict On
Option Compare Text
Imports System.Data.Common

Module ProgramFlow
    Sub Main()
        Dim chumpChange As Integer
        Dim userInput As String

        ''assign 5 to chumpChange
        'chumpChange = 5

        ''display if chumpChange is greater than 6
        'If chumpChange > 6 Then
        '    Console.WriteLine(chumpChange > 6)
        'End If

        'If chumpChange > 3 Then
        '    Console.WriteLine(chumpChange > 3)
        'End If

        'If chumpChange > 4 Then
        '    Console.WriteLine(chumpChange > 4)
        'End If


        ''new piece of code
        'Console.WriteLine()
        ''if anything evaluates to true all other evaluations are skipped
        'If chumpChange > 6 Then
        '    Console.WriteLine(chumpChange > 6)
        'ElseIf chumpChange > 3 Then
        '    Console.WriteLine(chumpChange > 3)
        'ElseIf chumpChange > 4 Then
        '    Console.WriteLine(chumpChange > 4)
        'End If


        ''new piece of code
        'Console.WriteLine()
        ''assign -3 to chumpChange (chumpChange is now 2)
        'chumpChange -= 3

        ''if none of the conditions evaluates to true the Else case triggers
        'If chumpChange > 6 Then
        '    Console.WriteLine($"{chumpChange} is greater than 6")
        'ElseIf chumpChange > 3 Then
        '    Console.WriteLine($"{chumpChange} is greater than 3")
        'ElseIf chumpChange > 4 Then
        '    Console.WriteLine($"{chumpChange} is greater than 4")
        'Else
        '    Console.WriteLine("How did you end up here?")
        'End If


        ''new piece of code
        'Do
        '    Console.WriteLine()
        '    Console.WriteLine("how old are you?")
        '    userInput = Console.ReadLine()

        '    Try
        '        chumpChange = CInt(userInput)
        '        Select Case chumpChange
        '            Case 0 To 3
        '                Console.WriteLine($"you're {chumpChange} years old? how about we go look for your parents.")
        '            Case 4 To 10
        '                Console.WriteLine($"you're {chumpChange} years old? sorry bubby, you're not old enough to ride.")
        '            Case 11 To 64
        '                Console.WriteLine($"you're {chumpChange} years old? hope you enjoy the ride!")
        '            Case 65 To 99
        '                Console.WriteLine($"you're {chumpChange} years old? i just need you to sign this release form.")
        '            Case > 100
        '                Console.WriteLine($"you're {chumpChange} years old? i think you may be too old for this ride...")
        '            Case Else
        '                Console.WriteLine($"whoops...")
        '        End Select

        '    Catch ex As Exception
        '        Console.WriteLine($"you entered {userInput}.")
        '        Console.WriteLine($"please enter a number.")
        '    End Try

        'Loop Until userInput = "q"

        ''Will run the code inside the loop at least once
        'Do
        '    Console.WriteLine("Type something and press enter:")
        '    userInput = Console.ReadLine()
        '    Console.WriteLine($"In the Do Until Loop:")
        'Loop Until userInput = "Q"

        ''Will only run the code inside the Do While loop when the condition is true
        'Do While userInput = "Q"
        '    Console.WriteLine("Type something and press enter:")
        '    userInput = Console.ReadLine()
        '    Console.WriteLine($"In the Do While Loop: ")
        'Loop

        'For i As Integer = 1 To 10 Step 1
        '    Console.WriteLine(i)
        'Next
        'Console.WriteLine(StrDup(80, "*"))

        'For i = 1 To 10 Step 0.5
        '    Console.WriteLine(i)
        'Next
        'Console.WriteLine(StrDup(80, "*"))

        'For i = 1 To 10
        '    Console.WriteLine(i)
        'Next
        'Console.WriteLine(StrDup(80, "*"))

        'nested for loops
        'For i = 0 To 20
        '    For j = 1 To 20
        '        If i + j >= 10 Then
        '            Console.Write(i + j & " ")
        '        ElseIf i + j >= 100 Then
        '            Console.Write(i + j & "   ")
        '        Else
        '            Console.Write(i + j & "  ")
        '        End If
        '    Next
        '    Console.WriteLine()
        'Next

        Dim result As String

        For i = 0 To 10
            For j = 1 To 10
                'result = CStr(i + j)
                result = (i + j).ToString("C")
                result = result.PadLeft(8)
                'result = StrReverse(result)
                Console.Write(result)
            Next
            Console.WriteLine()
        Next


    End Sub

End Module
