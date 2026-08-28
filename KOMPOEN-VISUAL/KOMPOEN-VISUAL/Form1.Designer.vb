<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblNim = New System.Windows.Forms.Label()
        Me.lblKom = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNim = New System.Windows.Forms.TextBox()
        Me.txtKom = New System.Windows.Forms.TextBox()
        Me.btnTampilkan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(170, 77)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(63, 20)
        Me.lblNama.TabIndex = 0
        Me.lblNama.Text = "Nama : "
        '
        'lblNim
        '
        Me.lblNim.AutoSize = True
        Me.lblNim.Location = New System.Drawing.Point(170, 123)
        Me.lblNim.Name = "lblNim"
        Me.lblNim.Size = New System.Drawing.Size(48, 20)
        Me.lblNim.TabIndex = 1
        Me.lblNim.Text = "Nim : "
        '
        'lblKom
        '
        Me.lblKom.AutoSize = True
        Me.lblKom.Location = New System.Drawing.Point(170, 168)
        Me.lblKom.Name = "lblKom"
        Me.lblKom.Size = New System.Drawing.Size(53, 20)
        Me.lblKom.TabIndex = 2
        Me.lblKom.Text = "Kom : "
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(239, 77)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(229, 26)
        Me.txtNama.TabIndex = 3
        '
        'txtNim
        '
        Me.txtNim.Location = New System.Drawing.Point(239, 123)
        Me.txtNim.Name = "txtNim"
        Me.txtNim.Size = New System.Drawing.Size(229, 26)
        Me.txtNim.TabIndex = 4
        '
        'txtKom
        '
        Me.txtKom.Location = New System.Drawing.Point(239, 165)
        Me.txtKom.Name = "txtKom"
        Me.txtKom.Size = New System.Drawing.Size(229, 26)
        Me.txtKom.TabIndex = 5
        '
        'btnTampilkan
        '
        Me.btnTampilkan.Location = New System.Drawing.Point(174, 235)
        Me.btnTampilkan.Name = "btnTampilkan"
        Me.btnTampilkan.Size = New System.Drawing.Size(136, 42)
        Me.btnTampilkan.TabIndex = 6
        Me.btnTampilkan.Text = "Tampilkan"
        Me.btnTampilkan.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(372, 236)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(136, 41)
        Me.btnHapus.TabIndex = 7
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(275, 299)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(136, 38)
        Me.btnKeluar.TabIndex = 8
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnTampilkan)
        Me.Controls.Add(Me.txtKom)
        Me.Controls.Add(Me.txtNim)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.lblKom)
        Me.Controls.Add(Me.lblNim)
        Me.Controls.Add(Me.lblNama)
        Me.Name = "Form1"
        Me.Text = "Profile Mahasiswa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNama As Label
    Friend WithEvents lblNim As Label
    Friend WithEvents lblKom As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNim As TextBox
    Friend WithEvents txtKom As TextBox
    Friend WithEvents btnTampilkan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnKeluar As Button
End Class
