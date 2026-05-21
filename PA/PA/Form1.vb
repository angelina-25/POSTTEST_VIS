Imports MySql.Data.MySqlClient
Public Class Form1
    Public Shared username As String
    Private Sub Form1_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text.Trim = "" OrElse
           txtPassword.Text.Trim = "" Then
            MsgBox(
                "Username dan Password tidak boleh kosong!"
            )
            Exit Sub
        End If
        If txtUsername.Text.Trim = "admin" AndAlso
           txtPassword.Text.Trim = "admin123" Then
            FormAdmin.Show()
            Me.Hide()
            Exit Sub
        End If
        Try
            Call Connect()

            cmd =
            New MySqlCommand(
            "SELECT * FROM tb_user
            WHERE username=@u
            AND password=@p",
            conn
            )
            cmd.Parameters.AddWithValue("@u", txtUsername.Text.Trim())

            cmd.Parameters.AddWithValue(
                "@p",
                txtPassword.Text.Trim()
            )

            rd =
            cmd.ExecuteReader()


            If rd.Read() Then

                username =
                    txtUsername.Text

                MsgBox(
                    "Login berhasil!"
                )

                FormUser.Show()

                Me.Hide()

            Else

                MsgBox(
                    "Username atau Password salah!"
                )
            End If
        Catch ex As Exception
            MsgBox(
                ex.Message
            )
        Finally
            If rd IsNot Nothing Then
                If Not rd.IsClosed Then
                    rd.Close()
                End If
            End If
            If conn IsNot Nothing Then

                If conn.State =
                ConnectionState.Open Then
                    conn.Close()
                End If
            End If
        End Try
    End Sub
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        FormRegister.Show()
        Me.Hide()
    End Sub
End Class