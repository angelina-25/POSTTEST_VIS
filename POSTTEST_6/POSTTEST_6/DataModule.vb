Imports MySqlConnector
Imports System.Data

Module DataModule

    Public Function GetAllPizza() As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String = "SELECT kodePizza, namaPizza, harga FROM tbpizza ORDER BY kodePizza ASC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message)
        End Try

        Return dt
    End Function

    Public Function SearchPizza(keyword As String) As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String =
                "SELECT kodePizza, namaPizza, harga FROM tbpizza " &
                "WHERE kodePizza LIKE @key OR namaPizza LIKE @key"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@key", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message)
        End Try

        Return dt
    End Function

    Public Sub SimpanPizza(kode As String, nama As String, harga As Integer)
        Try
            Dim query As String = "INSERT INTO tbpizza (kodePizza,namaPizza,harga) VALUES (@kode,@nama,@harga)"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.ExecuteNonQuery()
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan: " & ex.Message)
        End Try
    End Sub

    Public Sub UbahPizza(kode As String, nama As String, harga As Integer)
        Try
            Dim query As String = "UPDATE tbpizza SET namaPizza=@nama, harga=@harga WHERE kodePizza=@kode"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.ExecuteNonQuery()
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal mengubah: " & ex.Message)
        End Try
    End Sub

    Public Sub HapusPizza(kode As String)
        Try
            Dim query As String = "DELETE FROM tbpizza WHERE kodePizza=@kode"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.ExecuteNonQuery()
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal menghapus: " & ex.Message)
        End Try
    End Sub

    Public Function GetAllPesanan() As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String =
                "SELECT p.idPesanan, p.kodePizza, t.namaPizza, t.harga, p.jumlah, p.total " &
                "FROM tbpesanan p JOIN tbpizza t ON p.kodePizza = t.kodePizza"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal tampil pesanan: " & ex.Message)
        End Try

        Return dt
    End Function

    Public Sub SimpanPesanan(kode As String, jumlah As Integer, total As Integer)
        Try
            Dim query As String =
                "INSERT INTO tbpesanan (kodePizza, jumlah, total) VALUES (@kode,@jumlah,@total)"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@jumlah", jumlah)
                    cmd.Parameters.AddWithValue("@total", total)
                    cmd.ExecuteNonQuery()
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal simpan pesanan: " & ex.Message)
        End Try
    End Sub

End Module