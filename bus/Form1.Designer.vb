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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        listligne = New ComboBox()
        listdep = New ComboBox()
        listarr = New ComboBox()
        txtplace = New NumericUpDown()
        grp1 = New GroupBox()
        busaetage = New CheckBox()
        wifi = New CheckBox()
        climatisation = New CheckBox()
        grp2 = New GroupBox()
        nocturne = New RadioButton()
        express = New RadioButton()
        regulier = New RadioButton()
        ajouter = New Button()
        Button2 = New Button()
        Button3 = New Button()
        date1 = New DateTimePicker()
        date2 = New DateTimePicker()
        affichage = New DataGridView()
        code = New DataGridViewTextBoxColumn()
        villede = New DataGridViewTextBoxColumn()
        villearr = New DataGridViewTextBoxColumn()
        heurede = New DataGridViewTextBoxColumn()
        places = New DataGridViewTextBoxColumn()
        heurearr = New DataGridViewTextBoxColumn()
        optionn = New DataGridViewTextBoxColumn()
        ErrorProvider1 = New ErrorProvider(components)
        CType(txtplace, ComponentModel.ISupportInitialize).BeginInit()
        grp1.SuspendLayout()
        grp2.SuspendLayout()
        CType(affichage, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(32, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 20)
        Label1.TabIndex = 0
        Label1.Text = "ligne"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(32, 194)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 20)
        Label2.TabIndex = 1
        Label2.Text = "ville arrivee"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(32, 98)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 20)
        Label3.TabIndex = 2
        Label3.Text = "ville depart"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(342, 107)
        Label4.Name = "Label4"
        Label4.Size = New Size(95, 20)
        Label4.TabIndex = 3
        Label4.Text = "heure arrivee"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(342, 27)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 20)
        Label5.TabIndex = 4
        Label5.Text = "heure depart"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(342, 194)
        Label6.Name = "Label6"
        Label6.Size = New Size(51, 20)
        Label6.TabIndex = 5
        Label6.Text = "places"
        ' 
        ' listligne
        ' 
        listligne.FormattingEnabled = True
        listligne.Location = New Point(118, 27)
        listligne.Name = "listligne"
        listligne.Size = New Size(151, 28)
        listligne.TabIndex = 6
        ' 
        ' listdep
        ' 
        listdep.FormattingEnabled = True
        listdep.Location = New Point(118, 103)
        listdep.Name = "listdep"
        listdep.Size = New Size(151, 28)
        listdep.TabIndex = 7
        ' 
        ' listarr
        ' 
        listarr.FormattingEnabled = True
        listarr.Location = New Point(118, 186)
        listarr.Name = "listarr"
        listarr.Size = New Size(151, 28)
        listarr.TabIndex = 8
        ' 
        ' txtplace
        ' 
        txtplace.Location = New Point(471, 197)
        txtplace.Name = "txtplace"
        txtplace.Size = New Size(150, 27)
        txtplace.TabIndex = 9
        ' 
        ' grp1
        ' 
        grp1.Controls.Add(busaetage)
        grp1.Controls.Add(wifi)
        grp1.Controls.Add(climatisation)
        grp1.Location = New Point(740, 34)
        grp1.Name = "grp1"
        grp1.Size = New Size(250, 125)
        grp1.TabIndex = 10
        grp1.TabStop = False
        grp1.Text = "option"
        ' 
        ' busaetage
        ' 
        busaetage.AutoSize = True
        busaetage.Location = New Point(23, 82)
        busaetage.Name = "busaetage"
        busaetage.Size = New Size(108, 24)
        busaetage.TabIndex = 2
        busaetage.Text = "bus a etage"
        busaetage.UseVisualStyleBackColor = True
        ' 
        ' wifi
        ' 
        wifi.AutoSize = True
        wifi.Location = New Point(23, 52)
        wifi.Name = "wifi"
        wifi.Size = New Size(55, 24)
        wifi.TabIndex = 1
        wifi.Text = "wifi"
        wifi.UseVisualStyleBackColor = True
        ' 
        ' climatisation
        ' 
        climatisation.AutoSize = True
        climatisation.Location = New Point(23, 22)
        climatisation.Name = "climatisation"
        climatisation.Size = New Size(116, 24)
        climatisation.TabIndex = 0
        climatisation.Text = "climatisation"
        climatisation.UseVisualStyleBackColor = True
        ' 
        ' grp2
        ' 
        grp2.Controls.Add(nocturne)
        grp2.Controls.Add(express)
        grp2.Controls.Add(regulier)
        grp2.Location = New Point(1038, 34)
        grp2.Name = "grp2"
        grp2.Size = New Size(250, 125)
        grp2.TabIndex = 11
        grp2.TabStop = False
        grp2.Text = "type de trajet"
        ' 
        ' nocturne
        ' 
        nocturne.AutoSize = True
        nocturne.Location = New Point(23, 81)
        nocturne.Name = "nocturne"
        nocturne.Size = New Size(88, 24)
        nocturne.TabIndex = 2
        nocturne.TabStop = True
        nocturne.Text = "nocturne"
        nocturne.UseVisualStyleBackColor = True
        ' 
        ' express
        ' 
        express.AutoSize = True
        express.Location = New Point(23, 51)
        express.Name = "express"
        express.Size = New Size(79, 24)
        express.TabIndex = 1
        express.TabStop = True
        express.Text = "express"
        express.UseVisualStyleBackColor = True
        ' 
        ' regulier
        ' 
        regulier.AutoSize = True
        regulier.Location = New Point(23, 22)
        regulier.Name = "regulier"
        regulier.Size = New Size(81, 24)
        regulier.TabIndex = 0
        regulier.TabStop = True
        regulier.Text = "regulier"
        regulier.UseVisualStyleBackColor = True
        ' 
        ' ajouter
        ' 
        ajouter.Location = New Point(12, 248)
        ajouter.Name = "ajouter"
        ajouter.Size = New Size(94, 29)
        ajouter.TabIndex = 12
        ajouter.Text = "ajouter"
        ajouter.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(273, 248)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 13
        Button2.Text = "annuler"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(136, 248)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 14
        Button3.Text = "vider"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' date1
        ' 
        date1.Location = New Point(437, 25)
        date1.Name = "date1"
        date1.Size = New Size(250, 27)
        date1.TabIndex = 16
        ' 
        ' date2
        ' 
        date2.AccessibleRole = AccessibleRole.None
        date2.Location = New Point(437, 107)
        date2.Name = "date2"
        date2.Size = New Size(250, 27)
        date2.TabIndex = 17
        ' 
        ' affichage
        ' 
        affichage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        affichage.Columns.AddRange(New DataGridViewColumn() {code, villede, villearr, heurede, places, heurearr, optionn})
        affichage.Location = New Point(396, 248)
        affichage.Name = "affichage"
        affichage.RowHeadersWidth = 51
        affichage.Size = New Size(933, 188)
        affichage.TabIndex = 18
        ' 
        ' code
        ' 
        code.HeaderText = "code"
        code.MinimumWidth = 6
        code.Name = "code"
        code.Width = 125
        ' 
        ' villede
        ' 
        villede.HeaderText = "villede"
        villede.MinimumWidth = 6
        villede.Name = "villede"
        villede.Width = 125
        ' 
        ' villearr
        ' 
        villearr.HeaderText = "villearr"
        villearr.MinimumWidth = 6
        villearr.Name = "villearr"
        villearr.Width = 125
        ' 
        ' heurede
        ' 
        heurede.HeaderText = "heurede"
        heurede.MinimumWidth = 6
        heurede.Name = "heurede"
        heurede.Width = 125
        ' 
        ' places
        ' 
        places.HeaderText = "places"
        places.MinimumWidth = 6
        places.Name = "places"
        places.Width = 125
        ' 
        ' heurearr
        ' 
        heurearr.HeaderText = "heurearr"
        heurearr.MinimumWidth = 6
        heurearr.Name = "heurearr"
        heurearr.Width = 125
        ' 
        ' optionn
        ' 
        optionn.HeaderText = "optionn"
        optionn.MinimumWidth = 6
        optionn.Name = "optionn"
        optionn.Width = 125
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1341, 489)
        Controls.Add(affichage)
        Controls.Add(date2)
        Controls.Add(date1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(ajouter)
        Controls.Add(grp2)
        Controls.Add(grp1)
        Controls.Add(txtplace)
        Controls.Add(listarr)
        Controls.Add(listdep)
        Controls.Add(listligne)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(txtplace, ComponentModel.ISupportInitialize).EndInit()
        grp1.ResumeLayout(False)
        grp1.PerformLayout()
        grp2.ResumeLayout(False)
        grp2.PerformLayout()
        CType(affichage, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents listligne As ComboBox
    Friend WithEvents listdep As ComboBox
    Friend WithEvents listarr As ComboBox
    Friend WithEvents txtplace As NumericUpDown
    Friend WithEvents grp1 As GroupBox
    Friend WithEvents busaetage As CheckBox
    Friend WithEvents wifi As CheckBox
    Friend WithEvents climatisation As CheckBox
    Friend WithEvents grp2 As GroupBox
    Friend WithEvents nocturne As RadioButton
    Friend WithEvents express As RadioButton
    Friend WithEvents regulier As RadioButton
    Friend WithEvents ajouter As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents date1 As DateTimePicker
    Friend WithEvents date2 As DateTimePicker
    Friend WithEvents affichage As DataGridView
    Friend WithEvents code As DataGridViewTextBoxColumn
    Friend WithEvents villede As DataGridViewTextBoxColumn
    Friend WithEvents villearr As DataGridViewTextBoxColumn
    Friend WithEvents heurede As DataGridViewTextBoxColumn
    Friend WithEvents places As DataGridViewTextBoxColumn
    Friend WithEvents heurearr As DataGridViewTextBoxColumn
    Friend WithEvents optionn As DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class
