Module Module1

    Sub Main()
        Dim saludo As Holamundo = New Holamundo()
        saludo.saludar()
    End Sub


    Sub Main()
        Dim carro1 As carro = New carro("hilux", "4x4", "2019", "blanco")
        Dim carro2 As carro = New carro("audi", "r8", "20117", "megro")
        Dim carro3 As carro = New carro("yamaha", "r3", "2015", "azul con blanca")

        carro1.mostrar()
        Console.WriteLine("************************************")
        carro2.mostrar()
        Console.WriteLine("************************************")
        carro3.mostrar()
        Console.WriteLine("************************************")
        Console.ReadLine()

    End Sub
    Sub Main()
        Dim carro1 As vehiculo_b = New vehiculo_b
        carro1._marca = "hilux"
        carro1._modelo = "4x4"
        carro1._anho = "2019"
        carro1._color = "blanco"
        Dim carro2 As vehiculo_b = New vehiculo_b
        carro2._marca = "audi"
        carro2._modelo = "r8"
        carro2._anho = "20117"
        carro2._color = "NEGRO"
        Dim carro3 As vehiculo_b = New vehiculo_b
        carro3._marca = "YAMAHA"
        carro3._modelo = "r3"
        carro3._anho = "2017"
        carro3._color = "NEGRO CON BLANCA"

        carro1.devolverdatos()
        Console.WriteLine("********************************************")
        carro2.devolverdatos()
        Console.WriteLine("********************************************")
        carro3.devolverdatos()
        Console.WriteLine("********************************************")
        Console.ReadLine()
    End Sub
    Sub Main()
        Dim cuenta As Class1 = New Class1(10, 54)
        cuenta.depositar(534)
        cuenta.retirar(10)
        cuenta.mostrar()

    End Sub
    Sub Main()

        Console.WriteLine("calculadora selecione lo que quiere hacer")
        Console.WriteLine("1.sumar")
        Console.WriteLine("2.restar")
        Console.WriteLine("3.multiplicar")
        Console.WriteLine("4.dividir")
        Console.WriteLine("presione cualquier otro numero para salir")
        Dim respuesta As Integer = Console.ReadLine
        Console.WriteLine()
        While respuesta < 4 And respuesta > 0

            Select Case respuesta
                Case 1
                    Dim sumarr As calculadora = New calculadora
                    sumarr.suma()
                    Continue While
                Case 2
                    Dim restarr As calculadora = New calculadora
                    restarr.restar()
                Case 3
                    Dim multi As calculadora = New calculadora
                    multi.multiplicacion()
                Case 4
                    Dim div As calculadora = New calculadora
                    div.divicion()
            End Select
        End While
    End Sub
End Module
