Public Class FormHasil

    Public nama As String
    Public umur As String
    Public telepon As String
    Public alamat As String
    Public tanggal As String
    Public hobby As String
    Public jk As String
    Public foto As Image

    Private Sub FormHasil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblNama.Text = nama
        lblUmur.Text = umur
        lblTelepon.Text = telepon
        lblAlamat.Text = alamat
        lblTanggal.Text = tanggal
        lblHobby.Text = hobby
        lblJK.Text = jk

        pictureBoxFoto.Image = foto

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblHeader.Click

    End Sub

    Private Sub panelKartu_Paint(sender As Object, e As PaintEventArgs) Handles panelKartu.Paint

    End Sub
End Class