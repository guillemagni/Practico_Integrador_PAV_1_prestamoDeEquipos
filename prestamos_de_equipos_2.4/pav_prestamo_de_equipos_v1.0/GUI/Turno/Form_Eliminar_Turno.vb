Public Class Form_Eliminar_Turno
    Private Sub Form_Eliminar_Turno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim objTurnoService As New TurnoService
        Dim objTurno As Turno

        If String.IsNullOrEmpty(TextBox1.Text) Then
            MsgBox("identificacion del turno requerida!", vbCritical, "Aviso")
        End If

        Try
            objTurno = objTurnoService.buscarTurno(Convert.ToInt32(TextBox1.Text))

            lbl_valor_nombre_turno.Text = objTurno.desc_Turno
            lbl_valor_hora_inicio.Text = Convert.ToString(objTurno.hora_Inicio)
            lbl_valor_hora_fin.Text = Convert.ToString(objTurno.hora_Fin)

            btn_eliminar.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim Helper As BDHelper = BDHelper.getBDHelper
        Dim turno As Integer = Convert.ToInt32(TextBox1.Text)
        Dim sentenciaSQL As String = "DELETE FROM Turno WHERE idTurno = " & turno

        Helper.EjecutarSQL(sentenciaSQL)
        MsgBox("Turno Eliminado!")
        Me.Close()

    End Sub
End Class