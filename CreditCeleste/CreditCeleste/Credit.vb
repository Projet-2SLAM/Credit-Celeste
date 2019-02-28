Public Class Credit


    Private montantAFinancier As Double
    Private taux As Double
    Private duree As Integer
    Private mensualites As Double
    Private nomClient As String

    Public Sub New()
    End Sub

    Public Sub New(c, t, n)
        montantAFinancier = c
        taux = t
        duree = n
    End Sub
    Public Function GetTaux()
        Return taux
    End Function
    Public Function GetDuree()
        Return duree
    End Function
    Public Function GetMontantInitial()
        Return montantAFinancier
    End Function
    Public Function calculMensualites()
        Dim taux As Double = GetTaux() / 100
        Dim duree As Double = GetDuree()
        Dim montantAFinancier As Double = GetMontantInitial()

        mensualites = GetMontantInitial() * taux / (1 - (1 + taux) ^ -GetDuree())
        'montantAFinancier * taux / (1 - (1 + taux) ^ -duree)
        Return mensualites
    End Function

    Public Sub setCredit(montant As Double, taux As Integer, duree As Integer)
        montantAFinancier = montant
        Me.taux = taux
        Me.duree = duree
    End Sub

    Public Sub setMontantAFinancier(montantAFinancier)
        Me.montantAFinancier = montantAFinancier
    End Sub

    Public Sub setTaux(taux)
        Me.taux = taux
    End Sub

    Public Sub setDuree(duree)
        Me.duree = duree
    End Sub

    Public Sub setMensualites(mensualites)
        Me.mensualites = mensualites
    End Sub

    Public Sub setNomClient(nomClient)
        Me.nomClient = nomClient
    End Sub

    Public Function getMensualites()
        Return mensualites
    End Function

    Public Function getNomClient()
        Return nomClient
    End Function
End Class


