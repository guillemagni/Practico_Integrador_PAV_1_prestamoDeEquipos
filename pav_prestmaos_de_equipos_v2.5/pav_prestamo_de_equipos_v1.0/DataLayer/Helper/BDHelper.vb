Imports System.Data.SqlClient
Public Class BDHelper
    Private linea_conexion As String
    Private Shared instancia As BDHelper

    Private Sub New()
        '----- Lineas de Conexion-----
        '"Data Source=ANGONOAFRANCO\FRANCOANG;Initial Catalog=TP_PAVI;Integrated Security=True"
        '"Data Source=GUILLERMO\SQLMAGNI;Initial Catalog=TP_PAVI;Integrated Security=True"
        '"Data Source=maquis;Initial Catalog=TP_PAVI;User ID=avisuales1;Password=avisuales1"
        '-----------------------------

        linea_conexion = "Data Source=ANGONOAFRANCO\FRANCOANG;Initial Catalog=TP_PAVI;Integrated Security=True"
    End Sub

    'getBDHelper() aplica un patron Singleton. 
    'Devuelve la unica instancia de BDHelper.
    'Si no existe la instancia, entonces la crea.
    Public Shared Function getBDHelper() As BDHelper
        If IsNothing(instancia) Then
            instancia = New BDHelper
        End If
        Return instancia
    End Function

    Public Function EjecutarSQL(ByRef sentenciaSql As String) As Integer
        'Para trabajar sentencias SQL del tipo: Update/Insert/Delete
        'sentenciaSql = la sentencia SQL que se desea realizar y que se recibe como parametro
        Dim conexion As New SqlConnection
        Dim com As New SqlCommand

        'Try Catch Finally
        'Trata de ejecutar el código contenido dentro del bloque Try - Catch
        'Si hay error lo capta a través de una excepción
        'Si no hubo error
        Try
            'Inidicamos la info para la conexion
            conexion.ConnectionString = linea_conexion
            'abrimos la conexion
            conexion.Open()

            com.Connection = conexion
            com.CommandType = CommandType.Text
            'Indicamos a com (sqlcommand) que sentencia sql queremos realizar
            com.CommandText = sentenciaSql

            ' Retorna el resultado de ejecutar el comando
            Return com.ExecuteNonQuery()

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
        Finally
            'Cerramos conexion y libreamos los recursos
            conexion.Close()
            conexion.Dispose()
        End Try
    End Function

    Public Function ConsultarSQL(ByVal sentenciaSql As String) As Data.DataTable
        ' Se utiliza para sentencias SQL del tipo “Select”
        ' La función recibe por valor una sentencia sql como string, devuelve un objeto de tipo DataTable
        Dim conexion As New SqlConnection
        Dim com As New SqlCommand
        Dim tabla As New DataTable

        Try
            'Indicamos la info para la conexion
            conexion.ConnectionString = linea_conexion
            'abrimos la conexion
            conexion.Open()

            com.Connection = conexion
            com.CommandType = CommandType.Text
            com.CommandText = sentenciaSql

            ' El datatable se carga con el resultado de ejecutar la sentencia en el motor de base de datos
            tabla.Load(com.ExecuteReader)
            ' La función retorna el objeto datatable con 0, 1 o mas registros
            Return tabla
        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
        Finally
            'Cerramos conexion y libreamos los recursos
            conexion.Close()
            conexion.Dispose()
        End Try
    End Function


End Class
