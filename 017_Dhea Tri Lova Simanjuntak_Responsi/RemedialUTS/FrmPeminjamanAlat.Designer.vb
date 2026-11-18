<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPeminjamanAlat
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
        lblJudul = New Label()
        lblAlat = New Label()
        cboAlat = New ComboBox()
        lblJumlah = New Label()
        txtJumlah = New TextBox()
        btnPinjam = New Button()
        btnKembalikan = New Button()
        btnReset = New Button()
        dgvAlat = New DataGridView()
        lblTotalDipinjam = New Label()
        errInput = New ErrorProvider(components)
        bsAlat = New BindingSource(components)
        CType(dgvAlat, ComponentModel.ISupportInitialize).BeginInit()
        CType(errInput, ComponentModel.ISupportInitialize).BeginInit()
        CType(bsAlat, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(67, 46)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(342, 26)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Peminjaman Alat Laboratorium"
        ' 
        ' lblAlat
        ' 
        lblAlat.AutoSize = True
        lblAlat.Location = New Point(67, 112)
        lblAlat.Name = "lblAlat"
        lblAlat.Size = New Size(80, 25)
        lblAlat.TabIndex = 1
        lblAlat.Text = "Pilih Alat"
        ' 
        ' cboAlat
        ' 
        cboAlat.DropDownStyle = ComboBoxStyle.DropDownList
        cboAlat.FormattingEnabled = True
        cboAlat.Location = New Point(167, 112)
        cboAlat.Name = "cboAlat"
        cboAlat.Size = New Size(263, 33)
        cboAlat.TabIndex = 2
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.Location = New Point(67, 175)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(67, 25)
        lblJumlah.TabIndex = 3
        lblJumlah.Text = "Jumlah"
        ' 
        ' txtJumlah
        ' 
        txtJumlah.Location = New Point(167, 175)
        txtJumlah.Name = "txtJumlah"
        txtJumlah.Size = New Size(193, 31)
        txtJumlah.TabIndex = 4
        ' 
        ' btnPinjam
        ' 
        btnPinjam.Location = New Point(500, 112)
        btnPinjam.Name = "btnPinjam"
        btnPinjam.Size = New Size(112, 34)
        btnPinjam.TabIndex = 5
        btnPinjam.Text = "Pinjam"
        btnPinjam.UseVisualStyleBackColor = True
        ' 
        ' btnKembalikan
        ' 
        btnKembalikan.Location = New Point(681, 112)
        btnKembalikan.Name = "btnKembalikan"
        btnKembalikan.Size = New Size(112, 34)
        btnKembalikan.TabIndex = 6
        btnKembalikan.Text = "Kembalikan"
        btnKembalikan.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(858, 112)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(112, 34)
        btnReset.TabIndex = 7
        btnReset.Text = "Reset Data"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' dgvAlat
        ' 
        dgvAlat.AllowUserToAddRows = False
        dgvAlat.AllowUserToDeleteRows = False
        dgvAlat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAlat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAlat.Location = New Point(167, 225)
        dgvAlat.MultiSelect = False
        dgvAlat.Name = "dgvAlat"
        dgvAlat.ReadOnly = True
        dgvAlat.RowHeadersWidth = 62
        dgvAlat.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAlat.Size = New Size(803, 349)
        dgvAlat.TabIndex = 8
        ' 
        ' lblTotalDipinjam
        ' 
        lblTotalDipinjam.AutoSize = True
        lblTotalDipinjam.Location = New Point(500, 602)
        lblTotalDipinjam.Name = "lblTotalDipinjam"
        lblTotalDipinjam.Size = New Size(179, 25)
        lblTotalDipinjam.TabIndex = 9
        lblTotalDipinjam.Text = "Total Dipinjam: 0 unit"
        ' 
        ' errInput
        ' 
        errInput.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1009, 636)
        Controls.Add(lblTotalDipinjam)
        Controls.Add(dgvAlat)
        Controls.Add(btnReset)
        Controls.Add(btnKembalikan)
        Controls.Add(btnPinjam)
        Controls.Add(txtJumlah)
        Controls.Add(lblJumlah)
        Controls.Add(cboAlat)
        Controls.Add(lblAlat)
        Controls.Add(lblJudul)
        Name = "Form1"
        Text = "Form1"
        CType(dgvAlat, ComponentModel.ISupportInitialize).EndInit()
        CType(errInput, ComponentModel.ISupportInitialize).EndInit()
        CType(bsAlat, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblAlat As Label
    Friend WithEvents cboAlat As ComboBox
    Friend WithEvents lblJumlah As Label
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents btnPinjam As Button
    Friend WithEvents btnKembalikan As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents dgvAlat As DataGridView
    Friend WithEvents lblTotalDipinjam As Label
    Friend WithEvents errInput As ErrorProvider
    Friend WithEvents bsAlat As BindingSource

End Class
