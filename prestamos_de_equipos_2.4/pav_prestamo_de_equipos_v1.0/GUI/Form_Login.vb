Public Class Form_Login

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        'Objetos
        Dim objUserService As New UserService
        Dim objUser As User

        'Comprobamos que los campos no esten vacios 
        If String.IsNullOrEmpty(txtUsuario.Text) Or String.IsNullOrEmpty(txtContra.Text) Then
            MsgBox("Usuario y Password son requeridos", vbCritical, "Aviso")
            Exit Sub
        End If

        'Le damos al objUser el usuario que devuelva el validarUsuario del objUserService
        'Que va a ser un objeto User que concuerde con los datos ingresados en los campos
        objUser = objUserService.validarUsuario(txtUsuario.Text, txtContra.Text)

        If Not IsNothing(objUser) Then
            MsgBox("Bienvenido usuario: " + Me.txtUsuario.Text, MsgBoxStyle.Information, "¡Usuario correcto!")
            Form_Principal.Show()
            Me.Hide()
        Else
            lbl_mensaje.ForeColor = Color.Red
            lbl_mensaje.Text = "Usuario o clave incorrectos"
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MessageBox.Show("¿Está seguro que desea cancelar la operación?", "Importante.",
                           MessageBoxButtons.OKCancel, MessageBoxIcon.Question) =
                           Windows.Forms.DialogResult.OK Then
            Me.Close()
        Else
        End If
    End Sub

End Class