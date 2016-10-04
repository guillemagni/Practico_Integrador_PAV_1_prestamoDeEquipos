Public Class Form_Principal
    Private Sub Form_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Para ser mas ordenado, le indico al programa que al abrirse se ubique en la esquina superior izquierda
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        'y le doy el tamaño de la pantalla (size) 
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
    End Sub

    Private Sub RegistrarReservaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarReservaToolStripMenuItem.Click
        Form_Registrar_Reserva.ShowDialog()

    End Sub

    Private Sub RegistrarCursoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarCursoToolStripMenuItem.Click
        Form_Registrar_Curso.ShowDialog()

    End Sub

    Private Sub EditarInfoReservaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarInfoReservaToolStripMenuItem.Click
        Form_Editar_Reserva.ShowDialog()

    End Sub

    Private Sub EliminarReservasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarReservasToolStripMenuItem.Click
        Form_Eliminar_Reserva.ShowDialog()

    End Sub

    Private Sub RegistrarEquipoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarEquipoToolStripMenuItem.Click
        Form_Registrar_Equipo.ShowDialog()
    End Sub

    Private Sub EditarEquipoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarEquipoToolStripMenuItem.Click
        Form_Editar_Equipo.ShowDialog()
    End Sub

    Private Sub EliminarEquipoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarEquipoToolStripMenuItem.Click
        Form_Eliminar_Equipo.ShowDialog()
    End Sub

    Private Sub EditarInfoEquipoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarInfoEquipoToolStripMenuItem.Click
        Form_Editar_Equipo.ShowDialog()
    End Sub

    Private Sub EditarEstadoEquipoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarEstadoEquipoToolStripMenuItem.Click
        Form_Editar_Estado_Equipo.ShowDialog()
    End Sub

    Private Sub RegistrarTurnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarTurnoToolStripMenuItem.Click
        Form_Registrar_Turno.ShowDialog()
    End Sub

    Private Sub EditarTurnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarTurnoToolStripMenuItem.Click
        Form_Editar_Turno.ShowDialog()
    End Sub

    Private Sub EliminarTurnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarTurnoToolStripMenuItem.Click
        Form_Eliminar_Turno.ShowDialog()
    End Sub

    Private Sub RegistrarHorarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarHorarioToolStripMenuItem.Click
        Form_Registrar_Horario_X_Turno.ShowDialog()
    End Sub

    Private Sub EditarHorarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarHorarioToolStripMenuItem.Click
        Form_Editar_Horario_X_Turno.ShowDialog()
    End Sub

    Private Sub EliminarHorarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarHorarioToolStripMenuItem.Click
        Form_Eliminar_Horario_X_Turno.ShowDialog()
    End Sub

    Private Sub ConsultarHorarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarHorarioToolStripMenuItem.Click
        Form_Consultar_Horario_X_Turno.ShowDialog()
    End Sub

    Private Sub RegistrarProfesorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarProfesorToolStripMenuItem.Click
        Form_Registrar_Profesor.ShowDialog()
    End Sub

    Private Sub EditarInfoProfesorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarInfoProfesorToolStripMenuItem.Click
        Form_Editar_Profesor.ShowDialog()
    End Sub

    Private Sub EditarEstadoProfesorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarEstadoProfesorToolStripMenuItem.Click
        Form_Editar_Estado_Profesor.ShowDialog()
    End Sub

    Private Sub EditarCursoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarCursoToolStripMenuItem.Click
        Form_Editar_Curso.ShowDialog()
    End Sub

    Private Sub EliminarCursoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarCursoToolStripMenuItem.Click
        Form_Eliminar_Curso.ShowDialog()
    End Sub

    Private Sub RegistrarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarUsuarioToolStripMenuItem.Click
        Form_Registrar_Usuario.ShowDialog()
    End Sub

    Private Sub EditarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarUsuarioToolStripMenuItem.Click
        Form_Editar_Usuario.ShowDialog()
    End Sub

    Private Sub EliminarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarUsuarioToolStripMenuItem.Click
        Form_Eliminar_Usuario.ShowDialog()
    End Sub

    Private Sub ConsultarReservaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarReservaToolStripMenuItem.Click
        Form_Consultar_Reservas.ShowDialog()
    End Sub


    Private Sub Form_Principal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        MsgBox("Sesión cerrada", MsgBoxStyle.Information, "¡Hasta pronto!")
        Form_Login.Show()
        Form_Login.txtUsuario.Clear()
        Form_Login.txtContra.Clear()
    End Sub

End Class