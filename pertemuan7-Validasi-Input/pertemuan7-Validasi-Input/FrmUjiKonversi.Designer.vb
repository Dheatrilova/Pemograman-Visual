
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUjiKonversi
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()

        Me.lblJudul = New System.Windows.Forms.Label()
        Me.lblPetunjuk = New System.Windows.Forms.Label()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnCInt = New System.Windows.Forms.Button()
        Me.btnVal = New System.Windows.Forms.Button()
        Me.btnTryParse = New System.Windows.Forms.Button()
        Me.btnTryCatch = New System.Windows.Forms.Button()
        Me.btnCatchBertingkat = New System.Windows.Forms.Button()
        Me.lblHasil = New System.Windows.Forms.Label()

        Me.SuspendLayout()

        ' lblJudul
        Me.lblJudul.AutoSize = True
        Me.lblJudul.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblJudul.Location = New System.Drawing.Point(39, 31)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(253, 38)
        Me.lblJudul.TabIndex = 0
        Me.lblJudul.Text = "Uji Konversi Input"

        ' lblPetunjuk
        Me.lblPetunjuk.AutoSize = True
        Me.lblPetunjuk.Location = New System.Drawing.Point(25, 114)
        Me.lblPetunjuk.Name = "lblPetunjuk"
        Me.lblPetunjuk.Size = New System.Drawing.Size(778, 25)
        Me.lblPetunjuk.TabIndex = 1
        Me.lblPetunjuk.Text = "Ketik sebuah nilai lalu coba setiap tombol. Coba: 25, abc, 12abc, 3,5, 99999999999, atau kosong."

        ' lblInput
        Me.lblInput.AutoSize = True
        Me.lblInput.Location = New System.Drawing.Point(25, 171)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(63, 25)
        Me.lblInput.TabIndex = 2
        Me.lblInput.Text = "Input :"

        ' txtInput
        Me.txtInput.Location = New System.Drawing.Point(100, 163)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(700, 31)
        Me.txtInput.TabIndex = 3

        ' btnCInt
        Me.btnCInt.Location = New System.Drawing.Point(25, 223)
        Me.btnCInt.Name = "btnCInt"
        Me.btnCInt.Size = New System.Drawing.Size(146, 40)
        Me.btnCInt.TabIndex = 4
        Me.btnCInt.Text = "CInt (tanpa Try)"
        Me.btnCInt.UseVisualStyleBackColor = True

        ' btnVal
        Me.btnVal.Location = New System.Drawing.Point(189, 223)
        Me.btnVal.Name = "btnVal"
        Me.btnVal.Size = New System.Drawing.Size(100, 40)
        Me.btnVal.TabIndex = 5
        Me.btnVal.Text = "Val"
        Me.btnVal.UseVisualStyleBackColor = True

        ' btnTryParse
        Me.btnTryParse.Location = New System.Drawing.Point(305, 223)
        Me.btnTryParse.Name = "btnTryParse"
        Me.btnTryParse.Size = New System.Drawing.Size(112, 40)
        Me.btnTryParse.TabIndex = 6
        Me.btnTryParse.Text = "TryParse"
        Me.btnTryParse.UseVisualStyleBackColor = True

        ' btnTryCatch
        Me.btnTryCatch.Location = New System.Drawing.Point(430, 223)
        Me.btnTryCatch.Name = "btnTryCatch"
        Me.btnTryCatch.Size = New System.Drawing.Size(125, 40)
        Me.btnTryCatch.TabIndex = 7
        Me.btnTryCatch.Text = "Try...Catch"
        Me.btnTryCatch.UseVisualStyleBackColor = True

        ' btnCatchBertingkat
        Me.btnCatchBertingkat.Location = New System.Drawing.Point(568, 223)
        Me.btnCatchBertingkat.Name = "btnCatchBertingkat"
        Me.btnCatchBertingkat.Size = New System.Drawing.Size(175, 40)
        Me.btnCatchBertingkat.TabIndex = 8
        Me.btnCatchBertingkat.Text = "Catch Bertingkat"
        Me.btnCatchBertingkat.UseVisualStyleBackColor = True

        ' lblHasil
        Me.lblHasil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHasil.Location = New System.Drawing.Point(25, 292)
        Me.lblHasil.Name = "lblHasil"
        Me.lblHasil.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.lblHasil.Size = New System.Drawing.Size(718, 140)
        Me.lblHasil.TabIndex = 9
        Me.lblHasil.Text = "Hasil akan tampil di sini."

        ' FrmUjiKonversi
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 480)
        Me.Controls.Add(Me.lblHasil)
        Me.Controls.Add(Me.btnCatchBertingkat)
        Me.Controls.Add(Me.btnTryCatch)
        Me.Controls.Add(Me.btnTryParse)
        Me.Controls.Add(Me.btnVal)
        Me.Controls.Add(Me.btnCInt)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblInput)
        Me.Controls.Add(Me.lblPetunjuk)
        Me.Controls.Add(Me.lblJudul)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmUjiKonversi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Uji Konversi Input"

        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents lblPetunjuk As System.Windows.Forms.Label
    Friend WithEvents lblInput As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents btnCInt As System.Windows.Forms.Button
    Friend WithEvents btnVal As System.Windows.Forms.Button
    Friend WithEvents btnTryParse As System.Windows.Forms.Button
    Friend WithEvents btnTryCatch As System.Windows.Forms.Button
    Friend WithEvents btnCatchBertingkat As System.Windows.Forms.Button
    Friend WithEvents lblHasil As System.Windows.Forms.Label

End Class
