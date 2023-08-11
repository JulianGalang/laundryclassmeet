<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaksi
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelTanggal = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.HargaTotal = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbMember = New System.Windows.Forms.TextBox()
        Me.cbMember = New System.Windows.Forms.CheckBox()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.cbJenis = New System.Windows.Forms.ComboBox()
        Me.tbDiskon = New System.Windows.Forms.TextBox()
        Me.rKilo = New System.Windows.Forms.RadioButton()
        Me.rPotong = New System.Windows.Forms.RadioButton()
        Me.cbLayanan = New System.Windows.Forms.ComboBox()
        Me.bTambah = New Guna.UI2.WinForms.Guna2Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.bSimpan = New Guna.UI2.WinForms.Guna2Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbBayar = New System.Windows.Forms.TextBox()
        Me.nmJumlah = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Kembalian = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmJumlah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Member"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jenis Bahan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal"
        '
        'LabelTanggal
        '
        Me.LabelTanggal.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.LabelTanggal.Location = New System.Drawing.Point(200, 15)
        Me.LabelTanggal.Name = "LabelTanggal"
        Me.LabelTanggal.Size = New System.Drawing.Size(241, 25)
        Me.LabelTanggal.TabIndex = 4
        Me.LabelTanggal.Text = "30 September 2023 00.00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(460, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Kembalian"
        '
        'HargaTotal
        '
        Me.HargaTotal.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.HargaTotal.Location = New System.Drawing.Point(585, 18)
        Me.HargaTotal.Name = "HargaTotal"
        Me.HargaTotal.Size = New System.Drawing.Size(183, 25)
        Me.HargaTotal.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(460, 134)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 25)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Diskon"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(460, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 25)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Tipe"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(460, 102)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 25)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Layanan"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(42, 160)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 25)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Jumlah"
        '
        'tbMember
        '
        Me.tbMember.Location = New System.Drawing.Point(205, 59)
        Me.tbMember.Name = "tbMember"
        Me.tbMember.Size = New System.Drawing.Size(210, 20)
        Me.tbMember.TabIndex = 11
        '
        'cbMember
        '
        Me.cbMember.AutoSize = True
        Me.cbMember.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMember.Location = New System.Drawing.Point(205, 43)
        Me.cbMember.Name = "cbMember"
        Me.cbMember.Size = New System.Drawing.Size(98, 17)
        Me.cbMember.TabIndex = 12
        Me.cbMember.Text = "Pakai Member"
        Me.cbMember.UseVisualStyleBackColor = True
        '
        'tbNama
        '
        Me.tbNama.Location = New System.Drawing.Point(205, 94)
        Me.tbNama.Name = "tbNama"
        Me.tbNama.Size = New System.Drawing.Size(210, 20)
        Me.tbNama.TabIndex = 13
        '
        'cbJenis
        '
        Me.cbJenis.FormattingEnabled = True
        Me.cbJenis.Items.AddRange(New Object() {""})
        Me.cbJenis.Location = New System.Drawing.Point(205, 128)
        Me.cbJenis.Name = "cbJenis"
        Me.cbJenis.Size = New System.Drawing.Size(210, 21)
        Me.cbJenis.TabIndex = 14
        '
        'tbDiskon
        '
        Me.tbDiskon.Location = New System.Drawing.Point(590, 134)
        Me.tbDiskon.Name = "tbDiskon"
        Me.tbDiskon.Size = New System.Drawing.Size(178, 20)
        Me.tbDiskon.TabIndex = 15
        '
        'rKilo
        '
        Me.rKilo.AutoSize = True
        Me.rKilo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rKilo.Location = New System.Drawing.Point(590, 79)
        Me.rKilo.Name = "rKilo"
        Me.rKilo.Size = New System.Drawing.Size(60, 17)
        Me.rKilo.TabIndex = 16
        Me.rKilo.TabStop = True
        Me.rKilo.Text = "Perkilo"
        Me.rKilo.UseVisualStyleBackColor = True
        '
        'rPotong
        '
        Me.rPotong.AutoSize = True
        Me.rPotong.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rPotong.Location = New System.Drawing.Point(692, 80)
        Me.rPotong.Name = "rPotong"
        Me.rPotong.Size = New System.Drawing.Size(80, 17)
        Me.rPotong.TabIndex = 17
        Me.rPotong.TabStop = True
        Me.rPotong.Text = "Perpotong"
        Me.rPotong.UseVisualStyleBackColor = True
        '
        'cbLayanan
        '
        Me.cbLayanan.FormattingEnabled = True
        Me.cbLayanan.Items.AddRange(New Object() {" "})
        Me.cbLayanan.Location = New System.Drawing.Point(590, 106)
        Me.cbLayanan.Name = "cbLayanan"
        Me.cbLayanan.Size = New System.Drawing.Size(178, 21)
        Me.cbLayanan.TabIndex = 18
        '
        'bTambah
        '
        Me.bTambah.BackColor = System.Drawing.Color.AntiqueWhite
        Me.bTambah.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bTambah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bTambah.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bTambah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bTambah.FillColor = System.Drawing.Color.AntiqueWhite
        Me.bTambah.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bTambah.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bTambah.Location = New System.Drawing.Point(671, 162)
        Me.bTambah.Name = "bTambah"
        Me.bTambah.Size = New System.Drawing.Size(92, 24)
        Me.bTambah.TabIndex = 20
        Me.bTambah.Text = "Tambah"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeColumns = False
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(47, 189)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(716, 203)
        Me.dgv.TabIndex = 21
        '
        'bSimpan
        '
        Me.bSimpan.BackColor = System.Drawing.Color.AntiqueWhite
        Me.bSimpan.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bSimpan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bSimpan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bSimpan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bSimpan.FillColor = System.Drawing.Color.AntiqueWhite
        Me.bSimpan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSimpan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bSimpan.Location = New System.Drawing.Point(47, 399)
        Me.bSimpan.Name = "bSimpan"
        Me.bSimpan.Size = New System.Drawing.Size(716, 45)
        Me.bSimpan.TabIndex = 22
        Me.bSimpan.Text = "SIMPAN DAN CETAK STRUK"
        '
        'Timer1
        '
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(460, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 25)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Bayar"
        '
        'tbBayar
        '
        Me.tbBayar.Location = New System.Drawing.Point(528, 165)
        Me.tbBayar.Name = "tbBayar"
        Me.tbBayar.Size = New System.Drawing.Size(139, 20)
        Me.tbBayar.TabIndex = 25
        '
        'nmJumlah
        '
        Me.nmJumlah.DecimalPlaces = 2
        Me.nmJumlah.Location = New System.Drawing.Point(205, 163)
        Me.nmJumlah.Name = "nmJumlah"
        Me.nmJumlah.Size = New System.Drawing.Size(210, 20)
        Me.nmJumlah.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(460, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 25)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Harga Total"
        '
        'Kembalian
        '
        Me.Kembalian.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Kembalian.Location = New System.Drawing.Point(585, 43)
        Me.Kembalian.Name = "Kembalian"
        Me.Kembalian.Size = New System.Drawing.Size(183, 25)
        Me.Kembalian.TabIndex = 6
        '
        'Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.nmJumlah)
        Me.Controls.Add(Me.tbBayar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.bSimpan)
        Me.Controls.Add(Me.bTambah)
        Me.Controls.Add(Me.cbLayanan)
        Me.Controls.Add(Me.rPotong)
        Me.Controls.Add(Me.rKilo)
        Me.Controls.Add(Me.tbDiskon)
        Me.Controls.Add(Me.cbJenis)
        Me.Controls.Add(Me.tbNama)
        Me.Controls.Add(Me.cbMember)
        Me.Controls.Add(Me.tbMember)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Kembalian)
        Me.Controls.Add(Me.HargaTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabelTanggal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv)
        Me.Name = "Transaksi"
        Me.Text = "Transaksi"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmJumlah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelTanggal As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents HargaTotal As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents tbMember As TextBox
    Friend WithEvents cbMember As CheckBox
    Friend WithEvents tbNama As TextBox
    Friend WithEvents cbJenis As ComboBox
    Friend WithEvents tbDiskon As TextBox
    Friend WithEvents rKilo As RadioButton
    Friend WithEvents rPotong As RadioButton
    Friend WithEvents cbLayanan As ComboBox
    Friend WithEvents bTambah As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents bSimpan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents tbBayar As TextBox
    Friend WithEvents nmJumlah As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Kembalian As Label
End Class
