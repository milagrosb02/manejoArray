Module Module1

    Sub Main()

        Dim elementos(4) As UShort

        CargarArray(elementos)

        Console.WriteLine("La media de los nros es: " & CalcularMedia(elementos))

        CalcularDesvio(elementos)

    End Sub

    Sub CargarArray(ByRef elementos() As UShort)


        For x = 0 To elementos.Length - 1

            Console.WriteLine("Ingresar numero: ")

            elementos(x) = Console.ReadLine()

        Next



    End Sub

    Function CalcularMedia(ByRef elementos() As UShort) As UShort

        Dim suma, media As UShort

        suma = 0

        media = 0

        For x = 0 To elementos.Length - 1

            suma += elementos(x)

        Next

        media = suma / elementos.Length

        Return media

    End Function


    Sub CalcularDesvio(ByRef elementos() As UShort)

        For x = 0 To elementos.Length() - 1

            Console.WriteLine("Elemento del arreglo({0} = {1}  Desvio = {2} ", x + 1, elementos(x), elementos(x) - CalcularMedia(elementos))
        Next

    End Sub

End Module
