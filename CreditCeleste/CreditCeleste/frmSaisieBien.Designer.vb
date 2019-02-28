<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaisieBien
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
        Me.txt1ereImmat = New System.Windows.Forms.TextBox()
        Me.txtPuissance = New System.Windows.Forms.TextBox()
        Me.txtNumSerie = New System.Windows.Forms.TextBox()
        Me.txtNumImmat = New System.Windows.Forms.TextBox()
        Me.txtAnneeModele = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdEnregistre = New System.Windows.Forms.Button()
        Me.cmdIntro = New System.Windows.Forms.Button()
        Me.cmdCredit = New System.Windows.Forms.Button()
        Me.gpbNouveauVehic = New System.Windows.Forms.GroupBox()
        Me.gpbAge = New System.Windows.Forms.GroupBox()
        Me.rdbOcc5 = New System.Windows.Forms.RadioButton()
        Me.rdbOcc3a5 = New System.Windows.Forms.RadioButton()
        Me.rdbOcc3 = New System.Windows.Forms.RadioButton()
        Me.rdbNeuf = New System.Windows.Forms.RadioButton()
        Me.cmdClient = New System.Windows.Forms.Button()
        Me.gpbAge.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt1ereImmat
        '
        Me.txt1ereImmat.Location = New System.Drawing.Point(33, 285)
        Me.txt1ereImmat.Name = "txt1ereImmat"
        Me.txt1ereImmat.Size = New System.Drawing.Size(100, 20)
        Me.txt1ereImmat.TabIndex = 0
        '
        'txtPuissance
        '
        Me.txtPuissance.Location = New System.Drawing.Point(654, 285)
        Me.txtPuissance.Name = "txtPuissance"
        Me.txtPuissance.Size = New System.Drawing.Size(100, 20)
        Me.txtPuissance.TabIndex = 1
        '
        'txtNumSerie
        '
        Me.txtNumSerie.Location = New System.Drawing.Point(503, 285)
        Me.txtNumSerie.Name = "txtNumSerie"
        Me.txtNumSerie.Size = New System.Drawing.Size(100, 20)
        Me.txtNumSerie.TabIndex = 2
        '
        'txtNumImmat
        '
        Me.txtNumImmat.Location = New System.Drawing.Point(339, 285)
        Me.txtNumImmat.Name = "txtNumImmat"
        Me.txtNumImmat.Size = New System.Drawing.Size(100, 20)
        Me.txtNumImmat.TabIndex = 3
        '
        'txtAnneeModele
        '
        Me.txtAnneeModele.Location = New System.Drawing.Point(180, 285)
        Me.txtAnneeModele.Name = "txtAnneeModele"
        Me.txtAnneeModele.Size = New System.Drawing.Size(100, 20)
        Me.txtAnneeModele.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-1, 308)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Date de 1ère immatriculation"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(185, 308)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Année modèle"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(321, 312)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Numéro d'immatriculation"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(504, 308)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Numéro de série"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(674, 308)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Puissance"
        '
        'cmdEnregistre
        '
        Me.cmdEnregistre.Location = New System.Drawing.Point(686, 378)
        Me.cmdEnregistre.Name = "cmdEnregistre"
        Me.cmdEnregistre.Size = New System.Drawing.Size(80, 23)
        Me.cmdEnregistre.TabIndex = 10
        Me.cmdEnregistre.Text = "J'enregistre"
        Me.cmdEnregistre.UseVisualStyleBackColor = True
        '
        'cmdIntro
        '
        Me.cmdIntro.Location = New System.Drawing.Point(313, 378)
        Me.cmdIntro.Name = "cmdIntro"
        Me.cmdIntro.Size = New System.Drawing.Size(81, 23)
        Me.cmdIntro.TabIndex = 11
        Me.cmdIntro.Text = "Introduction"
        Me.cmdIntro.UseVisualStyleBackColor = True
        '
        'cmdCredit
        '
        Me.cmdCredit.Location = New System.Drawing.Point(447, 378)
        Me.cmdCredit.Name = "cmdCredit"
        Me.cmdCredit.Size = New System.Drawing.Size(75, 23)
        Me.cmdCredit.TabIndex = 12
        Me.cmdCredit.Text = "Crédit"
        Me.cmdCredit.UseVisualStyleBackColor = True
        '
        'gpbNouveauVehic
        '
        Me.gpbNouveauVehic.Location = New System.Drawing.Point(296, 56)
        Me.gpbNouveauVehic.Name = "gpbNouveauVehic"
        Me.gpbNouveauVehic.Size = New System.Drawing.Size(200, 100)
        Me.gpbNouveauVehic.TabIndex = 13
        Me.gpbNouveauVehic.TabStop = False
        Me.gpbNouveauVehic.Text = "Mon nouveau véhicule"
        '
        'gpbAge
        '
        Me.gpbAge.Controls.Add(Me.rdbOcc5)
        Me.gpbAge.Controls.Add(Me.rdbOcc3a5)
        Me.gpbAge.Controls.Add(Me.rdbOcc3)
        Me.gpbAge.Controls.Add(Me.rdbNeuf)
        Me.gpbAge.Location = New System.Drawing.Point(300, 172)
        Me.gpbAge.Name = "gpbAge"
        Me.gpbAge.Size = New System.Drawing.Size(200, 106)
        Me.gpbAge.TabIndex = 14
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
        'cmdClient
        '
        Me.cmdClient.Location = New System.Drawing.Point(566, 378)
        Me.cmdClient.Name = "cmdClient"
        Me.cmdClient.Size = New System.Drawing.Size(75, 23)
        Me.cmdClient.TabIndex = 18
        Me.cmdClient.Text = "Client"
        Me.cmdClient.UseVisualStyleBackColor = True
        '
        'frmSaisieBien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdClient)
        Me.Controls.Add(Me.gpbAge)
        Me.Controls.Add(Me.gpbNouveauVehic)
        Me.Controls.Add(Me.cmdCredit)
        Me.Controls.Add(Me.cmdIntro)
        Me.Controls.Add(Me.cmdEnregistre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAnneeModele)
        Me.Controls.Add(Me.txtNumImmat)
        Me.Controls.Add(Me.txtNumSerie)
        Me.Controls.Add(Me.txtPuissance)
        Me.Controls.Add(Me.txt1ereImmat)
        Me.Name = "frmSaisieBien"
        Me.Text = "frmSaisieBien"
        Me.gpbAge.ResumeLayout(False)
        Me.gpbAge.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt1ereImmat As TextBox
    Friend WithEvents txtPuissance As TextBox
    Friend WithEvents txtNumSerie As TextBox
    Friend WithEvents txtNumImmat As TextBox
    Friend WithEvents txtAnneeModele As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmdEnregistre As Button
    Friend WithEvents cmdIntro As Button
    Friend WithEvents cmdCredit As Button
    Friend WithEvents gpbNouveauVehic As GroupBox
    Friend WithEvents gpbAge As GroupBox
    Friend WithEvents rdbOcc5 As RadioButton
    Friend WithEvents rdbOcc3a5 As RadioButton
    Friend WithEvents rdbOcc3 As RadioButton
    Friend WithEvents rdbNeuf As RadioButton
    Friend WithEvents cmdClient As Button
End Class
