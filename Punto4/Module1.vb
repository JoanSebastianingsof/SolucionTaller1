Module Module1

    Sub Main()
        Dim myArray(1) As Integer
        Console.WriteLine("Introduzca el tamaño del arreglo")
        Dim Tam As Short = Console.ReadLine()
        ReDim myArray(Tam)

        For i = 0 To Tam Step 1

            Console.WriteLine("Introduz el valor del arreglo en la posicion {0}", i)
            myArray(i) = Console.ReadLine()
            myArray(i) *= myArray(i)
        Next

        For i = 0 To Tam Step 1
            Console.WriteLine(myArray(i))
        Next
    End Sub

End Module
