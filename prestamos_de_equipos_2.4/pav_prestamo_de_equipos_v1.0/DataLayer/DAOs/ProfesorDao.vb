Public Class ProfesorDao
    Public Function getProfesor(ByVal idProfesor)
        'Permite obtener un profesor a partir de su número de identificación
        Dim objProfesor As Profesor = Nothing 'Creamos un objeto profesor vacio
        Dim objTable As DataTable
        Dim sentenciaSQL As String
        'Armamos la sentencia SQL para buscar el Profesor en la base de datos
        sentenciaSQL = "SELECT * from Profesor WHERE idProfesor = " & idProfesor

        'Delegamos el trabajo de la consulta SQL a la instancia BDHelper
        objTable = BDHelper.getBDHelper.ConsultarSQL(sentenciaSQL)

        'La tabla ahora tiene los datos de un profesor recuperado de la base de datos
        'Con esos datos procedemos a crear un objeto Profesor
        If objTable.Rows.Count() > 0 Then 'Rows obtiene la coleccion de filas que pertenecen a la tabla
            objProfesor = New Profesor()
            objProfesor.id_profe = objTable.Rows(0).Item("idProfesor").ToString
            objProfesor.nom_profe = objTable.Rows(0).Item("nombre").ToString
            objProfesor.ape_profe = objTable.Rows(0).Item("apellido").ToString
            objProfesor.id_estado = objTable.Rows(0).Item("idEstado").ToString
        End If

        'retornamos el Profesor recien creado
        Return objProfesor
    End Function

    Public Function getAll() As List(Of Profesor)
        Dim oProfesor As Profesor
        Dim profesores As New List(Of Profesor)
        Dim strSQL = "SELECT P.*, E.nombre as nomEstado FROM Profesor P JOIN EstadoProfesor E ON P.idEstado = E.idEstadoProfesor " &
            " ORDER BY P.idProfesor"

        'Con la tabla devuelta por el Helper creamos N OBJETOS Profesor a partir de los datos de la/s filas de la tabla Profesor

        For Each row As DataRow In BDHelper.getBDHelper().ConsultarSQL(strSQL).Rows
            oProfesor = New Profesor()
            With oProfesor
                .id_profe = Convert.ToInt32(row.Item("idProfesor").ToString)
                .nom_profe = row.Item("nombre").ToString
                .ape_profe = row.Item("apellido").ToString
                .id_estado = Convert.ToInt32(row.Item("idEstado").ToString)

                .nom_estado = row.Item("nomEstado").ToString

            End With
            profesores.Add(oProfesor)
        Next

        Return profesores
    End Function

    'Public Function searchProfesor(ByVal idProfe)
    '    'Permite obtener un usuario a partir de su nickname y su password 
    '    Dim objUser As User = Nothing 'Creamos un objeto user vacio
    '    Dim objTable As DataTable
    '    Dim sentenciaSQL As String
    '    'Armamos la sentencia SQL para buscar el usuario en la base de datos
    '    'sentenciaSQL = "SELECT * from Usuario WHERE nombreUsuario = '" & user & "' AND contraseña = '" & pass & "'"

    '    sentenciaSQL = "SELECT * from Usuario WHERE nombreUsuario = '" & User & "'"

    '    'Delegamos el trabajo de la consulta SQL a la instancia BDHelper
    '    objTable = BDHelper.getBDHelper.ConsultarSQL(sentenciaSQL)

    '    'La tabla ahora tiene los datos de un usuario recuperado de la base de datos
    '    'Con esos datos procedemos a crear un objeto User
    '    If objTable.Rows.Count() > 0 Then 'Rows obtiene la coleccion de filas que pertenecen a la tabla
    '        objUser = New User()
    '        objUser.ape_user = objTable.Rows(0).Item("apellidoPerfil").ToString
    '        objUser.nom_user = objTable.Rows(0).Item("nombrePerfil").ToString
    '        objUser.nick_user = objTable.Rows(0).Item("nombreUsuario").ToString
    '        objUser.pass_user = objTable.Rows(0).Item("contraseña").ToString
    '    End If

    '    'retornamos el usuario recien creado
    '    Return objUser
    'End Function
End Class
