Imports System.Data.Odbc

Public Class Pengaturan
    Sub bawaan()
        tbpasslama.Text = ""
        tbpassbaru.Text = ""
    End Sub
    Private Sub blogin_Click(sender As Object, e As EventArgs) Handles blogin.Click
        If tbpassbaru.Text IsNot "" And tbpasslama.Text IsNot "" Then
            koneksi()
            cmd = New OdbcCommand("select * from user where username='" & Home.LabelUsername.Text & "'and password='" & tbpasslama.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Dim ubahdata As String
                ubahdata = ("update user set password='" & tbpassbaru.Text & "'where username='" & Home.lbadmin.Text & "'")
                cmd = New OdbcCommand(ubahdata, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Berhasil Menyimpan Data")
                Login.Show()
                Me.Close()
            Else
                MsgBox("Tidak dapat menemukan password lama")
                bawaan()
            End If
        End If
    End Sub
End Class