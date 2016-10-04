Public Class Form_Eliminar_Equipo
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim objEquipoService As New EquiposService
        Dim objEquipo As Equipos

        'Busco al Equipo
        Try
            objEquipo = objEquipoService.buscarEquipos(Convert.ToInt32(txt_idEquipo.Text))

            'Lleno los campos con los datos actuales del usuario.
            lbl_valor_id_equipo.Text = objEquipo.id_Equipo
            lbl_valor_nombre_equipo.Text = objEquipo.nombre_Equipo
            lbl_valor_descripcion_equipo.Text = objEquipo.desc_Equipo
            lbl_valor_id_estado_equipo.Text = objEquipo.nom_Estado

            btn_eliminar.Enabled = True
        Catch ex As Exception
            MsgBox("Número de identificación del equipo requerido", vbCritical, "Aviso")
            lbl_idEquipo.ForeColor = Color.Red
            lbl_idEquipo.Text = "Id del Equipo*"
            btn_eliminar.Enabled = False
        End Try
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim objHelper As BDHelper = BDHelper.getBDHelper
        Dim _idEquipo As Integer = txt_idEquipo.Text
        Dim sentenciaSql As String = "DELETE FROM Equipo WHERE idEquipo=" & _idEquipo

        objHelper.EjecutarSQL(sentenciaSql)

        MsgBox("¡Equipo Eliminado!", MsgBoxStyle.Information, "Eliminar")

        txt_idEquipo.Text = ""
        lbl_idEquipo.ForeColor = Color.Black
        lbl_idEquipo.Text = "Id del Equipo"

        lbl_valor_id_equipo.Text = "null"
        lbl_valor_nombre_equipo.Text = "null"
        lbl_valor_descripcion_equipo.Text = "null"
        lbl_valor_id_estado_equipo.Text = "null"

    End Sub

    Private Sub Form_Eliminar_Equipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class