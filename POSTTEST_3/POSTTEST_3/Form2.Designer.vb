<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        lblJudulKartu = New Label()
        picProfilHasil = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        lblNama = New Label()
        lblUmur = New Label()
        lblJK = New Label()
        lblNoTelp = New Label()
        lblTglLahir = New Label()
        lblAlamat = New Label()
        lblHobi = New Label()
        PanelKartu = New Panel()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        CType(picProfilHasil, ComponentModel.ISupportInitialize).BeginInit()
        PanelKartu.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblJudulKartu
        ' 
        lblJudulKartu.AutoSize = True
        lblJudulKartu.BackColor = Color.OrangeRed
        lblJudulKartu.Font = New Font("Britannic Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblJudulKartu.ForeColor = Color.White
        lblJudulKartu.Location = New Point(35, 9)
        lblJudulKartu.Name = "lblJudulKartu"
        lblJudulKartu.Size = New Size(599, 32)
        lblJudulKartu.TabIndex = 0
        lblJudulKartu.Text = "KARTU TANDA ANGGOTA - PEMUDA PANCASILA"
        ' 
        ' picProfilHasil
        ' 
        picProfilHasil.BackColor = Color.WhiteSmoke
        picProfilHasil.BackgroundImageLayout = ImageLayout.Stretch
        picProfilHasil.BorderStyle = BorderStyle.FixedSingle
        picProfilHasil.Location = New Point(34, 118)
        picProfilHasil.Name = "picProfilHasil"
        picProfilHasil.Size = New Size(148, 197)
        picProfilHasil.SizeMode = PictureBoxSizeMode.StretchImage
        picProfilHasil.TabIndex = 1
        picProfilHasil.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("MV Boli", 9.75F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(212, 118)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 17)
        Label1.TabIndex = 2
        Label1.Text = "Nama :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("MV Boli", 9.75F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(212, 148)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 17)
        Label2.TabIndex = 3
        Label2.Text = "Umur :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("MV Boli", 9.75F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(212, 178)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 17)
        Label3.TabIndex = 4
        Label3.Text = "Jenis Kelamin :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("MV Boli", 9.75F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(212, 208)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 17)
        Label4.TabIndex = 5
        Label4.Text = "No. Telp :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("MV Boli", 9.75F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(212, 238)
        Label5.Name = "Label5"
        Label5.Size = New Size(112, 17)
        Label5.TabIndex = 6
        Label5.Text = "Tanggal Lahir :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("MV Boli", 9.75F, FontStyle.Bold)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(212, 268)
        Label6.Name = "Label6"
        Label6.Size = New Size(69, 17)
        Label6.TabIndex = 7
        Label6.Text = "Alamat :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("MV Boli", 9.75F, FontStyle.Bold)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(212, 298)
        Label7.Name = "Label7"
        Label7.Size = New Size(51, 17)
        Label7.TabIndex = 8
        Label7.Text = "Hobi :"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = Color.Transparent
        lblNama.Font = New Font("MV Boli", 9.75F, FontStyle.Bold)
        lblNama.ForeColor = Color.White
        lblNama.Location = New Point(339, 118)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(15, 17)
        lblNama.TabIndex = 9
        lblNama.Text = "-"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.BackColor = Color.Transparent
        lblUmur.Font = New Font("MV Boli", 9.75F, FontStyle.Bold)
        lblUmur.ForeColor = Color.White
        lblUmur.Location = New Point(339, 148)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(15, 17)
        lblUmur.TabIndex = 10
        lblUmur.Text = "-"
        ' 
        ' lblJK
        ' 
        lblJK.AutoSize = True
        lblJK.BackColor = Color.Transparent
        lblJK.Font = New Font("MV Boli", 9.75F, FontStyle.Bold)
        lblJK.ForeColor = Color.White
        lblJK.Location = New Point(339, 178)
        lblJK.Name = "lblJK"
        lblJK.Size = New Size(15, 17)
        lblJK.TabIndex = 11
        lblJK.Text = "-"
        ' 
        ' lblNoTelp
        ' 
        lblNoTelp.AutoSize = True
        lblNoTelp.BackColor = Color.Transparent
        lblNoTelp.Font = New Font("MV Boli", 9.75F, FontStyle.Bold)
        lblNoTelp.ForeColor = Color.White
        lblNoTelp.Location = New Point(339, 208)
        lblNoTelp.Name = "lblNoTelp"
        lblNoTelp.Size = New Size(15, 17)
        lblNoTelp.TabIndex = 12
        lblNoTelp.Text = "-"
        ' 
        ' lblTglLahir
        ' 
        lblTglLahir.AutoSize = True
        lblTglLahir.BackColor = Color.Transparent
        lblTglLahir.Font = New Font("MV Boli", 9.75F, FontStyle.Bold)
        lblTglLahir.ForeColor = Color.White
        lblTglLahir.Location = New Point(339, 238)
        lblTglLahir.Name = "lblTglLahir"
        lblTglLahir.Size = New Size(15, 17)
        lblTglLahir.TabIndex = 13
        lblTglLahir.Text = "-"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.BackColor = Color.Transparent
        lblAlamat.Font = New Font("MV Boli", 9.75F, FontStyle.Bold)
        lblAlamat.ForeColor = Color.White
        lblAlamat.Location = New Point(339, 268)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(15, 17)
        lblAlamat.TabIndex = 14
        lblAlamat.Text = "-"
        ' 
        ' lblHobi
        ' 
        lblHobi.AutoSize = True
        lblHobi.BackColor = Color.Transparent
        lblHobi.Font = New Font("MV Boli", 9.75F, FontStyle.Bold)
        lblHobi.ForeColor = Color.White
        lblHobi.Location = New Point(339, 298)
        lblHobi.Name = "lblHobi"
        lblHobi.Size = New Size(15, 17)
        lblHobi.TabIndex = 15
        lblHobi.Text = "-"
        ' 
        ' PanelKartu
        ' 
        PanelKartu.BackColor = Color.DarkOrange
        PanelKartu.BackgroundImage = My.Resources.Resources.Screenshot_2026_03_14_124952
        PanelKartu.BackgroundImageLayout = ImageLayout.Stretch
        PanelKartu.BorderStyle = BorderStyle.FixedSingle
        PanelKartu.Controls.Add(PictureBox1)
        PanelKartu.Controls.Add(lblHobi)
        PanelKartu.Controls.Add(lblAlamat)
        PanelKartu.Controls.Add(lblTglLahir)
        PanelKartu.Controls.Add(lblNoTelp)
        PanelKartu.Controls.Add(lblJK)
        PanelKartu.Controls.Add(lblUmur)
        PanelKartu.Controls.Add(lblNama)
        PanelKartu.Controls.Add(Label7)
        PanelKartu.Controls.Add(Label6)
        PanelKartu.Controls.Add(Label5)
        PanelKartu.Controls.Add(Label4)
        PanelKartu.Controls.Add(Label3)
        PanelKartu.Controls.Add(Label2)
        PanelKartu.Controls.Add(Label1)
        PanelKartu.Controls.Add(picProfilHasil)
        PanelKartu.Controls.Add(Panel1)
        PanelKartu.Controls.Add(Panel2)
        PanelKartu.Controls.Add(Panel3)
        PanelKartu.Location = New Point(-2, -3)
        PanelKartu.Name = "PanelKartu"
        PanelKartu.Size = New Size(638, 385)
        PanelKartu.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources.Logo_Pemuda_Pancasila_PNG_Warna
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(484, 113)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(127, 142)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.OrangeRed
        Panel1.Controls.Add(lblJudulKartu)
        Panel1.Location = New Point(-18, 26)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(655, 51)
        Panel1.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Black
        Panel2.Location = New Point(-1, 22)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(648, 60)
        Panel2.TabIndex = 16
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.OrangeRed
        Panel3.Location = New Point(29, 113)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(159, 209)
        Panel3.TabIndex = 17
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(634, 342)
        Controls.Add(PanelKartu)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Hasil ID Card"
        CType(picProfilHasil, ComponentModel.ISupportInitialize).EndInit()
        PanelKartu.ResumeLayout(False)
        PanelKartu.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblJudulKartu As Label
    Friend WithEvents picProfilHasil As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblJK As Label
    Friend WithEvents lblNoTelp As Label
    Friend WithEvents lblTglLahir As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblHobi As Label
    Friend WithEvents PanelKartu As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class