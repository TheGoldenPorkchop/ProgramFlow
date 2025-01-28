Option Explicit On
Option Strict On
Option Compare Text
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
        Do
            Console.WriteLine()
            Console.WriteLine("How old are you?")
            userInput = Console.ReadLine()

            Try
                chumpChange = CInt(userInput)
                Select Case chumpChange
                    Case 0 To 3
                        Console.WriteLine($"You're {chumpChange} years old? How about we go look for your parents.")
                    Case 4 To 10
                        Console.WriteLine($"You're {chumpChange} years old? Sorry bubby, you're not old enough to ride.")
                    Case 11 To 64
                        Console.WriteLine($"You're {chumpChange} years old? Hope you enjoy the ride!")
                    Case 65 To 99
                        Console.WriteLine($"You're {chumpChange} years old? I just need you to sign this release form.")
                    Case > 100
                        Console.WriteLine($"You're {chumpChange} years old? I think you may be TOO old for this ride...")
                    Case Else
                        Console.WriteLine($"Whoops...")
                End Select

            Catch ex As Exception
                Console.WriteLine($"You entered {userInput}.")
                Console.WriteLine($"Please enter a number.")
            End Try

        Loop Until userInput = "Q"

    End Sub

End Module
