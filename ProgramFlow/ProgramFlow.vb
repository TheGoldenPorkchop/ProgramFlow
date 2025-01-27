Option Explicit On
Option Strict On
Module ProgramFlow
    Sub Main()
        Dim chumpChange As Integer

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

    End Sub

End Module
