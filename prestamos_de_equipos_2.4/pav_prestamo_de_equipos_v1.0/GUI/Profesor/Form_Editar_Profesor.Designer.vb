<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Editar_Profesor
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
        Me.lbl_id_profesor = New System.Windows.Forms.Label()
        Me.txt_box_id_profesor = New System.Windows.Forms.TextBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.dgv_profesores = New System.Windows.Forms.DataGridView()
        Me.id_profesor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_estado_profesor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_mensaje = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_editar_estado_equipo = New System.Windows.Forms.Button()
        CType(Me.dgv_profesores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_id_profesor
        '
        Me.lbl_id_profesor.AutoSize = True
        Me.lbl_id_profesor.Location = New System.Drawing.Point(12, 26)
        Me.lbl_id_profesor.Name = "lbl_id_profesor"
        Me.lbl_id_profesor.Size = New System.Drawing.Size(73, 13)
        Me.lbl_id_profesor.TabIndex = 0
        Me.lbl_id_profesor.Text = "Id de Profesor"
        '
        'txt_box_id_profesor
        '
        Me.txt_box_id_profesor.Location = New System.Drawing.Point(91, 23)
        Me.txt_box_id_profesor.Name = "txt_box_id_profesor"
        Me.txt_box_id_profesor.Size = New System.Drawing.Size(202, 20)
        Me.txt_box_id_profesor.TabIndex = 1
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(299, 23)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(102, 23)
        Me.btn_buscar.TabIndex = 30
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'dgv_profesores
        '
        Me.dgv_profesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_profesores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_profesor, Me.nombre_usuario, Me.apellido_usuario, Me.id_estado_profesor})
        Me.dgv_profesores.Location = New System.Drawing.Point(24, 98)
        Me.dgv_profesores.Name = "dgv_profesores"
        Me.dgv_profesores.Size = New System.Drawing.Size(507, 145)
        Me.dgv_profesores.TabIndex = 31
        '
        'id_profesor
        '
        Me.id_profesor.HeaderText = "Id"
        Me.id_profesor.Name = "id_profesor"
        Me.id_profesor.ReadOnly = True
        '
        'nombre_usuario
        '
        Me.nombre_usuario.HeaderText = "Nombre"
        Me.nombre_usuario.Name = "nombre_usuario"
        '
        'apellido_usuario
        '
        Me.apellido_usuario.HeaderText = "Apellido"
        Me.apellido_usuario.Name = "apellido_usuario"
        '
        'id_estado_profesor
        '
        Me.id_estado_profesor.HeaderText = "Estado"
        Me.id_estado_profesor.Name = "id_estado_profesor"
        Me.id_estado_profesor.ReadOnly = True
        '
        'lbl_mensaje
        '
        Me.lbl_mensaje.AutoSize = True
        Me.lbl_mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_mensaje.Location = New System.Drawing.Point(198, 64)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(159, 17)
        Me.lbl_mensaje.TabIndex = 32
        Me.lbl_mensaje.Text = "Informacion de Profesor"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(446, 279)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(85, 25)
        Me.btn_cancelar.TabIndex = 34
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(355, 278)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(85, 25)
        Me.btn_aceptar.TabIndex = 33
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_editar_estado_equipo
        '
        Me.btn_editar_estado_equipo.Location = New System.Drawing.Point(24, 280)
        Me.btn_editar_estado_equipo.Name = "btn_editar_estado_equipo"
        Me.btn_editar_estado_equipo.Size = New System.Drawing.Size(93, 23)
        Me.btn_editar_estado_equipo.TabIndex = 46
        Me.btn_editar_estado_equipo.Text = "Editar Estado"
        Me.btn_editar_estado_equipo.UseVisualStyleBackColor = True
        '
        'Form_Editar_Profesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 338)
        Me.Controls.Add(Me.btn_editar_estado_equipo)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.Controls.Add(Me.dgv_profesores)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.txt_box_id_profesor)
        Me.Controls.Add(Me.lbl_id_profesor)
        Me.Name = "Form_Editar_Profesor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Profesor"
        CType(Me.dgv_profesores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_id_profesor As Label
    Friend WithEvents txt_box_id_profesor As TextBox
    Friend WithEvents btn_buscar As Button
    Friend WithEvents dgv_profesores As DataGridView
    Friend WithEvents lbl_mensaje As Label
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents btn_editar_estado_equipo As Button
    Friend WithEvents id_profesor As DataGridViewTextBoxColumn
    Friend WithEvents nombre_usuario As DataGridViewTextBoxColumn
    Friend WithEvents apellido_usuario As DataGridViewTextBoxColumn
    Friend WithEvents id_estado_profesor As DataGridViewTextBoxColumn
End Class
