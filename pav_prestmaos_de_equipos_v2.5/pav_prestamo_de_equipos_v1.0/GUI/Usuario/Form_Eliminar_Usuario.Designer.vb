<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Eliminar_Usuario
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
        Me.lbl_mensaje = New System.Windows.Forms.Label()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_box_nickname_usuario = New System.Windows.Forms.TextBox()
        Me.lbl_nickname_usuario = New System.Windows.Forms.Label()
        Me.lbl_nickname = New System.Windows.Forms.Label()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.lbl_valor_apellido = New System.Windows.Forms.Label()
        Me.lbl_valor_nombre = New System.Windows.Forms.Label()
        Me.lbl_valor_nickname = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_mensaje
        '
        Me.lbl_mensaje.AutoSize = True
        Me.lbl_mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_mensaje.Location = New System.Drawing.Point(12, 71)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(154, 17)
        Me.lbl_mensaje.TabIndex = 34
        Me.lbl_mensaje.Text = "Informacion de Usuario"
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(372, 28)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(102, 23)
        Me.btn_buscar.TabIndex = 33
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'txt_box_nickname_usuario
        '
        Me.txt_box_nickname_usuario.Location = New System.Drawing.Point(142, 30)
        Me.txt_box_nickname_usuario.Name = "txt_box_nickname_usuario"
        Me.txt_box_nickname_usuario.Size = New System.Drawing.Size(208, 20)
        Me.txt_box_nickname_usuario.TabIndex = 32
        '
        'lbl_nickname_usuario
        '
        Me.lbl_nickname_usuario.AutoSize = True
        Me.lbl_nickname_usuario.Location = New System.Drawing.Point(12, 33)
        Me.lbl_nickname_usuario.Name = "lbl_nickname_usuario"
        Me.lbl_nickname_usuario.Size = New System.Drawing.Size(109, 13)
        Me.lbl_nickname_usuario.TabIndex = 31
        Me.lbl_nickname_usuario.Text = "Nickname de Usuario"
        '
        'lbl_nickname
        '
        Me.lbl_nickname.AutoSize = True
        Me.lbl_nickname.Location = New System.Drawing.Point(12, 117)
        Me.lbl_nickname.Name = "lbl_nickname"
        Me.lbl_nickname.Size = New System.Drawing.Size(112, 13)
        Me.lbl_nickname.TabIndex = 38
        Me.lbl_nickname.Text = "Nickname de Usuario:"
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(12, 185)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(101, 13)
        Me.lbl_apellido.TabIndex = 36
        Me.lbl_apellido.Text = "Apellido de Usuario:"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(12, 150)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(101, 13)
        Me.lbl_nombre.TabIndex = 35
        Me.lbl_nombre.Text = "Nombre de Usuario:"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(397, 233)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 40
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        Me.btn_cancelar.Visible = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(302, 233)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminar.TabIndex = 39
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'lbl_valor_apellido
        '
        Me.lbl_valor_apellido.AutoSize = True
        Me.lbl_valor_apellido.Location = New System.Drawing.Point(143, 185)
        Me.lbl_valor_apellido.Name = "lbl_valor_apellido"
        Me.lbl_valor_apellido.Size = New System.Drawing.Size(23, 13)
        Me.lbl_valor_apellido.TabIndex = 43
        Me.lbl_valor_apellido.Text = "null"
        '
        'lbl_valor_nombre
        '
        Me.lbl_valor_nombre.AutoSize = True
        Me.lbl_valor_nombre.Location = New System.Drawing.Point(143, 150)
        Me.lbl_valor_nombre.Name = "lbl_valor_nombre"
        Me.lbl_valor_nombre.Size = New System.Drawing.Size(23, 13)
        Me.lbl_valor_nombre.TabIndex = 42
        Me.lbl_valor_nombre.Text = "null"
        '
        'lbl_valor_nickname
        '
        Me.lbl_valor_nickname.AutoSize = True
        Me.lbl_valor_nickname.Location = New System.Drawing.Point(143, 117)
        Me.lbl_valor_nickname.Name = "lbl_valor_nickname"
        Me.lbl_valor_nickname.Size = New System.Drawing.Size(23, 13)
        Me.lbl_valor_nickname.TabIndex = 41
        Me.lbl_valor_nickname.Text = "null"
        '
        'Form_Eliminar_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 310)
        Me.Controls.Add(Me.lbl_valor_apellido)
        Me.Controls.Add(Me.lbl_valor_nombre)
        Me.Controls.Add(Me.lbl_valor_nickname)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.lbl_nickname)
        Me.Controls.Add(Me.lbl_apellido)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.txt_box_nickname_usuario)
        Me.Controls.Add(Me.lbl_nickname_usuario)
        Me.Name = "Form_Eliminar_Usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_mensaje As Label
    Friend WithEvents btn_buscar As Button
    Friend WithEvents txt_box_nickname_usuario As TextBox
    Friend WithEvents lbl_nickname_usuario As Label
    Friend WithEvents lbl_nickname As Label
    Friend WithEvents lbl_apellido As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents lbl_valor_apellido As Label
    Friend WithEvents lbl_valor_nombre As Label
    Friend WithEvents lbl_valor_nickname As Label
End Class
