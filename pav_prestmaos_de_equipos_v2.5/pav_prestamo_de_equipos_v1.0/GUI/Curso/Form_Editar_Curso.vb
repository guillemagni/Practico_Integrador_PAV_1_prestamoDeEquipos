Imports System.Data.SqlClient

Public Class Form_Editar_Curso


    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub Form_Editar_Curso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_box_id_turno.Text = ""
        txt_box_letra_curso.Text = ""
        txt_box_nro_curso.Text = ""

        cargarGrilla()
    End Sub

    Private Sub dgv_equipos_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        txt_box_nro_curso.Text = Convert.ToString(DataGridView1.CurrentRow.Cells(0).Value)
        txt_box_letra_curso.Text = Convert.ToString(DataGridView1.CurrentRow.Cells(1).Value)
        txt_box_id_turno.Text = Convert.ToString(DataGridView1.CurrentRow.Cells(2).Value)

    End Sub

    Private Sub cargarGrilla()
        Dim objCursoService As New CursoService
        DataGridView1.Rows.Clear()
        For Each objCurso In objCursoService.listarCursos()
            With objCurso
                DataGridView1.Rows.Add(New String() { .nro_Curso.ToString, .letra_Curso, .id_Turno.ToString})
            End With
        Next
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Try
            Dim strSQL = "UPDATE Curso SET nroCurso = '" & Convert.ToInt32(txt_box_nro_curso.Text) & "', letraCurso = '" & txt_box_letra_curso.Text & "', idTurno= '" & Convert.ToInt32(txt_box_id_turno.ToString) & "' WHERE nroCurso = " & Convert.ToInt32(txt_box_nro_curso.Text) & " AND letraCurso = " & txt_box_letra_curso.Text
            BDHelper.getBDHelper().EjecutarSQL(strSQL)

            MsgBox("Cambios guardados con éxito", MsgBoxStyle.Information, "Aviso")
            cargarGrilla()
        Catch ex As Exception
            MsgBox("Se requiere seleccionar un dato", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class