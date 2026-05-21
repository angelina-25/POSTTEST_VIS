Imports MySql.Data.MySqlClient
Imports System.IO

Public Class FormUser
    Dim iniFile As String

    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniFile = Application.StartupPath & "\data_" & Form1.username & ".ini"

        If File.Exists(iniFile) Then
            Dim lines() As String = File.ReadAllLines(iniFile)
            If lines.Length >= 9 Then
                txtNKK.Text = lines(0)
                cbGender.Text = lines(1)
                txtNama.Text = lines(2)
                txtAlamat.Text = lines(3)
                txtTelp.Text = lines(4)
                txtRek.Text = lines(5)
                txtGajih.Text = lines(6)
                txtNominal.Text = lines(7)
                txtDeskripsi.Text = lines(8)
                If lines.Length >= 10 Then
                    pbSlipGajih.ImageLocation = lines(9)
                End If
            End If
        Else
            BersihkanForm()
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNKK.Text = "" OrElse cbGender.Text = "" OrElse txtNama.Text = "" OrElse txtAlamat.Text = "" OrElse
           txtTelp.Text = "" OrElse txtRek.Text = "" OrElse txtGajih.Text = "" OrElse txtNominal.Text = "" OrElse
           txtDeskripsi.Text = "" Then
            MsgBox("Data tidak boleh kosong")
            Exit Sub
        End If

        If String.IsNullOrEmpty(pbSlipGajih.ImageLocation) Then
            MsgBox("Harap mengupload Foto Slip Gaji")
            Exit Sub
        End If

        If Not IsNumeric(txtNKK.Text) OrElse Not IsNumeric(txtTelp.Text) OrElse Not IsNumeric(txtRek.Text) OrElse
           Not IsNumeric(txtGajih.Text) OrElse Not IsNumeric(txtNominal.Text) Then
            MsgBox("Harap memasukkan berupa angka")
            Exit Sub
        End If

        If txtNama.Text.Any(Function(c) Not Char.IsLetter(c) AndAlso Not Char.IsWhiteSpace(c)) Then
            MsgBox("Nama wajib huruf bukan angka")
            Exit Sub
        End If

        Call Connect()
        Dim simpan As String = "INSERT INTO tb_penerima VALUES(@nkk,@gender,@nama,@alamat,@telp,@rek,@gajih,@nominal,@deskripsi,@foto,'Menunggu')"
        cmd = New MySqlCommand(simpan, conn)
        cmd.Parameters.AddWithValue("@nkk", txtNKK.Text)
        cmd.Parameters.AddWithValue("@gender", cbGender.Text)
        cmd.Parameters.AddWithValue("@nama", txtNama.Text)
        cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text)
        cmd.Parameters.AddWithValue("@telp", txtTelp.Text)
        cmd.Parameters.AddWithValue("@rek", txtRek.Text)
        cmd.Parameters.AddWithValue("@gajih", txtGajih.Text)
        cmd.Parameters.AddWithValue("@nominal", txtNominal.Text)
        cmd.Parameters.AddWithValue("@deskripsi", txtDeskripsi.Text)

        Dim imgBytes As Byte() = File.ReadAllBytes(pbSlipGajih.ImageLocation)
        cmd.Parameters.AddWithValue("@foto", imgBytes)

        cmd.ExecuteNonQuery()
        MsgBox("Data berhasil disimpan!")

        Dim lines As String() = {
            txtNKK.Text,
            cbGender.Text,
            txtNama.Text,
            txtAlamat.Text,
            txtTelp.Text,
            txtRek.Text,
            txtGajih.Text,
            txtNominal.Text,
            txtDeskripsi.Text,
            pbSlipGajih.ImageLocation
        }
        File.WriteAllLines(iniFile, lines)
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        If ofd.ShowDialog = DialogResult.OK Then
            pbSlipGajih.ImageLocation = ofd.FileName
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        FormCetak.lblNKK.Text = txtNKK.Text
        FormCetak.lblGender.Text = cbGender.Text
        FormCetak.lblNama.Text = txtNama.Text
        FormCetak.lblAlamat.Text = txtAlamat.Text
        FormCetak.lblTelp.Text = txtTelp.Text
        FormCetak.lblRek.Text = txtRek.Text
        FormCetak.lblGajih.Text = txtGajih.Text
        FormCetak.lblNominal.Text = txtNominal.Text
        FormCetak.lblDeskripsi.Text = txtDeskripsi.Text
        FormCetak.pbSlipGajih.ImageLocation = pbSlipGajih.ImageLocation
        FormCetak.Show()
        Me.Hide()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        BersihkanForm()
    End Sub

    Private Sub BersihkanForm()
        txtNKK.Clear()
        cbGender.SelectedIndex = -1
        txtNama.Clear()
        txtAlamat.Clear()
        txtTelp.Clear()
        txtRek.Clear()
        txtGajih.Clear()
        txtNominal.Clear()
        txtDeskripsi.Clear()
        pbSlipGajih.ImageLocation = ""
    End Sub
End Class
