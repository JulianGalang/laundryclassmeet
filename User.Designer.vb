<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class User
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RPerempuan = New System.Windows.Forms.RadioButton()
        Me.RLaki = New System.Windows.Forms.RadioButton()
        Me.CshowD = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BDaftar = New Guna.UI2.WinForms.Guna2Button()
        Me.TbTelepon = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TbPasswordDaftar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TbEmailDaftar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TbNama = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RPerempuan)
        Me.GroupBox1.Controls.Add(Me.RLaki)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(284, 287)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 42)
        Me.GroupBox1.TabIndex = 16
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
        'CshowD
        '
        Me.CshowD.AutoSize = True
        Me.CshowD.Location = New System.Drawing.Point(284, 230)
        Me.CshowD.Name = "CshowD"
        Me.CshowD.Size = New System.Drawing.Size(102, 17)
        Me.CshowD.TabIndex = 12
        Me.CshowD.Text = "Show Password"
        Me.CshowD.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gilroy ExtraBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(297, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 33)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "REGISTER USER"
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
        Me.BDaftar.Location = New System.Drawing.Point(284, 329)
        Me.BDaftar.Name = "BDaftar"
        Me.BDaftar.Size = New System.Drawing.Size(232, 43)
        Me.BDaftar.TabIndex = 11
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
        Me.TbTelepon.Location = New System.Drawing.Point(284, 246)
        Me.TbTelepon.Margin = New System.Windows.Forms.Padding(5)
        Me.TbTelepon.Name = "TbTelepon"
        Me.TbTelepon.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbTelepon.PlaceholderText = "Telepon"
        Me.TbTelepon.SelectedText = ""
        Me.TbTelepon.Size = New System.Drawing.Size(232, 33)
        Me.TbTelepon.TabIndex = 17
        '
        'TbPasswordDaftar
        '
        Me.TbPasswordDaftar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbPasswordDaftar.DefaultText = ""
        Me.TbPasswordDaftar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TbPasswordDaftar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TbPasswordDaftar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbPasswordDaftar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbPasswordDaftar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbPasswordDaftar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbPasswordDaftar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbPasswordDaftar.IconLeft = Global.laundry_classmeet.My.Resources.Resources.padlock
        Me.TbPasswordDaftar.Location = New System.Drawing.Point(284, 189)
        Me.TbPasswordDaftar.Margin = New System.Windows.Forms.Padding(5)
        Me.TbPasswordDaftar.Name = "TbPasswordDaftar"
        Me.TbPasswordDaftar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbPasswordDaftar.PlaceholderText = "Password"
        Me.TbPasswordDaftar.SelectedText = ""
        Me.TbPasswordDaftar.Size = New System.Drawing.Size(232, 33)
        Me.TbPasswordDaftar.TabIndex = 13
        '
        'TbEmailDaftar
        '
        Me.TbEmailDaftar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbEmailDaftar.DefaultText = ""
        Me.TbEmailDaftar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TbEmailDaftar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TbEmailDaftar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbEmailDaftar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbEmailDaftar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbEmailDaftar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbEmailDaftar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbEmailDaftar.IconLeft = Global.laundry_classmeet.My.Resources.Resources.mail
        Me.TbEmailDaftar.Location = New System.Drawing.Point(284, 146)
        Me.TbEmailDaftar.Margin = New System.Windows.Forms.Padding(5)
        Me.TbEmailDaftar.Name = "TbEmailDaftar"
        Me.TbEmailDaftar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbEmailDaftar.PlaceholderText = "Username"
        Me.TbEmailDaftar.SelectedText = ""
        Me.TbEmailDaftar.Size = New System.Drawing.Size(232, 33)
        Me.TbEmailDaftar.TabIndex = 15
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
        Me.TbNama.Location = New System.Drawing.Point(284, 103)
        Me.TbNama.Margin = New System.Windows.Forms.Padding(5)
        Me.TbNama.Name = "TbNama"
        Me.TbNama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbNama.PlaceholderText = "Nama Karyawan"
        Me.TbNama.SelectedText = ""
        Me.TbNama.Size = New System.Drawing.Size(232, 33)
        Me.TbNama.TabIndex = 14
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BDaftar)
        Me.Controls.Add(Me.TbTelepon)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CshowD)
        Me.Controls.Add(Me.TbPasswordDaftar)
        Me.Controls.Add(Me.TbEmailDaftar)
        Me.Controls.Add(Me.TbNama)
        Me.Controls.Add(Me.Label2)
        Me.Name = "User"
        Me.Text = "User"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BDaftar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TbTelepon As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RPerempuan As RadioButton
    Friend WithEvents RLaki As RadioButton
    Friend WithEvents CshowD As CheckBox
    Friend WithEvents TbPasswordDaftar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TbEmailDaftar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TbNama As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
End Class
