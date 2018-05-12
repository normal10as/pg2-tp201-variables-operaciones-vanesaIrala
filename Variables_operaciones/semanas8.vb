Module semanas8
    '1.8. Crear un módulo llamado semanas y en el declarar las siguientes constantes: días del año, días 
    'laborables y días de la semana. Informar cuantas semanas tiene el año y cuantas semanas son 
    'laborables.
    Sub Main()
        Const dias_anio As Short = 365
        Const dia_sem As Short = 7
        Const dia_lab As Short = 5
        Dim semanas As Short
        Dim semanas_lab As Short

        semanas = CInt(dias_anio / dia_sem)
        semanas_lab = CInt(semanas / dia_lab)
        Console.WriteLine("El año tiene {0} semanas", semanas)
        Console.WriteLine("De las cuales, {0} semanas son laborables", semanas_lab)
        Console.ReadKey()

    End Sub
End Module
