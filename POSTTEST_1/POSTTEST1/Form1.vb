Public Class Form1

    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0
    Dim ipk As Double = 0
    Dim predikat As String = ""

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click

        Dim ipSemester As Double

        If Double.TryParse(txtIPSemester.Text, ipSemester) Then

            If ipSemester < 0 Or ipSemester > 4 Then
                MessageBox.Show("IP Semester harus antara 0 - 4")
                txtIPSemester.Clear()
                txtIPSemester.Focus()
                Exit Sub
            End If

            totalIP += ipSemester
            jumlahSemester += 1

            ipk = totalIP / jumlahSemester
            txtIPK.Text = ipk.ToString("0.00")

            If ipk >= 2.0 And ipk <= 2.75 Then
                predikat = "Cukup"
            ElseIf ipk >= 2.76 And ipk <= 3.0 Then
                predikat = "Memuaskan"
            ElseIf ipk >= 3.01 Then
                predikat = "Sangat Memuaskan"
            Else
                predikat = "-"
            End If

            txtPredikat.Text = predikat

            txtIPSemester.Clear()
            txtIPSemester.Focus()

        Else
            MessageBox.Show("Input harus berupa angka!")
            txtIPSemester.Clear()
            txtIPSemester.Focus()
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnreset.Click

        totalIP = 0
        jumlahSemester = 0
        ipk = 0
        predikat = ""

        txtIPSemester.Clear()
        txtIPK.Clear()
        txtPredikat.Text = ""

        txtIPSemester.Focus()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class