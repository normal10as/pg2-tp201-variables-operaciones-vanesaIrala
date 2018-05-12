Module ecuacion6
    '1.6. Crear un programa que resuelva la siguiente ecuación = donde a = 1, b = 5 y c=2. 
    'Mostrar el resultado obtenido.

    Sub Main()

        Dim a As Short = 1
        Dim b As Short = 5
        Dim c As Short = 2
        Dim x As Single

        x = (b ^ 2 - 4 * a * c) / (2 * a)
        'Mostrar informcion
        Console.WriteLine("El resultado es: " & x)
        Console.ReadKey()

    End Sub

End Module
