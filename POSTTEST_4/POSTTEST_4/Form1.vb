Imports System.IO

Public Class Form1

    Private ReadOnly _defaultButtonBounds As New Dictionary(Of Button, Rectangle)

    Private Sub SetButtonHoverScale(btn As Button, scale As Single)
        If Not _defaultButtonBounds.ContainsKey(btn) Then
            _defaultButtonBounds(btn) = btn.Bounds
        End If

        Dim baseRect = _defaultButtonBounds(btn)

        If scale <= 1.0F Then
            btn.Bounds = baseRect
            Return
        End If

        Dim newWidth As Integer = CInt(baseRect.Width * scale)
        Dim newHeight As Integer = CInt(baseRect.Height * scale)
        Dim deltaX As Integer = (newWidth - baseRect.Width) \ 2
        Dim deltaY As Integer = (newHeight - baseRect.Height) \ 2

        btn.SetBounds(baseRect.X - deltaX, baseRect.Y - deltaY, newWidth, newHeight)
    End Sub

    ' Efek Hover Tombol Manual
    ' Tombol CETAK (Hijau)
    Private Sub btnCetak_MouseEnter(sender As Object, e As EventArgs) Handles btnCetak.MouseEnter
        ' Gunakan warna yang sangat gelap/pekat saat di-hover
        btnCetak.BackColor = Color.FromArgb(0, 64, 0) ' Hijau sangat gelap
        btnCetak.ForeColor = Color.Yellow ' Teks ganti kuning agar kontras sekali
        SetButtonHoverScale(btnCetak, 1.1F) ' Perbesar sedikit lagi skalanya
    End Sub

    Private Sub btnCetak_MouseLeave(sender As Object, e As EventArgs) Handles btnCetak.MouseLeave
        btnCetak.BackColor = Color.MediumSeaGreen ' Kembali ke warna asal yang terang
        btnCetak.ForeColor = Color.White
        SetButtonHoverScale(btnCetak, 1.0F)
    End Sub

    ' Tombol BROWSE (Abu-abu)
    Private Sub btnBrowse_MouseEnter(sender As Object, e As EventArgs) Handles btnBrowse.MouseEnter
        btnBrowse.BackColor = Color.Black ' Dari abu-abu langsung ke hitam pekat
        btnBrowse.ForeColor = Color.White
        SetButtonHoverScale(btnBrowse, 1.1F)
    End Sub

    Private Sub btnBrowse_MouseLeave(sender As Object, e As EventArgs) Handles btnBrowse.MouseLeave
        btnBrowse.BackColor = Color.Gray
        SetButtonHoverScale(btnBrowse, 1.0F)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup awal ComboBox
        cmbDivisi.Items.AddRange(New String() {"Divisi IT", "Divisi Olahraga", "Divisi Kesenian", "Divisi Sosial", "Humas"})
        cmbDivisi.SelectedIndex = 0
    End Sub

    ' Tombol Browse Foto
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        ofd.Title = "Pilih Foto Profil"

        If ofd.ShowDialog() = DialogResult.OK Then
            picFoto.Image = Image.FromFile(ofd.FileName)
            DataModule.FotoProfil = picFoto.Image
        End If
    End Sub

    ' Tombol Simpan & Cetak Kartu
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        SimpanKeModule()

        Dim umur As String = DateDiff(DateInterval.Year, dtpTanggalLahir.Value, Now).ToString()
        Dim pesanValidasi = ValidationModule.ValidateSebelumCetak(
            txtNama.Text,
            txtID.Text,
            umur,
            DataModule.Hobi,
            mtbTelepon.Text,
            txtEmail.Text,
            txtAlamat.Text)

        If Not String.IsNullOrEmpty(pesanValidasi) Then
            MessageBox.Show(pesanValidasi, "Data Belum Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Konfirmasi sebelum cetak
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin data sudah benar dan ingin mencetak kartu?", "Konfirmasi Cetak", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim f2 As New Form2()
            f2.ShowDialog()
        End If
    End Sub

    ' Menyimpan data dari inputan ke DataModule
    Private Sub SimpanKeModule()
        DataModule.Nama = txtNama.Text
        DataModule.IDAnggota = txtID.Text
        DataModule.TanggalLahir = dtpTanggalLahir.Value.ToString("dd MMMM yyyy")
        DataModule.JenisKelamin = If(rbLaki.Checked, "Laki-laki", "Perempuan")
        DataModule.Umur = txtUmur.Text
        DataModule.Divisi = cmbDivisi.Text
        DataModule.NoTelp = mtbTelepon.Text
        DataModule.Email = txtEmail.Text
        DataModule.Alamat = txtAlamat.Text

        ' Menggabungkan Hobi (Minimal 8 pilihan di desainer)
        Dim listHobi As New List(Of String)
        If chkMembaca.Checked Then listHobi.Add("Membaca")
        If chkMenulis.Checked Then listHobi.Add("Menulis")
        If chkOlahraga.Checked Then listHobi.Add("Olahraga")
        If chkMusik.Checked Then listHobi.Add("Musik")
        If chkCoding.Checked Then listHobi.Add("Coding")
        If chkDesain.Checked Then listHobi.Add("Desain")
        If chkGame.Checked Then listHobi.Add("Gaming")
        If chkFotografi.Checked Then listHobi.Add("Fotografi")

        DataModule.Hobi = String.Join(", ", listHobi)
    End Sub

    ' --- MENU STRIP LOGIC ---

    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage1 ' Fokus ke tab pertama
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        Dim f2 As New Form2()
        f2.Show()
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        SimpanKeModule()
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "Text File|*.txt|CSV File|*.csv"
        sfd.Title = "Simpan Data Divisi"
        sfd.FileName = "Data_" & DataModule.Nama & ".txt"

        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                Dim content As String =
                    $"ID Anggota: {DataModule.IDAnggota}{vbCrLf}" &
                    $"Nama: {DataModule.Nama}{vbCrLf}" &
                    $"Tanggal Lahir: {DataModule.TanggalLahir}{vbCrLf}" &
                    $"Jenis Kelamin: {DataModule.JenisKelamin}{vbCrLf}" &
                    $"Divisi: {DataModule.Divisi}{vbCrLf}" &
                    $"Umur: {DataModule.Umur}{vbCrLf}" &
                    $"No. Telp: {DataModule.NoTelp}{vbCrLf}" &
                    $"Email: {DataModule.Email}{vbCrLf}" &
                    $"Alamat: {DataModule.Alamat}{vbCrLf}" &
                    $"Hobi: {DataModule.Hobi}"

                File.WriteAllText(sfd.FileName, content)
                MessageBox.Show("Data berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Gagal menyimpan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Text File|*.txt|CSV File|*.csv"

        If ofd.ShowDialog() = DialogResult.OK Then
            Try
                Dim lines = File.ReadAllLines(ofd.FileName)
                Dim data As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)

                For Each line In lines
                    Dim idx As Integer = line.IndexOf(":"c)
                    If idx > 0 Then
                        Dim key = line.Substring(0, idx).Trim()
                        Dim value = line.Substring(idx + 1).Trim()
                        data(key) = value
                    End If
                Next

                DataModule.IDAnggota = If(data.ContainsKey("ID Anggota"), data("ID Anggota"), "-")
                DataModule.Nama = If(data.ContainsKey("Nama"), data("Nama"), "-")
                DataModule.TanggalLahir = If(data.ContainsKey("Tanggal Lahir"), data("Tanggal Lahir"), "-")
                DataModule.JenisKelamin = If(data.ContainsKey("Jenis Kelamin"), data("Jenis Kelamin"), "-")
                DataModule.Divisi = If(data.ContainsKey("Divisi"), data("Divisi"), "-")
                DataModule.Umur = If(data.ContainsKey("Umur"), data("Umur"), "-")
                DataModule.NoTelp = If(data.ContainsKey("No. Telp"), data("No. Telp"), "-")
                DataModule.Email = If(data.ContainsKey("Email"), data("Email"), "-")
                DataModule.Alamat = If(data.ContainsKey("Alamat"), data("Alamat"), "-")
                DataModule.Hobi = If(data.ContainsKey("Hobi"), data("Hobi"), "-")

                txtID.Text = DataModule.IDAnggota
                txtNama.Text = DataModule.Nama

                Dim tgl As DateTime
                If DateTime.TryParse(DataModule.TanggalLahir, tgl) Then
                    dtpTanggalLahir.Value = tgl
                End If

                rbLaki.Checked = String.Equals(DataModule.JenisKelamin, "Laki-laki", StringComparison.OrdinalIgnoreCase)
                rbPerempuan.Checked = String.Equals(DataModule.JenisKelamin, "Perempuan", StringComparison.OrdinalIgnoreCase)

                If Not String.IsNullOrWhiteSpace(DataModule.Divisi) AndAlso DataModule.Divisi <> "-" Then
                    If Not cmbDivisi.Items.Contains(DataModule.Divisi) Then
                        cmbDivisi.Items.Add(DataModule.Divisi)
                    End If
                    cmbDivisi.Text = DataModule.Divisi
                End If

                txtUmur.Text = DataModule.Umur
                mtbTelepon.Text = DataModule.NoTelp
                txtEmail.Text = DataModule.Email
                txtAlamat.Text = DataModule.Alamat

                chkMembaca.Checked = False
                chkMenulis.Checked = False
                chkOlahraga.Checked = False
                chkMusik.Checked = False
                chkCoding.Checked = False
                chkDesain.Checked = False
                chkGame.Checked = False
                chkFotografi.Checked = False

                For Each Hobi In DataModule.Hobi.Split(New String() {", "}, StringSplitOptions.RemoveEmptyEntries)
                    Select Case Hobi.Trim().ToLower()
                        Case "membaca" : chkMembaca.Checked = True
                        Case "menulis" : chkMenulis.Checked = True
                        Case "olahraga" : chkOlahraga.Checked = True
                        Case "musik" : chkMusik.Checked = True
                        Case "coding" : chkCoding.Checked = True
                        Case "desain" : chkDesain.Checked = True
                        Case "gaming" : chkGame.Checked = True
                        Case "fotografi" : chkFotografi.Checked = True
                    End Select
                Next

                TabControl1.SelectedTab = TabPage1
                MessageBox.Show("Data berhasil dibuka dan ditampilkan ke form.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Gagal membuka data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        Dim f2 As New Form2()
        f2.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub rbLaki_CheckedChanged(sender As Object, e As EventArgs) Handles rbLaki.CheckedChanged

    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Char.IsControl(e.KeyChar) OrElse Char.IsLetter(e.KeyChar) OrElse e.KeyChar = " "c Then
            Return
        End If

        e.Handled = True
    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        If Char.IsControl(e.KeyChar) OrElse Char.IsDigit(e.KeyChar) Then
            Return
        End If
        e.Handled = True
    End Sub
End Class