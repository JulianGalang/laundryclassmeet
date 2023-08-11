Imports System.Data.Odbc
Imports System.Security.Cryptography

Public Class Outlet
    Dim id As String
    Sub bawaan()
        TbNama.Text = ""
        TbCabang.Text = ""
        TbAlamat.Text = ""
        TbTelepon.Text = ""
        LabelGambar.Text = ""
        PictureBox1.Image = My.Resources.cloud_computing
    End Sub
    Sub auto()
        Dim urut As String
        Dim hitung As String
        cmd = New OdbcCommand("select * from outlet where id_outlet in (select max(id_outlet) from outlet)", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urut = "OUT" + "0001"
        Else
            hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 4) + 1
            urut = "OUT" + Microsoft.VisualBasic.Right("0000" + hitung, 4)
        End If
        id = urut
    End Sub
    Private Sub Outlet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bawaan()
    End Sub
    Sub cari()
        koneksi()
        cmd = New OdbcCommand("Select * from user where username='" & lbOwner.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Home.LabelUsername.Text = lbOwner.Text
            Home.LabelNamaToko.Text = TbNama.Text
            Home.LabelCabang.Text = TbCabang.Text
            Home.LabelNama.Text = dr!nama
            Home.LabelLevel.Text = dr!level
        End If
    End Sub
    Private Sub BDaftar_Click(sender As Object, e As EventArgs) Handles BDaftar.Click
        auto()
        Dim ganti As String
        ganti = LabelGambar.Text.Replace("\", "@")
        If TbNama.Text IsNot "" And TbCabang.Text IsNot "" And TbAlamat.Text IsNot "" And TbTelepon.Text IsNot "" Then
            koneksi()
            Dim hitungdata As String
            Dim simpandata As String
            hitungdata = "select count(nama) from outlet where nama='" & TbNama.Text & "'"
            cmd = New OdbcCommand(hitungdata, conn)
            Dim hitung As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If hitung > 0 Then
                MessageBox.Show("Nama outlet sudah tersedia", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                simpandata = "insert into outlet values('" & id & "','" & lbOwner.Text & "','" & TbNama.Text & "','" & TbCabang.Text & "','" & TbAlamat.Text & "','" & TbTelepon.Text & "','" & ganti & "')"
                cmd = New OdbcCommand(simpandata, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Berhasil menyimpan data")
                cari()
                Home.LogoPicture.ImageLocation = LabelGambar.Text
                bawaan()
                Home.Show()
                Me.Close()
                Pilih.Close()
                Login.Close()
            End If
        Else
            MessageBox.Show("Isi Formulir Dengan Tepat", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        BukaFile.Filter = "Images|*.jpg;*png"
        BukaFile.FileName = ""
        If BukaFile.ShowDialog() = DialogResult.OK Then
            LabelGambar.Text = BukaFile.FileName
            PictureBox1.ImageLocation = LabelGambar.Text
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            PictureBox1.Image = My.Resources.image_correction
        End If
    End Sub
    Private Sub Outlet_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        koneksi()
        Dim hitungdata As String
        hitungdata = "select count(*) from outlet where owner='" & lbOwner.Text & "'"
        cmd = New OdbcCommand(hitungdata, conn)
        Dim hitung As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        If hitung > 0 Then
            Pilih.LabelOwner.Text = lbOwner.Text
            Pilih.Show()
        Else
            Login.Show()
        End If
    End Sub
End Class