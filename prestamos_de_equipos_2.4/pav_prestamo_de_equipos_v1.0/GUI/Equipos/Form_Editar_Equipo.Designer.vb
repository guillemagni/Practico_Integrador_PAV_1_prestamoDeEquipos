<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Editar_Equipo
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_box_idEquipo = New System.Windows.Forms.TextBox()
        Me.lbl_mensaje = New System.Windows.Forms.Label()
        Me.dgv_equipos = New System.Windows.Forms.DataGridView()
        Me.id_equipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_equipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion_equipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_estado_equipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_cambiar_estado = New System.Windows.Forms.Button()
        Me.btn_editar_estado_equipo = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_box_nombreEq = New System.Windows.Forms.TextBox()
        Me.txt_box_desEquipo = New System.Windows.Forms.TextBox()
        Me.txt_box_nomEstado = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgv_equipos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id del Equipo"
        '
        'txt_box_idEquipo
        '
        Me.txt_box_idEquipo.Enabled = False
        Me.txt_box_idEquipo.Location = New System.Drawing.Point(105, 26)
        Me.txt_box_idEquipo.Name = "txt_box_idEquipo"
        Me.txt_box_idEquipo.ReadOnly = True
        Me.txt_box_idEquipo.Size = New System.Drawing.Size(100, 20)
        Me.txt_box_idEquipo.TabIndex = 1
        '
        'lbl_mensaje
        '
        Me.lbl_mensaje.AutoSize = True
        Me.lbl_mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_mensaje.Location = New System.Drawing.Point(226, 125)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(152, 17)
        Me.lbl_mensaje.TabIndex = 41
        Me.lbl_mensaje.Text = "Informacion del Equipo"
        '
        'dgv_equipos
        '
        Me.dgv_equipos.AllowUserToDeleteRows = False
        Me.dgv_equipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_equipos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_equipo, Me.nombre_equipo, Me.descripcion_equipo, Me.id_estado_equipo})
        Me.dgv_equipos.Location = New System.Drawing.Point(12, 156)
        Me.dgv_equipos.Name = "dgv_equipos"
        Me.dgv_equipos.ReadOnly = True
        Me.dgv_equipos.Size = New System.Drawing.Size(573, 281)
        Me.dgv_equipos.TabIndex = 42
        '
        'id_equipo
        '
        Me.id_equipo.HeaderText = "Id"
        Me.id_equipo.Name = "id_equipo"
        Me.id_equipo.ReadOnly = True
        '
        'nombre_equipo
        '
        Me.nombre_equipo.HeaderText = "Nombre"
        Me.nombre_equipo.Name = "nombre_equipo"
        Me.nombre_equipo.ReadOnly = True
        '
        'descripcion_equipo
        '
        Me.descripcion_equipo.HeaderText = "Descripcion"
        Me.descripcion_equipo.Name = "descripcion_equipo"
        Me.descripcion_equipo.ReadOnly = True
        '
        'id_estado_equipo
        '
        Me.id_estado_equipo.HeaderText = "Estado"
        Me.id_estado_equipo.Name = "id_estado_equipo"
        Me.id_estado_equipo.ReadOnly = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(500, 454)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(85, 25)
        Me.btn_cancelar.TabIndex = 44
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_cambiar_estado
        '
        Me.btn_cambiar_estado.Location = New System.Drawing.Point(364, 454)
        Me.btn_cambiar_estado.Name = "btn_cambiar_estado"
        Me.btn_cambiar_estado.Size = New System.Drawing.Size(130, 23)
        Me.btn_cambiar_estado.TabIndex = 43
        Me.btn_cambiar_estado.Text = "Guardar Cambios"
        Me.btn_cambiar_estado.UseVisualStyleBackColor = True
        '
        'btn_editar_estado_equipo
        '
        Me.btn_editar_estado_equipo.Location = New System.Drawing.Point(12, 454)
        Me.btn_editar_estado_equipo.Name = "btn_editar_estado_equipo"
        Me.btn_editar_estado_equipo.Size = New System.Drawing.Size(93, 23)
        Me.btn_editar_estado_equipo.TabIndex = 45
        Me.btn_editar_estado_equipo.Text = "Editar Estado"
        Me.btn_editar_estado_equipo.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(232, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Nombre del Equipo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(232, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Descripción del Equipo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Estado del Equipo"
        '
        'txt_box_nombreEq
        '
        Me.txt_box_nombreEq.Location = New System.Drawing.Point(354, 26)
        Me.txt_box_nombreEq.Name = "txt_box_nombreEq"
        Me.txt_box_nombreEq.Size = New System.Drawing.Size(213, 20)
        Me.txt_box_nombreEq.TabIndex = 3
        '
        'txt_box_desEquipo
        '
        Me.txt_box_desEquipo.Location = New System.Drawing.Point(354, 66)
        Me.txt_box_desEquipo.Name = "txt_box_desEquipo"
        Me.txt_box_desEquipo.Size = New System.Drawing.Size(213, 20)
        Me.txt_box_desEquipo.TabIndex = 4
        '
        'txt_box_nomEstado
        '
        Me.txt_box_nomEstado.Enabled = False
        Me.txt_box_nomEstado.Location = New System.Drawing.Point(105, 66)
        Me.txt_box_nomEstado.Name = "txt_box_nomEstado"
        Me.txt_box_nomEstado.ReadOnly = True
        Me.txt_box_nomEstado.Size = New System.Drawing.Size(100, 20)
        Me.txt_box_nomEstado.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_box_nomEstado)
        Me.GroupBox1.Controls.Add(Me.txt_box_idEquipo)
        Me.GroupBox1.Controls.Add(Me.txt_box_desEquipo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_box_nombreEq)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(573, 111)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información seleccionada"
        '
        'Form_Editar_Equipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 489)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_editar_estado_equipo)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_cambiar_estado)
        Me.Controls.Add(Me.dgv_equipos)
        Me.Name = "Form_Editar_Equipo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Equipo"
        CType(Me.dgv_equipos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_box_idEquipo As TextBox
    Friend WithEvents lbl_mensaje As Label
    Friend WithEvents dgv_equipos As DataGridView
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_cambiar_estado As Button
    Friend WithEvents btn_editar_estado_equipo As Button
    Friend WithEvents id_equipo As DataGridViewTextBoxColumn
    Friend WithEvents nombre_equipo As DataGridViewTextBoxColumn
    Friend WithEvents descripcion_equipo As DataGridViewTextBoxColumn
    Friend WithEvents id_estado_equipo As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_box_nombreEq As TextBox
    Friend WithEvents txt_box_desEquipo As TextBox
    Friend WithEvents txt_box_nomEstado As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
