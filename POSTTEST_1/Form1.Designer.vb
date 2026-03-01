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
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtIPS = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.labelIPK = New System.Windows.Forms.Label()
        Me.lblPredikat = New System.Windows.Forms.Label()
        Me.txtIPK = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(226, 130)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(158, 21)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Input IP Semester"
        '
        'txtIPS
        '
        Me.txtIPS.Location = New System.Drawing.Point(230, 169)
        Me.txtIPS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtIPS.Name = "txtIPS"
        Me.txtIPS.Size = New System.Drawing.Size(124, 28)
        Me.txtIPS.TabIndex = 1
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(618, 130)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(94, 30)
        Me.btnTambah.TabIndex = 2
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(618, 167)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(94, 30)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'labelIPK
        '
        Me.labelIPK.AutoSize = True
        Me.labelIPK.Location = New System.Drawing.Point(226, 295)
        Me.labelIPK.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelIPK.Name = "labelIPK"
        Me.labelIPK.Size = New System.Drawing.Size(41, 21)
        Me.labelIPK.TabIndex = 4
        Me.labelIPK.Text = "IPK"
        '
        'lblPredikat
        '
        Me.lblPredikat.AutoSize = True
        Me.lblPredikat.Location = New System.Drawing.Point(614, 333)
        Me.lblPredikat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPredikat.Name = "lblPredikat"
        Me.lblPredikat.Size = New System.Drawing.Size(100, 21)
        Me.lblPredikat.TabIndex = 5
        Me.lblPredikat.Text = "Predikat : -"
        '
        'txtIPK
        '
        Me.txtIPK.Location = New System.Drawing.Point(230, 333)
        Me.txtIPK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtIPK.Name = "txtIPK"
        Me.txtIPK.Size = New System.Drawing.Size(124, 28)
        Me.txtIPK.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(1000, 591)
        Me.Controls.Add(Me.txtIPK)
        Me.Controls.Add(Me.lblPredikat)
        Me.Controls.Add(Me.labelIPK)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.txtIPS)
        Me.Controls.Add(Me.label1)
        Me.Font = New System.Drawing.Font("Century", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Ayo Hitung IPK mu!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents txtIPS As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents labelIPK As Label
    Friend WithEvents lblPredikat As Label
    Friend WithEvents txtIPK As TextBox
End Class
