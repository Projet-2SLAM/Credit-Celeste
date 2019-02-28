<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCredit
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_Mensualite = New System.Windows.Forms.Label()
        Me.txt_Mensualite = New System.Windows.Forms.TextBox()
        Me.btn_Calcul = New System.Windows.Forms.Button()
        Me.lbl_Duree = New System.Windows.Forms.Label()
        Me.lbl_Taux = New System.Windows.Forms.Label()
        Me.lbl_CapitalInitial = New System.Windows.Forms.Label()
        Me.txt_Duree = New System.Windows.Forms.TextBox()
        Me.txt_Taux = New System.Windows.Forms.TextBox()
        Me.txt_CapitalInitial = New System.Windows.Forms.TextBox()
        Me.cmd_Connexion = New System.Windows.Forms.Button()
        Me.lbl_nomConnexion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_ClientCredit = New System.Windows.Forms.TextBox()
        Me.lbl_ClientCredit = New System.Windows.Forms.Label()
        Me.cmdClient = New System.Windows.Forms.Button()
        Me.cmdBien = New System.Windows.Forms.Button()
        Me.cmdIntro = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_Mensualite
        '
        Me.lbl_Mensualite.AutoSize = True
        Me.lbl_Mensualite.Location = New System.Drawing.Point(200, 232)
        Me.lbl_Mensualite.Name = "lbl_Mensualite"
        Me.lbl_Mensualite.Size = New System.Drawing.Size(74, 15)
        Me.lbl_Mensualite.TabIndex = 17
        Me.lbl_Mensualite.Text = "Mensualités"
        '
        'txt_Mensualite
        '
        Me.txt_Mensualite.Location = New System.Drawing.Point(280, 231)
        Me.txt_Mensualite.Name = "txt_Mensualite"
        Me.txt_Mensualite.Size = New System.Drawing.Size(100, 20)
        Me.txt_Mensualite.TabIndex = 16
        '
        'btn_Calcul
        '
        Me.btn_Calcul.Location = New System.Drawing.Point(236, 158)
        Me.btn_Calcul.Name = "btn_Calcul"
        Me.btn_Calcul.Size = New System.Drawing.Size(112, 23)
        Me.btn_Calcul.TabIndex = 15
        Me.btn_Calcul.Text = "Calculer intérêts"
        Me.btn_Calcul.UseVisualStyleBackColor = True
        '
        'lbl_Duree
        '
        Me.lbl_Duree.AutoSize = True
        Me.lbl_Duree.Location = New System.Drawing.Point(501, 91)
        Me.lbl_Duree.Name = "lbl_Duree"
        Me.lbl_Duree.Size = New System.Drawing.Size(96, 15)
        Me.lbl_Duree.TabIndex = 14
        Me.lbl_Duree.Text = "Durée (en mois)"
        '
        'lbl_Taux
        '
        Me.lbl_Taux.AutoSize = True
        Me.lbl_Taux.Location = New System.Drawing.Point(310, 89)
        Me.lbl_Taux.Name = "lbl_Taux"
        Me.lbl_Taux.Size = New System.Drawing.Size(56, 15)
        Me.lbl_Taux.TabIndex = 13
        Me.lbl_Taux.Text = "Taux (%)"
        '
        'lbl_CapitalInitial
        '
        Me.lbl_CapitalInitial.AutoSize = True
        Me.lbl_CapitalInitial.Location = New System.Drawing.Point(59, 89)
        Me.lbl_CapitalInitial.Name = "lbl_CapitalInitial"
        Me.lbl_CapitalInitial.Size = New System.Drawing.Size(77, 15)
        Me.lbl_CapitalInitial.TabIndex = 12
        Me.lbl_CapitalInitial.Text = "Capital Initial"
        '
        'txt_Duree
        '
        Me.txt_Duree.Location = New System.Drawing.Point(612, 89)
        Me.txt_Duree.Name = "txt_Duree"
        Me.txt_Duree.Size = New System.Drawing.Size(100, 20)
        Me.txt_Duree.TabIndex = 11
        '
        'txt_Taux
        '
        Me.txt_Taux.Location = New System.Drawing.Point(367, 89)
        Me.txt_Taux.Name = "txt_Taux"
        Me.txt_Taux.Size = New System.Drawing.Size(100, 20)
        Me.txt_Taux.TabIndex = 10
        '
        'txt_CapitalInitial
        '
        Me.txt_CapitalInitial.Location = New System.Drawing.Point(142, 89)
        Me.txt_CapitalInitial.Name = "txt_CapitalInitial"
        Me.txt_CapitalInitial.Size = New System.Drawing.Size(100, 20)
        Me.txt_CapitalInitial.TabIndex = 9
        '
        'cmd_Connexion
        '
        Me.cmd_Connexion.Location = New System.Drawing.Point(646, 249)
        Me.cmd_Connexion.Name = "cmd_Connexion"
        Me.cmd_Connexion.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Connexion.TabIndex = 18
        Me.cmd_Connexion.Text = "Connexion"
        Me.cmd_Connexion.UseVisualStyleBackColor = True
        '
        'lbl_nomConnexion
        '
        Me.lbl_nomConnexion.AutoSize = True
        Me.lbl_nomConnexion.Location = New System.Drawing.Point(643, 287)
        Me.lbl_nomConnexion.Name = "lbl_nomConnexion"
        Me.lbl_nomConnexion.Size = New System.Drawing.Size(83, 15)
        Me.lbl_nomConnexion.TabIndex = 19
        Me.lbl_nomConnexion.Text = "Non connecté"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(508, 287)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 15)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Connecté en tant que :"
        '
        'txt_ClientCredit
        '
        Me.txt_ClientCredit.Location = New System.Drawing.Point(637, 209)
        Me.txt_ClientCredit.Name = "txt_ClientCredit"
        Me.txt_ClientCredit.Size = New System.Drawing.Size(100, 20)
        Me.txt_ClientCredit.TabIndex = 21
        '
        'lbl_ClientCredit
        '
        Me.lbl_ClientCredit.AutoSize = True
        Me.lbl_ClientCredit.Location = New System.Drawing.Point(532, 211)
        Me.lbl_ClientCredit.Name = "lbl_ClientCredit"
        Me.lbl_ClientCredit.Size = New System.Drawing.Size(99, 15)
        Me.lbl_ClientCredit.TabIndex = 22
        Me.lbl_ClientCredit.Text = "Renseigner nom"
        '
        'cmdClient
        '
        Me.cmdClient.Location = New System.Drawing.Point(626, 386)
        Me.cmdClient.Name = "cmdClient"
        Me.cmdClient.Size = New System.Drawing.Size(75, 23)
        Me.cmdClient.TabIndex = 25
        Me.cmdClient.Text = "Client"
        Me.cmdClient.UseVisualStyleBackColor = True
        '
        'cmdBien
        '
        Me.cmdBien.Location = New System.Drawing.Point(511, 386)
        Me.cmdBien.Name = "cmdBien"
        Me.cmdBien.Size = New System.Drawing.Size(75, 23)
        Me.cmdBien.TabIndex = 23
        Me.cmdBien.Text = "Voiture"
        Me.cmdBien.UseVisualStyleBackColor = True
        '
        'cmdIntro
        '
        Me.cmdIntro.Location = New System.Drawing.Point(387, 386)
        Me.cmdIntro.Name = "cmdIntro"
        Me.cmdIntro.Size = New System.Drawing.Size(81, 23)
        Me.cmdIntro.TabIndex = 26
        Me.cmdIntro.Text = "Introduction"
        Me.cmdIntro.UseVisualStyleBackColor = True
        '
        'frmCredit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdIntro)
        Me.Controls.Add(Me.cmdClient)
        Me.Controls.Add(Me.cmdBien)
        Me.Controls.Add(Me.lbl_ClientCredit)
        Me.Controls.Add(Me.txt_ClientCredit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_nomConnexion)
        Me.Controls.Add(Me.cmd_Connexion)
        Me.Controls.Add(Me.lbl_Mensualite)
        Me.Controls.Add(Me.txt_Mensualite)
        Me.Controls.Add(Me.btn_Calcul)
        Me.Controls.Add(Me.lbl_Duree)
        Me.Controls.Add(Me.lbl_Taux)
        Me.Controls.Add(Me.lbl_CapitalInitial)
        Me.Controls.Add(Me.txt_Duree)
        Me.Controls.Add(Me.txt_Taux)
        Me.Controls.Add(Me.txt_CapitalInitial)
        Me.Name = "frmCredit"
        Me.Text = "frmCredit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Mensualite As Label
    Friend WithEvents txt_Mensualite As TextBox
    Friend WithEvents btn_Calcul As Button
    Friend WithEvents lbl_Duree As Label
    Friend WithEvents lbl_Taux As Label
    Friend WithEvents lbl_CapitalInitial As Label
    Friend WithEvents txt_Duree As TextBox
    Friend WithEvents txt_Taux As TextBox
    Friend WithEvents txt_CapitalInitial As TextBox
    Friend WithEvents cmd_Connexion As Button
    Friend WithEvents lbl_nomConnexion As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_ClientCredit As TextBox
    Friend WithEvents lbl_ClientCredit As Label
    Friend WithEvents cmdClient As Button
    Friend WithEvents cmdBien As Button
    Friend WithEvents cmdIntro As Button
End Class
