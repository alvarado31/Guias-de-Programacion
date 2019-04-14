Module Module1
    Sub main()
        Numeros()
        suma()
        adivinanza()
        Numfactorial()
        tablaMultiplicacion()
        InvertirCadena()
        lista()
        Contador()
        Aritmetica()

    End Sub
    Sub main()
        Console.WriteLine(" Eliga un numero para poder Ejecutar el programa de su Eleccion")
        Console.WriteLine(" 1. Numeros ")
        Console.WriteLine(" 2. suma ")
        Console.WriteLine(" 3. adivinanza")
        Console.WriteLine(" 4. Numeros Factorial")
        Console.WriteLine(" 5. Tablas de Multiplicacion")
        Console.WriteLine(" 6. Invertir cadena ")
        Console.WriteLine(" 7. Lista de Nombres")
        Console.WriteLine(" 8. Contador de palabras y contadores")
        Console.WriteLine(" 9. Aritmeticos")


        Dim menu = Console.ReadLine()
        Select Case menu
            Case Is = 1
                Call numeros()
            Case Is = 2
                Call suma()
            Case Is = 3
                Call adivinanza()
            Case Is = 4
                Call Numfactorial()
            Case Is = 5
                Call tablaMultiplicacion()
            Case Is = 6
                Call invertirCadena()
            Case Is = 7
                Call lista()
            Case Is = 8
                Call Contador()
            Case Is = 9
                Call Aritmetica()

                Console.WriteLine(" Esta opcion es invalida por favor ingrese una opcion correcta del 1-9 ")
                Console.ReadLine()


        End Select
        Return


    End Sub

    Sub Numeros()
        Console.WriteLine("Este es un pequeño programa para poder ver los numeros impares del 1-40")
        Dim index = 0
        While index <= 40
            If index Mod 2 <> 0 Then
                Console.WriteLine(index)
            Else Console.WriteLine(" ")
            End If
            index = index + 1
        End While
        Console.ReadLine()


    End Sub



    Sub suma()
        Console.WriteLine(" Suma de numeros enteros")
        Dim nose = 0
        Dim sum = 0
        Console.WriteLine(" Por favor ingrese  un numero para poder sumar todos sus numeros enteros")
        Dim numeros As Integer = Console.ReadLine
        While nose < numeros
            nose = nose + 1
            sum = sum + nose
        End While
        Console.WriteLine("La suma del numero proporcionado por el usuario es " & numeros & " es " & sum)
        Console.ReadLine()




    End Sub

    Sub adivinanza()
        Dim numero As Integer
        Console.WriteLine("Este es un programa para determinar la adivinanza de un numero")
        Dim numGenerado As Int16 = New Random().Next(1, 11)
        Do Until numero = numGenerado
            Console.WriteLine("Ingrese un numero para poder determinar o adivinar si el programa proporciona numeros  entre 0-10")
            numero = Console.ReadLine()
            If numero <> numGenerado Then
                Console.WriteLine("  OHHHHH Parece que has tenido mala Suerte por favor sigue intentando")
            ElseIf numero = numGenerado Then
                Console.WriteLine(" Parece que has acertado en el juego que buena suerte ha tenido esta vez")



            End If
            Console.ReadLine()
        Loop


    End Sub
    Sub Numfactorial()
        Dim o, t As Integer
        Dim s As Integer = 1
        Dim p As Integer = 1
        Console.WriteLine("Digite un numero para pooder verificar cual es su  factorial")
        o = Console.ReadLine()
        For t = 1 To o
            s = s * p
            p = p + 1
        Next
        Console.WriteLine(s)
        Console.ReadLine()


    End Sub
    Sub tablaMultiplicacion()
        Dim numero As Integer
        Dim nume1 As Integer = 10
        Dim nume2 As Integer = 1
        Dim nume3 As Integer = 1
        Dim nume4 As Integer
        Console.WriteLine("Ingrese un numero para poder mostrar  la tabla de multiplicacion")
        Dim nume5 = Console.ReadLine()
        For numero = 1 To nume1
            nume4 = nume2 * nume5
            Console.WriteLine(nume2 & "*" & nume5 & "=" & nume4)
            nume2 = nume2 + 1
        Next
        Console.ReadLine()
    End Sub



    Sub invertirCadena()
    Dim cadena As String
        Console.WriteLine("Ingrese una palabra o frase para saber que l que dice al revez   ")
        cadena = Console.ReadLine()
    For index = cadena.Length - 1 To 0 Step -1
        Console.Write(cadena(index))
    Next
    Console.ReadLine()


End Sub
Sub lista()

    Console.WriteLine("ESTUDIANTES DE GESTION DE BASE DE DATOS")
    Dim nombres() As String = {"Glenda", "Geovanny", "Mauricio", "Raul", "Luna"}
    For Each nombre As String In nombres
        Console.WriteLine(nombres)
    Next
    Console.ReadLine()

End Sub
    Sub Contador()
        Console.WriteLine("Contar palabras y caracteras")
        Dim conta As String
        Console.WriteLine("Ingrese una frase para poder saber cual es el numero de caracteres que posee: ")
        conta = Console.ReadLine()

        Dim words() As String = conta.Split(" ")

        Console.WriteLine("La frase ingresada '" & conta & "' contiene " & words.Count & "todas estas palabras.")
        For Each palabra As String In words
            Console.WriteLine("La palabra '" & palabra & "' contiene " & palabra.Length & " todas estas letras.")
        Next

        Console.ReadLine()
    End Sub
    Sub Aritmetica()
        Dim estrato1() As Integer = {1, 2, 3, 4, 5}
        Dim estrato2() As Integer = {6, 7, 8, 9, 10}

        'Sumatoria
        Console.WriteLine(" Sumas de numeros enteros ")
        For index = 0 To estrato1.Length - 1
            Console.WriteLine(estrato1(index) & " + " & estrato2(index) & " = " & (estrato1(index) + estrato2(index)))
        Next

        Console.ReadLine()
        'restas

        Console.WriteLine(" Restas de numeros enteros ")
        For index = 0 To estrato1.Length - 1
            Console.WriteLine(estrato1(index) & " - " & estrato2(index) & " = " & (estrato1(index) - estrato2(index)))
        Next

        Console.ReadLine()
        'Multiplicacion de numeros

        Console.WriteLine("Multiplicacion de numeros enteros ")
        For index = 0 To estrato1.Length - 1
            Console.WriteLine(estrato1(index) & " * " & estrato2(index) & " = " & (estrato1(index) * estrato2(index)))
        Next

        Console.ReadLine()
        'Division de numeros

        Console.WriteLine("Division de numeros enteros: ")
        For index = 0 To estrato1.Length - 1
            Console.WriteLine(estrato1(index) & " / " & estrato2(index) & " = " & (estrato1(index) / estrato2(index)))
        Next

        Console.ReadLine()
End Sub

End Module






