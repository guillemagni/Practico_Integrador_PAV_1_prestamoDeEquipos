<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Registrar_Curso
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
        Me.lbl_id_turno = New System.Windows.Forms.Label()
        Me.txt_box_turno = New System.Windows.Forms.TextBox()
        Me.txt_box_letra_curso = New System.Windows.Forms.TextBox()
        Me.lbl_letra_curso = New System.Windows.Forms.Label()
        Me.txt_box_nro_curso = New System.Windows.Forms.TextBox()
        Me.lbl_nro_curso = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.lbl_mensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_id_turno
        '
        Me.lbl_id_turno.AutoSize = True
        Me.lbl_id_turno.Location = New System.Drawing.Point(27, 140)
        Me.lbl_id_turno.Name = "lbl_id_turno"
        Me.lbl_id_turno.Size = New System.Drawing.Size(38, 13)
        Me.lbl_id_turno.TabIndex = 17
        Me.lbl_id_turno.Text = "Turno:"
        '
        'txt_box_turno
        '
        Me.txt_box_turno.Location = New System.Drawing.Point(159, 133)
        Me.txt_box_turno.Name = "txt_box_turno"
        Me.txt_box_turno.Size = New System.Drawing.Size(100, 20)
        Me.txt_box_turno.TabIndex = 16
        '
        'txt_box_letra_curso
        '
        Me.txt_box_letra_curso.Location = New System.Drawing.Point(159, 93)
        Me.txt_box_letra_curso.Name = "txt_box_letra_curso"
        Me.txt_box_letra_curso.Size = New System.Drawing.Size(100, 20)
        Me.txt_box_letra_curso.TabIndex = 15
        '
        'lbl_letra_curso
        '
        Me.lbl_letra_curso.AutoSize = True
        Me.lbl_letra_curso.Location = New System.Drawing.Point(27, 96)
        Me.lbl_letra_curso.Name = "lbl_letra_curso"
        Me.lbl_letra_curso.Size = New System.Drawing.Size(100, 13)
        Me.lbl_letra_curso.TabIndex = 14
        Me.lbl_letra_curso.Text = "Categoria de Curso:"
        '
        'txt_box_nro_curso
        '
        Me.txt_box_nro_curso.Location = New System.Drawing.Point(159, 54)
        Me.txt_box_nro_curso.Name = "txt_box_nro_curso"
        Me.txt_box_nro_curso.Size = New System.Drawing.Size(100, 20)
        Me.txt_box_nro_curso.TabIndex = 13
        '
        'lbl_nro_curso
        '
        Me.lbl_nro_curso.AutoSize = True
        Me.lbl_nro_curso.Location = New System.Drawing.Point(27, 57)
        Me.lbl_nro_curso.Name = "lbl_nro_curso"
        Me.lbl_nro_curso.Size = New System.Drawing.Size(92, 13)
        Me.lbl_nro_curso.TabIndex = 12
        Me.lbl_nro_curso.Text = "Numero de Curso:"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(184, 177)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 11
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(97, 177)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 10
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'lbl_mensaje
        '
        Me.lbl_mensaje.AutoSize = True
        Me.lbl_mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_mensaje.Location = New System.Drawing.Point(43, 9)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(207, 17)
        Me.lbl_mensaje.TabIndex = 18
        Me.lbl_mensaje.Text = "Ingrese los Datos para el Curso"
        '
        'Form_Registrar_Curso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 226)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.Controls.Add(Me.lbl_id_turno)
        Me.Controls.Add(Me.txt_box_turno)
        Me.Controls.Add(Me.txt_box_letra_curso)
        Me.Controls.Add(Me.lbl_letra_curso)
        Me.Controls.Add(Me.txt_box_nro_curso)
        Me.Controls.Add(Me.lbl_nro_curso)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Name = "Form_Registrar_Curso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Curso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_id_turno As Label
    Friend WithEvents txt_box_turno As TextBox
    Friend WithEvents txt_box_letra_curso As TextBox
    Friend WithEvents lbl_letra_curso As Label
    Friend WithEvents txt_box_nro_curso As TextBox
    Friend WithEvents lbl_nro_curso As Label
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents lbl_mensaje As Label
End Class
