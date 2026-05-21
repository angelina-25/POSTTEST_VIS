Imports MySql.Data.MySqlClient

Module ModuleKoneksi
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public rd As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet

    Public Sub Connect()
        Dim str As String = "server=localhost;user id=root;password=;database=db_BLT"
        conn = New MySqlConnection(str)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Koneksi gagal: " & ex.Message)
        End Try
    End Sub
End Module

