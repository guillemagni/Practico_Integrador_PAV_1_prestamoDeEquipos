<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Editar_Curso
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
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.nro_curso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.letra_curso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_turno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_box_id_turno = New System.Windows.Forms.TextBox()
        Me.txt_box_letra_curso = New System.Windows.Forms.TextBox()
        Me.txt_box_nro_curso = New System.Windows.Forms.TextBox()
        Me.lbl_id_turno = New System.Windows.Forms.Label()
        Me.lbl_letra_curso = New System.Windows.Forms.Label()
        Me.lbl_nro_curso = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(314, 413)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(85, 25)
        Me.btn_cancelar.TabIndex = 31
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(223, 413)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(85, 25)
        Me.btn_aceptar.TabIndex = 30
        Me.btn_aceptar.Text = "Modificar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nro_curso, Me.letra_curso, Me.id_turno})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 133)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(387, 274)
        Me.DataGridView1.TabIndex = 34
        '
        'nro_curso
        '
        Me.nro_curso.HeaderText = "Número del Curso"
        Me.nro_curso.Name = "nro_curso"
        '
        'letra_curso
        '
        Me.letra_curso.HeaderText = "Característica del Curso"
        Me.letra_curso.Name = "letra_curso"
        '
        'id_turno
        '
        Me.id_turno.HeaderText = "Identificacion del Turno"
        Me.id_turno.Name = "id_turno"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_box_id_turno)
        Me.GroupBox1.Controls.Add(Me.txt_box_letra_curso)
        Me.GroupBox1.Controls.Add(Me.txt_box_nro_curso)
        Me.GroupBox1.Controls.Add(Me.lbl_id_turno)
        Me.GroupBox1.Controls.Add(Me.lbl_letra_curso)
        Me.GroupBox1.Controls.Add(Me.lbl_nro_curso)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 106)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información de Curso"
        '
        'txt_box_id_turno
        '
        Me.txt_box_id_turno.Location = New System.Drawing.Point(175, 82)
        Me.txt_box_id_turno.Name = "txt_box_id_turno"
        Me.txt_box_id_turno.Size = New System.Drawing.Size(155, 20)
        Me.txt_box_id_turno.TabIndex = 5
        '
        'txt_box_letra_curso
        '
        Me.txt_box_letra_curso.Location = New System.Drawing.Point(175, 51)
        Me.txt_box_letra_curso.Name = "txt_box_letra_curso"
        Me.txt_box_letra_curso.Size = New System.Drawing.Size(155, 20)
        Me.txt_box_letra_curso.TabIndex = 4
        '
        'txt_box_nro_curso
        '
        Me.txt_box_nro_curso.Location = New System.Drawing.Point(175, 19)
        Me.txt_box_nro_curso.Name = "txt_box_nro_curso"
        Me.txt_box_nro_curso.Size = New System.Drawing.Size(155, 20)
        Me.txt_box_nro_curso.TabIndex = 3
        '
        'lbl_id_turno
        '
        Me.lbl_id_turno.AutoSize = True
        Me.lbl_id_turno.Location = New System.Drawing.Point(6, 82)
        Me.lbl_id_turno.Name = "lbl_id_turno"
        Me.lbl_id_turno.Size = New System.Drawing.Size(112, 13)
        Me.lbl_id_turno.TabIndex = 2
        Me.lbl_id_turno.Text = "Identifiacion del Turno"
        '
        'lbl_letra_curso
        '
        Me.lbl_letra_curso.AutoSize = True
        Me.lbl_letra_curso.Location = New System.Drawing.Point(6, 51)
        Me.lbl_letra_curso.Name = "lbl_letra_curso"
        Me.lbl_letra_curso.Size = New System.Drawing.Size(120, 13)
        Me.lbl_letra_curso.TabIndex = 1
        Me.lbl_letra_curso.Text = "Característica del Curso"
        '
        'lbl_nro_curso
        '
        Me.lbl_nro_curso.AutoSize = True
        Me.lbl_nro_curso.Location = New System.Drawing.Point(6, 26)
        Me.lbl_nro_curso.Name = "lbl_nro_curso"
        Me.lbl_nro_curso.Size = New System.Drawing.Size(91, 13)
        Me.lbl_nro_curso.TabIndex = 0
        Me.lbl_nro_curso.Text = "Numero del Curso"
        '
        'Form_Editar_Curso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Name = "Form_Editar_Curso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Curso"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents nro_curso As DataGridViewTextBoxColumn
    Friend WithEvents letra_curso As DataGridViewTextBoxColumn
    Friend WithEvents id_turno As DataGridViewTextBoxColumn
    Friend WithEvents txt_box_id_turno As TextBox
    Friend WithEvents txt_box_letra_curso As TextBox
    Friend WithEvents txt_box_nro_curso As TextBox
    Friend WithEvents lbl_id_turno As Label
    Friend WithEvents lbl_letra_curso As Label
    Friend WithEvents lbl_nro_curso As Label
End Class
