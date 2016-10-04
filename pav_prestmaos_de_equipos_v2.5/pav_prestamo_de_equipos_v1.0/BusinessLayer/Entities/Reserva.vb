Public Class Reserva
    Public Property id_Reserva As Integer 'Número de identificación de la Reserva
    Public Property id_Equipo As Integer 'Número de identificación del Equipo que se va a reservar
    Public Property id_Profesor As Integer 'Número de identificación del Profesor quien realiza la reserva
    Public Property nro_Curso As Integer 'Número del curso en donde se registra la reserva
    Public Property letra_Curso As String 'Representa la sección del curso en donde se registra la reserva
    Public Property id_Turno As Integer 'Número de identificación del turno en donde se registra la reserva
    Public Property hora_Desde As String 'Hora de comienzo de la reserva
    Public Property hora_Hasta As String 'Hora de finalización de la reserva
    Public Property nombre_Usuario As String 'Nickname del usuario quién realizó la reserva
    Public Property estado_Res As String 'Número de Identificación del estado en que se encuentra la reserva
End Class
