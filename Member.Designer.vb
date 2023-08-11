<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Member
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
        Me.RPerempuan = New System.Windows.Forms.RadioButton()
        Me.RLaki = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BDaftar = New Guna.UI2.WinForms.Guna2Button()
        Me.TbTelepon = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TbAlamat = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TbNama = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RPerempuan)
        Me.GroupBox1.Controls.Add(Me.RLaki)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(284, 254)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 42)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Jenis Kelamin"
        '
        'RPerempuan
        '
        Me.RPerempuan.AutoSize = True
        Me.RPerempuan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RPerempuan.Location = New System.Drawing.Point(122, 19)
        Me.RPerempuan.Name = "RPerempuan"
        Me.RPerempuan.Size = New System.Drawing.Size(83, 17)
        Me.RPerempuan.TabIndex = 1
        Me.RPerempuan.TabStop = True
        Me.RPerempuan.Text = "Perempuan"
        Me.RPerempuan.UseVisualStyleBackColor = True
        '
        'RLaki
        '
        Me.RLaki.AutoSize = True
        Me.RLaki.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RLaki.Location = New System.Drawing.Point(6, 19)
        Me.RLaki.Name = "RLaki"
        Me.RLaki.Size = New System.Drawing.Size(75, 17)
        Me.RLaki.TabIndex = 0
        Me.RLaki.TabStop = True
        Me.RLaki.Text = "Laki - Laki"
        Me.RLaki.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gilroy ExtraBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(278, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 33)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "REGISTER MEMBER"
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
        Me.BDaftar.Location = New System.Drawing.Point(284, 302)
        Me.BDaftar.Name = "BDaftar"
        Me.BDaftar.Size = New System.Drawing.Size(232, 43)
        Me.BDaftar.TabIndex = 19
        Me.BDaftar.Text = "SIGN UP"
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
        Me.TbTelepon.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbTelepon.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbTelepon.IconLeft = Global.laundry_classmeet.My.Resources.Resources.phone_call
        Me.TbTelepon.Location = New System.Drawing.Point(284, 213)
        Me.TbTelepon.Margin = New System.Windows.Forms.Padding(5)
        Me.TbTelepon.Name = "TbTelepon"
        Me.TbTelepon.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbTelepon.PlaceholderText = "Telepon"
        Me.TbTelepon.SelectedText = ""
        Me.TbTelepon.Size = New System.Drawing.Size(232, 33)
        Me.TbTelepon.TabIndex = 21
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
        Me.TbAlamat.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbAlamat.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbAlamat.IconLeft = Global.laundry_classmeet.My.Resources.Resources.map
        Me.TbAlamat.Location = New System.Drawing.Point(284, 170)
        Me.TbAlamat.Margin = New System.Windows.Forms.Padding(5)
        Me.TbAlamat.Name = "TbAlamat"
        Me.TbAlamat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbAlamat.PlaceholderText = "Alamat"
        Me.TbAlamat.SelectedText = ""
        Me.TbAlamat.Size = New System.Drawing.Size(232, 33)
        Me.TbAlamat.TabIndex = 23
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
        Me.TbNama.Location = New System.Drawing.Point(284, 127)
        Me.TbNama.Margin = New System.Windows.Forms.Padding(5)
        Me.TbNama.Name = "TbNama"
        Me.TbNama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbNama.PlaceholderText = "Nama"
        Me.TbNama.SelectedText = ""
        Me.TbNama.Size = New System.Drawing.Size(232, 33)
        Me.TbNama.TabIndex = 22
        '
        'Member
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BDaftar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TbTelepon)
        Me.Controls.Add(Me.TbAlamat)
        Me.Controls.Add(Me.TbNama)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Member"
        Me.Text = "Member"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BDaftar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RPerempuan As RadioButton
    Friend WithEvents RLaki As RadioButton
    Friend WithEvents TbTelepon As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TbAlamat As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TbNama As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
End Class
