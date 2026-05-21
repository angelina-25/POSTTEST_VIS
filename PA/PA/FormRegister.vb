Imports MySql.Data.MySqlClient

Public Class FormRegister


    Private Sub FormRegister_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        txtPassword.UseSystemPasswordChar = True

    End Sub



    Private Sub btnRegister_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnRegister.Click


        If txtUsername.Text.Trim = "" Or
           txtPassword.Text.Trim = "" Then

            MsgBox(
                "Username dan Password tidak boleh kosong!"
            )

            Exit Sub

        End If



        Try

            Call Connect()


            cmd = New MySqlCommand(
                "SELECT * FROM tb_user
                 WHERE username=@u",
                conn
            )

            cmd.Parameters.AddWithValue(
                "@u",
                txtUsername.Text.Trim()
            )


            rd =
            cmd.ExecuteReader()


            If rd.Read() Then

                rd.Close()

                MsgBox(
                    "Username sudah digunakan!"
                )

                Exit Sub

            End If


            rd.Close()



            cmd = New MySqlCommand(
                "INSERT INTO tb_user
                (username,password)
                VALUES(@u,@p)",
                conn
            )

            cmd.Parameters.AddWithValue(
                "@u",
                txtUsername.Text.Trim()
            )

            cmd.Parameters.AddWithValue(
                "@p",
                txtPassword.Text.Trim()
            )


            cmd.ExecuteNonQuery()


            MsgBox(
                "Registrasi berhasil!"
            )


            txtUsername.Clear()

            txtPassword.Clear()


            Dim login As New Form1()

            login.Show()

            Me.Close()


        Catch ex As Exception

            MsgBox(
                "Error : " &
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

    Private Sub btnKembali_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnKembali.Click


        Dim login As New Form1()

        login.Show()

        Me.Close()


    End Sub


End Class