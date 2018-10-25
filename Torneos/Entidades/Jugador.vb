Public Class Jugador
    Inherits Persona
    Private _numero As UShort
    Private _equipo As Equipo

    Sub New(nombre As String, fechaNacimiento As Date, numero As UShort)
        MyBase.New(nombre, fechaNacimiento)
        Me.Numero = numero
    End Sub

    Public Property Numero As UShort
        Get
            Return _numero
        End Get
        Set(value As UShort)
            If value > 0 And value < 100 Then
                _numero = value
            End If
        End Set
    End Property

    Public Property Equipo As Equipo
        Get
            Return _equipo
        End Get
        Set(value As Equipo)
            value.comprarJugador(Me)
            _equipo = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Nombre & " (" & Numero & ")"
    End Function
End Class
