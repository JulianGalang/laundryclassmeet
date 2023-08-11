Imports System.Data.Odbc
Imports System.Runtime.InteropServices
Imports System.Xml
Imports FontAwesome.Sharp
Public Class Home
    Dim gambar As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Timer1.Start()
        Panel5.Visible = False
        If LabelLevel.Text = "Owner" Then
            Panel5.Size = New Size(200, 98)
            bganti.Visible = True
        ElseIf LabelLevel.Text = "Karyawan" Then
            Panel5.Size = New Size(200, 51)
            bganti.Visible = False
            BUser.Visible = False
        End If
    End Sub
    'Sub nya ngab
    Private tombolini As IconButton
    Private panelkiri As Panel
    Private formini As Form
    'landasan
    Public Sub New()

        ' Panggil ini untuk desain
        InitializeComponent()

        ' isi dari initialize component
        panelkiri = New Panel
        panelkiri.Size = New Size(7, 42)
        Panel1.Controls.Add(panelkiri)

    End Sub
    Private Sub AktifasiButton(senderBtn As Object, Warnakustom As Color)
        If senderBtn IsNot Nothing Then
            matikanbuton()
            'tombol
            tombolini = CType(senderBtn, IconButton)
            tombolini.BackColor = Color.PeachPuff
            tombolini.ForeColor = Warnakustom
            tombolini.IconColor = Warnakustom
            tombolini.TextAlign = ContentAlignment.MiddleCenter
            tombolini.ImageAlign = ContentAlignment.MiddleRight
            tombolini.TextImageRelation = TextImageRelation.TextBeforeImage
            'borderkiri
            panelkiri.BackColor = Warnakustom
            panelkiri.Location = New Point(0, tombolini.Location.Y)
            panelkiri.Visible = True
            panelkiri.BringToFront()
            'iconoh
            IconTitle.IconChar = tombolini.IconChar
            IconTitle.IconColor = Warnakustom
        End If
    End Sub
    Public Sub bukaformlain(Formlain As Form)
        If formini IsNot Nothing Then
            formini.Close()
        End If
        formini = Formlain
        'end
        formini.TopLevel = False
        formini.FormBorderStyle = FormBorderStyle.None
        formini.Dock = DockStyle.Fill
        DeskPanel.Controls.Add(Formlain)
        DeskPanel.Tag = Formlain
        Formlain.BringToFront()
        Formlain.Show()
        LabelTitle.Text = Formlain.Text
    End Sub
    Private Sub matikanbuton()
        If tombolini IsNot Nothing Then
            tombolini.BackColor = Color.FromArgb(171, 196, 255)
            tombolini.ForeColor = Color.Black
            tombolini.IconColor = Color.Black
            tombolini.TextAlign = ContentAlignment.MiddleLeft
            tombolini.ImageAlign = ContentAlignment.MiddleLeft
            tombolini.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub BDashboard_Click(sender As Object, e As EventArgs) Handles BDashboard.Click
        AktifasiButton(sender, Warna.Warna1)
        bukaformlain(New Dashboard)
        Panel5.Visible = False
    End Sub

    Private Sub BUser_Click(sender As Object, e As EventArgs) Handles BUser.Click
        AktifasiButton(sender, Warna.Warna1)
        bukaformlain(New User)
        Panel5.Visible = False
    End Sub

    Private Sub BMember_Click(sender As Object, e As EventArgs) Handles BMember.Click
        AktifasiButton(sender, Warna.Warna2)
        bukaformlain(New Member)
        Panel5.Visible = False
    End Sub
    Private Sub LogoPicture_Click(sender As Object, e As EventArgs) Handles LogoPicture.Click
        If formini IsNot Nothing Then
            formini.Close()
        End If
        kembalikeawal()
    End Sub
    Private Sub kembalikeawal()
        matikanbuton()
        panelkiri.Visible = False
        IconTitle.IconChar = IconChar.Home
        IconTitle.IconColor = Color.Black
        LabelTitle.Text = "Home"
        Panel5.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbjamtanggal.Text = DateTime.Now.ToString("dddd, dd MM yyyy || HH:mm:ss")
    End Sub

    Private Sub bpanel_Click(sender As Object, e As EventArgs) Handles bpanel.Click
        If Panel5.Visible = True Then
            Panel5.Visible = False
        Else
            Panel5.Visible = True
        End If
        Panel5.BringToFront()
    End Sub

    Private Sub bganti_Click(sender As Object, e As EventArgs) Handles bganti.Click
        Panel5.Visible = False
        bukaformlain(New Pengaturan)
    End Sub

    Private Sub blogout_Click(sender As Object, e As EventArgs) Handles blogout.Click
        Dim result As DialogResult = MessageBox.Show("Anda ingin Keluar?", "Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            If LabelLevel.Text = "Owner" Then
                Pilih.LabelOwner.Text = LabelUsername.Text
                MsgBox("Berhasil Keluar")
                Pilih.Show()
                Me.Close()
            ElseIf LabelLevel.Text = "Karyawan" Then
                MsgBox("Berhasil Keluar")
                Login.Show()
                Me.Close()
            End If
        Else
            Panel5.Visible = False
        End If
    End Sub

    Private Sub home_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If formini IsNot Nothing Then
            formini.Close()
        End If
    End Sub

    Private Sub LabelWaktu_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LabelTanggal_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LabelWaktu_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub LabelTanggal_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub bDashboard_Click_1(sender As Object, e As EventArgs)

    End Sub
    Private Sub BLayanan_Click(sender As Object, e As EventArgs) Handles BLayanan.Click
        AktifasiButton(sender, Warna.Warna6)
        bukaformlain(New Layanan)
        Panel5.Visible = False
    End Sub

    Private Sub BTransaksi_Click(sender As Object, e As EventArgs) Handles BTransaksi.Click
        AktifasiButton(sender, Warna.Warna5)
        bukaformlain(New Transaksi)
        Panel5.Visible = False
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
