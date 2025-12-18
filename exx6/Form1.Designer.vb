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
        Label1 = New Label()
        txtetudiant = New TextBox()
        Button1 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        txtprenom = New TextBox()
        txtage = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(31, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 20)
        Label1.TabIndex = 0
        Label1.Text = "nom etudiant"
        ' 
        ' txtetudiant
        ' 
        txtetudiant.Location = New Point(185, 58)
        txtetudiant.Name = "txtetudiant"
        txtetudiant.Size = New Size(125, 27)
        txtetudiant.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(443, 295)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 2
        Button1.Text = "meilleur"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(31, 145)
        Label2.Name = "Label2"
        Label2.Size = New Size(120, 20)
        Label2.TabIndex = 3
        Label2.Text = "prenom etudiant"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(31, 215)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 20)
        Label3.TabIndex = 4
        Label3.Text = "age etudiant"
        ' 
        ' txtprenom
        ' 
        txtprenom.Location = New Point(196, 145)
        txtprenom.Name = "txtprenom"
        txtprenom.Size = New Size(125, 27)
        txtprenom.TabIndex = 5
        ' 
        ' txtage
        ' 
        txtage.Location = New Point(185, 224)
        txtage.Name = "txtage"
        txtage.Size = New Size(125, 27)
        txtage.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtage)
        Controls.Add(txtprenom)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(txtetudiant)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtetudiant As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtprenom As TextBox
    Friend WithEvents txtage As TextBox

End Class
