Option Strict On

Public Class Form1

    ' Memeriksa seluruh input dan menampilkan ikon kesalahan menggunakan ErrorProvider.
    Private daftarKodeDipinjam As New List(Of String)
    Private Function ValidasiInput() As Boolean

        Dim valid As Boolean = True
        Dim kode As String = txtKodeBuku.Text.Trim()
        Dim judul As String = txtJudul.Text.Trim()
        Dim nama As String = txtNamaPeminjam.Text.Trim()
        Dim lamaPinjam As Integer

        ' Menghapus ikon kesalahan dari pemeriksaan sebelumnya.
        errPinjam.Clear()

        ' Memeriksa format kode buku.
        If Not KodeBukuValid(kode) Then
            errPinjam.SetError(txtKodeBuku,
                "Kode buku harus BK diikuti 4 digit, contoh BK0012.")
            valid = False
        End If

        ' Memeriksa judul buku.
        If String.IsNullOrWhiteSpace(judul) Then
            errPinjam.SetError(txtJudul,
                "Judul buku wajib diisi.")
            valid = False
        End If

        ' Memeriksa pilihan kategori.
        If cboKategori.SelectedIndex = -1 Then
            errPinjam.SetError(cboKategori,
                "Silakan pilih kategori buku.")
            valid = False
        End If

        ' Memeriksa nama peminjam.
        If nama.Length < 3 Then
            errPinjam.SetError(txtNamaPeminjam,
                "Nama peminjam minimal 3 karakter.")
            valid = False
        End If

        ' Memeriksa lama pinjam menggunakan Integer.TryParse.
        If Not Integer.TryParse(txtLamaPinjam.Text.Trim(), lamaPinjam) Then
            errPinjam.SetError(txtLamaPinjam,
                "Lama pinjam harus berupa bilangan bulat.")
            valid = False
        ElseIf lamaPinjam < 1 OrElse lamaPinjam > 14 Then
            errPinjam.SetError(txtLamaPinjam,
                "Lama pinjam harus antara 1 sampai 14 hari.")
            valid = False
        End If

        ' Mengembalikan hasil pemeriksaan seluruh input.
        Return valid

    End Function

    Private Sub btnPinjam_Click(sender As Object, e As EventArgs) Handles btnPinjam.Click
        ' Memeriksa seluruh input.
        If Not ValidasiInput() Then
            Return
        End If

        ' Mengambil dan membersihkan data dari form.
        Dim kode As String = txtKodeBuku.Text.Trim().ToUpperInvariant()
        Dim judul As String = txtJudul.Text.Trim()
        Dim kategori As String = cboKategori.SelectedItem.ToString()
        Dim nama As String = txtNamaPeminjam.Text.Trim()
        Dim lamaPinjam As Integer

        ' Memeriksa apakah buku sudah sedang dipinjam.
        If daftarKodeDipinjam.Contains(kode) Then
            errPinjam.SetError(txtKodeBuku, "Buku ini sedang dipinjam.")
            MessageBox.Show(
                "Buku ini sedang dipinjamkan.",
                "Peminjaman Ditolak",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Return
        End If

        ' Mengambil lama pinjam sebagai bilangan bulat.
        If Not Integer.TryParse(txtLamaPinjam.Text.Trim(), lamaPinjam) Then
            Return
        End If

        ' Menghitung tanggal kembali.
        Dim tanggalKembali As String =
        Date.Today.AddDays(lamaPinjam).ToString("dd/MM/yyyy")

        ' Membuat baris informasi peminjaman.
        Dim dataPeminjaman As String =
        $"{kode} | {judul} | {kategori} | {nama} | {lamaPinjam} hari | kembali {tanggalKembali}"

        ' Menyimpan kode buku agar tidak dipinjam dua kali.
        daftarKodeDipinjam.Add(kode)

        ' Menampilkan data peminjaman pada ListBox.
        lstPeminjaman.Items.Add(dataPeminjaman)

        ' Memperbarui jumlah peminjaman.
        lblStatus.Text = "Jumlah peminjaman: " & daftarKodeDipinjam.Count.ToString()

        ' Mengosongkan input setelah peminjaman berhasil.
        txtKodeBuku.Clear()
        txtJudul.Clear()
        cboKategori.SelectedIndex = -1
        txtNamaPeminjam.Clear()
        txtLamaPinjam.Clear()

        ' Menghapus ikon kesalahan setelah form dibersihkan.
        errPinjam.Clear()

        ' Mengembalikan fokus ke input kode buku.
        txtKodeBuku.Focus()
    End Sub

    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click
        txtKodeBuku.Clear()
        txtJudul.Clear()
        cboKategori.SelectedIndex = -1
        txtNamaPeminjam.Clear()
        txtLamaPinjam.Clear()

        ' Menghapus ikon kesalahan.
        errPinjam.Clear()

        ' Mengembalikan fokus ke kode buku.
        txtKodeBuku.Focus()
    End Sub

    Private Sub btnEkspor_Click(sender As Object, e As EventArgs) Handles btnEkspor.Click
        ' Memastikan daftar peminjaman tidak kosong.
        If lstPeminjaman.Items.Count = 0 Then
            lblStatus.Text = "Tidak ada data peminjaman. Silakan pinjam buku terlebih dahulu."
            Return
        End If

        ' Menentukan lokasi folder Documents.
        Dim folderDocuments As String =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

        Dim lokasiFile As String =
            System.IO.Path.Combine(folderDocuments, "peminjaman.csv")

        ' Menyiapkan StreamWriter sebelum digunakan.
        Dim penulis As System.IO.StreamWriter = Nothing

        Try
            ' Membuka file untuk ditulis.
            penulis = New System.IO.StreamWriter(lokasiFile, False)

            ' Menulis judul kolom pada baris pertama.
            penulis.WriteLine(
                "KodeBuku;Judul;Kategori;NamaPeminjam;LamaPinjamHari;TanggalKembali"
            )

            ' Menulis setiap data peminjaman dari ListBox.
            For Each item As Object In lstPeminjaman.Items

                Dim bagian() As String =
                    item.ToString().Split(
                        New String() {" | "},
                        StringSplitOptions.None
                    )

                ' Memastikan format data sesuai dengan daftar peminjaman.
                If bagian.Length = 6 Then

                    Dim kode As String = bagian(0)
                    Dim judul As String = bagian(1)
                    Dim kategori As String = bagian(2)
                    Dim nama As String = bagian(3)
                    Dim lama As String = bagian(4).Replace(" hari", "")
                    Dim tanggalKembali As String =
                        bagian(5).Replace("kembali ", "")

                    ' Menulis data dengan pemisah titik koma.
                    penulis.WriteLine(
                        EscapeCsvField(kode) & ";" &
                        EscapeCsvField(judul) & ";" &
                        EscapeCsvField(kategori) & ";" &
                        EscapeCsvField(nama) & ";" &
                        EscapeCsvField(lama) & ";" &
                        EscapeCsvField(tanggalKembali)
                    )
                End If
            Next
            lblStatus.Text = "Ekspor berhasil. File tersimpan di Documents."
        Catch ex As System.IO.IOException
            lblStatus.Text =
                "Gagal menyimpan file. Tutup file CSV jika sedang dibuka, lalu coba lagi."

        Catch ex As UnauthorizedAccessException
            lblStatus.Text =
                "Akses ditolak. Periksa izin penulisan ke folder Documents."

        Finally
            ' Memastikan StreamWriter ditutup.
            If penulis IsNot Nothing Then
                penulis.Close()
            End If

        End Try

    End Sub

    ' Menangani karakter khusus pada kolom CSV.
    Private Function EscapeCsvField(nilai As String) As String

        If nilai.Contains(";") OrElse
           nilai.Contains("""") OrElse
           nilai.Contains(vbCr) OrElse
           nilai.Contains(vbLf) Then

            nilai = """" & nilai.Replace("""", """""") & """"

        End If
        Return nilai
    End Function

    Private Sub lblKodeBuku_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles lblKodeBuku.Validating
        Dim kode As String = txtKodeBuku.Text.Trim()

        If Not KodeBukuValid(kode) Then
            errPinjam.SetError(
                txtKodeBuku,
                "Kode buku harus BK diikuti 4 digit, contoh BK0012."
            )
        Else
            errPinjam.SetError(txtKodeBuku, "")
        End If
    End Sub
End Class