Public Class Form1

    Private Sub UpdateTampilanList(ByRef targetListBox As ListBox)
        targetListBox.Items.Clear()
        For i As Integer = 0 To jumlahBuku - 1
            targetListBox.Items.Add(daftarBuku(i))
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateTampilanList(ListBoxBuku)
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim judulBaru As String = txtJudulTambah.Text.Trim()
        Dim genreBaru As String = txtGenre.Text.Trim()

        If judulBaru <> "" AndAlso genreBaru <> "" Then
            TambahBukuArray(judulBaru, genreBaru)

            UpdateTampilanList(ListBoxBuku)

            txtJudulTambah.Clear()
            txtGenre.Clear()
            txtJudulTambah.Focus()
        Else
            MessageBox.Show("Judul dan Genre harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim judulHapus As String = txtJudulHapus.Text.Trim()

        If judulHapus <> "" Then
            Dim indeksDitemukan As Integer = CariIndeksBuku(judulHapus)

            If indeksDitemukan <> -1 Then
                HapusBukuArray(indeksDitemukan)

                UpdateTampilanList(ListBoxBuku)

                txtJudulHapus.Clear()
                MessageBox.Show("Buku berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Buku dengan judul '" & judulHapus & "' tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Masukkan judul buku yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class