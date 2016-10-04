Public Class TurnoDao
    Public Function getTurno(ByVal idTurno As Integer)
        'Permite obtener un usuario a partir de su nickname y su password 
        Dim objTurno As Turno = Nothing
        Dim objTable As DataTable
        Dim sentenciaSQL As String

        'Armamos la sentencia SQL para buscar el usuario en la base de datos
        sentenciaSQL = "SELECT * FROM Turno WHERE idTurno =  '" & idTurno & "'"

        objTable = BDHelper.getBDHelper.ConsultarSQL(sentenciaSQL)

        If objTable.Rows.Count() > 0 Then
            objTurno = New Turno
            objTurno.desc_Turno = objTable.Rows(0).Item("descripción").ToString
            objTurno.id_Turno = objTable.Rows(0).Item("idTurno").ToString
            objTurno.hora_Inicio = objTable.Rows(0).Item("horaInicio").ToString
            objTurno.hora_Fin = objTable.Rows(0).Item("horaFin").ToString
        Else
            MsgBox("No se encontro el usuario")
        End If

        Return objTurno


    End Function 'And My Life 

    Public Function getAllTurno() As List(Of Turno)
        Dim objTurno As Turno
        Dim turnos As New List(Of Turno)
        Dim sentenciaSQL As String

        sentenciaSQL = "SELECT * FROM Turno"

        For Each row As DataRow In BDHelper.getBDHelper.ConsultarSQL(sentenciaSQL).Rows
            objTurno = New Turno()
            With objTurno
                .id_Turno = Convert.ToInt32(row.Item("idTurno").ToString)
                .desc_Turno = row.Item("descripción").ToString
                .hora_Inicio = row.Item("horaInicio").ToString
                .hora_Fin = row.Item("horaFin").ToString
            End With
            turnos.Add(objTurno)

        Next
        Return turnos
    End Function
End Class
