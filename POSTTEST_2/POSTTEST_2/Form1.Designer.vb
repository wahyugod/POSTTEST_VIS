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
        GroupBoxTambah = New GroupBox()
        btnTambah = New Button()
        txtGenre = New TextBox()
        lblGenre = New Label()
        txtJudulTambah = New TextBox()
        lblJudulTambah = New Label()
        GroupBoxHapus = New GroupBox()
        btnHapus = New Button()
        txtJudulHapus = New TextBox()
        lblJudulHapus = New Label()
        ListBoxBuku = New ListBox()
        GroupBoxTambah.SuspendLayout()
        GroupBoxHapus.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBoxTambah
        ' 
        GroupBoxTambah.Controls.Add(btnTambah)
        GroupBoxTambah.Controls.Add(txtGenre)
        GroupBoxTambah.Controls.Add(lblGenre)
        GroupBoxTambah.Controls.Add(txtJudulTambah)
        GroupBoxTambah.Controls.Add(lblJudulTambah)
        GroupBoxTambah.Font = New Font("JetBrains Mono", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBoxTambah.ForeColor = Color.Cyan
        GroupBoxTambah.Location = New Point(23, 24)
        GroupBoxTambah.Name = "GroupBoxTambah"
        GroupBoxTambah.Size = New Size(262, 149)
        GroupBoxTambah.TabIndex = 0
        GroupBoxTambah.TabStop = False
        GroupBoxTambah.Text = "Tambah Buku"
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.Transparent
        btnTambah.Cursor = Cursors.Hand
        btnTambah.FlatAppearance.BorderColor = Color.Cyan
        btnTambah.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(60), CByte(60))
        btnTambah.FlatStyle = FlatStyle.Flat
        btnTambah.Font = New Font("JetBrains Mono ExtraBold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTambah.ForeColor = Color.Cyan
        btnTambah.Location = New Point(157, 107)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(87, 28)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' txtGenre
        ' 
        txtGenre.BackColor = Color.FromArgb(CByte(15), CByte(20), CByte(28))
        txtGenre.BorderStyle = BorderStyle.FixedSingle
        txtGenre.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtGenre.ForeColor = Color.White
        txtGenre.Location = New Point(92, 65)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(152, 23)
        txtGenre.TabIndex = 3
        ' 
        ' lblGenre
        ' 
        lblGenre.AutoSize = True
        lblGenre.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGenre.ForeColor = Color.LightGray
        lblGenre.Location = New Point(15, 68)
        lblGenre.Name = "lblGenre"
        lblGenre.Size = New Size(42, 15)
        lblGenre.TabIndex = 2
        lblGenre.Text = "Genre"
        ' 
        ' txtJudulTambah
        ' 
        txtJudulTambah.BackColor = Color.FromArgb(CByte(15), CByte(20), CByte(28))
        txtJudulTambah.BorderStyle = BorderStyle.FixedSingle
        txtJudulTambah.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtJudulTambah.ForeColor = Color.White
        txtJudulTambah.Location = New Point(92, 33)
        txtJudulTambah.Name = "txtJudulTambah"
        txtJudulTambah.Size = New Size(152, 23)
        txtJudulTambah.TabIndex = 1
        ' 
        ' lblJudulTambah
        ' 
        lblJudulTambah.AutoSize = True
        lblJudulTambah.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudulTambah.ForeColor = Color.LightGray
        lblJudulTambah.Location = New Point(15, 36)
        lblJudulTambah.Name = "lblJudulTambah"
        lblJudulTambah.Size = New Size(68, 15)
        lblJudulTambah.TabIndex = 0
        lblJudulTambah.Text = "Judul Buku"
        ' 
        ' GroupBoxHapus
        ' 
        GroupBoxHapus.Controls.Add(btnHapus)
        GroupBoxHapus.Controls.Add(txtJudulHapus)
        GroupBoxHapus.Controls.Add(lblJudulHapus)
        GroupBoxHapus.Font = New Font("JetBrains Mono", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBoxHapus.ForeColor = Color.FromArgb(CByte(255), CByte(80), CByte(80))
        GroupBoxHapus.Location = New Point(313, 24)
        GroupBoxHapus.Name = "GroupBoxHapus"
        GroupBoxHapus.Size = New Size(262, 149)
        GroupBoxHapus.TabIndex = 1
        GroupBoxHapus.TabStop = False
        GroupBoxHapus.Text = "Hapus Buku"
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.Transparent
        btnHapus.Cursor = Cursors.Hand
        btnHapus.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(80), CByte(80))
        btnHapus.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(20), CByte(20))
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("JetBrains Mono ExtraBold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHapus.ForeColor = Color.FromArgb(CByte(255), CByte(80), CByte(80))
        btnHapus.Location = New Point(159, 107)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(87, 28)
        btnHapus.TabIndex = 5
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' txtJudulHapus
        ' 
        txtJudulHapus.BackColor = Color.FromArgb(CByte(15), CByte(20), CByte(28))
        txtJudulHapus.BorderStyle = BorderStyle.FixedSingle
        txtJudulHapus.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtJudulHapus.ForeColor = Color.White
        txtJudulHapus.Location = New Point(94, 33)
        txtJudulHapus.Name = "txtJudulHapus"
        txtJudulHapus.Size = New Size(152, 23)
        txtJudulHapus.TabIndex = 3
        ' 
        ' lblJudulHapus
        ' 
        lblJudulHapus.AutoSize = True
        lblJudulHapus.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudulHapus.ForeColor = Color.LightGray
        lblJudulHapus.Location = New Point(17, 36)
        lblJudulHapus.Name = "lblJudulHapus"
        lblJudulHapus.Size = New Size(68, 15)
        lblJudulHapus.TabIndex = 2
        lblJudulHapus.Text = "Judul Buku"
        ' 
        ' ListBoxBuku
        ' 
        ListBoxBuku.BackColor = Color.FromArgb(CByte(15), CByte(20), CByte(28))
        ListBoxBuku.BorderStyle = BorderStyle.FixedSingle
        ListBoxBuku.Font = New Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListBoxBuku.ForeColor = Color.Lime
        ListBoxBuku.FormattingEnabled = True
        ListBoxBuku.Items.AddRange(New Object() {"Harry Potter (Fantasi)", "Sherlock Holmes (Misteri)"})
        ListBoxBuku.Location = New Point(120, 203)
        ListBoxBuku.Name = "ListBoxBuku"
        ListBoxBuku.Size = New Size(359, 172)
        ListBoxBuku.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(23), CByte(29), CByte(38))
        ClientSize = New Size(599, 411)
        Controls.Add(ListBoxBuku)
        Controls.Add(GroupBoxHapus)
        Controls.Add(GroupBoxTambah)
        Name = "Form1"
        Text = "Posttest 2"
        GroupBoxTambah.ResumeLayout(False)
        GroupBoxTambah.PerformLayout()
        GroupBoxHapus.ResumeLayout(False)
        GroupBoxHapus.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxTambah As GroupBox
    Friend WithEvents lblJudulTambah As Label
    Friend WithEvents txtJudulTambah As TextBox
    Friend WithEvents lblGenre As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents GroupBoxHapus As GroupBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents txtJudulHapus As TextBox
    Friend WithEvents lblJudulHapus As Label
    Friend WithEvents ListBoxBuku As ListBox

End Class