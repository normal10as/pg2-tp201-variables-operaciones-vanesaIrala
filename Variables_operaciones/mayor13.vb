Module mayor13
    Sub Main()
        '1.13.  Elabore un programa que lea tres números y muestre el mayor.

        'Declaracion de variables
        Dim num1 As Single
        Dim num2 As Single
        Dim num3 As Single
        'Ingresar datos
        Console.WriteLine("Ingrese tres numeros")
        Console.Write("Numero 1: ")
        num1 = Console.ReadLine()
        Console.Write("Numero 2: ")
        num2 = Console.ReadLine()
        Console.Write("Numero 3: ")
        num3 = Console.ReadLine()
        'Validar y mostrar informacion
        Console.WriteLine()
        Console.WriteLine("El mayor es: " & Math.Max(Math.Max(num1, num2), num3))
        Console.ReadKey()
    End Sub

End Module
