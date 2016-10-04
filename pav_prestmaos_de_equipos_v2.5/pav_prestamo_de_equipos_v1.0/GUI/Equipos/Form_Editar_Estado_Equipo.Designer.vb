<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Editar_Estado_Equipo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbl_mensaje = New System.Windows.Forms.Label()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_box_idEquipo = New System.Windows.Forms.TextBox()
        Me.lbl_IdEquipo = New System.Windows.Forms.Label()
        Me.lbl_id_estado_equipo = New System.Windows.Forms.Label()
        Me.lbl_estado_actual_equipo = New System.Windows.Forms.Label()
        Me.lbl_nuevo_estado_equipo = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_cambiar_estado = New System.Windows.Forms.Button()
        Me.txb_descripEquipo = New System.Windows.Forms.TextBox()
        Me.txb_nomEquipo = New System.Windows.Forms.TextBox()
        Me.lbl_nomProfe = New System.Windows.Forms.Label()
        Me.lbl_apeProfe = New System.Windows.Forms.Label()
        Me.comboBox_Estado = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lbl_mensaje
        '
        Me.lbl_mensaje.AutoSize = True
        Me.lbl_mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_mensaje.Location = New System.Drawing.Point(207, 73)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(152, 17)
        Me.lbl_mensaje.TabIndex = 45
        Me.lbl_mensaje.Text = "Informacion del Equipo"
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(408, 50)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(102, 23)
        Me.btn_buscar.TabIndex = 44
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'txt_box_idEquipo
        '
        Me.txt_box_idEquipo.Location = New System.Drawing.Point(173, 50)
        Me.txt_box_idEquipo.Name = "txt_box_idEquipo"
        Me.txt_box_idEquipo.Size = New System.Drawing.Size(212, 20)
        Me.txt_box_idEquipo.TabIndex = 43
        '
        'lbl_IdEquipo
        '
        Me.lbl_IdEquipo.AutoSize = True
        Me.lbl_IdEquipo.Location = New System.Drawing.Point(86, 53)
        Me.lbl_IdEquipo.Name = "lbl_IdEquipo"
        Me.lbl_IdEquipo.Size = New System.Drawing.Size(69, 13)
        Me.lbl_IdEquipo.TabIndex = 42
        Me.lbl_IdEquipo.Text = "Id del Equipo"
        '
        'lbl_id_estado_equipo
        '
        Me.lbl_id_estado_equipo.AutoSize = True
        Me.lbl_id_estado_equipo.Location = New System.Drawing.Point(12, 175)
        Me.lbl_id_estado_equipo.Name = "lbl_id_estado_equipo"
        Me.lbl_id_estado_equipo.Size = New System.Drawing.Size(129, 13)
        Me.lbl_id_estado_equipo.TabIndex = 50
        Me.lbl_id_estado_equipo.Text = "Estado Actual del Equipo:"
        '
        'lbl_estado_actual_equipo
        '
        Me.lbl_estado_actual_equipo.AutoSize = True
        Me.lbl_estado_actual_equipo.Location = New System.Drawing.Point(170, 175)
        Me.lbl_estado_actual_equipo.Name = "lbl_estado_actual_equipo"
        Me.lbl_estado_actual_equipo.Size = New System.Drawing.Size(23, 13)
        Me.lbl_estado_actual_equipo.TabIndex = 51
        Me.lbl_estado_actual_equipo.Text = "null"
        '
        'lbl_nuevo_estado_equipo
        '
        Me.lbl_nuevo_estado_equipo.AutoSize = True
        Me.lbl_nuevo_estado_equipo.Location = New System.Drawing.Point(12, 211)
        Me.lbl_nuevo_estado_equipo.Name = "lbl_nuevo_estado_equipo"
        Me.lbl_nuevo_estado_equipo.Size = New System.Drawing.Size(128, 13)
        Me.lbl_nuevo_estado_equipo.TabIndex = 52
        Me.lbl_nuevo_estado_equipo.Text = "Nuevo Estado del Equipo"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(425, 261)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(85, 25)
        Me.btn_cancelar.TabIndex = 55
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_cambiar_estado
        '
        Me.btn_cambiar_estado.Location = New System.Drawing.Point(274, 261)
        Me.btn_cambiar_estado.Name = "btn_cambiar_estado"
        Me.btn_cambiar_estado.Size = New System.Drawing.Size(130, 23)
        Me.btn_cambiar_estado.TabIndex = 54
        Me.btn_cambiar_estado.Text = "Guardar Cambios"
        Me.btn_cambiar_estado.UseVisualStyleBackColor = True
        '
        'txb_descripEquipo
        '
        Me.txb_descripEquipo.Enabled = False
        Me.txb_descripEquipo.Location = New System.Drawing.Point(173, 144)
        Me.txb_descripEquipo.Name = "txb_descripEquipo"
        Me.txb_descripEquipo.Size = New System.Drawing.Size(167, 20)
        Me.txb_descripEquipo.TabIndex = 59
        '
        'txb_nomEquipo
        '
        Me.txb_nomEquipo.Enabled = False
        Me.txb_nomEquipo.Location = New System.Drawing.Point(173, 110)
        Me.txb_nomEquipo.Name = "txb_nomEquipo"
        Me.txb_nomEquipo.Size = New System.Drawing.Size(167, 20)
        Me.txb_nomEquipo.TabIndex = 58
        '
        'lbl_nomProfe
        '
        Me.lbl_nomProfe.AutoSize = True
        Me.lbl_nomProfe.Location = New System.Drawing.Point(12, 110)
        Me.lbl_nomProfe.Name = "lbl_nomProfe"
        Me.lbl_nomProfe.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nomProfe.TabIndex = 57
        Me.lbl_nomProfe.Text = "Nombre"
        '
        'lbl_apeProfe
        '
        Me.lbl_apeProfe.AutoSize = True
        Me.lbl_apeProfe.Location = New System.Drawing.Point(12, 147)
        Me.lbl_apeProfe.Name = "lbl_apeProfe"
        Me.lbl_apeProfe.Size = New System.Drawing.Size(63, 13)
        Me.lbl_apeProfe.TabIndex = 56
        Me.lbl_apeProfe.Text = "Descripción"
        '
        'comboBox_Estado
        '
        Me.comboBox_Estado.FormattingEnabled = True
        Me.comboBox_Estado.Location = New System.Drawing.Point(173, 211)
        Me.comboBox_Estado.Name = "comboBox_Estado"
        Me.comboBox_Estado.Size = New System.Drawing.Size(167, 21)
        Me.comboBox_Estado.TabIndex = 60
        '
        'Form_Editar_Estado_Equipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 344)
        Me.Controls.Add(Me.comboBox_Estado)
        Me.Controls.Add(Me.txb_descripEquipo)
        Me.Controls.Add(Me.txb_nomEquipo)
        Me.Controls.Add(Me.lbl_nomProfe)
        Me.Controls.Add(Me.lbl_apeProfe)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_cambiar_estado)
        Me.Controls.Add(Me.lbl_nuevo_estado_equipo)
        Me.Controls.Add(Me.lbl_estado_actual_equipo)
        Me.Controls.Add(Me.lbl_id_estado_equipo)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.txt_box_idEquipo)
        Me.Controls.Add(Me.lbl_IdEquipo)
        Me.Name = "Form_Editar_Estado_Equipo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Estado Equipo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_mensaje As Label
    Friend WithEvents btn_buscar As Button
    Friend WithEvents txt_box_idEquipo As TextBox
    Friend WithEvents lbl_IdEquipo As Label
    Friend WithEvents lbl_id_estado_equipo As Label
    Friend WithEvents lbl_estado_actual_equipo As Label
    Friend WithEvents lbl_nuevo_estado_equipo As Label
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_cambiar_estado As Button
    Friend WithEvents txb_descripEquipo As TextBox
    Friend WithEvents txb_nomEquipo As TextBox
    Friend WithEvents lbl_nomProfe As Label
    Friend WithEvents lbl_apeProfe As Label
    Friend WithEvents comboBox_Estado As ComboBox
End Class
