Module Module1

    Sub multiplo()

        Console.WriteLine("elije una opcion ya sea 1 o 2:")
        Dim opcion As Integer = Console.ReadLine()
        If opcion = 1 Then
            ' ------  MULTIPLO
            Console.WriteLine("Presione 1 si desea consultar que el  número ingresado es múltiplo de 5")
            Console.WriteLine("Presione 2 si el numero a ingresar es múltiplo de 3")
            Dim múltiplo = Console.ReadLine()
            If múltiplo = 1 Then
                Console.WriteLine("Escriba un numero para saber si su número ingresado es múltiplo de 5")
                Dim nume = Console.ReadLine()
                If nume Mod 5 = 0 Then
                    Console.WriteLine("El número que usted ha ingresado es un múltiplo de 5")
                Else Console.WriteLine("Su número ingresado no es múltiplo de 5")
                    Console.ReadLine()
                End If
            ElseIf múltiplo = 2 Then
                Console.WriteLine("Inserte un numero para saber si el numero ingresado es múltiplo de 3")
                Dim nume = Console.ReadLine()
                If nume Mod 3 = 0 Then
                    Console.WriteLine("Su número ingresado es múltiplo de 3")
                Else Console.WriteLine("Su número que ha ingresado no es múltiplo de 3")
                    Console.ReadLine()
                    Console.ReadLine()
                End If
            End If
        End If

    End Sub

    Sub Registroacademico()
        Console.WriteLine("Escriba los nombres del Alumno o Alumna  a Consultar")
        Dim nombre As String = Console.ReadLine()
        Console.WriteLine("Escribas los apellidos de Alumno o Alumna a Consultar")
        Dim apellido As String = Console.ReadLine()

        Console.WriteLine("Escriba la asistencia obtenida del estudiante (a) " & nombre & " en formato entero ")
        Dim asistencia As Integer = Console.ReadLine()

        Console.WriteLine("Escriba la nota obtenida de " & nombre)
        Dim nota = Console.ReadLine()

        If asistencia >= 75 And asistencia <= 100 And nota >= 6.0 And nota <= 10.0 Then
            Console.WriteLine("El estudiante (a) " & nombre & " obtuvo una calificacion de " & nota & " y un promdio de asistencia " & asistencia & "%  por lo tanto el alumno (a) " & nombre & "fue aprobado")
            Console.ReadLine()

        ElseIf asistencia >= 0 And asistencia < 75 And nota < 6.0 And nota > 0.0 Then
            Console.WriteLine("El estudiante (a) " & nombre & " obtuvo una calificacion de " & nota & " y un promedio de  asistencia " & asistencia & "% Por lo tanto el alumno (a) " & nombre & " queda reprobado ")
            Console.ReadLine()

        ElseIf asistencia >= 0 And asistencia < 75 And nota >= 6.0 And nota <= 10.0 Then
            Console.WriteLine("El estudiante (a) " & nombre & " obtuvo una  calificacion de " & nota & " y un promedio de asistencia " & asistencia & "% por lo tanto " & nombre & "queda reprobado")
            Console.ReadLine()

        ElseIf asistencia >= 75 And asistencia <= 100 And nota >= 6.0 And nota <= 10.0 Then
            Console.WriteLine("El estudiante " & nombre & " reprobo con una de calificacion " & nota & " y un promedio de  asistencia " & asistencia & "%")
            Console.ReadLine()
        End If



    End Sub

    Sub TEMPERATURA()
        Dim temp As String
        Console.WriteLine("Ingrese la palabra de como se siente la temperatura, caloroso,calido,lluvioso")
        temp = Console.ReadLine()
        Select Case temp
            Case "frio"
                Console.WriteLine(" Necesita abrigarse pongase algo comodo para el frio")

            Case "caloroso"
                Console.WriteLine("Necesita tomar un baño o algunas bebidas frias que le ayuden a refrescarse y no sentir calor ")

            Case "calido"
                Console.WriteLine("El clima esta en perfectas condiciones para poder disfrutar cosn sus amigos o familia ")

            Case "lluvioso"
                Console.WriteLine("Si sus planes son de salida pongase algo comodo y no olvide su paraguas ")

        End Select
        Console.ReadLine()
    End Sub

    Sub TICKTOCK()
        Dim index = 0
        Console.WriteLine("Si en los primeros 100 intentos si en el programa le aparece la palabra  TICK  eso quiere decir que es un multiplo de 3")
        Console.WriteLine("y si en el programa muestra  la palabra  TOCK  es un multiplo de 5 y si le le muestra tick-tock eso quiere decir que es  multiplo de 3 y 5")

        While index <= 100
            If index Mod 3 = 0 And index Mod 5 = 0 Then
                Console.WriteLine("TICK-TOCK")
            ElseIf index Mod 5 = 0 Then
                Console.WriteLine("TOCK")
            ElseIf index Mod 3 = 0 Then
                Console.WriteLine("TICK")
            ElseIf index Mod 3 <> 0 And index Mod 5 <> 0 Then
                Console.WriteLine(index)
            End If
            '            index = index + 1
        End While
        Console.ReadLine()


    End Sub

    Sub Grupos()
        Dim salida = 1
        Dim menu = 0
        While menu <= 3
            Console.WriteLine("Elija un grupo y luego se le dara la opcion de escoger un deportista favorito, un Genero Musical favorito o una serie favorita")
            Console.WriteLine("")
            Console.WriteLine("1.Deportistas")
            Console.WriteLine("2.Generos musicales")
            Console.WriteLine("3.Series")
            Console.WriteLine("")
            Dim sum As Integer = Console.ReadLine

            If sum = 1 Then

                Dim Deportes = "deportistas"
                Console.WriteLine("1. Paulo Dybala")
                Console.WriteLine("2. Julian Draxler")
                Console.WriteLine("3. Kilyam Mbappe")
                Console.WriteLine("4. Eden Hazard")
                Console.WriteLine("Ingrese el numero de su Deportista Favorito")
                Console.WriteLine("")
                Dim favorito = Console.ReadLine()
                If favorito = 1 Then
                    favorito = "Paulo Dybala"
                ElseIf favorito = 2 Then
                    favorito = "Julian Draxler"
                ElseIf favorito = 3 Then
                    favorito = "Kyliam Mbappe"
                ElseIf favorito = 4 Then
                    favorito = "Eden Hazard "
                End If
                Console.WriteLine("su grupo favorito es " & Deportes & " y su deportista favorito es " & favorito)
                Console.ReadLine()

            ElseIf sum = 2 Then

                Console.WriteLine("Ingrese un numero de su genero musical Favorito")
                Dim generomusicales = "Generos Musicales"
                Console.WriteLine("1.Electronica")
                Console.WriteLine("2. Romantica")
                Console.WriteLine("3. Clasicos Ingles")
                Console.WriteLine("4. Regueton")
                Console.WriteLine("5. Bachata")
                Console.WriteLine("")
                Dim genero = Console.ReadLine()
                If genero = 1 Then
                    genero = "Electronica"
                ElseIf genero = 2 Then
                    genero = "Romantica"
                ElseIf genero = 3 Then
                    genero = "Clasicos Ingles"
                ElseIf genero = 4 Then
                    genero = "Regueton"
                ElseIf genero = 5 Then
                    genero = "Bachata"
                End If

                Console.WriteLine("su grupo favorito es " & generomusicales & " y su Genero musical  favorito es " & genero)
                Console.ReadLine()
            ElseIf sum = 3 Then
                Console.WriteLine("Ingrese una de sus series Favorita ")
                Dim serie = "Series"
                Console.WriteLine("1. Austin y Ally")
                Console.WriteLine("2. Dragon ball Z")
                Console.WriteLine("3. Los caballeros del Zodiaco El Lienzo perdido")
                Console.WriteLine("4. Los Thundercats Los Felinos Cosmicos")
                Dim series = Console.ReadLine()
                If series = 1 Then
                    series = "Austin y Ally"
                ElseIf series = 2 Then
                    series = "Dragon ball z"
                ElseIf series = 3 Then
                    series = " Los Caballeros del Zodiaco El Lienzo perdido"
                ElseIf series = 4 Then
                    series = "Los Thundercats Los Felinos cosmicos"
                End If

                Console.WriteLine("Su grupo favorito es " & serie & " y su serie favorita es " & series)
                Console.ReadLine()
            End If
            salida = salida + 1

        End While
        Console.ReadLine()




    End Sub


    Sub Main()
        Console.WriteLine(" Eliga un numero para poder Ejecutar el programa de su Eleccion")
        Console.WriteLine(" 1. Multiplo ")
        Console.WriteLine(" 2. Resultado Academico ")
        Console.WriteLine(" 3. Temperatura")
        Console.WriteLine(" 4. TICK-TOCK")
        Console.WriteLine(" 5. Grupos Favoritos")

        Dim menu = Console.ReadLine()
        Select Case menu
            Case Is = 1
                Call multiplo()
            Case Is = 2
                Call Registroacademico()
            Case Is = 3
                Call TEMPERATURA()
            Case Is = 4
                Call TICKTOCK()
            Case Is = 5
                Call Grupos()
            Case Else
                Console.WriteLine(" Esta opcion es invalida por favor ingrese una opcion correcta del 1-5 ")
                Console.ReadLine()


        End Select
        Return


    End Sub
End Module





