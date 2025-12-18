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
        Label3 = New Label()
        Label4 = New Label()
        txtcode = New TextBox()
        txtquantite = New TextBox()
        txtprix = New TextBox()
        txtdes = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(61, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 20)
        Label1.TabIndex = 0
        Label1.Text = "code"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(61, 107)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 20)
        Label2.TabIndex = 1
        Label2.Text = "designation"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(61, 157)
        Label3.Name = "Label3"
        Label3.Size = New Size(34, 20)
        Label3.TabIndex = 2
        Label3.Text = "prix"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(61, 223)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 20)
        Label4.TabIndex = 3
        Label4.Text = "quantite"
        ' 
        ' txtcode
        ' 
        txtcode.Location = New Point(233, 53)
        txtcode.Name = "txtcode"
        txtcode.Size = New Size(125, 27)
        txtcode.TabIndex = 4
        ' 
        ' txtquantite
        ' 
        txtquantite.Location = New Point(233, 220)
        txtquantite.Name = "txtquantite"
        txtquantite.Size = New Size(125, 27)
        txtquantite.TabIndex = 5
        ' 
        ' txtprix
        ' 
        txtprix.Location = New Point(233, 169)
        txtprix.Name = "txtprix"
        txtprix.Size = New Size(125, 27)
        txtprix.TabIndex = 6
        ' 
        ' txtdes
        ' 
        txtdes.Location = New Point(233, 107)
        txtdes.Name = "txtdes"
        txtdes.Size = New Size(125, 27)
        txtdes.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(506, 154)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 8
        Button1.Text = "article"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(txtdes)
        Controls.Add(txtprix)
        Controls.Add(txtquantite)
        Controls.Add(txtcode)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcode As TextBox
    Friend WithEvents txtquantite As TextBox
    Friend WithEvents txtprix As TextBox
    Friend WithEvents txtdes As TextBox
    Friend WithEvents Button1 As Button

End Class
