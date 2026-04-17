<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        btnLogin = New Guna.UI2.WinForms.Guna2Button()
        pnlCard = New Guna.UI2.WinForms.Guna2Panel()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        pnlCard.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderThickness = 0
        txtUsername.CustomizableEdges = CustomizableEdges1
        txtUsername.DefaultText = ""
        txtUsername.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtUsername.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtUsername.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtUsername.FillColor = Color.FromArgb(CByte(239), CByte(244), CByte(255))
        txtUsername.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtUsername.Font = New Font("JetBrains Mono", 8.999999F, FontStyle.Bold)
        txtUsername.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtUsername.Location = New Point(48, 168)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Username"
        txtUsername.SelectedText = ""
        txtUsername.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txtUsername.Size = New Size(288, 38)
        txtUsername.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderThickness = 0
        txtPassword.CustomizableEdges = CustomizableEdges3
        txtPassword.DefaultText = ""
        txtPassword.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtPassword.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtPassword.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtPassword.FillColor = Color.FromArgb(CByte(239), CByte(244), CByte(255))
        txtPassword.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtPassword.Font = New Font("JetBrains Mono", 8.999999F, FontStyle.Bold)
        txtPassword.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtPassword.Location = New Point(48, 248)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "•"c
        txtPassword.PlaceholderText = "Password"
        txtPassword.SelectedText = ""
        txtPassword.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txtPassword.Size = New Size(288, 38)
        txtPassword.TabIndex = 1
        ' 
        ' btnLogin
        ' 
        btnLogin.BorderRadius = 8
        btnLogin.CustomizableEdges = CustomizableEdges5
        btnLogin.DisabledState.BorderColor = Color.DarkGray
        btnLogin.DisabledState.CustomBorderColor = Color.DarkGray
        btnLogin.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnLogin.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnLogin.FillColor = Color.FromArgb(CByte(45), CByte(53), CByte(73))
        btnLogin.Font = New Font("JetBrains Mono", 8.999999F, FontStyle.Bold)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(48, 338)
        btnLogin.Name = "btnLogin"
        btnLogin.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnLogin.Size = New Size(288, 45)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Login"
        ' 
        ' pnlCard
        ' 
        pnlCard.BackColor = Color.Transparent
        pnlCard.BorderRadius = 12
        pnlCard.Controls.Add(Guna2HtmlLabel2)
        pnlCard.Controls.Add(Guna2HtmlLabel7)
        pnlCard.Controls.Add(Guna2HtmlLabel3)
        pnlCard.Controls.Add(Guna2HtmlLabel4)
        pnlCard.Controls.Add(Guna2HtmlLabel1)
        pnlCard.Controls.Add(txtUsername)
        pnlCard.Controls.Add(btnLogin)
        pnlCard.Controls.Add(txtPassword)
        pnlCard.CustomizableEdges = CustomizableEdges7
        pnlCard.FillColor = Color.White
        pnlCard.Location = New Point(456, 232)
        pnlCard.Name = "pnlCard"
        pnlCard.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        pnlCard.Size = New Size(377, 456)
        pnlCard.TabIndex = 3
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("JetBrains Mono", 8.999999F, FontStyle.Bold)
        Guna2HtmlLabel2.Location = New Point(48, 224)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(59, 18)
        Guna2HtmlLabel2.TabIndex = 3
        Guna2HtmlLabel2.Text = "Password"
        ' 
        ' Guna2HtmlLabel7
        ' 
        Guna2HtmlLabel7.BackColor = Color.Transparent
        Guna2HtmlLabel7.Font = New Font("JetBrains Mono", 8.999999F, FontStyle.Bold)
        Guna2HtmlLabel7.Location = New Point(80, 416)
        Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Guna2HtmlLabel7.Size = New Size(220, 18)
        Guna2HtmlLabel7.TabIndex = 3
        Guna2HtmlLabel7.Text = "Hint: user=admin, pass=admin123"
        ' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.BackColor = Color.Transparent
        Guna2HtmlLabel3.Font = New Font("JetBrains Mono", 8.999999F, FontStyle.Bold)
        Guna2HtmlLabel3.Location = New Point(48, 76)
        Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Guna2HtmlLabel3.Size = New Size(290, 18)
        Guna2HtmlLabel3.TabIndex = 3
        Guna2HtmlLabel3.Text = "Masukan Kredensial Untuk Mengakses Sistem"
        ' 
        ' Guna2HtmlLabel4
        ' 
        Guna2HtmlLabel4.BackColor = Color.Transparent
        Guna2HtmlLabel4.Font = New Font("JetBrains Mono", 8.999999F, FontStyle.Bold)
        Guna2HtmlLabel4.Location = New Point(48, 144)
        Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Guna2HtmlLabel4.Size = New Size(59, 18)
        Guna2HtmlLabel4.TabIndex = 3
        Guna2HtmlLabel4.Text = "Username"
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("JetBrains Mono", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.Location = New Point(104, 36)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(171, 33)
        Guna2HtmlLabel1.TabIndex = 3
        Guna2HtmlLabel1.Text = "Welcome Back"
        ' 
        ' Guna2HtmlLabel5
        ' 
        Guna2HtmlLabel5.BackColor = Color.Transparent
        Guna2HtmlLabel5.Font = New Font("JetBrains Mono ExtraBold", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel5.Location = New Point(552, 72)
        Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Guna2HtmlLabel5.Size = New Size(201, 51)
        Guna2HtmlLabel5.TabIndex = 3
        Guna2HtmlLabel5.Text = "WahyuTech"
        ' 
        ' Guna2HtmlLabel6
        ' 
        Guna2HtmlLabel6.BackColor = Color.Transparent
        Guna2HtmlLabel6.Font = New Font("JetBrains Mono", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel6.Location = New Point(512, 136)
        Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Guna2HtmlLabel6.Size = New Size(273, 21)
        Guna2HtmlLabel6.TabIndex = 3
        Guna2HtmlLabel6.Text = "Sistem Manajemen Produk Laptop"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(255))
        ClientSize = New Size(1280, 800)
        Controls.Add(pnlCard)
        Controls.Add(Guna2HtmlLabel6)
        Controls.Add(Guna2HtmlLabel5)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        pnlCard.ResumeLayout(False)
        pnlCard.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlCard As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel

End Class
