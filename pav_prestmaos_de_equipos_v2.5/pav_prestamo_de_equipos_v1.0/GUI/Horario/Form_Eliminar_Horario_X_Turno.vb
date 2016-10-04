Imports System.ComponentModel

Public Class Form_Eliminar_Horario_X_Turno
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub Form_Eliminar_Horario_X_Turno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'llenamos el combo box
        Dim oTurnoService As New TurnoService
        Form_Editar_Horario_X_Turno.llenarCombo(cb_IdTurno, oTurnoService.mostrarTurnos(), "desc_Turno", "id_Turno")

        'Vaciamos los campos
        vaciarCampos()

        'Deshabilitamos el botón Eliminar hasta que ingrese los datos a buscar        
        btn_eliminar.Enabled = False
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        'Verificamos que el turno este seleccionado
        Dim idTurno As Integer = -1
        If cb_IdTurno.SelectedIndex <> -1 Then
            idTurno = cb_IdTurno.SelectedValue
        Else
            MsgBox("Campo <TURNO> es obligatorio.", vbCritical + vbOKOnly, "Aviso")
            cb_IdTurno.Focus()
            Exit Sub
        End If

        'Verificamos se haya ingresado un número de horario
        If String.IsNullOrEmpty(txt_box_nro_horario.Text) Then
            MsgBox("Campo <NÚMERO HORARIO> es obligatorio.", vbCritical + vbOKOnly, "Aviso")
            txt_box_nro_horario.Focus()
            Exit Sub
        End If

        'Cargamos los datos que se van a eliminar
        cargarTextBoxConFiltros(idTurno, Convert.ToUInt32(txt_box_nro_horario.Text))

        'Habilito el botón Eliminar
        btn_eliminar.Enabled = True

    End Sub

    Public Sub cargarTextBoxConFiltros(ByVal idTurno As Integer, ByVal nroHorario As Integer)
        Dim objHorarioService As New HorarioService
        Dim objHorario As Horario

        objHorario = objHorarioService.listarHorariosConFiltros(idTurno, nroHorario)
        txt_box_nro_horario.Text = ""

        With objHorario
            Try
                txt_rptaIdTurno.Text = .nomTurno
                txt_rptaNroHorario.Text = .nro_Horario.ToString
                txt_rptaHInicio.Text = .hora_Inicio
                txt_rptaHFin.Text = .hora_Fin
            Catch ex As Exception
                MsgBox("No se encontró el horario", vbCritical + vbOKOnly, "Aviso")
                btn_eliminar.Enabled = False
            End Try
        End With
    End Sub

    Public Sub vaciarCampos()
        cb_IdTurno.SelectedIndex = -1
        txt_box_nro_horario.Text = ""
        txt_rptaIdTurno.Text = ""
        txt_rptaNroHorario.Text = ""
        txt_rptaHInicio.Text = ""
        txt_rptaHFin.Text = ""
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim objHorarioService As New HorarioService
        Dim oHorario As New Horario

        If cb_IdTurno.SelectedIndex <> -1 Then oHorario.id_Turno = cb_IdTurno.SelectedValue
        oHorario.nro_Horario = txt_rptaNroHorario.Text

        Dim rpta As Boolean = objHorarioService.eliminarHorario(oHorario)

        If rpta Then
            MsgBox("Operación realizada exitosamente.", vbOKOnly + MsgBoxStyle.Information, "Aviso")
            vaciarCampos()
            Me.Close()
        Else
            MsgBox("Operación NO se realizó con éxito.", vbCritical + vbOKOnly, "Aviso")
        End If
    End Sub
End Class