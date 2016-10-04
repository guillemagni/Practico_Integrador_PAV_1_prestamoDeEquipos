<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Eliminar_Horario_X_Turno
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
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.lbl_valor_hora_fin = New System.Windows.Forms.Label()
        Me.lbl_hora_fin = New System.Windows.Forms.Label()
        Me.lbl_valor_hora_inicio = New System.Windows.Forms.Label()
        Me.lbl_hora_inicio = New System.Windows.Forms.Label()
        Me.lbl_valor_nro_horario = New System.Windows.Forms.Label()
        Me.lbl_nombre_turno = New System.Windows.Forms.Label()
        Me.lbl_mensaje = New System.Windows.Forms.Label()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.txt_box_nro_horario = New System.Windows.Forms.TextBox()
        Me.lbl_nro_horario = New System.Windows.Forms.Label()
        Me.txt_box_id_turno = New System.Windows.Forms.TextBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.lbl_id_turno = New System.Windows.Forms.Label()
        Me.id_turno = New System.Windows.Forms.Label()
        Me.lbl_valor_id_turno = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(275, 294)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 20
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        Me.btn_cancelar.Visible = False
        '
        'lbl_valor_hora_fin
        '
        Me.lbl_valor_hora_fin.AutoSize = True
        Me.lbl_valor_hora_fin.Location = New System.Drawing.Point(119, 256)
        Me.lbl_valor_hora_fin.Name = "lbl_valor_hora_fin"
        Me.lbl_valor_hora_fin.Size = New System.Drawing.Size(23, 13)
        Me.lbl_valor_hora_fin.TabIndex = 19
        Me.lbl_valor_hora_fin.Text = "null"
        '
        'lbl_hora_fin
        '
        Me.lbl_hora_fin.AutoSize = True
        Me.lbl_hora_fin.Location = New System.Drawing.Point(17, 256)
        Me.lbl_hora_fin.Name = "lbl_hora_fin"
        Me.lbl_hora_fin.Size = New System.Drawing.Size(65, 13)
        Me.lbl_hora_fin.TabIndex = 18
        Me.lbl_hora_fin.Text = "Hora de Fin:"
        '
        'lbl_valor_hora_inicio
        '
        Me.lbl_valor_hora_inicio.AutoSize = True
        Me.lbl_valor_hora_inicio.Location = New System.Drawing.Point(119, 223)
        Me.lbl_valor_hora_inicio.Name = "lbl_valor_hora_inicio"
        Me.lbl_valor_hora_inicio.Size = New System.Drawing.Size(23, 13)
        Me.lbl_valor_hora_inicio.TabIndex = 17
        Me.lbl_valor_hora_inicio.Text = "null"
        '
        'lbl_hora_inicio
        '
        Me.lbl_hora_inicio.AutoSize = True
        Me.lbl_hora_inicio.Location = New System.Drawing.Point(17, 223)
        Me.lbl_hora_inicio.Name = "lbl_hora_inicio"
        Me.lbl_hora_inicio.Size = New System.Drawing.Size(76, 13)
        Me.lbl_hora_inicio.TabIndex = 16
        Me.lbl_hora_inicio.Text = "Hora de Inicio:"
        '
        'lbl_valor_nro_horario
        '
        Me.lbl_valor_nro_horario.AutoSize = True
        Me.lbl_valor_nro_horario.Location = New System.Drawing.Point(119, 197)
        Me.lbl_valor_nro_horario.Name = "lbl_valor_nro_horario"
        Me.lbl_valor_nro_horario.Size = New System.Drawing.Size(23, 13)
        Me.lbl_valor_nro_horario.TabIndex = 15
        Me.lbl_valor_nro_horario.Text = "null"
        '
        'lbl_nombre_turno
        '
        Me.lbl_nombre_turno.AutoSize = True
        Me.lbl_nombre_turno.Location = New System.Drawing.Point(17, 197)
        Me.lbl_nombre_turno.Name = "lbl_nombre_turno"
        Me.lbl_nombre_turno.Size = New System.Drawing.Size(102, 13)
        Me.lbl_nombre_turno.TabIndex = 14
        Me.lbl_nombre_turno.Text = "Numero de Horario: "
        '
        'lbl_mensaje
        '
        Me.lbl_mensaje.AutoSize = True
        Me.lbl_mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_mensaje.Location = New System.Drawing.Point(70, 145)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(143, 17)
        Me.lbl_mensaje.TabIndex = 13
        Me.lbl_mensaje.Text = "Informacion de Turno"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(180, 294)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminar.TabIndex = 12
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'txt_box_nro_horario
        '
        Me.txt_box_nro_horario.Location = New System.Drawing.Point(139, 66)
        Me.txt_box_nro_horario.Name = "txt_box_nro_horario"
        Me.txt_box_nro_horario.Size = New System.Drawing.Size(211, 20)
        Me.txt_box_nro_horario.TabIndex = 31
        '
        'lbl_nro_horario
        '
        Me.lbl_nro_horario.AutoSize = True
        Me.lbl_nro_horario.Location = New System.Drawing.Point(17, 69)
        Me.lbl_nro_horario.Name = "lbl_nro_horario"
        Me.lbl_nro_horario.Size = New System.Drawing.Size(96, 13)
        Me.lbl_nro_horario.TabIndex = 30
        Me.lbl_nro_horario.Text = "Numero de Horario"
        '
        'txt_box_id_turno
        '
        Me.txt_box_id_turno.Location = New System.Drawing.Point(139, 31)
        Me.txt_box_id_turno.Name = "txt_box_id_turno"
        Me.txt_box_id_turno.Size = New System.Drawing.Size(211, 20)
        Me.txt_box_id_turno.TabIndex = 29
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(248, 105)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(102, 23)
        Me.btn_buscar.TabIndex = 28
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'lbl_id_turno
        '
        Me.lbl_id_turno.AutoSize = True
        Me.lbl_id_turno.Location = New System.Drawing.Point(14, 34)
        Me.lbl_id_turno.Name = "lbl_id_turno"
        Me.lbl_id_turno.Size = New System.Drawing.Size(119, 13)
        Me.lbl_id_turno.TabIndex = 27
        Me.lbl_id_turno.Text = "Identificacion de  Turno"
        '
        'id_turno
        '
        Me.id_turno.AutoSize = True
        Me.id_turno.Location = New System.Drawing.Point(17, 168)
        Me.id_turno.Name = "id_turno"
        Me.id_turno.Size = New System.Drawing.Size(65, 13)
        Me.id_turno.TabIndex = 32
        Me.id_turno.Text = "Id de Turno:"
        '
        'lbl_valor_id_turno
        '
        Me.lbl_valor_id_turno.AutoSize = True
        Me.lbl_valor_id_turno.Location = New System.Drawing.Point(122, 167)
        Me.lbl_valor_id_turno.Name = "lbl_valor_id_turno"
        Me.lbl_valor_id_turno.Size = New System.Drawing.Size(23, 13)
        Me.lbl_valor_id_turno.TabIndex = 33
        Me.lbl_valor_id_turno.Text = "null"
        '
        'Form_Eliminar_Horario_X_Turno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 398)
        Me.Controls.Add(Me.lbl_valor_id_turno)
        Me.Controls.Add(Me.id_turno)
        Me.Controls.Add(Me.txt_box_nro_horario)
        Me.Controls.Add(Me.lbl_nro_horario)
        Me.Controls.Add(Me.txt_box_id_turno)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.lbl_id_turno)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.lbl_valor_hora_fin)
        Me.Controls.Add(Me.lbl_hora_fin)
        Me.Controls.Add(Me.lbl_valor_hora_inicio)
        Me.Controls.Add(Me.lbl_hora_inicio)
        Me.Controls.Add(Me.lbl_valor_nro_horario)
        Me.Controls.Add(Me.lbl_nombre_turno)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Name = "Form_Eliminar_Horario_X_Turno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar Horario Por Turno"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cancelar As Button
    Friend WithEvents lbl_valor_hora_fin As Label
    Friend WithEvents lbl_hora_fin As Label
    Friend WithEvents lbl_valor_hora_inicio As Label
    Friend WithEvents lbl_hora_inicio As Label
    Friend WithEvents lbl_valor_nro_horario As Label
    Friend WithEvents lbl_nombre_turno As Label
    Friend WithEvents lbl_mensaje As Label
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents txt_box_nro_horario As TextBox
    Friend WithEvents lbl_nro_horario As Label
    Friend WithEvents txt_box_id_turno As TextBox
    Friend WithEvents btn_buscar As Button
    Friend WithEvents lbl_id_turno As Label
    Friend WithEvents id_turno As Label
    Friend WithEvents lbl_valor_id_turno As Label
End Class
