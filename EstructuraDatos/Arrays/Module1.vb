Module Module1

    Sub Main()

        'SE DECLARA UNA VARIABLE DEL TIPO ARRAY PARA QUE LO RECIBA

        Dim valores As UShort() = NuevoArray() 'LLAMANDO AL PROCEDIMIENTO

        IterarArrayFor(valores)

        ArrayDeclaracionAsignacionSimultanea()

        Dim matriz As Single(,) = NuevoArray2Dimensiones()

    End Sub

    Private Function NuevoArray() As UShort() 'CON LOS PARENTESIS SE LE INDICA AL COMPILADOR QUE TIENE QUE DEVOLVER UN TIPO DE DATO ARRAY

        'TODOS LOS ELEMENTOS DEL ARRAY DEBEN SER DEL MISMO TIPO

        'DECLARANDO UN ARRAY:

        Dim valores(2) As UShort

        'ASIGNANDO VALORES UNO POR UNO (MEDIANTE SUS INDICES):

        valores(0) = 5

        valores(1) = 15

        valores(2) = 25

        Return valores

    End Function


    Private Sub IterarArrayFor(valores() As UShort)

        'ITERANDO EL VECTOR PARA MOSTRAR CADA UNO DE SUS ELEMENTOS

        For x = 0 To valores.Length - 1

            Console.WriteLine(valores(x))

        Next

    End Sub

    Private Sub ArrayDeclaracionAsignacionSimultanea()

        'DECLARANDO EL ARRAY DE 3 ELEMENTOS Y ASIGNANDOLE VALORES

        Dim nombres = New String() {"Mili", "Miracles", "Milagros"}

        'ITERACION SOBRE EL VECTOR PARA MOSTRAR EL VALOR DE SUS ELEMENTOS

        For Each nombre In nombres

            Console.WriteLine(nombre)

        Next

    End Sub

    Private Function NuevoArray2Dimensiones() As Single(,)

        'DECLARANDO UN ARRAY DE 2 DIMENSIONES DE 3 X 2

        Dim matriz(2, 1) As Single

        'ASIGNANDOLE VALORES UNO POR UNO

        matriz(0, 0) = 1

        matriz(0, 1) = 2

        matriz(1, 0) = 3

        matriz(1, 1) = 4

        matriz(2, 0) = 5

        matriz(2, 1) = 6

        Return matriz

    End Function


    'ITERAR ARRAY DE 2 DIMENSIONES

    Sub IterarArray2Dimensiones(grid(,) As Single)

        For Each valor In grid

            Console.Write(valor & " ")

        Next

        Console.WriteLine()

    End Sub


    'PARA OBTENER INFORMACION DEL ARRAY

    Private Sub VerInfoArray(grid1(,) As UShort)

        Console.WriteLine("Longitud: " & grid1.Length())

        Console.WriteLine("Ultima posicion dimension 0: " & grid1.GetUpperBound(0)) 'LIMITE SUPERIOR DE CADA DIMENSION

        Console.WriteLine("Ultima posicion dimension 1: " & grid1.GetUpperBound(1))

    End Sub


End Module
