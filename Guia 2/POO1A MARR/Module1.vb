Module Module1

    Sub Main()
        Impares()
        SumaDeNumeros()
        Adivinanza()
        Factorial()
        InvertirCadena()
        ListaAlumnos()
        ContadorPalabras()
        AritmeticaConConjuntos()
    End Sub

    Sub Impares()
        Dim impar As Integer = 1
        While impar <= 40
            If (impar Mod 2 <> 0) Then
                Console.WriteLine(impar)
            End If
            impar += 1
        End While

        Console.ReadLine()
    End Sub

    Sub SumaDeNumeros()

        Dim nume As Integer
        Console.WriteLine("Por favor ingrese un numero para poder realizar la operacion : ")
        nume = Console.ReadLine()
        Dim sumatoria As Integer = 0

        Dim index As Integer = 1
        While index <= nume
            sumatoria += index
            index += 1
        End While

        Console.WriteLine("El resultado obtenido de la suma es: " & sumatoria)
        Console.ReadLine()

    End Sub

    Sub Adivinanza()
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

    Sub Factorial()
        Dim factorial As Integer
        Console.WriteLine("Ingrese un numero: ")
        factorial = Console.ReadLine()

        Dim factor As Integer = 1
        For i = 1 To factorial
            factor = factor * i
        Next

        Console.WriteLine("El numero factorial obtenido es  " & factorial & " es " & factor)
        Console.ReadLine()
    End Sub

    Sub Invertir()
        Dim cadena As String
        Console.WriteLine("Ingrese una cadena: ")
        cadena = Console.ReadLine()
        For index = cadena.Length - 1 To 0 Step -1
            Console.Write(cadena(index))
        Next
        Console.ReadLine()
    End Sub

    Sub Lista()
        Console.WriteLine("ESTUDIANTES DE GESTION DE BASE DE DATOS")
        Dim nombres() As String = {"Glenda", "Geovanny", "Mauricio", "Raul", "Luna"}
        For Each nombre As String In nombres
            Console.WriteLine(nombres)
        Next
        Console.ReadLine()
    End Sub

    Sub Contador()
        Dim contador As String
        Console.WriteLine("Ingrese una frase: ")
        contador = Console.ReadLine()

        Dim palabras() As String = contador.Split(" ")

        Console.WriteLine("La frase '" & contador & "' tiene " & palabras.Count & " palabras.")
        For Each palabra As String In palabras
            Console.WriteLine("La palabra '" & palabra & "' tiene " & palabra.Length & " letras.")
        Next

        Console.ReadLine()
    End Sub

    Sub AritmeticaConConjuntos()
        Dim grupo1() As Integer = {1, 2, 3, 4, 5}
        Dim grupo2() As Integer = {6, 7, 8, 9, 10}

        'Sumas
        Console.WriteLine("Sumas: ")
        For i = 0 To grupo1.Length - 1
            Console.WriteLine(grupo1(i) & " + " & grupo2(i) & " = " & (grupo1(i) + grupo2(i)))
        Next

        Console.WriteLine()

        Console.WriteLine("Restas: ")
        For i = 0 To grupo1.Length - 1
            Console.WriteLine(grupo1(i) & " - " & grupo2(i) & " = " & (grupo1(i) - grupo2(i)))
        Next

        Console.WriteLine()

        Console.WriteLine("Multiplicacion: ")
        For i = 0 To grupo1.Length - 1
            Console.WriteLine(grupo1(i) & " * " & grupo2(i) & " = " & (grupo1(i) * grupo2(i)))
        Next

        Console.WriteLine()

        Console.WriteLine("Division: ")
        For i = 0 To grupo1.Length - 1
            Console.WriteLine(grupo1(i) & " / " & grupo2(i) & " = " & (grupo1(i) / grupo2(i)))
        Next

        Console.ReadLine()
    End Sub


End Module
