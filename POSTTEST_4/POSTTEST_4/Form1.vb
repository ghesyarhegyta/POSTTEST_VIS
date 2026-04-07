Public Class Form1

    Private Sub menuInput_Click(sender As Object, e As EventArgs) Handles menuInput.Click
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub menuLihat_Click(sender As Object, e As EventArgs) Handles menuLihat.Click
        If Validasi() = False Then Exit Sub

        Form2.lblNama.Text = txtNama.Text
        Form2.lblID.Text = txtID.Text
        Form2.lblKomunitas.Text = cbKomunitas.Text
        Form2.lblKontak.Text = mtbTelepon.Text
        Form2.lblHobby.Text = GetHobby()
        Form2.lblRole.Text = GetRole()
        Form2.lblTanggal.Text = dtpTanggal.Value.ToShortDateString()

        Form2.PictureBox1.Image = pbFoto.Image

        Form2.Show()
    End Sub

    Private Sub menuSimpan_Click(sender As Object, e As EventArgs) Handles menuSimpan.Click
        If Validasi() = False Then Exit Sub

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim sw As New IO.StreamWriter(SaveFileDialog1.FileName)

            sw.WriteLine(txtNama.Text)
            sw.WriteLine(txtID.Text)
            sw.WriteLine(cbKomunitas.Text)
            sw.WriteLine(mtbTelepon.Text)
            sw.WriteLine(txtEmail.Text)
            sw.WriteLine(txtAlamat.Text)
            sw.WriteLine(GetRole())
            sw.WriteLine(GetHobby())

            sw.Close()
            MessageBox.Show("YAYYY Data berhasil disimpan (˶˃ ᵕ ˂˶)")
        End If
    End Sub

    Private Sub menuBuka_Click(sender As Object, e As EventArgs) Handles menuBuka.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim sr As New IO.StreamReader(OpenFileDialog1.FileName)

            txtNama.Text = sr.ReadLine()
            txtID.Text = sr.ReadLine()
            cbKomunitas.Text = sr.ReadLine()
            mtbTelepon.Text = sr.ReadLine()
            txtEmail.Text = sr.ReadLine()
            txtAlamat.Text = sr.ReadLine()

            sr.Close()
        End If
    End Sub

    Private Sub menuKeluar_Click(sender As Object, e As EventArgs) Handles menuKeluar.Click
        If MessageBox.Show("(¬`‸´¬) yakin nih mau keluar??", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub


    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.png;*.jpeg"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            pbFoto.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub


    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Function GetRole() As String
        If rbLeader.Checked Then
            Return "Leader"
        ElseIf rbMember.Checked Then
            Return "Member"
        ElseIf rbAdmin.Checked Then
            Return "Admin"
        ElseIf rbModerator.Checked Then
            Return "Moderator"
        Else
            Return ""
        End If
    End Function


    Function GetHobby() As String
        Dim listHobi As New List(Of String)

        If cbMakeup.Checked Then listHobi.Add("Makeup")
        If cbNgoding.Checked Then listHobi.Add("Ngoding")
        If cbTraveling.Checked Then listHobi.Add("Traveling")
        If cbGaming.Checked Then listHobi.Add("Gaming")
        If cbOlahraga.Checked Then listHobi.Add("Olahraga")
        If cbMemasak.Checked Then listHobi.Add("Memasak")
        If cbEditing.Checked Then listHobi.Add("Editing")
        If cbMembaca.Checked Then listHobi.Add("Membaca")

        Return String.Join(", ", listHobi)
    End Function


    Function Validasi() As Boolean

        If txtNama.Text = "" Or txtID.Text = "" Or txtEmail.Text = "" Or txtAlamat.Text = "" Then
            MessageBox.Show("(๑•̀ᗝ•́)૭ Inputan tidak boleh kosong")
            Return False
        End If

        If mtbTelepon.Text.Trim = "" Then
            MessageBox.Show("(๑•̀ᗝ•́)૭ Nomor telepon tidak boleh kosong")
            Return False
        End If

        If GetRole() = "" Then
            MessageBox.Show("(๑•̀ᗝ•́)૭ Pilih role terlebih dahulu")
            Return False
        End If

        If GetHobby() = "" Then
            MessageBox.Show("(๑•̀ᗝ•́)૭ Pilih minimal 1 hobby")
            Return False
        End If

        If pbFoto.Image Is Nothing Then
            MessageBox.Show("(๑•̀ᗝ•́)૭ Upload foto terlebih dahuluuu")
            Return False
        End If

        Return True

    End Function

End Class