Option Strict On

Public Module ModuleValidasi

    ' Memeriksa apakah kode buku diawali BK dan diikuti empat digit angka.
    Public Function KodeBukuValid(kode As String) As Boolean

        ' Menghapus spasi di awal dan akhir serta mengubah huruf menjadi kapital.
        Dim kodeBersih As String = kode.Trim().ToUpperInvariant()

        ' Kode buku harus terdiri dari enam karakter.
        If kodeBersih.Length <> 6 Then
            Return False
        End If

        ' Dua karakter pertama harus BK.
        If Not kodeBersih.StartsWith("BK") Then
            Return False
        End If

        ' Empat karakter terakhir harus berupa angka 0 sampai 9.
        For i As Integer = 2 To 5
            If kodeBersih(i) < "0"c OrElse kodeBersih(i) > "9"c Then
                Return False
            End If
        Next

        ' Mengembalikan True jika semua pemeriksaan berhasil.
        Return True

    End Function

End Module