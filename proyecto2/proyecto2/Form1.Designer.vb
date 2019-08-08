<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.txtcontra = New System.Windows.Forms.TextBox()
        Me.Usuario = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btniniciarsesion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(204, 100)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(192, 20)
        Me.txtusuario.TabIndex = 0
        '
        'txtcontra
        '
        Me.txtcontra.Location = New System.Drawing.Point(204, 189)
        Me.txtcontra.Name = "txtcontra"
        Me.txtcontra.Size = New System.Drawing.Size(192, 20)
        Me.txtcontra.TabIndex = 1
        '
        'Usuario
        '
        Me.Usuario.AutoSize = True
        Me.Usuario.Location = New System.Drawing.Point(81, 103)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(43, 13)
        Me.Usuario.TabIndex = 2
        Me.Usuario.Text = "Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Contraseña"
        '
        'btniniciarsesion
        '
        Me.btniniciarsesion.Location = New System.Drawing.Point(187, 330)
        Me.btniniciarsesion.Name = "btniniciarsesion"
        Me.btniniciarsesion.Size = New System.Drawing.Size(121, 23)
        Me.btniniciarsesion.TabIndex = 4
        Me.btniniciarsesion.Text = "Iniciar Sesión"
        Me.btniniciarsesion.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 413)
        Me.Controls.Add(Me.btniniciarsesion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Usuario)
        Me.Controls.Add(Me.txtcontra)
        Me.Controls.Add(Me.txtusuario)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtusuario As System.Windows.Forms.TextBox
    Friend WithEvents txtcontra As System.Windows.Forms.TextBox
    Friend WithEvents Usuario As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btniniciarsesion As System.Windows.Forms.Button

End Class
