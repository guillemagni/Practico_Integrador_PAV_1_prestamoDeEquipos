Public Class HorarioService
    'Creamos un objeto HorarioDao
    Private objHorarioDao As HorarioDao

    'Constructor
    Public Sub New()
        objHorarioDao = New HorarioDao
    End Sub

    'Utiliza el metodo getHorario de la clase HorarioDao para obteer un objeto Horario que cumpla con los parametros que le pasamos
    Public Function listarHorarios() As List(Of Horario)
        Return objHorarioDao.getAll()
    End Function

    Public Function listarHorariosConFiltros(ByVal idTurno As Integer, ByVal nroHorario As Integer) As Horario
        Return objHorarioDao.getHorario(idTurno, nroHorario)
    End Function

    Public Function listarHorariosConFiltroTurno(ByVal idTurno As Integer) As List(Of Horario)
        Return objHorarioDao.getHorarioTurno(idTurno)
    End Function

    Public Function actualizarHorario(ByVal oHorario As Horario, ByVal isNew As Boolean) As Boolean
        Return objHorarioDao.update(oHorario)
    End Function

    Public Function registrarHorario(ByVal oHorario As Horario, ByVal isNew As Boolean) As Boolean
        Return objHorarioDao.add(oHorario)
    End Function

    Public Function eliminarHorario(ByVal oHorario As Horario) As Boolean
        Return objHorarioDao.delete(oHorario)
    End Function

End Class
