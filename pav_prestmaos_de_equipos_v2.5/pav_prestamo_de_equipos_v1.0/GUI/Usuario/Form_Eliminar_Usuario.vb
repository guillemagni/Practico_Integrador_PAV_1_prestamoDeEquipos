Imports System.Data.SqlClient

Public Class Form_Eliminar_Usuario
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click

        Dim objHelper As BDHelper = BDHelper.getBDHelper
        Dim user As String = txt_box_nickname_usuario.Text
        Dim sentenciaSql As String = "DELETE FROM Usuario WHERE nombreUsuario='" & user & "'"

        objHelper.EjecutarSQL(sentenciaSql)

        MessageBox.Show("Usuario Eliminado!")
        Me.Close()

    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim objUserService As New UserService
        Dim objUser As User

        'Compruebo que el campo de busqueda no este vacio
        If String.IsNullOrEmpty(txt_box_nickname_usuario.Text) Then
            MsgBox("Nickname de usuario requerido", vbCritical, "Aviso")
            Exit Sub
        End If

        'Busco la usuario
        Try
            objUser = objUserService.buscarUsuario(txt_box_nickname_usuario.Text)

            'Lleno los campos con los datos actuales del usuario.
            lbl_valor_nombre.Text = objUser.nom_user
            lbl_valor_apellido.Text = objUser.ape_user
            lbl_valor_nickname.Text = objUser.nick_user

            btn_eliminar.Enabled = True
        Catch ex As NullReferenceException
            MsgBox("No se encontró al usuario ingresado, intentelo nuevamente")
            btn_eliminar.Enabled = False
        End Try

    End Sub

    Private Sub Form_Eliminar_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
