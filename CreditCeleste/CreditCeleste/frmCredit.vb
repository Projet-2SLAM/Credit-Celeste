Imports System.Data.SqlClient

Public Class frmCredit
    Private Sub frmCredit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_CapitalInitial.Text = unCredit.GetMontantInitial
        txt_Taux.Text = unCredit.GetTaux
        txt_Duree.Text = unCredit.GetDuree
    End Sub

    Public Sub btn_Calcul_Click(sender As Object, e As EventArgs) Handles btn_Calcul.Click
        'unCredit.setCredit(Convert.ToDouble(txt_CapitalInitial.Text), Convert.ToDouble(txt_Taux.Text), Convert.ToDouble(txt_Duree.Text))
        'Dim unCredit = New Credit(Convert.ToDouble(txt_CapitalInitial.Text), Convert.ToDouble(txt_Taux.Text), Convert.ToDouble(txt_Duree.Text))
        'Dim montantDuCredit As Double
        'montantDuCredit = unCredit.calculMensualites()
        'txt_Mensualite.Text = montantDuCredit

        Dim Resultat As Double
        Resultat = (Double.Parse(txt_CapitalInitial.Text) * ((Double.Parse(txt_Taux.Text) / 100) / 12) / (1 - ((1 + ((Double.Parse(txt_Taux.Text) / 100) / 12)) ^ (-Double.Parse(txt_Duree.Text)))))
        txt_Mensualite.Text = Resultat

    End Sub

    Public Sub txt_Mensualite_TextChanged(sender As Object, e As EventArgs) Handles txt_Mensualite.TextChanged
        'Console.WriteLine(unCredit.calculMensualites())


    End Sub

    Private Sub cmd_Connexion_Click(sender As Object, e As EventArgs) Handles cmd_Connexion.Click
        ' REQUET ORIGINALE             Dim cnn As SqlConnection = New SqlConnection("Data Source=172.16.12.99;User Id = connEleveSio;password=mdpEleveSio;Initial Catalog=KREYDER-CreditCeleste")
        Dim cnn As SqlConnection = New SqlConnection("Data Source=10.129.0.59;User Id = Florian HUBER;password=Olympe16;Initial Catalog=Credit_Celeste")


        '                REQUETES ORIGINALES


        'unCredit.setMontantAFinancier(txt_CapitalInitial.Text)
        'unCredit.setTaux(txt_Taux.Text)
        'unCredit.setDuree(txt_Duree.Text)
        'unCredit.setMensualites(txt_Mensualite.Text)
        'unCredit.setNomClient(txt_ClientCredit.Text)

        'Dans la requête insert <éléments de frmCredit> au lieu d'écrire les champs txt_xxxxxx.Text déclarer des variables associées à ces mêmes champs pour simplifier la requête

        cnn.Open()

        Dim sql As String = "Insert into dbo.Client (civiliteCli, nomCli, prenomCli) VALUES ('Monsieur', 'KREYDER', 'Armand')"
        'Dim sql As String = ("Select nomCli FROM [dbo].[Client] WHERE prenomCli = 'Florian'")
        'Dim sql As String = "Insert into dbo.Credit (montantInitial,duree,mensualites,taux) VALUES (" & Str(txt_CapitalInitial.Text) & " , " & Str(txt_Duree.Text) & " , " & Str(txt_Mensualite.Text) & " , " & Str(txt_Taux.Text) & ")"

        'Dim sql As String = "Insert into [dbo].[CREDIT](MontantFinance, NombreMensualites, MontantMensualites, TauxAnnuel, ClientCredit) VALUES (" & txt_CapitalInitial.Text & ", " & txt_Duree.Text & " , " & txt_Mensualite.Text & "," & txt_Taux.Text & " , " & txt_ClientCredit.Text & ")"
        'Dim sql As String = "Insert into [dbo].[CREDIT](MontantFinance, NombreMensualites, MontantMensualites, TauxAnnuel, ClientCredit) VALUES (" & Str(txt_CapitalInitial.Text) & " , " & Str(txt_Duree.Text) & " , " & Str(txt_Mensualite.Text) & " , " & Str(txt_Taux.Text) & " , '" & txt_ClientCredit.Text & "')"
        'Celle-ci est la BONNE REQUETE                 Dim sql As String = "Insert into [dbo].[CREDIT](MontantFinance, NombreMensualites, MontantMensualites, TauxAnnuel, ClientCredit) VALUES (" & Str(unCredit.GetMontantInitial()) & " , " & Str(unCredit.GetDuree()) & " , " & Str(unCredit.getMensualites()) & " , " & Str(unCredit.GetTaux()) & " , '" & unCredit.getNomClient() & "')"
        'Impossible de saisir les données, erreur.

        'VALUES(
        'sql &= txt_CapitalInitial.Text & , &= txt_Duree.Text & , &= txt_Mensualite.Text &, &= txt_Taux.Text &, &= txt_ClientCredit.Text)"


        'Dim sql As String = "Insert into [dbo].[CREDIT](MontantFinance, NombreMensualites, MontantMensualites, TauxAnnuel, ClientCredit) VALUES (
        '10000,10,160,10,'HUBER')"

        Dim cmd As New SqlCommand(sql, cnn)

        cmd.ExecuteNonQuery()

        'Dim reader As SqlDataReader
        'reader = cmd.ExecuteReader()
        'txt_Mensualite.Text = reader.Read()
        MsgBox("ok pour votre ajout")
        cnn.Close()
    End Sub

    Private Sub txt_ClientCredit_TextChanged(sender As Object, e As EventArgs) Handles txt_ClientCredit.TextChanged

    End Sub

    Private Sub cmdBien_Click(sender As Object, e As EventArgs) Handles cmdBien.Click
        If fenSaisieBien Is Nothing Then
            fenSaisieBien = New frmSaisieBien  'design pattern : singleton
        ElseIf fenSaisieBien.IsDisposed Then
            fenSaisieBien = New frmSaisieBien
        End If

        'fenIntro = New frmIntroduction


        fenSaisieBien.Show() ''affichage de l'objet

        fenSaisieBien.BringToFront() ''Permet de mettre la fenêtre concernée au premier plan

        'fenIntro2.Show() ''affichage de l'objet

        'frmIntroduction.ShowDialog()    ''fenêtre modale

        Me.Close()  'Masque la fenêtre

        'Me.Hide()
    End Sub

    Private Sub cmdClient_Click(sender As Object, e As EventArgs) Handles cmdClient.Click
        If fenClient Is Nothing Then
            fenClient = New Client  'design pattern : singleton
        ElseIf fenClient.IsDisposed Then
            fenClient = New Client
        End If

        fenClient.Show()

        fenClient.BringToFront()

        Me.Close()
    End Sub

    Private Sub cmdIntro_Click(sender As Object, e As EventArgs) Handles cmdIntro.Click
        If fenIntro Is Nothing Then
            fenIntro = New frmIntroduction  'design pattern : singleton
        ElseIf fenIntro.IsDisposed Then
            fenIntro = New frmIntroduction
        End If

        'fenIntro = New frmIntroduction

        fenIntro.Show() ''affichage de l'objet

        fenIntro.BringToFront() ''Permet de mettre la fenêtre concernée au premier plan

        'fenIntro2.Show() ''affichage de l'objet

        'frmIntroduction.ShowDialog()    ''fenêtre modale

        'Me.Hide()
        Me.Close()
        'Me.Dispose()
    End Sub

    Private Sub lbl_Duree_Click(sender As Object, e As EventArgs) Handles lbl_Duree.Click

    End Sub
End Class