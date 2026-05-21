<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCetak
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCetak))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        btnKembali = New Button()
        lblNKK = New Label()
        lblGender = New Label()
        lblNama = New Label()
        lblRek = New Label()
        lblTelp = New Label()
        lblAlamat = New Label()
        lblDeskripsi = New Label()
        lblNominal = New Label()
        lblGajih = New Label()
        pbSlipGajih = New PictureBox()
        Label10 = New Label()
        Label11 = New Label()
        CType(pbSlipGajih, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(56, 148)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 29)
        Label1.TabIndex = 0
        Label1.Text = "NKK :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(56, 222)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 29)
        Label2.TabIndex = 1
        Label2.Text = "Gender :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(56, 295)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 29)
        Label3.TabIndex = 2
        Label3.Text = "Nama :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(56, 372)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(106, 29)
        Label4.TabIndex = 3
        Label4.Text = "Alamat :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ButtonHighlight
        Label5.Location = New Point(56, 448)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(114, 29)
        Label5.TabIndex = 4
        Label5.Text = "No Telp :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ButtonHighlight
        Label6.Location = New Point(56, 528)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(109, 29)
        Label6.TabIndex = 5
        Label6.Text = "No Rek :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ButtonHighlight
        Label7.Location = New Point(56, 608)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(145, 29)
        Label7.TabIndex = 6
        Label7.Text = "Gaji/bulan :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ButtonHighlight
        Label8.Location = New Point(56, 684)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(323, 29)
        Label8.TabIndex = 7
        Label8.Text = "Nominal yang dibutuhkan :"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ButtonHighlight
        Label9.Location = New Point(56, 764)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(263, 29)
        Label9.TabIndex = 8
        Label9.Text = "Deskripsi kebutuhan :"
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.SlateGray
        btnKembali.ForeColor = Color.White
        btnKembali.Location = New Point(849, 797)
        btnKembali.Margin = New Padding(4, 3, 4, 3)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(153, 52)
        btnKembali.TabIndex = 9
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' lblNKK
        ' 
        lblNKK.AutoSize = True
        lblNKK.BackColor = Color.Transparent
        lblNKK.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNKK.ForeColor = SystemColors.ButtonHighlight
        lblNKK.Location = New Point(410, 152)
        lblNKK.Margin = New Padding(4, 0, 4, 0)
        lblNKK.Name = "lblNKK"
        lblNKK.Size = New Size(93, 29)
        lblNKK.TabIndex = 10
        lblNKK.Text = "lblNKK"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.BackColor = Color.Transparent
        lblGender.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGender.ForeColor = SystemColors.ButtonHighlight
        lblGender.Location = New Point(410, 223)
        lblGender.Margin = New Padding(4, 0, 4, 0)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(126, 29)
        lblGender.TabIndex = 11
        lblGender.Text = "lblGender"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = Color.Transparent
        lblNama.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNama.ForeColor = SystemColors.ButtonHighlight
        lblNama.Location = New Point(410, 297)
        lblNama.Margin = New Padding(4, 0, 4, 0)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(106, 29)
        lblNama.TabIndex = 12
        lblNama.Text = "lblNama"
        ' 
        ' lblRek
        ' 
        lblRek.AutoSize = True
        lblRek.BackColor = Color.Transparent
        lblRek.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRek.ForeColor = SystemColors.ButtonHighlight
        lblRek.Location = New Point(410, 531)
        lblRek.Margin = New Padding(4, 0, 4, 0)
        lblRek.Name = "lblRek"
        lblRek.Size = New Size(85, 29)
        lblRek.TabIndex = 15
        lblRek.Text = "lblRek"
        ' 
        ' lblTelp
        ' 
        lblTelp.AutoSize = True
        lblTelp.BackColor = Color.Transparent
        lblTelp.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTelp.ForeColor = SystemColors.ButtonHighlight
        lblTelp.Location = New Point(410, 452)
        lblTelp.Margin = New Padding(4, 0, 4, 0)
        lblTelp.Name = "lblTelp"
        lblTelp.Size = New Size(90, 29)
        lblTelp.TabIndex = 14
        lblTelp.Text = "lblTelp"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.BackColor = Color.Transparent
        lblAlamat.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAlamat.ForeColor = SystemColors.ButtonHighlight
        lblAlamat.Location = New Point(410, 373)
        lblAlamat.Margin = New Padding(4, 0, 4, 0)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(121, 29)
        lblAlamat.TabIndex = 13
        lblAlamat.Text = "lblAlamat"
        ' 
        ' lblDeskripsi
        ' 
        lblDeskripsi.AutoSize = True
        lblDeskripsi.BackColor = Color.Transparent
        lblDeskripsi.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDeskripsi.ForeColor = SystemColors.ButtonHighlight
        lblDeskripsi.Location = New Point(410, 766)
        lblDeskripsi.Margin = New Padding(4, 0, 4, 0)
        lblDeskripsi.Name = "lblDeskripsi"
        lblDeskripsi.Size = New Size(149, 29)
        lblDeskripsi.TabIndex = 18
        lblDeskripsi.Text = "lblDeskripsi"
        ' 
        ' lblNominal
        ' 
        lblNominal.AutoSize = True
        lblNominal.BackColor = Color.Transparent
        lblNominal.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNominal.ForeColor = SystemColors.ButtonHighlight
        lblNominal.Location = New Point(410, 684)
        lblNominal.Margin = New Padding(4, 0, 4, 0)
        lblNominal.Name = "lblNominal"
        lblNominal.Size = New Size(137, 29)
        lblNominal.TabIndex = 17
        lblNominal.Text = "lblNominal"
        ' 
        ' lblGajih
        ' 
        lblGajih.AutoSize = True
        lblGajih.BackColor = Color.Transparent
        lblGajih.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGajih.ForeColor = SystemColors.ButtonHighlight
        lblGajih.Location = New Point(410, 609)
        lblGajih.Margin = New Padding(4, 0, 4, 0)
        lblGajih.Name = "lblGajih"
        lblGajih.Size = New Size(103, 29)
        lblGajih.TabIndex = 16
        lblGajih.Text = "lblGajih"
        ' 
        ' pbSlipGajih
        ' 
        pbSlipGajih.BackColor = Color.White
        pbSlipGajih.Location = New Point(724, 195)
        pbSlipGajih.Margin = New Padding(4, 3, 4, 3)
        pbSlipGajih.Name = "pbSlipGajih"
        pbSlipGajih.Size = New Size(278, 445)
        pbSlipGajih.SizeMode = PictureBoxSizeMode.StretchImage
        pbSlipGajih.TabIndex = 20
        pbSlipGajih.TabStop = False
        ' 
        ' Label10
        ' 
        Label10.BackColor = Color.White
        Label10.Font = New Font("Arial", 25.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(-2, 11)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(1085, 103)
        Label10.TabIndex = 19
        Label10.Text = "DATA PENERIMA BLT"
        Label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(815, 670)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(125, 25)
        Label11.TabIndex = 21
        Label11.Text = "*Foto Slip Gaji"
        ' 
        ' FormCetak
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1079, 891)
        Controls.Add(Label11)
        Controls.Add(pbSlipGajih)
        Controls.Add(Label10)
        Controls.Add(lblDeskripsi)
        Controls.Add(lblNominal)
        Controls.Add(lblGajih)
        Controls.Add(lblRek)
        Controls.Add(lblTelp)
        Controls.Add(lblAlamat)
        Controls.Add(lblNama)
        Controls.Add(lblGender)
        Controls.Add(lblNKK)
        Controls.Add(btnKembali)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        Name = "FormCetak"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormCetak"
        CType(pbSlipGajih, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnKembali As Button
    Friend WithEvents lblNKK As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblRek As Label
    Friend WithEvents lblTelp As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblDeskripsi As Label
    Friend WithEvents lblNominal As Label
    Friend WithEvents lblGajih As Label
    Friend WithEvents pbSlipGajih As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
