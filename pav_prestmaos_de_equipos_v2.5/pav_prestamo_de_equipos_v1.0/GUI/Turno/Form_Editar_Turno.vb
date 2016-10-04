Public Class Form_Editar_Turno


    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dvg_turnos.CellMouseClick
        txt_box_id_turno.Text = Convert.ToString(dvg_turnos.CurrentRow.Cells(0).Value)
        txt_box_descripcion.Text = Convert.ToString(dvg_turnos.CurrentRow.Cells(1).Value)
        txt_box_hora_inicio.Text = Convert.ToString(dvg_turnos.CurrentRow.Cells(2).Value)
        txt_box_hora_fin.Text = Convert.ToString(dvg_turnos.CurrentRow.Cells(3).Value)

    End Sub

    Private Sub Form_Editar_Turno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_box_descripcion.Text = ""
        txt_box_hora_fin.Text = ""
        txt_box_hora_inicio.Text = ""
        txt_box_id_turno.Text = ""

        cargar_turnos()

    End Sub

    Private Sub cargar_turnos()
        Dim objTurnoService As New TurnoService
        dvg_turnos.Rows.Clear()
        For Each objTurno In objTurnoService.mostrarTurnos()
            With objTurno
                dvg_turnos.Rows.Add(New String() { .id_Turno.ToString, .desc_Turno, .hora_Inicio, .hora_Fin})
            End With
        Next
    End Sub

    Private Sub btn_guardar_cambios_Click(sender As Object, e As EventArgs) Handles btn_guardar_cambios.Click
        Try
            Dim sentenciaSQL = "UPDATE Turno SET descripción = '" & txt_box_descripcion.Text & "', horaInicio = '" & Convert.ToDateTime(txt_box_hora_inicio.Text) & "', horaFin = '" & Convert.ToDateTime(txt_box_hora_fin.Text) & "' WHERE idTurno = " & Convert.ToInt32(txt_box_id_turno.Text)
            BDHelper.getBDHelper.EjecutarSQL(sentenciaSQL)
            MsgBox("Cambios guardados con éxito", MsgBoxStyle.Information, "Aviso")
            cargar_turnos()
        Catch ex As Exception
            MsgBox("Se requiere seleccionar un dato", MsgBoxStyle.Critical, "Error")
        End Try


    End Sub
End Class