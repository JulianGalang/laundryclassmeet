Imports System.Data.Odbc
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class DashboardLayanan
    Dim tipe As String
    Dim id As String
    Sub bawaan()
        TbNama.Text = ""
        TbHarga.Text = ""
        tbLayanan.Text = ""
        RKilo.Checked = False
        RSatuan.Checked = False

        TbNama.Enabled = False
        TbHarga.Enabled = False
        tbLayanan.Enabled = False
        RKilo.Enabled = False
        RSatuan.Enabled = False
    End Sub
    Sub tampil()
        koneksi()
        dgv.Refresh()
        cmd = New OdbcCommand("Select id,nama,harga,tipe,layanan from jenis_pakaian where toko='" & Home.LabelNamaToko.Text & "'", conn)
        da = New OdbcDataAdapter(cmd)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "jenis_pakaian")
        dgv.DataSource = (ds.Tables("jenis_pakaian"))
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
    Private Sub DashboardLayanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bawaan()
        tampil()
    End Sub

    Private Sub RSatuan_CheckedChanged(sender As Object, e As EventArgs) Handles RSatuan.CheckedChanged
        If RSatuan.Checked = True Then
            tipe = "Perpotong"
        End If
    End Sub

    Private Sub RKilo_CheckedChanged(sender As Object, e As EventArgs) Handles RKilo.CheckedChanged
        If RKilo.Checked = True Then
            tipe = "Perkilo"
        End If
    End Sub

    Private Sub BEdit_Click(sender As Object, e As EventArgs) Handles BEdit.Click
        Dim ubahdata As String
        If id IsNot "" And TbNama.Text IsNot "" And TbHarga.Text IsNot "" And tbLayanan.Text IsNot "" Then
            ubahdata = "update jenis_pakaian set nama='" & TbNama.Text & "', harga='" & TbHarga.Text & "',tipe='" & tipe & "', layanan='" & tbLayanan.Text & "'where id='" & id & "' and toko='" & Home.LabelNamaToko.Text & "'"
            cmd = New OdbcCommand(ubahdata, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Berhasil Mengubah data", "Sukses", MessageBoxButtons.OK)
            tampil()
            bawaan()
        Else
            MessageBox.Show("Pastikan formulir terisi semua", "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BHapus_Click(sender As Object, e As EventArgs) Handles BHapus.Click
        Dim hapusdata As String
        If id IsNot "" And TbNama.Text IsNot "" And TbHarga.Text IsNot "" And tbLayanan.Text IsNot "" Then
            hapusdata = "delete from jenis_pakaian where id='" & id & "'and toko='" & Home.LabelNamaToko.Text & "';"
            cmd = New OdbcCommand(hapusdata, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Berhasil Menghapus data", "Sukses", MessageBoxButtons.OK)
            tampil()
            bawaan()
        Else
            MessageBox.Show("Pastikan formulir terisi semua", "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        Dim i As Integer = 0
        i = dgv.CurrentRow.Index
        id = dgv(0, i).Value
        TbNama.Text = dgv(1, i).Value
        TbHarga.Text = dgv(2, i).Value
        tipe = dgv(3, i).Value
        tbLayanan.Text = dgv(4, i).Value
        If tipe = "Perkilo" Then
            RKilo.Checked = True
        ElseIf tipe = "Perpotong" Then
            RSatuan.Checked = True
        End If

        TbNama.Enabled = True
        TbHarga.Enabled = True
        tbLayanan.Enabled = True
        RKilo.Enabled = True
        RSatuan.Enabled = True
    End Sub

    Private Sub BCetak_Click(sender As Object, e As EventArgs) Handles BCetak.Click
        Dim report As ReportDocument = New ReportDocument()
        Dim reportPath As String = "LaporanLayanan.rpt"
        prints.crv.SelectionFormula = ("{jenis_pakaian.toko}='" & Home.LabelNamaToko.Text & "'")

        report.Load(reportPath)
        prints.crv.ReportSource = report
        prints.crv.RefreshReport()
        Dim exportOptions As New ExportOptions()
        exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat

        ' Menentukan path dan nama file untuk menyimpan laporan PDF
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf"
        saveFileDialog.FileName = "Layanan " & Home.LabelNamaToko.Text & ".pdf" ' Ganti dengan nama file yang sesuai

        ' Menyimpan laporan dalam format PDF
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            exportOptions.ExportDestinationType = ExportDestinationType.DiskFile
            exportOptions.DestinationOptions = New DiskFileDestinationOptions() With {.DiskFileName = saveFileDialog.FileName}
            report.Export(exportOptions)
        End If
        prints.Show()
        prints.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Home.bukaformlain(New Dashboard)
    End Sub
End Class