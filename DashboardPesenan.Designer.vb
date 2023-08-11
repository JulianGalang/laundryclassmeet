<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardPesenan
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.LabelTanggal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbKodeMember = New System.Windows.Forms.Label()
        Me.lbNama = New System.Windows.Forms.Label()
        Me.lbHargatotal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbKembalian = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbIDTransaksi = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbbayar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbBayar = New System.Windows.Forms.Label()
        Me.lbstatus = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2ButtonSelesai = New Guna.UI2.WinForms.Guna2Button()
        Me.BCetak = New Guna.UI2.WinForms.Guna2Button()
        Me.bbatal = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToOrderColumns = True
        Me.dgv.AllowUserToResizeColumns = False
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 265)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(776, 173)
        Me.dgv.TabIndex = 38
        '
        'LabelTanggal
        '
        Me.LabelTanggal.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.LabelTanggal.Location = New System.Drawing.Point(179, 67)
        Me.LabelTanggal.Name = "LabelTanggal"
        Me.LabelTanggal.Size = New System.Drawing.Size(241, 25)
        Me.LabelTanggal.TabIndex = 42
        Me.LabelTanggal.Text = "30 September 2023 00.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 25)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Tanggal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 25)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 25)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Kode Member"
        '
        'lbKodeMember
        '
        Me.lbKodeMember.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lbKodeMember.Location = New System.Drawing.Point(179, 103)
        Me.lbKodeMember.Name = "lbKodeMember"
        Me.lbKodeMember.Size = New System.Drawing.Size(241, 25)
        Me.lbKodeMember.TabIndex = 43
        Me.lbKodeMember.Text = "30 September 2023 00.00"
        '
        'lbNama
        '
        Me.lbNama.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lbNama.Location = New System.Drawing.Point(179, 140)
        Me.lbNama.Name = "lbNama"
        Me.lbNama.Size = New System.Drawing.Size(241, 25)
        Me.lbNama.TabIndex = 44
        Me.lbNama.Text = "30 September 2023 00.00"
        '
        'lbHargatotal
        '
        Me.lbHargatotal.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lbHargatotal.Location = New System.Drawing.Point(532, 66)
        Me.lbHargatotal.Name = "lbHargatotal"
        Me.lbHargatotal.Size = New System.Drawing.Size(241, 25)
        Me.lbHargatotal.TabIndex = 46
        Me.lbHargatotal.Text = "30 September 2023 00.00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(411, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 25)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Harga Total"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(411, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 25)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Bayar"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbKembalian
        '
        Me.lbKembalian.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lbKembalian.Location = New System.Drawing.Point(532, 142)
        Me.lbKembalian.Name = "lbKembalian"
        Me.lbKembalian.Size = New System.Drawing.Size(241, 25)
        Me.lbKembalian.TabIndex = 50
        Me.lbKembalian.Text = "30 September 2023 00.00"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(411, 142)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 25)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Kembalian"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbIDTransaksi
        '
        Me.lbIDTransaksi.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lbIDTransaksi.Location = New System.Drawing.Point(179, 30)
        Me.lbIDTransaksi.Name = "lbIDTransaksi"
        Me.lbIDTransaksi.Size = New System.Drawing.Size(241, 25)
        Me.lbIDTransaksi.TabIndex = 53
        Me.lbIDTransaksi.Text = "30 September 2023 00.00"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(21, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(119, 25)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "ID Transaksi"
        '
        'tbbayar
        '
        Me.tbbayar.Location = New System.Drawing.Point(184, 175)
        Me.tbbayar.Name = "tbbayar"
        Me.tbbayar.Size = New System.Drawing.Size(564, 20)
        Me.tbbayar.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 25)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Bayar"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbBayar
        '
        Me.lbBayar.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lbBayar.Location = New System.Drawing.Point(532, 103)
        Me.lbBayar.Name = "lbBayar"
        Me.lbBayar.Size = New System.Drawing.Size(241, 25)
        Me.lbBayar.TabIndex = 59
        Me.lbBayar.Text = "30 September 2023 00.00"
        '
        'lbstatus
        '
        Me.lbstatus.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lbstatus.Location = New System.Drawing.Point(532, 30)
        Me.lbstatus.Name = "lbstatus"
        Me.lbstatus.Size = New System.Drawing.Size(241, 25)
        Me.lbstatus.TabIndex = 61
        Me.lbstatus.Text = "30 September 2023 00.00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(411, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 25)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Status"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Guna2ButtonSelesai
        '
        Me.Guna2ButtonSelesai.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Guna2ButtonSelesai.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2ButtonSelesai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2ButtonSelesai.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2ButtonSelesai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2ButtonSelesai.FillColor = System.Drawing.Color.Empty
        Me.Guna2ButtonSelesai.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2ButtonSelesai.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Guna2ButtonSelesai.Image = Global.laundry_classmeet.My.Resources.Resources.remove
        Me.Guna2ButtonSelesai.Location = New System.Drawing.Point(26, 209)
        Me.Guna2ButtonSelesai.Name = "Guna2ButtonSelesai"
        Me.Guna2ButtonSelesai.Size = New System.Drawing.Size(232, 43)
        Me.Guna2ButtonSelesai.TabIndex = 62
        Me.Guna2ButtonSelesai.Text = "SELESAI"
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
        Me.BCetak.Location = New System.Drawing.Point(556, 209)
        Me.BCetak.Name = "BCetak"
        Me.BCetak.Size = New System.Drawing.Size(232, 43)
        Me.BCetak.TabIndex = 56
        Me.BCetak.Text = "PRINT"
        '
        'bbatal
        '
        Me.bbatal.BackColor = System.Drawing.Color.AntiqueWhite
        Me.bbatal.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bbatal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bbatal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bbatal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bbatal.FillColor = System.Drawing.Color.Empty
        Me.bbatal.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bbatal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bbatal.Image = Global.laundry_classmeet.My.Resources.Resources.remove
        Me.bbatal.Location = New System.Drawing.Point(282, 209)
        Me.bbatal.Name = "bbatal"
        Me.bbatal.Size = New System.Drawing.Size(232, 43)
        Me.bbatal.TabIndex = 55
        Me.bbatal.Text = "BATAL"
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
        Me.Guna2Button1.Location = New System.Drawing.Point(1, -2)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(113, 28)
        Me.Guna2Button1.TabIndex = 63
        Me.Guna2Button1.Text = "Kembali"
        '
        'DashboardPesenan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Guna2ButtonSelesai)
        Me.Controls.Add(Me.lbstatus)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbBayar)
        Me.Controls.Add(Me.tbbayar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BCetak)
        Me.Controls.Add(Me.bbatal)
        Me.Controls.Add(Me.lbIDTransaksi)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lbKembalian)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbHargatotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbNama)
        Me.Controls.Add(Me.lbKodeMember)
        Me.Controls.Add(Me.LabelTanggal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DashboardPesenan"
        Me.Text = "DashboardPesenan"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents LabelTanggal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbKodeMember As Label
    Friend WithEvents lbNama As Label
    Friend WithEvents lbHargatotal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbKembalian As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbIDTransaksi As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents BCetak As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bbatal As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbbayar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbBayar As Label
    Friend WithEvents lbstatus As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Guna2ButtonSelesai As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
