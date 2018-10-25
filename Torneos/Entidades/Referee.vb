Public Class Referee
    Inherits Persona
    Private _internacional As Boolean

    Sub New(nombre As String, fechaNacimiento As Date, internacional As Boolean)
        MyBase.New(nombre, fechaNacimiento)
        Me.Internacional = internacional
    End Sub

    Public Property Internacional As Boolean
        Get
            Return _internacional
        End Get
        Set(value As Boolean)
            _internacional = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return If(_internacional, Nombre & "( I )", Nombre)
    End Function

End Class
