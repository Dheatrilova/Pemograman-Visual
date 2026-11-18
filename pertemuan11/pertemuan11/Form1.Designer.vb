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
        lblAsisten = New Label()
        lbljaga = New Label()
        btnulangi = New Button()
        btnmode = New Button()
        lbsdurasi = New Label()
        lblmenit = New Label()
        lbldetik = New Label()
        lblcrtl = New Label()
        lblalt = New Label()
        lbltimer = New Label()
        chkbunyi = New CheckBox()
        CheckBox1 = New CheckBox()
        Panel1 = New Panel()
        txtmulai = New TextBox()
        NumericUpDown1 = New NumericUpDown()
        NumericUpDown2 = New NumericUpDown()
        Panel2 = New Panel()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblAsisten
        ' 
        lblAsisten.AutoSize = True
        lblAsisten.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAsisten.Location = New Point(58, 39)
        lblAsisten.Name = "lblAsisten"
        lblAsisten.Size = New Size(198, 26)
        lblAsisten.TabIndex = 0
        lblAsisten.Text = "Asisten Presentasi"
        ' 
        ' lbljaga
        ' 
        lbljaga.AutoSize = True
        lbljaga.Location = New Point(58, 79)
        lbljaga.Name = "lbljaga"
        lbljaga.Size = New Size(352, 25)
        lbljaga.TabIndex = 1
        lbljaga.Text = "Jaga durasi tanpa meninggalkan slide anda"
        ' 
        ' btnulangi
        ' 
        btnulangi.Location = New Point(660, 329)
        btnulangi.Name = "btnulangi"
        btnulangi.Size = New Size(159, 34)
        btnulangi.TabIndex = 2
        btnulangi.Text = "Ulangi"
        btnulangi.UseVisualStyleBackColor = True
        ' 
        ' btnmode
        ' 
        btnmode.Location = New Point(660, 369)
        btnmode.Name = "btnmode"
        btnmode.Size = New Size(157, 34)
        btnmode.TabIndex = 3
        btnmode.Text = "Mode ringkas"
        btnmode.UseVisualStyleBackColor = True
        ' 
        ' lbsdurasi
        ' 
        lbsdurasi.AutoSize = True
        lbsdurasi.Font = New Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbsdurasi.Location = New Point(58, 398)
        lbsdurasi.Name = "lbsdurasi"
        lbsdurasi.Size = New Size(158, 23)
        lbsdurasi.TabIndex = 4
        lbsdurasi.Text = "Durasi Presentasi"
        ' 
        ' lblmenit
        ' 
        lblmenit.AutoSize = True
        lblmenit.Location = New Point(58, 432)
        lblmenit.Name = "lblmenit"
        lblmenit.Size = New Size(57, 25)
        lblmenit.TabIndex = 5
        lblmenit.Text = "Menit"
        ' 
        ' lbldetik
        ' 
        lbldetik.AutoSize = True
        lbldetik.Location = New Point(335, 432)
        lbldetik.Name = "lbldetik"
        lbldetik.Size = New Size(53, 25)
        lbldetik.TabIndex = 6
        lbldetik.Text = "Detik"
        ' 
        ' lblcrtl
        ' 
        lblcrtl.AutoSize = True
        lblcrtl.Location = New Point(58, 490)
        lblcrtl.Name = "lblcrtl"
        lblcrtl.Size = New Size(191, 25)
        lblcrtl.TabIndex = 7
        lblcrtl.Text = "Ctrl+Alt+F9;mulai/jeda"
        ' 
        ' lblalt
        ' 
        lblalt.AutoSize = True
        lblalt.Location = New Point(58, 525)
        lblalt.Name = "lblalt"
        lblalt.Size = New Size(425, 25)
        lblalt.TabIndex = 8
        lblalt.Text = "Crtl+Alt+F10; ulangi, Tombol tetap dapat digunakan"
        ' 
        ' lbltimer
        ' 
        lbltimer.AutoSize = True
        lbltimer.Location = New Point(58, 573)
        lbltimer.Name = "lbltimer"
        lbltimer.Size = New Size(541, 25)
        lbltimer.TabIndex = 9
        lbltimer.Text = "Timer siap, Aktifkan Tetap di atas agar terlihat saat berganti aplikasi"
        ' 
        ' chkbunyi
        ' 
        chkbunyi.AutoSize = True
        chkbunyi.Location = New Point(645, 428)
        chkbunyi.Name = "chkbunyi"
        chkbunyi.Size = New Size(174, 29)
        chkbunyi.TabIndex = 12
        chkbunyi.Text = "Bunyi saat selesai"
        chkbunyi.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(65, 314)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(231, 29)
        CheckBox1.TabIndex = 13
        CheckBox1.Text = "tetap di atas aplikasi lain"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaptionText
        Panel1.Location = New Point(65, 107)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(766, 201)
        Panel1.TabIndex = 14
        ' 
        ' txtmulai
        ' 
        txtmulai.BackColor = SystemColors.HotTrack
        txtmulai.Location = New Point(65, 349)
        txtmulai.Name = "txtmulai"
        txtmulai.Size = New Size(418, 31)
        txtmulai.TabIndex = 15
        txtmulai.Text = "Mulai Presentasi"
        txtmulai.TextAlign = HorizontalAlignment.Center
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(130, 432)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(150, 31)
        NumericUpDown1.TabIndex = 16
        ' 
        ' NumericUpDown2
        ' 
        NumericUpDown2.Location = New Point(394, 430)
        NumericUpDown2.Name = "NumericUpDown2"
        NumericUpDown2.Size = New Size(129, 31)
        NumericUpDown2.TabIndex = 17
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.Location = New Point(65, 398)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(773, 172)
        Panel2.TabIndex = 18
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(930, 618)
        Controls.Add(Panel2)
        Controls.Add(NumericUpDown2)
        Controls.Add(NumericUpDown1)
        Controls.Add(txtmulai)
        Controls.Add(Panel1)
        Controls.Add(CheckBox1)
        Controls.Add(chkbunyi)
        Controls.Add(lbltimer)
        Controls.Add(lblalt)
        Controls.Add(lblcrtl)
        Controls.Add(lbldetik)
        Controls.Add(lblmenit)
        Controls.Add(lbsdurasi)
        Controls.Add(btnmode)
        Controls.Add(btnulangi)
        Controls.Add(lbljaga)
        Controls.Add(lblAsisten)
        Name = "Form1"
        Text = "Form1"
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblAsisten As Label
    Friend WithEvents lbljaga As Label
    Friend WithEvents btnulangi As Button
    Friend WithEvents btnmode As Button
    Friend WithEvents lbsdurasi As Label
    Friend WithEvents lblmenit As Label
    Friend WithEvents lbldetik As Label
    Friend WithEvents lblcrtl As Label
    Friend WithEvents lblalt As Label
    Friend WithEvents lbltimer As Label
    Friend WithEvents chkbunyi As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtmulai As TextBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Panel2 As Panel

End Class
