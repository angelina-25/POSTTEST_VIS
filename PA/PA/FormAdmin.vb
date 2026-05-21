Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing

Public Class FormAdmin

    Dim dataUser As New DataTable
    Dim rowIndex As Integer = 0
    Sub SetupDataGridView()
        dgvDataUser.Columns.Clear()
        dgvDataUser.Rows.Clear()

        dgvDataUser.Columns.Add("NKK", "NKK")
        dgvDataUser.Columns.Add("Gender", "Gender")
        dgvDataUser.Columns.Add("Nama", "Nama")
        dgvDataUser.Columns.Add("Alamat", "Alamat")
        dgvDataUser.Columns.Add("No_telp", "No Telp")
        dgvDataUser.Columns.Add("No_rek", "No Rek")
        dgvDataUser.Columns.Add("Gajih", "Gaji")
        dgvDataUser.Columns.Add("Nominal", "Nominal")
        dgvDataUser.Columns.Add("Deskripsi", "Deskripsi")

        Dim imgCol As New DataGridViewImageColumn()
        imgCol.Name = "Gambar"
        imgCol.HeaderText = "Slip Gaji"
        imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom
        dgvDataUser.Columns.Add(imgCol)

        dgvDataUser.Columns.Add("Status", "Status")
    End Sub

    Sub tampilData()
        Call Connect()
        dgvDataUser.Rows.Clear()

        Dim cmd As New MySqlCommand("SELECT * FROM tb_penerima", conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim img As Image = Nothing

            Try
                If Not IsDBNull(reader("foto")) Then
                    Dim imgBytes As Byte() = CType(reader("foto"), Byte())
                    If imgBytes IsNot Nothing AndAlso imgBytes.Length > 0 Then
                        Using ms As New MemoryStream(imgBytes)
                            img = Image.FromStream(ms)
                        End Using
                    End If
                End If
            Catch ex As Exception
                img = Nothing
            End Try

            dgvDataUser.Rows.Add(
                reader("nkk").ToString(),
                reader("gender").ToString(),
                reader("nama").ToString(),
                reader("alamat").ToString(),
                reader("no_telp").ToString(),
                reader("no_rek").ToString(),
                reader("gajih").ToString(),
                reader("nominal").ToString(),
                reader("deskripsi").ToString(),
                img,
                reader("status").ToString()
            )
        End While

        reader.Close()
    End Sub

    Sub FilterData(keyword As String)
        Call Connect()
        dgvDataUser.Rows.Clear()

        Dim cmd As New MySqlCommand("SELECT * FROM tb_penerima WHERE nkk LIKE @keyword OR nama LIKE @keyword", conn)
        cmd.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim img As Image = Nothing

            Try
                If Not IsDBNull(reader("foto")) Then
                    Dim imgBytes As Byte() = CType(reader("foto"), Byte())
                    If imgBytes IsNot Nothing AndAlso imgBytes.Length > 0 Then
                        Using ms As New MemoryStream(imgBytes)
                            img = Image.FromStream(ms)
                        End Using
                    End If
                End If
            Catch ex As Exception
                img = Nothing
            End Try

            dgvDataUser.Rows.Add(
                reader("nkk").ToString(),
                reader("gender").ToString(),
                reader("nama").ToString(),
                reader("alamat").ToString(),
                reader("no_telp").ToString(),
                reader("no_rek").ToString(),
                reader("gajih").ToString(),
                reader("nominal").ToString(),
                reader("deskripsi").ToString(),
                img,
                reader("status").ToString()
            )
        End While

        reader.Close()
    End Sub

    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupDataGridView()
        tampilData()
    End Sub

    Private Sub dgvDataUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDataUser.CellContentClick
        Dim i As Integer = dgvDataUser.CurrentRow.Index
        txtNKK.Text = dgvDataUser.Item(0, i).Value.ToString()
        txtNama.Text = dgvDataUser.Item(2, i).Value.ToString()
        cbStatus.Text = dgvDataUser.Item(10, i).Value.ToString()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Call Connect()
        Dim update As String = "UPDATE tb_penerima SET Nama=@nama, Status=@status WHERE NKK=@nkk"
        cmd = New MySqlCommand(update, conn)
        cmd.Parameters.AddWithValue("@nama", txtNama.Text)
        cmd.Parameters.AddWithValue("@status", cbStatus.Text)
        cmd.Parameters.AddWithValue("@nkk", txtNKK.Text)
        cmd.ExecuteNonQuery()
        MsgBox("Data berhasil diupdate!")
        tampilData()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Call Connect()
        Dim hapus As String = "DELETE FROM tb_penerima WHERE NKK=@nkk"
        cmd = New MySqlCommand(hapus, conn)
        cmd.Parameters.AddWithValue("@nkk", txtNKK.Text)
        cmd.ExecuteNonQuery()
        MsgBox("Data berhasil dihapus!")
        tampilData()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        txtNKK.Clear()
        txtNama.Clear()
        cbStatus.SelectedIndex = -1
    End Sub

    Private Sub txtPencarian_TextChanged(sender As Object, e As EventArgs) Handles txtPencarian.TextChanged
        FilterData(txtPencarian.Text)
    End Sub

    Private Sub PrintDataUserToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PrintDataUserToolStripMenuItem1.Click
        Call Connect()
        Dim cmd As New MySqlCommand("SELECT * FROM tb_penerima", conn)
        Dim adapter As New MySqlDataAdapter(cmd)
        dataUser.Clear()
        adapter.Fill(dataUser)

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fontJudul As New Font("Arial", 16, FontStyle.Bold)
        Dim fontIsi As New Font("Arial", 10)
        Dim y As Integer = 100

        e.Graphics.DrawString("DATA PENERIMA BLT", fontJudul, Brushes.Black, 250, y)
        y += 40

        Dim i As Integer = rowIndex
        While i < dataUser.Rows.Count
            Dim data = dataUser.Rows(i)

            e.Graphics.DrawRectangle(Pens.Black, 50, y, 700, 120)
            e.Graphics.DrawString("NKK         : " & data("nkk").ToString, fontIsi, Brushes.Black, 60, y + 10)
            e.Graphics.DrawString("Nama        : " & data("nama").ToString, fontIsi, Brushes.Black, 60, y + 30)
            e.Graphics.DrawString("Gaji        : " & data("gajih").ToString, fontIsi, Brushes.Black, 60, y + 50)
            e.Graphics.DrawString("Nominal     : " & data("nominal").ToString, fontIsi, Brushes.Black, 60, y + 70)
            e.Graphics.DrawString("Deskripsi   : " & data("deskripsi").ToString, fontIsi, Brushes.Black, 60, y + 90)
            e.Graphics.DrawString("Status      : " & data("status").ToString, fontIsi, Brushes.Black, 400, y + 10)
            y += 140

            i += 1

            If y > e.MarginBounds.Height - 150 Then
                e.HasMorePages = True
                rowIndex = i
                Exit Sub
            End If
        End While

        rowIndex = 0
        e.HasMorePages = False
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
    End Sub

    Private Sub PrintDataUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintDataUserToolStripMenuItem.Click

        Try
            SaveFileDialog1.Filter = "Text File|*.txt"
            SaveFileDialog1.Title = "Simpan Data"

            If SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Using sw As New StreamWriter(
                SaveFileDialog1.FileName
            )

                    For Each row As DataGridViewRow In dgvDataUser.Rows

                        If Not row.IsNewRow Then

                            sw.WriteLine(
                            "NKK : " &
                            row.Cells(0).Value
                        )

                            sw.WriteLine(
                            "Nama : " &
                            row.Cells(2).Value
                        )

                            sw.WriteLine(
                            "Status : " &
                            row.Cells(10).Value
                        )

                            sw.WriteLine("------------------")

                        End If

                    Next

                End Using

                MsgBox(
                "File berhasil disimpan!",
                MsgBoxStyle.Information
            )

            End If

        Catch ex As Exception
            MsgBox(
            "Gagal menyimpan : " &
            ex.Message
        )
        End Try

    End Sub

End Class
