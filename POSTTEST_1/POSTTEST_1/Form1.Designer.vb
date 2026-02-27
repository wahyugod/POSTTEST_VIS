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
        txtIPS = New TextBox()
        btnTambah = New Button()
        Label3 = New Label()
        lblPredikat = New Label()
        Label4 = New Label()
        lblSemester = New Label()
        btnReset = New Button()
        Label1 = New Label()
        Label5 = New Label()
        Panel1 = New Panel()
        txtIPK = New TextBox()
        SuspendLayout()
        ' 
        ' txtIPS
        ' 
        txtIPS.BackColor = Color.FromArgb(CByte(24), CByte(20), CByte(31))
        txtIPS.BorderStyle = BorderStyle.None
        txtIPS.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtIPS.ForeColor = Color.White
        txtIPS.Location = New Point(159, 149)
        txtIPS.Name = "txtIPS"
        txtIPS.PlaceholderText = "Masukan IP Semester..."
        txtIPS.Size = New Size(478, 28)
        txtIPS.TabIndex = 1
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.FromArgb(CByte(24), CByte(20), CByte(31))
        btnTambah.FlatAppearance.BorderSize = 2
        btnTambah.FlatStyle = FlatStyle.Flat
        btnTambah.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTambah.ForeColor = Color.DarkViolet
        btnTambah.Location = New Point(255, 236)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(131, 34)
        btnTambah.TabIndex = 2
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(100, 339)
        Label3.Name = "Label3"
        Label3.Size = New Size(154, 21)
        Label3.TabIndex = 0
        Label3.Text = "IP Kumulatif (IPK) :"
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPredikat.ForeColor = Color.DarkViolet
        lblPredikat.Location = New Point(279, 374)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(24, 32)
        lblPredikat.TabIndex = 0
        lblPredikat.Text = "-"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(604, 339)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 21)
        Label4.TabIndex = 0
        Label4.Text = "Semester ke :"
        ' 
        ' lblSemester
        ' 
        lblSemester.AutoSize = True
        lblSemester.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSemester.ForeColor = Color.White
        lblSemester.Location = New Point(599, 368)
        lblSemester.Name = "lblSemester"
        lblSemester.Size = New Size(33, 37)
        lblSemester.TabIndex = 0
        lblSemester.Text = "0"
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.FromArgb(CByte(24), CByte(20), CByte(31))
        btnReset.FlatAppearance.BorderSize = 2
        btnReset.FlatStyle = FlatStyle.Flat
        btnReset.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReset.ForeColor = Color.CornflowerBlue
        btnReset.Location = New Point(403, 236)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(131, 34)
        btnReset.TabIndex = 2
        btnReset.Text = "Reset Data"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(228, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(346, 32)
        Label1.TabIndex = 0
        Label1.Text = "PROGRAM PENGHITUNG IPK"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(282, 339)
        Label5.Name = "Label5"
        Label5.Size = New Size(82, 21)
        Label5.TabIndex = 0
        Label5.Text = "Predikat :"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.CornflowerBlue
        Panel1.Location = New Point(157, 147)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(5)
        Panel1.Size = New Size(482, 32)
        Panel1.TabIndex = 3
        ' 
        ' txtIPK
        ' 
        txtIPK.BackColor = Color.FromArgb(CByte(24), CByte(20), CByte(31))
        txtIPK.BorderStyle = BorderStyle.None
        txtIPK.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtIPK.ForeColor = Color.CornflowerBlue
        txtIPK.Location = New Point(102, 370)
        txtIPK.Name = "txtIPK"
        txtIPK.ReadOnly = True
        txtIPK.Size = New Size(75, 36)
        txtIPK.TabIndex = 1
        txtIPK.Text = "0.00"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(20), CByte(22), CByte(27))
        ClientSize = New Size(800, 450)
        Controls.Add(txtIPK)
        Controls.Add(txtIPS)
        Controls.Add(Label1)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(lblPredikat)
        Controls.Add(lblSemester)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Kalkulator IP"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtIPS As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPredikat As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblSemester As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtIPK As TextBox

End Class
