Imports Entidades

Module PartidoTest
    Sub Main()
        Dim e1 As New Equipo("Astralis")
        Dim e2 As New Equipo("Navi")

        Dim partido1 As Partido

        partido1 = New Partido(1, e1, e2, 16, 6)

        Console.WriteLine(partido1.EquipoLocal)
        Console.WriteLine(partido1.EquipoVisitante)
        Console.WriteLine(partido1.ToString)

        Dim partido2 As Partido

        partido2 = New Partido(2, e1, e2)

        partido2.NuevoGolLocal(1)
        partido2.NuevoGolLocal(3)
        partido2.NuevoGolLocal(4)
        partido2.NuevoGolLocal(7)
        partido2.NuevoGolVisitante(8)
        partido2.NuevoGolVisitante(10)
        partido2.NuevoGolVisitante(13)
        partido2.NuevoGolLocal(15)
        partido2.NuevoGolVisitante(17)
        partido2.NuevoGolVisitante(20)
        partido2.NuevoGolLocal(22)
        partido2.NuevoGolLocal(24)
        partido2.NuevoGolVisitante(27)
        partido2.NuevoGolLocal(29)
        partido2.NuevoGolLocal(31)

        partido2.NuevoGolLocal(32)
        partido2.NuevoGolLocal(34)
        partido2.NuevoGolLocal(37)
        partido2.NuevoGolLocal(39)
        partido2.NuevoGolLocal(42)
        partido2.NuevoGolVisitante(44)
        partido2.NuevoGolVisitante(46)
        partido2.NuevoGolVisitante(48)
        partido2.NuevoGolLocal(50)
        partido2.NuevoGolLocal(53)

        partido2.Finalizado()

        Console.WriteLine(partido2.EquipoLocal)
        Console.WriteLine(partido2.EquipoVisitante)
        Console.WriteLine(partido2.ToString)

    End Sub
End Module
