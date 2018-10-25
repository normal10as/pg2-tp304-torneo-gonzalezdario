Public Class Partido
    Private _jornada As Byte
    Private _equipoLocal As Equipo
    Private _equipoVisitante As Equipo
    Private _golesLocal As Byte
    Private _golesVisitante As Byte
    Private _minutosGolesLocal As List(Of Byte)
    Private _minutosGolesVisitante As List(Of Byte)
    Private _finalizado As Boolean

    Sub New(jornada As Byte, equipoLocal As Equipo, equipoVisitante As Equipo)
        Me.Jornada = jornada
        Me.EquipoLocal = equipoLocal
        Me.EquipoVisitante = equipoVisitante
        _minutosGolesLocal = New List(Of Byte)
        _minutosGolesVisitante = New List(Of Byte)
        _finalizado = False
    End Sub

    Sub New(jornada As Byte, equipoLocal As Equipo, equipoVisitante As Equipo, golesLocal As Byte, golesVisitante As Byte)
        Me.Jornada = jornada
        Me.EquipoLocal = equipoLocal
        Me.EquipoVisitante = equipoVisitante
        _golesLocal = golesLocal
        _golesVisitante = golesVisitante
        Finalizado()
    End Sub

    Public Property Jornada As Byte
        Get
            Return _jornada
        End Get
        Set(value As Byte)
            _jornada = value
        End Set
    End Property

    Public Property EquipoLocal As Equipo
        Get
            Return _equipoLocal
        End Get
        Set(value As Equipo)
            _equipoLocal = value
        End Set
    End Property

    Public Property EquipoVisitante As Equipo
        Get
            Return _equipoVisitante
        End Get
        Set(value As Equipo)
            _equipoVisitante = value
        End Set
    End Property

    Public ReadOnly Property GolesLocal As Byte
        Get
            Return _golesLocal
        End Get
    End Property

    Public ReadOnly Property GolesVisitante As Byte
        Get
            Return _golesVisitante
        End Get
    End Property

    Public ReadOnly Property MinutosGolesLocal As List(Of Byte)
        Get
            Return _minutosGolesLocal
        End Get
    End Property

    Public ReadOnly Property MinutosGolesVisitante As List(Of Byte)
        Get
            Return _minutosGolesVisitante
        End Get
    End Property

    Public Sub NuevoGolLocal(minuto As Byte)
        If Not _finalizado Then
            _golesLocal += 1
            _minutosGolesLocal.Add(minuto)
        End If
    End Sub

    Public Sub NuevoGolVisitante(minutos As Byte)
        If Not _finalizado Then
            _golesVisitante += 1
            _minutosGolesVisitante.Add(minutos)
        End If
    End Sub

    Public Sub Finalizado()
        _finalizado = True
    End Sub

    Public Overrides Function ToString() As String
        Return EquipoLocal.Nombre & " ( " & GolesLocal & " )  " & EquipoVisitante.Nombre & " ( " & GolesVisitante & " )"
    End Function
End Class
