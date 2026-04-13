Public Class Form1

    Sub Tampil()
        dgvPizza.DataSource = GetAllPizza()
    End Sub

    Sub Kosong()
        txtKode.Clear()
        txtNama.Clear()
        txtHarga.Clear()
        txtSearch.Clear()
        txtKode.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tampil()
        Kosong()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtKode.Text = "" Or txtNama.Text = "" Or txtHarga.Text = "" Then
            MessageBox.Show("Data tidak boleh kosong!")
            Exit Sub
        End If

        SimpanPizza(txtKode.Text, txtNama.Text, Val(txtHarga.Text))
        MessageBox.Show("Data berhasil disimpan")
        Tampil()
        Kosong()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        UbahPizza(txtKode.Text, txtNama.Text, Val(txtHarga.Text))
        MessageBox.Show("Data berhasil diubah")
        Tampil()
        Kosong()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        HapusPizza(txtKode.Text)
        MessageBox.Show("Data berhasil dihapus")
        Tampil()
        Kosong()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "" Then
            Tampil()
        Else
            dgvPizza.DataSource = SearchPizza(txtSearch.Text)
        End If
    End Sub

    Private Sub dgvPizza_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPizza.CellClick
        If e.RowIndex >= 0 Then
            txtKode.Text = dgvPizza.Rows(e.RowIndex).Cells(0).Value.ToString()
            txtNama.Text = dgvPizza.Rows(e.RowIndex).Cells(1).Value.ToString()
            txtHarga.Text = dgvPizza.Rows(e.RowIndex).Cells(2).Value.ToString()
        End If
    End Sub

End Class