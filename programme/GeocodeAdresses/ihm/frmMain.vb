Imports LeulMaps.Geocoder
Imports LeulMaps.Outils

Imports LeulOutils.Outils.LeulOutils

Public Class frmMain

    Private Sub chargerCboMapType()

        cboMapType.Items.Add(LeulMaps.Geocoder.GoogleGeocoder.eMapType.hybrid.ToString())
        cboMapType.Items.Add(LeulMaps.Geocoder.GoogleGeocoder.eMapType.roadmap.ToString())
        cboMapType.Items.Add(LeulMaps.Geocoder.GoogleGeocoder.eMapType.satellite.ToString())
        cboMapType.Items.Add(LeulMaps.Geocoder.GoogleGeocoder.eMapType.terrain.ToString())

        cboMapType.Text = cboMapType.Items(1)

    End Sub

    Private Sub cmdQuitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuitter.Click

        oAppLeul.Arret()

    End Sub

    Private Sub cmdChercher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChercher.Click

        Dim oGeocorder As New GoogleGeocoder()

        Dim oCoordonnees As New Coordonnees()

        Try

            oCoordonnees = oGeocorder.Geocode(txtAdresse.Text)

            lblLongitude.Text = oCoordonnees.Longitude.ToString()
            lblLatitude.Text = oCoordonnees.Latitude.ToString()

            wbrCarte.Url = oGeocorder.GeoLocalisation(txtAdresse.Text.Trim, tkbZoom.Value, 515, 520, cboMapType.Text)

        Catch ex As Exception

            msgErreur(ex, True)

        End Try

    End Sub

    Private Sub tkbZoom_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tkbZoom.Scroll

        Dim oGeocorder As New GoogleGeocoder()
        wbrCarte.Url = oGeocorder.GeoLocalisation(txtAdresse.Text.Trim, tkbZoom.Value, 515, 520, cboMapType.Text)

    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        chargerCboMapType()

    End Sub

End Class
