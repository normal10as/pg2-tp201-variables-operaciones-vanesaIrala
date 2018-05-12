Module día_hora14
    '1.14.  Crear un programa que muestre en líneas diferentes con sus correspondientes títulos los 
    'siguientes valores en el momento de la ejecución: día del año, mes, hora y minuto 
    Sub Main()
        'Declaracion de variables y asignacion
        Dim fecha As Date
        fecha = Now
        'Mostrar dias del año, mes, hora y minuto
        Console.WriteLine("Dias del año: " & fecha.DayOfYear())
        Console.WriteLine("Mes: " & fecha.Month())
        Console.WriteLine("Hora: " & fecha.Hour())
        Console.WriteLine("Minuto: " & fecha.Minute())
        Console.ReadKey()
    End Sub
End Module
