<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Eliminar_Curso
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
        Me.lbl_valor_id_turno = New System.Windows.Forms.Label()
        Me.lbl_id_turno = New System.Windows.Forms.Label()
        Me.lbl_valor_categoria_curso = New System.Windows.Forms.Label()
        Me.lbl_categoria_curso = New System.Windows.Forms.Label()
        Me.lbl_valor_nro_curso = New System.Windows.Forms.Label()
        Me.lbl_num_curso = New System.Windows.Forms.Label()
        Me.lbl_mensaje = New System.Windows.Forms.Label()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.txt_box_letra_curso = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_box_nro_curso = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_nro_curso = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(217, 304)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 23
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        Me.btn_cancelar.Visible = False
        '
        'lbl_valor_id_turno
        '
        Me.lbl_valor_id_turno.AutoSize = True
        Me.lbl_valor_id_turno.Location = New System.Drawing.Point(156, 249)
        Me.lbl_valor_id_turno.Name = "lbl_valor_id_turno"
        Me.lbl_valor_id_turno.Size = New System.Drawing.Size(23, 13)
        Me.lbl_valor_id_turno.TabIndex = 22
        Me.lbl_valor_id_turno.Text = "null"
        '
        'lbl_id_turno
        '
        Me.lbl_id_turno.AutoSize = True
        Me.lbl_id_turno.Location = New System.Drawing.Point(44, 249)
        Me.lbl_id_turno.Name = "lbl_id_turno"
        Me.lbl_id_turno.Size = New System.Drawing.Size(65, 13)
        Me.lbl_id_turno.TabIndex = 21
        Me.lbl_id_turno.Text = "Id de Turno:"
        '
        'lbl_valor_categoria_curso
        '
        Me.lbl_valor_categoria_curso.AutoSize = True
        Me.lbl_valor_categoria_curso.Location = New System.Drawing.Point(156, 216)
        Me.lbl_valor_categoria_curso.Name = "lbl_valor_categoria_curso"
        Me.lbl_valor_categoria_curso.Size = New System.Drawing.Size(23, 13)
        Me.lbl_valor_categoria_curso.TabIndex = 20
        Me.lbl_valor_categoria_curso.Text = "null"
        '
        'lbl_categoria_curso
        '
        Me.lbl_categoria_curso.AutoSize = True
        Me.lbl_categoria_curso.Location = New System.Drawing.Point(44, 216)
        Me.lbl_categoria_curso.Name = "lbl_categoria_curso"
        Me.lbl_categoria_curso.Size = New System.Drawing.Size(100, 13)
        Me.lbl_categoria_curso.TabIndex = 19
        Me.lbl_categoria_curso.Text = "Categoria de Curso:"
        '
        'lbl_valor_nro_curso
        '
        Me.lbl_valor_nro_curso.AutoSize = True
        Me.lbl_valor_nro_curso.Location = New System.Drawing.Point(156, 190)
        Me.lbl_valor_nro_curso.Name = "lbl_valor_nro_curso"
        Me.lbl_valor_nro_curso.Size = New System.Drawing.Size(23, 13)
        Me.lbl_valor_nro_curso.TabIndex = 18
        Me.lbl_valor_nro_curso.Text = "null"
        '
        'lbl_num_curso
        '
        Me.lbl_num_curso.AutoSize = True
        Me.lbl_num_curso.Location = New System.Drawing.Point(44, 190)
        Me.lbl_num_curso.Name = "lbl_num_curso"
        Me.lbl_num_curso.Size = New System.Drawing.Size(95, 13)
        Me.lbl_num_curso.TabIndex = 17
        Me.lbl_num_curso.Text = "Numero de Curso: "
        '
        'lbl_mensaje
        '
        Me.lbl_mensaje.AutoSize = True
        Me.lbl_mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_mensaje.Location = New System.Drawing.Point(94, 158)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(143, 17)
        Me.lbl_mensaje.TabIndex = 16
        Me.lbl_mensaje.Text = "Informacion de Turno"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Enabled = False
        Me.btn_eliminar.Location = New System.Drawing.Point(122, 304)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminar.TabIndex = 14
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'txt_box_letra_curso
        '
        Me.txt_box_letra_curso.Location = New System.Drawing.Point(149, 63)
        Me.txt_box_letra_curso.Name = "txt_box_letra_curso"
        Me.txt_box_letra_curso.Size = New System.Drawing.Size(143, 20)
        Me.txt_box_letra_curso.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Categoria de Curso"
        '
        'txt_box_nro_curso
        '
        Me.txt_box_nro_curso.Location = New System.Drawing.Point(149, 23)
        Me.txt_box_nro_curso.Name = "txt_box_nro_curso"
        Me.txt_box_nro_curso.Size = New System.Drawing.Size(143, 20)
        Me.txt_box_nro_curso.TabIndex = 36
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(190, 107)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 23)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl_nro_curso
        '
        Me.lbl_nro_curso.AutoSize = True
        Me.lbl_nro_curso.Location = New System.Drawing.Point(42, 26)
        Me.lbl_nro_curso.Name = "lbl_nro_curso"
        Me.lbl_nro_curso.Size = New System.Drawing.Size(89, 13)
        Me.lbl_nro_curso.TabIndex = 34
        Me.lbl_nro_curso.Text = "Numero de Curso"
        '
        'Form_Eliminar_Curso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 440)
        Me.Controls.Add(Me.txt_box_letra_curso)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_box_nro_curso)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_nro_curso)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.lbl_valor_id_turno)
        Me.Controls.Add(Me.lbl_id_turno)
        Me.Controls.Add(Me.lbl_valor_categoria_curso)
        Me.Controls.Add(Me.lbl_categoria_curso)
        Me.Controls.Add(Me.lbl_valor_nro_curso)
        Me.Controls.Add(Me.lbl_num_curso)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Name = "Form_Eliminar_Curso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar Curso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cancelar As Button
    Friend WithEvents lbl_valor_id_turno As Label
    Friend WithEvents lbl_id_turno As Label
    Friend WithEvents lbl_valor_categoria_curso As Label
    Friend WithEvents lbl_categoria_curso As Label
    Friend WithEvents lbl_valor_nro_curso As Label
    Friend WithEvents lbl_num_curso As Label
    Friend WithEvents lbl_mensaje As Label
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents txt_box_letra_curso As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_box_nro_curso As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lbl_nro_curso As Label
End Class
