Public Class Form_Editar_Equipo

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_editar_estado_equipo_Click(sender As Object, e As EventArgs) Handles btn_editar_estado_equipo.Click
        Form_Editar_Estado_Equipo.ShowDialog()
        cargarGrilla()
    End Sub

    Private Sub Form_Editar_Equipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Vaciamos los campos
        txt_box_idEquipo.Text = ""
        txt_box_nombreEq.Text = ""
        txt_box_desEquipo.Text = ""
        txt_box_nomEstado.Text = ""

        cargarGrilla()
    End Sub

    Private Sub btn_cambiar_estado_Click(sender As Object, e As EventArgs) Handles btn_cambiar_estado.Click
        Try
            Dim strSQL = "UPDATE Equipo SET nombre = '" & txt_box_nombreEq.Text & "', descripción = '" & txt_box_desEquipo.Text & "' WHERE idEquipo = " & Convert.ToInt32(txt_box_idEquipo.Text)
            BDHelper.getBDHelper().EjecutarSQL(strSQL)

            MsgBox("Cambios guardados con éxito", MsgBoxStyle.Information, "Aviso")
            cargarGrilla()
        Catch ex As Exception
            MsgBox("Se requiere seleccionar un dato", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dgv_equipos_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_equipos.CellMouseClick
        txt_box_idEquipo.Text = Convert.ToString(dgv_equipos.CurrentRow.Cells(0).Value)
        txt_box_nombreEq.Text = Convert.ToString(dgv_equipos.CurrentRow.Cells(1).Value)
        txt_box_desEquipo.Text = Convert.ToString(dgv_equipos.CurrentRow.Cells(2).Value)
        txt_box_nomEstado.Text = Convert.ToString(dgv_equipos.CurrentRow.Cells(3).Value)
    End Sub

    Private Sub cargarGrilla()
        Dim oEquiposService As New EquiposService
        dgv_equipos.Rows.Clear()
        For Each oEquipo In oEquiposService.listarEquipos()
            With oEquipo
                dgv_equipos.Rows.Add(New String() { .id_Equipo.ToString, .nombre_Equipo, .desc_Equipo, .nom_Estado})
            End With
        Next
    End Sub
End Class