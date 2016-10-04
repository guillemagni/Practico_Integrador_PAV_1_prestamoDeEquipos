Public Class Form_Registrar_Equipo
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim objHelper As BDHelper = BDHelper.getBDHelper
        Dim dt As New DataTable

        Try
            'Tomamos los valores 
            Dim _idEquipo As Integer = txt_box_id_equipo.Text
            Dim _nombreEquipo As String = txt_box_nombre_equipo.Text
            Dim _descEquipo As String = txt_box_descripcion_equipo.Text
            Dim _estadoEquipo As Integer = comboBox_Estado.SelectedValue.ToString

            Dim sentenciaSQL As String = "INSERT INTO Equipo VALUES (" & _idEquipo & ", '" & _nombreEquipo & "', '" & _descEquipo & "', " & _estadoEquipo & ")"


            'Ingresamos los datos a la base de datos a travez de un objeto helper
            objHelper.EjecutarSQL(sentenciaSQL)


            'Avisamos que la carga fue exitosa
            MessageBox.Show("Los datos se guardaron correctamente")

            'Vaciamos el contenido
            txt_box_id_equipo.Text = ""
            txt_box_nombre_equipo.Text = ""
            txt_box_descripcion_equipo.Text = ""

            'Cerramos la ventana
            Me.Close()

        Catch ex As Exception
            MsgBox("Se requiere ingresar datos", vbCritical, "Aviso")

            lbl_id_equipo.ForeColor = Color.Red
            lbl_id_equipo.Text = "Identifación del Equipo*"

            lbl_nombre_equipo.ForeColor = Color.Red
            lbl_nombre_equipo.Text = "Nombre del Equipo*"

            lbl_descripcion_equipo.ForeColor = Color.Red
            lbl_descripcion_equipo.Text = "Descripción del Equipo*"

            lbl_id_estado_equipo.ForeColor = Color.Red
            lbl_id_estado_equipo.Text = "Estado del Equipo*"
        End Try

    End Sub

    Private Sub Form_Registrar_Equipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
End Class