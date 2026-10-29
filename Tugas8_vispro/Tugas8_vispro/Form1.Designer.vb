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
        components = New ComponentModel.Container()
        lblJudulForm = New Label()
        lblKodeBuku = New Label()
        txtKodeBuku = New TextBox()
        lblJudul = New Label()
        txtJudul = New TextBox()
        lblPenulis = New Label()
        txtPenulis = New TextBox()
        lblKategori = New Label()
        cboKategori = New ComboBox()
        lblTahun = New Label()
        txtTahun = New TextBox()
        lblStok = New Label()
        txtStok = New TextBox()
        btnTambah = New Button()
        btnBersihkan = New Button()
        lblCari = New Label()
        txtCari = New TextBox()
        lblFilterKategori = New Label()
        cboFilterKategori = New ComboBox()
        dgvBuku = New DataGridView()
        lblJumlah = New Label()
        lblTotalStok = New Label()
        cboUrut = New ComboBox()
        lblUrut = New Label()
        chkStokHabis = New CheckBox()
        bsBuku = New BindingSource(components)
        errBuku = New ErrorProvider(components)
        CType(dgvBuku, ComponentModel.ISupportInitialize).BeginInit()
        CType(bsBuku, ComponentModel.ISupportInitialize).BeginInit()
        CType(errBuku, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudulForm
        ' 
        lblJudulForm.AutoSize = True
        lblJudulForm.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudulForm.Location = New Point(55, 29)
        lblJudulForm.Name = "lblJudulForm"
        lblJudulForm.Size = New Size(325, 26)
        lblJudulForm.TabIndex = 0
        lblJudulForm.Text = "Inventaris Buku Perpustakaan"
        ' 
        ' lblKodeBuku
        ' 
        lblKodeBuku.AutoSize = True
        lblKodeBuku.Location = New Point(62, 81)
        lblKodeBuku.Name = "lblKodeBuku"
        lblKodeBuku.Size = New Size(97, 25)
        lblKodeBuku.TabIndex = 1
        lblKodeBuku.Text = "Kode Buku"
        ' 
        ' txtKodeBuku
        ' 
        txtKodeBuku.Location = New Point(62, 109)
        txtKodeBuku.Name = "txtKodeBuku"
        txtKodeBuku.Size = New Size(306, 31)
        txtKodeBuku.TabIndex = 2
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Location = New Point(62, 148)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(97, 25)
        lblJudul.TabIndex = 3
        lblJudul.Text = "Judul Buku"
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(62, 183)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(306, 31)
        txtJudul.TabIndex = 4
        ' 
        ' lblPenulis
        ' 
        lblPenulis.AutoSize = True
        lblPenulis.Location = New Point(62, 219)
        lblPenulis.Name = "lblPenulis"
        lblPenulis.Size = New Size(66, 25)
        lblPenulis.TabIndex = 5
        lblPenulis.Text = "Penulis"
        ' 
        ' txtPenulis
        ' 
        txtPenulis.Location = New Point(62, 247)
        txtPenulis.Name = "txtPenulis"
        txtPenulis.Size = New Size(306, 31)
        txtPenulis.TabIndex = 6
        ' 
        ' lblKategori
        ' 
        lblKategori.AutoSize = True
        lblKategori.Location = New Point(62, 284)
        lblKategori.Name = "lblKategori"
        lblKategori.Size = New Size(78, 25)
        lblKategori.TabIndex = 7
        lblKategori.Text = "Kategori"
        ' 
        ' cboKategori
        ' 
        cboKategori.DropDownStyle = ComboBoxStyle.DropDownList
        cboKategori.FormattingEnabled = True
        cboKategori.Items.AddRange(New Object() {"Fiksi", "Nonfiksi", "Referensi", "Majalah", "Teknologi"})
        cboKategori.Location = New Point(62, 312)
        cboKategori.Name = "cboKategori"
        cboKategori.Size = New Size(306, 33)
        cboKategori.TabIndex = 8
        ' 
        ' lblTahun
        ' 
        lblTahun.AutoSize = True
        lblTahun.Location = New Point(62, 350)
        lblTahun.Name = "lblTahun"
        lblTahun.Size = New Size(106, 25)
        lblTahun.TabIndex = 9
        lblTahun.Text = "Tahun Terbit"
        ' 
        ' txtTahun
        ' 
        txtTahun.Location = New Point(62, 378)
        txtTahun.Name = "txtTahun"
        txtTahun.Size = New Size(306, 31)
        txtTahun.TabIndex = 10
        ' 
        ' lblStok
        ' 
        lblStok.AutoSize = True
        lblStok.Location = New Point(62, 416)
        lblStok.Name = "lblStok"
        lblStok.Size = New Size(47, 25)
        lblStok.TabIndex = 11
        lblStok.Text = "Stok"
        ' 
        ' txtStok
        ' 
        txtStok.Location = New Point(62, 444)
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(306, 31)
        txtStok.TabIndex = 12
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(62, 496)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(157, 34)
        btnTambah.TabIndex = 13
        btnTambah.Text = "Tambah Buku"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnBersihkan
        ' 
        btnBersihkan.Location = New Point(256, 496)
        btnBersihkan.Name = "btnBersihkan"
        btnBersihkan.Size = New Size(112, 34)
        btnBersihkan.TabIndex = 14
        btnBersihkan.Text = "Bersihkan"
        btnBersihkan.UseVisualStyleBackColor = True
        ' 
        ' lblCari
        ' 
        lblCari.AutoSize = True
        lblCari.Location = New Point(426, 81)
        lblCari.Name = "lblCari"
        lblCari.Size = New Size(149, 25)
        lblCari.TabIndex = 15
        lblCari.Text = "Cari Judul/Penulis"
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(426, 109)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(710, 31)
        txtCari.TabIndex = 16
        ' 
        ' lblFilterKategori
        ' 
        lblFilterKategori.AutoSize = True
        lblFilterKategori.Location = New Point(426, 153)
        lblFilterKategori.Name = "lblFilterKategori"
        lblFilterKategori.Size = New Size(121, 25)
        lblFilterKategori.TabIndex = 17
        lblFilterKategori.Text = "Filter Kategori"
        ' 
        ' cboFilterKategori
        ' 
        cboFilterKategori.DropDownStyle = ComboBoxStyle.DropDownList
        cboFilterKategori.FormattingEnabled = True
        cboFilterKategori.Items.AddRange(New Object() {"Semua", "Fiksi", "Nonfiksi", "Referensi", "Majalah", "Teknologi"})
        cboFilterKategori.Location = New Point(426, 183)
        cboFilterKategori.Name = "cboFilterKategori"
        cboFilterKategori.Size = New Size(182, 33)
        cboFilterKategori.TabIndex = 18
        ' 
        ' dgvBuku
        ' 
        dgvBuku.AllowUserToAddRows = False
        dgvBuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBuku.Location = New Point(426, 235)
        dgvBuku.MultiSelect = False
        dgvBuku.Name = "dgvBuku"
        dgvBuku.ReadOnly = True
        dgvBuku.RowHeadersWidth = 62
        dgvBuku.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBuku.Size = New Size(750, 373)
        dgvBuku.TabIndex = 19
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.Location = New Point(426, 623)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(229, 25)
        lblJumlah.TabIndex = 20
        lblJumlah.Text = "Menampilkan 0 dari 0 buku"
        ' 
        ' lblTotalStok
        ' 
        lblTotalStok.AutoSize = True
        lblTotalStok.Location = New Point(426, 657)
        lblTotalStok.Name = "lblTotalStok"
        lblTotalStok.Size = New Size(107, 25)
        lblTotalStok.TabIndex = 21
        lblTotalStok.Text = "Total stok: 0"
        ' 
        ' cboUrut
        ' 
        cboUrut.DropDownStyle = ComboBoxStyle.DropDownList
        cboUrut.FormattingEnabled = True
        cboUrut.Items.AddRange(New Object() {"Urutan awal", "", "", "", "", "Judul AZ", "", "", "", "", "Tahun terbaru", "", "", "", "", "Stok terbanyak"})
        cboUrut.Location = New Point(907, 187)
        cboUrut.Name = "cboUrut"
        cboUrut.Size = New Size(182, 33)
        cboUrut.TabIndex = 22
        ' 
        ' lblUrut
        ' 
        lblUrut.AutoSize = True
        lblUrut.Location = New Point(907, 159)
        lblUrut.Name = "lblUrut"
        lblUrut.Size = New Size(110, 25)
        lblUrut.TabIndex = 23
        lblUrut.Text = "Urutan buku"
        ' 
        ' chkStokHabis
        ' 
        chkStokHabis.AutoSize = True
        chkStokHabis.Location = New Point(669, 187)
        chkStokHabis.Name = "chkStokHabis"
        chkStokHabis.Size = New Size(174, 29)
        chkStokHabis.TabIndex = 24
        chkStokHabis.Text = "Hanya stok habis"
        chkStokHabis.UseVisualStyleBackColor = True
        ' 
        ' errBuku
        ' 
        errBuku.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1203, 691)
        Controls.Add(chkStokHabis)
        Controls.Add(lblUrut)
        Controls.Add(cboUrut)
        Controls.Add(lblTotalStok)
        Controls.Add(lblJumlah)
        Controls.Add(dgvBuku)
        Controls.Add(cboFilterKategori)
        Controls.Add(lblFilterKategori)
        Controls.Add(txtCari)
        Controls.Add(lblCari)
        Controls.Add(btnBersihkan)
        Controls.Add(btnTambah)
        Controls.Add(txtStok)
        Controls.Add(lblStok)
        Controls.Add(txtTahun)
        Controls.Add(lblTahun)
        Controls.Add(cboKategori)
        Controls.Add(lblKategori)
        Controls.Add(txtPenulis)
        Controls.Add(lblPenulis)
        Controls.Add(txtJudul)
        Controls.Add(lblJudul)
        Controls.Add(txtKodeBuku)
        Controls.Add(lblKodeBuku)
        Controls.Add(lblJudulForm)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inventaris Buku Perpustakaan"
        CType(dgvBuku, ComponentModel.ISupportInitialize).EndInit()
        CType(bsBuku, ComponentModel.ISupportInitialize).EndInit()
        CType(errBuku, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudulForm As Label
    Friend WithEvents lblKodeBuku As Label
    Friend WithEvents txtKodeBuku As TextBox
    Friend WithEvents lblJudul As Label
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents lblPenulis As Label
    Friend WithEvents txtPenulis As TextBox
    Friend WithEvents lblKategori As Label
    Friend WithEvents cboKategori As ComboBox
    Friend WithEvents lblTahun As Label
    Friend WithEvents txtTahun As TextBox
    Friend WithEvents lblStok As Label
    Friend WithEvents txtStok As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents lblCari As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents lblFilterKategori As Label
    Friend WithEvents cboFilterKategori As ComboBox
    Friend WithEvents dgvBuku As DataGridView
    Friend WithEvents lblJumlah As Label
    Friend WithEvents lblTotalStok As Label
    Friend WithEvents cboUrut As ComboBox
    Friend WithEvents lblUrut As Label
    Friend WithEvents chkStokHabis As CheckBox
    Friend WithEvents bsBuku As BindingSource
    Friend WithEvents errBuku As ErrorProvider

End Class
