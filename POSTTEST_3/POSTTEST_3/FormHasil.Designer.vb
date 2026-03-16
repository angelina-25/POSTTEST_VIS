<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHasil
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        pictureBoxFoto = New PictureBox()
        lblTextNama = New Label()
        lblTextUmur = New Label()
        lblTextTelepon = New Label()
        lblTextJK = New Label()
        lblTextHobby = New Label()
        lblTextTanggal = New Label()
        lblTextAlamat = New Label()
        panelKartu = New Panel()
        PictureBox1 = New PictureBox()
        lblStudent = New Label()
        lblAlamat = New Label()
        lblTanggal = New Label()
        lblHobby = New Label()
        lblJK = New Label()
        lblTelepon = New Label()
        lblUmur = New Label()
        lblNama = New Label()
        Panel1 = New Panel()
        lblHeader = New Label()
        CType(pictureBoxFoto, ComponentModel.ISupportInitialize).BeginInit()
        panelKartu.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pictureBoxFoto
        ' 
        pictureBoxFoto.Location = New Point(22, 94)
        pictureBoxFoto.Name = "pictureBoxFoto"
        pictureBoxFoto.Size = New Size(230, 260)
        pictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage
        pictureBoxFoto.TabIndex = 0
        pictureBoxFoto.TabStop = False
        ' 
        ' lblTextNama
        ' 
        lblTextNama.AutoSize = True
        lblTextNama.Font = New Font("High Tower Text", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTextNama.Location = New Point(284, 94)
        lblTextNama.Name = "lblTextNama"
        lblTextNama.Size = New Size(66, 21)
        lblTextNama.TabIndex = 1
        lblTextNama.Text = "Nama :"
        ' 
        ' lblTextUmur
        ' 
        lblTextUmur.AutoSize = True
        lblTextUmur.Font = New Font("High Tower Text", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTextUmur.Location = New Point(284, 130)
        lblTextUmur.Name = "lblTextUmur"
        lblTextUmur.Size = New Size(65, 21)
        lblTextUmur.TabIndex = 2
        lblTextUmur.Text = "Umur :"
        ' 
        ' lblTextTelepon
        ' 
        lblTextTelepon.AutoSize = True
        lblTextTelepon.Font = New Font("High Tower Text", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTextTelepon.Location = New Point(284, 166)
        lblTextTelepon.Name = "lblTextTelepon"
        lblTextTelepon.Size = New Size(109, 21)
        lblTextTelepon.TabIndex = 3
        lblTextTelepon.Text = "No Telepon :"
        ' 
        ' lblTextJK
        ' 
        lblTextJK.AutoSize = True
        lblTextJK.Font = New Font("High Tower Text", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTextJK.Location = New Point(284, 205)
        lblTextJK.Name = "lblTextJK"
        lblTextJK.Size = New Size(125, 21)
        lblTextJK.TabIndex = 4
        lblTextJK.Text = "Jenis Kelamin :"
        ' 
        ' lblTextHobby
        ' 
        lblTextHobby.AutoSize = True
        lblTextHobby.Font = New Font("High Tower Text", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTextHobby.Location = New Point(284, 245)
        lblTextHobby.Name = "lblTextHobby"
        lblTextHobby.Size = New Size(71, 21)
        lblTextHobby.TabIndex = 5
        lblTextHobby.Text = "Hobby :"
        ' 
        ' lblTextTanggal
        ' 
        lblTextTanggal.AutoSize = True
        lblTextTanggal.Font = New Font("High Tower Text", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTextTanggal.Location = New Point(284, 284)
        lblTextTanggal.Name = "lblTextTanggal"
        lblTextTanggal.Size = New Size(131, 21)
        lblTextTanggal.TabIndex = 6
        lblTextTanggal.Text = "Tanggal Lahir :"
        ' 
        ' lblTextAlamat
        ' 
        lblTextAlamat.AutoSize = True
        lblTextAlamat.Font = New Font("High Tower Text", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTextAlamat.Location = New Point(284, 323)
        lblTextAlamat.Name = "lblTextAlamat"
        lblTextAlamat.Size = New Size(77, 21)
        lblTextAlamat.TabIndex = 7
        lblTextAlamat.Text = "Alamat :"
        ' 
        ' panelKartu
        ' 
        panelKartu.BackColor = Color.FromArgb(CByte(250), CByte(240), CByte(180))
        panelKartu.Controls.Add(PictureBox1)
        panelKartu.Controls.Add(lblStudent)
        panelKartu.Controls.Add(lblAlamat)
        panelKartu.Controls.Add(lblTanggal)
        panelKartu.Controls.Add(lblHobby)
        panelKartu.Controls.Add(lblJK)
        panelKartu.Controls.Add(lblTelepon)
        panelKartu.Controls.Add(lblUmur)
        panelKartu.Controls.Add(lblNama)
        panelKartu.Controls.Add(Panel1)
        panelKartu.Controls.Add(lblHeader)
        panelKartu.Controls.Add(pictureBoxFoto)
        panelKartu.Controls.Add(lblTextAlamat)
        panelKartu.Controls.Add(lblTextNama)
        panelKartu.Controls.Add(lblTextTanggal)
        panelKartu.Controls.Add(lblTextUmur)
        panelKartu.Controls.Add(lblTextHobby)
        panelKartu.Controls.Add(lblTextTelepon)
        panelKartu.Controls.Add(lblTextJK)
        panelKartu.Dock = DockStyle.Fill
        panelKartu.Font = New Font("High Tower Text", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        panelKartu.Location = New Point(0, 0)
        panelKartu.Name = "panelKartu"
        panelKartu.Size = New Size(800, 450)
        panelKartu.TabIndex = 8
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.hogwarts_logo_png_transparent_317296
        PictureBox1.Location = New Point(597, 274)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(176, 160)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' lblStudent
        ' 
        lblStudent.AutoSize = True
        lblStudent.BackColor = Color.DarkRed
        lblStudent.Font = New Font("High Tower Text", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStudent.ForeColor = Color.Gold
        lblStudent.Location = New Point(66, 380)
        lblStudent.Name = "lblStudent"
        lblStudent.Size = New Size(506, 37)
        lblStudent.TabIndex = 17
        lblStudent.Text = "STUDENT IDENTIFICATION"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(416, 323)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(0, 21)
        lblAlamat.TabIndex = 16
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Location = New Point(415, 284)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(0, 21)
        lblTanggal.TabIndex = 15
        ' 
        ' lblHobby
        ' 
        lblHobby.AutoSize = True
        lblHobby.Font = New Font("High Tower Text", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblHobby.Location = New Point(416, 245)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(0, 21)
        lblHobby.TabIndex = 14
        ' 
        ' lblJK
        ' 
        lblJK.AutoSize = True
        lblJK.Font = New Font("High Tower Text", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblJK.Location = New Point(416, 205)
        lblJK.Name = "lblJK"
        lblJK.Size = New Size(0, 21)
        lblJK.TabIndex = 13
        ' 
        ' lblTelepon
        ' 
        lblTelepon.AutoSize = True
        lblTelepon.Font = New Font("High Tower Text", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTelepon.Location = New Point(416, 166)
        lblTelepon.Name = "lblTelepon"
        lblTelepon.Size = New Size(0, 21)
        lblTelepon.TabIndex = 12
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.Font = New Font("High Tower Text", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblUmur.Location = New Point(416, 130)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(0, 21)
        lblUmur.TabIndex = 11
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("High Tower Text", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblNama.Location = New Point(416, 94)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(0, 21)
        lblNama.TabIndex = 10
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Gold
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 37)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 54)
        Panel1.TabIndex = 9
        ' 
        ' lblHeader
        ' 
        lblHeader.AutoSize = True
        lblHeader.BackColor = Color.DarkRed
        lblHeader.Dock = DockStyle.Top
        lblHeader.Font = New Font("High Tower Text", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeader.ForeColor = Color.Gold
        lblHeader.Location = New Point(0, 0)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(463, 37)
        lblHeader.TabIndex = 8
        lblHeader.Text = "HOGWARTS UNIVERSITY"
        lblHeader.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FormHasil
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(panelKartu)
        Name = "FormHasil"
        Text = "FormHasil"
        CType(pictureBoxFoto, ComponentModel.ISupportInitialize).EndInit()
        panelKartu.ResumeLayout(False)
        panelKartu.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pictureBoxFoto As PictureBox
    Friend WithEvents lblTextNama As Label
    Friend WithEvents lblTextUmur As Label
    Friend WithEvents lblTextTelepon As Label
    Friend WithEvents lblTextJK As Label
    Friend WithEvents lblTextHobby As Label
    Friend WithEvents lblTextTanggal As Label
    Friend WithEvents lblTextAlamat As Label
    Friend WithEvents panelKartu As Panel
    Friend WithEvents lblHeader As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblHobby As Label
    Friend WithEvents lblJK As Label
    Friend WithEvents lblTelepon As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblStudent As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
