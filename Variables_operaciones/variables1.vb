Module variables1

    '1.1. Crear un módulo llamado “variables” en el proyecto “Hola Mundo”. Declarar variables de la 
    'lista adjunta como locales (Dim) utilizando tipos de datos adecuados para cada información y 
    'usando nombres que respeten las reglas de sintaxis, asignarles valores programáticamente y 
    'luego mostrar por consola la leyenda que representa el dato seguido del valor del dato.
    'nombre de una persona 
    'tipo de documento 
    'número de documento 
    'localidad
    'fecha de nacimiento
    'edad
    'altura corporal 
    'estado civil
    'si es argentino

    Sub Main()
        'Declaracion de variables y asignacion
        Dim nombre As String = "Vanesa"
        Dim tipodni As String = "DNI"
        Dim dni As Integer = 31361145
        Dim Localidad As String = "Posadas"
        Dim fecha_nac As Date = #02-13-1984#
        Dim edad As Byte = 34
        Dim altura As Single = 1.6
        Dim est_civ As String = "Soltera"
        Dim argentina As String = "Si"
        'Mostrar informacion
        Console.WriteLine("Datos Personales")
        Console.WriteLine("Nombre: " & nombre)
        Console.WriteLine("Tipo: " & tipodni)
        Console.WriteLine("Numero: " & dni)
        Console.WriteLine("Localidad: " & Localidad)
        Console.WriteLine("Fecha de Nac.: " & fecha_nac)
        Console.WriteLine("Edad: " & edad)
        Console.WriteLine("Altura: " & altura)
        Console.WriteLine("Estado Civil: " & est_civ)
        Console.WriteLine("Argentina: " & argentina)
        Console.ReadKey()

    End Sub

End Module
