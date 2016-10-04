Public Class CursoService

    Private objCursoDao As CursoDao

    Public Sub New()
        objCursoDao = New CursoDao
    End Sub

    Public Function buscarCurso(ByVal nroCurso As Integer, ByVal letraCurso As String) As Equipos
        Return objCursoDao.searchCurso(nroCurso, letraCurso)
    End Function

    Public Function listarCursos() As List(Of Curso)
        Return objCursoDao.getAll()
    End Function
End Class
