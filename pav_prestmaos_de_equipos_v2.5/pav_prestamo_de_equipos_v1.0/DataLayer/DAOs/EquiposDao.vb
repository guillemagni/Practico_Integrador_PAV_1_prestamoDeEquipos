Public Class EquiposDao

    Public Function searchEquipo(ByVal idEquipo As Integer)
        'Permite obtener un equipo a partir de su número de identificación
        Dim objEquipos As Equipos = Nothing 'Creamos un objeto Equipos vacío
        Dim objTable As DataTable
        Dim sentenciaSQL As String
        'Armamos la sentencia SQL para buscar al equipo en la base de datos        

        sentenciaSQL = "SELECT E.*, EE.nombre as nombreEstado from Equipo E JOIN EstadoEquipo EE ON E.idEstado=EE.idEstadoEquipo WHERE idEquipo = " & idEquipo

        'Delegamos el trabajo de la consulta SQL a la instancia BDHelper
        objTable = BDHelper.getBDHelper.ConsultarSQL(sentenciaSQL)

        'La tabla ahora tiene los datos de un Equipo recuperado de la base de datos
        'Con esos datos procedemos a crear un objeto Equipo
        If objTable.Rows.Count() > 0 Then 'Rows obtiene la coleccion de filas que pertenecen a la tabla
            objEquipos = New Equipos()
            objEquipos.id_Equipo = objTable.Rows(0).Item("idEquipo").ToString
            objEquipos.nombre_Equipo = objTable.Rows(0).Item("nombre").ToString
            objEquipos.desc_Equipo = objTable.Rows(0).Item("descripción").ToString
            objEquipos.id_Estado = objTable.Rows(0).Item("idEstado").ToString

            objEquipos.nom_Estado = objTable.Rows(0).Item("nombreEstado").ToString
        End If

        'retornamos el usuario recien creado
        Return objEquipos
    End Function

    Public Function getAll() As List(Of Equipos)
        Dim oEquipos As Equipos
        Dim equipos As New List(Of Equipos)
        Dim strSQL = "SELECT E.*, EE.nombre as nombreEstado from Equipo E JOIN EstadoEquipo EE ON E.idEstado=EE.idEstadoEquipo"

        'Con la tabla devuelta por el Helper creamos N OBJETOS Equipos a partir de los datos de la/s filas de la tabla Equipo

        For Each row As DataRow In BDHelper.getBDHelper().ConsultarSQL(strSQL).Rows
            oEquipos = New Equipos()
            With oEquipos
                .id_Equipo = Convert.ToInt32(row.Item("idEquipo").ToString)
                .nombre_Equipo = row.Item("nombre").ToString
                .desc_Equipo = row.Item("descripción").ToString
                .id_Estado = Convert.ToInt32(row.Item("idEstado").ToString)

                .nom_Estado = row.Item("nombreEstado").ToString
            End With
            equipos.Add(oEquipos)
        Next

        Return equipos
    End Function

    Public Function getAllStates() As List(Of Equipos)
        Dim oEquipos As Equipos
        Dim equipos As New List(Of Equipos)
        Dim strSQL = "SELECT DISTINCT E.idEstado, EE.nombre as nombreEstado from Equipo E JOIN EstadoEquipo EE ON E.idEstado=EE.idEstadoEquipo"

        'Con la tabla devuelta por el Helper creamos N OBJETOS Equipos a partir de los datos de la/s filas de la tabla Equipo

        For Each row As DataRow In BDHelper.getBDHelper().ConsultarSQL(strSQL).Rows
            oEquipos = New Equipos()
            With oEquipos
                .id_Estado = Convert.ToInt32(row.Item("idEstado").ToString)

                .nom_Estado = row.Item("nombreEstado").ToString
            End With
            equipos.Add(oEquipos)
        Next

        Return equipos
    End Function

End Class
