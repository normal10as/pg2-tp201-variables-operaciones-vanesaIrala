Module variables3
    '1.3. Asignarle valores no esperados al tipo de datos y observar los mensajes del IDE. Luego corregir 
    'asignándole un valor acorde al tipo de dato.

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
        Console.WriteLine("Datos Personales3")
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
