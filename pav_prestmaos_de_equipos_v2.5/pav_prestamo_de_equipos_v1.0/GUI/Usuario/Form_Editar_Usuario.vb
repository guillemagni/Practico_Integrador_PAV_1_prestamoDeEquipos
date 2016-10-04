Imports System.Data.SqlClient
Public Class Form_Editar_Usuario
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        'Dim objHelper As BDHelper = BDHelper.getBDHelper()
        Dim objUserService As New UserService
        Dim objUser As User

        'Compruebo que el campo de busqueda no este vacio
        If String.IsNullOrEmpty(txt_box_nickname_usuario.Text) Then
            MsgBox("Nickname de usuario requerido", vbCritical, "Aviso")
            Exit Sub
        End If

        'Busco la usuario
        objUser = objUserService.buscarUsuario(txt_box_nickname_usuario.Text)

        'Lleno los campos con lso datos actuales del usuario.
        txt_box_nombre.Text = objUser.nom_user
        txt_box_apellido.Text = objUser.ape_user
        txt_box_nick.Text = objUser.nick_user
        txt_box_pass.Text = objUser.pass_user

        'Bloquemos la textbox del nick de usuario para no permitir cambios
        txt_box_nick.Enabled = False
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim objHelper As BDHelper = BDHelper.getBDHelper
        Dim name As String = txt_box_nombre.Text
        Dim ape As String = txt_box_apellido.Text
        Dim pass As String = txt_box_pass.Text
        Dim nick As String = txt_box_nick.Text

        Dim sentenciaSql As String = "update Usuario set nombrePerfil='" & name & "', apellidoPerfil='" & ape & "', contraseña= '" & pass & "' where nombreUsuario='" & nick & "'"


        'Ingresamos los datos a la base de datos a travez de un objeto helper
        objHelper.EjecutarSQL(sentenciaSql)

        'limpiamos los campos
        txt_box_nombre.Text = ""
        txt_box_apellido.Text = ""
        txt_box_pass.Text = ""
        txt_box_nick.Text = ""

        'Avisamos que la carga fue exitosa
        MessageBox.Show("Los datos se guardaron correctamente")

        'Cerramos la ventana
        Me.Close()


        'cnn.Open()
        'Dim cod As String = txt_box_nickname_usuario.Text
        'Dim name As String = txt_box_nombre.Text
        'Dim ape As String = txt_box_apellido.Text
        'Dim pass As String = txt_box_pass.Text
        ''Dim nick As String = txt_box_nickname_usuario.Text
        'Dim cadena As String = "update Usuario set nombrePerfil='" & name & "', apellidoPerfil='" & ape & "', contraseña= '" & pass & "' where nombreUsuario='" & cod & "'"

        'cmd = New SqlCommand(cadena, cnn)
        'Dim cant As Integer
        'cant = cmd.ExecuteNonQuery()
        'If cant = 1 Then
        '    MessageBox.Show("Se modificaron los datos del artículo")
        '    txt_box_nombre.Text = ""
        '    txt_box_apellido.Text = ""
        '    txt_box_pass.Text = ""
        '    txt_box_nick.Text = ""
        'Else
        '    MessageBox.Show("No existe un artículo con el código ingresado")
        'End If
        'cnn.Close()
    End Sub
End Class