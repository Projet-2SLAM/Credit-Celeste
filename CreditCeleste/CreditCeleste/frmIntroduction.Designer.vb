<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIntroduction
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
        Me.cboCidt = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.cboVendeur = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gpbAge = New System.Windows.Forms.GroupBox()
        Me.rdbOcc5 = New System.Windows.Forms.RadioButton()
        Me.rdbOcc3a5 = New System.Windows.Forms.RadioButton()
        Me.rdbOcc3 = New System.Windows.Forms.RadioButton()
        Me.rdbNeuf = New System.Windows.Forms.RadioButton()
        Me.txtNouvVeh = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdEnregistre = New System.Windows.Forms.Button()
        Me.cmdBien = New System.Windows.Forms.Button()
        Me.cmdCredit = New System.Windows.Forms.Button()
        Me.cmdPlus = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAncVeh = New System.Windows.Forms.TextBox()
        Me.cmdClient = New System.Windows.Forms.Button()
        Me.gpbAge.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboCidt
        '
        Me.cboCidt.FormattingEnabled = True
        Me.cboCidt.Items.AddRange(New Object() {"Madame", "Mademoiselle", "Monsieur"})
        Me.cboCidt.Location = New System.Drawing.Point(92, 80)
        Me.cboCidt.Name = "cboCidt"
        Me.cboCidt.Size = New System.Drawing.Size(121, 21)
        Me.cboCidt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(115, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Je m'appelle"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(103, 143)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(100, 20)
        Me.txtNom.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(132, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nom"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(278, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Prénom"
        '
        'txtPrenom
        '
        Me.txtPrenom.Location = New System.Drawing.Point(249, 143)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(100, 20)
        Me.txtPrenom.TabIndex = 4
        '
        'cboVendeur
        '
        Me.cboVendeur.FormattingEnabled = True
        Me.cboVendeur.Location = New System.Drawing.Point(92, 252)
        Me.cboVendeur.Name = "cboVendeur"
        Me.cboVendeur.Size = New System.Drawing.Size(121, 21)
        Me.cboVendeur.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(132, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Vendeur"
        '
        'gpbAge
        '
        Me.gpbAge.Controls.Add(Me.rdbOcc5)
        Me.gpbAge.Controls.Add(Me.rdbOcc3a5)
        Me.gpbAge.Controls.Add(Me.rdbOcc3)
        Me.gpbAge.Controls.Add(Me.rdbNeuf)
        Me.gpbAge.Location = New System.Drawing.Point(411, 210)
        Me.gpbAge.Name = "gpbAge"
        Me.gpbAge.Size = New System.Drawing.Size(200, 106)
        Me.gpbAge.TabIndex = 8
        Me.gpbAge.TabStop = False
        Me.gpbAge.Text = "Age du véhicule"
        '
        'rdbOcc5
        '
        Me.rdbOcc5.AutoSize = True
        Me.rdbOcc5.Location = New System.Drawing.Point(7, 81)
        Me.rdbOcc5.Name = "rdbOcc5"
        Me.rdbOcc5.Size = New System.Drawing.Size(119, 19)
        Me.rdbOcc5.TabIndex = 3
        Me.rdbOcc5.Text = "Occasion > 5 ans"
        Me.rdbOcc5.UseVisualStyleBackColor = True
        '
        'rdbOcc3a5
        '
        Me.rdbOcc3a5.AutoSize = True
        Me.rdbOcc3a5.Location = New System.Drawing.Point(7, 62)
        Me.rdbOcc3a5.Name = "rdbOcc3a5"
        Me.rdbOcc3a5.Size = New System.Drawing.Size(126, 19)
        Me.rdbOcc3a5.TabIndex = 2
        Me.rdbOcc3a5.Text = "Occasion 3 - 5 ans"
        Me.rdbOcc3a5.UseVisualStyleBackColor = True
        '
        'rdbOcc3
        '
        Me.rdbOcc3.AutoSize = True
        Me.rdbOcc3.Location = New System.Drawing.Point(7, 43)
        Me.rdbOcc3.Name = "rdbOcc3"
        Me.rdbOcc3.Size = New System.Drawing.Size(119, 19)
        Me.rdbOcc3.TabIndex = 1
        Me.rdbOcc3.Text = "Occasion < 3 ans"
        Me.rdbOcc3.UseVisualStyleBackColor = True
        '
        'rdbNeuf
        '
        Me.rdbNeuf.AutoSize = True
        Me.rdbNeuf.Checked = True
        Me.rdbNeuf.Location = New System.Drawing.Point(7, 24)
        Me.rdbNeuf.Name = "rdbNeuf"
        Me.rdbNeuf.Size = New System.Drawing.Size(51, 19)
        Me.rdbNeuf.TabIndex = 0
        Me.rdbNeuf.TabStop = True
        Me.rdbNeuf.Text = "Neuf"
        Me.rdbNeuf.UseVisualStyleBackColor = True
        '
        'txtNouvVeh
        '
        Me.txtNouvVeh.Location = New System.Drawing.Point(435, 143)
        Me.txtNouvVeh.Name = "txtNouvVeh"
        Me.txtNouvVeh.Size = New System.Drawing.Size(150, 20)
        Me.txtNouvVeh.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(445, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Mon nouveau véhicule"
        '
        'cmdEnregistre
        '
        Me.cmdEnregistre.Location = New System.Drawing.Point(314, 434)
        Me.cmdEnregistre.Name = "cmdEnregistre"
        Me.cmdEnregistre.Size = New System.Drawing.Size(83, 23)
        Me.cmdEnregistre.TabIndex = 11
        Me.cmdEnregistre.Text = "J'enregistre"
        Me.cmdEnregistre.UseVisualStyleBackColor = True
        '
        'cmdBien
        '
        Me.cmdBien.Location = New System.Drawing.Point(453, 434)
        Me.cmdBien.Name = "cmdBien"
        Me.cmdBien.Size = New System.Drawing.Size(75, 23)
        Me.cmdBien.TabIndex = 12
        Me.cmdBien.Text = "Voiture"
        Me.cmdBien.UseVisualStyleBackColor = True
        '
        'cmdCredit
        '
        Me.cmdCredit.Location = New System.Drawing.Point(570, 434)
        Me.cmdCredit.Name = "cmdCredit"
        Me.cmdCredit.Size = New System.Drawing.Size(75, 23)
        Me.cmdCredit.TabIndex = 13
        Me.cmdCredit.Text = "Crédit"
        Me.cmdCredit.UseVisualStyleBackColor = True
        '
        'cmdPlus
        '
        Me.cmdPlus.Location = New System.Drawing.Point(746, 515)
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.Size = New System.Drawing.Size(75, 23)
        Me.cmdPlus.TabIndex = 14
        Me.cmdPlus.Text = "Plus"
        Me.cmdPlus.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(699, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 15)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Mon nouveau ancien"
        '
        'txtAncVeh
        '
        Me.txtAncVeh.Location = New System.Drawing.Point(686, 40)
        Me.txtAncVeh.Name = "txtAncVeh"
        Me.txtAncVeh.Size = New System.Drawing.Size(150, 20)
        Me.txtAncVeh.TabIndex = 15
        '
        'cmdClient
        '
        Me.cmdClient.Location = New System.Drawing.Point(686, 434)
        Me.cmdClient.Name = "cmdClient"
        Me.cmdClient.Size = New System.Drawing.Size(75, 23)
        Me.cmdClient.TabIndex = 17
        Me.cmdClient.Text = "Client"
        Me.cmdClient.UseVisualStyleBackColor = True
        '
        'frmIntroduction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 550)
        Me.Controls.Add(Me.cmdClient)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAncVeh)
        Me.Controls.Add(Me.cmdPlus)
        Me.Controls.Add(Me.cmdCredit)
        Me.Controls.Add(Me.cmdBien)
        Me.Controls.Add(Me.cmdEnregistre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNouvVeh)
        Me.Controls.Add(Me.gpbAge)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboVendeur)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPrenom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboCidt)
        Me.Name = "frmIntroduction"
        Me.Text = "frmIntroduction"
        Me.gpbAge.ResumeLayout(False)
        Me.gpbAge.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboCidt As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents cboVendeur As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents gpbAge As GroupBox
    Friend WithEvents rdbOcc5 As RadioButton
    Friend WithEvents rdbOcc3a5 As RadioButton
    Friend WithEvents rdbOcc3 As RadioButton
    Friend WithEvents rdbNeuf As RadioButton
    Friend WithEvents txtNouvVeh As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmdEnregistre As Button
    Friend WithEvents cmdBien As Button
    Friend WithEvents cmdCredit As Button
    Friend WithEvents cmdPlus As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAncVeh As TextBox
    Friend WithEvents cmdClient As Button
End Class
