Imports MySqlConnector

Module DataModule
    Public Function LoginUser(username As String, password As String) As Boolean
        Dim isValid As Boolean = False
        Using conn = GetConnection()
            Dim query As String = "SELECT COUNT(*) FROM users WHERE username=@user AND password=@pass"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@user", username)
                cmd.Parameters.AddWithValue("@pass", password)
                conn.Open()
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If count > 0 Then isValid = True
            End Using
        End Using
        Return isValid
    End Function

    Public Function GetLaptops() As DataTable
        Dim dt As New DataTable()
        Using conn = GetConnection()
            Dim query As String = "SELECT id AS ID, merk AS Merk, nama AS Nama, harga AS Harga, stok AS Stok FROM laptops"
            Using cmd As New MySqlCommand(query, conn)
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Sub InsertLaptop(merk As String, nama As String, harga As Decimal, stok As Integer)
        Using conn = GetConnection()
            Dim query As String = "INSERT INTO laptops (merk, nama, harga, stok) VALUES (@merk, @nama, @harga, @stok)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@merk", merk)
                cmd.Parameters.AddWithValue("@nama", nama)
                cmd.Parameters.AddWithValue("@harga", harga)
                cmd.Parameters.AddWithValue("@stok", stok)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub UpdateLaptop(id As Integer, merk As String, nama As String, harga As Decimal, stok As Integer)
        Using conn = GetConnection()
            Dim query As String = "UPDATE laptops SET merk=@merk, nama=@nama, harga=@harga, stok=@stok WHERE id=@id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@merk", merk)
                cmd.Parameters.AddWithValue("@nama", nama)
                cmd.Parameters.AddWithValue("@harga", harga)
                cmd.Parameters.AddWithValue("@stok", stok)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub DeleteLaptop(id As Integer)
        Using conn = GetConnection()
            Dim query As String = "DELETE FROM laptops WHERE id=@id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub GetDashboardStats(ByRef totalLaptop As Integer, ByRef merkTerbanyak As String, ByRef stokTertinggi As String)
        Using conn = GetConnection()
            conn.Open()
            Using cmd1 As New MySqlCommand("SELECT IFNULL(SUM(stok), 0) FROM laptops", conn)
                totalLaptop = Convert.ToInt32(cmd1.ExecuteScalar())
            End Using
            Using cmd2 As New MySqlCommand("SELECT merk FROM laptops GROUP BY merk ORDER BY COUNT(*) DESC LIMIT 1", conn)
                Dim result = cmd2.ExecuteScalar()
                merkTerbanyak = If(result IsNot Nothing, result.ToString(), "-")
            End Using
            Using cmd3 As New MySqlCommand("SELECT nama FROM laptops ORDER BY stok DESC LIMIT 1", conn)
                Dim result = cmd3.ExecuteScalar()
                stokTertinggi = If(result IsNot Nothing, result.ToString(), "-")
            End Using
        End Using
    End Sub
End Module