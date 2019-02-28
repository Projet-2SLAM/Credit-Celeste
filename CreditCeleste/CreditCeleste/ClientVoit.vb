Imports csClient    ''permet de récupérer le client en C#, lien physique

Public Class ClientVoit ''Déclaration de la classe
    Inherits csClient.csClient ''Héritage; en C# ":Client"

    Private dateNaissance As String
    Private revenuAnnuel As Double
    Private profession As String
    Private nomJeuneFille As String
    Private situation As String
    Private autorisation As Boolean
    Private autorisation2 As Boolean
    Private autorisation3 As Boolean
    Private mail As String


    Public Function getDateNaissance()
        Return dateNaissance
    End Function

    Public Sub setDateNaissance(dateNaissance)
        Me.dateNaissance = dateNaissance
    End Sub

    Public Function getRevenuAnnuel()
        Return revenuAnnuel
    End Function

    Public Sub setRevenuAnnuel(revenuAnnuel)
        Me.revenuAnnuel = revenuAnnuel
    End Sub

    Public Function getProfession()
        Return profession
    End Function

    Public Sub setProfession(profession)
        Me.profession = profession
    End Sub

    Public Function getNomJeuneFille()
        Return nomJeuneFille
    End Function

    Public Sub setNomJeuneFille(nomJeuneFille)
        Me.nomJeuneFille = nomJeuneFille
    End Sub

    Public Function getSituation()
        Return situation
    End Function

    Public Sub setSituation(situation)
        Me.situation = situation
    End Sub

    Public Function getAutorisation()
        Return autorisation
    End Function

    Public Function getAutorisation2()
        Return autorisation2
    End Function

    Public Function getAutorisation3()
        Return autorisation3
    End Function

    Public Sub setAutorisations(autorisation, autorisation2, autorisation3)
        Me.autorisation = autorisation
        Me.autorisation2 = autorisation2
        Me.autorisation3 = autorisation3

    End Sub

    Public Function getMail()
        Return mail
    End Function

    Public Sub setMail(mail)
        Me.mail = mail
    End Sub


End Class
