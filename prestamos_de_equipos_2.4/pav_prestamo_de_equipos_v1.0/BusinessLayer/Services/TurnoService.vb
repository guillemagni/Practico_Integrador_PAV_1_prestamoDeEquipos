Public Class TurnoService
    Private objTurnoDao As TurnoDao
    Public Sub New()
        objTurnoDao = New TurnoDao
    End Sub

    Public Function buscarTurno(ByVal idTurno As Integer) As Turno
        Return objTurnoDao.getTurno(idTurno)
    End Function

    Public Function mostrarTurnos() As List(Of Turno)
        Return objTurnoDao.getAllTurno()

    End Function
End Class

