Public Class Holamundo
    Public Subsaludar()
    Sub saludar()
        Console.WriteLine("hola mundo")
        Console.ReadLine()
    End Sub
End Class

Public Class carro
    Private marca As String
    Private modelo As String
    Private anho As String
    Private color As String

    Public Sub New(marca, modelo, anho, color)
        Me.marca = marca
        Me.modelo = modelo
        Me.anho = anho
        Me.color = color
    End Sub

    Public Sub mostrar()
        Console.WriteLine("Marca: " & marca)
        Console.WriteLine("Modelo: " & modelo)
        Console.WriteLine("Anho: " & anho)
        Console.WriteLine("Color: " & color)

    End Sub

End Class
Public Class vehiculo_b
    Private marca As String
    Private modelo As String
    Private anho As String
    Private color As String

    Public Property _marca() As String
        Get
            Return marca
        End Get
        Set(value As String)
            marca = value
        End Set
    End Property

    Public Property _modelo() As String
        Get
            Return modelo
        End Get
        Set(value As String)
            modelo = value
        End Set
    End Property

    Public Property _anho() As String
        Get
            Return anho
        End Get
        Set(value As String)
            anho = value
        End Set
    End Property
    Public Property _color() As String
        Get
            Return color
        End Get
        Set(value As String)
            color = value
        End Set
    End Property
    Public Sub devolverdatos()
        Console.WriteLine("marca " & marca)
        Console.WriteLine("modelo " & modelo)
        Console.WriteLine("anho " & anho)
        Console.WriteLine("color " & color)
    End Sub
End Class

Public Class Class1
    Private numcuenta As Integer
    Private balance As Double
    Public Sub New(numcuenta, balance)
        Me.numcuenta = numcuenta
        Me.balance = balance

    End Sub
    Public Sub depositar(total As Double)
        balance = balance + total
    End Sub

    Public Sub retirar(total As Double)
        balance = balance - total
    End Sub

    Public Sub mostrar()
        Console.WriteLine("mostrar balance" & balance)
        Console.ReadLine()
    End Sub
End Class
Public Class calculadora
    Public Function suma()
        Console.WriteLine("ingrese el primer numero")
        Dim num1 As Double = Console.ReadLine()
        Console.WriteLine()
        Console.WriteLine("ingrese el segundo numero numero")
        Dim num2 As Double = Console.ReadLine()
        Dim sumar As Double = num1 + num2
        Console.WriteLine("la suma es " & sumar)
    End Function

    Public Function restar()
        Console.WriteLine("ingrese el primer numero")
        Dim num1 As Double = Console.ReadLine()
        Console.WriteLine()
        Console.WriteLine("ingrese el segundo numero numero")
        Dim num2 As Double = Console.ReadLine()
        Dim sumar As Double = num1 - num2
        Console.WriteLine("la resta es " & sumar)
    End Function

    Public Function multiplicacion()
        Console.WriteLine("ingrese el primer numero")
        Dim num1 As Double = Console.ReadLine()
        Console.WriteLine()
        Console.WriteLine("ingrese el segundo numero numero")
        Dim num2 As Double = Console.ReadLine()
        Dim sumar As Double = num1 * num2
        Console.WriteLine("la multiplicacion es " & sumar)
    End Function

    Public Function divicion()
        Console.WriteLine("ingrese el primer numero")
        Dim num1 As Double = Console.ReadLine()
        Console.WriteLine()
        Console.WriteLine("ingrese el segundo numero numero")
        Dim num2 As Double = Console.ReadLine()
        Dim sumar As Double = num1 / num2
        Console.WriteLine("la divicion es " & sumar)
    End Function

End Class

