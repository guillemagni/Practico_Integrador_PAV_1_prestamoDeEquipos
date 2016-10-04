Public Class HorarioDao
    Public Function getAll() As List(Of Horario)
        Dim objHorario As Horario
        Dim listarHorarios As New List(Of Horario)
        Dim strSQL = "SELECT HT.*, T.descripción FROM HorarioXTurno HT JOIN Turno T ON HT.idTurno=T.idTurno"

        'Con la tabla devuelta por el Helper creamos N OBJETOS Horarios a partir de los datos de la/s filas de la tabla HorarioXTurno
        For Each row As DataRow In BDHelper.getBDHelper().ConsultarSQL(strSQL).Rows
            objHorario = New Horario()
            With objHorario
                .id_Turno = Convert.ToInt32(row.Item("idTurno").ToString)
                .nro_Horario = row.Item("nroHorario").ToString
                .hora_Inicio = row.Item("horaInicio").ToString
                .hora_Fin = row.Item("horaFin").ToString

                .nomTurno = row.Item("descripción").ToString
            End With
            listarHorarios.Add(objHorario)
        Next

        Return listarHorarios

    End Function

    Public Function getHorario(ByVal idTurno As Integer, ByVal nroHorario As Integer)
        Dim objHorario As Horario = Nothing
        Dim objTable As DataTable
        Dim strSQL = "SELECT HT.*, T.descripción FROM HorarioXTurno HT JOIN Turno T ON HT.idTurno=T.idTurno WHERE HT.idTurno = " & idTurno.ToString & " AND HT.nroHorario = " & nroHorario.ToString

        'Con la tabla devuelta por el Helper devolvemos un Horario a partir de los datos de la/s filas de la tabla HorarioXTurno
        objTable = BDHelper.getBDHelper().ConsultarSQL(strSQL)

        'La tabla ahora tiene los datos de un horario recuperado de la base de datos
        'Con esos datos procedemos a crear un objeto Horario
        If objTable.Rows.Count() > 0 Then 'Rows obtiene la coleccion de filas que pertenecen a la tabla
            objHorario = New Horario()

            With objHorario
                .id_Turno = objTable.Rows(0).Item("idTurno").ToString
                .nro_Horario = objTable.Rows(0).Item("nroHorario").ToString
                .hora_Inicio = objTable.Rows(0).Item("horaInicio").ToString
                .hora_Fin = objTable.Rows(0).Item("horaFin").ToString

                .nomTurno = objTable.Rows(0).Item("descripción").ToString
            End With
        End If

        'Retomamos el Horario recién creado
        Return objHorario

    End Function

    Public Function getHorarioTurno(ByVal idTurno As Integer) As List(Of Horario)
        Dim objHorario As Horario
        Dim listarHorarios As New List(Of Horario)
        Dim strSQL = "SELECT HT.*, T.descripción FROM HorarioXTurno HT JOIN Turno T ON HT.idTurno=T.idTurno WHERE HT.idTurno = " & idTurno.ToString

        'Con la tabla devuelta por el Helper creamos N OBJETOS Horarios a partir de los datos de la/s filas de la tabla HorarioXTurno
        For Each row As DataRow In BDHelper.getBDHelper().ConsultarSQL(strSQL).Rows
            objHorario = New Horario()
            With objHorario
                .id_Turno = Convert.ToInt32(row.Item("idTurno").ToString)
                .nro_Horario = row.Item("nroHorario").ToString
                .hora_Inicio = row.Item("horaInicio").ToString
                .hora_Fin = row.Item("horaFin").ToString

                .nomTurno = row.Item("descripción").ToString
            End With
            listarHorarios.Add(objHorario)
        Next

        Return listarHorarios
    End Function

    Public Function update(ByVal oHorario As Horario) As Boolean
        Dim commandStr As String
        commandStr = "UPDATE HorarioXTurno SET "
        commandStr += "horaInicio='" + oHorario.hora_Inicio + "', "
        commandStr += "horaFin='" + oHorario.hora_Fin + "' "
        commandStr += " WHERE idTurno=" + oHorario.id_Turno.ToString + " AND "
        commandStr += "nroHorario=" + oHorario.nro_Horario.ToString

        Return (BDHelper.getBDHelper().EjecutarSQL(commandStr) = 1)
    End Function

    Public Function add(ByVal oHorario As Horario) As Boolean
        Dim commandStr As String
        commandStr = "INSERT INTO HorarioXTurno VALUES("
        commandStr += oHorario.id_Turno.ToString + ", "
        commandStr += oHorario.nro_Horario.ToString + ", "
        commandStr += "'" + oHorario.hora_Inicio + "', "
        commandStr += "'" + oHorario.hora_Fin + "')"
        Return (BDHelper.getBDHelper().EjecutarSQL(commandStr) = 1)
    End Function

    Public Function delete(ByVal oHorario As Horario) As Boolean
        Dim commandStr As String
        commandStr = "DELETE HorarioXTurno WHERE idTurno = " + oHorario.id_Turno.ToString + " AND nroHorario = " + oHorario.nro_Horario.ToString

        Return (BDHelper.getBDHelper().EjecutarSQL(commandStr) = 1)
    End Function
End Class
