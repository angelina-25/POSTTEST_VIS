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
        GroupBox1 = New GroupBox()
        btntambah = New Button()
        txtgenre = New TextBox()
        txtjudul = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        btnhapus = New Button()
        txthapus = New TextBox()
        Label3 = New Label()
        ListBox1 = New ListBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btntambah)
        GroupBox1.Controls.Add(txtgenre)
        GroupBox1.Controls.Add(txtjudul)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(30, 30)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(321, 191)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Tambah Buku"
        ' 
        ' btntambah
        ' 
        btntambah.BackColor = SystemColors.ButtonShadow
        btntambah.Location = New Point(172, 143)
        btntambah.Name = "btntambah"
        btntambah.Size = New Size(112, 34)
        btntambah.TabIndex = 3
        btntambah.Text = "Tambah"
        btntambah.UseVisualStyleBackColor = False
        ' 
        ' txtgenre
        ' 
        txtgenre.BackColor = SystemColors.Info
        txtgenre.Location = New Point(134, 94)
        txtgenre.Name = "txtgenre"
        txtgenre.Size = New Size(150, 31)
        txtgenre.TabIndex = 1
        ' 
        ' txtjudul
        ' 
        txtjudul.BackColor = SystemColors.Info
        txtjudul.Location = New Point(134, 41)
        txtjudul.Name = "txtjudul"
        txtjudul.Size = New Size(150, 31)
        txtjudul.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(20, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 25)
        Label2.TabIndex = 2
        Label2.Text = "Genre"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 25)
        Label1.TabIndex = 1
        Label1.Text = "Judul Buku"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnhapus)
        GroupBox2.Controls.Add(txthapus)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Location = New Point(430, 42)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(320, 179)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hapus Buku"
        ' 
        ' btnhapus
        ' 
        btnhapus.BackColor = SystemColors.ButtonShadow
        btnhapus.Location = New Point(167, 110)
        btnhapus.Name = "btnhapus"
        btnhapus.Size = New Size(112, 34)
        btnhapus.TabIndex = 2
        btnhapus.Text = "Hapus"
        btnhapus.UseVisualStyleBackColor = False
        ' 
        ' txthapus
        ' 
        txthapus.BackColor = SystemColors.Info
        txthapus.Location = New Point(144, 41)
        txthapus.Name = "txthapus"
        txthapus.Size = New Size(150, 31)
        txthapus.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(16, 41)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 25)
        Label3.TabIndex = 0
        Label3.Text = "Judul Buku"
        ' 
        ' ListBox1
        ' 
        ListBox1.BackColor = SystemColors.ControlLight
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(232, 242)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(303, 179)
        ListBox1.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(ListBox1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btntambah As Button
    Friend WithEvents txtgenre As TextBox
    Friend WithEvents txtjudul As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnhapus As Button
    Friend WithEvents txthapus As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBox1 As ListBox

End Class
