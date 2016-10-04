Public Class Form_Consultar_Horario_X_Turno
    Private Sub Form_Consultar_Horario_X_Turno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargamos el comboBox
        Dim oTurnoService As New TurnoService
        Form_Editar_Horario_X_Turno.llenarCombo(cb_idTurno, oTurnoService.mostrarTurnos(), "desc_Turno", "id_Turno")

        'Vacíamos el DGV
        dgv_hpt.Rows.Clear()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim idTurno As Integer = -1
        If cb_idTurno.SelectedIndex <> -1 Then
            idTurno = cb_idTurno.SelectedValue
        Else
            MsgBox("Campo <TURNO> es obligatorio.", vbCritical + vbOKOnly, "Aviso")
            cb_idTurno.Focus()
            Exit Sub
        End If

        cargarGrillaConFiltroTurno(idTurno)
    End Sub

    Public Sub cargarGrillaConFiltroTurno(ByVal idTurno As Integer)
        Dim objHorarioService As New HorarioService

        dgv_hpt.Rows.Clear()

        For Each objHorario In objHorarioService.listarHorariosConFiltroTurno(idTurno)
            With objHorario
                dgv_hpt.Rows.Add(New String() { .nomTurno, .nro_Horario, .hora_Inicio, .hora_Fin})
            End With
        Next
    End Sub
End Class