Module sumatoriaymedia7
    '1.7. Crear un programa que calcule la sumatoria y la media de cuatro números enteros ingresados 
    'por teclado. 
    Sub Main()

        Dim n1 As Short
        Dim n2 As Short
        Dim n3 As Short
        Dim n4 As Short
        Dim suma As Short


        'Ingreso de valores
        Console.WriteLine("Ingrese 4 valores enteros:")
        Console.WriteLine()
        Console.Write("Primero: ")
        n1 = Console.ReadLine()
        Console.Write("Segundo: ")
        n2 = Console.ReadLine()
        Console.Write("Tercero: ")
        n3 = Console.ReadLine()
        Console.Write("Cuarto: ")
        n4 = Console.ReadLine()
        'Calcular y mostrar informacion
        Console.WriteLine()
        suma = n1 + n2 + n3 + n4
        Console.WriteLine("La sumatoria es: " & suma)
        Console.WriteLine("La media es: " & suma / 4)
        Console.ReadKey()
    End Sub
End Module
