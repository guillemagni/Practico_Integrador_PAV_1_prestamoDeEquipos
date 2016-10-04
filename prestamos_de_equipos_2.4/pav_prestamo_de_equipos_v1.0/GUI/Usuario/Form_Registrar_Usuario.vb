Imports System.Data.SqlClient
Public Class Form_Registrar_Usuario
    Private Sub Form_Registrar_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim objHelper As BDHelper = BDHelper.getBDHelper

        'Hacemos los controles de que las variables tengan valor 
        If String.IsNullOrEmpty(txt_box_apellido_usuario.Text) Or String.IsNullOrEmpty(txt_box_nickname_usuario.Text) Or String.IsNullOrEmpty(txt_box_nombre_usuario.Text) Or String.IsNullOrEmpty(txt_box_password_usuario.Text) Then
            MsgBox("Usuario y Password son requeridos", vbCritical, "Aviso")
            Exit Sub
        End If


        'Tomamos los valores 
        Dim nom_user As String = txt_box_nombre_usuario.Text
        Dim ape_user As String = txt_box_apellido_usuario.Text
        Dim nick_user As String = txt_box_nickname_usuario.Text
        Dim pass_user As String = txt_box_password_usuario.Text


        Dim sentenciaSQL As String = "INSERT INTO Usuario(nombreUsuario,contraseña,nombrePerfil,apellidoPerfil) VALUES ('" & nick_user & "','" & pass_user & "', '" & nom_user & "', '" & ape_user & "')"

        'Ingresamos los datos a la base de datos a travez de un objeto helper
        objHelper.EjecutarSQL(sentenciaSQL)


        'Avisamos que la carga fue exitosa
        MessageBox.Show("Los datos se guardaron correctamente")

        'Cerramos la ventana
        Me.Close()


        'Try
        '    conectarse()
        'Tomamos los valores 
        'Dim nom_user As String = txt_box_nombre_usuario.Text
        'Dim ape_user As String = txt_box_apellido_usuario.Text
        'Dim nick_user As String = txt_box_nickname_usuario.Text
        'Dim pass_user As String = txt_box_password_usuario.Text


        '    'String que contiene la sentencia sql
        '    Dim cadena As String = "INSERT INTO Usuario(nombreUsuario,contraseña,nombrePerfil,apellidoPerfil) VALUES ('" & nick_user & "','" & pass_user & "', '" & nom_user & "', '" & ape_user & "')"

        '    cmd = New SqlCommand(cadena, cnn)
        '    cmd.ExecuteNonQuery()

        '    MessageBox.Show("Los datos se guardaron correctamente")

        '    'Limpiamos los campos
        '    txt_box_apellido_usuario.Text = ""
        '    txt_box_nickname_usuario.Text = ""
        '    txt_box_nombre_usuario.Text = ""
        '    txt_box_password_usuario.Text = ""

        '    'Cerramos conexión
        '    cnn.Close()
        'Catch ex As Exception
        '    Debug.print("ERROR: " & ex.Message)
        'End Try


    End Sub
End Class