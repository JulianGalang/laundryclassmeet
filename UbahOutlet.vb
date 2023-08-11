Imports System.Data.Odbc
Imports System.Windows.Automation.Peers

Public Class UbahOutlet
    Dim id As String
    Private Sub UbahOutlet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Dim query As String = "select * from outlet where owner='" & Pilih.LabelOwner.Text & "' and nama='" & Pilih.LbNama.Text & "' and cabang='" & Pilih.LbCabang.Text & "'"
        cmd = New OdbcCommand(query, conn)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows Then
            TbNama.Text = dr!nama
            TbCabang.Text = dr!nama
            TbAlamat.Text = dr!alamat
            TbTelepon.Text = dr!telepon
            id = dr!id_outlet
            LabelGambar.Text = dr!gambar.ToString.Replace("@", "/")
        End If
        If System.IO.File.Exists(LabelGambar.Text) Then
            ' Tampilkan gambar dari database
            PictureBox1.Image = Image.FromFile(LabelGambar.Text)
        Else
            ' Tampilkan gambar default
            PictureBox1.Image = My.Resources.cloud_computing
        End If
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
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

    Private Sub BDaftar_Click(sender As Object, e As EventArgs) Handles BDaftar.Click
        Dim ubahdata As String
        Dim ganti As String
        ganti = LabelGambar.Text.Replace("\", "@")
        If TbNama.Text IsNot "" And TbAlamat.Text IsNot "" And TbCabang.Text IsNot "" And TbTelepon.Text IsNot "" Then
            ubahdata = "update outlet set nama='" & TbNama.Text & "', alamat='" & TbAlamat.Text & "', telepon='" & TbTelepon.Text & "', gambar='" & ganti & "' where id_outlet='" & id & "'"
            cmd = New OdbcCommand(ubahdata, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Berhasil Mengubah data", "Sukses", MessageBoxButtons.OK)
            Pilih.LabelOwner.Text = lbOwner.Text
        End If
        Pilih.Show()
        Me.Close()
    End Sub
End Class