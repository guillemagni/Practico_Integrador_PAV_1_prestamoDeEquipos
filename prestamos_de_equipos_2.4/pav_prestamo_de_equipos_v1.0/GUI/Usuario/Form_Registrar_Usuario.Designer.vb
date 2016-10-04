<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Registrar_Usuario
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
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.txt_box_nombre_usuario = New System.Windows.Forms.TextBox()
        Me.txt_box_apellido_usuario = New System.Windows.Forms.TextBox()
        Me.txt_box_password_usuario = New System.Windows.Forms.TextBox()
        Me.lbl_mensaje = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.lbl_nickname = New System.Windows.Forms.Label()
        Me.txt_box_nickname_usuario = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(66, 79)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Nombre"
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(66, 122)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(44, 13)
        Me.lbl_apellido.TabIndex = 1
        Me.lbl_apellido.Text = "Apellido"
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Location = New System.Drawing.Point(66, 198)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(61, 13)
        Me.lbl_password.TabIndex = 2
        Me.lbl_password.Text = "Contraseña"
        '
        'txt_box_nombre_usuario
        '
        Me.txt_box_nombre_usuario.Location = New System.Drawing.Point(147, 79)
        Me.txt_box_nombre_usuario.Name = "txt_box_nombre_usuario"
        Me.txt_box_nombre_usuario.Size = New System.Drawing.Size(206, 20)
        Me.txt_box_nombre_usuario.TabIndex = 3
        '
        'txt_box_apellido_usuario
        '
        Me.txt_box_apellido_usuario.Location = New System.Drawing.Point(147, 119)
        Me.txt_box_apellido_usuario.Name = "txt_box_apellido_usuario"
        Me.txt_box_apellido_usuario.Size = New System.Drawing.Size(206, 20)
        Me.txt_box_apellido_usuario.TabIndex = 4
        '
        'txt_box_password_usuario
        '
        Me.txt_box_password_usuario.Location = New System.Drawing.Point(147, 195)
        Me.txt_box_password_usuario.Name = "txt_box_password_usuario"
        Me.txt_box_password_usuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_box_password_usuario.Size = New System.Drawing.Size(206, 20)
        Me.txt_box_password_usuario.TabIndex = 6
        '
        'lbl_mensaje
        '
        Me.lbl_mensaje.AutoSize = True
        Me.lbl_mensaje.Location = New System.Drawing.Point(66, 37)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(151, 13)
        Me.lbl_mensaje.TabIndex = 6
        Me.lbl_mensaje.Text = "Ingrese los Datos del Uusuario"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(268, 264)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(85, 25)
        Me.btn_cancelar.TabIndex = 8
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(169, 264)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(85, 25)
        Me.btn_aceptar.TabIndex = 7
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'lbl_nickname
        '
        Me.lbl_nickname.AutoSize = True
        Me.lbl_nickname.Location = New System.Drawing.Point(66, 159)
        Me.lbl_nickname.Name = "lbl_nickname"
        Me.lbl_nickname.Size = New System.Drawing.Size(55, 13)
        Me.lbl_nickname.TabIndex = 27
        Me.lbl_nickname.Text = "Nickname"
        '
        'txt_box_nickname_usuario
        '
        Me.txt_box_nickname_usuario.Location = New System.Drawing.Point(147, 159)
        Me.txt_box_nickname_usuario.Name = "txt_box_nickname_usuario"
        Me.txt_box_nickname_usuario.Size = New System.Drawing.Size(206, 20)
        Me.txt_box_nickname_usuario.TabIndex = 5
        '
        'Form_Registrar_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 319)
        Me.Controls.Add(Me.txt_box_nickname_usuario)
        Me.Controls.Add(Me.lbl_nickname)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.Controls.Add(Me.txt_box_password_usuario)
        Me.Controls.Add(Me.txt_box_apellido_usuario)
        Me.Controls.Add(Me.txt_box_nombre_usuario)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.lbl_apellido)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Name = "Form_Registrar_Usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_apellido As Label
    Friend WithEvents lbl_password As Label
    Friend WithEvents txt_box_nombre_usuario As TextBox
    Friend WithEvents txt_box_apellido_usuario As TextBox
    Friend WithEvents txt_box_password_usuario As TextBox
    Friend WithEvents lbl_mensaje As Label
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents lbl_nickname As Label
    Friend WithEvents txt_box_nickname_usuario As TextBox
End Class
