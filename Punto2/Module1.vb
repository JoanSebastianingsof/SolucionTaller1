Module Module1

    Sub Main()
        Dim myArray(50) As Integer
        Dim limiteSuperior As Integer = 100
        Dim limiteInferior As Integer = -100
        Dim Cero As Integer = 0
        Dim Positivo As Integer = 0
        Dim Negativo As Integer = 0

        For i = 0 To 49 Step 1


            myArray(i) = (limiteSuperior - limiteInferior + 1) * Rnd() + limiteInferior

        Next
        For i = 0 To 49 Step 1

            Console.WriteLine(myArray(i))
        Next
        For i = 0 To 49 Step 1
            If myArray(i) = 0 Then
                Cero += 1
            ElseIf myArray(i) > 0 Then
                Positivo += 1
            ElseIf myArray(i) < 0 Then
                Negativo += 1
            End If
        Next
        Console.WriteLine("La cantidad de numeros positivos dentro del arreglo son: " & Positivo)
        Console.WriteLine("La cantidad de numeros negativos dentro del arreglo son: " & Negativo)
        Console.WriteLine("La cantidad de numeros ceros dentro del arreglo son: " & Cero)
    End Sub

End Module
