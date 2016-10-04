Public Class CursoDao
    Public Function searchCurso(ByVal nroCurso, ByVal letraCurso)
        Dim objCurso As Curso = Nothing
        Dim objTable As DataTable
        Dim sentenciaSQL As String

        sentenciaSQL = "SELECT C.* FROM Curso C WHERE C.nroCurso =" & nroCurso & " AND C.letraCurso =" & letraCurso

        objTable = BDHelper.getBDHelper.ConsultarSQL(sentenciaSQL)

        If objTable.Rows.Count() > 0 Then
            objCurso = New Curso
            objCurso.nro_Curso = objTable.Rows(0).Item("nroCurso").ToString
            objCurso.letra_Curso = objTable.Rows(0).Item("letraCurso").ToString
            objCurso.id_Turno = objTable.Rows(0).Item("idTurno").ToString
        End If
        Return objCurso
    End Function

    Public Function getAll() As List(Of Curso)
        Dim objCurso As Curso
        Dim listaCursos As New List(Of Curso)
        Dim strSQL = "SELECT C.* From Curso C"

        'Con la tabla devuelta por el Helper creamos N OBJETOS Equipos a partir de los datos de la/s filas de la tabla Equipo

        For Each row As DataRow In BDHelper.getBDHelper().ConsultarSQL(strSQL).Rows
            objCurso = New Curso()
            With objCurso
                .nro_Curso = Convert.ToInt32(row.Item("nroCurso").ToString)
                .letra_Curso = row.Item("letraCurso").ToString
                .id_Turno = Convert.ToInt32(row.Item("idTurno").ToString)

            End With
            listaCursos.Add(objCurso)

        Next

        Return listaCursos
    End Function

End Class
