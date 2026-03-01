Public Class Form1

    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        If txtIPS.Text = "" Then
            MessageBox.Show("Masukkan IP Semester terlebih dahulu!")
            Exit Sub
        End If

        Dim ips As Double

        If Not Double.TryParse(txtIPS.Text, ips) Then
            MessageBox.Show("Input harus berupa angka!")
            Exit Sub
        End If

        If ips < 0 Or ips > 4 Then
            MessageBox.Show("IP Semester harus antara 0 - 4")
            Exit Sub
        End If

        totalIP += ips
        jumlahSemester += 1

        Dim ipk As Double = totalIP / jumlahSemester

        txtIPK.Text = ipk.ToString("0.00")

        If ipk >= 2.0 And ipk <= 2.75 Then
            lblPredikat.Text = "Cukup"
        ElseIf ipk >= 2.76 And ipk <= 3.0 Then
            lblPredikat.Text = "Memuaskan"
        ElseIf ipk >= 3.01 Then
            lblPredikat.Text = "Sangat Memuaskan"
        Else
            lblPredikat.Text = "-"
        End If

        txtIPS.Clear()
        txtIPS.Focus()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        totalIP = 0
        jumlahSemester = 0

        txtIPS.Clear()
        txtIPK.Clear()
        lblPredikat.Text = "-"

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtIPS.TextChanged, txtIPK.TextChanged

    End Sub
End Class