<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUtama
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
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        ErrorProvider1 = New ErrorProvider(components)
        OpenFileDialog1 = New OpenFileDialog()
        OpenFileDialog2 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        TabPage3 = New TabPage()
        picFoto = New PictureBox()
        btnBrowse = New Button()
        GroupBoxKartu = New GroupBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        cbHobby1 = New CheckBox()
        btnCetak = New Button()
        cbHobby2 = New CheckBox()
        cbHobby3 = New CheckBox()
        cbHobby4 = New CheckBox()
        cbHobby5 = New CheckBox()
        cbHobby6 = New CheckBox()
        cbHobby7 = New CheckBox()
        cbHobby8 = New CheckBox()
        TabPage2 = New TabPage()
        lblKontakKartu = New MaskedTextBox()
        txtEmail = New TextBox()
        txtAlamat = New TextBox()
        TabPage1 = New TabPage()
        lblNamaKartu = New TextBox()
        lblIDKartu = New TextBox()
        dtpLahir = New DateTimePicker()
        rbLaki = New RadioButton()
        rbPerempuan = New RadioButton()
        lblKomunitasKartu = New ComboBox()
        TabControl1 = New TabControl()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        GroupBoxKartu.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage1.SuspendLayout()
        TabControl1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKartuToolStripMenuItem, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(867, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(112, 29)
        InputDataToolStripMenuItem.Text = "Input Data"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Size = New Size(111, 29)
        LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Size = New Size(130, 29)
        SimpanDataToolStripMenuItem.Text = "Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.Size = New Size(108, 29)
        BukaDataToolStripMenuItem.Text = "Buka Data"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(76, 29)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bernard MT Condensed", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(253, 33)
        Label1.TabIndex = 1
        Label1.Text = "Komunitas Olahraga"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.logo_no_bg__1_
        PictureBox1.Location = New Point(12, 88)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(225, 208)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' OpenFileDialog2
        ' 
        OpenFileDialog2.FileName = "OpenFileDialog2"
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = SystemColors.InactiveCaption
        TabPage3.Controls.Add(cbHobby8)
        TabPage3.Controls.Add(cbHobby7)
        TabPage3.Controls.Add(cbHobby6)
        TabPage3.Controls.Add(cbHobby5)
        TabPage3.Controls.Add(cbHobby4)
        TabPage3.Controls.Add(cbHobby3)
        TabPage3.Controls.Add(cbHobby2)
        TabPage3.Controls.Add(btnCetak)
        TabPage3.Controls.Add(cbHobby1)
        TabPage3.Controls.Add(GroupBoxKartu)
        TabPage3.Controls.Add(btnBrowse)
        TabPage3.Controls.Add(picFoto)
        TabPage3.Font = New Font("High Tower Text", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TabPage3.Location = New Point(4, 34)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(515, 418)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profil & Aktivitas"
        ' 
        ' picFoto
        ' 
        picFoto.Location = New Point(19, 16)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(161, 145)
        picFoto.SizeMode = PictureBoxSizeMode.Zoom
        picFoto.TabIndex = 0
        picFoto.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = SystemColors.Highlight
        btnBrowse.Location = New Point(41, 176)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(112, 34)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' GroupBoxKartu
        ' 
        GroupBoxKartu.Controls.Add(RadioButton3)
        GroupBoxKartu.Controls.Add(RadioButton2)
        GroupBoxKartu.Controls.Add(RadioButton1)
        GroupBoxKartu.Location = New Point(35, 244)
        GroupBoxKartu.Name = "GroupBoxKartu"
        GroupBoxKartu.Size = New Size(157, 146)
        GroupBoxKartu.TabIndex = 2
        GroupBoxKartu.TabStop = False
        GroupBoxKartu.Text = "Peran"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(6, 39)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(87, 25)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Ketua"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(6, 74)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(110, 25)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "Anggota"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(6, 109)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(96, 25)
        RadioButton3.TabIndex = 2
        RadioButton3.TabStop = True
        RadioButton3.Text = "Admin"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' cbHobby1
        ' 
        cbHobby1.AutoSize = True
        cbHobby1.Location = New Point(205, 27)
        cbHobby1.Name = "cbHobby1"
        cbHobby1.Size = New Size(77, 25)
        cbHobby1.TabIndex = 3
        cbHobby1.Text = "Voli"
        cbHobby1.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = SystemColors.Highlight
        btnCetak.Location = New Point(207, 244)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(252, 35)
        btnCetak.TabIndex = 4
        btnCetak.Text = "Simpan & Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' cbHobby2
        ' 
        cbHobby2.AutoSize = True
        cbHobby2.Location = New Point(205, 62)
        cbHobby2.Name = "cbHobby2"
        cbHobby2.Size = New Size(87, 25)
        cbHobby2.TabIndex = 5
        cbHobby2.Text = "futsal"
        cbHobby2.UseVisualStyleBackColor = True
        ' 
        ' cbHobby3
        ' 
        cbHobby3.AutoSize = True
        cbHobby3.Location = New Point(205, 97)
        cbHobby3.Name = "cbHobby3"
        cbHobby3.Size = New Size(94, 25)
        cbHobby3.TabIndex = 6
        cbHobby3.Text = "Basket"
        cbHobby3.UseVisualStyleBackColor = True
        ' 
        ' cbHobby4
        ' 
        cbHobby4.AutoSize = True
        cbHobby4.Location = New Point(205, 132)
        cbHobby4.Name = "cbHobby4"
        cbHobby4.Size = New Size(75, 25)
        cbHobby4.TabIndex = 7
        cbHobby4.Text = "bola"
        cbHobby4.UseVisualStyleBackColor = True
        ' 
        ' cbHobby5
        ' 
        cbHobby5.AutoSize = True
        cbHobby5.Location = New Point(334, 27)
        cbHobby5.Name = "cbHobby5"
        cbHobby5.Size = New Size(135, 25)
        cbHobby5.TabIndex = 8
        cbHobby5.Text = "Badminton"
        cbHobby5.UseVisualStyleBackColor = True
        ' 
        ' cbHobby6
        ' 
        cbHobby6.AutoSize = True
        cbHobby6.Location = New Point(334, 62)
        cbHobby6.Name = "cbHobby6"
        cbHobby6.Size = New Size(86, 25)
        cbHobby6.TabIndex = 9
        cbHobby6.Text = "Tenis"
        cbHobby6.UseVisualStyleBackColor = True
        ' 
        ' cbHobby7
        ' 
        cbHobby7.AutoSize = True
        cbHobby7.Location = New Point(335, 97)
        cbHobby7.Name = "cbHobby7"
        cbHobby7.Size = New Size(84, 25)
        cbHobby7.TabIndex = 10
        cbHobby7.Text = "Padel"
        cbHobby7.UseVisualStyleBackColor = True
        ' 
        ' cbHobby8
        ' 
        cbHobby8.AutoSize = True
        cbHobby8.Location = New Point(334, 132)
        cbHobby8.Name = "cbHobby8"
        cbHobby8.Size = New Size(114, 25)
        cbHobby8.TabIndex = 11
        cbHobby8.Text = "Running"
        cbHobby8.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = SystemColors.InactiveCaption
        TabPage2.Controls.Add(txtAlamat)
        TabPage2.Controls.Add(txtEmail)
        TabPage2.Controls.Add(lblKontakKartu)
        TabPage2.Font = New Font("High Tower Text", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TabPage2.Location = New Point(4, 34)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(515, 418)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak & Info"
        ' 
        ' lblKontakKartu
        ' 
        lblKontakKartu.AccessibleDescription = ""
        lblKontakKartu.Location = New Point(23, 25)
        lblKontakKartu.Mask = "0000-0000-0000"
        lblKontakKartu.Name = "lblKontakKartu"
        lblKontakKartu.Size = New Size(150, 28)
        lblKontakKartu.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(23, 100)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email"
        txtEmail.Size = New Size(150, 28)
        txtEmail.TabIndex = 1
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(23, 171)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.PlaceholderText = "Alamat"
        txtAlamat.Size = New Size(150, 28)
        txtAlamat.TabIndex = 2
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = SystemColors.InactiveCaption
        TabPage1.Controls.Add(lblKomunitasKartu)
        TabPage1.Controls.Add(rbPerempuan)
        TabPage1.Controls.Add(rbLaki)
        TabPage1.Controls.Add(dtpLahir)
        TabPage1.Controls.Add(lblIDKartu)
        TabPage1.Controls.Add(lblNamaKartu)
        TabPage1.Font = New Font("High Tower Text", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TabPage1.Location = New Point(4, 34)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(515, 418)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Utama"
        ' 
        ' lblNamaKartu
        ' 
        lblNamaKartu.Location = New Point(18, 15)
        lblNamaKartu.Name = "lblNamaKartu"
        lblNamaKartu.PlaceholderText = "Nama"
        lblNamaKartu.Size = New Size(150, 28)
        lblNamaKartu.TabIndex = 0
        ' 
        ' lblIDKartu
        ' 
        lblIDKartu.Location = New Point(18, 63)
        lblIDKartu.Name = "lblIDKartu"
        lblIDKartu.PlaceholderText = "ID"
        lblIDKartu.Size = New Size(150, 28)
        lblIDKartu.TabIndex = 1
        ' 
        ' dtpLahir
        ' 
        dtpLahir.Location = New Point(18, 112)
        dtpLahir.Name = "dtpLahir"
        dtpLahir.Size = New Size(300, 28)
        dtpLahir.TabIndex = 2
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(18, 162)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(117, 25)
        rbLaki.TabIndex = 3
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(172, 162)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(135, 25)
        rbPerempuan.TabIndex = 4
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' lblKomunitasKartu
        ' 
        lblKomunitasKartu.AccessibleName = ""
        lblKomunitasKartu.FormattingEnabled = True
        lblKomunitasKartu.Items.AddRange(New Object() {"Voli", "Basket", "Futsal", "Badminton"})
        lblKomunitasKartu.Location = New Point(18, 197)
        lblKomunitasKartu.Name = "lblKomunitasKartu"
        lblKomunitasKartu.Size = New Size(182, 29)
        lblKomunitasKartu.TabIndex = 4
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(284, 36)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(523, 456)
        TabControl1.TabIndex = 3
        ' 
        ' FormUtama
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(867, 521)
        Controls.Add(TabControl1)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "FormUtama"
        Text = "FormUtama"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        GroupBoxKartu.ResumeLayout(False)
        GroupBoxKartu.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabControl1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lblKomunitasKartu As ComboBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents lblIDKartu As TextBox
    Friend WithEvents lblNamaKartu As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblKontakKartu As MaskedTextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents cbHobby8 As CheckBox
    Friend WithEvents cbHobby7 As CheckBox
    Friend WithEvents cbHobby6 As CheckBox
    Friend WithEvents cbHobby5 As CheckBox
    Friend WithEvents cbHobby4 As CheckBox
    Friend WithEvents cbHobby3 As CheckBox
    Friend WithEvents cbHobby2 As CheckBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents cbHobby1 As CheckBox
    Friend WithEvents GroupBoxKartu As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents btnBrowse As Button
    Friend WithEvents picFoto As PictureBox

End Class
