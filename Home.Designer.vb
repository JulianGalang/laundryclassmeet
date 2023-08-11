<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BLayanan = New FontAwesome.Sharp.IconButton()
        Me.BTransaksi = New FontAwesome.Sharp.IconButton()
        Me.BMember = New FontAwesome.Sharp.IconButton()
        Me.BUser = New FontAwesome.Sharp.IconButton()
        Me.BDashboard = New FontAwesome.Sharp.IconButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LogoPicture = New System.Windows.Forms.PictureBox()
        Me.DeskPanel = New System.Windows.Forms.Panel()
        Me.lbjamtanggal = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.blogout = New System.Windows.Forms.Button()
        Me.bganti = New System.Windows.Forms.Button()
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.lbadmin = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.bpanel = New System.Windows.Forms.Button()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.IconTitle = New FontAwesome.Sharp.IconPictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelInfo = New System.Windows.Forms.Panel()
        Me.LabelLevel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelNama = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelCabang = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelNamaToko = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.LogoPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DeskPanel.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.PanelTitle.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.IconTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BLayanan)
        Me.Panel1.Controls.Add(Me.BTransaksi)
        Me.Panel1.Controls.Add(Me.BMember)
        Me.Panel1.Controls.Add(Me.BUser)
        Me.Panel1.Controls.Add(Me.BDashboard)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(153, 1003)
        Me.Panel1.TabIndex = 6
        '
        'BLayanan
        '
        Me.BLayanan.Dock = System.Windows.Forms.DockStyle.Top
        Me.BLayanan.FlatAppearance.BorderSize = 0
        Me.BLayanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BLayanan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLayanan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BLayanan.IconChar = FontAwesome.Sharp.IconChar.JugDetergent
        Me.BLayanan.IconColor = System.Drawing.Color.Black
        Me.BLayanan.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BLayanan.IconSize = 30
        Me.BLayanan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BLayanan.Location = New System.Drawing.Point(0, 268)
        Me.BLayanan.Name = "BLayanan"
        Me.BLayanan.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BLayanan.Size = New System.Drawing.Size(153, 42)
        Me.BLayanan.TabIndex = 9
        Me.BLayanan.Text = "Layanan"
        Me.BLayanan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BLayanan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BLayanan.UseVisualStyleBackColor = True
        '
        'BTransaksi
        '
        Me.BTransaksi.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTransaksi.FlatAppearance.BorderSize = 0
        Me.BTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTransaksi.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTransaksi.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BTransaksi.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer
        Me.BTransaksi.IconColor = System.Drawing.Color.Black
        Me.BTransaksi.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BTransaksi.IconSize = 30
        Me.BTransaksi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTransaksi.Location = New System.Drawing.Point(0, 226)
        Me.BTransaksi.Name = "BTransaksi"
        Me.BTransaksi.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BTransaksi.Size = New System.Drawing.Size(153, 42)
        Me.BTransaksi.TabIndex = 7
        Me.BTransaksi.Text = "Transaksi"
        Me.BTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTransaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTransaksi.UseVisualStyleBackColor = True
        '
        'BMember
        '
        Me.BMember.Dock = System.Windows.Forms.DockStyle.Top
        Me.BMember.FlatAppearance.BorderSize = 0
        Me.BMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BMember.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BMember.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BMember.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup
        Me.BMember.IconColor = System.Drawing.Color.Black
        Me.BMember.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BMember.IconSize = 30
        Me.BMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BMember.Location = New System.Drawing.Point(0, 184)
        Me.BMember.Name = "BMember"
        Me.BMember.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BMember.Size = New System.Drawing.Size(153, 42)
        Me.BMember.TabIndex = 4
        Me.BMember.Text = "Member"
        Me.BMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BMember.UseVisualStyleBackColor = True
        '
        'BUser
        '
        Me.BUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.BUser.FlatAppearance.BorderSize = 0
        Me.BUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BUser.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUser.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BUser.IconChar = FontAwesome.Sharp.IconChar.User
        Me.BUser.IconColor = System.Drawing.Color.Black
        Me.BUser.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BUser.IconSize = 30
        Me.BUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BUser.Location = New System.Drawing.Point(0, 142)
        Me.BUser.Name = "BUser"
        Me.BUser.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BUser.Size = New System.Drawing.Size(153, 42)
        Me.BUser.TabIndex = 3
        Me.BUser.Text = "User"
        Me.BUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BUser.UseVisualStyleBackColor = True
        '
        'BDashboard
        '
        Me.BDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.BDashboard.FlatAppearance.BorderSize = 0
        Me.BDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BDashboard.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BDashboard.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BDashboard.IconChar = FontAwesome.Sharp.IconChar.LineChart
        Me.BDashboard.IconColor = System.Drawing.Color.Black
        Me.BDashboard.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BDashboard.IconSize = 30
        Me.BDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BDashboard.Location = New System.Drawing.Point(0, 100)
        Me.BDashboard.Name = "BDashboard"
        Me.BDashboard.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BDashboard.Size = New System.Drawing.Size(153, 42)
        Me.BDashboard.TabIndex = 2
        Me.BDashboard.Text = "Dashboard"
        Me.BDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BDashboard.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LogoPicture)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(153, 100)
        Me.Panel2.TabIndex = 0
        '
        'LogoPicture
        '
        Me.LogoPicture.Image = Global.laundry_classmeet.My.Resources.Resources._20230613_072242
        Me.LogoPicture.Location = New System.Drawing.Point(0, 0)
        Me.LogoPicture.Name = "LogoPicture"
        Me.LogoPicture.Size = New System.Drawing.Size(153, 100)
        Me.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoPicture.TabIndex = 0
        Me.LogoPicture.TabStop = False
        '
        'DeskPanel
        '
        Me.DeskPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeskPanel.BackColor = System.Drawing.Color.PeachPuff
        Me.DeskPanel.Controls.Add(Me.lbjamtanggal)
        Me.DeskPanel.Controls.Add(Me.Panel5)
        Me.DeskPanel.Location = New System.Drawing.Point(151, 43)
        Me.DeskPanel.Name = "DeskPanel"
        Me.DeskPanel.Size = New System.Drawing.Size(1583, 929)
        Me.DeskPanel.TabIndex = 8
        '
        'lbjamtanggal
        '
        Me.lbjamtanggal.Font = New System.Drawing.Font("Gilroy ExtraBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbjamtanggal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbjamtanggal.Location = New System.Drawing.Point(29, 191)
        Me.lbjamtanggal.Name = "lbjamtanggal"
        Me.lbjamtanggal.Size = New System.Drawing.Size(752, 33)
        Me.lbjamtanggal.TabIndex = 10
        Me.lbjamtanggal.Text = "dd MM yyyy || HH mm ss"
        Me.lbjamtanggal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel5.Controls.Add(Me.blogout)
        Me.Panel5.Controls.Add(Me.bganti)
        Me.Panel5.Location = New System.Drawing.Point(608, 0)
        Me.Panel5.MaximumSize = New System.Drawing.Size(200, 98)
        Me.Panel5.MinimumSize = New System.Drawing.Size(200, 51)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 98)
        Me.Panel5.TabIndex = 4
        '
        'blogout
        '
        Me.blogout.Dock = System.Windows.Forms.DockStyle.Top
        Me.blogout.FlatAppearance.BorderSize = 0
        Me.blogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.blogout.Font = New System.Drawing.Font("Gilroy ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.blogout.ForeColor = System.Drawing.SystemColors.ControlText
        Me.blogout.Location = New System.Drawing.Point(0, 47)
        Me.blogout.Name = "blogout"
        Me.blogout.Size = New System.Drawing.Size(200, 47)
        Me.blogout.TabIndex = 1
        Me.blogout.Text = "KELUAR"
        Me.blogout.UseVisualStyleBackColor = True
        '
        'bganti
        '
        Me.bganti.Dock = System.Windows.Forms.DockStyle.Top
        Me.bganti.FlatAppearance.BorderSize = 0
        Me.bganti.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bganti.Font = New System.Drawing.Font("Gilroy ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bganti.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bganti.Location = New System.Drawing.Point(0, 0)
        Me.bganti.Name = "bganti"
        Me.bganti.Size = New System.Drawing.Size(200, 47)
        Me.bganti.TabIndex = 0
        Me.bganti.Text = "Ganti Password"
        Me.bganti.UseVisualStyleBackColor = True
        '
        'PanelTitle
        '
        Me.PanelTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelTitle.Controls.Add(Me.lbadmin)
        Me.PanelTitle.Controls.Add(Me.Panel3)
        Me.PanelTitle.Controls.Add(Me.LabelTitle)
        Me.PanelTitle.Controls.Add(Me.IconTitle)
        Me.PanelTitle.Location = New System.Drawing.Point(0, -1)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(1734, 44)
        Me.PanelTitle.TabIndex = 7
        '
        'lbadmin
        '
        Me.lbadmin.AutoSize = True
        Me.lbadmin.Font = New System.Drawing.Font("Gilroy ExtraBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbadmin.ForeColor = System.Drawing.Color.Cornsilk
        Me.lbadmin.Location = New System.Drawing.Point(622, 21)
        Me.lbadmin.Name = "lbadmin"
        Me.lbadmin.Size = New System.Drawing.Size(0, 26)
        Me.lbadmin.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.bpanel)
        Me.Panel3.Location = New System.Drawing.Point(759, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 47)
        Me.Panel3.TabIndex = 2
        '
        'bpanel
        '
        Me.bpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bpanel.FlatAppearance.BorderSize = 0
        Me.bpanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bpanel.Font = New System.Drawing.Font("Gilroy ExtraBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bpanel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bpanel.Location = New System.Drawing.Point(0, 0)
        Me.bpanel.Name = "bpanel"
        Me.bpanel.Size = New System.Drawing.Size(200, 47)
        Me.bpanel.TabIndex = 0
        Me.bpanel.Text = "MENU"
        Me.bpanel.UseVisualStyleBackColor = True
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Gilroy ExtraBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelTitle.Location = New System.Drawing.Point(211, 9)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(68, 26)
        Me.LabelTitle.TabIndex = 1
        Me.LabelTitle.Text = "Home"
        '
        'IconTitle
        '
        Me.IconTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IconTitle.ForeColor = System.Drawing.Color.Black
        Me.IconTitle.IconChar = FontAwesome.Sharp.IconChar.House
        Me.IconTitle.IconColor = System.Drawing.Color.Black
        Me.IconTitle.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconTitle.Location = New System.Drawing.Point(173, 6)
        Me.IconTitle.Name = "IconTitle"
        Me.IconTitle.Size = New System.Drawing.Size(32, 32)
        Me.IconTitle.TabIndex = 0
        Me.IconTitle.TabStop = False
        '
        'Timer1
        '
        '
        'PanelInfo
        '
        Me.PanelInfo.BackColor = System.Drawing.Color.PeachPuff
        Me.PanelInfo.Controls.Add(Me.LabelLevel)
        Me.PanelInfo.Controls.Add(Me.Label6)
        Me.PanelInfo.Controls.Add(Me.LabelUsername)
        Me.PanelInfo.Controls.Add(Me.Label5)
        Me.PanelInfo.Controls.Add(Me.LabelNama)
        Me.PanelInfo.Controls.Add(Me.Label3)
        Me.PanelInfo.Controls.Add(Me.LabelCabang)
        Me.PanelInfo.Controls.Add(Me.Label4)
        Me.PanelInfo.Controls.Add(Me.LabelNamaToko)
        Me.PanelInfo.Controls.Add(Me.Label1)
        Me.PanelInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelInfo.Location = New System.Drawing.Point(0, 499)
        Me.PanelInfo.Name = "PanelInfo"
        Me.PanelInfo.Size = New System.Drawing.Size(959, 31)
        Me.PanelInfo.TabIndex = 9
        '
        'LabelLevel
        '
        Me.LabelLevel.Location = New System.Drawing.Point(850, 9)
        Me.LabelLevel.Name = "LabelLevel"
        Me.LabelLevel.Size = New System.Drawing.Size(109, 13)
        Me.LabelLevel.TabIndex = 9
        Me.LabelLevel.Text = "Karyawan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(814, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Level :"
        '
        'LabelUsername
        '
        Me.LabelUsername.Location = New System.Drawing.Point(701, 9)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(109, 13)
        Me.LabelUsername.TabIndex = 7
        Me.LabelUsername.Text = "Cibaduyut"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(643, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Username :"
        '
        'LabelNama
        '
        Me.LabelNama.Location = New System.Drawing.Point(540, 9)
        Me.LabelNama.Name = "LabelNama"
        Me.LabelNama.Size = New System.Drawing.Size(97, 13)
        Me.LabelNama.TabIndex = 5
        Me.LabelNama.Text = "Cibaduyut"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(502, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nama :"
        '
        'LabelCabang
        '
        Me.LabelCabang.Location = New System.Drawing.Point(387, 9)
        Me.LabelCabang.Name = "LabelCabang"
        Me.LabelCabang.Size = New System.Drawing.Size(109, 13)
        Me.LabelCabang.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(341, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Cabang :"
        '
        'LabelNamaToko
        '
        Me.LabelNamaToko.Location = New System.Drawing.Point(226, 9)
        Me.LabelNamaToko.Name = "LabelNamaToko"
        Me.LabelNamaToko.Size = New System.Drawing.Size(109, 13)
        Me.LabelNamaToko.TabIndex = 1
        Me.LabelNamaToko.Text = "Julaundry"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(160, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Toko :"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(959, 530)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelTitle)
        Me.Controls.Add(Me.PanelInfo)
        Me.Controls.Add(Me.DeskPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Home"
        Me.Text = "Home"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.LogoPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DeskPanel.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.PanelTitle.ResumeLayout(False)
        Me.PanelTitle.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.IconTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelInfo.ResumeLayout(False)
        Me.PanelInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LogoPicture As PictureBox
    Friend WithEvents DeskPanel As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents blogout As Button
    Friend WithEvents bganti As Button
    Friend WithEvents PanelTitle As Panel
    Friend WithEvents lbadmin As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents bpanel As Button
    Friend WithEvents LabelTitle As Label
    Friend WithEvents IconTitle As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PanelInfo As Panel
    Friend WithEvents LabelLevel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LabelUsername As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelNama As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelCabang As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelNamaToko As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BLayanan As FontAwesome.Sharp.IconButton
    Friend WithEvents BTransaksi As FontAwesome.Sharp.IconButton
    Friend WithEvents BMember As FontAwesome.Sharp.IconButton
    Friend WithEvents BUser As FontAwesome.Sharp.IconButton
    Friend WithEvents BDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents lbjamtanggal As Label
End Class
