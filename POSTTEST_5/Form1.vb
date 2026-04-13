Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class Form1

    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim dt As DataTable

    Sub koneksi()
        conn = New MySqlConnection("server=localhost;user id=root;password=;database=db_nailart")
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Sub tampilData()
        Call koneksi()
        da = New MySqlDataAdapter("SELECT * FROM nailart", conn)
        dt = New DataTable
        da.Fill(dt)
        dgvData.DataSource = dt
    End Sub

    Sub bersih()
        txtNama.Text = ""
        txtHarga.Text = ""
        txtKategori.Text = ""
        txtCari.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilData()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Call koneksi()
        Dim query As String = "INSERT INTO nailart (nama, harga, kategori) VALUES (@nama, @harga, @kategori)"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@nama", txtNama.Text)
        cmd.Parameters.AddWithValue("@harga", txtHarga.Text)
        cmd.Parameters.AddWithValue("@kategori", txtKategori.Text)
        cmd.ExecuteNonQuery()

        MsgBox("Data berhasil ditambahkan")
        Call tampilData()
        Call bersih()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Call koneksi()
        Dim query As String = "UPDATE nailart SET nama=@nama, harga=@harga, kategori=@kategori WHERE id=@id"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@id", dgvData.CurrentRow.Cells(0).Value)
        cmd.Parameters.AddWithValue("@nama", txtNama.Text)
        cmd.Parameters.AddWithValue("@harga", txtHarga.Text)
        cmd.Parameters.AddWithValue("@kategori", txtKategori.Text)
        cmd.ExecuteNonQuery()

        MsgBox("Data berhasil diupdate")
        Call tampilData()
        Call bersih()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Call koneksi()
        Dim query As String = "DELETE FROM nailart WHERE id=@id"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@id", dgvData.CurrentRow.Cells(0).Value)
        cmd.ExecuteNonQuery()

        MsgBox("Data berhasil dihapus")
        Call tampilData()
        Call bersih()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Call koneksi()
        da = New MySqlDataAdapter("SELECT * FROM nailart WHERE nama LIKE '%" & txtCari.Text & "%'", conn)
        dt = New DataTable
        da.Fill(dt)
        dgvData.DataSource = dt
    End Sub

    Private Sub dgvData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellClick
        txtNama.Text = dgvData.CurrentRow.Cells(1).Value
        txtHarga.Text = dgvData.CurrentRow.Cells(2).Value
        txtKategori.Text = dgvData.CurrentRow.Cells(3).Value
    End Sub

    Private Sub btnForm2_Click(sender As Object, e As EventArgs) Handles btnForm2.Click
        Form2.Show()
    End Sub

End Class