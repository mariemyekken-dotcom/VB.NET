<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        grpvetement = New GroupBox()
        chemise = New RadioButton()
        pantallon = New RadioButton()
        robe = New RadioButton()
        grpsupp = New GroupBox()
        antitache = New CheckBox()
        defoissage = New CheckBox()
        grpnett = New GroupBox()
        repasse = New RadioButton()
        lavage = New RadioButton()
        nettsec = New RadioButton()
        Label1 = New Label()
        ajouter = New Button()
        annuler = New Button()
        affichage = New DataGridView()
        vetement = New DataGridViewTextBoxColumn()
        typenett = New DataGridViewTextBoxColumn()
        supplement = New DataGridViewTextBoxColumn()
        nombre = New DataGridViewTextBoxColumn()
        txtnum = New NumericUpDown()
        ErrorProvider1 = New ErrorProvider(components)
        grpvetement.SuspendLayout()
        grpsupp.SuspendLayout()
        grpnett.SuspendLayout()
        CType(affichage, ComponentModel.ISupportInitialize).BeginInit()
        CType(txtnum, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' grpvetement
        ' 
        grpvetement.Controls.Add(chemise)
        grpvetement.Controls.Add(pantallon)
        grpvetement.Controls.Add(robe)
        grpvetement.Location = New Point(25, 26)
        grpvetement.Name = "grpvetement"
        grpvetement.Size = New Size(250, 125)
        grpvetement.TabIndex = 0
        grpvetement.TabStop = False
        grpvetement.Text = "choix de vetement"
        ' 
        ' chemise
        ' 
        chemise.AutoSize = True
        chemise.Location = New Point(23, 80)
        chemise.Name = "chemise"
        chemise.Size = New Size(84, 24)
        chemise.TabIndex = 2
        chemise.TabStop = True
        chemise.Text = "chemise"
        chemise.UseVisualStyleBackColor = True
        ' 
        ' pantallon
        ' 
        pantallon.AutoSize = True
        pantallon.Location = New Point(23, 50)
        pantallon.Name = "pantallon"
        pantallon.Size = New Size(93, 24)
        pantallon.TabIndex = 1
        pantallon.TabStop = True
        pantallon.Text = "pantallon"
        pantallon.UseVisualStyleBackColor = True
        ' 
        ' robe
        ' 
        robe.AutoSize = True
        robe.Location = New Point(23, 23)
        robe.Name = "robe"
        robe.Size = New Size(61, 24)
        robe.TabIndex = 0
        robe.TabStop = True
        robe.Text = "robe"
        robe.UseVisualStyleBackColor = True
        ' 
        ' grpsupp
        ' 
        grpsupp.Controls.Add(antitache)
        grpsupp.Controls.Add(defoissage)
        grpsupp.Location = New Point(25, 231)
        grpsupp.Name = "grpsupp"
        grpsupp.Size = New Size(250, 125)
        grpsupp.TabIndex = 1
        grpsupp.TabStop = False
        grpsupp.Text = "suppmlement"
        ' 
        ' antitache
        ' 
        antitache.AutoSize = True
        antitache.Location = New Point(23, 68)
        antitache.Name = "antitache"
        antitache.Size = New Size(96, 24)
        antitache.TabIndex = 1
        antitache.Text = "anti tache"
        antitache.UseVisualStyleBackColor = True
        ' 
        ' defoissage
        ' 
        defoissage.AutoSize = True
        defoissage.Location = New Point(29, 23)
        defoissage.Name = "defoissage"
        defoissage.Size = New Size(103, 24)
        defoissage.TabIndex = 0
        defoissage.Text = "defoissage"
        defoissage.UseVisualStyleBackColor = True
        ' 
        ' grpnett
        ' 
        grpnett.Controls.Add(repasse)
        grpnett.Controls.Add(lavage)
        grpnett.Controls.Add(nettsec)
        grpnett.Location = New Point(361, 39)
        grpnett.Name = "grpnett"
        grpnett.Size = New Size(250, 125)
        grpnett.TabIndex = 2
        grpnett.TabStop = False
        grpnett.Text = "type de nettoyage"
        ' 
        ' repasse
        ' 
        repasse.AutoSize = True
        repasse.Location = New Point(6, 85)
        repasse.Name = "repasse"
        repasse.Size = New Size(80, 24)
        repasse.TabIndex = 3
        repasse.TabStop = True
        repasse.Text = "repasse"
        repasse.UseVisualStyleBackColor = True
        ' 
        ' lavage
        ' 
        lavage.AutoSize = True
        lavage.Location = New Point(6, 55)
        lavage.Name = "lavage"
        lavage.Size = New Size(74, 24)
        lavage.TabIndex = 2
        lavage.TabStop = True
        lavage.Text = "lavage"
        lavage.UseVisualStyleBackColor = True
        ' 
        ' nettsec
        ' 
        nettsec.AutoSize = True
        nettsec.Location = New Point(6, 26)
        nettsec.Name = "nettsec"
        nettsec.Size = New Size(81, 24)
        nettsec.TabIndex = 1
        nettsec.TabStop = True
        nettsec.Text = "nett sec"
        nettsec.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(755, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 20)
        Label1.TabIndex = 3
        Label1.Text = "nombre d'article"
        ' 
        ' ajouter
        ' 
        ajouter.Location = New Point(987, 72)
        ajouter.Name = "ajouter"
        ajouter.Size = New Size(94, 29)
        ajouter.TabIndex = 5
        ajouter.Text = "ajouter"
        ajouter.UseVisualStyleBackColor = True
        ' 
        ' annuler
        ' 
        annuler.Location = New Point(1133, 72)
        annuler.Name = "annuler"
        annuler.Size = New Size(94, 29)
        annuler.TabIndex = 6
        annuler.Text = "annuler"
        annuler.UseVisualStyleBackColor = True
        ' 
        ' affichage
        ' 
        affichage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        affichage.Columns.AddRange(New DataGridViewColumn() {vetement, typenett, supplement, nombre})
        affichage.Location = New Point(400, 225)
        affichage.Name = "affichage"
        affichage.RowHeadersWidth = 51
        affichage.Size = New Size(684, 188)
        affichage.TabIndex = 7
        ' 
        ' vetement
        ' 
        vetement.HeaderText = "vetement"
        vetement.MinimumWidth = 6
        vetement.Name = "vetement"
        vetement.Width = 125
        ' 
        ' typenett
        ' 
        typenett.HeaderText = "type de nett"
        typenett.MinimumWidth = 6
        typenett.Name = "typenett"
        typenett.Width = 125
        ' 
        ' supplement
        ' 
        supplement.HeaderText = "suppment"
        supplement.MinimumWidth = 6
        supplement.Name = "supplement"
        supplement.Width = 125
        ' 
        ' nombre
        ' 
        nombre.HeaderText = "nombre"
        nombre.MinimumWidth = 6
        nombre.Name = "nombre"
        nombre.Width = 125
        ' 
        ' txtnum
        ' 
        txtnum.Location = New Point(779, 91)
        txtnum.Name = "txtnum"
        txtnum.Size = New Size(150, 27)
        txtnum.TabIndex = 8
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1320, 492)
        Controls.Add(txtnum)
        Controls.Add(affichage)
        Controls.Add(annuler)
        Controls.Add(ajouter)
        Controls.Add(Label1)
        Controls.Add(grpnett)
        Controls.Add(grpsupp)
        Controls.Add(grpvetement)
        Name = "Form1"
        Text = "Form1"
        grpvetement.ResumeLayout(False)
        grpvetement.PerformLayout()
        grpsupp.ResumeLayout(False)
        grpsupp.PerformLayout()
        grpnett.ResumeLayout(False)
        grpnett.PerformLayout()
        CType(affichage, ComponentModel.ISupportInitialize).EndInit()
        CType(txtnum, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents grpvetement As GroupBox
    Friend WithEvents chemise As RadioButton
    Friend WithEvents pantallon As RadioButton
    Friend WithEvents robe As RadioButton
    Friend WithEvents grpsupp As GroupBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents antitache As CheckBox
    Friend WithEvents defoissage As CheckBox
    Friend WithEvents grpnett As GroupBox
    Friend WithEvents repasse As RadioButton
    Friend WithEvents lavage As RadioButton
    Friend WithEvents nettsec As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents ajouter As Button
    Friend WithEvents annuler As Button
    Friend WithEvents affichage As DataGridView
    Friend WithEvents vetement As DataGridViewTextBoxColumn
    Friend WithEvents typenett As DataGridViewTextBoxColumn
    Friend WithEvents supplement As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents txtnum As NumericUpDown
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class
