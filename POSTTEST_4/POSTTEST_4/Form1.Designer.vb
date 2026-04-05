<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    ' Kontrol Utama
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem

    Friend WithEvents lblJudulApp As Label
    Friend WithEvents picLogoApp As PictureBox
    Friend WithEvents TabControl1 As TabControl

    ' Tab 1
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents cmbDivisi As ComboBox

    ' Tab 2
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents mtbTelepon As MaskedTextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtAlamat As TextBox

    ' Tab 3
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents gbHobi As GroupBox
    Friend WithEvents chkMembaca As CheckBox
    Friend WithEvents chkMenulis As CheckBox
    Friend WithEvents chkOlahraga As CheckBox
    Friend WithEvents chkMusik As CheckBox
    Friend WithEvents chkCoding As CheckBox
    Friend WithEvents chkDesain As CheckBox
    Friend WithEvents chkGame As CheckBox
    Friend WithEvents chkFotografi As CheckBox
    Friend WithEvents btnCetak As Button

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        lblJudulApp = New Label()
        picLogoApp = New PictureBox()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtNama = New TextBox()
        txtID = New TextBox()
        dtpTanggalLahir = New DateTimePicker()
        rbLaki = New RadioButton()
        rbPerempuan = New RadioButton()
        cmbDivisi = New ComboBox()
        TabPage2 = New TabPage()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        mtbTelepon = New MaskedTextBox()
        txtEmail = New TextBox()
        txtAlamat = New TextBox()
        TabPage3 = New TabPage()
        picFoto = New PictureBox()
        btnBrowse = New Button()
        gbHobi = New GroupBox()
        chkMembaca = New CheckBox()
        chkMenulis = New CheckBox()
        chkOlahraga = New CheckBox()
        chkMusik = New CheckBox()
        chkCoding = New CheckBox()
        chkDesain = New CheckBox()
        chkGame = New CheckBox()
        chkFotografi = New CheckBox()
        btnCetak = New Button()
        Panel1 = New Panel()
        txtUmur = New TextBox()
        lblUmur = New Label()
        MenuStrip1.SuspendLayout()
        CType(picLogoApp, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        gbHobi.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.OrangeRed
        MenuStrip1.Dock = DockStyle.None
        MenuStrip1.Font = New Font("Futura Md BT", 12.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKartuToolStripMenuItem, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow
        MenuStrip1.Location = New Point(21, 110)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(125, 321)
        MenuStrip1.TabIndex = 0
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Padding = New Padding(0, 20, 0, 20)
        InputDataToolStripMenuItem.Size = New Size(118, 63)
        InputDataToolStripMenuItem.Text = "Input Data"
        InputDataToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Padding = New Padding(0, 20, 0, 20)
        LihatKartuToolStripMenuItem.Size = New Size(118, 63)
        LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        LihatKartuToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Padding = New Padding(0, 20, 0, 20)
        SimpanDataToolStripMenuItem.Size = New Size(118, 63)
        SimpanDataToolStripMenuItem.Text = "Simpan Data"
        SimpanDataToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.Padding = New Padding(0, 20, 0, 20)
        BukaDataToolStripMenuItem.Size = New Size(118, 63)
        BukaDataToolStripMenuItem.Text = "Buka Data"
        BukaDataToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Padding = New Padding(0, 20, 0, 20)
        KeluarToolStripMenuItem.Size = New Size(118, 63)
        KeluarToolStripMenuItem.Text = "Keluar"
        KeluarToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblJudulApp
        ' 
        lblJudulApp.AutoSize = True
        lblJudulApp.Font = New Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudulApp.Location = New Point(202, 39)
        lblJudulApp.Name = "lblJudulApp"
        lblJudulApp.Size = New Size(561, 32)
        lblJudulApp.TabIndex = 2
        lblJudulApp.Text = "Sistem Registrasi Kartu Komunitas"
        ' 
        ' picLogoApp
        ' 
        picLogoApp.BackColor = Color.OrangeRed
        picLogoApp.BackgroundImage = My.Resources.Resources.Logo_Pemuda_Pancasila_PNG_Warna
        picLogoApp.BackgroundImageLayout = ImageLayout.Stretch
        picLogoApp.Location = New Point(51, 25)
        picLogoApp.Name = "picLogoApp"
        picLogoApp.Size = New Size(60, 71)
        picLogoApp.TabIndex = 1
        picLogoApp.TabStop = False
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Font = New Font("JetBrains Mono ExtraBold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(202, 110)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(560, 320)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Coral
        TabPage1.Controls.Add(lblUmur)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(txtNama)
        TabPage1.Controls.Add(txtUmur)
        TabPage1.Controls.Add(txtID)
        TabPage1.Controls.Add(dtpTanggalLahir)
        TabPage1.Controls.Add(rbLaki)
        TabPage1.Controls.Add(rbPerempuan)
        TabPage1.Controls.Add(cmbDivisi)
        TabPage1.Location = New Point(4, 25)
        TabPage1.Name = "TabPage1"
        TabPage1.Size = New Size(552, 291)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Utama"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("JetBrains Mono", 8.999999F, FontStyle.Bold)
        Label5.Location = New Point(300, 40)
        Label5.Name = "Label5"
        Label5.Size = New Size(28, 16)
        Label5.TabIndex = 6
        Label5.Text = "ID:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("JetBrains Mono", 8.999999F, FontStyle.Bold)
        Label4.Location = New Point(300, 119)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 16)
        Label4.TabIndex = 6
        Label4.Text = "Divisi:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("JetBrains Mono", 8.999999F, FontStyle.Bold)
        Label3.Location = New Point(55, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 16)
        Label3.TabIndex = 6
        Label3.Text = "Jenis Kelamin:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("JetBrains Mono", 8.999999F, FontStyle.Bold)
        Label2.Location = New Point(55, 200)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 16)
        Label2.TabIndex = 6
        Label2.Text = "Tanggal Lahir:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("JetBrains Mono", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(55, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 16)
        Label1.TabIndex = 6
        Label1.Text = "Nama:"
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("JetBrains Mono", 8.999999F, FontStyle.Bold)
        txtNama.Location = New Point(55, 58)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Nama Lengkap"
        txtNama.Size = New Size(200, 23)
        txtNama.TabIndex = 0
        ' 
        ' txtID
        ' 
        txtID.Font = New Font("JetBrains Mono", 8.999999F, FontStyle.Bold)
        txtID.Location = New Point(300, 58)
        txtID.Name = "txtID"
        txtID.PlaceholderText = "ID Anggota"
        txtID.Size = New Size(200, 23)
        txtID.TabIndex = 1
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Font = New Font("JetBrains Mono", 8.999999F, FontStyle.Bold)
        dtpTanggalLahir.Location = New Point(55, 218)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(244, 23)
        dtpTanggalLahir.TabIndex = 2
        ' 
        ' rbLaki
        ' 
        rbLaki.Checked = True
        rbLaki.Font = New Font("JetBrains Mono", 8.999999F, FontStyle.Bold)
        rbLaki.Location = New Point(55, 137)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(101, 24)
        rbLaki.TabIndex = 3
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-laki"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.Font = New Font("JetBrains Mono", 8.999999F, FontStyle.Bold)
        rbPerempuan.Location = New Point(162, 137)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(93, 24)
        rbPerempuan.TabIndex = 4
        rbPerempuan.Text = "Perempuan"
        ' 
        ' cmbDivisi
        ' 
        cmbDivisi.DropDownStyle = ComboBoxStyle.DropDownList
        cmbDivisi.Font = New Font("JetBrains Mono", 8.999999F, FontStyle.Bold)
        cmbDivisi.Location = New Point(300, 137)
        cmbDivisi.Name = "cmbDivisi"
        cmbDivisi.Size = New Size(200, 24)
        cmbDivisi.TabIndex = 5
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.Coral
        TabPage2.Controls.Add(Label8)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(mtbTelepon)
        TabPage2.Controls.Add(txtEmail)
        TabPage2.Controls.Add(txtAlamat)
        TabPage2.Location = New Point(4, 25)
        TabPage2.Name = "TabPage2"
        TabPage2.Size = New Size(552, 291)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak & Info"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(55, 122)
        Label8.Name = "Label8"
        Label8.Size = New Size(161, 16)
        Label8.TabIndex = 3
        Label8.Text = "Alamat Tempat Tinggal:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(297, 38)
        Label7.Name = "Label7"
        Label7.Size = New Size(105, 16)
        Label7.TabIndex = 3
        Label7.Text = "Alamat E-Mail:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(55, 38)
        Label6.Name = "Label6"
        Label6.Size = New Size(84, 16)
        Label6.TabIndex = 3
        Label6.Text = "No Telepon:"
        ' 
        ' mtbTelepon
        ' 
        mtbTelepon.Location = New Point(55, 57)
        mtbTelepon.Mask = "0000-0000-0000"
        mtbTelepon.Name = "mtbTelepon"
        mtbTelepon.Size = New Size(200, 23)
        mtbTelepon.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(297, 57)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email"
        txtEmail.Size = New Size(200, 23)
        txtEmail.TabIndex = 1
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(55, 141)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.PlaceholderText = "Alamat"
        txtAlamat.Size = New Size(442, 105)
        txtAlamat.TabIndex = 2
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.Coral
        TabPage3.Controls.Add(picFoto)
        TabPage3.Controls.Add(btnBrowse)
        TabPage3.Controls.Add(gbHobi)
        TabPage3.Controls.Add(btnCetak)
        TabPage3.Location = New Point(4, 25)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(552, 291)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profil & Aktivitas"
        ' 
        ' picFoto
        ' 
        picFoto.BorderStyle = BorderStyle.FixedSingle
        picFoto.Location = New Point(20, 20)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(139, 170)
        picFoto.SizeMode = PictureBoxSizeMode.StretchImage
        picFoto.TabIndex = 0
        picFoto.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.Gray
        btnBrowse.FlatStyle = FlatStyle.Flat
        btnBrowse.ForeColor = Color.White
        btnBrowse.Location = New Point(20, 196)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(139, 41)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse Foto"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' gbHobi
        ' 
        gbHobi.Controls.Add(chkMembaca)
        gbHobi.Controls.Add(chkMenulis)
        gbHobi.Controls.Add(chkOlahraga)
        gbHobi.Controls.Add(chkMusik)
        gbHobi.Controls.Add(chkCoding)
        gbHobi.Controls.Add(chkDesain)
        gbHobi.Controls.Add(chkGame)
        gbHobi.Controls.Add(chkFotografi)
        gbHobi.Location = New Point(188, 20)
        gbHobi.Name = "gbHobi"
        gbHobi.Size = New Size(351, 170)
        gbHobi.TabIndex = 3
        gbHobi.TabStop = False
        gbHobi.Text = "Aktivitas / Hobi"
        ' 
        ' chkMembaca
        ' 
        chkMembaca.Location = New Point(10, 20)
        chkMembaca.Name = "chkMembaca"
        chkMembaca.Size = New Size(104, 24)
        chkMembaca.TabIndex = 0
        chkMembaca.Text = "Membaca"
        ' 
        ' chkMenulis
        ' 
        chkMenulis.Location = New Point(10, 51)
        chkMenulis.Name = "chkMenulis"
        chkMenulis.Size = New Size(104, 24)
        chkMenulis.TabIndex = 1
        chkMenulis.Text = "Menulis"
        ' 
        ' chkOlahraga
        ' 
        chkOlahraga.Location = New Point(10, 83)
        chkOlahraga.Name = "chkOlahraga"
        chkOlahraga.Size = New Size(104, 24)
        chkOlahraga.TabIndex = 2
        chkOlahraga.Text = "Olahraga"
        ' 
        ' chkMusik
        ' 
        chkMusik.Location = New Point(10, 115)
        chkMusik.Name = "chkMusik"
        chkMusik.Size = New Size(104, 24)
        chkMusik.TabIndex = 3
        chkMusik.Text = "Musik"
        ' 
        ' chkCoding
        ' 
        chkCoding.Location = New Point(169, 20)
        chkCoding.Name = "chkCoding"
        chkCoding.Size = New Size(104, 24)
        chkCoding.TabIndex = 4
        chkCoding.Text = "Coding"
        ' 
        ' chkDesain
        ' 
        chkDesain.Location = New Point(169, 51)
        chkDesain.Name = "chkDesain"
        chkDesain.Size = New Size(104, 24)
        chkDesain.TabIndex = 5
        chkDesain.Text = "Desain"
        ' 
        ' chkGame
        ' 
        chkGame.Location = New Point(169, 83)
        chkGame.Name = "chkGame"
        chkGame.Size = New Size(104, 24)
        chkGame.TabIndex = 6
        chkGame.Text = "Gaming"
        ' 
        ' chkFotografi
        ' 
        chkFotografi.Location = New Point(169, 115)
        chkFotografi.Name = "chkFotografi"
        chkFotografi.Size = New Size(104, 24)
        chkFotografi.TabIndex = 7
        chkFotografi.Text = "Fotografi"
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.MediumSeaGreen
        btnCetak.FlatStyle = FlatStyle.Flat
        btnCetak.ForeColor = Color.White
        btnCetak.Location = New Point(390, 235)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(149, 41)
        btnCetak.TabIndex = 4
        btnCetak.Text = "Simpan dan Cetak"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.OrangeRed
        Panel1.Controls.Add(MenuStrip1)
        Panel1.Controls.Add(picLogoApp)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(164, 461)
        Panel1.TabIndex = 3
        ' 
        ' txtUmur
        ' 
        txtUmur.Font = New Font("JetBrains Mono", 8.999999F, FontStyle.Bold)
        txtUmur.Location = New Point(334, 218)
        txtUmur.Name = "txtUmur"
        txtUmur.PlaceholderText = "Umur"
        txtUmur.Size = New Size(166, 23)
        txtUmur.TabIndex = 1
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.Font = New Font("JetBrains Mono", 8.999999F, FontStyle.Bold)
        lblUmur.Location = New Point(334, 200)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(42, 16)
        lblUmur.TabIndex = 6
        lblUmur.Text = "Umur:"
        ' 
        ' Form1
        ' 
        BackColor = Color.Tomato
        ClientSize = New Size(791, 461)
        Controls.Add(TabControl1)
        Controls.Add(lblJudulApp)
        Controls.Add(Panel1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Input Data Komunitas"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(picLogoApp, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        gbHobi.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents txtUmur As TextBox
End Class