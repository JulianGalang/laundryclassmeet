Imports System.Data.Odbc
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class LaporanTransaksi
    Dim tipe As String = "Proses"
    Sub tampil()
        koneksi()
        dgv.Refresh()
        cmd = New OdbcCommand("Select * from transaksi where status='" & tipe & "' and toko='" & Home.LabelNamaToko.Text & "'", conn)
        da = New OdbcDataAdapter(cmd)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "transaksi")
        dgv.DataSource = (ds.Tables("transaksi"))
    End Sub
    Private Sub LaporanTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
    End Sub

    Private Sub bProses_Click(sender As Object, e As EventArgs) Handles bProses.Click
        tipe = "Proses"
        tampil()
    End Sub

    Private Sub bSelesai_Click(sender As Object, e As EventArgs) Handles bSelesai.Click
        tipe = "Selesai"
        tampil()
    End Sub

    Private Sub bbatal_Click(sender As Object, e As EventArgs) Handles bbatal.Click
        tipe = "Batal"
        tampil()
    End Sub

    Private Sub BCetak_Click(sender As Object, e As EventArgs) Handles BCetak.Click
        Dim report As ReportDocument = New ReportDocument()
        Dim reportPath As String = "LaporanTransaksi.rpt"
        report.Load(reportPath)
        prints.crv.SelectionFormula = ("{transaksi.status}='" & tipe & "'")
        prints.crv.ReportSource = report
        prints.crv.RefreshReport()
        Dim exportOptions As New ExportOptions()
        exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat

        ' Menentukan path dan nama file untuk menyimpan laporan PDF
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf"
        saveFileDialog.FileName = "Transaksi " & tipe & Home.LabelNamaToko.Text & ".pdf" ' Ganti dengan nama file yang sesuai

        ' Menyimpan laporan dalam format PDF
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            exportOptions.ExportDestinationType = ExportDestinationType.DiskFile
            exportOptions.DestinationOptions = New DiskFileDestinationOptions() With {.DiskFileName = saveFileDialog.FileName}
            report.Export(exportOptions)
        End If
        prints.Show()
        prints.WindowState = FormWindowState.Maximized
    End Sub
End Class