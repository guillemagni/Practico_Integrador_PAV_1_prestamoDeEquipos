Public Class ProfesorService
    'Creamos un objeto ProfesorDao
    Private objProfesorDao As ProfesorDao

    'Constructor
    Public Sub New()
        objProfesorDao = New ProfesorDao
    End Sub

    'Utiliza el metodo getProfesor de la clase ProfesorDao para obtener un objeto Profesor que cumpla con los parametros que le pasamos
    Public Function buscarProfesor(ByVal idProfesor As Integer) As Profesor
        Return objProfesorDao.getProfesor(idProfesor)
    End Function

    Public Function listarProfesores() As List(Of Profesor)
        Return objProfesorDao.getAll()
    End Function

End Class
