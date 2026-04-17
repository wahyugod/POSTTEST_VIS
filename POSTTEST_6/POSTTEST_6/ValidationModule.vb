Imports MySqlConnector

Module ValidationModule
    Public Function IsEmpty(ParamArray inputs As String()) As Boolean
        For Each item In inputs
            If String.IsNullOrWhiteSpace(item) Then Return True
        Next
        Return False
    End Function

    Public Function IsValidNumber(value As String) As Boolean
        Dim result As Decimal
        Return Decimal.TryParse(value, result) AndAlso result >= 0
    End Function

    Public Function IsduplicateLaptop(kodeMerk As String, nama As String) As Boolean
        Dim isDuplicate As Boolean = False
        Using conn = GetConnection()
            Dim query As String = "SELECT COUNT(*) FROM laptops WHERE kodeMerk=@kodeMerk AND nama=@nama"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@kodeMerk", kodeMerk)
                cmd.Parameters.AddWithValue("@nama", nama)
                conn.Open()
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If count > 0 Then isDuplicate = True
            End Using
        End Using
        Return isDuplicate
    End Function
End Module