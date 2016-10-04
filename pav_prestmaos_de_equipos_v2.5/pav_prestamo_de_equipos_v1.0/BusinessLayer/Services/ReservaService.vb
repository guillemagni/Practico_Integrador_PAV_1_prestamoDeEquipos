Public Class ReservaService
    'Creamos un objeto HorarioDao
    Private objReservaDao As ReservaDao

    'Constructor
    Public Sub New()
        objReservaDao = New ReservaDao
    End Sub
End Class
