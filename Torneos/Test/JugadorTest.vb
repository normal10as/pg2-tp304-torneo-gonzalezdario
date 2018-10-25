Imports Entidades

Module JugadorTest

    Sub Main()

        Dim jug1 As New Jugador("Gabriel 'FalleN' Toledo", #4-30-1991#, 1)

        Console.WriteLine(jug1.Nombre)
        Console.WriteLine(jug1.FechaNacimiento)
        Console.WriteLine(jug1.Edad)
    End Sub

End Module
