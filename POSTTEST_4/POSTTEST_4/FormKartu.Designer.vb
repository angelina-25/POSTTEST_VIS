<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKartu
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
        picFoto = New PictureBox()
        lblNamaKartu = New Label()
        lblIDKartu = New Label()
        lblKomunitasKartu = New Label()
        lblKontakKartu = New Label()
        lblHobiKartu = New Label()
        Button1 = New Button()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picFoto
        ' 
        picFoto.Location = New Point(41, 45)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(208, 229)
        picFoto.SizeMode = PictureBoxSizeMode.Zoom
        picFoto.TabIndex = 0
        picFoto.TabStop = False
        ' 
        ' lblNamaKartu
        ' 
        lblNamaKartu.AutoSize = True
        lblNamaKartu.Font = New Font("High Tower Text", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNamaKartu.Location = New Point(335, 45)
        lblNamaKartu.Name = "lblNamaKartu"
        lblNamaKartu.Size = New Size(63, 21)
        lblNamaKartu.TabIndex = 1
        lblNamaKartu.Text = "Nama"
        ' 
        ' lblIDKartu
        ' 
        lblIDKartu.AutoSize = True
        lblIDKartu.Font = New Font("High Tower Text", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblIDKartu.Location = New Point(335, 94)
        lblIDKartu.Name = "lblIDKartu"
        lblIDKartu.Size = New Size(34, 21)
        lblIDKartu.TabIndex = 2
        lblIDKartu.Text = "ID"
        ' 
        ' lblKomunitasKartu
        ' 
        lblKomunitasKartu.AutoSize = True
        lblKomunitasKartu.Font = New Font("High Tower Text", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblKomunitasKartu.Location = New Point(335, 144)
        lblKomunitasKartu.Name = "lblKomunitasKartu"
        lblKomunitasKartu.Size = New Size(108, 21)
        lblKomunitasKartu.TabIndex = 3
        lblKomunitasKartu.Text = "Komunitas"
        ' 
        ' lblKontakKartu
        ' 
        lblKontakKartu.AutoSize = True
        lblKontakKartu.Font = New Font("High Tower Text", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblKontakKartu.Location = New Point(335, 191)
        lblKontakKartu.Name = "lblKontakKartu"
        lblKontakKartu.Size = New Size(75, 21)
        lblKontakKartu.TabIndex = 4
        lblKontakKartu.Text = "Kontak"
        ' 
        ' lblHobiKartu
        ' 
        lblHobiKartu.AutoSize = True
        lblHobiKartu.Font = New Font("High Tower Text", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHobiKartu.Location = New Point(335, 238)
        lblHobiKartu.Name = "lblHobiKartu"
        lblHobiKartu.Size = New Size(162, 21)
        lblHobiKartu.TabIndex = 5
        lblHobiKartu.Text = "Hobby/Aktivitas"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Highlight
        Button1.Font = New Font("High Tower Text", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(335, 313)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 6
        Button1.Text = "Kembali"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' FormKartu
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(lblHobiKartu)
        Controls.Add(lblKontakKartu)
        Controls.Add(lblKomunitasKartu)
        Controls.Add(lblIDKartu)
        Controls.Add(lblNamaKartu)
        Controls.Add(picFoto)
        Name = "FormKartu"
        Text = "FormKartu"
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picFoto As PictureBox
    Friend WithEvents lblNamaKartu As Label
    Friend WithEvents lblIDKartu As Label
    Friend WithEvents lblKomunitasKartu As Label
    Friend WithEvents lblKontakKartu As Label
    Friend WithEvents lblHobiKartu As Label

    Private Sub FormKartu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblNama_Click(sender As Object, e As EventArgs) Handles lblNamaKartu.Click

    End Sub

    Friend WithEvents Button1 As Button
End Class
