<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRegister))
        Label1 = New Label()
        Label2 = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        PictureBox1 = New PictureBox()
        btnKembali = New Button()
        btnRegister = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(276, 279)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 29)
        Label1.TabIndex = 4
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(280, 414)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 29)
        Label2.TabIndex = 5
        Label2.Text = "Password"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(170, 318)
        txtUsername.Margin = New Padding(3, 2, 3, 2)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(374, 35)
        txtUsername.TabIndex = 6
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(170, 452)
        txtPassword.Margin = New Padding(3, 2, 3, 2)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(374, 35)
        txtPassword.TabIndex = 7
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(223, 46)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(224, 214)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.SlateGray
        btnKembali.ForeColor = SystemColors.ButtonFace
        btnKembali.Location = New Point(170, 564)
        btnKembali.Margin = New Padding(3, 4, 3, 4)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(103, 44)
        btnKembali.TabIndex = 9
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.SlateGray
        btnRegister.ForeColor = SystemColors.ButtonFace
        btnRegister.Location = New Point(413, 564)
        btnRegister.Margin = New Padding(3, 4, 3, 4)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(113, 44)
        btnRegister.TabIndex = 10
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' FormRegister
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(724, 681)
        Controls.Add(btnRegister)
        Controls.Add(btnKembali)
        Controls.Add(PictureBox1)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormRegister"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormRegister"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnKembali As Button
    Friend WithEvents btnRegister As Button
End Class
