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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuInput = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuLihat = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSimpan = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuBuka = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuKeluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbKomunitas = New System.Windows.Forms.ComboBox()
        Me.rbL = New System.Windows.Forms.RadioButton()
        Me.rbP = New System.Windows.Forms.RadioButton()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.ID = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mtbTelepon = New System.Windows.Forms.MaskedTextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbMembaca = New System.Windows.Forms.CheckBox()
        Me.cbEditing = New System.Windows.Forms.CheckBox()
        Me.cbMemasak = New System.Windows.Forms.CheckBox()
        Me.cbOlahraga = New System.Windows.Forms.CheckBox()
        Me.cbGaming = New System.Windows.Forms.CheckBox()
        Me.cbTraveling = New System.Windows.Forms.CheckBox()
        Me.cbNgoding = New System.Windows.Forms.CheckBox()
        Me.cbMakeup = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbModerator = New System.Windows.Forms.RadioButton()
        Me.rbAdmin = New System.Windows.Forms.RadioButton()
        Me.rbMember = New System.Windows.Forms.RadioButton()
        Me.rbLeader = New System.Windows.Forms.RadioButton()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.pbFoto = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuInput, Me.menuLihat, Me.menuSimpan, Me.menuBuka, Me.menuKeluar})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuInput
        '
        Me.menuInput.Name = "menuInput"
        Me.menuInput.Size = New System.Drawing.Size(93, 24)
        Me.menuInput.Text = "Input Data"
        '
        'menuLihat
        '
        Me.menuLihat.Name = "menuLihat"
        Me.menuLihat.Size = New System.Drawing.Size(94, 24)
        Me.menuLihat.Text = "Lihat Kartu"
        '
        'menuSimpan
        '
        Me.menuSimpan.Name = "menuSimpan"
        Me.menuSimpan.Size = New System.Drawing.Size(109, 24)
        Me.menuSimpan.Text = "Simpan Data"
        '
        'menuBuka
        '
        Me.menuBuka.Name = "menuBuka"
        Me.menuBuka.Size = New System.Drawing.Size(91, 24)
        Me.menuBuka.Text = "Buka Data"
        '
        'menuKeluar
        '
        Me.menuKeluar.Name = "menuKeluar"
        Me.menuKeluar.Size = New System.Drawing.Size(65, 24)
        Me.menuKeluar.Text = "Keluar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Baskerville Old Face", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(298, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CREATE YOUR IDENTITY"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(707, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(28, 127)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(657, 253)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.cbKomunitas)
        Me.TabPage1.Controls.Add(Me.rbL)
        Me.TabPage1.Controls.Add(Me.rbP)
        Me.TabPage1.Controls.Add(Me.dtpTanggal)
        Me.TabPage1.Controls.Add(Me.ID)
        Me.TabPage1.Controls.Add(Me.txtID)
        Me.TabPage1.Controls.Add(Me.txtNama)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(649, 224)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Data Utama"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Komunitas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Tanggal Lahir"
        '
        'cbKomunitas
        '
        Me.cbKomunitas.FormattingEnabled = True
        Me.cbKomunitas.Items.AddRange(New Object() {"Beauty", "Programming", "Gaming", "Design"})
        Me.cbKomunitas.Location = New System.Drawing.Point(180, 162)
        Me.cbKomunitas.Name = "cbKomunitas"
        Me.cbKomunitas.Size = New System.Drawing.Size(121, 24)
        Me.cbKomunitas.TabIndex = 7
        '
        'rbL
        '
        Me.rbL.AutoSize = True
        Me.rbL.Location = New System.Drawing.Point(180, 136)
        Me.rbL.Name = "rbL"
        Me.rbL.Size = New System.Drawing.Size(88, 20)
        Me.rbL.TabIndex = 6
        Me.rbL.TabStop = True
        Me.rbL.Text = "Laki - Laki"
        Me.rbL.UseVisualStyleBackColor = True
        '
        'rbP
        '
        Me.rbP.AutoSize = True
        Me.rbP.Location = New System.Drawing.Point(180, 109)
        Me.rbP.Name = "rbP"
        Me.rbP.Size = New System.Drawing.Size(98, 20)
        Me.rbP.TabIndex = 5
        Me.rbP.TabStop = True
        Me.rbP.Text = "Perempuan"
        Me.rbP.UseVisualStyleBackColor = True
        '
        'dtpTanggal
        '
        Me.dtpTanggal.Location = New System.Drawing.Point(180, 80)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(200, 22)
        Me.dtpTanggal.TabIndex = 4
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Location = New System.Drawing.Point(39, 54)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(20, 16)
        Me.ID.TabIndex = 3
        Me.ID.Text = "ID"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(180, 51)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 22)
        Me.txtID.TabIndex = 2
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(180, 22)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(100, 22)
        Me.txtNama.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtAlamat)
        Me.TabPage2.Controls.Add(Me.txtEmail)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.mtbTelepon)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(649, 224)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Kontak & Info"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(182, 108)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(100, 22)
        Me.txtAlamat.TabIndex = 5
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(182, 62)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 22)
        Me.txtEmail.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(47, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 16)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Alamat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(47, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "No Telepon"
        '
        'mtbTelepon
        '
        Me.mtbTelepon.Location = New System.Drawing.Point(182, 23)
        Me.mtbTelepon.Mask = "0000-0000-0000"
        Me.mtbTelepon.Name = "mtbTelepon"
        Me.mtbTelepon.Size = New System.Drawing.Size(100, 22)
        Me.mtbTelepon.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnCetak)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Controls.Add(Me.btnBrowse)
        Me.TabPage3.Controls.Add(Me.pbFoto)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(649, 224)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Profil & Aktivitas"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnCetak
        '
        Me.btnCetak.Location = New System.Drawing.Point(442, 175)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(172, 23)
        Me.btnCetak.TabIndex = 4
        Me.btnCetak.Text = "Simpan dan Cetak Kartu"
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbMembaca)
        Me.GroupBox2.Controls.Add(Me.cbEditing)
        Me.GroupBox2.Controls.Add(Me.cbMemasak)
        Me.GroupBox2.Controls.Add(Me.cbOlahraga)
        Me.GroupBox2.Controls.Add(Me.cbGaming)
        Me.GroupBox2.Controls.Add(Me.cbTraveling)
        Me.GroupBox2.Controls.Add(Me.cbNgoding)
        Me.GroupBox2.Controls.Add(Me.cbMakeup)
        Me.GroupBox2.Location = New System.Drawing.Point(396, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(218, 126)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hobby"
        '
        'cbMembaca
        '
        Me.cbMembaca.AutoSize = True
        Me.cbMembaca.Location = New System.Drawing.Point(112, 102)
        Me.cbMembaca.Name = "cbMembaca"
        Me.cbMembaca.Size = New System.Drawing.Size(90, 20)
        Me.cbMembaca.TabIndex = 7
        Me.cbMembaca.Text = "Membaca"
        Me.cbMembaca.UseVisualStyleBackColor = True
        '
        'cbEditing
        '
        Me.cbEditing.AutoSize = True
        Me.cbEditing.Location = New System.Drawing.Point(112, 75)
        Me.cbEditing.Name = "cbEditing"
        Me.cbEditing.Size = New System.Drawing.Size(70, 20)
        Me.cbEditing.TabIndex = 6
        Me.cbEditing.Text = "Editing"
        Me.cbEditing.UseVisualStyleBackColor = True
        '
        'cbMemasak
        '
        Me.cbMemasak.AutoSize = True
        Me.cbMemasak.Location = New System.Drawing.Point(112, 47)
        Me.cbMemasak.Name = "cbMemasak"
        Me.cbMemasak.Size = New System.Drawing.Size(89, 20)
        Me.cbMemasak.TabIndex = 5
        Me.cbMemasak.Text = "Memasak"
        Me.cbMemasak.UseVisualStyleBackColor = True
        '
        'cbOlahraga
        '
        Me.cbOlahraga.AutoSize = True
        Me.cbOlahraga.Location = New System.Drawing.Point(112, 21)
        Me.cbOlahraga.Name = "cbOlahraga"
        Me.cbOlahraga.Size = New System.Drawing.Size(85, 20)
        Me.cbOlahraga.TabIndex = 4
        Me.cbOlahraga.Text = "Olahraga"
        Me.cbOlahraga.UseVisualStyleBackColor = True
        '
        'cbGaming
        '
        Me.cbGaming.AutoSize = True
        Me.cbGaming.Location = New System.Drawing.Point(7, 102)
        Me.cbGaming.Name = "cbGaming"
        Me.cbGaming.Size = New System.Drawing.Size(76, 20)
        Me.cbGaming.TabIndex = 3
        Me.cbGaming.Text = "Gaming"
        Me.cbGaming.UseVisualStyleBackColor = True
        '
        'cbTraveling
        '
        Me.cbTraveling.AutoSize = True
        Me.cbTraveling.Location = New System.Drawing.Point(7, 76)
        Me.cbTraveling.Name = "cbTraveling"
        Me.cbTraveling.Size = New System.Drawing.Size(86, 20)
        Me.cbTraveling.TabIndex = 2
        Me.cbTraveling.Text = "Traveling"
        Me.cbTraveling.UseVisualStyleBackColor = True
        '
        'cbNgoding
        '
        Me.cbNgoding.AutoSize = True
        Me.cbNgoding.Location = New System.Drawing.Point(7, 48)
        Me.cbNgoding.Name = "cbNgoding"
        Me.cbNgoding.Size = New System.Drawing.Size(81, 20)
        Me.cbNgoding.TabIndex = 1
        Me.cbNgoding.Text = "Ngoding"
        Me.cbNgoding.UseVisualStyleBackColor = True
        '
        'cbMakeup
        '
        Me.cbMakeup.AutoSize = True
        Me.cbMakeup.Location = New System.Drawing.Point(7, 22)
        Me.cbMakeup.Name = "cbMakeup"
        Me.cbMakeup.Size = New System.Drawing.Size(84, 20)
        Me.cbMakeup.TabIndex = 0
        Me.cbMakeup.Text = "Make Up"
        Me.cbMakeup.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbModerator)
        Me.GroupBox1.Controls.Add(Me.rbAdmin)
        Me.GroupBox1.Controls.Add(Me.rbMember)
        Me.GroupBox1.Controls.Add(Me.rbLeader)
        Me.GroupBox1.Location = New System.Drawing.Point(217, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(173, 126)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Role"
        '
        'rbModerator
        '
        Me.rbModerator.AutoSize = True
        Me.rbModerator.Location = New System.Drawing.Point(17, 98)
        Me.rbModerator.Name = "rbModerator"
        Me.rbModerator.Size = New System.Drawing.Size(90, 20)
        Me.rbModerator.TabIndex = 3
        Me.rbModerator.TabStop = True
        Me.rbModerator.Text = "Moderator"
        Me.rbModerator.UseVisualStyleBackColor = True
        '
        'rbAdmin
        '
        Me.rbAdmin.AutoSize = True
        Me.rbAdmin.Location = New System.Drawing.Point(17, 72)
        Me.rbAdmin.Name = "rbAdmin"
        Me.rbAdmin.Size = New System.Drawing.Size(66, 20)
        Me.rbAdmin.TabIndex = 2
        Me.rbAdmin.TabStop = True
        Me.rbAdmin.Text = "Admin"
        Me.rbAdmin.UseVisualStyleBackColor = True
        '
        'rbMember
        '
        Me.rbMember.AutoSize = True
        Me.rbMember.Location = New System.Drawing.Point(17, 46)
        Me.rbMember.Name = "rbMember"
        Me.rbMember.Size = New System.Drawing.Size(78, 20)
        Me.rbMember.TabIndex = 1
        Me.rbMember.TabStop = True
        Me.rbMember.Text = "Member"
        Me.rbMember.UseVisualStyleBackColor = True
        '
        'rbLeader
        '
        Me.rbLeader.AutoSize = True
        Me.rbLeader.Location = New System.Drawing.Point(17, 20)
        Me.rbLeader.Name = "rbLeader"
        Me.rbLeader.Size = New System.Drawing.Size(71, 20)
        Me.rbLeader.TabIndex = 0
        Me.rbLeader.TabStop = True
        Me.rbLeader.Text = "Leader"
        Me.rbLeader.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(73, 175)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'pbFoto
        '
        Me.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbFoto.Location = New System.Drawing.Point(59, 32)
        Me.pbFoto.Name = "pbFoto"
        Me.pbFoto.Size = New System.Drawing.Size(105, 126)
        Me.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFoto.TabIndex = 0
        Me.pbFoto.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents menuInput As ToolStripMenuItem
    Friend WithEvents menuLihat As ToolStripMenuItem
    Friend WithEvents menuSimpan As ToolStripMenuItem
    Friend WithEvents menuBuka As ToolStripMenuItem
    Friend WithEvents menuKeluar As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ID As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents cbKomunitas As ComboBox
    Friend WithEvents rbL As RadioButton
    Friend WithEvents rbP As RadioButton
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents mtbTelepon As MaskedTextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbModerator As RadioButton
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbMember As RadioButton
    Friend WithEvents rbLeader As RadioButton
    Friend WithEvents cbMembaca As CheckBox
    Friend WithEvents cbEditing As CheckBox
    Friend WithEvents cbMemasak As CheckBox
    Friend WithEvents cbOlahraga As CheckBox
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents cbTraveling As CheckBox
    Friend WithEvents cbNgoding As CheckBox
    Friend WithEvents cbMakeup As CheckBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
