<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdmin
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdmin))
        dgvDataUser = New DataGridView()
        txtNKK = New TextBox()
        txtNama = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        cbStatus = New ComboBox()
        Label3 = New Label()
        btnUpdate = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        btnKeluar = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        MenuStrip1 = New MenuStrip()
        PrintDataUserToolStripMenuItem = New ToolStripMenuItem()
        PrintDataUserToolStripMenuItem1 = New ToolStripMenuItem()
        SaveDataToolStripMenuItem = New ToolStripMenuItem()
        txtPencarian = New TextBox()
        Label4 = New Label()
        SaveFileDialog1 = New SaveFileDialog()
        ErrorProvider1 = New ErrorProvider(components)
        CType(dgvDataUser, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvDataUser
        ' 
        dgvDataUser.AllowUserToOrderColumns = True
        dgvDataUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDataUser.Location = New Point(36, 67)
        dgvDataUser.Margin = New Padding(3, 2, 3, 2)
        dgvDataUser.Name = "dgvDataUser"
        dgvDataUser.ReadOnly = True
        dgvDataUser.RowHeadersWidth = 62
        dgvDataUser.RowTemplate.Height = 28
        dgvDataUser.Size = New Size(1210, 347)
        dgvDataUser.TabIndex = 0
        ' 
        ' txtNKK
        ' 
        txtNKK.Location = New Point(149, 528)
        txtNKK.Margin = New Padding(3, 2, 3, 2)
        txtNKK.Name = "txtNKK"
        txtNKK.Size = New Size(268, 31)
        txtNKK.TabIndex = 1
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(580, 525)
        txtNama.Margin = New Padding(3, 2, 3, 2)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(268, 31)
        txtNama.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(36, 533)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 25)
        Label1.TabIndex = 3
        Label1.Text = "NKK"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(482, 531)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 25)
        Label2.TabIndex = 4
        Label2.Text = "Nama"
        ' 
        ' cbStatus
        ' 
        cbStatus.FormattingEnabled = True
        cbStatus.Items.AddRange(New Object() {"disetujui", "ditolak"})
        cbStatus.Location = New Point(1003, 523)
        cbStatus.Margin = New Padding(3, 2, 3, 2)
        cbStatus.Name = "cbStatus"
        cbStatus.Size = New Size(243, 33)
        cbStatus.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(908, 528)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 25)
        Label3.TabIndex = 6
        Label3.Text = "Status"
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.SlateGray
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(36, 602)
        btnUpdate.Margin = New Padding(3, 2, 3, 2)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(330, 44)
        btnUpdate.TabIndex = 7
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.SlateGray
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(509, 602)
        btnHapus.Margin = New Padding(3, 2, 3, 2)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(320, 44)
        btnHapus.TabIndex = 8
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.SlateGray
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(933, 602)
        btnBatal.Margin = New Padding(3, 2, 3, 2)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(313, 44)
        btnBatal.TabIndex = 9
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' btnKeluar
        ' 
        btnKeluar.BackColor = Color.SlateGray
        btnKeluar.ForeColor = Color.White
        btnKeluar.Location = New Point(1124, 11)
        btnKeluar.Margin = New Padding(3, 2, 3, 2)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(143, 40)
        btnKeluar.TabIndex = 10
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Dock = DockStyle.None
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {PrintDataUserToolStripMenuItem})
        MenuStrip1.Location = New Point(10, 11)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 2, 0, 2)
        MenuStrip1.Size = New Size(63, 33)
        MenuStrip1.TabIndex = 11
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' PrintDataUserToolStripMenuItem
        ' 
        PrintDataUserToolStripMenuItem.BackColor = Color.SlateGray
        PrintDataUserToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PrintDataUserToolStripMenuItem1, SaveDataToolStripMenuItem})
        PrintDataUserToolStripMenuItem.ForeColor = Color.White
        PrintDataUserToolStripMenuItem.Name = "PrintDataUserToolStripMenuItem"
        PrintDataUserToolStripMenuItem.Size = New Size(54, 29)
        PrintDataUserToolStripMenuItem.Text = "File"
        ' 
        ' PrintDataUserToolStripMenuItem1
        ' 
        PrintDataUserToolStripMenuItem1.Name = "PrintDataUserToolStripMenuItem1"
        PrintDataUserToolStripMenuItem1.Size = New Size(182, 34)
        PrintDataUserToolStripMenuItem1.Text = "Print"
        ' 
        ' SaveDataToolStripMenuItem
        ' 
        SaveDataToolStripMenuItem.Name = "SaveDataToolStripMenuItem"
        SaveDataToolStripMenuItem.Size = New Size(182, 34)
        SaveDataToolStripMenuItem.Text = "Save File"
        ' 
        ' txtPencarian
        ' 
        txtPencarian.Location = New Point(149, 456)
        txtPencarian.Margin = New Padding(3, 2, 3, 2)
        txtPencarian.Name = "txtPencarian"
        txtPencarian.Size = New Size(1097, 31)
        txtPencarian.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(36, 456)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 25)
        Label4.TabIndex = 13
        Label4.Text = "Pencarian"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' FormAdmin
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1281, 708)
        Controls.Add(Label4)
        Controls.Add(txtPencarian)
        Controls.Add(btnKeluar)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUpdate)
        Controls.Add(Label3)
        Controls.Add(cbStatus)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtNama)
        Controls.Add(txtNKK)
        Controls.Add(dgvDataUser)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.None
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 2, 3, 2)
        Name = "FormAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "  "
        CType(dgvDataUser, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents dgvDataUser As DataGridView
    Friend WithEvents txtNKK As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PrintDataUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintDataUserToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents txtPencarian As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents SaveDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
