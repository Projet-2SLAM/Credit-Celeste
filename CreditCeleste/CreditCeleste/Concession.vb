Public Class Concession

    Private monNomConcession As String
    Private monAdresseConcession As String

    Public lesVendeurs As New List(Of Vendeur) 'Une collection fortement typée
    'A METTRE EN PRIVE AVEC ACCESSEURS (get & set)

    Sub New()

    End Sub

    Sub New(ByVal nomConcession As String, ByVal adresseConcession As String)

        monNomConcession = nomConcession
        monAdresseConcession = adresseConcession

    End Sub

    Sub setConcession(ByVal nomConcession As String, ByVal adresseConcession As String)

        monNomConcession = nomConcession
        monAdresseConcession = adresseConcession

    End Sub

End Class
