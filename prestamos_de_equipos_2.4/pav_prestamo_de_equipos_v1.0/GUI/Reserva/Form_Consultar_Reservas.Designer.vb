<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Consultar_Reservas
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
        Me.btn_all_reservas = New System.Windows.Forms.Button()
        Me.lbl_id_reserva = New System.Windows.Forms.Label()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_box_id_reserva = New System.Windows.Forms.TextBox()
        Me.btn_reservas_getday = New System.Windows.Forms.Button()
        Me.lbl_mensaje = New System.Windows.Forms.Label()
        Me.dgv_reserva = New System.Windows.Forms.DataGridView()
        Me.id_reserva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_reserva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nro_curso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.letra_curso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nro_horario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_turno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_profesor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_equipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        CType(Me.dgv_reserva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_all_reservas
        '
        Me.btn_all_reservas.Location = New System.Drawing.Point(44, 77)
        Me.btn_all_reservas.Name = "btn_all_reservas"
        Me.btn_all_reservas.Size = New System.Drawing.Size(184, 23)
        Me.btn_all_reservas.TabIndex = 0
        Me.btn_all_reservas.Text = "Mostrar Todas las Reservas"
        Me.btn_all_reservas.UseVisualStyleBackColor = True
        '
        'lbl_id_reserva
        '
        Me.lbl_id_reserva.AutoSize = True
        Me.lbl_id_reserva.Location = New System.Drawing.Point(41, 38)
        Me.lbl_id_reserva.Name = "lbl_id_reserva"
        Me.lbl_id_reserva.Size = New System.Drawing.Size(128, 13)
        Me.lbl_id_reserva.TabIndex = 4
        Me.lbl_id_reserva.Text = "Identificación de Reserva"
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(387, 34)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(95, 23)
        Me.btn_buscar.TabIndex = 3
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'txt_box_id_reserva
        '
        Me.txt_box_id_reserva.Location = New System.Drawing.Point(192, 36)
        Me.txt_box_id_reserva.Name = "txt_box_id_reserva"
        Me.txt_box_id_reserva.Size = New System.Drawing.Size(173, 20)
        Me.txt_box_id_reserva.TabIndex = 5
        '
        'btn_reservas_getday
        '
        Me.btn_reservas_getday.Location = New System.Drawing.Point(255, 77)
        Me.btn_reservas_getday.Name = "btn_reservas_getday"
        Me.btn_reservas_getday.Size = New System.Drawing.Size(167, 23)
        Me.btn_reservas_getday.TabIndex = 6
        Me.btn_reservas_getday.Text = "Mostrar Reservas del Dia"
        Me.btn_reservas_getday.UseVisualStyleBackColor = True
        '
        'lbl_mensaje
        '
        Me.lbl_mensaje.AutoSize = True
        Me.lbl_mensaje.Location = New System.Drawing.Point(498, 38)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(213, 13)
        Me.lbl_mensaje.TabIndex = 7
        Me.lbl_mensaje.Text = "Ingrese el id de la reseva que desea buscar"
        '
        'dgv_reserva
        '
        Me.dgv_reserva.AllowUserToDeleteRows = False
        Me.dgv_reserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_reserva.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_reserva, Me.fecha_pedido, Me.fecha_reserva, Me.nro_curso, Me.letra_curso, Me.nro_horario, Me.id_turno, Me.nom_usuario, Me.id_profesor, Me.id_equipo})
        Me.dgv_reserva.Location = New System.Drawing.Point(44, 124)
        Me.dgv_reserva.Name = "dgv_reserva"
        Me.dgv_reserva.Size = New System.Drawing.Size(1046, 517)
        Me.dgv_reserva.TabIndex = 8
        '
        'id_reserva
        '
        Me.id_reserva.HeaderText = "Id Reserva"
        Me.id_reserva.Name = "id_reserva"
        Me.id_reserva.ReadOnly = True
        '
        'fecha_pedido
        '
        Me.fecha_pedido.HeaderText = "Fecha de Pedido"
        Me.fecha_pedido.Name = "fecha_pedido"
        Me.fecha_pedido.ReadOnly = True
        '
        'fecha_reserva
        '
        Me.fecha_reserva.HeaderText = "Fecha de Reserva"
        Me.fecha_reserva.Name = "fecha_reserva"
        Me.fecha_reserva.ReadOnly = True
        '
        'nro_curso
        '
        Me.nro_curso.HeaderText = "Número de Curso"
        Me.nro_curso.Name = "nro_curso"
        Me.nro_curso.ReadOnly = True
        '
        'letra_curso
        '
        Me.letra_curso.HeaderText = "Característica de Curso"
        Me.letra_curso.Name = "letra_curso"
        Me.letra_curso.ReadOnly = True
        '
        'nro_horario
        '
        Me.nro_horario.HeaderText = "Horario"
        Me.nro_horario.Name = "nro_horario"
        Me.nro_horario.ReadOnly = True
        '
        'id_turno
        '
        Me.id_turno.HeaderText = "Turno"
        Me.id_turno.Name = "id_turno"
        Me.id_turno.ReadOnly = True
        '
        'nom_usuario
        '
        Me.nom_usuario.HeaderText = "Usuario"
        Me.nom_usuario.Name = "nom_usuario"
        Me.nom_usuario.ReadOnly = True
        '
        'id_profesor
        '
        Me.id_profesor.HeaderText = "Profesor"
        Me.id_profesor.Name = "id_profesor"
        Me.id_profesor.ReadOnly = True
        '
        'id_equipo
        '
        Me.id_equipo.HeaderText = "Equipo"
        Me.id_equipo.Name = "id_equipo"
        Me.id_equipo.ReadOnly = True
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Location = New System.Drawing.Point(1015, 660)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cerrar.TabIndex = 9
        Me.btn_cerrar.Text = "Cerrar"
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'Form_Consultar_Reservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 695)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.dgv_reserva)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.Controls.Add(Me.btn_reservas_getday)
        Me.Controls.Add(Me.txt_box_id_reserva)
        Me.Controls.Add(Me.lbl_id_reserva)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_all_reservas)
        Me.Name = "Form_Consultar_Reservas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Reservas"
        CType(Me.dgv_reserva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_all_reservas As Button
    Friend WithEvents lbl_id_reserva As Label
    Friend WithEvents btn_buscar As Button
    Friend WithEvents txt_box_id_reserva As TextBox
    Friend WithEvents btn_reservas_getday As Button
    Friend WithEvents lbl_mensaje As Label
    Friend WithEvents dgv_reserva As DataGridView
    Friend WithEvents id_reserva As DataGridViewTextBoxColumn
    Friend WithEvents fecha_pedido As DataGridViewTextBoxColumn
    Friend WithEvents fecha_reserva As DataGridViewTextBoxColumn
    Friend WithEvents nro_curso As DataGridViewTextBoxColumn
    Friend WithEvents letra_curso As DataGridViewTextBoxColumn
    Friend WithEvents nro_horario As DataGridViewTextBoxColumn
    Friend WithEvents id_turno As DataGridViewTextBoxColumn
    Friend WithEvents nom_usuario As DataGridViewTextBoxColumn
    Friend WithEvents id_profesor As DataGridViewTextBoxColumn
    Friend WithEvents id_equipo As DataGridViewTextBoxColumn
    Friend WithEvents btn_cerrar As Button
End Class
