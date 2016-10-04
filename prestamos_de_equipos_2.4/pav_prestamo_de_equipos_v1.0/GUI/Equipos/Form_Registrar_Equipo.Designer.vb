<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Registrar_Equipo
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
        Me.lbl_id_equipo = New System.Windows.Forms.Label()
        Me.lbl_nombre_equipo = New System.Windows.Forms.Label()
        Me.lbl_descripcion_equipo = New System.Windows.Forms.Label()
        Me.lbl_id_estado_equipo = New System.Windows.Forms.Label()
        Me.txt_box_id_equipo = New System.Windows.Forms.TextBox()
        Me.txt_box_nombre_equipo = New System.Windows.Forms.TextBox()
        Me.txt_box_descripcion_equipo = New System.Windows.Forms.TextBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.lbl_mensaje = New System.Windows.Forms.Label()
        Me.comboBox_Estado = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lbl_id_equipo
        '
        Me.lbl_id_equipo.AutoSize = True
        Me.lbl_id_equipo.Location = New System.Drawing.Point(46, 86)
        Me.lbl_id_equipo.Name = "lbl_id_equipo"
        Me.lbl_id_equipo.Size = New System.Drawing.Size(115, 13)
        Me.lbl_id_equipo.TabIndex = 0
        Me.lbl_id_equipo.Text = "Identifación del Equipo"
        '
        'lbl_nombre_equipo
        '
        Me.lbl_nombre_equipo.AutoSize = True
        Me.lbl_nombre_equipo.Location = New System.Drawing.Point(46, 133)
        Me.lbl_nombre_equipo.Name = "lbl_nombre_equipo"
        Me.lbl_nombre_equipo.Size = New System.Drawing.Size(97, 13)
        Me.lbl_nombre_equipo.TabIndex = 1
        Me.lbl_nombre_equipo.Text = "Nombre del Equipo"
        '
        'lbl_descripcion_equipo
        '
        Me.lbl_descripcion_equipo.AutoSize = True
        Me.lbl_descripcion_equipo.Location = New System.Drawing.Point(46, 177)
        Me.lbl_descripcion_equipo.Name = "lbl_descripcion_equipo"
        Me.lbl_descripcion_equipo.Size = New System.Drawing.Size(116, 13)
        Me.lbl_descripcion_equipo.TabIndex = 2
        Me.lbl_descripcion_equipo.Text = "Descripción del Equipo"
        '
        'lbl_id_estado_equipo
        '
        Me.lbl_id_estado_equipo.AutoSize = True
        Me.lbl_id_estado_equipo.Location = New System.Drawing.Point(46, 222)
        Me.lbl_id_estado_equipo.Name = "lbl_id_estado_equipo"
        Me.lbl_id_estado_equipo.Size = New System.Drawing.Size(93, 13)
        Me.lbl_id_estado_equipo.TabIndex = 3
        Me.lbl_id_estado_equipo.Text = "Estado del Equipo"
        '
        'txt_box_id_equipo
        '
        Me.txt_box_id_equipo.Location = New System.Drawing.Point(211, 86)
        Me.txt_box_id_equipo.Name = "txt_box_id_equipo"
        Me.txt_box_id_equipo.Size = New System.Drawing.Size(192, 20)
        Me.txt_box_id_equipo.TabIndex = 4
        '
        'txt_box_nombre_equipo
        '
        Me.txt_box_nombre_equipo.Location = New System.Drawing.Point(211, 133)
        Me.txt_box_nombre_equipo.Name = "txt_box_nombre_equipo"
        Me.txt_box_nombre_equipo.Size = New System.Drawing.Size(192, 20)
        Me.txt_box_nombre_equipo.TabIndex = 5
        '
        'txt_box_descripcion_equipo
        '
        Me.txt_box_descripcion_equipo.Location = New System.Drawing.Point(211, 177)
        Me.txt_box_descripcion_equipo.Name = "txt_box_descripcion_equipo"
        Me.txt_box_descripcion_equipo.Size = New System.Drawing.Size(192, 20)
        Me.txt_box_descripcion_equipo.TabIndex = 6
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(318, 285)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(85, 25)
        Me.btn_cancelar.TabIndex = 30
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(219, 285)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(85, 25)
        Me.btn_aceptar.TabIndex = 29
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'lbl_mensaje
        '
        Me.lbl_mensaje.AutoSize = True
        Me.lbl_mensaje.Location = New System.Drawing.Point(137, 29)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(142, 13)
        Me.lbl_mensaje.TabIndex = 31
        Me.lbl_mensaje.Text = "Ingrese los Datos del Equipo"
        '
        'comboBox_Estado
        '
        Me.comboBox_Estado.FormattingEnabled = True
        Me.comboBox_Estado.Location = New System.Drawing.Point(211, 222)
        Me.comboBox_Estado.Name = "comboBox_Estado"
        Me.comboBox_Estado.Size = New System.Drawing.Size(121, 21)
        Me.comboBox_Estado.TabIndex = 32
        '
        'Form_Registrar_Equipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 361)
        Me.Controls.Add(Me.comboBox_Estado)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.txt_box_descripcion_equipo)
        Me.Controls.Add(Me.txt_box_nombre_equipo)
        Me.Controls.Add(Me.txt_box_id_equipo)
        Me.Controls.Add(Me.lbl_id_estado_equipo)
        Me.Controls.Add(Me.lbl_descripcion_equipo)
        Me.Controls.Add(Me.lbl_nombre_equipo)
        Me.Controls.Add(Me.lbl_id_equipo)
        Me.Name = "Form_Registrar_Equipo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Equipo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_id_equipo As Label
    Friend WithEvents lbl_nombre_equipo As Label
    Friend WithEvents lbl_descripcion_equipo As Label
    Friend WithEvents lbl_id_estado_equipo As Label
    Friend WithEvents txt_box_id_equipo As TextBox
    Friend WithEvents txt_box_nombre_equipo As TextBox
    Friend WithEvents txt_box_descripcion_equipo As TextBox
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents lbl_mensaje As Label
    Friend WithEvents comboBox_Estado As ComboBox
End Class
