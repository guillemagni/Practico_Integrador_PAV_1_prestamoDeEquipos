<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Editar_Turno
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
        Me.dvg_turnos = New System.Windows.Forms.DataGridView()
        Me.id_turno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hora_inicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hora_fin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_guardar_cambios = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_box_hora_inicio = New System.Windows.Forms.TextBox()
        Me.txt_box_hora_fin = New System.Windows.Forms.TextBox()
        Me.txt_box_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_box_id_turno = New System.Windows.Forms.TextBox()
        Me.lbl_hora_inicio = New System.Windows.Forms.Label()
        Me.lbl_hora_fin = New System.Windows.Forms.Label()
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.lbl_id_turno = New System.Windows.Forms.Label()
        CType(Me.dvg_turnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dvg_turnos
        '
        Me.dvg_turnos.AllowUserToAddRows = False
        Me.dvg_turnos.AllowUserToDeleteRows = False
        Me.dvg_turnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvg_turnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_turno, Me.nombre, Me.hora_inicio, Me.hora_fin})
        Me.dvg_turnos.Location = New System.Drawing.Point(12, 154)
        Me.dvg_turnos.Name = "dvg_turnos"
        Me.dvg_turnos.Size = New System.Drawing.Size(501, 150)
        Me.dvg_turnos.TabIndex = 7
        '
        'id_turno
        '
        Me.id_turno.HeaderText = "Id"
        Me.id_turno.Name = "id_turno"
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
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
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(428, 336)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(85, 25)
        Me.btn_cancelar.TabIndex = 17
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_guardar_cambios
        '
        Me.btn_guardar_cambios.Location = New System.Drawing.Point(306, 336)
        Me.btn_guardar_cambios.Name = "btn_guardar_cambios"
        Me.btn_guardar_cambios.Size = New System.Drawing.Size(108, 25)
        Me.btn_guardar_cambios.TabIndex = 16
        Me.btn_guardar_cambios.Text = "Guardar Cambios"
        Me.btn_guardar_cambios.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_box_hora_inicio)
        Me.GroupBox1.Controls.Add(Me.txt_box_hora_fin)
        Me.GroupBox1.Controls.Add(Me.txt_box_descripcion)
        Me.GroupBox1.Controls.Add(Me.txt_box_id_turno)
        Me.GroupBox1.Controls.Add(Me.lbl_hora_inicio)
        Me.GroupBox1.Controls.Add(Me.lbl_hora_fin)
        Me.GroupBox1.Controls.Add(Me.lbl_descripcion)
        Me.GroupBox1.Controls.Add(Me.lbl_id_turno)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(501, 126)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion Turno"
        '
        'txt_box_hora_inicio
        '
        Me.txt_box_hora_inicio.Location = New System.Drawing.Point(329, 29)
        Me.txt_box_hora_inicio.Name = "txt_box_hora_inicio"
        Me.txt_box_hora_inicio.Size = New System.Drawing.Size(153, 20)
        Me.txt_box_hora_inicio.TabIndex = 7
        '
        'txt_box_hora_fin
        '
        Me.txt_box_hora_fin.Location = New System.Drawing.Point(329, 83)
        Me.txt_box_hora_fin.Name = "txt_box_hora_fin"
        Me.txt_box_hora_fin.Size = New System.Drawing.Size(153, 20)
        Me.txt_box_hora_fin.TabIndex = 6
        '
        'txt_box_descripcion
        '
        Me.txt_box_descripcion.Location = New System.Drawing.Point(99, 79)
        Me.txt_box_descripcion.Name = "txt_box_descripcion"
        Me.txt_box_descripcion.Size = New System.Drawing.Size(132, 20)
        Me.txt_box_descripcion.TabIndex = 5
        '
        'txt_box_id_turno
        '
        Me.txt_box_id_turno.Enabled = False
        Me.txt_box_id_turno.Location = New System.Drawing.Point(99, 32)
        Me.txt_box_id_turno.Name = "txt_box_id_turno"
        Me.txt_box_id_turno.Size = New System.Drawing.Size(132, 20)
        Me.txt_box_id_turno.TabIndex = 4
        '
        'lbl_hora_inicio
        '
        Me.lbl_hora_inicio.AutoSize = True
        Me.lbl_hora_inicio.Location = New System.Drawing.Point(250, 32)
        Me.lbl_hora_inicio.Name = "lbl_hora_inicio"
        Me.lbl_hora_inicio.Size = New System.Drawing.Size(73, 13)
        Me.lbl_hora_inicio.TabIndex = 3
        Me.lbl_hora_inicio.Text = "Hora de Inicio"
        '
        'lbl_hora_fin
        '
        Me.lbl_hora_fin.AutoSize = True
        Me.lbl_hora_fin.Location = New System.Drawing.Point(250, 86)
        Me.lbl_hora_fin.Name = "lbl_hora_fin"
        Me.lbl_hora_fin.Size = New System.Drawing.Size(62, 13)
        Me.lbl_hora_fin.TabIndex = 2
        Me.lbl_hora_fin.Text = "Hora de Fin"
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Location = New System.Drawing.Point(29, 86)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbl_descripcion.TabIndex = 1
        Me.lbl_descripcion.Text = "Descripcion"
        '
        'lbl_id_turno
        '
        Me.lbl_id_turno.AutoSize = True
        Me.lbl_id_turno.Location = New System.Drawing.Point(29, 39)
        Me.lbl_id_turno.Name = "lbl_id_turno"
        Me.lbl_id_turno.Size = New System.Drawing.Size(47, 13)
        Me.lbl_id_turno.TabIndex = 0
        Me.lbl_id_turno.Text = "Id Turno"
        '
        'Form_Editar_Turno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 396)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_guardar_cambios)
        Me.Controls.Add(Me.dvg_turnos)
        Me.Name = "Form_Editar_Turno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Turno"
        CType(Me.dvg_turnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dvg_turnos As DataGridView
    Friend WithEvents id_turno As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents hora_inicio As DataGridViewTextBoxColumn
    Friend WithEvents hora_fin As DataGridViewTextBoxColumn
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_guardar_cambios As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_hora_inicio As Label
    Friend WithEvents lbl_hora_fin As Label
    Friend WithEvents lbl_descripcion As Label
    Friend WithEvents lbl_id_turno As Label
    Friend WithEvents txt_box_hora_inicio As TextBox
    Friend WithEvents txt_box_hora_fin As TextBox
    Friend WithEvents txt_box_descripcion As TextBox
    Friend WithEvents txt_box_id_turno As TextBox
End Class
