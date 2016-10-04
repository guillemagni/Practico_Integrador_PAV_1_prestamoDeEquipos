Public Class Form_Editar_Profesor
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_editar_estado_equipo_Click(sender As Object, e As EventArgs) Handles btn_editar_estado_equipo.Click
        Form_Editar_Estado_Profesor.ShowDialog()
    End Sub

    Private Sub Form_Editar_Profesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oProfesorService As New ProfesorService
        dgv_profesores.Rows.Clear()
        For Each oProfesor In oProfesorService.listarProfesores()
            With oProfesor
                dgv_profesores.Rows.Add(New String() { .id_profe.ToString, .nom_profe, .ape_profe, .nom_estado})
            End With
        Next
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click

    End Sub

    Private Sub dgv_profesores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_profesores.CellContentClick

    End Sub
End Class