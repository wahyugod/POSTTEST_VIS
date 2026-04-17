Public Class Form3
    Private selectedKodeMerk As String = String.Empty

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLaptops.EnableHeadersVisualStyles = False
        dgvLaptops.ColumnHeadersDefaultCellStyle.BackColor = Color.Red
        dgvLaptops.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvLaptops.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Red
        dgvLaptops.ThemeStyle.HeaderStyle.BackColor = Color.Red
        dgvLaptops.ThemeStyle.HeaderStyle.ForeColor = Color.White

        RefreshData()
    End Sub

    Private Sub RefreshData()
        dgvLaptops.DataSource = DataModule.GetMerk()
        ClearForm()
    End Sub

    Private Sub ClearForm()
        selectedKodeMerk = String.Empty
        txtMerk.Clear()
        txtNama.Clear()
    End Sub

    Private Sub dgvLaptops_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLaptops.CellClick
        If e.RowIndex < 0 Then Return

        Dim row As DataGridViewRow = dgvLaptops.Rows(e.RowIndex)
        txtMerk.Text = row.Cells("KodeMerk").Value?.ToString()
        txtNama.Text = row.Cells("NamaMerk").Value?.ToString()
        selectedKodeMerk = txtMerk.Text
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If ValidationModule.IsEmpty(txtMerk.Text, txtNama.Text) Then
            MessageBox.Show("Kode Merk dan Nama Merk harus diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            DataModule.InsertMerk(txtMerk.Text.Trim(), txtNama.Text.Trim())
            MessageBox.Show("Data merk berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            RefreshData()
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data merk: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If ValidationModule.IsEmpty(txtMerk.Text, txtNama.Text) Then
            MessageBox.Show("Kode Merk dan Nama Merk harus diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrWhiteSpace(selectedKodeMerk) Then Return

        Try
            DataModule.UpdateMerk(selectedKodeMerk, txtNama.Text.Trim())
            MessageBox.Show("Data merk berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            RefreshData()
        Catch ex As Exception
            MessageBox.Show("Gagal memperbarui data merk: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrWhiteSpace(selectedKodeMerk) Then Return

        If MessageBox.Show("Hapus data merk ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
            Return
        End If

        Try
            DataModule.DeleteMerk(selectedKodeMerk)
            MessageBox.Show("Data merk berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            RefreshData()
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data merk: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub btnMenuProduk_Click(sender As Object, e As EventArgs) Handles btnMenuProduk.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Form1.Show()
        Me.Close()
    End Sub

End Class