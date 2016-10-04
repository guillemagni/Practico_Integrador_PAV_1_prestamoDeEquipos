Public Class Form_Registrar_Turno
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub Form_Registrar_Turno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        If String.IsNullOrEmpty(txt_box_id_turno.Text) Or String.IsNullOrEmpty(txt_box_nombre_turno.Text) Or String.IsNullOrEmpty(txt_box_hora_inicio.Text) Or String.IsNullOrEmpty(txt_box_hora_fin.Text) Then
            MsgBox("Se requieren todos los campos completos!")
            Exit Sub
        End If

        Dim objHelper As BDHelper = BDHelper.getBDHelper

        Dim id As Integer = Convert.ToInt32(txt_box_id_turno.Text)
        Dim descripcion As String = txt_box_nombre_turno.Text
        Dim horaInicio As DateTime = Convert.ToDateTime(txt_box_hora_inicio.Text)
        Dim horaFin As DateTime = Convert.ToDateTime(txt_box_hora_fin.Text)

        Dim sentenciaSQL As String = "INSERT INTO Turno(idTurno,descripción,horaInicio,horaFin) VALUES ('" & id & "', '" & descripcion & "', '" & horaInicio & "', '" & horaFin & "')"

        objHelper.EjecutarSQL(sentenciaSQL)
        MessageBox.Show("Los datos se guardaron correctamente")
        Me.Close()

    End Sub
End Class