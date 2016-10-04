Public Class Form_Editar_Estado_Equipo

    Private Sub Form_Editar_Estado_Equipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        vaciarCampos()
        Dim dt As New DataTable
        dt.Columns.Add("idEstado")
        dt.Columns.Add("nombreEstado")

        Dim oEquiposService As New EquiposService
        For Each oEquipo In oEquiposService.listarEstados()
            With oEquipo
                dt.Rows.Add(New String() { .id_Estado.ToString, .nom_Estado})
            End With
        Next

        comboBox_Estado.DataSource = dt
        comboBox_Estado.ValueMember = "idEstado"
        comboBox_Estado.DisplayMember = "nombreEstado"

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim objEquiposService As New EquiposService
        Dim objEquipos As Equipos

        'Compruebo que el campo de búsqueda NO esté vacío
        If String.IsNullOrEmpty(txt_box_idEquipo.Text) Then
            lbl_IdEquipo.ForeColor = Color.Red
            lbl_IdEquipo.Text = "Id del Equipo*"
        End If

        Try
            'Busco el equipo
            objEquipos = objEquiposService.buscarEquipos(Convert.ToInt32(txt_box_idEquipo.Text))

            'Lleno los campos con los datos actuales del Equipo
            txb_nomEquipo.Text = objEquipos.nombre_Equipo
            txb_descripEquipo.Text = objEquipos.desc_Equipo
            lbl_estado_actual_equipo.Text = objEquipos.nom_Estado
            comboBox_Estado.Enabled = True
            btn_cambiar_estado.Enabled = True

        Catch ex As Exception
            MsgBox("Número de identificación no corresponde a ningún equipo", MsgBoxStyle.Critical, "Error")
            btn_cambiar_estado.Enabled = False
        End Try

    End Sub

    Private Sub btn_cambiar_estado_Click(sender As Object, e As EventArgs) Handles btn_cambiar_estado.Click
        Dim objHelper As BDHelper = BDHelper.getBDHelper

        Dim _nvoEstado As Integer = comboBox_Estado.SelectedValue.ToString
        Dim _idEquipo As Integer = txt_box_idEquipo.Text


        Dim sentenciaSql As String = "UPDATE Equipo SET idEstado= " & _nvoEstado & " WHERE idEquipo=" & _idEquipo

        'Ingresamos los datos a la base de datos a través de un Objeto Helper
        objHelper.EjecutarSQL(sentenciaSql)

        'Avisamos que la carga fue exitosa
        MsgBox("Se realizó correctamente el cambio de estado del equipo: " + txb_nomEquipo.Text, MsgBoxStyle.Information, "Cambio de estado")

        'Limpiamos los campos y deshabilitamos el botón        
        vaciarCampos()
        comboBox_Estado.Enabled = False

        'Cerramos la ventana
        Me.Close()
    End Sub

    Private Sub vaciarCampos()
        lbl_IdEquipo.ForeColor = Color.Black
        lbl_IdEquipo.Text = "Id del Equipo"
        txt_box_idEquipo.Text = ""
        txb_nomEquipo.Text = ""
        txb_descripEquipo.Text = ""
        lbl_estado_actual_equipo.Text = "null"
        btn_cambiar_estado.Enabled = False
    End Sub
End Class