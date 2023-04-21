Module Module1

    Sub Main()

        Dim carro1 As Carro = New Carro()
        Console.WriteLine("Nombre: " & carro1.Modelocarro())
        Console.WriteLine("Edad: " & carro1.ObtenerColor())
        Dim carro2 As Carro = New Carro("Chevrolet", "Gris")
        Console.WriteLine("Nombre: " & carro2.Modelocarro())
        Console.WriteLine("Edad: " & carro2.ObtenerColor())
        Console.WriteLine(carro2.Modelocarro("Hola el  modelo es"))
        Console.ReadKey()


    End Sub
    Public Class Carro
        Private marca As String
        Private color As String

        Public Sub New()
            Me.marca = "SUZUKI"
            Me.color = "NEGRO"
        End Sub

        Public Sub New(ByVal marcaa As String, ByVal colorr As String)
            Me.marca = marcaa
            Me.color = colorr
        End Sub

        Public Function Modelocarro() As String
            Return Me.marca
        End Function

        Public Function Modelocarro(ByVal saludo As String) As String
            Return saludo & " " & Me.marca & " " & Me.color
        End Function

        Public Function ObtenerColor() As String
            Return Me.color
        End Function

        Protected Overrides Sub Finalize()
            Console.WriteLine("Objeto Persona destruido.")
        End Sub
    End Class


End Module
