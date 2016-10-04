Public Class Form_Registrar_Horario_X_Turno
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub Form_Registrar_Horario_X_Turno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'llenamos el combo box
        Dim oTurnoService As New TurnoService
        Form_Editar_Horario_X_Turno.llenarCombo(cb_idTurno, oTurnoService.mostrarTurnos(), "desc_Turno", "id_Turno")

        'Vaciamos los campos
        vaciarCampos()
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim objHorarioService As New HorarioService
        Dim oHorario As New Horario

        'Verificamos que haya seleccionado un Turno
        Dim idTurno As Integer = -1
        If cb_idTurno.SelectedIndex <> -1 Then
            idTurno = cb_idTurno.SelectedValue
        Else
            MsgBox("Campo <TURNO> es obligatorio.", vbCritical + vbOKOnly, "Aviso")
            cb_idTurno.Focus()
            Exit Sub
        End If

        'Verificamos que haya ingresado un número de horario
        If String.IsNullOrEmpty(txt_box_nro_horario.Text) Then
            MsgBox("Campo <NÚMERO HORARIO> es obligatorio.", vbCritical + vbOKOnly, "Aviso")
            txt_box_nro_horario.Focus()
            Exit Sub
        End If

        'Llenamos el objeto con valores
        oHorario.id_Turno = idTurno
        oHorario.nro_Horario = txt_box_nro_horario.Text
        oHorario.hora_Inicio = txt_box_hora_inicio.Text
        oHorario.hora_Fin = txt_box_hora_fin.Text

        'Llamamos el método registrarHorario del HorarioService para agregar un nuevo Horario
        Dim rpta As Boolean = objHorarioService.registrarHorario(oHorario, True)

        'Verificamos si pudo ingresarse correctamente a la Base de Datos
        If rpta Then
            MsgBox("Operación realizada exitosamente.", vbOKOnly + MsgBoxStyle.Information, "Aviso")
            vaciarCampos()
            Me.Close()
        Else
            MsgBox("Operación NO se realizó con éxito.", vbCritical + vbOKOnly, "Aviso")
        End If
    End Sub

    Public Sub vaciarCampos()
        cb_idTurno.SelectedIndex = -1
        txt_box_nro_horario.Text = ""
        txt_box_hora_inicio.Text = ""
        txt_box_hora_fin.Text = ""
    End Sub

End Class