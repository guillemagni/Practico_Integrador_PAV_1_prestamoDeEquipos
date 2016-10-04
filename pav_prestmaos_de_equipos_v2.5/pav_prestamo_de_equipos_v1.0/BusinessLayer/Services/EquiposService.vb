Public Class EquiposService
    'Creamos un objeto EquiposDao
    Private objEquiposDao As EquiposDao

    'Constructor
    Public Sub New()
        objEquiposDao = New EquiposDao
    End Sub

    Public Function buscarEquipos(ByVal _idEquipo As Integer) As Equipos
        Return objEquiposDao.searchEquipo(_idEquipo)
    End Function

    Public Function listarEquipos() As List(Of Equipos)
        Return objEquiposDao.getAll()
    End Function

    Public Function listarEstados() As List(Of Equipos)
        Return objEquiposDao.getAllStates()
    End Function
End Class
