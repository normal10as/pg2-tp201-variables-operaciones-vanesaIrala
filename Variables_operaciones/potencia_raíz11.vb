Module potencia_raíz11
    Sub Main()
        ' 1.11.  Ingresar un número por teclado y mostrar su valor absoluto, el resultado de elevarlo a la 
        'décima potencia y su raíz cuadrada.
        'Declaracion de variables
        Dim num As Single
        'Ingrear datos
        Console.Write("Ingrese un Numero: ")
        num = Console.ReadLine()
        Console.WriteLine()
        'Calculo y mostrar informacion
        Console.WriteLine("Valor absoluto: " & Math.Abs(num))
        Console.WriteLine("Numero elevado por 10: " & Math.Pow(Math.Abs(num), 10))
        Console.WriteLine("Raiz cuadrada del numero: " & Math.Sqrt(Math.Abs(num)))
        Console.ReadKey()
    End Sub
End Module
