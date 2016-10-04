<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Registrar_Horario_X_Turno
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
        Me.lbl_hora_fin = New System.Windows.Forms.Label()
        Me.lbl_hora_inicio = New System.Windows.Forms.Label()
        Me.txt_box_nro_horario = New System.Windows.Forms.TextBox()
        Me.lbl_nro_horario = New System.Windows.Forms.Label()
        Me.lbl_id_turno = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.txt_box_hora_inicio = New System.Windows.Forms.MaskedTextBox()
        Me.txt_box_hora_fin = New System.Windows.Forms.MaskedTextBox()
        Me.cb_idTurno = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lbl_hora_fin
        '
        Me.lbl_hora_fin.AutoSize = True
        Me.lbl_hora_fin.Location = New System.Drawing.Point(29, 166)
        Me.lbl_hora_fin.Name = "lbl_hora_fin"
        Me.lbl_hora_fin.Size = New System.Drawing.Size(62, 13)
        Me.lbl_hora_fin.TabIndex = 18
        Me.lbl_hora_fin.Text = "Hora de Fin"
        '
        'lbl_hora_inicio
        '
        Me.lbl_hora_inicio.AutoSize = True
        Me.lbl_hora_inicio.Location = New System.Drawing.Point(29, 129)
        Me.lbl_hora_inicio.Name = "lbl_hora_inicio"
        Me.lbl_hora_inicio.Size = New System.Drawing.Size(73, 13)
        Me.lbl_hora_inicio.TabIndex = 17
        Me.lbl_hora_inicio.Text = "Hora de Inicio"
        '
        'txt_box_nro_horario
        '
        Me.txt_box_nro_horario.Location = New System.Drawing.Point(161, 82)
        Me.txt_box_nro_horario.Name = "txt_box_nro_horario"
        Me.txt_box_nro_horario.Size = New System.Drawing.Size(100, 20)
        Me.txt_box_nro_horario.TabIndex = 15
        '
        'lbl_nro_horario
        '
        Me.lbl_nro_horario.AutoSize = True
        Me.lbl_nro_horario.Location = New System.Drawing.Point(29, 85)
        Me.lbl_nro_horario.Name = "lbl_nro_horario"
        Me.lbl_nro_horario.Size = New System.Drawing.Size(96, 13)
        Me.lbl_nro_horario.TabIndex = 14
        Me.lbl_nro_horario.Text = "Número de Horario"
        '
        'lbl_id_turno
        '
        Me.lbl_id_turno.AutoSize = True
        Me.lbl_id_turno.Location = New System.Drawing.Point(29, 46)
        Me.lbl_id_turno.Name = "lbl_id_turno"
        Me.lbl_id_turno.Size = New System.Drawing.Size(116, 13)
        Me.lbl_id_turno.TabIndex = 12
        Me.lbl_id_turno.Text = "Identificación de Turno"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(186, 214)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 11
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(99, 214)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 10
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'txt_box_hora_inicio
        '
        Me.txt_box_hora_inicio.Location = New System.Drawing.Point(161, 126)
        Me.txt_box_hora_inicio.Mask = "00:00"
        Me.txt_box_hora_inicio.Name = "txt_box_hora_inicio"
        Me.txt_box_hora_inicio.Size = New System.Drawing.Size(37, 20)
        Me.txt_box_hora_inicio.TabIndex = 19
        Me.txt_box_hora_inicio.ValidatingType = GetType(Date)
        '
        'txt_box_hora_fin
        '
        Me.txt_box_hora_fin.Location = New System.Drawing.Point(161, 166)
        Me.txt_box_hora_fin.Mask = "00:00"
        Me.txt_box_hora_fin.Name = "txt_box_hora_fin"
        Me.txt_box_hora_fin.Size = New System.Drawing.Size(37, 20)
        Me.txt_box_hora_fin.TabIndex = 20
        Me.txt_box_hora_fin.ValidatingType = GetType(Date)
        '
        'cb_idTurno
        '
        Me.cb_idTurno.FormattingEnabled = True
        Me.cb_idTurno.Location = New System.Drawing.Point(161, 43)
        Me.cb_idTurno.Name = "cb_idTurno"
        Me.cb_idTurno.Size = New System.Drawing.Size(100, 21)
        Me.cb_idTurno.TabIndex = 21
        '
        'Form_Registrar_Horario_X_Turno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 321)
        Me.Controls.Add(Me.cb_idTurno)
        Me.Controls.Add(Me.txt_box_hora_fin)
        Me.Controls.Add(Me.txt_box_hora_inicio)
        Me.Controls.Add(Me.lbl_hora_fin)
        Me.Controls.Add(Me.lbl_hora_inicio)
        Me.Controls.Add(Me.txt_box_nro_horario)
        Me.Controls.Add(Me.lbl_nro_horario)
        Me.Controls.Add(Me.lbl_id_turno)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Name = "Form_Registrar_Horario_X_Turno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Horario Por Turno"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_hora_fin As Label
    Friend WithEvents lbl_hora_inicio As Label
    Friend WithEvents txt_box_nro_horario As TextBox
    Friend WithEvents lbl_nro_horario As Label
    Friend WithEvents lbl_id_turno As Label
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents txt_box_hora_inicio As MaskedTextBox
    Friend WithEvents txt_box_hora_fin As MaskedTextBox
    Friend WithEvents cb_idTurno As ComboBox
End Class
