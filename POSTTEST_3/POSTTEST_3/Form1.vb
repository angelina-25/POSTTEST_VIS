Imports System.IO

Public Class Form1

    Dim hobby As String = ""

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Dim open As New OpenFileDialog
        open.Filter = "Image Files|*.jpg;*.png;*.jpeg"

        If open.ShowDialog = DialogResult.OK Then
            pictureBoxFoto.Image = Image.FromFile(open.FileName)
        End If

    End Sub


    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And e.KeyChar <> " "c Then
            e.Handled = True
        End If

    End Sub


    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub


    Private Sub txtTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelepon.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub


    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        If txtNama.Text = "" Or txtUmur.Text = "" Or txtTelepon.Text = "" Or txtAlamat.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If

        If pictureBoxFoto.Image Is Nothing Then
            MessageBox.Show("Foto belum dipilih")
            Exit Sub
        End If

        If rbLaki.Checked = False And rbPerempuan.Checked = False Then
            MessageBox.Show("Pilih jenis kelamin")
            Exit Sub
        End If

        If cbGaming.Checked = False And cbCoding.Checked = False And cbTraveling.Checked = False And
           cbMenggambar.Checked = False And cbMenulis.Checked = False And cbMemancing.Checked = False And
           cbMembaca.Checked = False And cbOlahraga.Checked = False And cbMenyanyi.Checked = False And
           cbMenari.Checked = False Then

            MessageBox.Show("Pilih minimal satu hobby")
            Exit Sub

        End If


        hobby = ""

        For Each c As Control In groupBoxHobby.Controls

            If TypeOf c Is CheckBox Then

                Dim cb As CheckBox = CType(c, CheckBox)

                If cb.Checked Then
                    hobby &= cb.Text & ", "
                End If

            End If

        Next


        Dim jk As String

        If rbLaki.Checked Then
            jk = rbLaki.Text
        Else
            jk = rbPerempuan.Text
        End If


        Dim fh As New FormHasil

        fh.nama = txtNama.Text
        fh.umur = txtUmur.Text
        fh.telepon = txtTelepon.Text
        fh.alamat = txtAlamat.Text
        fh.tanggal = dtTanggal.Value.ToString("dd/MM/yyyy")
        fh.hobby = hobby
        fh.jk = jk
        fh.foto = pictureBoxFoto.Image

        fh.Show()

    End Sub

End Class