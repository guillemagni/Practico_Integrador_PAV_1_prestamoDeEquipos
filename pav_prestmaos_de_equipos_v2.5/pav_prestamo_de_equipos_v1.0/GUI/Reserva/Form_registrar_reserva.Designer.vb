<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Registrar_Reserva
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
        Me.txt_box_id_reserva = New System.Windows.Forms.TextBox()
        Me.lbl_id_reserva = New System.Windows.Forms.Label()
        Me.txt_box_num_curso = New System.Windows.Forms.TextBox()
        Me.txt_box_num_horario = New System.Windows.Forms.TextBox()
        Me.txt_box_letra_curso = New System.Windows.Forms.TextBox()
        Me.txt_box_id_equipo = New System.Windows.Forms.TextBox()
        Me.txt_box_id_profesor = New System.Windows.Forms.TextBox()
        Me.txt_box_id_turno = New System.Windows.Forms.TextBox()
        Me.lbl_num_curso = New System.Windows.Forms.Label()
        Me.lbl_letra_curso = New System.Windows.Forms.Label()
        Me.lbl_num_horario = New System.Windows.Forms.Label()
        Me.lbl_id_turno = New System.Windows.Forms.Label()
        Me.lbl_id_profesor = New System.Windows.Forms.Label()
        Me.lbl_id_equipo = New System.Windows.Forms.Label()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.lbl_fecha_pedido = New System.Windows.Forms.Label()
        Me.lbl_fecha_reserva = New System.Windows.Forms.Label()
        Me.lbl_mensaje_pricipal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_box_id_reserva
        '
        Me.txt_box_id_reserva.Location = New System.Drawing.Point(156, 74)
        Me.txt_box_id_reserva.Name = "txt_box_id_reserva"
        Me.txt_box_id_reserva.Size = New System.Drawing.Size(200, 20)
        Me.txt_box_id_reserva.TabIndex = 0
        '
        'lbl_id_reserva
        '
        Me.lbl_id_reserva.AutoSize = True
        Me.lbl_id_reserva.Location = New System.Drawing.Point(16, 77)
        Me.lbl_id_reserva.Name = "lbl_id_reserva"
        Me.lbl_id_reserva.Size = New System.Drawing.Size(128, 13)
        Me.lbl_id_reserva.TabIndex = 1
        Me.lbl_id_reserva.Text = "Identificacion de Reserva"
        '
        'txt_box_num_curso
        '
        Me.txt_box_num_curso.Location = New System.Drawing.Point(572, 74)
        Me.txt_box_num_curso.Name = "txt_box_num_curso"
        Me.txt_box_num_curso.Size = New System.Drawing.Size(200, 20)
        Me.txt_box_num_curso.TabIndex = 2
        '
        'txt_box_num_horario
        '
        Me.txt_box_num_horario.Location = New System.Drawing.Point(156, 303)
        Me.txt_box_num_horario.Name = "txt_box_num_horario"
        Me.txt_box_num_horario.Size = New System.Drawing.Size(200, 20)
        Me.txt_box_num_horario.TabIndex = 3
        '
        'txt_box_letra_curso
        '
        Me.txt_box_letra_curso.Location = New System.Drawing.Point(156, 241)
        Me.txt_box_letra_curso.Name = "txt_box_letra_curso"
        Me.txt_box_letra_curso.Size = New System.Drawing.Size(200, 20)
        Me.txt_box_letra_curso.TabIndex = 4
        '
        'txt_box_id_equipo
        '
        Me.txt_box_id_equipo.Location = New System.Drawing.Point(572, 241)
        Me.txt_box_id_equipo.Name = "txt_box_id_equipo"
        Me.txt_box_id_equipo.Size = New System.Drawing.Size(200, 20)
        Me.txt_box_id_equipo.TabIndex = 5
        '
        'txt_box_id_profesor
        '
        Me.txt_box_id_profesor.Location = New System.Drawing.Point(572, 188)
        Me.txt_box_id_profesor.Name = "txt_box_id_profesor"
        Me.txt_box_id_profesor.Size = New System.Drawing.Size(200, 20)
        Me.txt_box_id_profesor.TabIndex = 6
        '
        'txt_box_id_turno
        '
        Me.txt_box_id_turno.Location = New System.Drawing.Point(572, 130)
        Me.txt_box_id_turno.Name = "txt_box_id_turno"
        Me.txt_box_id_turno.Size = New System.Drawing.Size(200, 20)
        Me.txt_box_id_turno.TabIndex = 7
        '
        'lbl_num_curso
        '
        Me.lbl_num_curso.AutoSize = True
        Me.lbl_num_curso.Location = New System.Drawing.Point(435, 74)
        Me.lbl_num_curso.Name = "lbl_num_curso"
        Me.lbl_num_curso.Size = New System.Drawing.Size(89, 13)
        Me.lbl_num_curso.TabIndex = 8
        Me.lbl_num_curso.Text = "Número de Curso"
        '
        'lbl_letra_curso
        '
        Me.lbl_letra_curso.AutoSize = True
        Me.lbl_letra_curso.Location = New System.Drawing.Point(15, 241)
        Me.lbl_letra_curso.Name = "lbl_letra_curso"
        Me.lbl_letra_curso.Size = New System.Drawing.Size(120, 13)
        Me.lbl_letra_curso.TabIndex = 9
        Me.lbl_letra_curso.Text = "Característica del Curso"
        '
        'lbl_num_horario
        '
        Me.lbl_num_horario.AutoSize = True
        Me.lbl_num_horario.Location = New System.Drawing.Point(15, 303)
        Me.lbl_num_horario.Name = "lbl_num_horario"
        Me.lbl_num_horario.Size = New System.Drawing.Size(96, 13)
        Me.lbl_num_horario.TabIndex = 10
        Me.lbl_num_horario.Text = "Número de Horario"
        '
        'lbl_id_turno
        '
        Me.lbl_id_turno.AutoSize = True
        Me.lbl_id_turno.Location = New System.Drawing.Point(435, 130)
        Me.lbl_id_turno.Name = "lbl_id_turno"
        Me.lbl_id_turno.Size = New System.Drawing.Size(112, 13)
        Me.lbl_id_turno.TabIndex = 11
        Me.lbl_id_turno.Text = "Identificacion de turno"
        '
        'lbl_id_profesor
        '
        Me.lbl_id_profesor.AutoSize = True
        Me.lbl_id_profesor.Location = New System.Drawing.Point(435, 188)
        Me.lbl_id_profesor.Name = "lbl_id_profesor"
        Me.lbl_id_profesor.Size = New System.Drawing.Size(127, 13)
        Me.lbl_id_profesor.TabIndex = 12
        Me.lbl_id_profesor.Text = "Identificación de Profesor"
        '
        'lbl_id_equipo
        '
        Me.lbl_id_equipo.AutoSize = True
        Me.lbl_id_equipo.Location = New System.Drawing.Point(435, 241)
        Me.lbl_id_equipo.Name = "lbl_id_equipo"
        Me.lbl_id_equipo.Size = New System.Drawing.Size(123, 13)
        Me.lbl_id_equipo.TabIndex = 13
        Me.lbl_id_equipo.Text = "Identificación de Equípo"
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(598, 341)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 14
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(697, 341)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 15
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(156, 133)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 16
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(156, 188)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 17
        '
        'lbl_fecha_pedido
        '
        Me.lbl_fecha_pedido.AutoSize = True
        Me.lbl_fecha_pedido.Location = New System.Drawing.Point(15, 133)
        Me.lbl_fecha_pedido.Name = "lbl_fecha_pedido"
        Me.lbl_fecha_pedido.Size = New System.Drawing.Size(88, 13)
        Me.lbl_fecha_pedido.TabIndex = 18
        Me.lbl_fecha_pedido.Text = "Fecha de Pedido"
        '
        'lbl_fecha_reserva
        '
        Me.lbl_fecha_reserva.AutoSize = True
        Me.lbl_fecha_reserva.Location = New System.Drawing.Point(16, 188)
        Me.lbl_fecha_reserva.Name = "lbl_fecha_reserva"
        Me.lbl_fecha_reserva.Size = New System.Drawing.Size(95, 13)
        Me.lbl_fecha_reserva.TabIndex = 19
        Me.lbl_fecha_reserva.Text = "Fecha de Reserva"
        '
        'lbl_mensaje_pricipal
        '
        Me.lbl_mensaje_pricipal.AutoSize = True
        Me.lbl_mensaje_pricipal.Location = New System.Drawing.Point(331, 22)
        Me.lbl_mensaje_pricipal.Name = "lbl_mensaje_pricipal"
        Me.lbl_mensaje_pricipal.Size = New System.Drawing.Size(139, 13)
        Me.lbl_mensaje_pricipal.TabIndex = 20
        Me.lbl_mensaje_pricipal.Text = "Ingrese los datos solicitados"
        '
        'Form_Registrar_Reserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 389)
        Me.Controls.Add(Me.lbl_mensaje_pricipal)
        Me.Controls.Add(Me.lbl_fecha_reserva)
        Me.Controls.Add(Me.lbl_fecha_pedido)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.lbl_id_equipo)
        Me.Controls.Add(Me.lbl_id_profesor)
        Me.Controls.Add(Me.lbl_id_turno)
        Me.Controls.Add(Me.lbl_num_horario)
        Me.Controls.Add(Me.lbl_letra_curso)
        Me.Controls.Add(Me.lbl_num_curso)
        Me.Controls.Add(Me.txt_box_id_turno)
        Me.Controls.Add(Me.txt_box_id_profesor)
        Me.Controls.Add(Me.txt_box_id_equipo)
        Me.Controls.Add(Me.txt_box_letra_curso)
        Me.Controls.Add(Me.txt_box_num_horario)
        Me.Controls.Add(Me.txt_box_num_curso)
        Me.Controls.Add(Me.lbl_id_reserva)
        Me.Controls.Add(Me.txt_box_id_reserva)
        Me.Name = "Form_Registrar_Reserva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Reserva"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_box_id_reserva As TextBox
    Friend WithEvents lbl_id_reserva As Label
    Friend WithEvents txt_box_num_curso As TextBox
    Friend WithEvents txt_box_num_horario As TextBox
    Friend WithEvents txt_box_letra_curso As TextBox
    Friend WithEvents txt_box_id_equipo As TextBox
    Friend WithEvents txt_box_id_profesor As TextBox
    Friend WithEvents txt_box_id_turno As TextBox
    Friend WithEvents lbl_num_curso As Label
    Friend WithEvents lbl_letra_curso As Label
    Friend WithEvents lbl_num_horario As Label
    Friend WithEvents lbl_id_turno As Label
    Friend WithEvents lbl_id_profesor As Label
    Friend WithEvents lbl_id_equipo As Label
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents lbl_fecha_pedido As Label
    Friend WithEvents lbl_fecha_reserva As Label
    Friend WithEvents lbl_mensaje_pricipal As Label
End Class
