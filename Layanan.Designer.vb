<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Layanan
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbLayanan = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BDaftar = New Guna.UI2.WinForms.Guna2Button()
        Me.TbHarga = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TbNama = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RSatuan)
        Me.GroupBox1.Controls.Add(Me.RKilo)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(286, 260)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 42)
        Me.GroupBox1.TabIndex = 30
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gilroy ExtraBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(310, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 33)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "JENIS BAHAN"
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
        Me.tbLayanan.Location = New System.Drawing.Point(286, 219)
        Me.tbLayanan.Margin = New System.Windows.Forms.Padding(5)
        Me.tbLayanan.Name = "tbLayanan"
        Me.tbLayanan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbLayanan.PlaceholderText = "Layanan"
        Me.tbLayanan.SelectedText = ""
        Me.tbLayanan.Size = New System.Drawing.Size(232, 33)
        Me.tbLayanan.TabIndex = 31
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
        Me.BDaftar.Image = Global.laundry_classmeet.My.Resources.Resources.server
        Me.BDaftar.Location = New System.Drawing.Point(286, 308)
        Me.BDaftar.Name = "BDaftar"
        Me.BDaftar.Size = New System.Drawing.Size(232, 43)
        Me.BDaftar.TabIndex = 26
        Me.BDaftar.Text = "Input"
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
        Me.TbHarga.Location = New System.Drawing.Point(286, 176)
        Me.TbHarga.Margin = New System.Windows.Forms.Padding(5)
        Me.TbHarga.Name = "TbHarga"
        Me.TbHarga.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbHarga.PlaceholderText = "Harga"
        Me.TbHarga.SelectedText = ""
        Me.TbHarga.Size = New System.Drawing.Size(232, 33)
        Me.TbHarga.TabIndex = 29
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
        Me.TbNama.IconLeft = Global.laundry_classmeet.My.Resources.Resources.material
        Me.TbNama.Location = New System.Drawing.Point(286, 133)
        Me.TbNama.Margin = New System.Windows.Forms.Padding(5)
        Me.TbNama.Name = "TbNama"
        Me.TbNama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbNama.PlaceholderText = "Nama Pakaian"
        Me.TbNama.SelectedText = ""
        Me.TbNama.Size = New System.Drawing.Size(232, 33)
        Me.TbNama.TabIndex = 28
        '
        'Layanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbLayanan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BDaftar)
        Me.Controls.Add(Me.TbHarga)
        Me.Controls.Add(Me.TbNama)
        Me.Name = "Layanan"
        Me.Text = "Layanan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RSatuan As RadioButton
    Friend WithEvents RKilo As RadioButton
    Friend WithEvents BDaftar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TbHarga As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TbNama As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbLayanan As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
End Class
