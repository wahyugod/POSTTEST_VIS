# POSTTEST 5 - Aplikasi Manajemen Laptop (VB.NET + MySQL)

README ini menjelaskan cara menyiapkan database dan menjalankan aplikasi POSTTEST 5.

## 1. Prasyarat

- Windows + Visual Studio 2022 (workload .NET desktop development)
- .NET SDK 10.0 (sesuai TargetFramework `net10.0-windows`)
- MySQL Server (contoh: MySQL 8.x)
- Koneksi lokal MySQL aktif di `localhost:3306`

## 2. Setup Database

Jalankan SQL berikut di MySQL (MySQL Workbench / phpMyAdmin / terminal):

```sql
CREATE DATABASE IF NOT EXISTS dblaptop;
USE dblaptop;

CREATE TABLE users (
    id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) NOT NULL,
    password VARCHAR(255) NOT NULL
);

-- Akun default untuk login
INSERT INTO users (username, password) VALUES ('admin', 'admin123');

CREATE TABLE laptops (
    id INT AUTO_INCREMENT PRIMARY KEY,
    merk VARCHAR(50) NOT NULL,
    nama VARCHAR(100) NOT NULL,
    harga DECIMAL(15,2) NOT NULL,
    stok INT NOT NULL
);

INSERT INTO laptops (merk, nama, harga, stok) VALUES
('Apple', 'MacBook Pro 16"', 3499.00, 42),
('Dell', 'XPS 15 OLED', 2199.00, 12),
('Lenovo', 'ThinkPad X1 Carbon', 1450.00, 3),
('Microsoft', 'Surface Laptop 5', 999.00, 152),
('HP', 'EliteBook 840 G9', 1250.00, 35),
('Asus', 'ROG Zephyrus G14', 1699.00, 8),
('Acer', 'Swift 3', 750.00, 60),
('Lenovo', 'IdeaPad Slim 5', 850.00, 45),
('Apple', 'MacBook Air M2', 1199.00, 25),
('Dell', 'Latitude 7420', 1350.00, 18);
```

## 3. Cek Konfigurasi Koneksi

Di file `POSTTEST_5/ConnectionModule.vb`, connection string default saat ini:

```vb
Public ReadOnly ConnectionString As String = "Server=localhost;Port=3306;Database=dblaptop;UserID=root;Password=;"
```

Jika MySQL kamu memakai password, ubah bagian `Password=` sesuai konfigurasi lokal.

## 4. Cara Menjalankan (Visual Studio)

1. Buka `POSTTEST_5.slnx` atau `POSTTEST_5/POSTTEST_5.vbproj` di Visual Studio.
2. Tunggu proses restore NuGet selesai (MySqlConnector dan Guna.UI2.WinForms).
3. Pastikan project `POSTTEST_5` menjadi Startup Project.
4. Jalankan dengan tombol `Start` atau `F5`.

## 5. Login Awal

- Username: `admin`
- Password: `admin123`

Setelah login berhasil, aplikasi menampilkan dashboard dan menu CRUD data laptop.

## 6. Menjalankan via CLI (opsional)

Di folder `POSTTEST_5/POSTTEST_5`, jalankan:

```bash
dotnet restore
dotnet run
```

## 7. Troubleshooting Singkat

- Gagal koneksi database: cek service MySQL aktif dan port `3306` benar.
- Login selalu gagal: pastikan tabel `users` berisi data `admin/admin123`.
- Error akses database: cek `UserID` dan `Password` pada connection string.
