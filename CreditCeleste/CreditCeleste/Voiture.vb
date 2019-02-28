Public Class Voiture

    Private monNomVehicule As String
    Private monAgeVehicule As String
    Private monAncienNomVehicule As String

    Private monDate1ereImmatriculation As String
    Private monAnneeModele As Integer
    Private monNumImmat As String
    Private monNumeroSerie As String
    Private monPuisChevaux As Integer


    Sub New()

    End Sub

    Sub New(ByVal NomVehicule As String, ByVal AgeVehicule As String, ByVal AncienVehicule As String)
        monNomVehicule = NomVehicule
        monAgeVehicule = AgeVehicule
        monAncienNomVehicule = AncienVehicule

    End Sub

    Sub setVoiture(ByVal NomVehicule As String, ByVal AncienVehicule As String, ByVal AgeVehicule As String)
        monNomVehicule = NomVehicule
        monAgeVehicule = AgeVehicule
        monAncienNomVehicule = AncienVehicule

    End Sub

    Sub New(ByVal NouveauNomVehicule As String)
        monNomVehicule = NouveauNomVehicule
    End Sub

    Sub setNomVehicule(ByVal NouveauNomVehicule As String)
        monNomVehicule = NouveauNomVehicule
    End Sub

    Function getNomVehicule() As String
        Return (monNomVehicule)
    End Function

    Public Sub setAge(ByVal age As String)
        monAgeVehicule = age
    End Sub

    Function getAge() As String
        Return (monAgeVehicule)
    End Function

    Public Sub setbien(ByVal d1èreImmat As String, ByVal anneMod As Integer, ByVal numImmat As String, ByVal numSerie As String, ByVal puiss As Integer)
        monDate1ereImmatriculation = d1èreImmat
        monAnneeModele = anneMod
        monNumImmat = numImmat
        monNumeroSerie = numSerie
        monPuisChevaux = puiss
    End Sub

    Public Sub setVoiture(ByVal d1èreImmat As String, ByVal anneMod As Integer, ByVal numImmat As String, ByVal numSerie As String, ByVal puiss As Integer)
        monDate1ereImmatriculation = d1èreImmat
        monAnneeModele = anneMod
        monNumImmat = numImmat
        monNumeroSerie = numSerie
        monPuisChevaux = puiss
    End Sub

    Function getAncienNomVehicule()
        Return (monAncienNomVehicule)
    End Function

    Function getDate1ereImmat()
        Return (monDate1ereImmatriculation)
    End Function

    Function getAnneeModele()
        Return (monAnneeModele)
    End Function

    Function getNumImmat()
        Return (monNumImmat)
    End Function

    Function getNumSerie()
        Return (monNumeroSerie)
    End Function

    Function getPuisChevaux()
        Return (monPuisChevaux)
    End Function

End Class
