Public Class FormUtama

    Dim hobbies As String = ""
    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        GroupBoxKartu.Visible = True
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        SaveData()
    End Sub

    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click
        OpenData()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim keluar As DialogResult
        keluar = MessageBox.Show("Yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo)
        If keluar = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub


    Private Function ValidasiInput() As Boolean

        If lblNamaKartu.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Return False
        End If

        If lblIDKartu.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Return False
        End If

        If lblKontakKartu.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Return False
        End If

        If txtEmail.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Return False
        End If

        If txtAlamat.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Return False
        End If

        If Not lblKontakKartu.MaskCompleted Then
            MessageBox.Show("Nomor telepon harus lengkap!")
            Return False
        End If

        If Not cbHobby1.Checked And Not cbHobby2.Checked And Not cbHobby3.Checked And Not cbHobby4.Checked _
            And Not cbHobby5.Checked And Not cbHobby6.Checked And Not cbHobby7.Checked And Not cbHobby8.Checked Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Return False
        End If

        Return True

    End Function


    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.png;*.jpeg"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            picFoto.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub


    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        If ValidasiInput() = False Then Exit Sub

        Dim hasil As DialogResult
        hasil = MessageBox.Show("Cetak kartu sekarang?", "Konfirmasi", MessageBoxButtons.YesNo)

        If hasil = DialogResult.Yes Then

            hobbies = ""
            If cbHobby1.Checked Then hobbies &= cbHobby1.Text & ", "
            If cbHobby2.Checked Then hobbies &= cbHobby2.Text & ", "
            If cbHobby3.Checked Then hobbies &= cbHobby3.Text & ", "
            If cbHobby4.Checked Then hobbies &= cbHobby4.Text & ", "
            If cbHobby5.Checked Then hobbies &= cbHobby5.Text & ", "
            If cbHobby6.Checked Then hobbies &= cbHobby6.Text & ", "
            If cbHobby7.Checked Then hobbies &= cbHobby7.Text & ", "
            If cbHobby8.Checked Then hobbies &= cbHobby8.Text & ", "

            If hobbies.Length > 2 Then
                hobbies = hobbies.Substring(0, hobbies.Length - 2)
            End If

            FormKartu.lblNamaKartu.Text = lblNamaKartu.Text
            FormKartu.lblIDKartu.Text = lblIDKartu.Text
            FormKartu.lblKomunitasKartu.Text = lblKomunitasKartu.Text
            FormKartu.lblKontakKartu.Text = lblKontakKartu.Text
            FormKartu.lblHobiKartu.Text = hobbies

            If picFoto.Image IsNot Nothing Then
                FormKartu.picFoto.Image = picFoto.Image
            End If

            FormKartu.Show()

        End If

    End Sub


    Private Sub SaveData()
        SaveFileDialog1.Filter = "Text File|*.txt"
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Dim data As String =
                lblNamaKartu.Text & vbCrLf &
                lblIDKartu.Text & vbCrLf &
                lblKontakKartu.Text & vbCrLf &
                txtEmail.Text & vbCrLf &
                txtAlamat.Text
            IO.File.WriteAllText(SaveFileDialog1.FileName, data)
            MessageBox.Show("Data berhasil disimpan")
        End If
    End Sub


    Private Sub OpenData()
        OpenFileDialog1.Filter = "Text File|*.txt"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim data() As String = IO.File.ReadAllLines(OpenFileDialog1.FileName)
            lblNamaKartu.Text = data(0)
            lblIDKartu.Text = data(1)
            lblKontakKartu.Text = data(2)
            txtEmail.Text = data(3)
            txtAlamat.Text = data(4)
            MessageBox.Show("Data berhasil dibuka")
        End If
    End Sub


    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lblNamaKartu.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub


    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lblIDKartu.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class