<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        btnLogin = New Button()
        btnRegister = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(424, 348)
        txtUsername.Margin = New Padding(3, 2, 3, 2)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(374, 35)
        txtUsername.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(424, 478)
        txtPassword.Margin = New Padding(3, 2, 3, 2)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(375, 35)
        txtPassword.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.RoyalBlue
        Label1.Location = New Point(542, 296)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 29)
        Label1.TabIndex = 3
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.RoyalBlue
        Label2.Location = New Point(542, 412)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 29)
        Label2.TabIndex = 4
        Label2.Text = "Password"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.RoyalBlue
        btnLogin.Font = New Font("Microsoft Sans Serif", 7.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(483, 560)
        btnLogin.Margin = New Padding(3, 2, 3, 2)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(276, 64)
        btnLogin.TabIndex = 5
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.Transparent
        btnRegister.Font = New Font("Microsoft Sans Serif", 7.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegister.ForeColor = Color.RoyalBlue
        btnRegister.Location = New Point(483, 682)
        btnRegister.Margin = New Padding(3, 2, 3, 2)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(276, 55)
        btnRegister.TabIndex = 6
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ActiveBorder
        Label3.Location = New Point(483, 630)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 20)
        Label3.TabIndex = 7
        Label3.Text = "_____________"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ActiveBorder
        Label4.Location = New Point(650, 631)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 20)
        Label4.TabIndex = 8
        Label4.Text = "_____________"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ActiveBorder
        Label5.Location = New Point(607, 639)
        Label5.Name = "Label5"
        Label5.Size = New Size(28, 20)
        Label5.TabIndex = 9
        Label5.Text = "OR"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(493, 42)
        PictureBox1.Margin = New Padding(3, 5, 3, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(224, 249)
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(842, 795)
        Controls.Add(PictureBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(btnRegister)
        Controls.Add(btnLogin)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = " "
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnRegister As Button
End Class
