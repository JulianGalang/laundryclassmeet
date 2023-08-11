Imports System.Data.Odbc

Public Class User
    Dim level As String = "Karyawan"
    Dim kelamin As String
    Sub bawaan()
        TbEmailDaftar.Text = ""
        TbNama.Text = ""
        TbPasswordDaftar.Text = ""
        TbTelepon.Text = ""
        RLaki.Checked = False
        RPerempuan.Checked = False
        TbPasswordDaftar.UseSystemPasswordChar = True

    End Sub
    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bawaan()
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
                MessageBox.Show("Username sudah digunakan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                simpandata = "insert into user values('','" & TbNama.Text & "','" & TbEmailDaftar.Text & "','" & TbPasswordDaftar.Text & "','" & kelamin & "','" & level & "','" & TbTelepon.Text & "','" & Home.LabelUsername.Text & "','" & Home.LabelNamaToko.Text & "')"
                cmd = New OdbcCommand(simpandata, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Berhasil menyimpan data")
                bawaan()
            End If
        Else
            MessageBox.Show("Isi Formulir Dengan Tepat", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub CshowD_CheckedChanged(sender As Object, e As EventArgs) Handles CshowD.CheckedChanged
        If CshowD.Checked = True Then
            TbPasswordDaftar.UseSystemPasswordChar = False
            CshowD.Text = "Hide Password"
        Else
            TbPasswordDaftar.UseSystemPasswordChar = True
            CshowD.Text = "Show Password"
        End If
    End Sub
End Class