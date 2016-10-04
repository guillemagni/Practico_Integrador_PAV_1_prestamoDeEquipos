Public Class Form_Registrar_Profesor
    Enum Action_type
        insert
        update
    End Enum

    Public action As Action_type

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub Form_Registrar_Profesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim objHelper As BDHelper = BDHelper.getBDHelper
        Dim dt As New DataTable

        'Hacemos los controles de que las variables tengan valor 
        If String.IsNullOrEmpty(txt_box_idProfesor.Text) Or String.IsNullOrEmpty(txt_box_nombre_profesor.Text) Or String.IsNullOrEmpty(txt_box_apellido_profesor.Text) Then
            MsgBox("Datos requeridos", vbCritical, "Aviso")
            Exit Sub
        End If

        'Tomamos los valores 
        Dim idProfe As String = txt_box_idProfesor.Text
        Dim nombreProfe As String = txt_box_nombre_profesor.Text
        Dim apeProfe As String = txt_box_apellido_profesor.Text
        Dim idEstado As Integer = txt_box_Est.Text

        Dim sentenciaSQL As String = "INSERT INTO Profesor VALUES (" & idProfe & ",'" & nombreProfe & "', '" & apeProfe & "', " & idEstado & ")"


        'Ingresamos los datos a la base de datos a travez de un objeto helper
        objHelper.EjecutarSQL(sentenciaSQL)


        'Avisamos que la carga fue exitosa
        MessageBox.Show("Los datos se guardaron correctamente")

        'Cerramos la ventana
        Me.Close()
    End Sub
End Class