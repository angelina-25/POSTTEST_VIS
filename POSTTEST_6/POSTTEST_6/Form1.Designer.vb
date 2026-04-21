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
        components = New ComponentModel.Container()
        lblJudul = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtKode = New TextBox()
        txtNama = New TextBox()
        txtHarga = New TextBox()
        Label4 = New Label()
        txtSearch = New TextBox()
        dgvPizza = New DataGridView()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        dgvPesanan = New DataGridView()
        Label5 = New Label()
        Label6 = New Label()
        btnHitung = New Button()
        btnPesan = New Button()
        txtJumlah = New TextBox()
        txtTotal = New TextBox()
        CType(dgvPizza, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvPesanan, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(34, 9)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(332, 26)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Sistem Pemesanan Pizza Online"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("STZhongsong", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(34, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 20)
        Label1.TabIndex = 1
        Label1.Text = "Kode Pizza"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("STZhongsong", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(34, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 20)
        Label2.TabIndex = 2
        Label2.Text = "Nama Pizza"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("STZhongsong", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(34, 144)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 20)
        Label3.TabIndex = 3
        Label3.Text = "Harga"
        ' 
        ' txtKode
        ' 
        txtKode.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtKode.Location = New Point(165, 48)
        txtKode.Name = "txtKode"
        txtKode.Size = New Size(201, 31)
        txtKode.TabIndex = 4
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtNama.Location = New Point(165, 94)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(201, 31)
        txtNama.TabIndex = 5
        ' 
        ' txtHarga
        ' 
        txtHarga.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtHarga.Location = New Point(165, 138)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(201, 31)
        txtHarga.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("STZhongsong", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Label4.Location = New Point(847, 19)
        Label4.Name = "Label4"
        Label4.Size = New Size(95, 20)
        Label4.TabIndex = 7
        Label4.Text = "Cari Pizza"
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(964, 8)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(266, 31)
        txtSearch.TabIndex = 8
        ' 
        ' dgvPizza
        ' 
        dgvPizza.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPizza.Location = New Point(34, 226)
        dgvPizza.Name = "dgvPizza"
        dgvPizza.RowHeadersWidth = 62
        dgvPizza.Size = New Size(591, 273)
        dgvPizza.TabIndex = 14
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.SaddleBrown
        btnSimpan.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpan.Location = New Point(43, 186)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(112, 34)
        btnSimpan.TabIndex = 15
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.SaddleBrown
        btnUbah.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUbah.Location = New Point(203, 186)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(112, 34)
        btnUbah.TabIndex = 16
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.SaddleBrown
        btnHapus.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHapus.Location = New Point(358, 186)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(112, 34)
        btnHapus.TabIndex = 17
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.SaddleBrown
        btnBatal.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBatal.Location = New Point(513, 186)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(112, 34)
        btnBatal.TabIndex = 18
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' dgvPesanan
        ' 
        dgvPesanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPesanan.Location = New Point(725, 226)
        dgvPesanan.Name = "dgvPesanan"
        dgvPesanan.RowHeadersWidth = 62
        dgvPesanan.Size = New Size(505, 273)
        dgvPesanan.TabIndex = 19
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("STZhongsong", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(745, 54)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 20)
        Label5.TabIndex = 20
        Label5.Text = "Jumlah"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("STZhongsong", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(745, 100)
        Label6.Name = "Label6"
        Label6.Size = New Size(52, 20)
        Label6.TabIndex = 21
        Label6.Text = "Total"
        ' 
        ' btnHitung
        ' 
        btnHitung.BackColor = Color.SaddleBrown
        btnHitung.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHitung.Location = New Point(820, 172)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(112, 34)
        btnHitung.TabIndex = 22
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = False
        ' 
        ' btnPesan
        ' 
        btnPesan.BackColor = Color.SaddleBrown
        btnPesan.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPesan.Location = New Point(1023, 172)
        btnPesan.Name = "btnPesan"
        btnPesan.Size = New Size(112, 34)
        btnPesan.TabIndex = 23
        btnPesan.Text = "Pesan"
        btnPesan.UseVisualStyleBackColor = False
        ' 
        ' txtJumlah
        ' 
        txtJumlah.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtJumlah.Location = New Point(847, 54)
        txtJumlah.Name = "txtJumlah"
        txtJumlah.Size = New Size(201, 31)
        txtJumlah.TabIndex = 24
        ' 
        ' txtTotal
        ' 
        txtTotal.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtTotal.Location = New Point(847, 100)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(201, 31)
        txtTotal.TabIndex = 25
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Tan
        ClientSize = New Size(1253, 515)
        Controls.Add(txtTotal)
        Controls.Add(txtJumlah)
        Controls.Add(btnPesan)
        Controls.Add(btnHitung)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(dgvPesanan)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(dgvPizza)
        Controls.Add(txtSearch)
        Controls.Add(Label4)
        Controls.Add(txtHarga)
        Controls.Add(txtNama)
        Controls.Add(txtKode)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblJudul)
        Name = "Form1"
        Text = "Form1"
        CType(dgvPizza, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvPesanan, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtKode As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvPizza As DataGridView
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents dgvPesanan As DataGridView
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents btnPesan As Button
    Friend WithEvents btnHitung As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label

End Class
