Imports System.Data.Odbc
Public Class Layanan
    Dim tipe As String
    Dim id As String
    Sub bawaan()
        TbNama.Text = ""
        TbHarga.Text = ""
        tbLayanan.Text = ""
        RKilo.Checked = False
        RSatuan.Checked = False
    End Sub
    Sub auto()
        Dim urut As String
        Dim hitung As String
        cmd = New OdbcCommand("select * from jenis_pakaian where id in (select max(id) from jenis_pakaian)", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urut = "JNS" + "0001"
        Else
            hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 4) + 1
            urut = "JNS" + Microsoft.VisualBasic.Right("0000" + hitung, 4)
        End If
        id = urut
    End Sub
    Private Sub Layanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BDaftar_Click(sender As Object, e As EventArgs) Handles BDaftar.Click
        If TbNama.Text IsNot "" And TbHarga.Text IsNot "" Then
            koneksi()
            auto()
            Dim simpandata As String
            simpandata = "insert into jenis_pakaian values('" & id & "','" & TbNama.Text & "','" & TbHarga.Text & "','" & tipe & "','" & tbLayanan.Text & "','" & Home.LabelNamaToko.Text & "')"
            cmd = New OdbcCommand(simpandata, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil menyimpan data")
            bawaan()
        End If
    End Sub

    Private Sub RKilo_CheckedChanged(sender As Object, e As EventArgs) Handles RKilo.CheckedChanged
        If RKilo.Checked = True Then
            tipe = "Perkilo"
        End If
    End Sub

    Private Sub RSatuan_CheckedChanged(sender As Object, e As EventArgs) Handles RSatuan.CheckedChanged
        If RSatuan.Checked = True Then
            tipe = "Perpotong"
        End If
    End Sub
End Class