Public Class Form1

    Dim totalIPS As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim ipsBaru As Double
        Dim teksInput As String = txtIPS.Text.Trim()

        teksInput = teksInput.Replace(",", ".")

        If Double.TryParse(teksInput, ipsBaru) Then

            If ipsBaru >= 0 AndAlso ipsBaru <= 4.0 Then

                totalIPS += ipsBaru
                jumlahSemester += 1

                Dim ipk As Double = totalIPS / jumlahSemester

                Dim predikat As String = ""
                If ipk > 3.0 Then
                    predikat = "Sangat Memuaskan"
                ElseIf ipk >= 2.76 And ipk <= 3.0 Then
                    predikat = "Memuaskan"
                ElseIf ipk >= 2.0 And ipk <= 2.75 Then
                    predikat = "Cukup"
                Else
                    predikat = "Kurang"
                End If

                txtIPK.Text = ipk.ToString("0.00")
                lblPredikat.Text = predikat
                lblSemester.Text = jumlahSemester.ToString()

                txtIPS.Clear()
                txtIPS.Focus()
            Else
                MessageBox.Show("Mohon masukkan rentang nilai IPS antara 0,00 sampai 4,00.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtIPS.Focus()
            End If
        Else
            MessageBox.Show("Input tidak valid! Pastikan Anda memasukkan angka.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtIPS.Clear()
            txtIPS.Focus()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        totalIPS = 0
        jumlahSemester = 0

        txtIPK.Text = "0.00"
        lblPredikat.Text = "-"
        lblSemester.Text = "0"

        txtIPS.Clear()
        txtIPS.Focus()
    End Sub

    Private Sub txtIPS_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIPS.KeyDown, txtIPK.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnTambah.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click, Label5.Click

    End Sub
End Class