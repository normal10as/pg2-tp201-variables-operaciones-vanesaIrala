Module aritmetica5
    '1.5. Crear un módulo llamado aritmética que declare y asigne dos valores enteros y dos valores de
    'punto flotante. Luego demostrar las operaciones aritméticas básicas mezclando los tipos de 
    'datos utilizados y mostrar los resultados por consola previo un mensaje adecuado. Por ejemplo: 
    'sumar entero con entero, entero con punto flotante y punto flotante con punto flotante.

    Sub Main()
        Dim entero1 As Short = 5
        Dim entero2 As Short = 2
        Dim pflotante1 As Single = 1.5
        Dim pflotante2 As Single = 2.4

        Console.WriteLine("Operaciones Aritmeticas")
        Console.WriteLine()
        Console.WriteLine("Suma:")
        Console.WriteLine("{0} + {1} = " & entero1 + entero2, entero1, entero2)
        Console.WriteLine("{0} + {1} = " & entero1 + pflotante2, entero1, pflotante2)
        Console.WriteLine("{0} + {1} = " & pflotante1 + pflotante2, pflotante1, pflotante2)
        Console.WriteLine()
        Console.WriteLine("Resta:")
        Console.WriteLine("{0} - {1} = " & entero1 - entero2, entero1, entero2)
        Console.WriteLine("{0} - {1} = " & entero1 - pflotante2, entero1, pflotante2)
        Console.WriteLine("{0} - {1} = " & pflotante1 - pflotante2, pflotante1, pflotante2)
        Console.WriteLine()
        Console.WriteLine("Multiplicacion:")
        Console.WriteLine("{0} * {1} = " & entero1 * entero2, entero1, entero2)
        Console.WriteLine("{0} * {1} = " & entero1 * entero2, entero1, entero2)
        Console.WriteLine("{0} * {1} = " & pflotante1 * pflotante2, pflotante1, pflotante2)
        Console.WriteLine()
        Console.WriteLine("Division:")
        Console.WriteLine("{0} / {1} = " & entero1 / entero2, entero1, entero2)
        Console.WriteLine("{0} / {1} = " & entero1 / entero2, entero1, entero2)
        Console.WriteLine("{0} / {1} = " & pflotante1 / entero2, pflotante1, entero2)




        Console.ReadKey()

    End Sub
End Module
