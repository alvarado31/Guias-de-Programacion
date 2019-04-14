Module Module2
    Sub Personajes()
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
                Console.WriteLine("su grupo favorito es " & Deportistas & " y su personaje favorito es " & favorito)
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

                Console.WriteLine("su grupo favorito es " & sum & " y su personaje favorito es " & genero)
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




    End Sub
End Module
