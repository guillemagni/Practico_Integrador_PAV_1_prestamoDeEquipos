Imports System.Data.SqlClient

Public Class Form_Eliminar_Curso
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub Form_Eliminar_Curso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        conectarse()
        Dim nroCurso As String = txt_box_nro_curso.Text
        Dim letraCurso As String = txt_box_letra_curso.Text

        Dim cadena As String = "SELECT nroCurso, letraCurso, idTurno FROM Curso WHERE nroCurso = " & nroCurso & " AND letraCurso = '" & letraCurso & "'"

        cmd = New SqlCommand(cadena, cnn)
        Dim registro As SqlDataReader
        registro = cmd.ExecuteReader()

        If registro.Read() Then
            lbl_valor_nro_curso.Text = registro("nroCurso")
            lbl_valor_categoria_curso.Text = registro("letraCurso")
            lbl_valor_id_turno.Text = registro("idTurno")
            btn_eliminar.Enabled = True
        Else
            MsgBox("No existe ningún curso con esas características")
        End If
        cnn.Close()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        conectarse()
        Dim nroCurso As String = txt_box_nro_curso.Text
        Dim letraCurso As String = txt_box_letra_curso.Text
        Dim cadena As String = "DELETE FROM Curso WHERE nroCurso = " & nroCurso & " AND letraCurso = '" & letraCurso & "'"

        cmd = New SqlCommand(cadena, cnn)
        Dim cant As Integer
        cant = cmd.ExecuteNonQuery()
        If cant = 1 Then
            txt_box_nro_curso.Text = ""
            txt_box_letra_curso.Text = ""
            lbl_valor_nro_curso.Text = ""
            lbl_valor_categoria_curso.Text = ""
            lbl_valor_id_turno.Text = ""
            MessageBox.Show("Se borró el curso")
        Else
            MessageBox.Show("No existe un curso con las características ingresadas")
        End If
        cnn.Close()
    End Sub
End Class