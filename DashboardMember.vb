Imports System.Data.Odbc
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class DashboardMember
    Dim kelamin As String
    Dim id As String
    Sub bawaan()
        TbNama.Text = ""
        TbAlamat.Text = ""
        TbTelepon.Text = ""
        RLaki.Checked = False
        RPerempuan.Checked = False

        TbNama.Enabled = False
        TbAlamat.Enabled = False
        TbTelepon.Enabled = False
        RLaki.Enabled = False
        RPerempuan.Enabled = False
    End Sub
    Sub edit()
        Dim ubahdata As String
        If id IsNot "" And TbNama.Text IsNot "" And TbAlamat.Text IsNot "" And TbTelepon.Text IsNot "" Then
            ubahdata = "update member set nama='" & TbNama.Text & "', alamat='" & TbAlamat.Text & "', telepon='" & TbTelepon.Text & "', jenis_kelamin='" & kelamin & "' where id='" & id & "'and toko='" & Home.LabelNamaToko.Text & "'"
            cmd = New OdbcCommand(ubahdata, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Berhasil Mengubah data", "Sukses", MessageBoxButtons.OK)
            tampil()
            bawaan()
        Else
            MessageBox.Show("Pastikan formulir terisi semua", "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Sub tampil()
        koneksi()
        dgv.Refresh()
        cmd = New OdbcCommand("Select kode_member,nama,alamat,telepon,jenis_kelamin,jumlah_transaksi from member where toko='" & Home.LabelNamaToko.Text & "'", conn)
        da = New OdbcDataAdapter(cmd)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "member")
        dgv.DataSource = (ds.Tables("member"))
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
    Private Sub DashboardMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bawaan()
        tampil()
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        Dim i As Integer = 0
        i = dgv.CurrentRow.Index
        id = dgv(0, i).Value
        TbNama.Text = dgv(1, i).Value
        TbAlamat.Text = dgv(2, i).Value
        TbTelepon.Text = dgv(3, i).Value
        kelamin = dgv(4, i).Value
        If kelamin = "Laki-laki" Then
            RLaki.Checked = True
        ElseIf kelamin = "Perempuan" Then
            RPerempuan.Checked = True
        End If
        TbNama.Enabled = True
        TbAlamat.Enabled = True
        TbTelepon.Enabled = True
        RLaki.Enabled = True
        RPerempuan.Enabled = True
    End Sub

    Private Sub BEdit_Click(sender As Object, e As EventArgs) Handles BEdit.Click
        edit()
    End Sub

    Private Sub BHapus_Click(sender As Object, e As EventArgs) Handles BHapus.Click
        Dim hapusdata As String
        If id IsNot "" And TbNama.Text IsNot "" And TbAlamat.Text IsNot "" And TbTelepon.Text IsNot "" Then
            hapusdata = "delete from member where kode_member='" & id & "'and toko='" & Home.LabelNamaToko.Text & "';"
            cmd = New OdbcCommand(hapusdata, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Berhasil Menghapus data", "Sukses", MessageBoxButtons.OK)
            tampil()
            bawaan()
        Else
            MessageBox.Show("Pastikan formulir terisi semua", "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub RLaki_CheckedChanged(sender As Object, e As EventArgs) Handles RLaki.CheckedChanged
        If RLaki.Checked = True Then
            kelamin = "Laki-Laki"
        End If
    End Sub

    Private Sub RPerempuan_CheckedChanged(sender As Object, e As EventArgs) Handles RPerempuan.CheckedChanged
        If RPerempuan.Checked = True Then
            kelamin = "Perempuan"
        End If
    End Sub

    Private Sub BCetak_Click(sender As Object, e As EventArgs) Handles BCetak.Click
        Dim report As ReportDocument = New ReportDocument()
        Dim reportPath As String = "LaporanMember.rpt"
        prints.crv.SelectionFormula = ("{member.toko}='" & Home.LabelNamaToko.Text & "'")

        report.Load(reportPath)
        prints.crv.ReportSource = report
        prints.crv.RefreshReport()
        Dim exportOptions As New ExportOptions()
        exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat

        ' Menentukan path dan nama file untuk menyimpan laporan PDF
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf"
        saveFileDialog.FileName = "Member " & Home.LabelNamaToko.Text & ".pdf" ' Ganti dengan nama file yang sesuai

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