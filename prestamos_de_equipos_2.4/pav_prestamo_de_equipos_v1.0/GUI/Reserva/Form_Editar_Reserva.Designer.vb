<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Editar_Reserva
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
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.lbl_id_reserva = New System.Windows.Forms.Label()
        Me.dud_id_reserva = New System.Windows.Forms.DomainUpDown()
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
        Me.lbl_aceptar = New System.Windows.Forms.Button()
        Me.lbl_cancelar = New System.Windows.Forms.Button()
        Me.lbl_mensaje = New System.Windows.Forms.Label()
        CType(Me.dgv_reserva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(349, 18)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(95, 23)
        Me.btn_buscar.TabIndex = 0
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'lbl_id_reserva
        '
        Me.lbl_id_reserva.AutoSize = True
        Me.lbl_id_reserva.Location = New System.Drawing.Point(12, 20)
        Me.lbl_id_reserva.Name = "lbl_id_reserva"
        Me.lbl_id_reserva.Size = New System.Drawing.Size(128, 13)
        Me.lbl_id_reserva.TabIndex = 1
        Me.lbl_id_reserva.Text = "Identificación de Reserva"
        '
        'dud_id_reserva
        '
        Me.dud_id_reserva.Location = New System.Drawing.Point(166, 18)
        Me.dud_id_reserva.Name = "dud_id_reserva"
        Me.dud_id_reserva.Size = New System.Drawing.Size(162, 20)
        Me.dud_id_reserva.TabIndex = 2
        '
        'dgv_reserva
        '
        Me.dgv_reserva.AllowUserToDeleteRows = False
        Me.dgv_reserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_reserva.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_reserva, Me.fecha_pedido, Me.fecha_reserva, Me.nro_curso, Me.letra_curso, Me.nro_horario, Me.id_turno, Me.nom_usuario, Me.id_profesor, Me.id_equipo})
        Me.dgv_reserva.Location = New System.Drawing.Point(15, 98)
        Me.dgv_reserva.Name = "dgv_reserva"
        Me.dgv_reserva.Size = New System.Drawing.Size(1046, 192)
        Me.dgv_reserva.TabIndex = 3
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
        'lbl_aceptar
        '
        Me.lbl_aceptar.Location = New System.Drawing.Point(875, 311)
        Me.lbl_aceptar.Name = "lbl_aceptar"
        Me.lbl_aceptar.Size = New System.Drawing.Size(92, 23)
        Me.lbl_aceptar.TabIndex = 4
        Me.lbl_aceptar.Text = "Aceptar"
        Me.lbl_aceptar.UseVisualStyleBackColor = True
        '
        'lbl_cancelar
        '
        Me.lbl_cancelar.Location = New System.Drawing.Point(973, 311)
        Me.lbl_cancelar.Name = "lbl_cancelar"
        Me.lbl_cancelar.Size = New System.Drawing.Size(88, 23)
        Me.lbl_cancelar.TabIndex = 5
        Me.lbl_cancelar.Text = "Cancelar"
        Me.lbl_cancelar.UseVisualStyleBackColor = True
        '
        'lbl_mensaje
        '
        Me.lbl_mensaje.AutoSize = True
        Me.lbl_mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_mensaje.Location = New System.Drawing.Point(170, 56)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(158, 17)
        Me.lbl_mensaje.TabIndex = 6
        Me.lbl_mensaje.Text = "Informacion de Reserva"
        '
        'Form_Editar_Reserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1073, 346)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.Controls.Add(Me.lbl_cancelar)
        Me.Controls.Add(Me.lbl_aceptar)
        Me.Controls.Add(Me.dgv_reserva)
        Me.Controls.Add(Me.dud_id_reserva)
        Me.Controls.Add(Me.lbl_id_reserva)
        Me.Controls.Add(Me.btn_buscar)
        Me.Name = "Form_Editar_Reserva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Reserva"
        CType(Me.dgv_reserva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_buscar As Button
    Friend WithEvents lbl_id_reserva As Label
    Friend WithEvents dud_id_reserva As DomainUpDown
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
    Friend WithEvents lbl_aceptar As Button
    Friend WithEvents lbl_cancelar As Button
    Friend WithEvents lbl_mensaje As Label
End Class
