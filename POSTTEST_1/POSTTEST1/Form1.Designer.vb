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
        Label1 = New Label()
        txtIPSemester = New TextBox()
        Label2 = New Label()
        txtIPK = New TextBox()
        txtPredikat = New Label()
        lblPredikat = New Label()
        btntambah = New Button()
        btnreset = New Button()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(117, 97)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 25)
        Label1.TabIndex = 0
        Label1.Text = "IP Semester"
        ' 
        ' txtIPSemester
        ' 
        txtIPSemester.Location = New Point(278, 97)
        txtIPSemester.Name = "txtIPSemester"
        txtIPSemester.Size = New Size(150, 31)
        txtIPSemester.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(115, 168)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 25)
        Label2.TabIndex = 2
        Label2.Text = "IP Kumulatif"
        ' 
        ' txtIPK
        ' 
        txtIPK.Location = New Point(278, 168)
        txtIPK.Name = "txtIPK"
        txtIPK.Size = New Size(150, 31)
        txtIPK.TabIndex = 3
        ' 
        ' txtPredikat
        ' 
        txtPredikat.AutoSize = True
        txtPredikat.Location = New Point(222, 248)
        txtPredikat.Name = "txtPredikat"
        txtPredikat.Size = New Size(0, 25)
        txtPredikat.TabIndex = 4
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.Location = New Point(117, 319)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(0, 25)
        lblPredikat.TabIndex = 5
        ' 
        ' btntambah
        ' 
        btntambah.Location = New Point(278, 319)
        btntambah.Name = "btntambah"
        btntambah.Size = New Size(112, 34)
        btntambah.TabIndex = 6
        btntambah.Text = "Tambah"
        btntambah.UseVisualStyleBackColor = True
        ' 
        ' btnreset
        ' 
        btnreset.Location = New Point(476, 319)
        btnreset.Name = "btnreset"
        btnreset.Size = New Size(112, 34)
        btnreset.TabIndex = 7
        btnreset.Text = "Reset"
        btnreset.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(123, 319)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 25)
        Label3.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(278, 356)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 25)
        Label4.TabIndex = 9
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(btnreset)
        Controls.Add(btntambah)
        Controls.Add(lblPredikat)
        Controls.Add(txtPredikat)
        Controls.Add(txtIPK)
        Controls.Add(Label2)
        Controls.Add(txtIPSemester)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIPSemester As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIPK As TextBox
    Friend WithEvents txtPredikat As Label
    Friend WithEvents lblPredikat As Label
    Friend WithEvents btntambah As Button
    Friend WithEvents btnreset As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label

End Class
