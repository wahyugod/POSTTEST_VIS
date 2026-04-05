Public Class ValidationModule
    Public Shared Function ValidateSebelumCetak(nama As String,
                                               idAnggota As String,
                                               umur As String,
                                               hobi As String,
                                               noTelp As String,
                                               email As String,
                                               alamat As String) As String
        If String.IsNullOrWhiteSpace(nama) Then
            Return "Nama belum diisi."
        End If

        If String.IsNullOrWhiteSpace(idAnggota) Then
            Return "ID belum diisi."
        End If

        If String.IsNullOrWhiteSpace(umur) Then
            Return "Umur belum diisi."
        End If

        If String.IsNullOrWhiteSpace(hobi) Then
            Return "Hobi belum diisi."
        End If

        Dim telpBersih = noTelp.Replace("-", "").Trim()
        If String.IsNullOrWhiteSpace(telpBersih) Then
            Return "Nomor telepon belum diisi."
        End If

        If String.IsNullOrWhiteSpace(email) Then
            Return "Email belum diisi."
        End If

        If String.IsNullOrWhiteSpace(alamat) Then
            Return "Alamat belum diisi."
        End If

        Return String.Empty
    End Function
End Class
