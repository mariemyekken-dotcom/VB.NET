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
        nomm = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtnom = New TextBox()
        txtprenom = New TextBox()
        txtage = New NumericUpDown()
        btnajouter = New Button()
        btnannuler = New Button()
        graffichage = New DataGridView()
        code = New DataGridViewTextBoxColumn()
        nom = New DataGridViewTextBoxColumn()
        prenom = New DataGridViewTextBoxColumn()
        age = New DataGridViewTextBoxColumn()
        labdate = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        CType(txtage, ComponentModel.ISupportInitialize).BeginInit()
        CType(graffichage, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(154, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(187, 20)
        Label1.TabIndex = 0
        Label1.Text = "ajouter un nouveau patient"
        ' 
        ' nomm
        ' 
        nomm.AutoSize = True
        nomm.Location = New Point(54, 71)
        nomm.Name = "nomm"
        nomm.Size = New Size(39, 20)
        nomm.TabIndex = 1
        nomm.Text = "nom"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(54, 140)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 20)
        Label3.TabIndex = 2
        Label3.Text = "prenom"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(54, 217)
        Label4.Name = "Label4"
        Label4.Size = New Size(34, 20)
        Label4.TabIndex = 3
        Label4.Text = "age"
        ' 
        ' txtnom
        ' 
        txtnom.Location = New Point(154, 66)
        txtnom.Name = "txtnom"
        txtnom.Size = New Size(125, 27)
        txtnom.TabIndex = 4
        ' 
        ' txtprenom
        ' 
        txtprenom.Location = New Point(154, 133)
        txtprenom.Name = "txtprenom"
        txtprenom.Size = New Size(125, 27)
        txtprenom.TabIndex = 5
        ' 
        ' txtage
        ' 
        txtage.Location = New Point(156, 217)
        txtage.Name = "txtage"
        txtage.Size = New Size(150, 27)
        txtage.TabIndex = 6
        ' 
        ' btnajouter
        ' 
        btnajouter.Location = New Point(89, 319)
        btnajouter.Name = "btnajouter"
        btnajouter.Size = New Size(94, 29)
        btnajouter.TabIndex = 7
        btnajouter.Text = "ajouter"
        btnajouter.UseVisualStyleBackColor = True
        ' 
        ' btnannuler
        ' 
        btnannuler.Location = New Point(247, 319)
        btnannuler.Name = "btnannuler"
        btnannuler.Size = New Size(94, 29)
        btnannuler.TabIndex = 8
        btnannuler.Text = "annuler"
        btnannuler.UseVisualStyleBackColor = True
        ' 
        ' graffichage
        ' 
        graffichage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        graffichage.Columns.AddRange(New DataGridViewColumn() {code, nom, prenom, age})
        graffichage.Location = New Point(403, 105)
        graffichage.Name = "graffichage"
        graffichage.RowHeadersWidth = 51
        graffichage.Size = New Size(648, 188)
        graffichage.TabIndex = 9
        ' 
        ' code
        ' 
        code.HeaderText = "code"
        code.MinimumWidth = 6
        code.Name = "code"
        code.Width = 125
        ' 
        ' nom
        ' 
        nom.HeaderText = "nom"
        nom.MinimumWidth = 6
        nom.Name = "nom"
        nom.Width = 125
        ' 
        ' prenom
        ' 
        prenom.HeaderText = "prenom"
        prenom.MinimumWidth = 6
        prenom.Name = "prenom"
        prenom.Width = 125
        ' 
        ' age
        ' 
        age.HeaderText = "age"
        age.MinimumWidth = 6
        age.Name = "age"
        age.Width = 125
        ' 
        ' labdate
        ' 
        labdate.AutoSize = True
        labdate.Location = New Point(622, 30)
        labdate.Name = "labdate"
        labdate.Size = New Size(0, 20)
        labdate.TabIndex = 10
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1157, 486)
        Controls.Add(labdate)
        Controls.Add(graffichage)
        Controls.Add(btnannuler)
        Controls.Add(btnajouter)
        Controls.Add(txtage)
        Controls.Add(txtprenom)
        Controls.Add(txtnom)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(nomm)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(txtage, ComponentModel.ISupportInitialize).EndInit()
        CType(graffichage, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents nomm As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnom As TextBox
    Friend WithEvents txtprenom As TextBox
    Friend WithEvents txtage As NumericUpDown
    Friend WithEvents btnajouter As Button
    Friend WithEvents btnannuler As Button
    Friend WithEvents graffichage As DataGridView
    Friend WithEvents code As DataGridViewTextBoxColumn
    Friend WithEvents nom As DataGridViewTextBoxColumn
    Friend WithEvents prenom As DataGridViewTextBoxColumn
    Friend WithEvents age As DataGridViewTextBoxColumn
    Friend WithEvents labdate As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class
