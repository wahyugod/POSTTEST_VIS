Imports System.IO

Public Class Form1
    Dim grupHobi() As CheckBox
    Dim grupJK() As RadioButton

    Private Function CekData() As Boolean
        grupHobi = {cbHobi1, cbHobi2, cbHobi3, cbHobi4, cbHobi5, cbHobi6, cbHobi7, cbHobi8, cbHobi9, cbHobi10, cbHobi11, cbHobi12}
        grupJK = {rbLaki, rbPerempuan}

        Dim pesanError As String = "Inputan tidak boleh kosong"

        If Not ValidasiTextBox(txtNama, pesanError) Then Return False
        If Not ValidasiTextBox(txtUmur, pesanError) Then Return False
        If Not ValidasiTextBox(txtNoTelp, pesanError) Then Return False
        If Not ValidasiTextBox(txtAlamat, pesanError) Then Return False
        If Not ValidasiRadioButton(grupJK, pesanError) Then Return False
        If Not ValidasiCheckBox(grupHobi, pesanError) Then Return False
        If Not ValidasiPictureBox(picProfil, pesanError) Then Return False

        Return True
    End Function

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If CekData() Then
            Dim Hobi_Selected As String = GetSelectedCheckBox(grupHobi)
            Dim jk_Selected As String = GetSelectedRadioButton(grupJK)

            DataModule.Nama = txtNama.Text
            DataModule.Umur = txtUmur.Text
            DataModule.NoTelp = txtNoTelp.Text
            DataModule.Alamat = txtAlamat.Text
            DataModule.Hobi = Hobi_Selected
            DataModule.JK = jk_Selected
            DataModule.Tglahir = dtpLahir.Value.ToShortDateString()

            Form2.Show()
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If ValidasiTextBox(txtNama, "Isi nama terlebih dahulu untuk nama file gambar") Then
            Dim NamaFile As String = txtNama.Text.Trim()
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            openFileDialog.Title = "Pilih Gambar"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim folderPath As String = Path.Combine(Application.StartupPath, "Foto")
                Dim fileName As String = NamaFile & Path.GetExtension(openFileDialog.FileName)
                Dim destinationPath As String = Path.Combine(folderPath, fileName)

                If Not Directory.Exists(folderPath) Then
                    Directory.CreateDirectory(folderPath)
                End If

                File.Copy(openFileDialog.FileName, destinationPath, True)
                DataModule.Foto = destinationPath
                picProfil.Image = Image.FromFile(destinationPath)
                MessageBox.Show("Gambar berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        ValidationModule.HanyaHuruf(sender, e)
    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        ValidationModule.HanyaAngka(sender, e)
    End Sub

    Private Sub txtNoTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoTelp.KeyPress
        ValidationModule.HanyaAngka(sender, e)
    End Sub

    Private Sub lblJudul_Click(sender As Object, e As EventArgs) Handles lblJudul.Click

    End Sub

    Private Sub cbHobi4_CheckedChanged(sender As Object, e As EventArgs) Handles cbHobi4.CheckedChanged

    End Sub
End Class