Imports System.Data.SqlClient

Public Class Form_Registrar_Curso
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click

        Try

            conectarse()
            Dim nroCurso As String = txt_box_nro_curso.Text
            Dim catCurso As String = txt_box_letra_curso.Text
            Dim turno As String = txt_box_turno.Text

            Dim cadena As String = "INSERT INTO Curso (nroCurso, letraCurso, idTurno) VALUES (" & nroCurso & ", '" & catCurso & "', " & turno & ")"

            Dim cmd As SqlCommand
            cmd = New SqlCommand(cadena, cnn)
            cmd.ExecuteNonQuery()

            MsgBox("Curso registrado con éxito")

            txt_box_nro_curso.Text = ""
            txt_box_letra_curso.Text = ""
            txt_box_turno.Text = ""

        Catch ex2 As SqlException
            MsgBox("Los datos ingresados, son incorrectos")

        Catch ex As Exception


        End Try

    End Sub

    Private Sub Form_Registrar_Curso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class