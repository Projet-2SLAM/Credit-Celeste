Public Class frmSaisieBien
    Private Sub frmSaisieBien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt1ereImmat.Text = uneVoiture.getDate1ereImmat()
        txtAnneeModele.Text = uneVoiture.getAnneeModele()
        txtNumImmat.Text = uneVoiture.getNumImmat()
        txtNumSerie.Text = uneVoiture.getNumSerie()
        txtPuissance.Text = uneVoiture.getPuisChevaux()
        gpbNouveauVehic.Text = uneVoiture.getNomVehicule()
    End Sub

    Private Sub cmdEnregistre_Click(sender As Object, e As EventArgs) Handles cmdEnregistre.Click

        uneVoiture.setVoiture(txt1ereImmat.Text, txtAnneeModele.Text, txtNumImmat.Text, txtNumSerie.Text, txtPuissance.Text)
        MsgBox("C'est enregistré")
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

    Private Sub cmdCredit_Click(sender As Object, e As EventArgs) Handles cmdCredit.Click
        ' chaînage vers le crédit
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