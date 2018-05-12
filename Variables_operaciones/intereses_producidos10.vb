Module intereses_producidos10
    '1.10.  Realizar un programa que dé como resultado los intereses producidos y el capital 
    'acumulado de un monto m invertido a un interés anual r durante t días. La fórmula utilizada es 
    'I= m.r.t / 360.100. donde I es el interés producido. Ingresar por teclado el monto, el interés y el tiemponn. 


    Sub Main()
        'Declaracion de variables
        Dim m_monto As Single
        Dim r_interes As Single
        Dim t_dias As UShort
        Dim i_interes_prod As Single
        'Ingrear datos
        Console.WriteLine("Ingrese Datos")
        Console.WriteLine()
        Console.Write("Monto: ")
        m_monto = Console.ReadLine()
        Console.Write("Interes: ")
        r_interes = Console.ReadLine()
        Console.Write("Dias: ")
        t_dias = Console.ReadLine()
        'Calculo
        i_interes_prod = (m_monto * r_interes * t_dias) / (360 * 100)
        'Mostrar informacion
        Console.WriteLine()
        Console.WriteLine("El interes producido es: " & i_interes_prod)
        Console.WriteLine("El capital acumulado es: " & i_interes_prod + m_monto)
        Console.ReadKey()
    End Sub
End Module
