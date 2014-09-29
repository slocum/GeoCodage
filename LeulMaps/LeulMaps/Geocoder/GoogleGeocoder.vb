Imports System.IO
Imports System.Net
Imports System.Web
Imports System.Xml.XPath
Imports System.ArgumentNullException

Imports LeulOutils.Outils

Imports LeulMaps.Geocoder
Imports LeulMaps.Outils

Namespace Geocoder

    Public Class GoogleGeocoder
        Implements IGeocoder

#Region "Enumération"

        Private Enum eStatut
            Ok = 0
            ZeroResults = 1
            OverQueryLimit = 2
            RequestDenied = 3
            InvalidRequest = 5
            Erreur = 6
        End Enum

        Public Enum eMapType
            roadmap = 0
            satellite = 1
            terrain = 2
            hybrid = 3
        End Enum

#End Region

#Region "Constantes"

        Private Const SERVICE_URL_GEOCODE As String = "https://maps.googleapis.com/maps/api/geocode/xml?address={0}&region=fr&sensor=false"
        Private Const SERVICE_URL_GEOLOCALISATION As String = "https://maps.googleapis.com/maps/api/staticmap?center={0}&" + _
                                                                                                             "zoom={1}&" + _
                                                                                                             "size={2}&" + _
                                                                                                             "maptype={3}&" + _
                                                                                                             "markers=color:{4}|label:{5}|{6},{7}&" + _
                                                                                                             "sensor=false&" + _
                                                                                                             "visual_refresh=false&" + _
                                                                                                             "language=fr&" + _
                                                                                                             "region=fr"

#End Region

#Region "Interface"

        Public Function Geocode(ByVal pAdresses As String) As Coordonnees Implements IGeocoder.Geocode

            If (String.IsNullOrEmpty(pAdresses)) Then Throw New ArgumentNullException("Adresse incorecte.")

            Dim request As HttpWebRequest = BuildWebRequest(Uri.EscapeDataString(pAdresses))

            Dim xdoc As XPathDocument = LoadXmlResponse(request.GetResponse())
            Dim nav As XPathNavigator = xdoc.CreateNavigator()

            Return getCoordonneesAdresse(nav.Select("/GeocodeResponse/result"))

        End Function

        ''' <summary>
        ''' Création d'une Static Maps API v2 Google
        ''' </summary>
        ''' <param name="padresse">Adresse postale de la carte à afficher</param>
        ''' <returns>Adresse URI de la carte à afficher</returns>
        ''' <remarks>
        ''' Créée le 05/11/2013 par : JF Enond
        ''' </remarks>
        Public Function GeoLocalisation(ByVal padresse As String, ByVal pZoom As Byte, ByVal pLargImage As Integer, ByVal pHautImage As Integer, ByVal pMapType As String) As Uri
            '25000 requêtes par jour et par IP sont autorisées
            'La longueur de la reqête ne doit pas dépasser 2048 caratectères

            'https://developers.google.com/maps/documentation/staticmaps/?hl=fr#Zoomlevels

            If (String.IsNullOrEmpty(padresse.Trim)) Then Throw New Exception("Adresse postale obligatoire.")

            Dim oCoordonnees As New Coordonnees()
            oCoordonnees = Me.Geocode(padresse)

            Dim centreeSur As String = oCoordonnees.Latitude.ToString() + "," + oCoordonnees.Longitude.ToString()
            Dim dimension As String = pLargImage.ToString() + "x" + pHautImage.ToString()

            Dim adresseURL As String = String.Format(SERVICE_URL_GEOLOCALISATION, centreeSur, pZoom.ToString(), dimension, pMapType, "red", "I", oCoordonnees.Latitude.ToString(), oCoordonnees.Longitude.ToString())

            If (adresseURL.Length > 2048) Then Throw New Exception("Trop de caractères dans la requête.")

            Return New Uri(adresseURL)

        End Function



#End Region

#Region "Implémentation"

        Private Function BuildWebRequest(ByVal pValue As String) As HttpWebRequest

            Dim url As String = String.Format(SERVICE_URL_GEOCODE, pValue)

            Dim req As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            req.Method = "GET"

            Return req

        End Function

        Private Function getCoordonneesAdresse(ByVal pNoeud As XPathNodeIterator) As Coordonnees

            Dim latitude As Double = 0
            Dim longitude As Double = 0

            While pNoeud.MoveNext

                Dim navNodeCurrent As XPathNavigator = pNoeud.Current

                latitude = CDbl(navNodeCurrent.Evaluate("number(geometry/location/lat)"))
                longitude = CDbl(navNodeCurrent.Evaluate("number(geometry/location/lng)"))

            End While

            Return New Coordonnees(latitude, longitude)

        End Function


        Private Function LoadXmlResponse(ByVal response As WebResponse) As XPathDocument

            Using stream As Stream = response.GetResponseStream()

                Dim doc As XPathDocument = New XPathDocument(stream)

                Return doc

            End Using

        End Function

        'private GoogleStatus EvaluateStatus(string status)
        '{
        '	switch (status)
        '	{
        '		case "OK": return GoogleStatus.Ok;
        '		case "ZERO_RESULTS": return GoogleStatus.ZeroResults;
        '		case "OVER_QUERY_LIMIT": return GoogleStatus.OverQueryLimit;
        '		case "REQUEST_DENIED": return GoogleStatus.RequestDenied;
        '		case "INVALID_REQUEST": return GoogleStatus.InvalidRequest;
        '		default: return GoogleStatus.Error;
        '	}
        '}

#End Region

    End Class

End Namespace
