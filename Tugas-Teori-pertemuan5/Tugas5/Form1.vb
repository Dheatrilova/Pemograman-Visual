Public Class Form1
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click

        'Harga laundry per kilogram
        Dim hargaPerKg As Integer = 7000

        'Variabel
        Dim nama As String
        Dim berat As Double
        Dim subtotal As Double
        Dim diskon As Double
        Dim totalBayar As Double

        'Mengambil input
        nama = txtNama.Text

        'Validasi nama
        If nama = "" Then
            MessageBox.Show("Nama pelanggan harus diisi!")
            txtNama.Focus()
            Exit Sub
        End If

        'Validasi berat
        If Not Double.TryParse(txtBerat.Text, berat) Then
            MessageBox.Show("Berat cucian harus berupa angka!")
            txtBerat.Focus()
            Exit Sub
        End If

        If berat <= 0 Then
            MessageBox.Show("Berat cucian harus lebih dari 0 Kg!")
            txtBerat.Focus()
            Exit Sub
        End If

        'Menghitung subtotal
        subtotal = hargaPerKg * berat

        'Menghitung diskon
        diskon = 0

        'Diskon 10% jika berat minimal 5 Kg
        If berat >= 5 Then
            diskon = subtotal * 0.1
        End If

        'Tambahan diskon 5% untuk member dengan berat minimal 8 Kg
        If chkMember.Checked And berat >= 8 Then
            diskon = diskon + (subtotal * 0.05)
        End If

        'Menghitung total bayar
        totalBayar = subtotal - diskon

        'Menampilkan hasil
        lblHarga.Text = "Harga Laundry : Rp" & subtotal.ToString("N0")
        lblDiskon.Text = "Diskon : Rp" & diskon.ToString("N0")
        lblTotal.Text = "Total Bayar : Rp" & totalBayar.ToString("N0")

        'Keterangan
        If chkMember.Checked And berat >= 8 Then
            lblKeterangan.Text = "Keterangan : Member mendapatkan diskon total 15%"
        ElseIf berat >= 5 Then
            lblKeterangan.Text = "Keterangan : Mendapatkan diskon 10%"
        Else
            lblKeterangan.Text = "Keterangan : Tidak mendapatkan diskon"
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtNama.Clear()
        txtBerat.Clear()
        chkMember.Checked = False

        lblHarga.Text = "Harga Laundry : Rp0"
        lblDiskon.Text = "Diskon : Rp0"
        lblTotal.Text = "Total Bayar : Rp0"
        lblKeterangan.Text = "Keterangan : Belum dihitung"

        txtNama.Focus()
    End Sub
End Class
