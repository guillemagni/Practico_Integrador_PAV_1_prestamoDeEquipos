<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Eliminar_Equipo
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
        Me.txt_idEquipo = New System.Windows.Forms.TextBox()
        Me.lbl_idEquipo = New System.Windows.Forms.Label()
        Me.lbl_id_equipo = New System.Windows.Forms.Label()
        Me.lbl_nombre_equipo = New System.Windows.Forms.Label()
        Me.lbl_Descripcion_equipo = New System.Windows.Forms.Label()
        Me.lbl_id_estado_equipo = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.lbl_valor_descripcion_equipo = New System.Windows.Forms.Label()
        Me.lbl_valor_nombre_equipo = New System.Windows.Forms.Label()
        Me.lbl_valor_id_equipo = New System.Windows.Forms.Label()
        Me.lbl_valor_id_estado_equipo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_mensaje
        '
        Me.lbl_mensaje.AutoSize = True
        Me.lbl_mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_mensaje.Location = New System.Drawing.Point(158, 88)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(152, 17)
        Me.lbl_mensaje.TabIndex = 45
        Me.lbl_mensaje.Text = "Informacion del Equipo"
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(359, 46)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(102, 23)
        Me.btn_buscar.TabIndex = 44
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'txt_idEquipo
        '
        Me.txt_idEquipo.Location = New System.Drawing.Point(124, 46)
        Me.txt_idEquipo.Name = "txt_idEquipo"
        Me.txt_idEquipo.Size = New System.Drawing.Size(212, 20)
        Me.txt_idEquipo.TabIndex = 43
        '
        'lbl_idEquipo
        '
        Me.lbl_idEquipo.AutoSize = True
        Me.lbl_idEquipo.Location = New System.Drawing.Point(37, 49)
        Me.lbl_idEquipo.Name = "lbl_idEquipo"
        Me.lbl_idEquipo.Size = New System.Drawing.Size(69, 13)
        Me.lbl_idEquipo.TabIndex = 42
        Me.lbl_idEquipo.Text = "Id del Equipo"
        '
        'lbl_id_equipo
        '
        Me.lbl_id_equipo.AutoSize = True
        Me.lbl_id_equipo.Location = New System.Drawing.Point(104, 158)
        Me.lbl_id_equipo.Name = "lbl_id_equipo"
        Me.lbl_id_equipo.Size = New System.Drawing.Size(126, 13)
        Me.lbl_id_equipo.TabIndex = 46
        Me.lbl_id_equipo.Text = "Identificacion del Equipo:"
        '
        'lbl_nombre_equipo
        '
        Me.lbl_nombre_equipo.AutoSize = True
        Me.lbl_nombre_equipo.Location = New System.Drawing.Point(104, 201)
        Me.lbl_nombre_equipo.Name = "lbl_nombre_equipo"
        Me.lbl_nombre_equipo.Size = New System.Drawing.Size(100, 13)
        Me.lbl_nombre_equipo.TabIndex = 47
        Me.lbl_nombre_equipo.Text = "Nombre del Equipo:"
        '
        'lbl_Descripcion_equipo
        '
        Me.lbl_Descripcion_equipo.AutoSize = True
        Me.lbl_Descripcion_equipo.Location = New System.Drawing.Point(104, 245)
        Me.lbl_Descripcion_equipo.Name = "lbl_Descripcion_equipo"
        Me.lbl_Descripcion_equipo.Size = New System.Drawing.Size(119, 13)
        Me.lbl_Descripcion_equipo.TabIndex = 48
        Me.lbl_Descripcion_equipo.Text = "Descripcion del Equipo:"
        '
        'lbl_id_estado_equipo
        '
        Me.lbl_id_estado_equipo.AutoSize = True
        Me.lbl_id_estado_equipo.Location = New System.Drawing.Point(104, 287)
        Me.lbl_id_estado_equipo.Name = "lbl_id_estado_equipo"
        Me.lbl_id_estado_equipo.Size = New System.Drawing.Size(96, 13)
        Me.lbl_id_estado_equipo.TabIndex = 49
        Me.lbl_id_estado_equipo.Text = "Estado del Equipo:"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(386, 372)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 51
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(294, 372)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminar.TabIndex = 50
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'lbl_valor_descripcion_equipo
        '
        Me.lbl_valor_descripcion_equipo.AutoSize = True
        Me.lbl_valor_descripcion_equipo.Location = New System.Drawing.Point(279, 245)
        Me.lbl_valor_descripcion_equipo.Name = "lbl_valor_descripcion_equipo"
        Me.lbl_valor_descripcion_equipo.Size = New System.Drawing.Size(23, 13)
        Me.lbl_valor_descripcion_equipo.TabIndex = 54
        Me.lbl_valor_descripcion_equipo.Text = "null"
        '
        'lbl_valor_nombre_equipo
        '
        Me.lbl_valor_nombre_equipo.AutoSize = True
        Me.lbl_valor_nombre_equipo.Location = New System.Drawing.Point(279, 201)
        Me.lbl_valor_nombre_equipo.Name = "lbl_valor_nombre_equipo"
        Me.lbl_valor_nombre_equipo.Size = New System.Drawing.Size(23, 13)
        Me.lbl_valor_nombre_equipo.TabIndex = 53
        Me.lbl_valor_nombre_equipo.Text = "null"
        '
        'lbl_valor_id_equipo
        '
        Me.lbl_valor_id_equipo.AutoSize = True
        Me.lbl_valor_id_equipo.Location = New System.Drawing.Point(279, 158)
        Me.lbl_valor_id_equipo.Name = "lbl_valor_id_equipo"
        Me.lbl_valor_id_equipo.Size = New System.Drawing.Size(23, 13)
        Me.lbl_valor_id_equipo.TabIndex = 52
        Me.lbl_valor_id_equipo.Text = "null"
        '
        'lbl_valor_id_estado_equipo
        '
        Me.lbl_valor_id_estado_equipo.AutoSize = True
        Me.lbl_valor_id_estado_equipo.Location = New System.Drawing.Point(282, 286)
        Me.lbl_valor_id_estado_equipo.Name = "lbl_valor_id_estado_equipo"
        Me.lbl_valor_id_estado_equipo.Size = New System.Drawing.Size(23, 13)
        Me.lbl_valor_id_estado_equipo.TabIndex = 55
        Me.lbl_valor_id_estado_equipo.Text = "null"
        '
        'Form_Eliminar_Equipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 452)
        Me.Controls.Add(Me.lbl_valor_id_estado_equipo)
        Me.Controls.Add(Me.lbl_valor_descripcion_equipo)
        Me.Controls.Add(Me.lbl_valor_nombre_equipo)
        Me.Controls.Add(Me.lbl_valor_id_equipo)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.lbl_id_estado_equipo)
        Me.Controls.Add(Me.lbl_Descripcion_equipo)
        Me.Controls.Add(Me.lbl_nombre_equipo)
        Me.Controls.Add(Me.lbl_id_equipo)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.txt_idEquipo)
        Me.Controls.Add(Me.lbl_idEquipo)
        Me.Name = "Form_Eliminar_Equipo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar Equipo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_mensaje As Label
    Friend WithEvents btn_buscar As Button
    Friend WithEvents txt_idEquipo As TextBox
    Friend WithEvents lbl_idEquipo As Label
    Friend WithEvents lbl_id_equipo As Label
    Friend WithEvents lbl_nombre_equipo As Label
    Friend WithEvents lbl_Descripcion_equipo As Label
    Friend WithEvents lbl_id_estado_equipo As Label
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents lbl_valor_descripcion_equipo As Label
    Friend WithEvents lbl_valor_nombre_equipo As Label
    Friend WithEvents lbl_valor_id_equipo As Label
    Friend WithEvents lbl_valor_id_estado_equipo As Label
End Class
