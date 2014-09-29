Imports LeulMaps.Outils
Imports LeulOutils.Outils

Namespace Geocoder

    Public Interface IGeocoder

        Function Geocode(ByVal Adresses As String) As Coordonnees

    End Interface

End Namespace
