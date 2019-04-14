Module Module1

    Sub Main()
        While True
            Console.WriteLine("elije una opcion:")
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
            ElseIf opcion = 2 Then
                Console.WriteLine("Ingrese los nombres del estudiante ")
                Dim nombre As String = Console.ReadLine()

                Console.WriteLine(" Ingrese los apellidos del Estudiante")
                Dim apellido As String = Console.ReadLine()


                Console.WriteLine("Ingrese la Nota  obtenida durante el periodo de  " & nombre & "")
                Dim Nota As Integer = Console.ReadLine()

                Console.WriteLine("Ingrese el porcentaje de asitencia obtenido de " & nombre & "")
                Dim asistencia = Console.ReadLine()

                If Nota >= 6 And asistencia <= 10 And asistencia >= 75 And asistencia <= 100 Then
                    Console.WriteLine("El estudiante " & nombre & " Obtuvo una calificacion de " & Nota & "y un proemdio de asitencia de " & asistencia & "%")
                    Console.ReadLine()

                ElseIf Nota >= 0 And Nota < 6 And asistencia <= 0 And asistencia < 75 Then
                    Console.WriteLine(" El estudiante " & nombre & " obtuvo una calificacion de  " & Nota & " y un promedio de asitencia de  " & asistencia & "% por lo tanto queda reprobado")
                    Console.ReadLine()

                ElseIf Nota >= 0 And Nota < 6 And asistencia >= 75 And asistencia <= 100 Then
                    Console.WriteLine("El estudiante " & nombre & " obtuvo una calificacion de " & Nota & " yun promedio de asistencia de " & asistencia & "%")
                    Console.ReadLine()

                ElseIf Nota >= 6 And Nota <= 10 And asistencia >= 75 And asistencia <= 100 Then
                    Console.WriteLine("El estudiante " & nombre & " obtuvo una calificacion  de" & Nota & "  un promedio de asistencia " & asistencia & "% por lo tanto ha sido reprobado ")
                    Console.ReadLine()
                End If
                Console.ReadLine()
            ElseIf opcion = 3 Then
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
                        Console.WriteLine("Si sus palnes son de salida pongase algo comodo y no olvide su paraguas ")

                End Select
                Console.ReadLine()
            ElseIf opcion = 4 Then
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
            ElseIf opcion = 5 Then
                Dim salida = 1
                Dim menu = 0
                While menu <= 3
                    Console.WriteLine("Elija un grupo y luego se le dara la opcion de escoger  un personaje favorito")
                    Console.WriteLine("")
                    Console.WriteLine("1.Deportistas")
                    Console.WriteLine("2.Generos musicales")
                    Console.WriteLine("3.Personajes")
                    Console.WriteLine("")
                    Dim sum As Integer = Console.ReadLine
                    If sum = 1 Then

                        Dim Deportistas = "deportistas"
                        Console.WriteLine("1. Paulo Dybala")
                        Console.WriteLine("2. Julian Draxler")
                        Console.WriteLine("3. Kilyam Mbappe")
                        Console.WriteLine("4. Eden Hazard")
                        Console.WriteLine("Ingrese su Deportista de su pereferencia o su Deportista Favorito")
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
                        Console.WriteLine("su grupo favorito es " & sum & " y su personaje favorito es " & favorito)
                        Console.ReadLine()

                    ElseIf sum = 2 Then
                        Console.WriteLine("Ingrese su genero de musica Favorito")
                        Dim personaje = "Generos Musicales"
                        Console.WriteLine("1.Electronica")
                        Console.WriteLine("2. Romantica")
                        Console.WriteLine("3. Clasicos Ingles")
                        Console.WriteLine("4. Regueton")
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
                        End If

                        Console.WriteLine("su grupo favorito es " & genero & " y su personaje favorito es " & genero)
                        Console.ReadLine()
                    ElseIf sum = 3 Then
                        Console.WriteLine("Ingrese su serie Favorita ")
                        Dim serie = "Series"
                        Console.WriteLine("1. Austin y Ally")
                        Console.WriteLine("2. Dragon ball Z")
                        Console.WriteLine("3. Los caballeros del Zodiaco")
                        Dim series = Console.ReadLine()
                        If series = 1 Then
                            series = "Austin y Ally"
                        ElseIf series = 2 Then
                            series = "Dragon ball z"
                        ElseIf series = 3 Then
                            series = " Los Caballeros del Zodiaco El Lienzo perdido"
                        End If

                        Console.WriteLine("Su Serie  favorito es " & serie & " y su personaje favorito es " & series)
                        Console.ReadLine()
                    End If
                    salida = salida + 1

                End While
                Console.ReadLine()
            End If

        End While
    End Sub

End Module
