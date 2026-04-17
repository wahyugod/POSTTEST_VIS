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
            Dim query As String = "SELECT l.id AS ID, l.kodeMerk AS KodeMerk, m.namaMerk AS Merk, l.nama AS Nama, l.harga AS Harga, l.stok AS Stok FROM laptops l LEFT JOIN merk m ON l.kodeMerk = m.kodeMerk"
            Using cmd As New MySqlCommand(query, conn)
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Function GetMerkList() As DataTable
        Dim dt As New DataTable()
        Using conn = GetConnection()
            Dim query As String = "SELECT kodeMerk, namaMerk FROM merk ORDER BY namaMerk"
            Using cmd As New MySqlCommand(query, conn)
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Sub InsertLaptop(kodeMerk As String, nama As String, harga As Decimal, stok As Integer)
        Using conn = GetConnection()
            Dim query As String = "INSERT INTO laptops (kodeMerk, nama, harga, stok) VALUES (@kodeMerk, @nama, @harga, @stok)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@kodeMerk", kodeMerk)
                cmd.Parameters.AddWithValue("@nama", nama)
                cmd.Parameters.AddWithValue("@harga", harga)
                cmd.Parameters.AddWithValue("@stok", stok)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub UpdateLaptop(id As Integer, kodeMerk As String, nama As String, harga As Decimal, stok As Integer)
        Using conn = GetConnection()
            Dim query As String = "UPDATE laptops SET kodeMerk=@kodeMerk, nama=@nama, harga=@harga, stok=@stok WHERE id=@id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@kodeMerk", kodeMerk)
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

    Public Function GetMerk() As DataTable
        Dim dt As New DataTable()
        Using conn = GetConnection()
            Dim query As String = "SELECT kodeMerk AS KodeMerk, namaMerk AS NamaMerk FROM merk ORDER BY kodeMerk"
            Using cmd As New MySqlCommand(query, conn)
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Sub InsertMerk(kodeMerk As String, namaMerk As String)
        Using conn = GetConnection()
            Dim query As String = "INSERT INTO merk (kodeMerk, namaMerk) VALUES (@kodeMerk, @namaMerk)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@kodeMerk", kodeMerk)
                cmd.Parameters.AddWithValue("@namaMerk", namaMerk)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub UpdateMerk(kodeMerk As String, namaMerk As String)
        Using conn = GetConnection()
            Dim query As String = "UPDATE merk SET namaMerk=@namaMerk WHERE kodeMerk=@kodeMerk"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@kodeMerk", kodeMerk)
                cmd.Parameters.AddWithValue("@namaMerk", namaMerk)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub DeleteMerk(kodeMerk As String)
        Using conn = GetConnection()
            Dim query As String = "DELETE FROM merk WHERE kodeMerk=@kodeMerk"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@kodeMerk", kodeMerk)
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
            Using cmd2 As New MySqlCommand("SELECT COALESCE(m.namaMerk, '-') FROM laptops l LEFT JOIN merk m ON l.kodeMerk = m.kodeMerk GROUP BY m.namaMerk ORDER BY COUNT(*) DESC LIMIT 1", conn)
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