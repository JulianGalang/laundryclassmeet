<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pengaturan
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.blogin = New System.Windows.Forms.Button()
        Me.tbpasslama = New System.Windows.Forms.TextBox()
        Me.tbpassbaru = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.PeachPuff
        Me.Label3.Font = New System.Drawing.Font("Gilroy ExtraBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(290, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 29)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Password Baru"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.PeachPuff
        Me.Label2.Font = New System.Drawing.Font("Gilroy ExtraBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(290, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 29)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Password Lama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PeachPuff
        Me.Label1.Font = New System.Drawing.Font("Gilroy ExtraBold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(281, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 39)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Ubah Password"
        '
        'blogin
        '
        Me.blogin.BackColor = System.Drawing.Color.CornflowerBlue
        Me.blogin.FlatAppearance.BorderSize = 0
        Me.blogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.blogin.Font = New System.Drawing.Font("Gilroy ExtraBold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.blogin.ForeColor = System.Drawing.Color.Cornsilk
        Me.blogin.Location = New System.Drawing.Point(295, 288)
        Me.blogin.Name = "blogin"
        Me.blogin.Size = New System.Drawing.Size(224, 39)
        Me.blogin.TabIndex = 42
        Me.blogin.Text = "UBAH"
        Me.blogin.UseVisualStyleBackColor = False
        '
        'tbpasslama
        '
        Me.tbpasslama.Location = New System.Drawing.Point(295, 191)
        Me.tbpasslama.Name = "tbpasslama"
        Me.tbpasslama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbpasslama.Size = New System.Drawing.Size(224, 20)
        Me.tbpasslama.TabIndex = 40
        '
        'tbpassbaru
        '
        Me.tbpassbaru.Location = New System.Drawing.Point(295, 262)
        Me.tbpassbaru.Name = "tbpassbaru"
        Me.tbpassbaru.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbpassbaru.Size = New System.Drawing.Size(224, 20)
        Me.tbpassbaru.TabIndex = 41
        '
        'Pengaturan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.blogin)
        Me.Controls.Add(Me.tbpasslama)
        Me.Controls.Add(Me.tbpassbaru)
        Me.Name = "Pengaturan"
        Me.Text = "Pengaturan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents blogin As Button
    Friend WithEvents tbpasslama As TextBox
    Friend WithEvents tbpassbaru As TextBox
End Class
