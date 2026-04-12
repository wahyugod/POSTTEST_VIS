Public Class Form2
    Private selectedLaptopId As Integer?

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SwitchPanel(pnlProduk)
        RefreshData()
    End Sub

    Private Sub SwitchPanel(activePanel As Panel)
        pnlDashboard.Visible = False
        pnlProduk.Visible = False
        activePanel.Visible = True
        activePanel.Dock = DockStyle.Fill
    End Sub

    Private Sub pnlProduk_Paint(sender As Object, e As PaintEventArgs) Handles pnlProduk.Paint
    End Sub

    Private Sub pnlSidebar_Paint(sender As Object, e As PaintEventArgs) Handles pnlSidebar.Paint
    End Sub

    Private Sub btnMenuProduk_Click(sender As Object, e As EventArgs) Handles btnMenuProduk.Click
        SwitchPanel(pnlProduk)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Form1.Show()
        Form1.txtPassword.Clear()
        Me.Close()
    End Sub

    Private Sub RefreshData()
        dgvLaptops.DataSource = DataModule.GetLaptops()
        Dim total As Integer, merk As String = "", stok As String = ""
        DataModule.GetDashboardStats(total, merk, stok)
        lblTotal.Text = total.ToString()
        lblTopMerk.Text = merk
        lblTopStok.Text = stok
    End Sub

    Private Sub ClearForm()
        selectedLaptopId = Nothing
        txtMerk.Clear()
        txtNama.Clear()
        txtHarga.Clear()
        txtStok.Clear()
    End Sub

    Private Sub dgvLaptops_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLaptops.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvLaptops.Rows(e.RowIndex)
            Dim idValue As Integer
            If Integer.TryParse(row.Cells("ID").Value?.ToString(), idValue) Then
                selectedLaptopId = idValue
            Else
                selectedLaptopId = Nothing
            End If
            txtMerk.Text = row.Cells("Merk").Value.ToString()
            txtNama.Text = row.Cells("Nama").Value.ToString()
            txtHarga.Text = row.Cells("Harga").Value.ToString()
            txtStok.Text = row.Cells("Stok").Value.ToString()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If ValidationModule.IsEmpty(txtMerk.Text, txtNama.Text, txtHarga.Text, txtStok.Text) Then
            MessageBox.Show("Semua kolom harus diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If Not ValidationModule.IsValidNumber(txtHarga.Text) Or Not ValidationModule.IsValidNumber(txtStok.Text) Then
            MessageBox.Show("Harga dan Stok harus berupa angka yang valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'jika Data dengan merk dan nama yang sama sudah ada, tampilkan pesan error
        If ValidationModule.IsDuplicateLaptop(txtMerk.Text, txtNama.Text) Then
            MessageBox.Show("Data dengan merk dan nama yang sama sudah ada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        DataModule.InsertLaptop(txtMerk.Text, txtNama.Text, Convert.ToDecimal(txtHarga.Text), Convert.ToInt32(txtStok.Text))
        MessageBox.Show("Data berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        RefreshData()
        ClearForm()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If ValidationModule.IsEmpty(txtMerk.Text, txtNama.Text, txtHarga.Text, txtStok.Text) Then
            MessageBox.Show("Semua kolom harus diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If Not ValidationModule.IsValidNumber(txtHarga.Text) Or Not ValidationModule.IsValidNumber(txtStok.Text) Then
            MessageBox.Show("Harga dan Stok harus berupa angka yang valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If Not selectedLaptopId.HasValue Then Return
        DataModule.UpdateLaptop(selectedLaptopId.Value, txtMerk.Text, txtNama.Text, Convert.ToDecimal(txtHarga.Text), Convert.ToInt32(txtStok.Text))
        MessageBox.Show("Data berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        RefreshData()
        ClearForm()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Not selectedLaptopId.HasValue Then Return
        If MessageBox.Show("Hapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            DataModule.DeleteLaptop(selectedLaptopId.Value)
            RefreshData()
            ClearForm()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub
End Class