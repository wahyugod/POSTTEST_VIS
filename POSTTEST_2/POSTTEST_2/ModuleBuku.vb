Module ModuleBuku

    Public daftarBuku(99) As String
    Public jumlahBuku As Integer = 2

    Sub New()
        daftarBuku(0) = "Harry Potter (Fantasi)"
        daftarBuku(1) = "Sherlock Holmes (Misteri)"
    End Sub

    Public Function CariIndeksBuku(ByVal judulCari As String) As Integer
        For i As Integer = 0 To jumlahBuku - 1
            If daftarBuku(i) IsNot Nothing AndAlso daftarBuku(i).StartsWith(judulCari & " (", StringComparison.OrdinalIgnoreCase) Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Sub TambahBukuArray(ByVal judul As String, ByVal genre As String)
        If jumlahBuku < 100 Then
            Dim formatBuku As String = judul & " (" & genre & ")"
            daftarBuku(jumlahBuku) = formatBuku
            jumlahBuku += 1
        Else
            MessageBox.Show("Kapasitas daftar buku sudah penuh (Maksimal 100)!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Public Sub HapusBukuArray(ByVal indeks As Integer)
        If indeks >= 0 AndAlso indeks < jumlahBuku Then
            For i As Integer = indeks To jumlahBuku - 2
                daftarBuku(i) = daftarBuku(i + 1)
            Next
            daftarBuku(jumlahBuku - 1) = Nothing
            jumlahBuku -= 1
        End If
    End Sub

End Module