<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(118, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SISTEM MANAJEMEN NAIL ART"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DeepPink
        Me.Label2.Location = New System.Drawing.Point(117, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(446, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Aplikasi CRUD Data Nail Art menggunakan VB.NET"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(150, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 14)
        Me.Label3.TabIndex = 2
        '
        'btnKembali
        '
        Me.btnKembali.Location = New System.Drawing.Point(563, 314)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(66, 21)
        Me.btnKembali.TabIndex = 3
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Ivory
        Me.Label4.Location = New System.Drawing.Point(189, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(314, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = ". ݁₊ ⊹ . ݁ ⟡ ݁ . ⊹ ₊ ݁.. ݁₊ ⊹ . ݁ ⟡ ݁ . ⊹ ₊ ݁.. ݁₊ ⊹ . ݁ ⟡ ݁ . ⊹ ₊ ݁."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(179, 347)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(314, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = ". ݁₊ ⊹ . ݁ ⟡ ݁ . ⊹ ₊ ݁.. ݁₊ ⊹ . ݁ ⟡ ݁ . ⊹ ₊ ݁.. ݁₊ ⊹ . ݁ ⟡ ݁ . ⊹ ₊ ݁."
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(700, 394)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Mongolian Baiti", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnKembali As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
