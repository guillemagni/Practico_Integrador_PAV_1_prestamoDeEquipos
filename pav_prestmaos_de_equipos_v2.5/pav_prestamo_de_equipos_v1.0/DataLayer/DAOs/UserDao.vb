Public Class UserDao
    Public Function getUser(ByVal user, ByVal pass)
        'Permite obtener un usuario a partir de su nickname y su password 
        Dim objUser As User = Nothing 'Creamos un objeto user vacio
        Dim objTable As DataTable
        Dim sentenciaSQL As String
        'Armamos la sentencia SQL para buscar el usuario en la base de datos
        sentenciaSQL = "SELECT * from Usuario WHERE nombreUsuario = '" & user & "' AND contraseña = '" & pass & "'"

        'Delegamos el trabajo de la consulta SQL a la instancia BDHelper
        objTable = BDHelper.getBDHelper.ConsultarSQL(sentenciaSQL)

        'La tabla ahora tiene los datos de un usuario recuperado de la base de datos
        'Con esos datos procedemos a crear un objeto User
        If objTable.Rows.Count() > 0 Then 'Rows obtiene la coleccion de filas que pertenecen a la tabla
            objUser = New User()
            objUser.ape_user = objTable.Rows(0).Item("apellidoPerfil").ToString
            objUser.nom_user = objTable.Rows(0).Item("nombrePerfil").ToString
            objUser.nick_user = objTable.Rows(0).Item("nombreUsuario").ToString
            objUser.pass_user = objTable.Rows(0).Item("contraseña").ToString
        End If

        'retornamos el usuario recien creado
        Return objUser
    End Function

    Public Function searchUser(ByVal user)
        'Permite obtener un usuario a partir de su nickname y su password 
        Dim objUser As User = Nothing 'Creamos un objeto user vacio
        Dim objTable As DataTable
        Dim sentenciaSQL As String
        'Armamos la sentencia SQL para buscar el usuario en la base de datos
        'sentenciaSQL = "SELECT * from Usuario WHERE nombreUsuario = '" & user & "' AND contraseña = '" & pass & "'"

        sentenciaSQL = "SELECT * from Usuario WHERE nombreUsuario = '" & user & "'"

        'Delegamos el trabajo de la consulta SQL a la instancia BDHelper
        objTable = BDHelper.getBDHelper.ConsultarSQL(sentenciaSQL)

        'La tabla ahora tiene los datos de un usuario recuperado de la base de datos
        'Con esos datos procedemos a crear un objeto User
        If objTable.Rows.Count() > 0 Then 'Rows obtiene la coleccion de filas que pertenecen a la tabla
            objUser = New User()
            objUser.ape_user = objTable.Rows(0).Item("apellidoPerfil").ToString
            objUser.nom_user = objTable.Rows(0).Item("nombrePerfil").ToString
            objUser.nick_user = objTable.Rows(0).Item("nombreUsuario").ToString
            objUser.pass_user = objTable.Rows(0).Item("contraseña").ToString
        End If

        'retornamos el usuario recien creado
        Return objUser
    End Function
End Class
