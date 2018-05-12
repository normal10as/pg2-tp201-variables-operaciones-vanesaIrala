Module sumar_cantidad_días16
    '1.16.Crear un programa que se ingrese una fecha y un número dados de días, Mostrar como 
    'resultado la fecha obtenida de sumar la cantidad de días a la fecha dada
    Sub Main()
        'Declaracion de variables
        Dim fecha As Date
        Dim dias As UShort
        'Ingreso de datos
        Console.Write("Ingrese fecha: ")
        fecha = Console.ReadLine()
        Console.Write("Ingrese dias: ")
        dias = Console.ReadLine()
        'Mostrar informacion
        Console.WriteLine("Fecha obtenida: " & fecha.AddDays(dias))
        Console.ReadKey()
    End Sub
End Module
