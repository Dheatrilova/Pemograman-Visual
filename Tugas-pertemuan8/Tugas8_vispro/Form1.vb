Option Strict On

Imports System.Data
Imports System.Text

Public Class Form1

    Private tabelBuku As DataTable

    ' =========================================================
    ' 1. MEMBUAT DATA AWAL DAN MENGATUR TAMPILAN
    ' =========================================================
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tabelBuku = New DataTable("InventarisBuku")

        tabelBuku.Columns.Add("KodeBuku", GetType(String))
        tabelBuku.Columns.Add("Judul", GetType(String))
        tabelBuku.Columns.Add("Penulis", GetType(String))
        tabelBuku.Columns.Add("Kategori", GetType(String))
        tabelBuku.Columns.Add("Tahun", GetType(Integer))
        tabelBuku.Columns.Add("Stok", GetType(Integer))

        ' Data awal: 10 buku dari empat kategori.
        tabelBuku.Rows.Add("BK0001", "Laskar Pelangi", "Andrea Hirata", "Fiksi", 2005, 8)
        tabelBuku.Rows.Add("BK0002", "Bumi Manusia", "Pramoedya Ananta Toer", "Fiksi", 1980, 5)
        tabelBuku.Rows.Add("BK0003", "Negeri 5 Menara", "Ahmad Fuadi", "Fiksi", 2009, 0)
        tabelBuku.Rows.Add("BK0004", "Laut Bercerita", "Leila S. Chudori", "Fiksi", 2017, 3)
        tabelBuku.Rows.Add("BK0005", "Atomic Habits", "James Clear", "Nonfiksi", 2018, 6)
        tabelBuku.Rows.Add("BK0006", "Filosofi Teras", "Henry Manampiring", "Nonfiksi", 2018, 4)
        tabelBuku.Rows.Add("BK0007", "Kamus Bahasa Indonesia", "Tim Penyusun", "Referensi", 2016, 0)
        tabelBuku.Rows.Add("BK0008", "Ensiklopedia Sains", "Tim Ensiklopedia", "Referensi", 2020, 2)
        tabelBuku.Rows.Add("BK0009", "National Geographic", "Redaksi Majalah", "Majalah", 2024, 7)
        tabelBuku.Rows.Add("BK0010", "Majalah Teknologi", "Redaksi Teknologi", "Majalah", 2025, 3)

        ' Menghubungkan DataTable, BindingSource, dan DataGridView.
        bsBuku.DataSource = tabelBuku
        dgvBuku.DataSource = bsBuku

        ' Pengaturan DataGridView.
        dgvBuku.ReadOnly = True
        dgvBuku.AllowUserToAddRows = False
        dgvBuku.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBuku.MultiSelect = False
        dgvBuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgvBuku.Columns("KodeBuku").HeaderText = "Kode Buku"
        dgvBuku.Columns("Judul").FillWeight = 180

        dgvBuku.Columns("Tahun").DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter

        dgvBuku.Columns("Stok").DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter

        ' Pilihan ComboBox kategori input.
        If cboKategori.Items.Count = 0 Then
            cboKategori.Items.AddRange(
                New Object() {"Fiksi", "Nonfiksi", "Referensi", "Majalah"}
            )
        End If

        ' Pilihan ComboBox filter kategori.
        If cboFilterKategori.Items.Count = 0 Then
            cboFilterKategori.Items.AddRange(
                New Object() {"Semua", "Fiksi", "Nonfiksi", "Referensi", "Majalah"}
            )
        End If

        ' Pilihan ComboBox pengurutan.
        If cboUrut.Items.Count = 0 Then
            cboUrut.Items.AddRange(
                New Object() {
                    "Urutan awal",
                    "Judul AZ",
                    "Tahun terbaru",
                    "Stok terbanyak"
                }
            )
        End If

        cboKategori.SelectedIndex = -1
        cboFilterKategori.SelectedIndex = 0
        cboUrut.SelectedIndex = 0
        chkStokHabis.Checked = False

        PerbaruiRingkasan()

    End Sub

    ' =========================================================
    ' 2. VALIDASI SELURUH INPUT
    ' =========================================================
    Private Function ValidasiInput() As Boolean

        Dim valid As Boolean = True

        Dim kode As String =
            txtKodeBuku.Text.Trim().ToUpperInvariant()

        Dim judul As String = txtJudul.Text.Trim()
        Dim penulis As String = txtPenulis.Text.Trim()

        Dim tahun As Integer
        Dim stok As Integer

        errBuku.Clear()

        ' Validasi format kode: BK diikuti empat digit.
        Dim formatKodeValid As Boolean =
            kode.Length = 6 AndAlso kode.StartsWith("BK")

        If formatKodeValid Then
            For i As Integer = 2 To 5
                If kode(i) < "0"c OrElse kode(i) > "9"c Then
                    formatKodeValid = False
                    Exit For
                End If
            Next
        End If

        If Not formatKodeValid Then
            errBuku.SetError(
                txtKodeBuku,
                "Kode harus BK diikuti 4 digit, contoh BK0011."
            )
            valid = False
        Else
            ' Memeriksa kode unik dengan perulangan DataTable.Rows.
            For Each baris As DataRow In tabelBuku.Rows

                If String.Equals(
                    baris("KodeBuku").ToString(),
                    kode,
                    StringComparison.OrdinalIgnoreCase
                ) Then

                    errBuku.SetError(
                        txtKodeBuku,
                        "Kode buku sudah terdaftar."
                    )
                    valid = False
                    Exit For

                End If

            Next
        End If

        ' Judul wajib diisi.
        If String.IsNullOrWhiteSpace(judul) Then
            errBuku.SetError(txtJudul, "Judul buku wajib diisi.")
            valid = False
        End If

        ' Penulis wajib diisi.
        If String.IsNullOrWhiteSpace(penulis) Then
            errBuku.SetError(txtPenulis, "Penulis wajib diisi.")
            valid = False
        End If

        ' Kategori wajib dipilih.
        If cboKategori.SelectedIndex = -1 Then
            errBuku.SetError(cboKategori, "Pilih kategori buku.")
            valid = False
        End If

        ' Tahun harus berupa bilangan bulat dari 1900 sampai tahun ini.
        If Not Integer.TryParse(txtTahun.Text.Trim(), tahun) Then

            errBuku.SetError(
                txtTahun,
                "Tahun harus berupa bilangan bulat."
            )
            valid = False

        ElseIf tahun < 1900 OrElse tahun > Date.Today.Year Then

            errBuku.SetError(
                txtTahun,
                "Tahun harus antara 1900 dan " &
                Date.Today.Year.ToString() & "."
            )
            valid = False

        End If

        ' Stok harus berupa bilangan bulat dan tidak negatif.
        If Not Integer.TryParse(txtStok.Text.Trim(), stok) Then

            errBuku.SetError(
                txtStok,
                "Stok harus berupa bilangan bulat."
            )
            valid = False

        ElseIf stok < 0 Then

            errBuku.SetError(
                txtStok,
                "Stok tidak boleh kurang dari 0."
            )
            valid = False

        End If

        Return valid

    End Function

    ' =========================================================
    ' 3. TOMBOL TAMBAH BUKU
    ' =========================================================
    Private Sub btnTambah_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnTambah.Click

        If Not ValidasiInput() Then
            Return
        End If

        Dim kode As String =
            txtKodeBuku.Text.Trim().ToUpperInvariant()

        Dim judul As String = txtJudul.Text.Trim()
        Dim penulis As String = txtPenulis.Text.Trim()

        Dim kategori As String =
            cboKategori.SelectedItem.ToString()

        Dim tahun As Integer = Integer.Parse(txtTahun.Text.Trim())
        Dim stok As Integer = Integer.Parse(txtStok.Text.Trim())

        ' Menambahkan data ke DataTable, bukan Rows milik DataGridView.
        tabelBuku.Rows.Add(
            kode, judul, penulis, kategori, tahun, stok
        )

        ' Filter dan urutan aktif tetap diterapkan.
        TerapkanFilterDanUrutan()

        BersihkanInput()

    End Sub

    ' =========================================================
    ' 4. TOMBOL BERSIHKAN
    ' =========================================================
    Private Sub BersihkanInput()

        txtKodeBuku.Clear()
        txtJudul.Clear()
        txtPenulis.Clear()
        cboKategori.SelectedIndex = -1
        txtTahun.Clear()
        txtStok.Clear()

        errBuku.Clear()
        txtKodeBuku.Focus()

    End Sub

    Private Sub btnBersihkan_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnBersihkan.Click

        BersihkanInput()

    End Sub

    ' =========================================================
    ' 5. MENGAMANKAN KARAKTER PENCARIAN
    ' =========================================================
    Private Function AmankanKataPencarian(teks As String) As String

        ' Mengamankan tanda kutip tunggal untuk ekspresi DataView.
        Dim hasil As String = teks.Replace("'", "''")

        ' Mengamankan karakter khusus pada pola LIKE DataView.
        hasil = hasil.Replace("[", "[[]")
        hasil = hasil.Replace("]", "[]]")
        hasil = hasil.Replace("%", "[%]")
        hasil = hasil.Replace("*", "[*]")

        Return hasil

    End Function

    ' =========================================================
    ' 6. PENCARIAN GABUNGAN, FILTER KATEGORI, DAN STOK HABIS
    ' =========================================================
    Private Sub TerapkanFilterDanUrutan()

        If tabelBuku Is Nothing Then
            Return
        End If

        Dim syarat As New List(Of String)

        Dim kata As String = txtCari.Text.Trim()
        Dim kategori As String = ""

        If cboFilterKategori.SelectedItem IsNot Nothing Then
            kategori = cboFilterKategori.SelectedItem.ToString()
        End If

        ' Pencarian judul ATAU penulis.
        If kata.Length > 0 Then

            Dim kataAman As String = AmankanKataPencarian(kata)

            syarat.Add(
                "(Judul LIKE '%" & kataAman &
                "%' OR Penulis LIKE '%" & kataAman & "%')"
            )

        End If

        ' Filter kategori bekerja bersama pencarian.
        If kategori <> "" AndAlso kategori <> "Semua" Then

            syarat.Add(
                "Kategori = '" & kategori.Replace("'", "''") & "'"
            )

        End If

        ' Filter tambahan: hanya buku dengan stok nol.
        If chkStokHabis.Checked Then
            syarat.Add("Stok = 0")
        End If

        ' Menggabungkan semua syarat dalam satu ekspresi Filter.
        bsBuku.Filter = String.Join(" AND ", syarat)

        ' Mengatur urutan berdasarkan pilihan.
        Select Case cboUrut.SelectedItem?.ToString()

            Case "Judul AZ"
                bsBuku.Sort = "Judul ASC"

            Case "Tahun terbaru"
                bsBuku.Sort = "Tahun DESC"

            Case "Stok terbanyak"
                bsBuku.Sort = "Stok DESC"

            Case Else
                ' Mengembalikan urutan awal berdasarkan posisi data.
                bsBuku.Sort = "KodeBuku ASC"

        End Select

        PerbaruiRingkasan()

    End Sub

    ' Pencarian berjalan saat pengguna mengetik.
    Private Sub txtCari_TextChanged(
        sender As Object,
        e As EventArgs
    ) Handles txtCari.TextChanged

        TerapkanFilterDanUrutan()

    End Sub

    ' Filter kategori.
    Private Sub cboFilterKategori_SelectedIndexChanged(
        sender As Object,
        e As EventArgs
    ) Handles cboFilterKategori.SelectedIndexChanged

        TerapkanFilterDanUrutan()

    End Sub

    ' Pengurutan buku.
    Private Sub cboUrut_SelectedIndexChanged(
        sender As Object,
        e As EventArgs
    ) Handles cboUrut.SelectedIndexChanged

        TerapkanFilterDanUrutan()

    End Sub

    ' Filter hanya stok habis.
    Private Sub chkStokHabis_CheckedChanged(
        sender As Object,
        e As EventArgs
    ) Handles chkStokHabis.CheckedChanged

        TerapkanFilterDanUrutan()

    End Sub

    ' =========================================================
    ' 7. RINGKASAN JUMLAH BUKU DAN TOTAL STOK
    ' =========================================================
    Private Sub PerbaruiRingkasan()

        If tabelBuku Is Nothing Then
            Return
        End If

        Dim jumlahTampil As Integer = 0
        Dim totalStok As Integer = 0

        ' Menghitung langsung dari baris yang tampil pada DataGridView.
        For Each baris As DataGridViewRow In dgvBuku.Rows

            If Not baris.IsNewRow Then

                jumlahTampil += 1

                If baris.Cells("Stok").Value IsNot Nothing AndAlso
                   Not Convert.IsDBNull(baris.Cells("Stok").Value) Then

                    totalStok += Convert.ToInt32(
                        baris.Cells("Stok").Value
                    )

                End If

            End If

        Next

        lblJumlah.Text =
            "Menampilkan " & jumlahTampil.ToString() &
            " dari " & tabelBuku.Rows.Count.ToString() & " buku"

        lblTotalStok.Text = "Total stok: " & totalStok.ToString()

    End Sub

End Class
