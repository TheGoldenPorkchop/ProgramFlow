Option Explicit On
Option Strict On
Module ProgramFlow
    Sub Main()
        Dim chumpChange As Integer
        Dim userInput As String

        'assign 5 to chumpChange
        chumpChange = 5

        'display if chumpChange is greater than 6
        If chumpChange > 6 Then
            Console.WriteLine(chumpChange > 6)
        End If

        If chumpChange > 3 Then
            Console.WriteLine(chumpChange > 3)
        End If

        If chumpChange > 4 Then
            Console.WriteLine(chumpChange > 4)
        End If


        'new piece of code
        Console.WriteLine()
        'if anything evaluates to true all other evaluations are skipped
        If chumpChange > 6 Then
            Console.WriteLine(chumpChange > 6)
        ElseIf chumpChange > 3 Then
            Console.WriteLine(chumpChange > 3)
        ElseIf chumpChange > 4 Then
            Console.WriteLine(chumpChange > 4)
        End If


        'new piece of code
        Console.WriteLine()
        'assign -3 to chumpChange (chumpChange is now 2)
        chumpChange -= 3

        'if none of the conditions evaluates to true the Else case triggers
        If chumpChange > 6 Then
            Console.WriteLine($"{chumpChange} is greater than 6")
        ElseIf chumpChange > 3 Then
            Console.WriteLine($"{chumpChange} is greater than 3")
        ElseIf chumpChange > 4 Then
            Console.WriteLine($"{chumpChange} is greater than 4")
        Else
            Console.WriteLine("How did you end up here?")
        End If


        'new piece of code
        Console.WriteLine()
        Console.WriteLine("How old are you?")
        userInput = Console.ReadLine()
        chumpChange = CInt(userInput)
        Select Case chumpChange
            Case 0 To 3
                Console.WriteLine($"{chumpChange} is less than 4")
            Case 4 To 10
                Console.WriteLine($"{chumpChange} is less than 11")
            Case 11 To 64
                Console.WriteLine($"{chumpChange} is less than 65")
            Case 65 To 99
                Console.WriteLine($"{chumpChange} is less than 100")
            Case > 100
                Console.WriteLine($"{chumpChange} is greater than 100")
            Case Else
                Console.WriteLine($"Whoops")
        End Select


    End Sub

End Module
