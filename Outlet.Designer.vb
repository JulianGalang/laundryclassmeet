<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Outlet
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LabelWelcome = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbCabang = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TbAlamat = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TbTelepon = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbOwner = New System.Windows.Forms.Label()
        Me.BukaFile = New System.Windows.Forms.OpenFileDialog()
        Me.LabelGambar = New System.Windows.Forms.Label()
        Me.BDaftar = New Guna.UI2.WinForms.Guna2Button()
        Me.TbNama = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelWelcome
        '
        Me.LabelWelcome.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelWelcome.BackColor = System.Drawing.Color.PeachPuff
        Me.LabelWelcome.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWelcome.Location = New System.Drawing.Point(90, 104)
        Me.LabelWelcome.Name = "LabelWelcome"
        Me.LabelWelcome.Size = New System.Drawing.Size(213, 25)
        Me.LabelWelcome.TabIndex = 0
        Me.LabelWelcome.Text = "Selamat Datang Owner"
        Me.LabelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.PeachPuff
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 285)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(274, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Pilih gambar outlet(Opsional)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(478, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 37)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Daftar Outlet"
        '
        'TbCabang
        '
        Me.TbCabang.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbCabang.DefaultText = ""
        Me.TbCabang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TbCabang.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TbCabang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbCabang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbCabang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbCabang.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TbCabang.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbCabang.IconLeft = Global.laundry_classmeet.My.Resources.Resources.hub
        Me.TbCabang.Location = New System.Drawing.Point(422, 146)
        Me.TbCabang.Name = "TbCabang"
        Me.TbCabang.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbCabang.PlaceholderText = "Cabang"
        Me.TbCabang.SelectedText = ""
        Me.TbCabang.Size = New System.Drawing.Size(300, 36)
        Me.TbCabang.TabIndex = 5
        '
        'TbAlamat
        '
        Me.TbAlamat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbAlamat.DefaultText = ""
        Me.TbAlamat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TbAlamat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TbAlamat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbAlamat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbAlamat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbAlamat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TbAlamat.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbAlamat.IconLeft = Global.laundry_classmeet.My.Resources.Resources.map
        Me.TbAlamat.Location = New System.Drawing.Point(422, 188)
        Me.TbAlamat.Name = "TbAlamat"
        Me.TbAlamat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbAlamat.PlaceholderText = "Alamat"
        Me.TbAlamat.SelectedText = ""
        Me.TbAlamat.Size = New System.Drawing.Size(300, 36)
        Me.TbAlamat.TabIndex = 6
        '
        'TbTelepon
        '
        Me.TbTelepon.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbTelepon.DefaultText = ""
        Me.TbTelepon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TbTelepon.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TbTelepon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbTelepon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbTelepon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbTelepon.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TbTelepon.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbTelepon.IconLeft = Global.laundry_classmeet.My.Resources.Resources.phone_call
        Me.TbTelepon.Location = New System.Drawing.Point(422, 230)
        Me.TbTelepon.Name = "TbTelepon"
        Me.TbTelepon.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbTelepon.PlaceholderText = "Telepon"
        Me.TbTelepon.SelectedText = ""
        Me.TbTelepon.Size = New System.Drawing.Size(300, 36)
        Me.TbTelepon.TabIndex = 7
        '
        'lbOwner
        '
        Me.lbOwner.AutoSize = True
        Me.lbOwner.ForeColor = System.Drawing.Color.PeachPuff
        Me.lbOwner.Location = New System.Drawing.Point(708, 9)
        Me.lbOwner.Name = "lbOwner"
        Me.lbOwner.Size = New System.Drawing.Size(39, 13)
        Me.lbOwner.TabIndex = 10
        Me.lbOwner.Text = "Label1"
        Me.lbOwner.Visible = False
        '
        'BukaFile
        '
        Me.BukaFile.FileName = "OpenFileDialog1"
        '
        'LabelGambar
        '
        Me.LabelGambar.AutoSize = True
        Me.LabelGambar.ForeColor = System.Drawing.Color.PeachPuff
        Me.LabelGambar.Location = New System.Drawing.Point(12, 9)
        Me.LabelGambar.Name = "LabelGambar"
        Me.LabelGambar.Size = New System.Drawing.Size(35, 13)
        Me.LabelGambar.TabIndex = 11
        Me.LabelGambar.Text = "huhjhj"
        Me.LabelGambar.Visible = False
        '
        'BDaftar
        '
        Me.BDaftar.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BDaftar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BDaftar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BDaftar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BDaftar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BDaftar.FillColor = System.Drawing.Color.Empty
        Me.BDaftar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BDaftar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BDaftar.Image = Global.laundry_classmeet.My.Resources.Resources.add_user
        Me.BDaftar.Location = New System.Drawing.Point(422, 272)
        Me.BDaftar.Name = "BDaftar"
        Me.BDaftar.Size = New System.Drawing.Size(300, 43)
        Me.BDaftar.TabIndex = 8
        Me.BDaftar.Text = "DAFTAR"
        '
        'TbNama
        '
        Me.TbNama.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbNama.DefaultText = ""
        Me.TbNama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TbNama.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TbNama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbNama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbNama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbNama.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TbNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbNama.IconLeft = Global.laundry_classmeet.My.Resources.Resources.washing_machine
        Me.TbNama.Location = New System.Drawing.Point(422, 104)
        Me.TbNama.Name = "TbNama"
        Me.TbNama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbNama.PlaceholderText = "Nama Outlet"
        Me.TbNama.SelectedText = ""
        Me.TbNama.Size = New System.Drawing.Size(300, 36)
        Me.TbNama.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.laundry_classmeet.My.Resources.Resources.cloud_computing
        Me.PictureBox1.Location = New System.Drawing.Point(119, 132)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Outlet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(779, 424)
        Me.Controls.Add(Me.LabelWelcome)
        Me.Controls.Add(Me.LabelGambar)
        Me.Controls.Add(Me.lbOwner)
        Me.Controls.Add(Me.BDaftar)
        Me.Controls.Add(Me.TbTelepon)
        Me.Controls.Add(Me.TbAlamat)
        Me.Controls.Add(Me.TbCabang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TbNama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Outlet"
        Me.Text = "Outlet"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelWelcome As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TbNama As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TbCabang As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TbAlamat As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TbTelepon As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BDaftar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lbOwner As Label
    Friend WithEvents BukaFile As OpenFileDialog
    Friend WithEvents LabelGambar As Label
End Class
