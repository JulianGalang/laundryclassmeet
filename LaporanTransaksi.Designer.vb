<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LaporanTransaksi
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
        Me.bbatal = New Guna.UI2.WinForms.Guna2Button()
        Me.bProses = New Guna.UI2.WinForms.Guna2Button()
        Me.bSelesai = New Guna.UI2.WinForms.Guna2Button()
        Me.BCetak = New Guna.UI2.WinForms.Guna2Button()
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
        Me.dgv.Location = New System.Drawing.Point(12, 62)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(776, 339)
        Me.dgv.TabIndex = 39
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
        Me.bbatal.Location = New System.Drawing.Point(558, 11)
        Me.bbatal.Name = "bbatal"
        Me.bbatal.Size = New System.Drawing.Size(232, 43)
        Me.bbatal.TabIndex = 57
        Me.bbatal.Text = "BATAL"
        '
        'bProses
        '
        Me.bProses.BackColor = System.Drawing.Color.AntiqueWhite
        Me.bProses.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bProses.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bProses.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bProses.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bProses.FillColor = System.Drawing.Color.Empty
        Me.bProses.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bProses.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bProses.Image = Global.laundry_classmeet.My.Resources.Resources.data_processing
        Me.bProses.Location = New System.Drawing.Point(13, 13)
        Me.bProses.Name = "bProses"
        Me.bProses.Size = New System.Drawing.Size(232, 43)
        Me.bProses.TabIndex = 56
        Me.bProses.Text = "PROSES"
        '
        'bSelesai
        '
        Me.bSelesai.BackColor = System.Drawing.Color.AntiqueWhite
        Me.bSelesai.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bSelesai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bSelesai.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bSelesai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bSelesai.FillColor = System.Drawing.Color.Empty
        Me.bSelesai.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSelesai.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bSelesai.Image = Global.laundry_classmeet.My.Resources.Resources.checked
        Me.bSelesai.Location = New System.Drawing.Point(288, 12)
        Me.bSelesai.Name = "bSelesai"
        Me.bSelesai.Size = New System.Drawing.Size(232, 43)
        Me.bSelesai.TabIndex = 56
        Me.bSelesai.Text = "SELESAI"
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
        Me.BCetak.Location = New System.Drawing.Point(13, 407)
        Me.BCetak.Name = "BCetak"
        Me.BCetak.Size = New System.Drawing.Size(775, 43)
        Me.BCetak.TabIndex = 43
        Me.BCetak.Text = "PRINT"
        '
        'LaporanTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.bbatal)
        Me.Controls.Add(Me.bProses)
        Me.Controls.Add(Me.bSelesai)
        Me.Controls.Add(Me.BCetak)
        Me.Controls.Add(Me.dgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "LaporanTransaksi"
        Me.Text = "LaporanTransaksi"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents BCetak As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bbatal As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bSelesai As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bProses As Guna.UI2.WinForms.Guna2Button
End Class
