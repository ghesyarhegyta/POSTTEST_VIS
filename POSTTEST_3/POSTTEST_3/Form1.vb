Public Class Form1

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFile As New OpenFileDialog
        openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png"

        If openFile.ShowDialog = DialogResult.OK Then
            picFoto.Image = Image.FromFile(openFile.FileName)
        End If
    End Sub


    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub txtTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelepon.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        If txtNama.Text = "" Or txtUmur.Text = "" Or txtTelepon.Text = "" Or txtAlamat.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong (⸝⸝๑﹏๑⸝⸝)")
            Exit Sub
        End If


        If picFoto.Image Is Nothing Then
            MessageBox.Show("Foto tidak boleh kosong (⸝⸝๑﹏๑⸝⸝)")
            Exit Sub
        End If


        If Not rbLaki.Checked And Not rbPerempuan.Checked Then
            MessageBox.Show("Pilih jenis kelamin yaa")
            Exit Sub
        End If


        Dim hobby As String = ""

        For Each ctrl As Control In GroupBoxHobby.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = CType(ctrl, CheckBox)
                If cb.Checked Then
                    hobby &= cb.Text & ", "
                End If
            End If
        Next

        If hobby.EndsWith(", ") Then
            hobby = hobby.Substring(0, hobby.Length - 2)
        End If

        If hobby = "" Then
            MessageBox.Show("Pilih minimal satu hobby yaa")
            Exit Sub
        End If


        Dim gender As String

        If rbLaki.Checked Then
            gender = "Laki-laki"
        Else
            gender = "Perempuan"
        End If


        Dim formHasil As New Form2

        formHasil.lblNama.Text = txtNama.Text
        formHasil.lblUmur.Text = txtUmur.Text
        formHasil.lblTelepon.Text = txtTelepon.Text
        formHasil.lblAlamat.Text = txtAlamat.Text
        formHasil.lblGender.Text = gender
        formHasil.lblHobby.Text = hobby
        formHasil.lblTanggal.Text = dtTanggalLahir.Value.ToShortDateString()

        formHasil.picHasil.Image = picFoto.Image

        formHasil.Show()

    End Sub
End Class