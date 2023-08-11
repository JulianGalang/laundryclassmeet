Imports System.Data.Odbc
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Public Class DashboardUser
    Dim id As String
    Dim kelamin As String
    Sub bawaan()
        TbEmailDaftar.Text = ""
        TbNama.Text = ""
        TbPasswordDaftar.Text = ""
        TbTelepon.Text = ""
        RLaki.Checked = False
        RPerempuan.Checked = False

        TbEmailDaftar.Enabled = False
        TbNama.Enabled = False
        TbPasswordDaftar.Enabled = False
        TbTelepon.Enabled = False
        RLaki.Enabled = False
        RPerempuan.Enabled = False
    End Sub
    Private Sub DashboardUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
        TbPasswordDaftar.UseSystemPasswordChar = True
    End Sub
    Sub tampil()
        koneksi()
        dgv.Refresh()
        cmd = New OdbcCommand("Select id,nama,username,jenis_kelamin,telepon from user where level='Karyawan' and toko='" & Home.LabelNamaToko.Text & "'", conn)
        da = New OdbcDataAdapter(cmd)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "user")
        dgv.DataSource = (ds.Tables("user"))
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        Dim i As Integer = 0
        i = dgv.CurrentRow.Index
        id = dgv(0, i).Value
        TbNama.Text = dgv(1, i).Value
        TbEmailDaftar.Text = dgv(2, i).Value
        kelamin = dgv(3, i).Value
        TbTelepon.Text = dgv(4, i).Value
        If kelamin = "Laki-laki" Then
            RLaki.Checked = True
        ElseIf kelamin = "Perempuan" Then
            RPerempuan.Checked = True
        End If
        koneksi()
        cmd = New OdbcCommand("select * from user where id='" & id & "'and toko='" & Home.LabelNamaToko.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            TbPasswordDaftar.Text = dr!password
        End If
        TbEmailDaftar.Enabled = True
        TbNama.Enabled = True
        TbPasswordDaftar.Enabled = True
        TbTelepon.Enabled = True
        RLaki.Enabled = True
        RPerempuan.Enabled = True

    End Sub

    Private Sub BEdit_Click(sender As Object, e As EventArgs) Handles BEdit.Click
        Dim ubahdata As String
        If TbEmailDaftar.Text IsNot "" And TbPasswordDaftar.Text IsNot "" And TbNama.Text IsNot "" And TbTelepon.Text IsNot "" Then
            ubahdata = "update user set nama='" & TbNama.Text & "', username='" & TbEmailDaftar.Text & "', password='" & TbPasswordDaftar.Text & "', jenis_kelamin='" & kelamin & "', telepon='" & TbTelepon.Text & "' where id='" & id & "' and toko ='" & Home.LabelNamaToko.Text & "'"
            cmd = New OdbcCommand(ubahdata, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Berhasil Mengubah data", "Sukses", MessageBoxButtons.OK)
            tampil()
            bawaan()
        Else
            MessageBox.Show("Pastikan formulir terisi semua", "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CshowD_CheckedChanged(sender As Object, e As EventArgs) Handles CshowD.CheckedChanged
        If CshowD.Checked = True Then
            TbPasswordDaftar.UseSystemPasswordChar = False
        Else
            TbPasswordDaftar.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub BHapus_Click(sender As Object, e As EventArgs) Handles BHapus.Click
        Dim hapusdata As String
        hapusdata = "delete from user where id='" & id & "';"
        cmd = New OdbcCommand(hapusdata, conn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Berhasil Menghapus data", "Sukses", MessageBoxButtons.OK)
        tampil()
        bawaan()
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
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Home.bukaformlain(New Dashboard)
    End Sub
End Class