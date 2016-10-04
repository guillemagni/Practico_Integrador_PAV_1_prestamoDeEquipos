Imports System.Data.SqlClient

Module funcionesBD

    Public cnn As New SqlConnection("Data Source=ANGONOAFRANCO\FRANCOANG;Initial Catalog=TP_PAVI;Integrated Security=True")
    Public cmd As SqlCommand

    'Data Source=maquis;Initial Catalog=TP_PAVI;User ID=avisuales1;Password=avisuales1

    Public Sub conectarse()
        Try
            cnn.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Module
