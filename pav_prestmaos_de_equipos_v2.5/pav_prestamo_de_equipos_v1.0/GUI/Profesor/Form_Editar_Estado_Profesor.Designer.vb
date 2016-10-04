<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Editar_Estado_Profesor
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
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_box_id_profesor = New System.Windows.Forms.TextBox()
        Me.lbl_id_profesor = New System.Windows.Forms.Label()
        Me.lbl_estado_actual_profesor = New System.Windows.Forms.Label()
        Me.lbl_estado_profesor = New System.Windows.Forms.Label()
        Me.lbl_nuevo_estado = New System.Windows.Forms.Label()
        Me.txt_box_nuevo_estado_profesor = New System.Windows.Forms.TextBox()
        Me.btn_cambiar_estado = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.lbl_mensaje = New System.Windows.Forms.Label()
        Me.lbl_apeProfe = New System.Windows.Forms.Label()
        Me.lbl_nomProfe = New System.Windows.Forms.Label()
        Me.txb_nomProfe = New System.Windows.Forms.TextBox()
        Me.txb_apeProfe = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(323, 20)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(102, 23)
        Me.btn_buscar.TabIndex = 33
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'txt_box_id_profesor
        '
        Me.txt_box_id_profesor.Location = New System.Drawing.Point(106, 20)
        Me.txt_box_id_profesor.Name = "txt_box_id_profesor"
        Me.txt_box_id_profesor.Size = New System.Drawing.Size(202, 20)
        Me.txt_box_id_profesor.TabIndex = 32
        '
        'lbl_id_profesor
        '
        Me.lbl_id_profesor.AutoSize = True
        Me.lbl_id_profesor.Location = New System.Drawing.Point(17, 25)
        Me.lbl_id_profesor.Name = "lbl_id_profesor"
        Me.lbl_id_profesor.Size = New System.Drawing.Size(73, 13)
        Me.lbl_id_profesor.TabIndex = 31
        Me.lbl_id_profesor.Text = "Id de Profesor"
        '
        'lbl_estado_actual_profesor
        '
        Me.lbl_estado_actual_profesor.AutoSize = True
        Me.lbl_estado_actual_profesor.Location = New System.Drawing.Point(12, 173)
        Me.lbl_estado_actual_profesor.Name = "lbl_estado_actual_profesor"
        Me.lbl_estado_actual_profesor.Size = New System.Drawing.Size(76, 13)
        Me.lbl_estado_actual_profesor.TabIndex = 34
        Me.lbl_estado_actual_profesor.Text = "Estado Actual:"
        '
        'lbl_estado_profesor
        '
        Me.lbl_estado_profesor.AutoSize = True
        Me.lbl_estado_profesor.Location = New System.Drawing.Point(108, 173)
        Me.lbl_estado_profesor.Name = "lbl_estado_profesor"
        Me.lbl_estado_profesor.Size = New System.Drawing.Size(23, 13)
        Me.lbl_estado_profesor.TabIndex = 35
        Me.lbl_estado_profesor.Text = "null"
        '
        'lbl_nuevo_estado
        '
        Me.lbl_nuevo_estado.AutoSize = True
        Me.lbl_nuevo_estado.Location = New System.Drawing.Point(12, 214)
        Me.lbl_nuevo_estado.Name = "lbl_nuevo_estado"
        Me.lbl_nuevo_estado.Size = New System.Drawing.Size(75, 13)
        Me.lbl_nuevo_estado.TabIndex = 36
        Me.lbl_nuevo_estado.Text = "Nuevo Estado"
        '
        'txt_box_nuevo_estado_profesor
        '
        Me.txt_box_nuevo_estado_profesor.Location = New System.Drawing.Point(111, 214)
        Me.txt_box_nuevo_estado_profesor.Name = "txt_box_nuevo_estado_profesor"
        Me.txt_box_nuevo_estado_profesor.Size = New System.Drawing.Size(167, 20)
        Me.txt_box_nuevo_estado_profesor.TabIndex = 37
        '
        'btn_cambiar_estado
        '
        Me.btn_cambiar_estado.Location = New System.Drawing.Point(98, 278)
        Me.btn_cambiar_estado.Name = "btn_cambiar_estado"
        Me.btn_cambiar_estado.Size = New System.Drawing.Size(130, 23)
        Me.btn_cambiar_estado.TabIndex = 38
        Me.btn_cambiar_estado.Text = "Guardar Cambios"
        Me.btn_cambiar_estado.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(249, 278)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(85, 25)
        Me.btn_cancelar.TabIndex = 39
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'lbl_mensaje
        '
        Me.lbl_mensaje.AutoSize = True
        Me.lbl_mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_mensaje.Location = New System.Drawing.Point(132, 60)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(159, 17)
        Me.lbl_mensaje.TabIndex = 40
        Me.lbl_mensaje.Text = "Informacion de Profesor"
        '
        'lbl_apeProfe
        '
        Me.lbl_apeProfe.AutoSize = True
        Me.lbl_apeProfe.Location = New System.Drawing.Point(12, 135)
        Me.lbl_apeProfe.Name = "lbl_apeProfe"
        Me.lbl_apeProfe.Size = New System.Drawing.Size(44, 13)
        Me.lbl_apeProfe.TabIndex = 41
        Me.lbl_apeProfe.Text = "Apellido"
        '
        'lbl_nomProfe
        '
        Me.lbl_nomProfe.AutoSize = True
        Me.lbl_nomProfe.Location = New System.Drawing.Point(12, 98)
        Me.lbl_nomProfe.Name = "lbl_nomProfe"
        Me.lbl_nomProfe.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nomProfe.TabIndex = 42
        Me.lbl_nomProfe.Text = "Nombre"
        '
        'txb_nomProfe
        '
        Me.txb_nomProfe.Enabled = False
        Me.txb_nomProfe.Location = New System.Drawing.Point(111, 98)
        Me.txb_nomProfe.Name = "txb_nomProfe"
        Me.txb_nomProfe.Size = New System.Drawing.Size(167, 20)
        Me.txb_nomProfe.TabIndex = 43
        '
        'txb_apeProfe
        '
        Me.txb_apeProfe.Enabled = False
        Me.txb_apeProfe.Location = New System.Drawing.Point(111, 135)
        Me.txb_apeProfe.Name = "txb_apeProfe"
        Me.txb_apeProfe.Size = New System.Drawing.Size(167, 20)
        Me.txb_apeProfe.TabIndex = 44
        '
        'Form_Editar_Estado_Profesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 334)
        Me.Controls.Add(Me.txb_apeProfe)
        Me.Controls.Add(Me.txb_nomProfe)
        Me.Controls.Add(Me.lbl_nomProfe)
        Me.Controls.Add(Me.lbl_apeProfe)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_cambiar_estado)
        Me.Controls.Add(Me.txt_box_nuevo_estado_profesor)
        Me.Controls.Add(Me.lbl_nuevo_estado)
        Me.Controls.Add(Me.lbl_estado_profesor)
        Me.Controls.Add(Me.lbl_estado_actual_profesor)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.txt_box_id_profesor)
        Me.Controls.Add(Me.lbl_id_profesor)
        Me.Name = "Form_Editar_Estado_Profesor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Estado Profesor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_buscar As Button
    Friend WithEvents txt_box_id_profesor As TextBox
    Friend WithEvents lbl_id_profesor As Label
    Friend WithEvents lbl_estado_actual_profesor As Label
    Friend WithEvents lbl_estado_profesor As Label
    Friend WithEvents lbl_nuevo_estado As Label
    Friend WithEvents txt_box_nuevo_estado_profesor As TextBox
    Friend WithEvents btn_cambiar_estado As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents lbl_mensaje As Label
    Friend WithEvents lbl_apeProfe As Label
    Friend WithEvents lbl_nomProfe As Label
    Friend WithEvents txb_nomProfe As TextBox
    Friend WithEvents txb_apeProfe As TextBox
End Class
