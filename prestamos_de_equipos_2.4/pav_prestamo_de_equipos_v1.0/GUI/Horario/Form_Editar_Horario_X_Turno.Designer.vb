<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Editar_Horario_X_Turno
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
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.lbl_mensaje = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id_turno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nro_horario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hora_inicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hora_fin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_box_id_turno = New System.Windows.Forms.TextBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.lbl_id_turno = New System.Windows.Forms.Label()
        Me.lbl_nro_horario = New System.Windows.Forms.Label()
        Me.txt_box_nro_horario = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(400, 361)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(85, 25)
        Me.btn_cancelar.TabIndex = 24
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(301, 361)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(85, 25)
        Me.btn_aceptar.TabIndex = 23
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'lbl_mensaje
        '
        Me.lbl_mensaje.AutoSize = True
        Me.lbl_mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_mensaje.Location = New System.Drawing.Point(191, 119)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(143, 17)
        Me.lbl_mensaje.TabIndex = 22
        Me.lbl_mensaje.Text = "Informacion de Turno"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_turno, Me.nro_horario, Me.hora_inicio, Me.hora_fin})
        Me.DataGridView1.Location = New System.Drawing.Point(41, 155)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(444, 186)
        Me.DataGridView1.TabIndex = 21
        '
        'id_turno
        '
        Me.id_turno.HeaderText = "Id Turno"
        Me.id_turno.Name = "id_turno"
        '
        'nro_horario
        '
        Me.nro_horario.HeaderText = "Numero de Horario"
        Me.nro_horario.Name = "nro_horario"
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
        'txt_box_id_turno
        '
        Me.txt_box_id_turno.Location = New System.Drawing.Point(163, 29)
        Me.txt_box_id_turno.Name = "txt_box_id_turno"
        Me.txt_box_id_turno.Size = New System.Drawing.Size(211, 20)
        Me.txt_box_id_turno.TabIndex = 20
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(383, 64)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(102, 23)
        Me.btn_buscar.TabIndex = 19
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'lbl_id_turno
        '
        Me.lbl_id_turno.AutoSize = True
        Me.lbl_id_turno.Location = New System.Drawing.Point(38, 32)
        Me.lbl_id_turno.Name = "lbl_id_turno"
        Me.lbl_id_turno.Size = New System.Drawing.Size(119, 13)
        Me.lbl_id_turno.TabIndex = 18
        Me.lbl_id_turno.Text = "Identificacion de  Turno"
        '
        'lbl_nro_horario
        '
        Me.lbl_nro_horario.AutoSize = True
        Me.lbl_nro_horario.Location = New System.Drawing.Point(41, 67)
        Me.lbl_nro_horario.Name = "lbl_nro_horario"
        Me.lbl_nro_horario.Size = New System.Drawing.Size(96, 13)
        Me.lbl_nro_horario.TabIndex = 25
        Me.lbl_nro_horario.Text = "Numero de Horario"
        '
        'txt_box_nro_horario
        '
        Me.txt_box_nro_horario.Location = New System.Drawing.Point(163, 64)
        Me.txt_box_nro_horario.Name = "txt_box_nro_horario"
        Me.txt_box_nro_horario.Size = New System.Drawing.Size(211, 20)
        Me.txt_box_nro_horario.TabIndex = 26
        '
        'Form_Editar_Horario_X_Turno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 439)
        Me.Controls.Add(Me.txt_box_nro_horario)
        Me.Controls.Add(Me.lbl_nro_horario)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txt_box_id_turno)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.lbl_id_turno)
        Me.Name = "Form_Editar_Horario_X_Turno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Horario Por Turno"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents lbl_mensaje As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents id_turno As DataGridViewTextBoxColumn
    Friend WithEvents nro_horario As DataGridViewTextBoxColumn
    Friend WithEvents hora_inicio As DataGridViewTextBoxColumn
    Friend WithEvents hora_fin As DataGridViewTextBoxColumn
    Friend WithEvents txt_box_id_turno As TextBox
    Friend WithEvents btn_buscar As Button
    Friend WithEvents lbl_id_turno As Label
    Friend WithEvents lbl_nro_horario As Label
    Friend WithEvents txt_box_nro_horario As TextBox
End Class
