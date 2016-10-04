<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Consultar_Horario_X_Turno
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
        Me.lbl_Turno = New System.Windows.Forms.Label()
        Me.cb_idTurno = New System.Windows.Forms.ComboBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.lbl_mensaje = New System.Windows.Forms.Label()
        Me.dgv_hpt = New System.Windows.Forms.DataGridView()
        Me.id_turno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nro_horario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hora_inicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hora_fin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_hpt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Turno
        '
        Me.lbl_Turno.AutoSize = True
        Me.lbl_Turno.Location = New System.Drawing.Point(12, 16)
        Me.lbl_Turno.Name = "lbl_Turno"
        Me.lbl_Turno.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Turno.TabIndex = 0
        Me.lbl_Turno.Text = "Turno"
        '
        'cb_idTurno
        '
        Me.cb_idTurno.FormattingEnabled = True
        Me.cb_idTurno.Location = New System.Drawing.Point(69, 13)
        Me.cb_idTurno.Name = "cb_idTurno"
        Me.cb_idTurno.Size = New System.Drawing.Size(204, 21)
        Me.cb_idTurno.TabIndex = 1
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(308, 13)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(148, 21)
        Me.btn_buscar.TabIndex = 2
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'lbl_mensaje
        '
        Me.lbl_mensaje.AutoSize = True
        Me.lbl_mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_mensaje.Location = New System.Drawing.Point(176, 52)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(143, 17)
        Me.lbl_mensaje.TabIndex = 24
        Me.lbl_mensaje.Text = "Informacion de Turno"
        '
        'dgv_hpt
        '
        Me.dgv_hpt.AllowUserToAddRows = False
        Me.dgv_hpt.AllowUserToDeleteRows = False
        Me.dgv_hpt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_hpt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_turno, Me.nro_horario, Me.hora_inicio, Me.hora_fin})
        Me.dgv_hpt.Location = New System.Drawing.Point(12, 84)
        Me.dgv_hpt.Name = "dgv_hpt"
        Me.dgv_hpt.Size = New System.Drawing.Size(444, 285)
        Me.dgv_hpt.TabIndex = 23
        '
        'id_turno
        '
        Me.id_turno.HeaderText = "Id Turno"
        Me.id_turno.Name = "id_turno"
        Me.id_turno.ReadOnly = True
        '
        'nro_horario
        '
        Me.nro_horario.HeaderText = "Número de Horario"
        Me.nro_horario.Name = "nro_horario"
        Me.nro_horario.ReadOnly = True
        '
        'hora_inicio
        '
        Me.hora_inicio.HeaderText = "Hora de Inicio"
        Me.hora_inicio.Name = "hora_inicio"
        '
        'hora_fin
        '
        Me.hora_fin.HeaderText = "Hora de Fin"
        Me.hora_fin.Name = "hora_fin"
        '
        'Form_Consultar_Horario_X_Turno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 381)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.Controls.Add(Me.dgv_hpt)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.cb_idTurno)
        Me.Controls.Add(Me.lbl_Turno)
        Me.Name = "Form_Consultar_Horario_X_Turno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar un Horario por su Turno"
        CType(Me.dgv_hpt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Turno As Label
    Friend WithEvents cb_idTurno As ComboBox
    Friend WithEvents btn_buscar As Button
    Friend WithEvents lbl_mensaje As Label
    Friend WithEvents dgv_hpt As DataGridView
    Friend WithEvents id_turno As DataGridViewTextBoxColumn
    Friend WithEvents nro_horario As DataGridViewTextBoxColumn
    Friend WithEvents hora_inicio As DataGridViewTextBoxColumn
    Friend WithEvents hora_fin As DataGridViewTextBoxColumn
End Class
