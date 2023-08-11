Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Dashboard
    Dim totalPemasukan As Decimal = 0
    Dim total As String = 0
    Dim total2 As String = 0
    Dim total3 As String = 0
    Dim total4 As String = 0

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        cmd = New OdbcCommand("select COUNT(*) from user where level='Karyawan' and toko='" & Home.LabelNamaToko.Text & "'", conn)
        total = Convert.ToInt32(cmd.ExecuteScalar)
        LabelUser.Text = "Terdapat " & total & " Karyawan"

        Dim cmd2 As OdbcCommand = New OdbcCommand("select COUNT(*) from member where toko='" & Home.LabelNamaToko.Text & "'", conn)
        total2 = Convert.ToInt32(cmd2.ExecuteScalar)
        LabelMember.Text = "Terdapat " & total2 & " Member"

        Dim cmd3 As OdbcCommand = New OdbcCommand("select COUNT(*) from jenis_pakaian where toko='" & Home.LabelNamaToko.Text & "'", conn)
        total3 = Convert.ToInt32(cmd3.ExecuteScalar)
        LabelLayanan.Text = "Terdapat " & total3 & " Layanan"

        Dim cmd4 As OdbcCommand = New OdbcCommand("select COUNT(*) from transaksi where toko='" & Home.LabelNamaToko.Text & "'and status='Proses'", conn)
        total4 = Convert.ToInt32(cmd4.ExecuteScalar)
        LabelPesanan.Text = "Terdapat " & total4 & " Pesanan belum selesai"

        Dim query As String = "SELECT * FROM transaksi where toko='" & Home.LabelNamaToko.Text & "'and status='Selesai'"
        Dim command As New OdbcCommand(query, conn)

        ' Eksekusi perintah dan baca data transaksi
        Dim reader As OdbcDataReader = command.ExecuteReader()

        ' Periksa apakah ada data transaksi
        If reader.HasRows Then
            ' Hitung total pemasukan dari data transaksi
            While reader.Read()
                totalPemasukan += Convert.ToDecimal(reader("harga_total")) - Convert.ToDecimal(reader("potongan_harga"))
            End While
        Else
            ' Jika tidak ada data transaksi, atur pemasukan menjadi 0
            totalPemasukan = 0
        End If
        LabelPemasukan.Text = "Pemasukan " & totalPemasukan.ToString("N")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Home.LabelLevel.Text = "Owner" Then
            Home.bukaformlain(New DashboardUser)
        Else
            Dim report As ReportDocument = New ReportDocument()
            Dim reportPath As String = "LaporanUser.rpt"
            prints.crv.SelectionFormula = ("{user.toko}='" & Home.LabelNamaToko.Text & "'")

            report.Load(reportPath)
            prints.crv.ReportSource = report
            prints.crv.RefreshReport()
            Dim exportOptions As New ExportOptions()
            exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat

            ' Menentukan path dan nama file untuk menyimpan laporan PDF
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf"
            saveFileDialog.FileName = "User " & Home.LabelNamaToko.Text & ".pdf" ' Ganti dengan nama file yang sesuai

            ' Menyimpan laporan dalam format PDF
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                exportOptions.ExportDestinationType = ExportDestinationType.DiskFile
                exportOptions.DestinationOptions = New DiskFileDestinationOptions() With {.DiskFileName = saveFileDialog.FileName}
                report.Export(exportOptions)
            End If
            prints.Show()
            prints.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Home.bukaformlain(New DashboardMember)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Home.bukaformlain(New DashboardLayanan)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Home.bukaformlain(New DashboardPesenan)
    End Sub
End Class