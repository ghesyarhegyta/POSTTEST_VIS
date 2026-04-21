Imports System.Reflection.Emit
Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class Form2

    Dim conn As New MySqlConnection("server=localhost;user id=root;password=;database=nailart")

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Sistem Manajemen Nail Art" & vbCrLf & "Dibuat oleh: Ghesya 💅"

        loadLayanan()
        tampil()
    End Sub

    Sub loadLayanan()
        Dim da As New MySqlDataAdapter("SELECT id, nama, harga FROM layanan", conn)
        Dim dt As New DataTable
        da.Fill(dt)

        cbLayanan.DataSource = dt
        cbLayanan.DisplayMember = "nama"
        cbLayanan.ValueMember = "id"
    End Sub

    Sub tampil()
        Dim query As String = "SELECT pesanan.id_pesanan, layanan.nama AS layanan, pesanan.nama_customer, pesanan.tanggal, pesanan.total " &
                              "FROM pesanan JOIN layanan ON pesanan.id_layanan = layanan.id"

        Dim da As New MySqlDataAdapter(query, conn)
        Dim dt As New DataTable
        da.Fill(dt)
        dgvPesanan.DataSource = dt
    End Sub

    Private Sub cbLayanan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLayanan.SelectedIndexChanged
        Try
            Dim dt As DataTable = cbLayanan.DataSource
            txtTotal.Text = dt.Rows(cbLayanan.SelectedIndex)("harga").ToString()
        Catch
        End Try
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Try
            If txtCustomer.Text = "" Then
                MessageBox.Show("Nama customer wajib diisi!")
                Exit Sub
            End If

            Dim query As String = "INSERT INTO pesanan(id_layanan, nama_customer, tanggal, total) VALUES(@id, @nama, @tgl, @total)"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@id", cbLayanan.SelectedValue)
            cmd.Parameters.AddWithValue("@nama", txtCustomer.Text)
            cmd.Parameters.AddWithValue("@tgl", dtTanggal.Value)
            cmd.Parameters.AddWithValue("@total", Integer.Parse(txtTotal.Text))

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Pesanan berhasil disimpan!")

            tampil()
            kosong()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Sub kosong()
        txtCustomer.Text = ""
        txtTotal.Text = ""
        cbLayanan.SelectedIndex = 0
    End Sub

End Class