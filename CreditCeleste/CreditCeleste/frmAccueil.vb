Public Class frmAccueil
    Private Sub cmdIntroduction_Click(sender As Object, e As EventArgs) Handles cmdIntroduction.Click

        'Dim fenIntro As New frmIntroduction '' portée

        'Dim fenIntro2 As New frmIntroduction   '2 objets frm


        ''Aller vers la fenêtre Introduction 
        '
        'frmIntroduction.Show()  'affiche une classe

        If fenIntro Is Nothing Then
            fenIntro = New frmIntroduction  'design pattern : singleton
        End If

        'fenIntro = New frmIntroduction


        fenIntro.Show() ''affichage de l'objet

        fenIntro.BringToFront() ''Permet de mettre la fenêtre concernée au premier plan

        'fenIntro2.Show() ''affichage de l'objet

        'frmIntroduction.ShowDialog()    ''fenêtre modale

        Me.Hide()




    End Sub

    Private Sub frmAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'uneConcession.setConcession()   'Si déclaration avec New

        uneConcession = New Concession("Garage du parc", "4 rue des rossignols")

        'création d'un vendeur
        Dim UnVendeur As New Vendeur("M.", "Kreyder", "Armand")
        Dim UnDeuxiemeVendeur As New Vendeur("Mme.", "Weber", "Sylvie")
        Dim UnTroisiemeVendeur As New Vendeur("M.", "Dubois", "Joel")

        'rajouter les 3 vendeurs

        uneConcession.lesVendeurs.Add(UnVendeur)
        uneConcession.lesVendeurs.Add(UnDeuxiemeVendeur)
        uneConcession.lesVendeurs.Add(UnTroisiemeVendeur)



    End Sub
End Class
