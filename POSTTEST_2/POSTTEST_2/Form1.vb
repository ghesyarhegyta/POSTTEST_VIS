Public Class Form1

    Sub TambahBuku(ByVal judul As String, ByVal penulis As String, ByVal genre As String)

        judulBuku(jumlahData) = judul
        penulisBuku(jumlahData) = penulis
        genreBuku(jumlahData) = genre

        jumlahData += 1

    End Sub

    Function FormatBuku(ByVal index As Integer) As String

        Return judulBuku(index) & " | " &
               penulisBuku(index) & " | " &
               genreBuku(index)

    End Function


    Sub TampilkanBuku()

        lstBuku.Items.Clear()

        For i As Integer = 0 To jumlahData - 1
            lstBuku.Items.Add(FormatBuku(i))
        Next

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Dim judul As String = txtJudul.Text
        Dim penulis As String = txtPenulis.Text
        Dim genre As String = txtGenre.Text

        If judul = "" Or penulis = "" Or genre = "" Then
            MessageBox.Show("Data buku harus diisi semua ok")
            Exit Sub
        End If

        TambahBuku(judul, penulis, genre)

        MessageBox.Show("YEAYYY! Buku berhasil ditambahkan")

        txtJudul.Clear()
        txtPenulis.Clear()
        txtGenre.Clear()

        TampilkanBuku()

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        Dim judulCari As String = txtJudulHapus.Text
        Dim ditemukan As Boolean = False

        For i As Integer = 0 To jumlahData - 1

            If judulBuku(i).ToLower = judulCari.ToLower Then

                For j As Integer = i To jumlahData - 2
                    judulBuku(j) = judulBuku(j + 1)
                    penulisBuku(j) = penulisBuku(j + 1)
                    genreBuku(j) = genreBuku(j + 1)
                Next

                jumlahData -= 1
                ditemukan = True
                Exit For

            End If

        Next

        If ditemukan Then
            MessageBox.Show("Buku berhasil dihapus, say byeee")
        Else
            MessageBox.Show("NOOO judul buku tidak ditemukan")
        End If

        TampilkanBuku()

    End Sub
End Class