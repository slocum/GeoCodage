Namespace Outils

    Public Class Coordonnees

#Region "Attributs et accesseurs"

        Private _Latitude As Double
        Public ReadOnly Property Latitude() As Double
            Get
                Return _Latitude
            End Get
        End Property

        Private _Longitude As Double
        Public ReadOnly Property Longitude() As Double
            Get
                Return _Longitude
            End Get
        End Property

#End Region

#Region "Constructeurs"

        Public Sub New()

            _Latitude = 0
            _Longitude = 0

        End Sub
        Public Sub New(ByVal pLatitude As Double, ByVal pLongitude As Double)

            _Latitude = pLatitude
            _Longitude = pLongitude

        End Sub

#End Region

    End Class

End Namespace
