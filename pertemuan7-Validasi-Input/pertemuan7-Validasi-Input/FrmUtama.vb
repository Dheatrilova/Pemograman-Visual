
Public Class FrmUtama

    ' Membuka form Uji Konversi Input.
    Private Sub btnUjiKonversi_Click(sender As Object, e As EventArgs) Handles btnUjiKonversi.Click

        Try
            Using frm As New FrmUjiKonversi()
                frm.ShowDialog(Me)
            End Using

        Catch ex As Exception
            MessageBox.Show(
                "Gagal membuka Form Uji Konversi." & vbCrLf &
                "Detail: " & ex.Message,
                "Kesalahan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try

    End Sub

    ' Membuka studi kasus pendaftaran.
    Private Sub btnPendaftaran_Click(sender As Object, e As EventArgs) Handles btnPendaftaran.Click

        Try
            Using frm As New FrmPendaftaran()
                frm.ShowDialog(Me)
            End Using

        Catch ex As Exception
            MessageBox.Show(
                "Gagal membuka Form Pendaftaran." & vbCrLf &
                "Detail: " & ex.Message,
                "Kesalahan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try

    End Sub

End Class
