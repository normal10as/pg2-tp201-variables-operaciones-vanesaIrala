Module valor12
    Sub Main()
        'Declaracion de variables
        Dim real As Double
        'Ingresar datos
        Console.Write("Ingrese un numero real: ")
        real = Console.ReadLine()
        'Mostrar informacion
        Console.WriteLine()
        Console.WriteLine("Valor aproximado por exceso: " & Math.Ceiling(real))
        Console.WriteLine("Valor aproximado por defecto: " & Math.Floor(real))
        Console.WriteLine("Valor redondeado: " & Math.Round(real))
        Console.ReadKey()
    End Sub
End Module
