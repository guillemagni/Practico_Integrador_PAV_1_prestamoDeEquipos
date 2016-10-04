<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Registrar_Turno
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
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.lbl_id_turno = New System.Windows.Forms.Label()
        Me.txt_box_id_turno = New System.Windows.Forms.TextBox()
        Me.lbl_nombre_turno = New System.Windows.Forms.Label()
        Me.txt_box_nombre_turno = New System.Windows.Forms.TextBox()
        Me.txt_box_hora_inicio = New System.Windows.Forms.TextBox()
        Me.lbl_hora_inicio = New System.Windows.Forms.Label()
        Me.lbl_hora_fin = New System.Windows.Forms.Label()
        Me.txt_box_hora_fin = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(82, 209)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 0
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(169, 209)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 1
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'lbl_id_turno
        '
        Me.lbl_id_turno.AutoSize = True
        Me.lbl_id_turno.Location = New System.Drawing.Point(12, 41)
        Me.lbl_id_turno.Name = "lbl_id_turno"
        Me.lbl_id_turno.Size = New System.Drawing.Size(116, 13)
        Me.lbl_id_turno.TabIndex = 2
        Me.lbl_id_turno.Text = "Identificación de Turno"
        '
        'txt_box_id_turno
        '
        Me.txt_box_id_turno.Location = New System.Drawing.Point(144, 38)
        Me.txt_box_id_turno.Name = "txt_box_id_turno"
        Me.txt_box_id_turno.Size = New System.Drawing.Size(100, 20)
        Me.txt_box_id_turno.TabIndex = 3
        '
        'lbl_nombre_turno
        '
        Me.lbl_nombre_turno.AutoSize = True
        Me.lbl_nombre_turno.Location = New System.Drawing.Point(12, 80)
        Me.lbl_nombre_turno.Name = "lbl_nombre_turno"
        Me.lbl_nombre_turno.Size = New System.Drawing.Size(90, 13)
        Me.lbl_nombre_turno.TabIndex = 4
        Me.lbl_nombre_turno.Text = "Nombre de Turno"
        '
        'txt_box_nombre_turno
        '
        Me.txt_box_nombre_turno.Location = New System.Drawing.Point(144, 77)
        Me.txt_box_nombre_turno.Name = "txt_box_nombre_turno"
        Me.txt_box_nombre_turno.Size = New System.Drawing.Size(100, 20)
        Me.txt_box_nombre_turno.TabIndex = 5
        '
        'txt_box_hora_inicio
        '
        Me.txt_box_hora_inicio.Location = New System.Drawing.Point(144, 117)
        Me.txt_box_hora_inicio.Name = "txt_box_hora_inicio"
        Me.txt_box_hora_inicio.Size = New System.Drawing.Size(100, 20)
        Me.txt_box_hora_inicio.TabIndex = 6
        '
        'lbl_hora_inicio
        '
        Me.lbl_hora_inicio.AutoSize = True
        Me.lbl_hora_inicio.Location = New System.Drawing.Point(12, 124)
        Me.lbl_hora_inicio.Name = "lbl_hora_inicio"
        Me.lbl_hora_inicio.Size = New System.Drawing.Size(73, 13)
        Me.lbl_hora_inicio.TabIndex = 7
        Me.lbl_hora_inicio.Text = "Hora de Inicio"
        '
        'lbl_hora_fin
        '
        Me.lbl_hora_fin.AutoSize = True
        Me.lbl_hora_fin.Location = New System.Drawing.Point(12, 161)
        Me.lbl_hora_fin.Name = "lbl_hora_fin"
        Me.lbl_hora_fin.Size = New System.Drawing.Size(62, 13)
        Me.lbl_hora_fin.TabIndex = 8
        Me.lbl_hora_fin.Text = "Hora de Fin"
        '
        'txt_box_hora_fin
        '
        Me.txt_box_hora_fin.Location = New System.Drawing.Point(144, 161)
        Me.txt_box_hora_fin.Name = "txt_box_hora_fin"
        Me.txt_box_hora_fin.Size = New System.Drawing.Size(100, 20)
        Me.txt_box_hora_fin.TabIndex = 9
        '
        'Form_Registrar_Turno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 260)
        Me.Controls.Add(Me.txt_box_hora_fin)
        Me.Controls.Add(Me.lbl_hora_fin)
        Me.Controls.Add(Me.lbl_hora_inicio)
        Me.Controls.Add(Me.txt_box_hora_inicio)
        Me.Controls.Add(Me.txt_box_nombre_turno)
        Me.Controls.Add(Me.lbl_nombre_turno)
        Me.Controls.Add(Me.txt_box_id_turno)
        Me.Controls.Add(Me.lbl_id_turno)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Name = "Form_Registrar_Turno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Turno"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_aceptar As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents lbl_id_turno As Label
    Friend WithEvents txt_box_id_turno As TextBox
    Friend WithEvents lbl_nombre_turno As Label
    Friend WithEvents txt_box_nombre_turno As TextBox
    Friend WithEvents txt_box_hora_inicio As TextBox
    Friend WithEvents lbl_hora_inicio As Label
    Friend WithEvents lbl_hora_fin As Label
    Friend WithEvents txt_box_hora_fin As TextBox
End Class
