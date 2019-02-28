Public Class frmIntroduction
    Private Sub frmIntroduction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Affichage des vendeurs
        'Lire les vendeurs de la concession

        For Each xVendeur As Vendeur In uneConcession.lesVendeurs
            cboVendeur.Items.Add(xVendeur.getVendeur())
        Next

        'De l'objet vers l'écran

        txtNouvVeh.Text = uneVoiture.getNomVehicule()
        txtAncVeh.Text = uneVoiture.getAncienNomVehicule()
        '
        '   charger le client, de l'objet vers l'écran
        '
        txtNom.Text = unClientVoiture.getNomClient()
        txtPrenom.Text = unClientVoiture.getPrenomClient()
        cboCidt.Text = unClientVoiture.getCidtClient()

    End Sub

    Private Sub cmdEnregistre_Click(sender As Object, e As EventArgs) Handles cmdEnregistre.Click
        Dim age As String   'âge de la voiture

        'stockage des données dans les objets
        '
        'le client

        unClientVoiture.setCidtClient(cboCidt.Text)
        unClientVoiture.setNomClient(txtNom.Text)
        unClientVoiture.setPrenomClient(txtPrenom.Text)
        '
        'les données du véhicule

        'If rdbNeuf.Checked Then
        '    'le bouton est coché
        '    age = rdbNeuf.Text

        'ElseIf rdbOcc3.Checked Then
        '    'le bouton est coché
        '    age = rdbOcc3.Text

        'ElseIf rdbOcc3a5.Checked Then
        '    'le bouton est coché
        '    age = rdbOcc3a5.Text

        'ElseIf rdbOcc5.Checked Then
        '    'le bouton est coché
        '    age = rdbOcc5.Text

        'End If

        'MsgBox(age)


        '2eme méthode

        Dim i As Integer
        Dim radio As RadioButton
        'For i = 0 To gpbAge.Controls.Count - 1
        '    radio = If gpbAge.Controls(i)
        '    If radio.Checked Then
        '        age = radio.Text
        '    End If
        'Next
        ''-->Inconvénients : parcourir toute la liste


        '3eme méthode
        'For Each radio In gpbAge.Controls
        '    If radio.Checked Then
        '        age = radio.Text
        '    End If
        'Next

        'MsgBox(age)


        '4eme méthode
        i = 0
        radio = gpbAge.Controls(i)

        Do While radio.Checked = False And i < gpbAge.Controls.Count - 1
            i = i + 1
            radio = gpbAge.Controls(i)
        Loop

        'Je m'arrête au bon endroit, pas besoin de parcourir toute la liste

        age = radio.Text

        uneVoiture.setVoiture(txtNouvVeh.Text, txtAncVeh.Text, age)

        MsgBox("C'est enregistré")

    End Sub

    Private Sub cmdBien_Click(sender As Object, e As EventArgs) Handles cmdBien.Click
        '
        'permet de saisir les informations de la voiture/un bien
        '
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

    Private Sub cmdCredit_Click(sender As Object, e As EventArgs) Handles cmdCredit.Click
        '
        '   Mettre en place la fenêtre du crédit
        '   Le tout en C# (écran, et la classe voiture)
        '   L'écran en VB, et la classe en C#
        '
        If fenCredit Is Nothing Then
            fenCredit = New frmCredit  'design pattern : singleton
        ElseIf fenCredit.IsDisposed Then
            fenCredit = New frmCredit
        End If

        fenCredit.Show()

        fenCredit.BringToFront()

        Me.Close()
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
End Class