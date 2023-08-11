Imports System.Data.Odbc
Public Class Member
    Dim id As String
    Dim kelamin As String
    Sub bawaan()
        TbNama.Text = ""
        TbAlamat.Text = ""
        TbTelepon.Text = ""
        id = ""
        RLaki.Checked = False
        RPerempuan.Checked = False
    End Sub
    Sub auto()
        koneksi()
        Dim rnd As New Random()
        Dim randomNumber As Integer = rnd.Next(10000, 30000)
        Dim hitung As String
        Dim mengurut As String
        cmd = New OdbcCommand("select * from member where kode_member in (select max(kode_member) from member)", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            mengurut = randomNumber.ToString + "0001"
        Else
            hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 4) + 1
            mengurut = randomNumber.ToString + Microsoft.VisualBasic.Right("0000" + hitung, 4)
        End If
        id = mengurut
    End Sub
    Private Sub Member_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bawaan()
    End Sub

    Private Sub BDaftar_Click(sender As Object, e As EventArgs) Handles BDaftar.Click
        auto()
        If TbNama.Text IsNot "" And TbAlamat.Text IsNot "" And TbTelepon.Text IsNot "" Then
            Dim simpandata As String
            simpandata = "insert into member values('" & id & "','" & TbNama.Text & "','" & TbAlamat.Text & "','" & TbTelepon.Text & "','" & kelamin & "','0','" & Home.LabelNamaToko.Text & "')"
            cmd = New OdbcCommand(simpandata, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil menyimpan data")
            bawaan()
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
End Class