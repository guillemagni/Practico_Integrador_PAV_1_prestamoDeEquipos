Public Class Form_Registrar_Horario_X_Turno
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub Form_Registrar_Horario_X_Turno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim objHelper As BDHelper = BDHelper.getBDHelper
        Dim dt As New DataTable

        'Hacemos los controles de que las variables tengan valor 
        If String.IsNullOrEmpty(txt_box_id_turno.Text) Or String.IsNullOrEmpty(txt_box_nro_horario.Text) Then
            MsgBox("Datos requeridos", vbCritical, "Aviso")
            lbl_id_turno.ForeColor = Color.Red
            lbl_id_turno.Text = "Identificación de Turno*"

            lbl_nro_horario.ForeColor = Color.Red
            lbl_nro_horario.Text = "Número de Horario*"
            Exit Sub
        End If

        'Tomamos los valores 
        Dim _idTurno As Integer = txt_box_id_turno.Text
        Dim _nroHorario As Integer = txt_box_nro_horario.Text
        Dim _horaInicio As String = txt_box_hora_inicio.Text
        Dim _horaFin As String = txt_box_hora_fin.Text



        Dim sentenciaSQL As String = "INSERT INTO HorarioXTurno VALUES (" & _idTurno & ", " & _nroHorario & ", '" & _horaInicio & "', '" & _horaFin & "')"


        'Ingresamos los datos a la base de datos a travez de un objeto helper
        objHelper.EjecutarSQL(sentenciaSQL)


        'Avisamos que la carga fue exitosa
        MessageBox.Show("Los datos se guardaron correctamente")

        'Cerramos la ventana
        Me.Close()
    End Sub
End Class