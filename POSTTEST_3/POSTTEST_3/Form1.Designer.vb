<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.picFoto = New System.Windows.Forms.PictureBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtUmur = New System.Windows.Forms.TextBox()
        Me.txtTelepon = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbLaki = New System.Windows.Forms.RadioButton()
        Me.rbPerempuan = New System.Windows.Forms.RadioButton()
        Me.GroupBoxHobby = New System.Windows.Forms.GroupBox()
        Me.cbBerburu = New System.Windows.Forms.CheckBox()
        Me.cbTraveling = New System.Windows.Forms.CheckBox()
        Me.cbBerkebun = New System.Windows.Forms.CheckBox()
        Me.cbJournaling = New System.Windows.Forms.CheckBox()
        Me.cbMakeup = New System.Windows.Forms.CheckBox()
        Me.cbShopping = New System.Windows.Forms.CheckBox()
        Me.cbOlahraga = New System.Windows.Forms.CheckBox()
        Me.cbMenggambar = New System.Windows.Forms.CheckBox()
        Me.cbGaming = New System.Windows.Forms.CheckBox()
        Me.cbMemasak = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtTanggalLahir = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxHobby.SuspendLayout()
        Me.SuspendLayout()
        '
        'picFoto
        '
        Me.picFoto.BackColor = System.Drawing.Color.White
        Me.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFoto.Location = New System.Drawing.Point(35, 62)
        Me.picFoto.Name = "picFoto"
        Me.picFoto.Size = New System.Drawing.Size(150, 220)
        Me.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFoto.TabIndex = 0
        Me.picFoto.TabStop = False
        '
        'btnBrowse
        '
        Me.btnBrowse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBrowse.Location = New System.Drawing.Point(66, 324)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(77, 25)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnCetak
        '
        Me.btnCetak.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCetak.Location = New System.Drawing.Point(384, 441)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(144, 25)
        Me.btnCetak.TabIndex = 2
        Me.btnCetak.Text = "Cetak Kartu"
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(371, 62)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(199, 23)
        Me.txtNama.TabIndex = 3
        '
        'txtUmur
        '
        Me.txtUmur.Location = New System.Drawing.Point(371, 95)
        Me.txtUmur.Name = "txtUmur"
        Me.txtUmur.Size = New System.Drawing.Size(199, 23)
        Me.txtUmur.TabIndex = 4
        '
        'txtTelepon
        '
        Me.txtTelepon.Location = New System.Drawing.Point(371, 170)
        Me.txtTelepon.Name = "txtTelepon"
        Me.txtTelepon.Size = New System.Drawing.Size(199, 23)
        Me.txtTelepon.TabIndex = 5
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(371, 203)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(199, 23)
        Me.txtAlamat.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightYellow
        Me.GroupBox1.Controls.Add(Me.rbLaki)
        Me.GroupBox1.Controls.Add(Me.rbPerempuan)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.GroupBox1.Location = New System.Drawing.Point(231, 257)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 107)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Jenis Kelamin"
        '
        'rbLaki
        '
        Me.rbLaki.AutoSize = True
        Me.rbLaki.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbLaki.Location = New System.Drawing.Point(7, 50)
        Me.rbLaki.Name = "rbLaki"
        Me.rbLaki.Size = New System.Drawing.Size(85, 21)
        Me.rbLaki.TabIndex = 1
        Me.rbLaki.TabStop = True
        Me.rbLaki.Text = "Laki Laki"
        Me.rbLaki.UseVisualStyleBackColor = True
        '
        'rbPerempuan
        '
        Me.rbPerempuan.AutoSize = True
        Me.rbPerempuan.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPerempuan.Location = New System.Drawing.Point(7, 23)
        Me.rbPerempuan.Name = "rbPerempuan"
        Me.rbPerempuan.Size = New System.Drawing.Size(96, 21)
        Me.rbPerempuan.TabIndex = 0
        Me.rbPerempuan.TabStop = True
        Me.rbPerempuan.Text = "Perempuan"
        Me.rbPerempuan.UseVisualStyleBackColor = True
        '
        'GroupBoxHobby
        '
        Me.GroupBoxHobby.BackColor = System.Drawing.Color.LightYellow
        Me.GroupBoxHobby.Controls.Add(Me.cbBerburu)
        Me.GroupBoxHobby.Controls.Add(Me.cbTraveling)
        Me.GroupBoxHobby.Controls.Add(Me.cbBerkebun)
        Me.GroupBoxHobby.Controls.Add(Me.cbJournaling)
        Me.GroupBoxHobby.Controls.Add(Me.cbMakeup)
        Me.GroupBoxHobby.Controls.Add(Me.cbShopping)
        Me.GroupBoxHobby.Controls.Add(Me.cbOlahraga)
        Me.GroupBoxHobby.Controls.Add(Me.cbMenggambar)
        Me.GroupBoxHobby.Controls.Add(Me.cbGaming)
        Me.GroupBoxHobby.Controls.Add(Me.cbMemasak)
        Me.GroupBoxHobby.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxHobby.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.GroupBoxHobby.Location = New System.Drawing.Point(450, 257)
        Me.GroupBoxHobby.Name = "GroupBoxHobby"
        Me.GroupBoxHobby.Size = New System.Drawing.Size(301, 162)
        Me.GroupBoxHobby.TabIndex = 8
        Me.GroupBoxHobby.TabStop = False
        Me.GroupBoxHobby.Text = "Hobby"
        '
        'cbBerburu
        '
        Me.cbBerburu.AutoSize = True
        Me.cbBerburu.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBerburu.Location = New System.Drawing.Point(158, 135)
        Me.cbBerburu.Name = "cbBerburu"
        Me.cbBerburu.Size = New System.Drawing.Size(78, 21)
        Me.cbBerburu.TabIndex = 9
        Me.cbBerburu.Text = "Berburu"
        Me.cbBerburu.UseVisualStyleBackColor = True
        '
        'cbTraveling
        '
        Me.cbTraveling.AutoSize = True
        Me.cbTraveling.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTraveling.Location = New System.Drawing.Point(16, 135)
        Me.cbTraveling.Name = "cbTraveling"
        Me.cbTraveling.Size = New System.Drawing.Size(84, 21)
        Me.cbTraveling.TabIndex = 8
        Me.cbTraveling.Text = "Traveling"
        Me.cbTraveling.UseVisualStyleBackColor = True
        '
        'cbBerkebun
        '
        Me.cbBerkebun.AutoSize = True
        Me.cbBerkebun.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBerkebun.Location = New System.Drawing.Point(158, 109)
        Me.cbBerkebun.Name = "cbBerkebun"
        Me.cbBerkebun.Size = New System.Drawing.Size(87, 21)
        Me.cbBerkebun.TabIndex = 7
        Me.cbBerkebun.Text = "Berkebun"
        Me.cbBerkebun.UseVisualStyleBackColor = True
        '
        'cbJournaling
        '
        Me.cbJournaling.AutoSize = True
        Me.cbJournaling.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbJournaling.Location = New System.Drawing.Point(158, 80)
        Me.cbJournaling.Name = "cbJournaling"
        Me.cbJournaling.Size = New System.Drawing.Size(89, 21)
        Me.cbJournaling.TabIndex = 6
        Me.cbJournaling.Text = "Journaling"
        Me.cbJournaling.UseVisualStyleBackColor = True
        '
        'cbMakeup
        '
        Me.cbMakeup.AutoSize = True
        Me.cbMakeup.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMakeup.Location = New System.Drawing.Point(158, 52)
        Me.cbMakeup.Name = "cbMakeup"
        Me.cbMakeup.Size = New System.Drawing.Size(86, 21)
        Me.cbMakeup.TabIndex = 5
        Me.cbMakeup.Text = "Make Up"
        Me.cbMakeup.UseVisualStyleBackColor = True
        '
        'cbShopping
        '
        Me.cbShopping.AutoSize = True
        Me.cbShopping.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbShopping.Location = New System.Drawing.Point(158, 25)
        Me.cbShopping.Name = "cbShopping"
        Me.cbShopping.Size = New System.Drawing.Size(83, 21)
        Me.cbShopping.TabIndex = 4
        Me.cbShopping.Text = "Shopping"
        Me.cbShopping.UseVisualStyleBackColor = True
        '
        'cbOlahraga
        '
        Me.cbOlahraga.AutoSize = True
        Me.cbOlahraga.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOlahraga.Location = New System.Drawing.Point(16, 109)
        Me.cbOlahraga.Name = "cbOlahraga"
        Me.cbOlahraga.Size = New System.Drawing.Size(84, 21)
        Me.cbOlahraga.TabIndex = 3
        Me.cbOlahraga.Text = "Olahraga"
        Me.cbOlahraga.UseVisualStyleBackColor = True
        '
        'cbMenggambar
        '
        Me.cbMenggambar.AutoSize = True
        Me.cbMenggambar.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMenggambar.Location = New System.Drawing.Point(16, 80)
        Me.cbMenggambar.Name = "cbMenggambar"
        Me.cbMenggambar.Size = New System.Drawing.Size(108, 21)
        Me.cbMenggambar.TabIndex = 2
        Me.cbMenggambar.Text = "Menggambar"
        Me.cbMenggambar.UseVisualStyleBackColor = True
        '
        'cbGaming
        '
        Me.cbGaming.AutoSize = True
        Me.cbGaming.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGaming.Location = New System.Drawing.Point(16, 52)
        Me.cbGaming.Name = "cbGaming"
        Me.cbGaming.Size = New System.Drawing.Size(75, 21)
        Me.cbGaming.TabIndex = 1
        Me.cbGaming.Text = "Gaming"
        Me.cbGaming.UseVisualStyleBackColor = True
        '
        'cbMemasak
        '
        Me.cbMemasak.AutoSize = True
        Me.cbMemasak.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMemasak.Location = New System.Drawing.Point(16, 25)
        Me.cbMemasak.Name = "cbMemasak"
        Me.cbMemasak.Size = New System.Drawing.Size(88, 21)
        Me.cbMemasak.TabIndex = 0
        Me.cbMemasak.Text = "Memasak"
        Me.cbMemasak.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(211, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(211, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Umur"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(211, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "No Telepon"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(211, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Alamat"
        '
        'dtTanggalLahir
        '
        Me.dtTanggalLahir.Location = New System.Drawing.Point(371, 135)
        Me.dtTanggalLahir.Name = "dtTanggalLahir"
        Me.dtTanggalLahir.Size = New System.Drawing.Size(199, 23)
        Me.dtTanggalLahir.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(211, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Tanggal Lahir"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("STLiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(108, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(605, 31)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "⋆.˚ ☾⭒.˚ Fill in your details to create your member card !!"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(12, 446)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 23)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "ᓚ₍⑅^..^₎♡"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Consolas", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(676, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 15)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "(˶ˆᗜˆ˵)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(49, 288)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 15)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Choose Your Best Photo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 478)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtTanggalLahir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBoxHobby)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtTelepon)
        Me.Controls.Add(Me.txtUmur)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.picFoto)
        Me.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Form1"
        Me.Text = "Cmon Join the Community"
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBoxHobby.ResumeLayout(False)
        Me.GroupBoxHobby.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picFoto As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnCetak As Button
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtTelepon As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBoxHobby As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents cbMenggambar As CheckBox
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents cbMemasak As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbMakeup As CheckBox
    Friend WithEvents cbShopping As CheckBox
    Friend WithEvents cbOlahraga As CheckBox
    Friend WithEvents cbJournaling As CheckBox
    Friend WithEvents cbBerburu As CheckBox
    Friend WithEvents cbTraveling As CheckBox
    Friend WithEvents cbBerkebun As CheckBox
    Friend WithEvents dtTanggalLahir As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
