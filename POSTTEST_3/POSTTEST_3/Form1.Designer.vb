<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblJudul = New Label()
        lblNama = New Label()
        lblUmur = New Label()
        lblNoTelp = New Label()
        lblAlamat = New Label()
        lblTglLahir = New Label()
        lblJK = New Label()
        lblHobi = New Label()
        pnlNama = New Panel()
        txtNama = New TextBox()
        pnlUmur = New Panel()
        txtUmur = New TextBox()
        pnlNoTelp = New Panel()
        txtNoTelp = New TextBox()
        pnlAlamat = New Panel()
        txtAlamat = New TextBox()
        pnlTglLahir = New Panel()
        dtpLahir = New DateTimePicker()
        rbLaki = New RadioButton()
        rbPerempuan = New RadioButton()
        cbHobi1 = New CheckBox()
        cbHobi2 = New CheckBox()
        cbHobi3 = New CheckBox()
        cbHobi4 = New CheckBox()
        cbHobi5 = New CheckBox()
        cbHobi6 = New CheckBox()
        cbHobi7 = New CheckBox()
        cbHobi8 = New CheckBox()
        cbHobi9 = New CheckBox()
        cbHobi10 = New CheckBox()
        cbHobi11 = New CheckBox()
        cbHobi12 = New CheckBox()
        picProfil = New PictureBox()
        btnBrowse = New Button()
        btnCetak = New Button()
        lineSeparator = New Panel()
        pnlNama.SuspendLayout()
        pnlUmur.SuspendLayout()
        pnlNoTelp.SuspendLayout()
        pnlAlamat.SuspendLayout()
        pnlTglLahir.SuspendLayout()
        CType(picProfil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("JetBrains Mono", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0)
        lblJudul.ForeColor = Color.White
        lblJudul.Location = New Point(102, 19)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(638, 49)
        lblJudul.TabIndex = 0
        lblJudul.Text = "PEMUDA PANCASILA MEMBER CARD"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Segoe UI", 11.25F)
        lblNama.ForeColor = Color.White
        lblNama.Location = New Point(40, 85)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(109, 20)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama Lengkap"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.Font = New Font("Segoe UI", 11.25F)
        lblUmur.ForeColor = Color.White
        lblUmur.Location = New Point(40, 125)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(45, 20)
        lblUmur.TabIndex = 3
        lblUmur.Text = "Umur"
        ' 
        ' lblNoTelp
        ' 
        lblNoTelp.AutoSize = True
        lblNoTelp.Font = New Font("Segoe UI", 11.25F)
        lblNoTelp.ForeColor = Color.White
        lblNoTelp.Location = New Point(40, 165)
        lblNoTelp.Name = "lblNoTelp"
        lblNoTelp.Size = New Size(89, 20)
        lblNoTelp.TabIndex = 5
        lblNoTelp.Text = "No. Telepon"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Font = New Font("Segoe UI", 11.25F)
        lblAlamat.ForeColor = Color.White
        lblAlamat.Location = New Point(40, 205)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(57, 20)
        lblAlamat.TabIndex = 7
        lblAlamat.Text = "Alamat"
        ' 
        ' lblTglLahir
        ' 
        lblTglLahir.AutoSize = True
        lblTglLahir.Font = New Font("Segoe UI", 11.25F)
        lblTglLahir.ForeColor = Color.White
        lblTglLahir.Location = New Point(40, 245)
        lblTglLahir.Name = "lblTglLahir"
        lblTglLahir.Size = New Size(97, 20)
        lblTglLahir.TabIndex = 9
        lblTglLahir.Text = "Tanggal Lahir"
        ' 
        ' lblJK
        ' 
        lblJK.AutoSize = True
        lblJK.Font = New Font("Segoe UI", 11.25F)
        lblJK.ForeColor = Color.White
        lblJK.Location = New Point(40, 290)
        lblJK.Name = "lblJK"
        lblJK.Size = New Size(98, 20)
        lblJK.TabIndex = 11
        lblJK.Text = "Jenis Kelamin"
        ' 
        ' lblHobi
        ' 
        lblHobi.AutoSize = True
        lblHobi.Font = New Font("Segoe UI", 11.25F)
        lblHobi.ForeColor = Color.White
        lblHobi.Location = New Point(40, 330)
        lblHobi.Name = "lblHobi"
        lblHobi.Size = New Size(42, 20)
        lblHobi.TabIndex = 14
        lblHobi.Text = "Hobi"
        ' 
        ' pnlNama
        ' 
        pnlNama.BackColor = Color.FromArgb(255, 102, 0)
        pnlNama.Controls.Add(txtNama)
        pnlNama.Location = New Point(180, 80)
        pnlNama.Name = "pnlNama"
        pnlNama.Padding = New Padding(1)
        pnlNama.Size = New Size(380, 32)
        pnlNama.TabIndex = 2
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = Color.FromArgb(40, 40, 40)
        txtNama.BorderStyle = BorderStyle.None
        txtNama.Dock = DockStyle.Fill
        txtNama.Font = New Font("Segoe UI", 14.25F)
        txtNama.ForeColor = Color.White
        txtNama.Location = New Point(1, 1)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(378, 26)
        txtNama.TabIndex = 0
        ' 
        ' pnlUmur
        ' 
        pnlUmur.BackColor = Color.FromArgb(255, 102, 0)
        pnlUmur.Controls.Add(txtUmur)
        pnlUmur.Location = New Point(180, 120)
        pnlUmur.Name = "pnlUmur"
        pnlUmur.Padding = New Padding(1)
        pnlUmur.Size = New Size(380, 32)
        pnlUmur.TabIndex = 4
        ' 
        ' txtUmur
        ' 
        txtUmur.BackColor = Color.FromArgb(40, 40, 40)
        txtUmur.BorderStyle = BorderStyle.None
        txtUmur.Dock = DockStyle.Fill
        txtUmur.Font = New Font("Segoe UI", 14.25F)
        txtUmur.ForeColor = Color.White
        txtUmur.Location = New Point(1, 1)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(378, 26)
        txtUmur.TabIndex = 0
        ' 
        ' pnlNoTelp
        ' 
        pnlNoTelp.BackColor = Color.FromArgb(255, 102, 0)
        pnlNoTelp.Controls.Add(txtNoTelp)
        pnlNoTelp.Location = New Point(180, 160)
        pnlNoTelp.Name = "pnlNoTelp"
        pnlNoTelp.Padding = New Padding(1)
        pnlNoTelp.Size = New Size(380, 32)
        pnlNoTelp.TabIndex = 6
        ' 
        ' txtNoTelp
        ' 
        txtNoTelp.BackColor = Color.FromArgb(40, 40, 40)
        txtNoTelp.BorderStyle = BorderStyle.None
        txtNoTelp.Dock = DockStyle.Fill
        txtNoTelp.Font = New Font("Segoe UI", 14.25F)
        txtNoTelp.ForeColor = Color.White
        txtNoTelp.Location = New Point(1, 1)
        txtNoTelp.Name = "txtNoTelp"
        txtNoTelp.Size = New Size(378, 26)
        txtNoTelp.TabIndex = 0
        ' 
        ' pnlAlamat
        ' 
        pnlAlamat.BackColor = Color.FromArgb(255, 102, 0)
        pnlAlamat.Controls.Add(txtAlamat)
        pnlAlamat.Location = New Point(180, 200)
        pnlAlamat.Name = "pnlAlamat"
        pnlAlamat.Padding = New Padding(1)
        pnlAlamat.Size = New Size(380, 32)
        pnlAlamat.TabIndex = 8
        ' 
        ' txtAlamat
        ' 
        txtAlamat.BackColor = Color.FromArgb(40, 40, 40)
        txtAlamat.BorderStyle = BorderStyle.None
        txtAlamat.Dock = DockStyle.Fill
        txtAlamat.Font = New Font("Segoe UI", 14.25F)
        txtAlamat.ForeColor = Color.White
        txtAlamat.Location = New Point(1, 1)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(378, 26)
        txtAlamat.TabIndex = 0
        ' 
        ' pnlTglLahir
        ' 
        pnlTglLahir.BackColor = Color.FromArgb(255, 102, 0)
        pnlTglLahir.Controls.Add(dtpLahir)
        pnlTglLahir.Location = New Point(180, 240)
        pnlTglLahir.Name = "pnlTglLahir"
        pnlTglLahir.Padding = New Padding(1)
        pnlTglLahir.Size = New Size(380, 32)
        pnlTglLahir.TabIndex = 10
        ' 
        ' dtpLahir
        ' 
        dtpLahir.CalendarMonthBackground = Color.FromArgb(40, 40, 40)
        dtpLahir.Dock = DockStyle.Fill
        dtpLahir.Font = New Font("Segoe UI", 11F)
        dtpLahir.Location = New Point(1, 1)
        dtpLahir.Name = "dtpLahir"
        dtpLahir.Size = New Size(378, 27)
        dtpLahir.TabIndex = 0
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.FlatStyle = FlatStyle.Flat
        rbLaki.Font = New Font("Segoe UI", 11.25F)
        rbLaki.ForeColor = Color.White
        rbLaki.Location = New Point(180, 288)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(84, 24)
        rbLaki.TabIndex = 12
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.FlatStyle = FlatStyle.Flat
        rbPerempuan.Font = New Font("Segoe UI", 11.25F)
        rbPerempuan.ForeColor = Color.White
        rbPerempuan.Location = New Point(315, 288)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(100, 24)
        rbPerempuan.TabIndex = 13
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' cbHobi1
        ' 
        cbHobi1.AutoSize = True
        cbHobi1.FlatStyle = FlatStyle.Flat
        cbHobi1.Font = New Font("Segoe UI", 10F)
        cbHobi1.ForeColor = Color.White
        cbHobi1.Location = New Point(180, 330)
        cbHobi1.Name = "cbHobi1"
        cbHobi1.Size = New Size(81, 23)
        cbHobi1.TabIndex = 15
        cbHobi1.Text = "Olahraga"
        ' 
        ' cbHobi2
        ' 
        cbHobi2.AutoSize = True
        cbHobi2.FlatStyle = FlatStyle.Flat
        cbHobi2.Font = New Font("Segoe UI", 10F)
        cbHobi2.ForeColor = Color.White
        cbHobi2.Location = New Point(180, 360)
        cbHobi2.Name = "cbHobi2"
        cbHobi2.Size = New Size(85, 23)
        cbHobi2.TabIndex = 16
        cbHobi2.Text = "Membaca"
        ' 
        ' cbHobi3
        ' 
        cbHobi3.AutoSize = True
        cbHobi3.FlatStyle = FlatStyle.Flat
        cbHobi3.Font = New Font("Segoe UI", 10F)
        cbHobi3.ForeColor = Color.White
        cbHobi3.Location = New Point(180, 390)
        cbHobi3.Name = "cbHobi3"
        cbHobi3.Size = New Size(73, 23)
        cbHobi3.TabIndex = 17
        cbHobi3.Text = "Gaming"
        ' 
        ' cbHobi4
        ' 
        cbHobi4.AutoSize = True
        cbHobi4.FlatStyle = FlatStyle.Flat
        cbHobi4.Font = New Font("Segoe UI", 10F)
        cbHobi4.ForeColor = Color.White
        cbHobi4.Location = New Point(180, 420)
        cbHobi4.Name = "cbHobi4"
        cbHobi4.Size = New Size(73, 23)
        cbHobi4.TabIndex = 18
        cbHobi4.Text = "Balapan"
        ' 
        ' cbHobi5
        ' 
        cbHobi5.AutoSize = True
        cbHobi5.FlatStyle = FlatStyle.Flat
        cbHobi5.Font = New Font("Segoe UI", 10F)
        cbHobi5.ForeColor = Color.White
        cbHobi5.Location = New Point(315, 330)
        cbHobi5.Name = "cbHobi5"
        cbHobi5.Size = New Size(79, 23)
        cbHobi5.TabIndex = 19
        cbHobi5.Text = "Traveling"
        ' 
        ' cbHobi6
        ' 
        cbHobi6.AutoSize = True
        cbHobi6.FlatStyle = FlatStyle.Flat
        cbHobi6.Font = New Font("Segoe UI", 10F)
        cbHobi6.ForeColor = Color.White
        cbHobi6.Location = New Point(315, 360)
        cbHobi6.Name = "cbHobi6"
        cbHobi6.Size = New Size(67, 23)
        cbHobi6.TabIndex = 20
        cbHobi6.Text = "Kuliner"
        ' 
        ' cbHobi7
        ' 
        cbHobi7.AutoSize = True
        cbHobi7.FlatStyle = FlatStyle.Flat
        cbHobi7.Font = New Font("Segoe UI", 10F)
        cbHobi7.ForeColor = Color.White
        cbHobi7.Location = New Point(315, 390)
        cbHobi7.Name = "cbHobi7"
        cbHobi7.Size = New Size(62, 23)
        cbHobi7.TabIndex = 21
        cbHobi7.Text = "Musik"
        ' 
        ' cbHobi8
        ' 
        cbHobi8.AutoSize = True
        cbHobi8.FlatStyle = FlatStyle.Flat
        cbHobi8.Font = New Font("Segoe UI", 10F)
        cbHobi8.ForeColor = Color.White
        cbHobi8.Location = New Point(315, 420)
        cbHobi8.Name = "cbHobi8"
        cbHobi8.Size = New Size(70, 23)
        cbHobi8.TabIndex = 22
        cbHobi8.Text = "Trading"
        ' 
        ' cbHobi9
        ' 
        cbHobi9.AutoSize = True
        cbHobi9.FlatStyle = FlatStyle.Flat
        cbHobi9.Font = New Font("Segoe UI", 10F)
        cbHobi9.ForeColor = Color.White
        cbHobi9.Location = New Point(445, 330)
        cbHobi9.Name = "cbHobi9"
        cbHobi9.Size = New Size(83, 23)
        cbHobi9.TabIndex = 23
        cbHobi9.Text = "Berenang"
        ' 
        ' cbHobi10
        ' 
        cbHobi10.AutoSize = True
        cbHobi10.FlatStyle = FlatStyle.Flat
        cbHobi10.Font = New Font("Segoe UI", 10F)
        cbHobi10.ForeColor = Color.White
        cbHobi10.Location = New Point(445, 360)
        cbHobi10.Name = "cbHobi10"
        cbHobi10.Size = New Size(81, 23)
        cbHobi10.TabIndex = 24
        cbHobi10.Text = "Otomotif"
        ' 
        ' cbHobi11
        ' 
        cbHobi11.AutoSize = True
        cbHobi11.FlatStyle = FlatStyle.Flat
        cbHobi11.Font = New Font("Segoe UI", 10F)
        cbHobi11.ForeColor = Color.White
        cbHobi11.Location = New Point(445, 390)
        cbHobi11.Name = "cbHobi11"
        cbHobi11.Size = New Size(80, 23)
        cbHobi11.TabIndex = 25
        cbHobi11.Text = "Fotografi"
        ' 
        ' cbHobi12
        ' 
        cbHobi12.AutoSize = True
        cbHobi12.FlatStyle = FlatStyle.Flat
        cbHobi12.Font = New Font("Segoe UI", 10F)
        cbHobi12.ForeColor = Color.White
        cbHobi12.Location = New Point(445, 420)
        cbHobi12.Name = "cbHobi12"
        cbHobi12.Size = New Size(73, 23)
        cbHobi12.TabIndex = 26
        cbHobi12.Text = "Menulis"
        ' 
        ' picProfil
        ' 
        picProfil.BackColor = Color.FromArgb(10, 10, 10)
        picProfil.Location = New Point(620, 80)
        picProfil.Name = "picProfil"
        picProfil.Size = New Size(180, 180)
        picProfil.SizeMode = PictureBoxSizeMode.Zoom
        picProfil.TabIndex = 28
        picProfil.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.FromArgb(255, 102, 0)
        btnBrowse.FlatAppearance.BorderSize = 0
        btnBrowse.FlatStyle = FlatStyle.Flat
        btnBrowse.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        btnBrowse.ForeColor = Color.Black
        btnBrowse.Location = New Point(620, 280)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(180, 40)
        btnBrowse.TabIndex = 29
        btnBrowse.Text = "Upload Foto"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.FromArgb(255, 102, 0)
        btnCetak.FlatAppearance.BorderSize = 0
        btnCetak.FlatStyle = FlatStyle.Flat
        btnCetak.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        btnCetak.ForeColor = Color.Black
        btnCetak.Location = New Point(620, 420)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(180, 40)
        btnCetak.TabIndex = 30
        btnCetak.Text = "CETAK KARTU"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' lineSeparator
        ' 
        lineSeparator.BackColor = Color.FromArgb(64, 64, 64)
        lineSeparator.Location = New Point(590, 80)
        lineSeparator.Name = "lineSeparator"
        lineSeparator.Size = New Size(2, 380)
        lineSeparator.TabIndex = 27
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(20, 20, 20)
        ClientSize = New Size(840, 500)
        Controls.Add(btnCetak)
        Controls.Add(btnBrowse)
        Controls.Add(picProfil)
        Controls.Add(lineSeparator)
        Controls.Add(cbHobi12)
        Controls.Add(cbHobi11)
        Controls.Add(cbHobi10)
        Controls.Add(cbHobi9)
        Controls.Add(cbHobi8)
        Controls.Add(cbHobi7)
        Controls.Add(cbHobi6)
        Controls.Add(cbHobi5)
        Controls.Add(cbHobi4)
        Controls.Add(cbHobi3)
        Controls.Add(cbHobi2)
        Controls.Add(cbHobi1)
        Controls.Add(rbPerempuan)
        Controls.Add(rbLaki)
        Controls.Add(lblHobi)
        Controls.Add(lblJK)
        Controls.Add(pnlTglLahir)
        Controls.Add(lblTglLahir)
        Controls.Add(pnlAlamat)
        Controls.Add(lblAlamat)
        Controls.Add(pnlNoTelp)
        Controls.Add(lblNoTelp)
        Controls.Add(pnlUmur)
        Controls.Add(lblUmur)
        Controls.Add(pnlNama)
        Controls.Add(lblNama)
        Controls.Add(lblJudul)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PEMUDA PANCASILA REGISTRATION FORM"
        pnlNama.ResumeLayout(False)
        pnlNama.PerformLayout()
        pnlUmur.ResumeLayout(False)
        pnlUmur.PerformLayout()
        pnlNoTelp.ResumeLayout(False)
        pnlNoTelp.PerformLayout()
        pnlAlamat.ResumeLayout(False)
        pnlAlamat.PerformLayout()
        pnlTglLahir.ResumeLayout(False)
        CType(picProfil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents pnlNama As Panel
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblUmur As Label
    Friend WithEvents pnlUmur As Panel
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents lblNoTelp As Label
    Friend WithEvents pnlNoTelp As Panel
    Friend WithEvents txtNoTelp As TextBox
    Friend WithEvents lblAlamat As Label
    Friend WithEvents pnlAlamat As Panel
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents lblTglLahir As Label
    Friend WithEvents pnlTglLahir As Panel
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents lblJK As Label
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents lblHobi As Label
    Friend WithEvents cbHobi1 As CheckBox
    Friend WithEvents cbHobi2 As CheckBox
    Friend WithEvents cbHobi3 As CheckBox
    Friend WithEvents cbHobi4 As CheckBox
    Friend WithEvents cbHobi5 As CheckBox
    Friend WithEvents cbHobi6 As CheckBox
    Friend WithEvents cbHobi7 As CheckBox
    Friend WithEvents cbHobi8 As CheckBox
    Friend WithEvents cbHobi9 As CheckBox
    Friend WithEvents cbHobi10 As CheckBox
    Friend WithEvents cbHobi11 As CheckBox
    Friend WithEvents cbHobi12 As CheckBox
    Friend WithEvents picProfil As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnCetak As Button
    Friend WithEvents lineSeparator As Panel
End Class