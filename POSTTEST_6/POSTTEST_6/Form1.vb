Imports System.Drawing
Imports System.Windows

Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If ValidationModule.IsEmpty(txtUsername.Text, txtPassword.Text) Then
            MessageBox.Show("Username dan Password tidak boleh kosong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If DataModule.LoginUser(txtUsername.Text, txtPassword.Text) Then
            Dim dashboard As New Form2()
            dashboard.Show()
            Me.Hide()
        Else
            MessageBox.Show("Kredensial tidak valid. Silakan coba lagi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

End Class