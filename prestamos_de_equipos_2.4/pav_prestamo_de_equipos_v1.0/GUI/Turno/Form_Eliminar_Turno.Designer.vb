<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Eliminar_Turno
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
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbl_mensaje = New System.Windows.Forms.Label()
        Me.lbl_nombre_turno = New System.Windows.Forms.Label()
        Me.lbl_valor_nombre_turno = New System.Windows.Forms.Label()
        Me.lbl_hora_inicio = New System.Windows.Forms.Label()
        Me.lbl_valor_hora_inicio = New System.Windows.Forms.Label()
        Me.lbl_hora_fin = New System.Windows.Forms.Label()
        Me.lbl_valor_hora_fin = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_id_turno
        '
        Me.lbl_id_turno.AutoSize = True
        Me.lbl_id_turno.Location = New System.Drawing.Point(12, 40)
        Me.lbl_id_turno.Name = "lbl_id_turno"
        Me.lbl_id_turno.Size = New System.Drawing.Size(47, 13)
        Me.lbl_id_turno.TabIndex = 0
        Me.lbl_id_turno.Text = "Id Turno"
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(225, 30)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 1
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Enabled = False
        Me.btn_eliminar.Location = New System.Drawing.Point(130, 223)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminar.TabIndex = 2
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(65, 33)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(140, 20)
        Me.TextBox1.TabIndex = 3
        '
        'lbl_mensaje
        '
        Me.lbl_mensaje.AutoSize = True
        Me.lbl_mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_mensaje.Location = New System.Drawing.Point(62, 65)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(143, 17)
        Me.lbl_mensaje.TabIndex = 4
        Me.lbl_mensaje.Text = "Informacion de Turno"
        '
        'lbl_nombre_turno
        '
        Me.lbl_nombre_turno.AutoSize = True
        Me.lbl_nombre_turno.Location = New System.Drawing.Point(12, 97)
        Me.lbl_nombre_turno.Name = "lbl_nombre_turno"
        Me.lbl_nombre_turno.Size = New System.Drawing.Size(96, 13)
        Me.lbl_nombre_turno.TabIndex = 5
        Me.lbl_nombre_turno.Text = "Nombre de Turno: "
        '
        'lbl_valor_nombre_turno
        '
        Me.lbl_valor_nombre_turno.AutoSize = True
        Me.lbl_valor_nombre_turno.Location = New System.Drawing.Point(114, 97)
        Me.lbl_valor_nombre_turno.Name = "lbl_valor_nombre_turno"
        Me.lbl_valor_nombre_turno.Size = New System.Drawing.Size(23, 13)
        Me.lbl_valor_nombre_turno.TabIndex = 6
        Me.lbl_valor_nombre_turno.Text = "null"
        '
        'lbl_hora_inicio
        '
        Me.lbl_hora_inicio.AutoSize = True
        Me.lbl_hora_inicio.Location = New System.Drawing.Point(12, 123)
        Me.lbl_hora_inicio.Name = "lbl_hora_inicio"
        Me.lbl_hora_inicio.Size = New System.Drawing.Size(76, 13)
        Me.lbl_hora_inicio.TabIndex = 7
        Me.lbl_hora_inicio.Text = "Hora de Inicio:"
        '
        'lbl_valor_hora_inicio
        '
        Me.lbl_valor_hora_inicio.AutoSize = True
        Me.lbl_valor_hora_inicio.Location = New System.Drawing.Point(114, 123)
        Me.lbl_valor_hora_inicio.Name = "lbl_valor_hora_inicio"
        Me.lbl_valor_hora_inicio.Size = New System.Drawing.Size(23, 13)
        Me.lbl_valor_hora_inicio.TabIndex = 8
        Me.lbl_valor_hora_inicio.Text = "null"
        '
        'lbl_hora_fin
        '
        Me.lbl_hora_fin.AutoSize = True
        Me.lbl_hora_fin.Location = New System.Drawing.Point(12, 156)
        Me.lbl_hora_fin.Name = "lbl_hora_fin"
        Me.lbl_hora_fin.Size = New System.Drawing.Size(65, 13)
        Me.lbl_hora_fin.TabIndex = 9
        Me.lbl_hora_fin.Text = "Hora de Fin:"
        '
        'lbl_valor_hora_fin
        '
        Me.lbl_valor_hora_fin.AutoSize = True
        Me.lbl_valor_hora_fin.Location = New System.Drawing.Point(114, 156)
        Me.lbl_valor_hora_fin.Name = "lbl_valor_hora_fin"
        Me.lbl_valor_hora_fin.Size = New System.Drawing.Size(23, 13)
        Me.lbl_valor_hora_fin.TabIndex = 10
        Me.lbl_valor_hora_fin.Text = "null"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(225, 223)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 11
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        Me.btn_cancelar.Visible = False
        '
        'Form_Eliminar_Turno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 264)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.lbl_valor_hora_fin)
        Me.Controls.Add(Me.lbl_hora_fin)
        Me.Controls.Add(Me.lbl_valor_hora_inicio)
        Me.Controls.Add(Me.lbl_hora_inicio)
        Me.Controls.Add(Me.lbl_valor_nombre_turno)
        Me.Controls.Add(Me.lbl_nombre_turno)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.lbl_id_turno)
        Me.Name = "Form_Eliminar_Turno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar Turno"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_id_turno As Label
    Friend WithEvents btn_buscar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lbl_mensaje As Label
    Friend WithEvents lbl_nombre_turno As Label
    Friend WithEvents lbl_valor_nombre_turno As Label
    Friend WithEvents lbl_hora_inicio As Label
    Friend WithEvents lbl_valor_hora_inicio As Label
    Friend WithEvents lbl_hora_fin As Label
    Friend WithEvents lbl_valor_hora_fin As Label
    Friend WithEvents btn_cancelar As Button
End Class
