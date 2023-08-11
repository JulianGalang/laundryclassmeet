<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardLayanan
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RSatuan = New System.Windows.Forms.RadioButton()
        Me.RKilo = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.BCetak = New Guna.UI2.WinForms.Guna2Button()
        Me.BHapus = New Guna.UI2.WinForms.Guna2Button()
        Me.BEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.tbLayanan = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TbHarga = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TbNama = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RSatuan)
        Me.GroupBox1.Controls.Add(Me.RKilo)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(286, 189)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 42)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipe"
        '
        'RSatuan
        '
        Me.RSatuan.AutoSize = True
        Me.RSatuan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RSatuan.Location = New System.Drawing.Point(144, 19)
        Me.RSatuan.Name = "RSatuan"
        Me.RSatuan.Size = New System.Drawing.Size(80, 17)
        Me.RSatuan.TabIndex = 1
        Me.RSatuan.TabStop = True
        Me.RSatuan.Text = "Perpotong"
        Me.RSatuan.UseVisualStyleBackColor = True
        '
        'RKilo
        '
        Me.RKilo.AutoSize = True
        Me.RKilo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RKilo.Location = New System.Drawing.Point(17, 19)
        Me.RKilo.Name = "RKilo"
        Me.RKilo.Size = New System.Drawing.Size(60, 17)
        Me.RKilo.TabIndex = 0
        Me.RKilo.TabStop = True
        Me.RKilo.Text = "Perkilo"
        Me.RKilo.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gilroy ExtraBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(310, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 33)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "JENIS BAHAN"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToOrderColumns = True
        Me.dgv.AllowUserToResizeColumns = False
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(16, 287)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(776, 144)
        Me.dgv.TabIndex = 37
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.Empty
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Guna2Button1.Image = Global.laundry_classmeet.My.Resources.Resources.left_arrow
        Me.Guna2Button1.Location = New System.Drawing.Point(16, 12)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(127, 34)
        Me.Guna2Button1.TabIndex = 41
        Me.Guna2Button1.Text = "Kembali"
        '
        'BCetak
        '
        Me.BCetak.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BCetak.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BCetak.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BCetak.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BCetak.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BCetak.FillColor = System.Drawing.Color.Empty
        Me.BCetak.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCetak.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BCetak.Image = Global.laundry_classmeet.My.Resources.Resources.printer
        Me.BCetak.Location = New System.Drawing.Point(560, 237)
        Me.BCetak.Name = "BCetak"
        Me.BCetak.Size = New System.Drawing.Size(232, 43)
        Me.BCetak.TabIndex = 40
        Me.BCetak.Text = "PRINT"
        '
        'BHapus
        '
        Me.BHapus.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BHapus.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BHapus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BHapus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BHapus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BHapus.FillColor = System.Drawing.Color.Empty
        Me.BHapus.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BHapus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BHapus.Image = Global.laundry_classmeet.My.Resources.Resources.remove
        Me.BHapus.Location = New System.Drawing.Point(286, 237)
        Me.BHapus.Name = "BHapus"
        Me.BHapus.Size = New System.Drawing.Size(232, 43)
        Me.BHapus.TabIndex = 39
        Me.BHapus.Text = "DELETE"
        '
        'BEdit
        '
        Me.BEdit.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BEdit.FillColor = System.Drawing.Color.Empty
        Me.BEdit.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BEdit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BEdit.Image = Global.laundry_classmeet.My.Resources.Resources.pen
        Me.BEdit.Location = New System.Drawing.Point(16, 238)
        Me.BEdit.Name = "BEdit"
        Me.BEdit.Size = New System.Drawing.Size(232, 43)
        Me.BEdit.TabIndex = 38
        Me.BEdit.Text = "EDIT"
        '
        'tbLayanan
        '
        Me.tbLayanan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbLayanan.DefaultText = ""
        Me.tbLayanan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbLayanan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbLayanan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbLayanan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbLayanan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbLayanan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLayanan.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbLayanan.IconLeft = Global.laundry_classmeet.My.Resources.Resources.laundry_basket
        Me.tbLayanan.Location = New System.Drawing.Point(286, 148)
        Me.tbLayanan.Margin = New System.Windows.Forms.Padding(5)
        Me.tbLayanan.Name = "tbLayanan"
        Me.tbLayanan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbLayanan.PlaceholderText = "Layanan"
        Me.tbLayanan.SelectedText = ""
        Me.tbLayanan.Size = New System.Drawing.Size(232, 33)
        Me.tbLayanan.TabIndex = 36
        '
        'TbHarga
        '
        Me.TbHarga.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbHarga.DefaultText = ""
        Me.TbHarga.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TbHarga.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TbHarga.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbHarga.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbHarga.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbHarga.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbHarga.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbHarga.IconLeft = Global.laundry_classmeet.My.Resources.Resources.calculator
        Me.TbHarga.Location = New System.Drawing.Point(286, 105)
        Me.TbHarga.Margin = New System.Windows.Forms.Padding(5)
        Me.TbHarga.Name = "TbHarga"
        Me.TbHarga.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbHarga.PlaceholderText = "Harga"
        Me.TbHarga.SelectedText = ""
        Me.TbHarga.Size = New System.Drawing.Size(232, 33)
        Me.TbHarga.TabIndex = 34
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
        Me.TbNama.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbNama.IconLeft = Global.laundry_classmeet.My.Resources.Resources.user
        Me.TbNama.Location = New System.Drawing.Point(286, 62)
        Me.TbNama.Margin = New System.Windows.Forms.Padding(5)
        Me.TbNama.Name = "TbNama"
        Me.TbNama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbNama.PlaceholderText = "Nama Pakaian"
        Me.TbNama.SelectedText = ""
        Me.TbNama.Size = New System.Drawing.Size(232, 33)
        Me.TbNama.TabIndex = 33
        '
        'DashboardLayanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.BCetak)
        Me.Controls.Add(Me.BHapus)
        Me.Controls.Add(Me.BEdit)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tbLayanan)
        Me.Controls.Add(Me.TbHarga)
        Me.Controls.Add(Me.TbNama)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DashboardLayanan"
        Me.Text = "DashboardLayanan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RSatuan As RadioButton
    Friend WithEvents RKilo As RadioButton
    Friend WithEvents tbLayanan As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TbHarga As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TbNama As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BCetak As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BHapus As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
