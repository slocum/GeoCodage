Module modMain

    Public oAppLeul As New LeulOutils.Fenetres.AppLeul(New frmMain())
    'Public oAppParametres As New metier.Parametres()

    Sub Main()
        oAppLeul.Start(True, False)

    End Sub

End Module
