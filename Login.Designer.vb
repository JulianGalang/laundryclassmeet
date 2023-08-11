<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.PanelLogin = New System.Windows.Forms.Panel()
        Me.CShow = New System.Windows.Forms.CheckBox()
        Me.BLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.TbPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TbEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelDaftar = New System.Windows.Forms.Panel()
        Me.BDaftar = New Guna.UI2.WinForms.Guna2Button()
        Me.TbTelepon = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RPerempuan = New System.Windows.Forms.RadioButton()
        Me.RLaki = New System.Windows.Forms.RadioButton()
        Me.CshowD = New System.Windows.Forms.CheckBox()
        Me.TbPasswordDaftar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TbEmailDaftar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TbNama = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelLogin.SuspendLayout()
        Me.PanelDaftar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelLogin
        '
        Me.PanelLogin.Controls.Add(Me.CShow)
        Me.PanelLogin.Controls.Add(Me.BLogin)
        Me.PanelLogin.Controls.Add(Me.TbPassword)
        Me.PanelLogin.Controls.Add(Me.TbEmail)
        Me.PanelLogin.Controls.Add(Me.Label1)
        Me.PanelLogin.Location = New System.Drawing.Point(0, -1)
        Me.PanelLogin.Name = "PanelLogin"
        Me.PanelLogin.Size = New System.Drawing.Size(341, 386)
        Me.PanelLogin.TabIndex = 0
        '
        'CShow
        '
        Me.CShow.AutoSize = True
        Me.CShow.Location = New System.Drawing.Point(54, 203)
        Me.CShow.Name = "CShow"
        Me.CShow.Size = New System.Drawing.Size(102, 17)
        Me.CShow.TabIndex = 5
        Me.CShow.Text = "Show Password"
        Me.CShow.UseVisualStyleBackColor = True
        '
        'BLogin
        '
        Me.BLogin.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BLogin.FillColor = System.Drawing.Color.Empty
        Me.BLogin.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLogin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BLogin.Image = Global.laundry_classmeet.My.Resources.Resources.sign_in
        Me.BLogin.Location = New System.Drawing.Point(54, 226)
        Me.BLogin.Name = "BLogin"
        Me.BLogin.Size = New System.Drawing.Size(232, 43)
        Me.BLogin.TabIndex = 4
        Me.BLogin.Text = "SIGN IN"
        '
        'TbPassword
        '
        Me.TbPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbPassword.DefaultText = ""
        Me.TbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbPassword.IconLeft = Global.laundry_classmeet.My.Resources.Resources.padlock
        Me.TbPassword.Location = New System.Drawing.Point(54, 161)
        Me.TbPassword.Margin = New System.Windows.Forms.Padding(5)
        Me.TbPassword.Name = "TbPassword"
        Me.TbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbPassword.PlaceholderText = "Password"
        Me.TbPassword.SelectedText = ""
        Me.TbPassword.Size = New System.Drawing.Size(232, 33)
        Me.TbPassword.TabIndex = 2
        '
        'TbEmail
        '
        Me.TbEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbEmail.DefaultText = ""
        Me.TbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbEmail.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbEmail.IconLeft = Global.laundry_classmeet.My.Resources.Resources.mail
        Me.TbEmail.Location = New System.Drawing.Point(54, 118)
        Me.TbEmail.Margin = New System.Windows.Forms.Padding(5)
        Me.TbEmail.Name = "TbEmail"
        Me.TbEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbEmail.PlaceholderText = "Email"
        Me.TbEmail.SelectedText = ""
        Me.TbEmail.Size = New System.Drawing.Size(232, 33)
        Me.TbEmail.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gilroy ExtraBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(125, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOG IN"
        '
        'PanelDaftar
        '
        Me.PanelDaftar.Controls.Add(Me.BDaftar)
        Me.PanelDaftar.Controls.Add(Me.TbTelepon)
        Me.PanelDaftar.Controls.Add(Me.GroupBox1)
        Me.PanelDaftar.Controls.Add(Me.CshowD)
        Me.PanelDaftar.Controls.Add(Me.TbPasswordDaftar)
        Me.PanelDaftar.Controls.Add(Me.TbEmailDaftar)
        Me.PanelDaftar.Controls.Add(Me.TbNama)
        Me.PanelDaftar.Controls.Add(Me.Label2)
        Me.PanelDaftar.Location = New System.Drawing.Point(385, -1)
        Me.PanelDaftar.Name = "PanelDaftar"
        Me.PanelDaftar.Size = New System.Drawing.Size(327, 386)
        Me.PanelDaftar.TabIndex = 1
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
        Me.BDaftar.Location = New System.Drawing.Point(49, 297)
        Me.BDaftar.Name = "BDaftar"
        Me.BDaftar.Size = New System.Drawing.Size(232, 43)
        Me.BDaftar.TabIndex = 6
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
        Me.TbTelepon.Location = New System.Drawing.Point(49, 214)
        Me.TbTelepon.Margin = New System.Windows.Forms.Padding(5)
        Me.TbTelepon.Name = "TbTelepon"
        Me.TbTelepon.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbTelepon.PlaceholderText = "Telepon"
        Me.TbTelepon.SelectedText = ""
        Me.TbTelepon.Size = New System.Drawing.Size(232, 33)
        Me.TbTelepon.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RPerempuan)
        Me.GroupBox1.Controls.Add(Me.RLaki)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(49, 255)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 42)
        Me.GroupBox1.TabIndex = 8
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
        Me.CshowD.Location = New System.Drawing.Point(49, 198)
        Me.CshowD.Name = "CshowD"
        Me.CshowD.Size = New System.Drawing.Size(102, 17)
        Me.CshowD.TabIndex = 6
        Me.CshowD.Text = "Show Password"
        Me.CshowD.UseVisualStyleBackColor = True
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
        Me.TbPasswordDaftar.Location = New System.Drawing.Point(49, 157)
        Me.TbPasswordDaftar.Margin = New System.Windows.Forms.Padding(5)
        Me.TbPasswordDaftar.Name = "TbPasswordDaftar"
        Me.TbPasswordDaftar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbPasswordDaftar.PlaceholderText = "Password"
        Me.TbPasswordDaftar.SelectedText = ""
        Me.TbPasswordDaftar.Size = New System.Drawing.Size(232, 33)
        Me.TbPasswordDaftar.TabIndex = 6
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
        Me.TbEmailDaftar.Location = New System.Drawing.Point(49, 114)
        Me.TbEmailDaftar.Margin = New System.Windows.Forms.Padding(5)
        Me.TbEmailDaftar.Name = "TbEmailDaftar"
        Me.TbEmailDaftar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbEmailDaftar.PlaceholderText = "Email"
        Me.TbEmailDaftar.SelectedText = ""
        Me.TbEmailDaftar.Size = New System.Drawing.Size(232, 33)
        Me.TbEmailDaftar.TabIndex = 7
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
        Me.TbNama.Location = New System.Drawing.Point(49, 71)
        Me.TbNama.Margin = New System.Windows.Forms.Padding(5)
        Me.TbNama.Name = "TbNama"
        Me.TbNama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbNama.PlaceholderText = "Nama Owner"
        Me.TbNama.SelectedText = ""
        Me.TbNama.Size = New System.Drawing.Size(232, 33)
        Me.TbNama.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gilroy ExtraBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(99, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "REGISTER"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(713, 381)
        Me.Controls.Add(Me.PanelDaftar)
        Me.Controls.Add(Me.PanelLogin)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Login"
        Me.Text = "Owner Login"
        Me.PanelLogin.ResumeLayout(False)
        Me.PanelLogin.PerformLayout()
        Me.PanelDaftar.ResumeLayout(False)
        Me.PanelDaftar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLogin As Panel
    Friend WithEvents TbEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelDaftar As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TbPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CShow As CheckBox
    Friend WithEvents BDaftar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TbTelepon As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RPerempuan As RadioButton
    Friend WithEvents RLaki As RadioButton
    Friend WithEvents CshowD As CheckBox
    Friend WithEvents TbPasswordDaftar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TbEmailDaftar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TbNama As Guna.UI2.WinForms.Guna2TextBox
End Class
