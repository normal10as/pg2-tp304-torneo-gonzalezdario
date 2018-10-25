Public Class Equipo
    Private _nombre As String
    Private _jugadores As List(Of Jugador)

    Sub New(nombre As String)
        Me.Nombre = nombre
        _jugadores = New List(Of Jugador)
    End Sub

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value.Length > 0 And value.Length <= 30 Then
                _nombre = value
            End If
        End Set
    End Property

    Public Sub comprarJugador(jugador As Jugador)
        jugador.Equipo = Me
        _jugadores.Add(jugador)
    End Sub

    Public Function getAllJugadores() As List(Of Jugador)
        Return _jugadores
    End Function

    Public Sub venderJugador(jugador As Jugador, EquipoDestino As Equipo, Equipo As Equipo)

    End Sub

    Public Sub liberarJugador(jugador As Jugador)
        'jugador.Equipo = Nothing
        _jugadores.Remove(jugador)
    End Sub

    Public Overrides Function ToString() As String
        Return Nombre
    End Function

End Class
