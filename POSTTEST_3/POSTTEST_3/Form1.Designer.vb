<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pictureBoxFoto = New PictureBox()
        btnBrowse = New Button()
        btnCetak = New Button()
        lblNama = New Label()
        lblUmur = New Label()
        lblTelepon = New Label()
        lblTanggal = New Label()
        lblAlamat = New Label()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtTelepon = New TextBox()
        txtAlamat = New TextBox()
        dtTanggal = New DateTimePicker()
        groupBoxJK = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        groupBoxHobby = New GroupBox()
        cbMenari = New CheckBox()
        cbMenyanyi = New CheckBox()
        cbOlahraga = New CheckBox()
        cbMembaca = New CheckBox()
        cbMemancing = New CheckBox()
        cbMenulis = New CheckBox()
        cbMenggambar = New CheckBox()
        cbTraveling = New CheckBox()
        cbCoding = New CheckBox()
        cbGaming = New CheckBox()
        panelForm = New Panel()
        pictureBoxLogo = New PictureBox()
        lblHeader = New Label()
        CType(pictureBoxFoto, ComponentModel.ISupportInitialize).BeginInit()
        groupBoxJK.SuspendLayout()
        groupBoxHobby.SuspendLayout()
        panelForm.SuspendLayout()
        CType(pictureBoxLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pictureBoxFoto
        ' 
        pictureBoxFoto.BorderStyle = BorderStyle.FixedSingle
        pictureBoxFoto.Location = New Point(12, 45)
        pictureBoxFoto.Name = "pictureBoxFoto"
        pictureBoxFoto.Size = New Size(230, 260)
        pictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage
        pictureBoxFoto.TabIndex = 0
        pictureBoxFoto.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.DarkRed
        btnBrowse.Font = New Font("High Tower Text", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBrowse.ForeColor = Color.Gold
        btnBrowse.Location = New Point(61, 351)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(134, 34)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.DarkRed
        btnCetak.Font = New Font("High Tower Text", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCetak.ForeColor = Color.Gold
        btnCetak.Location = New Point(345, 458)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(483, 34)
        btnCetak.TabIndex = 2
        btnCetak.Text = "Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = Color.DarkRed
        lblNama.Font = New Font("High Tower Text", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblNama.ForeColor = Color.Gold
        lblNama.Location = New Point(290, 45)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(56, 21)
        lblNama.TabIndex = 3
        lblNama.Text = "Nama"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.BackColor = Color.DarkRed
        lblUmur.Font = New Font("High Tower Text", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblUmur.ForeColor = Color.Gold
        lblUmur.Location = New Point(290, 88)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(55, 21)
        lblUmur.TabIndex = 4
        lblUmur.Text = "Umur"
        ' 
        ' lblTelepon
        ' 
        lblTelepon.AutoSize = True
        lblTelepon.BackColor = Color.DarkRed
        lblTelepon.Font = New Font("High Tower Text", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTelepon.ForeColor = Color.Gold
        lblTelepon.Location = New Point(290, 134)
        lblTelepon.Name = "lblTelepon"
        lblTelepon.Size = New Size(99, 21)
        lblTelepon.TabIndex = 5
        lblTelepon.Text = "No Telepon"
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.BackColor = Color.DarkRed
        lblTanggal.Font = New Font("High Tower Text", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTanggal.ForeColor = Color.Gold
        lblTanggal.Location = New Point(287, 178)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(121, 21)
        lblTanggal.TabIndex = 6
        lblTanggal.Text = "Tanggal Lahir"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.BackColor = Color.DarkRed
        lblAlamat.Font = New Font("High Tower Text", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblAlamat.ForeColor = Color.Gold
        lblAlamat.Location = New Point(290, 221)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(67, 21)
        lblAlamat.TabIndex = 7
        lblAlamat.Text = "Alamat"
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = Color.Beige
        txtNama.Font = New Font("High Tower Text", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtNama.Location = New Point(416, 42)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(243, 28)
        txtNama.TabIndex = 8
        ' 
        ' txtUmur
        ' 
        txtUmur.BackColor = Color.Beige
        txtUmur.Font = New Font("High Tower Text", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtUmur.Location = New Point(416, 85)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(243, 28)
        txtUmur.TabIndex = 9
        ' 
        ' txtTelepon
        ' 
        txtTelepon.BackColor = Color.Beige
        txtTelepon.Font = New Font("High Tower Text", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtTelepon.Location = New Point(416, 128)
        txtTelepon.Name = "txtTelepon"
        txtTelepon.Size = New Size(243, 28)
        txtTelepon.TabIndex = 10
        ' 
        ' txtAlamat
        ' 
        txtAlamat.BackColor = Color.Beige
        txtAlamat.Font = New Font("High Tower Text", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtAlamat.Location = New Point(416, 221)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(243, 28)
        txtAlamat.TabIndex = 11
        ' 
        ' dtTanggal
        ' 
        dtTanggal.CalendarMonthBackground = Color.Beige
        dtTanggal.CustomFormat = ""
        dtTanggal.Font = New Font("High Tower Text", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        dtTanggal.Format = DateTimePickerFormat.Short
        dtTanggal.Location = New Point(416, 172)
        dtTanggal.Name = "dtTanggal"
        dtTanggal.Size = New Size(243, 28)
        dtTanggal.TabIndex = 12
        ' 
        ' groupBoxJK
        ' 
        groupBoxJK.BackColor = Color.Transparent
        groupBoxJK.Controls.Add(rbPerempuan)
        groupBoxJK.Controls.Add(rbLaki)
        groupBoxJK.Font = New Font("High Tower Text", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        groupBoxJK.ForeColor = Color.Black
        groupBoxJK.Location = New Point(262, 260)
        groupBoxJK.Name = "groupBoxJK"
        groupBoxJK.Size = New Size(284, 166)
        groupBoxJK.TabIndex = 13
        groupBoxJK.TabStop = False
        groupBoxJK.Text = "Jenis Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(18, 93)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(135, 25)
        rbPerempuan.TabIndex = 1
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(18, 48)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(117, 25)
        rbLaki.TabIndex = 0
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' groupBoxHobby
        ' 
        groupBoxHobby.BackColor = Color.Transparent
        groupBoxHobby.Controls.Add(cbMenari)
        groupBoxHobby.Controls.Add(cbMenyanyi)
        groupBoxHobby.Controls.Add(cbOlahraga)
        groupBoxHobby.Controls.Add(cbMembaca)
        groupBoxHobby.Controls.Add(cbMemancing)
        groupBoxHobby.Controls.Add(cbMenulis)
        groupBoxHobby.Controls.Add(cbMenggambar)
        groupBoxHobby.Controls.Add(cbTraveling)
        groupBoxHobby.Controls.Add(cbCoding)
        groupBoxHobby.Controls.Add(cbGaming)
        groupBoxHobby.Font = New Font("High Tower Text", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        groupBoxHobby.Location = New Point(590, 258)
        groupBoxHobby.Name = "groupBoxHobby"
        groupBoxHobby.Size = New Size(351, 194)
        groupBoxHobby.TabIndex = 14
        groupBoxHobby.TabStop = False
        groupBoxHobby.Text = "Hobby"
        ' 
        ' cbMenari
        ' 
        cbMenari.AutoSize = True
        cbMenari.Location = New Point(196, 168)
        cbMenari.Name = "cbMenari"
        cbMenari.Size = New Size(102, 25)
        cbMenari.TabIndex = 9
        cbMenari.Text = "Menari"
        cbMenari.UseVisualStyleBackColor = True
        ' 
        ' cbMenyanyi
        ' 
        cbMenyanyi.AutoSize = True
        cbMenyanyi.Location = New Point(196, 137)
        cbMenyanyi.Name = "cbMenyanyi"
        cbMenyanyi.Size = New Size(126, 25)
        cbMenyanyi.TabIndex = 8
        cbMenyanyi.Text = "Menyanyi"
        cbMenyanyi.UseVisualStyleBackColor = True
        ' 
        ' cbOlahraga
        ' 
        cbOlahraga.AutoSize = True
        cbOlahraga.Location = New Point(196, 100)
        cbOlahraga.Name = "cbOlahraga"
        cbOlahraga.Size = New Size(119, 25)
        cbOlahraga.TabIndex = 7
        cbOlahraga.Text = "Olahraga"
        cbOlahraga.UseVisualStyleBackColor = True
        ' 
        ' cbMembaca
        ' 
        cbMembaca.AutoSize = True
        cbMembaca.Location = New Point(196, 65)
        cbMembaca.Name = "cbMembaca"
        cbMembaca.Size = New Size(122, 25)
        cbMembaca.TabIndex = 6
        cbMembaca.Text = "Membaca"
        cbMembaca.UseVisualStyleBackColor = True
        ' 
        ' cbMemancing
        ' 
        cbMemancing.AutoSize = True
        cbMemancing.Location = New Point(196, 30)
        cbMemancing.Name = "cbMemancing"
        cbMemancing.Size = New Size(142, 25)
        cbMemancing.TabIndex = 5
        cbMemancing.Text = "Memancing"
        cbMemancing.UseVisualStyleBackColor = True
        ' 
        ' cbMenulis
        ' 
        cbMenulis.AutoSize = True
        cbMenulis.Location = New Point(6, 168)
        cbMenulis.Name = "cbMenulis"
        cbMenulis.Size = New Size(111, 25)
        cbMenulis.TabIndex = 4
        cbMenulis.Text = "Menulis"
        cbMenulis.UseVisualStyleBackColor = True
        ' 
        ' cbMenggambar
        ' 
        cbMenggambar.AutoSize = True
        cbMenggambar.Location = New Point(6, 135)
        cbMenggambar.Name = "cbMenggambar"
        cbMenggambar.Size = New Size(153, 25)
        cbMenggambar.TabIndex = 3
        cbMenggambar.Text = "Menggambar"
        cbMenggambar.UseVisualStyleBackColor = True
        ' 
        ' cbTraveling
        ' 
        cbTraveling.AutoSize = True
        cbTraveling.Location = New Point(6, 100)
        cbTraveling.Name = "cbTraveling"
        cbTraveling.Size = New Size(123, 25)
        cbTraveling.TabIndex = 2
        cbTraveling.Text = "Traveling"
        cbTraveling.UseVisualStyleBackColor = True
        ' 
        ' cbCoding
        ' 
        cbCoding.AutoSize = True
        cbCoding.Location = New Point(6, 65)
        cbCoding.Name = "cbCoding"
        cbCoding.Size = New Size(100, 25)
        cbCoding.TabIndex = 1
        cbCoding.Text = "Coding"
        cbCoding.UseVisualStyleBackColor = True
        ' 
        ' cbGaming
        ' 
        cbGaming.AutoSize = True
        cbGaming.Location = New Point(6, 30)
        cbGaming.Name = "cbGaming"
        cbGaming.Size = New Size(107, 25)
        cbGaming.TabIndex = 0
        cbGaming.Text = "Gaming"
        cbGaming.UseVisualStyleBackColor = True
        ' 
        ' panelForm
        ' 
        panelForm.BackColor = Color.FromArgb(CByte(250), CByte(240), CByte(180))
        panelForm.Controls.Add(pictureBoxLogo)
        panelForm.Controls.Add(lblHeader)
        panelForm.Controls.Add(pictureBoxFoto)
        panelForm.Controls.Add(btnCetak)
        panelForm.Controls.Add(groupBoxHobby)
        panelForm.Controls.Add(btnBrowse)
        panelForm.Controls.Add(groupBoxJK)
        panelForm.Controls.Add(lblNama)
        panelForm.Controls.Add(txtAlamat)
        panelForm.Controls.Add(dtTanggal)
        panelForm.Controls.Add(lblAlamat)
        panelForm.Controls.Add(lblUmur)
        panelForm.Controls.Add(lblTelepon)
        panelForm.Controls.Add(txtTelepon)
        panelForm.Controls.Add(lblTanggal)
        panelForm.Controls.Add(txtUmur)
        panelForm.Controls.Add(txtNama)
        panelForm.Dock = DockStyle.Fill
        panelForm.Location = New Point(0, 0)
        panelForm.Name = "panelForm"
        panelForm.Size = New Size(952, 502)
        panelForm.TabIndex = 15
        ' 
        ' pictureBoxLogo
        ' 
        pictureBoxLogo.BackColor = Color.Transparent
        pictureBoxLogo.Image = My.Resources.Resources.hogwarts_logo_png_transparent_317296
        pictureBoxLogo.Location = New Point(686, 53)
        pictureBoxLogo.Name = "pictureBoxLogo"
        pictureBoxLogo.Size = New Size(231, 210)
        pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom
        pictureBoxLogo.TabIndex = 16
        pictureBoxLogo.TabStop = False
        ' 
        ' lblHeader
        ' 
        lblHeader.AutoSize = True
        lblHeader.BackColor = Color.DarkRed
        lblHeader.Dock = DockStyle.Top
        lblHeader.Font = New Font("High Tower Text", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeader.ForeColor = Color.Gold
        lblHeader.Location = New Point(0, 0)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(396, 32)
        lblHeader.TabIndex = 15
        lblHeader.Text = "HOGWARTS UNIVERSITY"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(952, 502)
        Controls.Add(panelForm)
        Name = "Form1"
        Text = "FormCetak"
        CType(pictureBoxFoto, ComponentModel.ISupportInitialize).EndInit()
        groupBoxJK.ResumeLayout(False)
        groupBoxJK.PerformLayout()
        groupBoxHobby.ResumeLayout(False)
        groupBoxHobby.PerformLayout()
        panelForm.ResumeLayout(False)
        panelForm.PerformLayout()
        CType(pictureBoxLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pictureBoxFoto As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnCetak As Button
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblTelepon As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtTelepon As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents dtTanggal As DateTimePicker
    Friend WithEvents groupBoxJK As GroupBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents groupBoxHobby As GroupBox
    Friend WithEvents cbMenggambar As CheckBox
    Friend WithEvents cbTraveling As CheckBox
    Friend WithEvents cbCoding As CheckBox
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents cbOlahraga As CheckBox
    Friend WithEvents cbMembaca As CheckBox
    Friend WithEvents cbMemancing As CheckBox
    Friend WithEvents cbMenulis As CheckBox
    Friend WithEvents cbMenari As CheckBox
    Friend WithEvents cbMenyanyi As CheckBox
    Friend WithEvents panelForm As Panel
    Friend WithEvents lblHeader As Label
    Friend WithEvents pictureBoxLogo As PictureBox

End Class
