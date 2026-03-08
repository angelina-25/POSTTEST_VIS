Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TambahData("Harry Potter", "Fantasi")
        TambahData("Sherlock Holmes", "Misteri")

        TampilkanData()

    End Sub

    Sub TambahData(ByVal judul As String, ByVal genre As String)

        buku(jumlah) = judul & " (" & genre & ")"
        jumlah += 1

    End Sub

    Function CariBuku(ByVal judul As String) As Integer

        For i As Integer = 0 To jumlah - 1

            If buku(i).ToLower.Contains(judul.ToLower) Then
                Return i
            End If

        Next

        Return -1

    End Function

    Sub TampilkanData()

        ListBox1.Items.Clear()

        For i As Integer = 0 To jumlah - 1
            ListBox1.Items.Add(buku(i))
        Next

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click

        Dim judul As String = txtjudul.Text
        Dim genre As String = txtgenre.Text

        If judul = "" Or genre = "" Then
            MessageBox.Show("Data harus diisi")
            Exit Sub
        End If

        TambahData(judul, genre)

        TampilkanData()

        txtjudul.Clear()
        txtgenre.Clear()

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click

        Dim judul As String = txthapus.Text

        Dim index As Integer = CariBuku(judul)

        If index = -1 Then
            MessageBox.Show("Buku tidak ditemukan")
        Else

            For i As Integer = index To jumlah - 2
                buku(i) = buku(i + 1)
            Next

            jumlah -= 1

            MessageBox.Show("Buku berhasil dihapus")

        End If

        TampilkanData()

        txthapus.Clear()

    End Sub

End Class