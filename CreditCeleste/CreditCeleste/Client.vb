Public Class Client
    Private situation As String
    Private autorisation As Boolean
    Private autorisation2 As Boolean
    Private autorisation3 As Boolean
    Private txt As String
    Private txt2 As String
    Private txt3 As String



    Private Sub Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboCidt.Text = unClientVoiture.getCidtClient()
        txtNom.Text = unClientVoiture.getNomClient()
        txtPrenom.Text = unClientVoiture.getPrenomClient()
        txtAdresse.Text = unClientVoiture.getAdresseClient()
        txtVille.Text = unClientVoiture.getVilleClient()
        txtCodePostal.Text = unClientVoiture.getCodePostalClient()
        txtNumTel.Text = unClientVoiture.getNumTelClient()
        txtDateNaissance.Text = unClientVoiture.getDateNaissance()
        txtRevenuAnnuel.Text = unClientVoiture.getRevenuAnnuel()
        txtProfession.Text = unClientVoiture.getProfession()
        txtNomJeuneFille.Text = unClientVoiture.getNomJeuneFille()
        txtMail.Text = unClientVoiture.getMail()
        'Dim condition = unClientVoiture.getSituation()

        If unClientVoiture.getSituation() = "Propriétaire" Then
            '    'le bouton est coché
            rdbProprio.Checked = True

        ElseIf unClientVoiture.getSituation() = "Locataire" Then
            '    'le bouton est coché
            rdbLocat.Checked = True

        ElseIf unClientVoiture.getSituation() = "Occupant à titre gratuit" Then
            '    'le bouton est coché
            rdbOccGratuit.Checked = True
        End If

        If unClientVoiture.getAutorisation() = True Then
            chkboxCorresp.Checked = True
        End If

        If unClientVoiture.getAutorisation2() = True Then
            chkboxCommerc.Checked = True
        End If

        If unClientVoiture.getAutorisation3() = True Then
            chkboxPrestat.Checked = True
        End If

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

    Private Sub cmdCredit_Click(sender As Object, e As EventArgs) Handles cmdCredit.Click
        If fenCredit Is Nothing Then
            fenCredit = New frmCredit  'design pattern : singleton
        ElseIf fenCredit.IsDisposed Then
            fenCredit = New frmCredit
        End If

        fenCredit.Show()

        fenCredit.BringToFront()

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


    Private Sub gpbSituation_Enter(sender As Object, e As EventArgs) Handles gpbSituation.Enter

    End Sub

    Private Sub cmdEnregistre_Click(sender As Object, e As EventArgs) Handles cmdEnregistre.Click

        unClientVoiture.setCidtClient(cboCidt.Text)
        unClientVoiture.setNomClient(txtNom.Text)
        unClientVoiture.setPrenomClient(txtPrenom.Text)
        unClientVoiture.setAdresseClient(txtAdresse.Text)
        unClientVoiture.setVilleClient(txtVille.Text)
        unClientVoiture.setCodePostalClient(txtCodePostal.Text)
        unClientVoiture.setNumTelClient(txtNumTel.Text)
        unClientVoiture.setDateNaissance(txtDateNaissance.Text)
        unClientVoiture.setRevenuAnnuel(txtRevenuAnnuel.Text)
        unClientVoiture.setProfession(txtProfession.Text)
        unClientVoiture.setNomJeuneFille(txtNomJeuneFille.Text)
        unClientVoiture.setMail(txtMail.Text)
        If rdbProprio.Checked Then
            '    'le bouton est coché
            situation = rdbProprio.Text

        ElseIf rdbLocat.Checked Then
            '    'le bouton est coché
            situation = rdbLocat.Text

        ElseIf rdbOccGratuit.Checked Then
            '    'le bouton est coché
            situation = rdbOccGratuit.Text
        End If

        unClientVoiture.setSituation(situation)


        If chkboxCorresp.Checked Then
            'le bouton est coché
            autorisation = True
        End If


        If chkboxCommerc.Checked Then
            'le bouton est coché
            autorisation2 = True
        End If

        If chkboxPrestat.Checked Then
            'le bouton est coché
            autorisation3 = True
        End If

        unClientVoiture.setAutorisations(autorisation, autorisation2, autorisation3)


        If unClientVoiture.getAutorisation() = True Then
            txt = chkboxCorresp.Text
        End If

        If unClientVoiture.getAutorisation2() = True Then
            txt2 = chkboxCommerc.Text
        End If

        If unClientVoiture.getAutorisation3() = True Then
            txt3 = chkboxPrestat.Text
        End If

        MsgBox("C'est enregistré, vous avez choisi " & unClientVoiture.getSituation() & " concernant votre situation et " & txt & ", " & txt2 & ", " & txt3 & ".")



    End Sub

    Private Sub gpbAutorisations_Enter(sender As Object, e As EventArgs) Handles gpbAutorisations.Enter

    End Sub

    Private Sub chkboxCorresp_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxCorresp.CheckedChanged

    End Sub

    Private Sub chkboxCommerc_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxCommerc.CheckedChanged

    End Sub

    Private Sub chkboxPrestat_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxPrestat.CheckedChanged

    End Sub
End Class