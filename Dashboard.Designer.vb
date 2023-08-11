<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.LabelUser = New System.Windows.Forms.Label()
        Me.LabelMember = New System.Windows.Forms.Label()
        Me.LabelLayanan = New System.Windows.Forms.Label()
        Me.LabelPesanan = New System.Windows.Forms.Label()
        Me.LabelPemasukan = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelUser
        '
        Me.LabelUser.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUser.Location = New System.Drawing.Point(36, 260)
        Me.LabelUser.Name = "LabelUser"
        Me.LabelUser.Size = New System.Drawing.Size(155, 23)
        Me.LabelUser.TabIndex = 4
        Me.LabelUser.Text = "Terdapat 300 Karyawan"
        Me.LabelUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelMember
        '
        Me.LabelMember.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMember.Location = New System.Drawing.Point(239, 260)
        Me.LabelMember.Name = "LabelMember"
        Me.LabelMember.Size = New System.Drawing.Size(146, 23)
        Me.LabelMember.TabIndex = 5
        Me.LabelMember.Text = "Terdapat 300 Member"
        Me.LabelMember.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelLayanan
        '
        Me.LabelLayanan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLayanan.Location = New System.Drawing.Point(443, 260)
        Me.LabelLayanan.Name = "LabelLayanan"
        Me.LabelLayanan.Size = New System.Drawing.Size(143, 23)
        Me.LabelLayanan.TabIndex = 6
        Me.LabelLayanan.Text = "Terdapat 300 Layanan"
        Me.LabelLayanan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelPesanan
        '
        Me.LabelPesanan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPesanan.Location = New System.Drawing.Point(635, 260)
        Me.LabelPesanan.Name = "LabelPesanan"
        Me.LabelPesanan.Size = New System.Drawing.Size(143, 40)
        Me.LabelPesanan.TabIndex = 7
        Me.LabelPesanan.Text = "Terdapat 300 Pesanan"
        Me.LabelPesanan.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelPemasukan
        '
        Me.LabelPemasukan.AutoSize = True
        Me.LabelPemasukan.Font = New System.Drawing.Font("Gilroy ExtraBold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPemasukan.Location = New System.Drawing.Point(62, 25)
        Me.LabelPemasukan.Name = "LabelPemasukan"
        Me.LabelPemasukan.Size = New System.Drawing.Size(284, 59)
        Me.LabelPemasukan.TabIndex = 8
        Me.LabelPemasukan.Text = "Pemasukan"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.laundry_classmeet.My.Resources.Resources.clipboard
        Me.PictureBox4.Location = New System.Drawing.Point(655, 157)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.laundry_classmeet.My.Resources.Resources.customer_service
        Me.PictureBox3.Location = New System.Drawing.Point(466, 157)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.laundry_classmeet.My.Resources.Resources.team
        Me.PictureBox2.Location = New System.Drawing.Point(261, 157)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.laundry_classmeet.My.Resources.Resources.user
        Me.PictureBox1.Location = New System.Drawing.Point(63, 157)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LabelPemasukan)
        Me.Controls.Add(Me.LabelPesanan)
        Me.Controls.Add(Me.LabelLayanan)
        Me.Controls.Add(Me.LabelMember)
        Me.Controls.Add(Me.LabelUser)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents LabelUser As Label
    Friend WithEvents LabelMember As Label
    Friend WithEvents LabelLayanan As Label
    Friend WithEvents LabelPesanan As Label
    Friend WithEvents LabelPemasukan As Label
End Class
