<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUser))
        txtNKK = New TextBox()
        cbGender = New ComboBox()
        txtNominal = New TextBox()
        txtDeskripsi = New TextBox()
        txtGajih = New TextBox()
        txtRek = New TextBox()
        txtTelp = New TextBox()
        txtAlamat = New TextBox()
        txtNama = New TextBox()
        btnBrowse = New Button()
        btnSimpan = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        btnCetak = New Button()
        Label10 = New Label()
        btnKeluar = New Button()
        btnBatal = New Button()
        pbSlipGajih = New PictureBox()
        CType(pbSlipGajih, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNKK
        ' 
        txtNKK.Location = New Point(214, 78)
        txtNKK.Margin = New Padding(4, 3, 4, 3)
        txtNKK.Name = "txtNKK"
        txtNKK.Size = New Size(239, 31)
        txtNKK.TabIndex = 0
        ' 
        ' cbGender
        ' 
        cbGender.FormattingEnabled = True
        cbGender.Items.AddRange(New Object() {"Pria", "Wanita"})
        cbGender.Location = New Point(659, 78)
        cbGender.Margin = New Padding(4, 3, 4, 3)
        cbGender.Name = "cbGender"
        cbGender.Size = New Size(209, 33)
        cbGender.TabIndex = 1
        ' 
        ' txtNominal
        ' 
        txtNominal.Location = New Point(694, 508)
        txtNominal.Margin = New Padding(4, 3, 4, 3)
        txtNominal.Name = "txtNominal"
        txtNominal.Size = New Size(174, 31)
        txtNominal.TabIndex = 2
        ' 
        ' txtDeskripsi
        ' 
        txtDeskripsi.Location = New Point(100, 622)
        txtDeskripsi.Margin = New Padding(4, 3, 4, 3)
        txtDeskripsi.Multiline = True
        txtDeskripsi.Name = "txtDeskripsi"
        txtDeskripsi.Size = New Size(1102, 88)
        txtDeskripsi.TabIndex = 3
        ' 
        ' txtGajih
        ' 
        txtGajih.Location = New Point(214, 508)
        txtGajih.Margin = New Padding(4, 3, 4, 3)
        txtGajih.Name = "txtGajih"
        txtGajih.Size = New Size(239, 31)
        txtGajih.TabIndex = 4
        ' 
        ' txtRek
        ' 
        txtRek.Location = New Point(214, 408)
        txtRek.Margin = New Padding(4, 3, 4, 3)
        txtRek.Name = "txtRek"
        txtRek.Size = New Size(654, 31)
        txtRek.TabIndex = 5
        ' 
        ' txtTelp
        ' 
        txtTelp.Location = New Point(214, 316)
        txtTelp.Margin = New Padding(4, 3, 4, 3)
        txtTelp.Name = "txtTelp"
        txtTelp.Size = New Size(654, 31)
        txtTelp.TabIndex = 6
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(214, 234)
        txtAlamat.Margin = New Padding(4, 3, 4, 3)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(654, 31)
        txtAlamat.TabIndex = 7
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(214, 153)
        txtNama.Margin = New Padding(4, 3, 4, 3)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(654, 31)
        txtNama.TabIndex = 8
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.SlateGray
        btnBrowse.ForeColor = Color.White
        btnBrowse.Location = New Point(925, 447)
        btnBrowse.Margin = New Padding(4, 3, 4, 3)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(280, 52)
        btnBrowse.TabIndex = 10
        btnBrowse.Text = "Upload"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.SlateGray
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(100, 739)
        btnSimpan.Margin = New Padding(4, 3, 4, 3)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(265, 44)
        btnSimpan.TabIndex = 11
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(95, 81)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 25)
        Label1.TabIndex = 13
        Label1.Text = "NKK"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(95, 156)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 25)
        Label2.TabIndex = 14
        Label2.Text = "Nama"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(95, 241)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 25)
        Label3.TabIndex = 15
        Label3.Text = "Alamat"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(95, 320)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 25)
        Label4.TabIndex = 16
        Label4.Text = "No Telp"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.ForeColor = SystemColors.ButtonHighlight
        Label5.Location = New Point(95, 411)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 25)
        Label5.TabIndex = 17
        Label5.Text = "No Rek"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.ForeColor = SystemColors.ButtonHighlight
        Label6.Location = New Point(561, 81)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(69, 25)
        Label6.TabIndex = 18
        Label6.Text = "Gender"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.ForeColor = SystemColors.ButtonHighlight
        Label7.Location = New Point(95, 508)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(97, 25)
        Label7.TabIndex = 19
        Label7.Text = "Gaji /bulan"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.ForeColor = SystemColors.ButtonHighlight
        Label8.Location = New Point(479, 511)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(218, 25)
        Label8.TabIndex = 20
        Label8.Text = "Nominal yang dibutuhkan"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.ForeColor = SystemColors.ButtonHighlight
        Label9.Location = New Point(95, 592)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(174, 25)
        Label9.TabIndex = 21
        Label9.Text = "Deskripsi Kebutuhan"
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.SlateGray
        btnCetak.ForeColor = Color.White
        btnCetak.Location = New Point(379, 739)
        btnCetak.Margin = New Padding(4, 3, 4, 3)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(265, 44)
        btnCetak.TabIndex = 22
        btnCetak.Text = "Cetak"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.ForeColor = SystemColors.HighlightText
        Label10.Location = New Point(1005, 108)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(117, 25)
        Label10.TabIndex = 23
        Label10.Text = "Foto Slip Gaji"
        ' 
        ' btnKeluar
        ' 
        btnKeluar.BackColor = Color.SlateGray
        btnKeluar.ForeColor = Color.White
        btnKeluar.Location = New Point(938, 739)
        btnKeluar.Margin = New Padding(4, 3, 4, 3)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(265, 44)
        btnKeluar.TabIndex = 24
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.SlateGray
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(659, 739)
        btnBatal.Margin = New Padding(4, 3, 4, 3)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(265, 44)
        btnBatal.TabIndex = 25
        btnBatal.Text = "Refresh"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' pbSlipGajih
        ' 
        pbSlipGajih.BackColor = Color.White
        pbSlipGajih.Location = New Point(926, 153)
        pbSlipGajih.Margin = New Padding(4, 3, 4, 3)
        pbSlipGajih.Name = "pbSlipGajih"
        pbSlipGajih.Size = New Size(278, 288)
        pbSlipGajih.SizeMode = PictureBoxSizeMode.StretchImage
        pbSlipGajih.TabIndex = 9
        pbSlipGajih.TabStop = False
        ' 
        ' FormUser
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1295, 867)
        Controls.Add(btnBatal)
        Controls.Add(btnKeluar)
        Controls.Add(Label10)
        Controls.Add(btnCetak)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnSimpan)
        Controls.Add(btnBrowse)
        Controls.Add(pbSlipGajih)
        Controls.Add(txtNama)
        Controls.Add(txtAlamat)
        Controls.Add(txtTelp)
        Controls.Add(txtRek)
        Controls.Add(txtGajih)
        Controls.Add(txtDeskripsi)
        Controls.Add(txtNominal)
        Controls.Add(cbGender)
        Controls.Add(txtNKK)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        Name = "FormUser"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormUser"
        CType(pbSlipGajih, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents txtNKK As TextBox
    Friend WithEvents cbGender As ComboBox
    Friend WithEvents txtNominal As TextBox
    Friend WithEvents txtDeskripsi As TextBox
    Friend WithEvents txtGajih As TextBox
    Friend WithEvents txtRek As TextBox
    Friend WithEvents txtTelp As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents pbSlipGajih As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnCetak As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnBatal As Button
End Class
