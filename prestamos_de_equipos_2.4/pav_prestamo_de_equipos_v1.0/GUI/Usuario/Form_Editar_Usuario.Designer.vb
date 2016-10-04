<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Editar_Usuario
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
        Me.lbl_nickname_usuario = New System.Windows.Forms.Label()
        Me.txt_box_nickname_usuario = New System.Windows.Forms.TextBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.lbl_mensaje = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.lbl_pass = New System.Windows.Forms.Label()
        Me.lbl_nick = New System.Windows.Forms.Label()
        Me.txt_box_nombre = New System.Windows.Forms.TextBox()
        Me.txt_box_apellido = New System.Windows.Forms.TextBox()
        Me.txt_box_pass = New System.Windows.Forms.TextBox()
        Me.txt_box_nick = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbl_nickname_usuario
        '
        Me.lbl_nickname_usuario.AutoSize = True
        Me.lbl_nickname_usuario.Location = New System.Drawing.Point(12, 24)
        Me.lbl_nickname_usuario.Name = "lbl_nickname_usuario"
        Me.lbl_nickname_usuario.Size = New System.Drawing.Size(109, 13)
        Me.lbl_nickname_usuario.TabIndex = 0
        Me.lbl_nickname_usuario.Text = "Nickname de Usuario"
        '
        'txt_box_nickname_usuario
        '
        Me.txt_box_nickname_usuario.Location = New System.Drawing.Point(142, 21)
        Me.txt_box_nickname_usuario.Name = "txt_box_nickname_usuario"
        Me.txt_box_nickname_usuario.Size = New System.Drawing.Size(208, 20)
        Me.txt_box_nickname_usuario.TabIndex = 2
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(390, 297)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(85, 25)
        Me.btn_cancelar.TabIndex = 28
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(291, 297)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(85, 25)
        Me.btn_aceptar.TabIndex = 27
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(373, 19)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(102, 23)
        Me.btn_buscar.TabIndex = 29
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'lbl_mensaje
        '
        Me.lbl_mensaje.AutoSize = True
        Me.lbl_mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_mensaje.Location = New System.Drawing.Point(183, 59)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(154, 17)
        Me.lbl_mensaje.TabIndex = 30
        Me.lbl_mensaje.Text = "Informacion de Usuario"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(22, 101)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(50, 13)
        Me.lbl_nombre.TabIndex = 31
        Me.lbl_nombre.Text = "Nombre: "
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(22, 144)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(47, 13)
        Me.lbl_apellido.TabIndex = 32
        Me.lbl_apellido.Text = "Apellido:"
        '
        'lbl_pass
        '
        Me.lbl_pass.AutoSize = True
        Me.lbl_pass.Location = New System.Drawing.Point(22, 193)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(56, 13)
        Me.lbl_pass.TabIndex = 33
        Me.lbl_pass.Text = "Password:"
        '
        'lbl_nick
        '
        Me.lbl_nick.AutoSize = True
        Me.lbl_nick.Location = New System.Drawing.Point(22, 231)
        Me.lbl_nick.Name = "lbl_nick"
        Me.lbl_nick.Size = New System.Drawing.Size(58, 13)
        Me.lbl_nick.TabIndex = 34
        Me.lbl_nick.Text = "Nickname:"
        '
        'txt_box_nombre
        '
        Me.txt_box_nombre.Location = New System.Drawing.Point(127, 101)
        Me.txt_box_nombre.Name = "txt_box_nombre"
        Me.txt_box_nombre.Size = New System.Drawing.Size(100, 20)
        Me.txt_box_nombre.TabIndex = 35
        '
        'txt_box_apellido
        '
        Me.txt_box_apellido.Location = New System.Drawing.Point(127, 144)
        Me.txt_box_apellido.Name = "txt_box_apellido"
        Me.txt_box_apellido.Size = New System.Drawing.Size(100, 20)
        Me.txt_box_apellido.TabIndex = 36
        '
        'txt_box_pass
        '
        Me.txt_box_pass.Location = New System.Drawing.Point(127, 190)
        Me.txt_box_pass.Name = "txt_box_pass"
        Me.txt_box_pass.Size = New System.Drawing.Size(100, 20)
        Me.txt_box_pass.TabIndex = 37
        '
        'txt_box_nick
        '
        Me.txt_box_nick.Location = New System.Drawing.Point(127, 231)
        Me.txt_box_nick.Name = "txt_box_nick"
        Me.txt_box_nick.Size = New System.Drawing.Size(100, 20)
        Me.txt_box_nick.TabIndex = 38
        '
        'Form_Editar_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 334)
        Me.Controls.Add(Me.txt_box_nick)
        Me.Controls.Add(Me.txt_box_pass)
        Me.Controls.Add(Me.txt_box_apellido)
        Me.Controls.Add(Me.txt_box_nombre)
        Me.Controls.Add(Me.lbl_nick)
        Me.Controls.Add(Me.lbl_pass)
        Me.Controls.Add(Me.lbl_apellido)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.txt_box_nickname_usuario)
        Me.Controls.Add(Me.lbl_nickname_usuario)
        Me.Name = "Form_Editar_Usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_nickname_usuario As Label
    Friend WithEvents txt_box_nickname_usuario As TextBox
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents btn_buscar As Button
    Friend WithEvents lbl_mensaje As Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents lbl_pass As System.Windows.Forms.Label
    Friend WithEvents lbl_nick As System.Windows.Forms.Label
    Friend WithEvents txt_box_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_box_apellido As System.Windows.Forms.TextBox
    Friend WithEvents txt_box_pass As System.Windows.Forms.TextBox
    Friend WithEvents txt_box_nick As System.Windows.Forms.TextBox
End Class
