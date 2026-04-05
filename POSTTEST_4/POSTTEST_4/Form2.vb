Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Memasukkan data dari DataModule ke Label di Form 2
        lblNama.Text = DataModule.Nama
        lblID.Text = DataModule.IDAnggota
        lblDivisi.Text = DataModule.Divisi
        lblJK.Text = DataModule.JenisKelamin
        lblUmur.Text = DataModule.Umur
        lblTglLahir.Text = DataModule.TanggalLahir
        lblNoTelp.Text = DataModule.NoTelp
        lblEmail.Text = DataModule.Email
        lblAlamat.Text = DataModule.Alamat
        lblHobi.Text = DataModule.Hobi

        ' Cek jika foto profil sudah diupload
        If DataModule.FotoProfil IsNot Nothing Then
            picProfilHasil.Image = DataModule.FotoProfil
        End If
    End Sub
End Class