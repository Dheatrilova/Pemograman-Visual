
Option Strict On

Imports System.Collections.Generic

Public Class FrmPeminjamanAlat

    ' Menyimpan seluruh data alat di dalam List
    Private daftarAlat As New List(Of AlatLab)

    ' ==========================================
    ' 1. FORM LOAD
    ' ==========================================
    Private Sub FrmPeminjamanAlat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cboAlat.Items.Clear()
        daftarAlat.Clear()

        ' Mengisi ComboBox dan List berdasarkan array
        For Each nama As String In ModInventaris.DaftarAlat

            cboAlat.Items.Add(nama)

            Dim stok As Integer = ModInventaris.StokAwal(nama)

            Dim alatBaru As New AlatLab With {
                .NamaAlat = nama,
                .StokAwal = stok,
                .Tersedia = stok,
                .Dipinjam = 0
            }

            daftarAlat.Add(alatBaru)

        Next

        ' Kondisi awal input
        cboAlat.SelectedIndex = -1
        txtJumlah.Clear()

        ' Menghubungkan List dengan DataGridView melalui BindingSource
        bsAlat.DataSource = daftarAlat
        dgvAlat.AutoGenerateColumns = True
        dgvAlat.DataSource = bsAlat

        ' Mengatur DataGridView agar tidak dapat diedit
        dgvAlat.ReadOnly = True
        dgvAlat.AllowUserToAddRows = False
        dgvAlat.AllowUserToDeleteRows = False
        dgvAlat.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAlat.MultiSelect = False
        dgvAlat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAlat.RowHeadersVisible = False

        ' Mengatur nama dan urutan kolom
        If dgvAlat.Columns.Contains("NamaAlat") Then
            dgvAlat.Columns("NamaAlat").HeaderText = "Nama Alat"
            dgvAlat.Columns("NamaAlat").DisplayIndex = 0
        End If

        If dgvAlat.Columns.Contains("StokAwal") Then
            dgvAlat.Columns("StokAwal").HeaderText = "Stok Awal"
            dgvAlat.Columns("StokAwal").DisplayIndex = 1
        End If

        If dgvAlat.Columns.Contains("Tersedia") Then
            dgvAlat.Columns("Tersedia").HeaderText = "Tersedia"
            dgvAlat.Columns("Tersedia").DisplayIndex = 2
        End If

        If dgvAlat.Columns.Contains("Dipinjam") Then
            dgvAlat.Columns("Dipinjam").HeaderText = "Dipinjam"
            dgvAlat.Columns("Dipinjam").DisplayIndex = 3
        End If

        ' Membuat angka rata kanan
        Dim kolomAngka As String() = {
            "StokAwal",
            "Tersedia",
            "Dipinjam"
        }

        For Each namaKolom As String In kolomAngka
            If dgvAlat.Columns.Contains(namaKolom) Then
                dgvAlat.Columns(namaKolom).DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight
            End If
        Next

        lblTotalDipinjam.Text = "Total Dipinjam: 0 unit"

        errInput.Clear()

    End Sub

    ' ==========================================
    ' 2. VALIDASI INPUT
    ' ==========================================
    Private Function ValidasiInput() As Boolean

        Dim valid As Boolean = True
        Dim jumlah As Integer

        errInput.Clear()

        ' Memeriksa pilihan alat
        If cboAlat.SelectedIndex = -1 Then
            errInput.SetError(cboAlat, "Pilih alat terlebih dahulu.")
            valid = False
        End If

        ' Memeriksa jumlah
        If String.IsNullOrWhiteSpace(txtJumlah.Text) Then

            errInput.SetError(txtJumlah, "Jumlah wajib diisi.")
            valid = False

        ElseIf Not Integer.TryParse(txtJumlah.Text.Trim(), jumlah) Then

            errInput.SetError(txtJumlah, "Jumlah harus berupa bilangan bulat.")
            valid = False

        ElseIf jumlah <= 0 Then

            errInput.SetError(txtJumlah, "Jumlah harus lebih dari 0.")
            valid = False

        End If

        Return valid

    End Function

    ' ==========================================
    ' 3. MENCARI DATA ALAT
    ' ==========================================
    Private Function CariAlat(nama As String) As AlatLab

        For Each item As AlatLab In daftarAlat

            If item.NamaAlat = nama Then
                Return item
            End If

        Next

        Return Nothing

    End Function

    ' ==========================================
    ' 4. TOMBOL PINJAM
    ' ==========================================
    Private Sub btnPinjam_Click(sender As Object, e As EventArgs) Handles btnPinjam.Click

        Try

            If Not ValidasiInput() Then
                Return
            End If

            Dim jumlah As Integer
            Integer.TryParse(txtJumlah.Text.Trim(), jumlah)

            Dim nama As String = cboAlat.SelectedItem.ToString()
            Dim alat As AlatLab = CariAlat(nama)

            If alat Is Nothing Then
                Throw New InvalidOperationException("Data alat tidak ditemukan.")
            End If

            ' Memeriksa ketersediaan stok
            If jumlah > alat.Tersedia Then

                errInput.SetError(
                    txtJumlah,
                    "Jumlah melebihi stok tersedia (" & alat.Tersedia.ToString() & ")."
                )

                Return

            End If

            ' Memperbarui stok
            alat.Tersedia -= jumlah
            alat.Dipinjam += jumlah

            ' Memperbarui tampilan
            bsAlat.ResetBindings(False)
            PerbaruiTotal()
            BersihkanInput()

        Catch ex As Exception

            MessageBox.Show(
                "Terjadi kesalahan saat meminjam alat: " & ex.Message,
                "Kesalahan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    ' ==========================================
    ' 5. TOMBOL KEMBALIKAN
    ' ==========================================
    Private Sub btnKembalikan_Click(sender As Object, e As EventArgs) Handles btnKembalikan.Click

        Try

            If Not ValidasiInput() Then
                Return
            End If

            Dim jumlah As Integer
            Integer.TryParse(txtJumlah.Text.Trim(), jumlah)

            Dim nama As String = cboAlat.SelectedItem.ToString()
            Dim alat As AlatLab = CariAlat(nama)

            If alat Is Nothing Then
                Throw New InvalidOperationException("Data alat tidak ditemukan.")
            End If

            ' Memeriksa jumlah alat yang sedang dipinjam
            If jumlah > alat.Dipinjam Then

                errInput.SetError(
                    txtJumlah,
                    "Jumlah melebihi alat yang sedang dipinjam (" & alat.Dipinjam.ToString() & ")."
                )

                Return

            End If

            ' Memperbarui stok
            alat.Tersedia += jumlah
            alat.Dipinjam -= jumlah

            ' Memperbarui tampilan
            bsAlat.ResetBindings(False)
            PerbaruiTotal()
            BersihkanInput()

        Catch ex As Exception

            MessageBox.Show(
                "Terjadi kesalahan saat mengembalikan alat: " & ex.Message,
                "Kesalahan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    ' ==========================================
    ' 6. MEMPERBARUI TOTAL ALAT DIPINJAM
    ' ==========================================
    Private Sub PerbaruiTotal()

        Dim total As Integer = 0

        For Each item As AlatLab In daftarAlat
            total += item.Dipinjam
        Next

        lblTotalDipinjam.Text = "Total Dipinjam: " & total.ToString() & " unit"

    End Sub

    ' ==========================================
    ' 7. MEMBERSIHKAN INPUT
    ' ==========================================
    Private Sub BersihkanInput()

        cboAlat.SelectedIndex = -1
        txtJumlah.Clear()
        errInput.Clear()

        cboAlat.Focus()

    End Sub

    ' ==========================================
    ' 8. TOMBOL RESET DATA
    ' ==========================================
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        Dim jawaban As DialogResult = MessageBox.Show(
            "Kembalikan seluruh data ke kondisi awal?",
            "Reset Data",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If jawaban = DialogResult.Yes Then

            For Each item As AlatLab In daftarAlat

                item.StokAwal = ModInventaris.StokAwal(item.NamaAlat)
                item.Tersedia = item.StokAwal
                item.Dipinjam = 0

            Next

            bsAlat.ResetBindings(False)
            PerbaruiTotal()
            BersihkanInput()

        End If

    End Sub

End Class
