<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pilih
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
        Me.LbNama = New System.Windows.Forms.Label()
        Me.LbCabang = New System.Windows.Forms.Label()
        Me.LabelOwner = New System.Windows.Forms.Label()
        Me.bLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.bUbah = New Guna.UI2.WinForms.Guna2Button()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbNama
        '
        Me.LbNama.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNama.Location = New System.Drawing.Point(262, 266)
        Me.LbNama.Name = "LbNama"
        Me.LbNama.Size = New System.Drawing.Size(200, 24)
        Me.LbNama.TabIndex = 1
        Me.LbNama.Text = "Tempat"
        Me.LbNama.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LbCabang
        '
        Me.LbCabang.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCabang.Location = New System.Drawing.Point(262, 290)
        Me.LbCabang.Name = "LbCabang"
        Me.LbCabang.Size = New System.Drawing.Size(200, 24)
        Me.LbCabang.TabIndex = 2
        Me.LbCabang.Text = "Mana"
        Me.LbCabang.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelOwner
        '
        Me.LabelOwner.BackColor = System.Drawing.Color.PeachPuff
        Me.LabelOwner.ForeColor = System.Drawing.Color.PeachPuff
        Me.LabelOwner.Location = New System.Drawing.Point(444, 9)
        Me.LabelOwner.Name = "LabelOwner"
        Me.LabelOwner.Size = New System.Drawing.Size(203, 13)
        Me.LabelOwner.TabIndex = 12
        '
        'bLogout
        '
        Me.bLogout.BackColor = System.Drawing.Color.AntiqueWhite
        Me.bLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bLogout.FillColor = System.Drawing.Color.AntiqueWhite
        Me.bLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bLogout.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bLogout.Location = New System.Drawing.Point(565, 9)
        Me.bLogout.Name = "bLogout"
        Me.bLogout.Size = New System.Drawing.Size(146, 45)
        Me.bLogout.TabIndex = 23
        Me.bLogout.Text = "LOGOUT"
        '
        'bUbah
        '
        Me.bUbah.BackColor = System.Drawing.Color.AntiqueWhite
        Me.bUbah.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bUbah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bUbah.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bUbah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bUbah.FillColor = System.Drawing.Color.AntiqueWhite
        Me.bUbah.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bUbah.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bUbah.Location = New System.Drawing.Point(565, 60)
        Me.bUbah.Name = "bUbah"
        Me.bUbah.Size = New System.Drawing.Size(146, 45)
        Me.bUbah.TabIndex = 24
        Me.bUbah.Text = "UBAH"
        '
        'IconButton4
        '
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton4.IconColor = System.Drawing.Color.Black
        Me.IconButton4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton4.Location = New System.Drawing.Point(187, 353)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Size = New System.Drawing.Size(350, 37)
        Me.IconButton4.TabIndex = 16
        Me.IconButton4.Text = "TAMBAH OUTLET"
        Me.IconButton4.UseVisualStyleBackColor = True
        '
        'IconButton3
        '
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton3.IconColor = System.Drawing.Color.Black
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.Location = New System.Drawing.Point(187, 315)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(350, 37)
        Me.IconButton3.TabIndex = 15
        Me.IconButton3.Text = "PILIH OUTLET"
        Me.IconButton3.UseVisualStyleBackColor = True
        '
        'IconButton2
        '
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.ArrowRight
        Me.IconButton2.IconColor = System.Drawing.Color.Black
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.Location = New System.Drawing.Point(468, 261)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(69, 48)
        Me.IconButton2.TabIndex = 14
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'IconButton1
        '
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.Location = New System.Drawing.Point(187, 261)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(69, 48)
        Me.IconButton1.TabIndex = 13
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(262, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Pilih
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(723, 406)
        Me.Controls.Add(Me.bUbah)
        Me.Controls.Add(Me.bLogout)
        Me.Controls.Add(Me.IconButton4)
        Me.Controls.Add(Me.IconButton3)
        Me.Controls.Add(Me.IconButton2)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.LabelOwner)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LbCabang)
        Me.Controls.Add(Me.LbNama)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Pilih"
        Me.Text = "Pilih"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LbNama As Label
    Friend WithEvents LbCabang As Label
    Friend WithEvents LabelOwner As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents bLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bUbah As Guna.UI2.WinForms.Guna2Button
End Class
