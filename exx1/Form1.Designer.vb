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
        Label2 = New Label()
        txtnom = New TextBox()
        txtprenom = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(54, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 20)
        Label1.TabIndex = 0
        Label1.Text = "nom"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(54, 134)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 20)
        Label2.TabIndex = 1
        Label2.Text = "age"
        ' 
        ' txtnom
        ' 
        txtnom.Location = New Point(169, 53)
        txtnom.Name = "txtnom"
        txtnom.Size = New Size(125, 27)
        txtnom.TabIndex = 2
        ' 
        ' txtprenom
        ' 
        txtprenom.Location = New Point(169, 134)
        txtprenom.Name = "txtprenom"
        txtprenom.Size = New Size(125, 27)
        txtprenom.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtprenom)
        Controls.Add(txtnom)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnom As TextBox
    Friend WithEvents txtprenom As TextBox

End Class
