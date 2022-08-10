Module Module1

    Sub Main()

        Dim myArray(19) As Integer

        Dim pares As Integer = 0
        Dim impares As Integer = 0

        For i = 0 To 19 Step 1

            myArray(i) = i + 1

        Next
        For i = 0 To 19 Step 1

            Console.WriteLine(myArray(i))
        Next
        For i = 0 To 19
            If myArray(i) Mod 2 = 0 Then
                pares += 1

            ElseIf myArray(i) Mod 2 = 1 Then

                impares += 1


            End If

            ' Console.WriteLine(myArray(i))
        Next
        Console.WriteLine("Cantidad de numeros pares :" & pares)

        Console.WriteLine("Cantidad de numeros impares :" & impares)
    End Sub

End Module
