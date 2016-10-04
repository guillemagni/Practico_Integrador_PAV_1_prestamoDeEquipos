<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblContra = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContra = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lbl_mensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(26, 70)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "Usuario"
        '
        'lblContra
        '
        Me.lblContra.AutoSize = True
        Me.lblContra.Location = New System.Drawing.Point(26, 99)
        Me.lblContra.Name = "lblContra"
        Me.lblContra.Size = New System.Drawing.Size(61, 13)
        Me.lblContra.TabIndex = 1
        Me.lblContra.Text = "Contraseña"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(109, 67)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(199, 20)
        Me.txtUsuario.TabIndex = 2
        '
        'txtContra
        '
        Me.txtContra.Location = New System.Drawing.Point(109, 99)
        Me.txtContra.Name = "txtContra"
        Me.txtContra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContra.Size = New System.Drawing.Size(199, 20)
        Me.txtContra.TabIndex = 3
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(109, 134)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(91, 23)
        Me.btnIngresar.TabIndex = 4
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(217, 134)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(91, 23)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lbl_mensaje
        '
        Me.lbl_mensaje.AutoSize = True
        Me.lbl_mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_mensaje.Location = New System.Drawing.Point(106, 22)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(116, 17)
        Me.lbl_mensaje.TabIndex = 6
        Me.lbl_mensaje.Text = "Ingrese los datos"
        '
        'Form_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 183)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.txtContra)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblContra)
        Me.Controls.Add(Me.lblUsuario)
        Me.MaximizeBox = False
        Me.Name = "Form_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblContra As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContra As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents lbl_mensaje As Label
End Class
