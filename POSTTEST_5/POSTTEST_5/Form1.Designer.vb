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
        CType(dgvPizza, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Location = New Point(34, 9)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(259, 25)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Sistem Pemesanan Pizza Online"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(34, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 25)
        Label1.TabIndex = 1
        Label1.Text = "Kode Pizza"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(34, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 25)
        Label2.TabIndex = 2
        Label2.Text = "Nama Pizza"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(34, 144)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 25)
        Label3.TabIndex = 3
        Label3.Text = "Harga"
        ' 
        ' txtKode
        ' 
        txtKode.Location = New Point(165, 48)
        txtKode.Name = "txtKode"
        txtKode.Size = New Size(150, 31)
        txtKode.TabIndex = 4
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(165, 94)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(150, 31)
        txtNama.TabIndex = 5
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(165, 138)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(150, 31)
        txtHarga.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(449, 19)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 25)
        Label4.TabIndex = 7
        Label4.Text = "Cari Pizza"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(554, 19)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(150, 31)
        txtSearch.TabIndex = 8
        ' 
        ' dgvPizza
        ' 
        dgvPizza.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPizza.Location = New Point(34, 226)
        dgvPizza.Name = "dgvPizza"
        dgvPizza.RowHeadersWidth = 62
        dgvPizza.Size = New Size(683, 218)
        dgvPizza.TabIndex = 14
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(43, 186)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(112, 34)
        btnSimpan.TabIndex = 15
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(237, 186)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(112, 34)
        btnUbah.TabIndex = 16
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(423, 186)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(112, 34)
        btnHapus.TabIndex = 17
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(605, 186)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(112, 34)
        btnBatal.TabIndex = 18
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
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

End Class
