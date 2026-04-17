Public Class Form2
    Private selectedLaptopId As Integer?

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SwitchPanel(pnlProduk)
        LoadMerkDropdown()
        RefreshData()
    End Sub

    Private Sub SwitchPanel(activePanel As Panel)
        pnlDashboard.Visible = False
        pnlProduk.Visible = False
        activePanel.Visible = True
        activePanel.Dock = DockStyle.Fill
    End Sub

    Private Sub LoadMerkDropdown()
        txtMerk.DataSource = DataModule.GetMerkList()
        txtMerk.DisplayMember = "namaMerk"
        txtMerk.ValueMember = "kodeMerk"
        txtMerk.SelectedIndex = -1
    End Sub

    Private Sub pnlProduk_Paint(sender As Object, e As PaintEventArgs) Handles pnlProduk.Paint
    End Sub

    Private Sub pnlSidebar_Paint(sender As Object, e As PaintEventArgs) Handles pnlSidebar.Paint
    End Sub

    Private Sub btnMenuProduk_Click(sender As Object, e As EventArgs) Handles btnMenuProduk.Click
        SwitchPanel(pnlProduk)
    End Sub

    Private Sub btnMerk_Click(sender As Object, e As EventArgs) Handles btnMerk.Click
        Form3.Show()
        Me.Hide()
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
        txtMerk.SelectedIndex = -1
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

            Dim kodeMerk = row.Cells("KodeMerk").Value?.ToString()
            If Not String.IsNullOrWhiteSpace(kodeMerk) Then
                txtMerk.SelectedValue = kodeMerk
            End If
            txtNama.Text = row.Cells("Nama").Value.ToString()
            txtHarga.Text = row.Cells("Harga").Value.ToString()
            txtStok.Text = row.Cells("Stok").Value.ToString()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtMerk.SelectedIndex < 0 OrElse ValidationModule.IsEmpty(txtNama.Text, txtHarga.Text, txtStok.Text) Then
            MessageBox.Show("Semua kolom harus diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If Not ValidationModule.IsValidNumber(txtHarga.Text) Or Not ValidationModule.IsValidNumber(txtStok.Text) Then
            MessageBox.Show("Harga dan Stok harus berupa angka yang valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim kodeMerk As String = txtMerk.SelectedValue?.ToString()
        If String.IsNullOrWhiteSpace(kodeMerk) Then
            MessageBox.Show("Merk harus dipilih.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If ValidationModule.IsduplicateLaptop(kodeMerk, txtNama.Text) Then
            MessageBox.Show("Data dengan merk dan nama yang sama sudah ada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        DataModule.InsertLaptop(kodeMerk, txtNama.Text, Convert.ToDecimal(txtHarga.Text), Convert.ToInt32(txtStok.Text))
        MessageBox.Show("Data berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoadMerkDropdown()
        RefreshData()
        ClearForm()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtMerk.SelectedIndex < 0 OrElse ValidationModule.IsEmpty(txtNama.Text, txtHarga.Text, txtStok.Text) Then
            MessageBox.Show("Semua kolom harus diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If Not ValidationModule.IsValidNumber(txtHarga.Text) Or Not ValidationModule.IsValidNumber(txtStok.Text) Then
            MessageBox.Show("Harga dan Stok harus berupa angka yang valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If Not selectedLaptopId.HasValue Then Return

        Dim kodeMerk As String = txtMerk.SelectedValue?.ToString()
        If String.IsNullOrWhiteSpace(kodeMerk) Then
            MessageBox.Show("Merk harus dipilih.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        DataModule.UpdateLaptop(selectedLaptopId.Value, kodeMerk, txtNama.Text, Convert.ToDecimal(txtHarga.Text), Convert.ToInt32(txtStok.Text))
        MessageBox.Show("Data berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoadMerkDropdown()
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