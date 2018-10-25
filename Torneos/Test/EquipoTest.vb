Imports Entidades

Module EquipoTest
    Sub Main()
        Dim astralis As Equipo
        Dim jug1 As Jugador
        Dim jug2 As Jugador

        astralis = New Equipo("Astralis")
        jug1 = New Jugador("Nicolai 'dev1ce' Reedtz", #9-8-1995#, 1)
        jug2 = New Jugador("Andreas 'Xyp9x' Hojsleth", #9-11-1995#, 2)

        astralis.comprarJugador(jug1)
        astralis.comprarJugador(jug2)

        For Each jugador In astralis.getAllJugadores
            Console.WriteLine(jugador)
        Next

        'Console.WriteLine(jug1.ToString & " " & jug1.Equipo.Nombre)
        'Console.WriteLine(jug2.ToString & " " & jug2.Equipo.Nombre)

        astralis.liberarJugador(jug1)

        For Each jugador In astralis.getAllJugadores
            Console.WriteLine(jugador)
        Next

    End Sub
End Module
