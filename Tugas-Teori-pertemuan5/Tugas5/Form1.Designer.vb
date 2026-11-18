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
        lblNama = New Label()
        lblBerat = New Label()
        lblHarga = New Label()
        lblDiskon = New Label()
        lblTotal = New Label()
        lblKeterangan = New Label()
        chkMember = New CheckBox()
        btnHitung = New Button()
        btnReset = New Button()
        txtNama = New TextBox()
        txtBerat = New TextBox()
        lblAplikasi = New Label()
        SuspendLayout()
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(92, 68)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(155, 25)
        lblNama.TabIndex = 0
        lblNama.Text = "Nama Pelanggan :"
        ' 
        ' lblBerat
        ' 
        lblBerat.AutoSize = True
        lblBerat.Location = New Point(92, 105)
        lblBerat.Name = "lblBerat"
        lblBerat.Size = New Size(154, 25)
        lblBerat.TabIndex = 1
        lblBerat.Text = "Berat Cucian (Kg) :"
        ' 
        ' lblHarga
        ' 
        lblHarga.AutoSize = True
        lblHarga.Location = New Point(92, 258)
        lblHarga.Name = "lblHarga"
        lblHarga.Size = New Size(137, 25)
        lblHarga.TabIndex = 2
        lblHarga.Text = "Harga Laundry :"
        ' 
        ' lblDiskon
        ' 
        lblDiskon.AutoSize = True
        lblDiskon.Location = New Point(92, 297)
        lblDiskon.Name = "lblDiskon"
        lblDiskon.Size = New Size(76, 25)
        lblDiskon.TabIndex = 3
        lblDiskon.Text = "Diskon :"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(92, 340)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(116, 25)
        lblTotal.TabIndex = 4
        lblTotal.Text = "Total Harga : "
        ' 
        ' lblKeterangan
        ' 
        lblKeterangan.AutoSize = True
        lblKeterangan.Location = New Point(92, 387)
        lblKeterangan.Name = "lblKeterangan"
        lblKeterangan.Size = New Size(110, 25)
        lblKeterangan.TabIndex = 5
        lblKeterangan.Text = "Keterangan :"
        ' 
        ' chkMember
        ' 
        chkMember.AutoSize = True
        chkMember.Location = New Point(95, 144)
        chkMember.Name = "chkMember"
        chkMember.Size = New Size(105, 29)
        chkMember.TabIndex = 6
        chkMember.Text = "Member"
        chkMember.UseVisualStyleBackColor = True
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(169, 188)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(112, 34)
        btnHitung.TabIndex = 7
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(325, 188)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(112, 34)
        btnReset.TabIndex = 8
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(258, 68)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(307, 31)
        txtNama.TabIndex = 9
        ' 
        ' txtBerat
        ' 
        txtBerat.Location = New Point(258, 105)
        txtBerat.Name = "txtBerat"
        txtBerat.Size = New Size(307, 31)
        txtBerat.TabIndex = 10
        ' 
        ' lblAplikasi
        ' 
        lblAplikasi.AutoSize = True
        lblAplikasi.BackColor = SystemColors.GradientActiveCaption
        lblAplikasi.Location = New Point(305, 9)
        lblAplikasi.Name = "lblAplikasi"
        lblAplikasi.Size = New Size(169, 25)
        lblAplikasi.TabIndex = 11
        lblAplikasi.Text = "APLIKASI LAUNDRY"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblAplikasi)
        Controls.Add(txtBerat)
        Controls.Add(txtNama)
        Controls.Add(btnReset)
        Controls.Add(btnHitung)
        Controls.Add(chkMember)
        Controls.Add(lblKeterangan)
        Controls.Add(lblTotal)
        Controls.Add(lblDiskon)
        Controls.Add(lblHarga)
        Controls.Add(lblBerat)
        Controls.Add(lblNama)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNama As Label
    Friend WithEvents lblBerat As Label
    Friend WithEvents lblHarga As Label
    Friend WithEvents lblDiskon As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblKeterangan As Label
    Friend WithEvents chkMember As CheckBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtBerat As TextBox
    Friend WithEvents lblAplikasi As Label

End Class
