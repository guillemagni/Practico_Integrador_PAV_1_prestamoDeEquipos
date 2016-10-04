Public Class Form_Editar_Horario_X_Turno
    Friend row_selected As DataGridViewRow

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub Form_Editar_Horario_X_Turno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oTurnoService As New TurnoService

        'Carga la grilla con Horarios y su Turno
        cargarGrilla()

        'Carga el Combo Box
        llenarCombo(cb_idTurno, oTurnoService.mostrarTurnos(), "desc_Turno", "id_Turno")

        'DGV Sólo Consulta        
        dgv_hpt.ReadOnly = True

        'Campos vacíos
        vaciarCampos()

        'Boton Aceptar deshabilitado
        btn_aceptar.Enabled = False
    End Sub

    'Definimos un procedimiento Friend (Amigo) para poder utilizarlo desde otro formulario, que permita cargar un combo a partir de:
    'Componente combo
    'Source, una lista de objetos
    'Nombre de la property a mostrar en el displayMember del componente
    'Nombre de la property a almacenar en el valueMember del componente
    Friend Sub llenarCombo(ByVal cbo As ComboBox, source As Object, ByVal display As String, ByVal value As String)
        cbo.DataSource = source
        cbo.DisplayMember = display
        cbo.ValueMember = value
        cbo.SelectedIndex = -1
    End Sub


    Friend Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        'Verificamos que el turno este seleccionado
        Dim idTurno As Integer = -1
        If cb_idTurno.SelectedIndex <> -1 Then
            idTurno = cb_idTurno.SelectedValue
        Else
            MsgBox("Campo <TURNO> es obligatorio.", vbCritical + vbOKOnly, "Aviso")
            cb_idTurno.Focus()
            Exit Sub
        End If

        'Verificamos se haya ingresado un número de horario
        If String.IsNullOrEmpty(txt_box_nro_horario.Text) Then
            MsgBox("Campo <NÚMERO HORARIO> es obligatorio.", vbCritical + vbOKOnly, "Aviso")
            txt_box_nro_horario.Focus()
            Exit Sub
        End If

        'Habilitamos las columnas de los horarios para poder modificarlas
        dgv_hpt.ReadOnly = False
        dgv_hpt.Columns(0).ReadOnly = True
        dgv_hpt.Columns(1).ReadOnly = True

        'Habilitamos el boton Aceptar
        btn_aceptar.Enabled = True

        Dim nroHorario As Integer = Convert.ToInt32(txt_box_nro_horario.Text)

        cargarGrillaConFiltros(idTurno, nroHorario)
    End Sub

    Private Sub cargarGrilla()
        Dim objHorarioService As New HorarioService
        dgv_hpt.Rows.Clear()
        For Each objHorario In objHorarioService.listarHorarios()
            With objHorario
                dgv_hpt.Rows.Add(New String() { .nomTurno, .nro_Horario, .hora_Inicio, .hora_Fin})
            End With
        Next
    End Sub

    Private Sub cargarGrillaConFiltros(ByVal idTurno As Integer, ByVal nroHorario As Integer)
        Dim objHorarioService As New HorarioService
        Dim objHorario As Horario

        dgv_hpt.Rows.Clear()

        objHorario = objHorarioService.listarHorariosConFiltros(idTurno, nroHorario)

        With objHorario
            Try
                dgv_hpt.Rows.Add(New String() { .nomTurno, .nro_Horario, .hora_Inicio, .hora_Fin})
            Catch ex As Exception
                MsgBox("No se encontró el horario", vbCritical + vbOKOnly, "Aviso")
                btn_aceptar.Enabled = False
                cargarGrilla()
                vaciarCampos()
            End Try
        End With
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim oHorario As New Horario
        Dim objHorarioService As New HorarioService

        If cb_idTurno.SelectedIndex <> -1 Then oHorario.id_Turno = cb_idTurno.SelectedValue

        oHorario.nro_Horario = dgv_hpt.CurrentRow.Cells(1).Value
        oHorario.hora_Inicio = dgv_hpt.CurrentRow.Cells(2).Value
        oHorario.hora_Fin = dgv_hpt.CurrentRow.Cells(3).Value

        Dim rpta As Boolean = objHorarioService.actualizarHorario(oHorario, False)

        If rpta Then
            MsgBox("Operación realizada exitosamente.", vbOKOnly + MsgBoxStyle.Information, "Aviso")
            vaciarCampos()
            cargarGrilla()
        Else
            MsgBox("Operación NO se realizó con éxito.", vbCritical + vbOKOnly, "Aviso")
        End If

    End Sub

    Private Sub dgv_hpt_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_hpt.CellClick
        row_selected = dgv_hpt.CurrentRow

    End Sub

    Private Sub dgv_hpt_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_hpt.CellDoubleClick
        If dgv_hpt.ReadOnly Then
            MsgBox("Para modificar los valores, primero debe realizar la búsqueda", vbCritical + vbOKOnly, "Aviso")
        ElseIf dgv_hpt.CurrentCell.ReadOnly Then
            MsgBox("No se puede modificar", vbCritical + vbOKOnly, "Aviso")
        End If

    End Sub

    'Definimos un procedimiento Friend (Amigo) para poder utilizarlo desde otro formulario
    Friend Sub vaciarCampos()
        cb_idTurno.SelectedIndex = -1
        txt_box_nro_horario.Text = ""
    End Sub
End Class