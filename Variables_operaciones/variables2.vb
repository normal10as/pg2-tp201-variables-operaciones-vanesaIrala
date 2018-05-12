Module variables2
    '1.2. Cambiar el ámbito de las variables a:
    'el nombre de la persona para que sea accesible en cualquier parte de la solución
    'el tipo y número documento y fecha de nacimiento para que sean accesibles solamente al 
    'proyecto “Hola Mundo”
    'Edad es local.
    'El resto que sean solo accesibles en todo el módulo.

    Public nombre As String = "Vanesa"
    Friend tipodni As String = "DNI"
    Friend dni As Integer = 31361145
    Friend fecha_nac As Date = #02-13-1984#
    Private Localidad As String = "Posadas"
    Private altura As Single = 1.6
    Private est_civ As String = "Soltera"
    Private argentina As String = "Si"

    Sub Main()
        'Declaracion de variables y asignacion
        Dim edad As Byte = 33

        'Mostrar informacion
        Console.WriteLine("Datos Personales2")
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
