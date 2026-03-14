Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNama.Text = DataModule.Nama
        lblUmur.Text = DataModule.Umur
        lblNoTelp.Text = DataModule.NoTelp
        lblAlamat.Text = DataModule.Alamat
        lblJK.Text = DataModule.JK
        lblTglLahir.Text = DataModule.Tglahir
        lblHobi.Text = DataModule.Hobi

        If Not String.IsNullOrEmpty(DataModule.Foto) Then
            picProfilHasil.Image = Image.FromFile(DataModule.Foto)
        End If
    End Sub

    Private Sub picProfilHasil_Click(sender As Object, e As EventArgs) Handles picProfilHasil.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub lblJudulKartu_Click(sender As Object, e As EventArgs) Handles lblJudulKartu.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class