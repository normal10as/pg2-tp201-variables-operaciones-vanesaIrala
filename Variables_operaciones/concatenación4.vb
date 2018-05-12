Module concatenación4
    '1.4. Crear un módulo llamado concatenación y en el declarar variables para almacenar los siguientes 
    'datos: nombre de la empresa, nombre de la calle, altura de la calle y fecha de inicio de 
    'actividades. Mostrar los mismos concatenados en la salida de la consola dos veces: la primera 
    'utilizando conversión explícita y la segunda conversión implícita.

    Sub Main()
        Dim empresa As String = "Sancor"
        Dim direccion As String = "Uruguay"
        Dim altura As Single = 123
        Dim fecha_inicio As Date = #02-13-1984#
        'Convertir y mostrar informacion
        Console.WriteLine("Conversion explicita: ")
        Console.WriteLine("Empresa {0} calle {1} altura {2} fehca de inicio de actividad {3}" _
                          , empresa, direccion, CStr(altura), CStr(fecha_inicio))
        Console.WriteLine("Conversion implicita: ")
        Console.WriteLine("Empresa {0} calle {1} altura {2} fehca de inicio de actividad {3}" _
                          , empresa, direccion, altura, fecha_inicio)
        Console.ReadKey()
    End Sub
End Module
