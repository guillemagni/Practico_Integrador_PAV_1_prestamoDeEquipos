Public Class UserService
    'Creamos un objeto UserDao
    Private objUserDao As UserDao

    'Constructor
    Public Sub New()
        objUserDao = New UserDao
    End Sub

    'Utiliza el metodo getUser de la clase UserDao para obteer un objeto User que cumpla con los parametros que le pasamos
    Public Function validarUsuario(ByVal user As String, ByVal pass As String) As User
        Return objUserDao.getUser(user, pass)
    End Function

    Public Function buscarUsuario(ByVal user As String) As User
        Return objUserDao.searchUser(user)
    End Function

End Class
