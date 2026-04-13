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
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtKategori = New System.Windows.Forms.TextBox()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Kategori = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnForm2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(218, 81)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(226, 22)
        Me.txtNama.TabIndex = 0
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(218, 119)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(226, 22)
        Me.txtHarga.TabIndex = 1
        '
        'txtKategori
        '
        Me.txtKategori.Location = New System.Drawing.Point(218, 157)
        Me.txtKategori.Name = "txtKategori"
        Me.txtKategori.Size = New System.Drawing.Size(226, 22)
        Me.txtKategori.TabIndex = 2
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(218, 197)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(226, 22)
        Me.txtCari.TabIndex = 3
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(82, 247)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 4
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(260, 247)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(450, 247)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 6
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(639, 247)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 23)
        Me.btnCari.TabIndex = 7
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'dgvData
        '
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(218, 278)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.RowHeadersWidth = 51
        Me.dgvData.RowTemplate.Height = 24
        Me.dgvData.Size = New System.Drawing.Size(338, 150)
        Me.dgvData.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(106, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(106, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Harga"
        '
        'Kategori
        '
        Me.Kategori.AutoSize = True
        Me.Kategori.Location = New System.Drawing.Point(106, 163)
        Me.Kategori.Name = "Kategori"
        Me.Kategori.Size = New System.Drawing.Size(57, 16)
        Me.Kategori.TabIndex = 11
        Me.Kategori.Text = "Kategori"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(106, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Cari"
        '
        'btnForm2
        '
        Me.btnForm2.Location = New System.Drawing.Point(655, 405)
        Me.btnForm2.Name = "btnForm2"
        Me.btnForm2.Size = New System.Drawing.Size(75, 23)
        Me.btnForm2.TabIndex = 13
        Me.btnForm2.Text = "Form 2"
        Me.btnForm2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightGray
        Me.Label4.Font = New System.Drawing.Font("Lucida Fax", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.HotPink
        Me.Label4.Location = New System.Drawing.Point(176, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(426, 21)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "✦•┈๑⋅⋯SISTEM MANAJEMEN NAIL ART⋯⋅๑┈•✦"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnForm2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Kategori)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.txtKategori)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtNama)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtKategori As TextBox
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnCari As Button
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Kategori As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnForm2 As Button
    Friend WithEvents Label4 As Label
End Class
