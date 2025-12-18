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
        txta = New TextBox()
        txtb = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(52, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(17, 20)
        Label1.TabIndex = 0
        Label1.Text = "a"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(52, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(18, 20)
        Label2.TabIndex = 1
        Label2.Text = "b"
        ' 
        ' txta
        ' 
        txta.Location = New Point(123, 46)
        txta.Name = "txta"
        txta.Size = New Size(125, 27)
        txta.TabIndex = 2
        ' 
        ' txtb
        ' 
        txtb.Location = New Point(123, 110)
        txtb.Name = "txtb"
        txtb.Size = New Size(125, 27)
        txtb.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtb)
        Controls.Add(txta)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txta As TextBox
    Friend WithEvents txtb As TextBox

End Class
