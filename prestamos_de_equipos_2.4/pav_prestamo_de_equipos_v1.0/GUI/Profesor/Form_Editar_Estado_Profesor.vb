Public Class Form_Editar_Estado_Profesor
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub



    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click

        Dim objProfesorService As New ProfesorService
        Dim objProfesor As Profesor

        'Compruebo que el campo de búsqueda NO esté vacío
        If String.IsNullOrEmpty(txt_box_id_profesor.Text) Then
            MsgBox("Número de Identificación requerido", vbCritical, "Aviso")
            lbl_id_profesor.ForeColor = Color.Red
            lbl_id_profesor.Text = "Id de Profesor*"
            Exit Sub
        End If

        Try
            'Busco al Profesor
            objProfesor = objProfesorService.buscarProfesor(Convert.ToInt32(txt_box_id_profesor.Text))

            'Lleno los campos con los datos actuales del Profesor.
            txb_nomProfe.Text = objProfesor.nom_profe
            txb_apeProfe.Text = objProfesor.ape_profe
            lbl_estado_profesor.Text = objProfesor.id_estado
            btn_cambiar_estado.Enabled = True
        Catch ex As Exception
            MsgBox("No se encontró a ningún profesor con ese número de identificación")
            btn_cambiar_estado.Enabled = False
        End Try

    End Sub

    Private Sub btn_cambiar_estado_Click(sender As Object, e As EventArgs) Handles btn_cambiar_estado.Click
        Dim objHelper As BDHelper = BDHelper.getBDHelper

        Dim nvoEstado As Integer = txt_box_nuevo_estado_profesor.Text
        Dim idProfe As Integer = txt_box_id_profesor.Text

        Dim sentenciaSql As String = "UPDATE Profesor SET idEstado= " & nvoEstado & " WHERE idProfesor=" & idProfe


        'Ingresamos los datos a la base de datos a través de un Objeto Helper
        objHelper.EjecutarSQL(sentenciaSql)

        'limpiamos los campos
        txt_box_id_profesor.Text = ""
        txb_nomProfe.Text = ""
        txb_apeProfe.Text = ""
        lbl_estado_profesor.Text = "null"
        txt_box_nuevo_estado_profesor.Text = ""
        btn_cambiar_estado.Enabled = False

        'Avisamos que la carga fue exitosa
        MessageBox.Show("Los datos se guardaron correctamente")

        'Cerramos la ventana
        Me.Close()
    End Sub

    Private Sub Form_Editar_Estado_Profesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_box_id_profesor.Text = ""
        txb_nomProfe.Text = ""
        txb_apeProfe.Text = ""
        lbl_estado_profesor.Text = "null"
        txt_box_nuevo_estado_profesor.Text = ""
        btn_cambiar_estado.Enabled = False
    End Sub
End Class