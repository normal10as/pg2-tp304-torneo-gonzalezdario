Public MustInherit Class Persona
    Private _nombre As String
    Private _fechaNacimiento As Date

    Sub New(nombre As String, fechaNacimiento As Date)
        Me.Nombre = nombre
        Me.FechaNacimiento = fechaNacimiento
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

    Public Property FechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            _fechaNacimiento = value
        End Set
    End Property

    Public ReadOnly Property Edad As UShort
        Get
            Return CalcularEdad(FechaNacimiento)
        End Get
    End Property

    Public Function CalcularEdad(fechaNacimiento As Date) As UShort
        Return DateDiff(DateInterval.Year, fechaNacimiento, Now)
    End Function

    Public Overrides Function ToString() As String
        Return Nombre
    End Function
End Class
