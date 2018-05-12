Module verdad9
    '1.9. Crear un programa que muestre las tablas de verdad booleanas (And, Or, Not y Xor)
    Sub Main()
        'Declaracion de variables y aasignacion
        Dim verdadero As Boolean = True
        Dim falso As Boolean = False
        'Comparar y mostrar informacion
        Console.WriteLine("Tablas de verdad booleanas")
        Console.WriteLine()
        Console.WriteLine("{0} And {1} = " & (verdadero And verdadero), verdadero, verdadero)
        Console.WriteLine("{0} And {1} = " & (verdadero And falso), verdadero, falso)
        Console.WriteLine("{0} And {1} = " & (falso And verdadero), falso, verdadero)
        Console.WriteLine("{0} And {1} = " & (falso And falso), falso, falso)
        Console.WriteLine()
        Console.WriteLine("{0} Or {1} = " & (verdadero Or verdadero), verdadero, verdadero)
        Console.WriteLine("{0} Or {1} = " & (verdadero Or falso), verdadero, falso)
        Console.WriteLine("{0} Or {1} = " & (falso Or verdadero), falso, verdadero)
        Console.WriteLine("{0} Or {1} = " & (falso Or falso), falso, falso)
        Console.WriteLine()
        Console.WriteLine("{0} Xor {1} = " & (verdadero Xor verdadero), verdadero, verdadero)
        Console.WriteLine("{0} Xor {1} = " & (verdadero Xor falso), verdadero, falso)
        Console.WriteLine("{0} Xor {1} = " & (falso Xor verdadero), falso, verdadero)
        Console.WriteLine("{0} Xor {1} = " & (falso Xor falso), falso, falso)
        Console.WriteLine()
        Console.WriteLine("Not {0} = " & (Not verdadero), verdadero)
        Console.WriteLine("Not {0} = " & (Not falso), falso)
        Console.ReadKey()
    End Sub
End Module
