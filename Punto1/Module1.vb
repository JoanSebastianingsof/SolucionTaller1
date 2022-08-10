Module Module1

    Sub Main()
        Dim cantidad As Integer = 0

        Console.WriteLine("Escriba la cantidad del arreglo")
        cantidad = Console.ReadLine()
        Dim myArray(cantidad) As Double

        cantidad = cantidad - 1


        For i = 0 To cantidad Step 1

            myArray(i) = i + 1
        Next
        For i = 0 To cantidad Step 1

            Console.WriteLine(myArray(i))
        Next
    End Sub

End Module
