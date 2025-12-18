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
        grp1 = New GroupBox()
        pates = New RadioButton()
        burger = New RadioButton()
        pizza = New RadioButton()
        grp2 = New GroupBox()
        dessert = New CheckBox()
        frits = New CheckBox()
        fromage = New CheckBox()
        listboisson = New ComboBox()
        Label1 = New Label()
        resultat = New Label()
        ajouter = New Button()
        grp1.SuspendLayout()
        grp2.SuspendLayout()
        SuspendLayout()
        ' 
        ' grp1
        ' 
        grp1.Controls.Add(pates)
        grp1.Controls.Add(burger)
        grp1.Controls.Add(pizza)
        grp1.Location = New Point(68, 37)
        grp1.Name = "grp1"
        grp1.Size = New Size(250, 125)
        grp1.TabIndex = 0
        grp1.TabStop = False
        grp1.Text = "plas"
        ' 
        ' pates
        ' 
        pates.AutoSize = True
        pates.Location = New Point(23, 95)
        pates.Name = "pates"
        pates.Size = New Size(66, 24)
        pates.TabIndex = 2
        pates.TabStop = True
        pates.Text = "pates"
        pates.UseVisualStyleBackColor = True
        ' 
        ' burger
        ' 
        burger.AutoSize = True
        burger.Location = New Point(23, 54)
        burger.Name = "burger"
        burger.Size = New Size(74, 24)
        burger.TabIndex = 1
        burger.TabStop = True
        burger.Text = "burger"
        burger.UseVisualStyleBackColor = True
        ' 
        ' pizza
        ' 
        pizza.AutoSize = True
        pizza.Location = New Point(23, 24)
        pizza.Name = "pizza"
        pizza.Size = New Size(65, 24)
        pizza.TabIndex = 0
        pizza.TabStop = True
        pizza.Text = "pizza"
        pizza.UseVisualStyleBackColor = True
        ' 
        ' grp2
        ' 
        grp2.Controls.Add(dessert)
        grp2.Controls.Add(frits)
        grp2.Controls.Add(fromage)
        grp2.Location = New Point(68, 230)
        grp2.Name = "grp2"
        grp2.Size = New Size(250, 125)
        grp2.TabIndex = 1
        grp2.TabStop = False
        grp2.Text = "supplement"
        ' 
        ' dessert
        ' 
        dessert.AutoSize = True
        dessert.Location = New Point(25, 95)
        dessert.Name = "dessert"
        dessert.Size = New Size(78, 24)
        dessert.TabIndex = 2
        dessert.Text = "dessert"
        dessert.UseVisualStyleBackColor = True
        ' 
        ' frits
        ' 
        frits.AutoSize = True
        frits.Location = New Point(25, 55)
        frits.Name = "frits"
        frits.Size = New Size(56, 24)
        frits.TabIndex = 1
        frits.Text = "frits"
        frits.UseVisualStyleBackColor = True
        ' 
        ' fromage
        ' 
        fromage.AutoSize = True
        fromage.Location = New Point(25, 25)
        fromage.Name = "fromage"
        fromage.Size = New Size(88, 24)
        fromage.TabIndex = 0
        fromage.Text = "fromage"
        fromage.UseVisualStyleBackColor = True
        ' 
        ' listboisson
        ' 
        listboisson.FormattingEnabled = True
        listboisson.Location = New Point(536, 87)
        listboisson.Name = "listboisson"
        listboisson.Size = New Size(151, 28)
        listboisson.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(422, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 20)
        Label1.TabIndex = 3
        Label1.Text = "boisson"
        ' 
        ' resultat
        ' 
        resultat.AutoSize = True
        resultat.Location = New Point(460, 146)
        resultat.Name = "resultat"
        resultat.Size = New Size(0, 20)
        resultat.TabIndex = 4
        ' 
        ' ajouter
        ' 
        ajouter.Location = New Point(392, 218)
        ajouter.Name = "ajouter"
        ajouter.Size = New Size(94, 29)
        ajouter.TabIndex = 5
        ajouter.Text = "ajouter"
        ajouter.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ajouter)
        Controls.Add(resultat)
        Controls.Add(Label1)
        Controls.Add(listboisson)
        Controls.Add(grp2)
        Controls.Add(grp1)
        Name = "Form1"
        Text = "Form1"
        grp1.ResumeLayout(False)
        grp1.PerformLayout()
        grp2.ResumeLayout(False)
        grp2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents grp1 As GroupBox
    Friend WithEvents pates As RadioButton
    Friend WithEvents burger As RadioButton
    Friend WithEvents pizza As RadioButton
    Friend WithEvents grp2 As GroupBox
    Friend WithEvents dessert As CheckBox
    Friend WithEvents frits As CheckBox
    Friend WithEvents fromage As CheckBox
    Friend WithEvents listboisson As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents resultat As Label
    Friend WithEvents ajouter As Button

End Class
