Public Class Form1
    Private Sub btntampilkan_Click(sender As Object, e As EventArgs) Handles btntampilkan.Click
        dgvMahasiswa.AutoGenerateColumns = True
        dgvMahasiswa.DataSource = ModQuery.TampilkanData()
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        If ModQuery.TambahData(
        txtnim.Text,
        txtnama.Text,
        txtjurusan.Text
       ) Then
            MessageBox.Show("Data Berhasil Disimpan")
        End If
        txtjurusan.Clear()
        txtnim.Clear()
        txtnama.Clear()
    End Sub

    Private Sub lblnama_Click(sender As Object, e As EventArgs) Handles lblnama.Click

    End Sub
End Class
