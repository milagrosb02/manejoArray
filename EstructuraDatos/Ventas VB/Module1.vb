Module Module1

    Sub Main()

        Dim codigos = New UShort() {1, 2, 3}

        Dim nombres = New String() {"yerba", "sal", "ajo"}

        Dim precios = New Decimal() {60.5, 50.2, 15.5}

        Dim codigo, cantidad As UShort

        Dim aux_precio, totalVenta, total As Decimal


        codigo = IngresarCodigo()

        Do While codigo <> 0


            If ValidarCodProducto(codigo, codigos) = True Then

                For i = 0 To codigos.Length() - 1

                    Console.WriteLine("Producto: " & nombres(i))

                    Console.WriteLine("Precio: " & precios(i))

                    aux_precio = precios(i)


                Next

                Console.WriteLine("Ingresar cantidad: ")

                cantidad = Console.ReadLine()

                totalVenta = aux_precio * cantidad

                total += totalVenta

                Console.WriteLine("El total de venta es de: " & total)

            Else

                codigo = IngresarCodigo()

            End If

        Loop

    End Sub


    Function IngresarCodigo() As UShort

        Console.WriteLine("Ingresar codigo: ")

        Return Console.ReadLine()

    End Function
    Function ValidarCodProducto(ByRef codigo As UShort, ByRef codigos() As UShort) As Boolean

        For Each valor In codigos

            If valor = codigo Then

                Return True

            End If
        Next

        Console.WriteLine("Codigo erroneo")

        Return False

    End Function

End Module
