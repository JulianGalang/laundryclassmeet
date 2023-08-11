Imports System.Data.Odbc
Public Class Login
    Dim kelamin As String
    Dim level As String = "Owner"
    Dim levellogin As String
    Dim namatoko As String
    Sub bawaan()
        TbEmail.Enabled = False
        TbPassword.Enabled = False
        CShow.Enabled = False
        BLogin.Enabled = False

        TbEmailDaftar.Enabled = False
        TbNama.Enabled = False
        TbPasswordDaftar.Enabled = False
        CshowD.Enabled = False
        TbTelepon.Enabled = False
        GroupBox1.Enabled = False
        BDaftar.Enabled = False

        TbEmail.Text = ""
        TbPassword.Text = ""
        TbNama.Text = ""
        TbEmailDaftar.Text = ""
        TbPasswordDaftar.Text = ""
        TbTelepon.Text = ""
        RLaki.Checked = False
        RPerempuan.Checked = False
        TbPassword.UseSystemPasswordChar = True
        TbPasswordDaftar.UseSystemPasswordChar = True

    End Sub
    Private Sub Owner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bawaan()
    End Sub
    Private Sub CShow_CheckedChanged(sender As Object, e As EventArgs) Handles CShow.CheckedChanged
        If CShow.Checked = True Then
            TbPassword.UseSystemPasswordChar = False
            CShow.Text = "Hide Password"
        Else
            TbPassword.UseSystemPasswordChar = True
            CShow.Text = "Show Password"
        End If
    End Sub

    Private Sub PanelLogin_Paint(sender As Object, e As PaintEventArgs) Handles PanelLogin.Paint

    End Sub
    Private Sub PanelDaftar_Click(sender As Object, e As EventArgs) Handles PanelDaftar.Click
        TbEmail.Enabled = False
        TbPassword.Enabled = False
        CShow.Enabled = False
        BLogin.Enabled = False

        TbEmailDaftar.Enabled = True
        TbNama.Enabled = True
        TbPasswordDaftar.Enabled = True
        CshowD.Enabled = True
        TbTelepon.Enabled = True
        GroupBox1.Enabled = True
        BDaftar.Enabled = True
    End Sub

    Private Sub PanelLogin_Click(sender As Object, e As EventArgs) Handles PanelLogin.Click
        TbEmail.Enabled = True
        TbPassword.Enabled = True
        CShow.Enabled = True
        BLogin.Enabled = True

        TbEmailDaftar.Enabled = False
        TbNama.Enabled = False
        TbPasswordDaftar.Enabled = False
        CshowD.Enabled = False
        TbTelepon.Enabled = False
        GroupBox1.Enabled = False
        BDaftar.Enabled = False
    End Sub

    Private Sub CshowD_CheckedChanged(sender As Object, e As EventArgs) Handles CshowD.CheckedChanged
        If CshowD.Checked = True Then
            TbPasswordDaftar.UseSystemPasswordChar = False
            CshowD.Text = "Hide Password"
        Else
            TbPasswordDaftar.UseSystemPasswordChar = True
            CshowD.Text = "Show Password"
        End If
    End Sub

    Private Sub RLaki_CheckedChanged(sender As Object, e As EventArgs) Handles RLaki.CheckedChanged
        If RLaki.Checked = True Then
            kelamin = "Laki - Laki"
        End If
    End Sub

    Private Sub RPerempuan_CheckedChanged(sender As Object, e As EventArgs) Handles RPerempuan.CheckedChanged
        If RPerempuan.Checked = True Then
            kelamin = "Perempuan"
        End If
    End Sub
    Sub cari()
        koneksi()
        cmd = New OdbcCommand("select * from outlet where nama='" & namatoko & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Home.Show()
            Home.LabelNamaToko.Text = dr!nama
            Home.LabelCabang.Text = dr!cabang
        End If
    End Sub
    Private Sub BLogin_Click(sender As Object, e As EventArgs) Handles BLogin.Click
        If TbEmail.Text IsNot "" And TbPassword.Text IsNot "" Then
            koneksi()
            cmd = New OdbcCommand("select * from user where username='" & TbEmail.Text & "' and password='" & TbPassword.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                MessageBox.Show("Data tidak ditemukan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                levellogin = dr!level
                Dim nama As String
                nama = dr!nama
                If levellogin = "Karyawan" Then
                    Home.LabelNama.Text = nama
                    Home.LabelUsername.Text = TbEmail.Text
                    Home.LabelLevel.Text = dr!level
                    namatoko = dr!toko
                    cari()
                    MsgBox("Berhasil Login")
                    Home.Show()
                    Me.Close()
                ElseIf levellogin = "Owner" Then
                    Dim hitungdata As String
                    hitungdata = "select count(*) from outlet where owner='" & TbEmail.Text & "'"
                    cmd = New OdbcCommand(hitungdata, conn)
                    Dim hitung As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If hitung > 0 Then
                        Pilih.LabelOwner.Text = TbEmail.Text
                        MsgBox("Berhasil Login")
                        Pilih.Show()
                        Me.Close()
                    Else
                        MsgBox("Berhasil Login")
                        Outlet.Show()
                        Outlet.lbOwner.Text = dr!username
                        Me.Close()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub BDaftar_Click(sender As Object, e As EventArgs) Handles BDaftar.Click
        If TbEmailDaftar.Text IsNot "" And TbNama.Text IsNot "" And TbPasswordDaftar.Text IsNot "" And TbTelepon.Text IsNot "" Then
            koneksi()
            Dim simpandata As String
            Dim hitungdata As String
            hitungdata = "select count(*) from user where username='" & TbEmailDaftar.Text & "'"
            cmd = New OdbcCommand(hitungdata, conn)
            Dim hitung As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If hitung > 0 Then
                MessageBox.Show("Email sudah digunakan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                simpandata = "insert into user values('','" & TbNama.Text & "','" & TbEmailDaftar.Text & "','" & TbPasswordDaftar.Text & "','" & kelamin & "','" & level & "','" & TbTelepon.Text & "','','')"
                cmd = New OdbcCommand(simpandata, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Berhasil menyimpan data")
                Outlet.lbOwner.Text = TbEmailDaftar.Text
                Outlet.Show()
                bawaan()
                Me.Close()
            End If
        Else
            MessageBox.Show("Isi Formulir Dengan Tepat", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub TbTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbTelepon.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class