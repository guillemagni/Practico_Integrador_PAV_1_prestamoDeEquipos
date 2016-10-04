<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Registrar_Profesor
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
        Me.txt_box_idProfesor = New System.Windows.Forms.TextBox()
        Me.lbl_id_profesor = New System.Windows.Forms.Label()
        Me.lbl_mensaje = New System.Windows.Forms.Label()
        Me.txt_box_apellido_profesor = New System.Windows.Forms.TextBox()
        Me.txt_box_nombre_profesor = New System.Windows.Forms.TextBox()
        Me.lbl_id_estado_profesor = New System.Windows.Forms.Label()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.txt_box_Est = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt_box_idProfesor
        '
        Me.txt_box_idProfesor.Location = New System.Drawing.Point(186, 83)
        Me.txt_box_idProfesor.Name = "txt_box_idProfesor"
        Me.txt_box_idProfesor.Size = New System.Drawing.Size(206, 20)
        Me.txt_box_idProfesor.TabIndex = 1
        '
        'lbl_id_profesor
        '
        Me.lbl_id_profesor.AutoSize = True
        Me.lbl_id_profesor.Location = New System.Drawing.Point(53, 83)
        Me.lbl_id_profesor.Name = "lbl_id_profesor"
        Me.lbl_id_profesor.Size = New System.Drawing.Size(127, 13)
        Me.lbl_id_profesor.TabIndex = 36
        Me.lbl_id_profesor.Text = "Identificacion de Profesor"
        '
        'lbl_mensaje
        '
        Me.lbl_mensaje.AutoSize = True
        Me.lbl_mensaje.Location = New System.Drawing.Point(53, 31)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(148, 13)
        Me.lbl_mensaje.TabIndex = 35
        Me.lbl_mensaje.Text = "Ingrese los Datos del Profesor"
        '
        'txt_box_apellido_profesor
        '
        Me.txt_box_apellido_profesor.Location = New System.Drawing.Point(186, 167)
        Me.txt_box_apellido_profesor.Name = "txt_box_apellido_profesor"
        Me.txt_box_apellido_profesor.Size = New System.Drawing.Size(206, 20)
        Me.txt_box_apellido_profesor.TabIndex = 3
        '
        'txt_box_nombre_profesor
        '
        Me.txt_box_nombre_profesor.Location = New System.Drawing.Point(186, 127)
        Me.txt_box_nombre_profesor.Name = "txt_box_nombre_profesor"
        Me.txt_box_nombre_profesor.Size = New System.Drawing.Size(206, 20)
        Me.txt_box_nombre_profesor.TabIndex = 2
        '
        'lbl_id_estado_profesor
        '
        Me.lbl_id_estado_profesor.AutoSize = True
        Me.lbl_id_estado_profesor.Location = New System.Drawing.Point(53, 211)
        Me.lbl_id_estado_profesor.Name = "lbl_id_estado_profesor"
        Me.lbl_id_estado_profesor.Size = New System.Drawing.Size(100, 13)
        Me.lbl_id_estado_profesor.TabIndex = 31
        Me.lbl_id_estado_profesor.Text = " Estado de Profesor"
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(53, 170)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(44, 13)
        Me.lbl_apellido.TabIndex = 30
        Me.lbl_apellido.Text = "Apellido"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(53, 127)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 29
        Me.lbl_nombre.Text = "Nombre"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(307, 264)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(85, 25)
        Me.btn_cancelar.TabIndex = 6
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(208, 264)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(85, 25)
        Me.btn_aceptar.TabIndex = 5
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'txt_box_Est
        '
        Me.txt_box_Est.Location = New System.Drawing.Point(186, 211)
        Me.txt_box_Est.Name = "txt_box_Est"
        Me.txt_box_Est.Size = New System.Drawing.Size(206, 20)
        Me.txt_box_Est.TabIndex = 4
        '
        'Form_Registrar_Profesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 344)
        Me.Controls.Add(Me.txt_box_Est)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.txt_box_idProfesor)
        Me.Controls.Add(Me.lbl_id_profesor)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.Controls.Add(Me.txt_box_apellido_profesor)
        Me.Controls.Add(Me.txt_box_nombre_profesor)
        Me.Controls.Add(Me.lbl_id_estado_profesor)
        Me.Controls.Add(Me.lbl_apellido)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Name = "Form_Registrar_Profesor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Profesor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_box_idProfesor As TextBox
    Friend WithEvents lbl_id_profesor As Label
    Friend WithEvents lbl_mensaje As Label
    Friend WithEvents txt_box_apellido_profesor As TextBox
    Friend WithEvents txt_box_nombre_profesor As TextBox
    Friend WithEvents lbl_id_estado_profesor As Label
    Friend WithEvents lbl_apellido As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents txt_box_Est As TextBox
End Class
