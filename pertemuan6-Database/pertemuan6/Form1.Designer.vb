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
        btntampilkan = New Button()
        dgvMahasiswa = New DataGridView()
        txtnama = New TextBox()
        txtnim = New TextBox()
        txtjurusan = New TextBox()
        btntambah = New Button()
        lblnama = New Label()
        Label2 = New Label()
        Label3 = New Label()
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btntampilkan
        ' 
        btntampilkan.Location = New Point(229, 390)
        btntampilkan.Name = "btntampilkan"
        btntampilkan.Size = New Size(112, 34)
        btntampilkan.TabIndex = 0
        btntampilkan.Text = "tampilkan"
        btntampilkan.UseVisualStyleBackColor = True
        ' 
        ' dgvMahasiswa
        ' 
        dgvMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMahasiswa.Location = New Point(31, 104)
        dgvMahasiswa.Name = "dgvMahasiswa"
        dgvMahasiswa.RowHeadersWidth = 62
        dgvMahasiswa.Size = New Size(531, 270)
        dgvMahasiswa.TabIndex = 1
        ' 
        ' txtnama
        ' 
        txtnama.Location = New Point(703, 115)
        txtnama.Name = "txtnama"
        txtnama.Size = New Size(217, 31)
        txtnama.TabIndex = 2
        ' 
        ' txtnim
        ' 
        txtnim.Location = New Point(703, 166)
        txtnim.Name = "txtnim"
        txtnim.Size = New Size(217, 31)
        txtnim.TabIndex = 3
        ' 
        ' txtjurusan
        ' 
        txtjurusan.Location = New Point(703, 219)
        txtjurusan.Name = "txtjurusan"
        txtjurusan.Size = New Size(217, 31)
        txtjurusan.TabIndex = 4
        ' 
        ' btntambah
        ' 
        btntambah.Location = New Point(749, 286)
        btntambah.Name = "btntambah"
        btntambah.Size = New Size(112, 34)
        btntambah.TabIndex = 5
        btntambah.Text = "Tambah"
        btntambah.UseVisualStyleBackColor = True
        ' 
        ' lblnama
        ' 
        lblnama.AutoSize = True
        lblnama.Location = New Point(586, 121)
        lblnama.Name = "lblnama"
        lblnama.Size = New Size(59, 25)
        lblnama.TabIndex = 6
        lblnama.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(586, 172)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 25)
        Label2.TabIndex = 7
        Label2.Text = "Nim"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(586, 225)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 25)
        Label3.TabIndex = 8
        Label3.Text = "Jurusan"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1064, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(lblnama)
        Controls.Add(btntambah)
        Controls.Add(txtjurusan)
        Controls.Add(txtnim)
        Controls.Add(txtnama)
        Controls.Add(dgvMahasiswa)
        Controls.Add(btntampilkan)
        Name = "Form1"
        Text = "Form1"
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btntampilkan As Button
    Friend WithEvents dgvMahasiswa As DataGridView
    Friend WithEvents txtnama As TextBox
    Friend WithEvents txtnim As TextBox
    Friend WithEvents txtjurusan As TextBox
    Friend WithEvents btntambah As Button
    Friend WithEvents lblnama As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
