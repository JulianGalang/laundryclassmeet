Imports System.Data.Odbc
Imports Guna.UI2.Native.WinApi
Imports Guna.UI2.WinForms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Transaksi
    Dim tanggal As String
    Dim tipe As String
    Dim hargalayanan As Double
    Dim hargatotallayanan As Double
    Dim hargatotals As Double
    Dim hargadiskon As Double
    Dim id As String
    Dim idbahan As String
    Dim alamat As String = ""
    Dim kelamin As String = ""
    Dim telepon As String = ""
    Dim jumlahtransaksi As Integer
    Dim diskonawal As Double = 0.0
    Sub auto()
        koneksi()
        Dim hitung As String
        Dim mengurut As String
        cmd = New OdbcCommand("select * from transaksi where id_transaksi in (select max(id_transaksi) from transaksi)", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            mengurut = "TRS" + "0001"
        Else
            hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 4) + 1
            mengurut = "TRS" + Microsoft.VisualBasic.Right("0000" + hitung, 4)
        End If
        id = mengurut
    End Sub
    Sub bawaan()
        buatkolom()
        cbMember.Checked = False
        tbMember.Enabled = False
        tbMember.Text = ""
        tbNama.Text = ""
        cbJenis.Text = ""
        HargaTotal.Text = "0"
        tbDiskon.Text = ""
        nmJumlah.Value = 0.00
        tbBayar.Text = ""
        rKilo.Checked = False
        rPotong.Checked = False
        cbLayanan.Text = ""
        nmJumlah.Enabled = False
        cbJenis.Enabled = False
        tbDiskon.Enabled = False
        cbLayanan.Enabled = False
        tbBayar.Enabled = False
        bTambah.Enabled = False
        Kembalian.Text = "0"
    End Sub
    Sub buatkolom()
        dgv.Columns.Clear()
        dgv.Columns.Add("ID", "ID")
        dgv.Columns.Add("IDJENIS", "ID JENIS BAHAN")
        dgv.Columns.Add("BAHAN", "JENIS BAHAN")
        dgv.Columns.Add("TIPE", "TIPE")
        dgv.Columns.Add("LAYANAN", "LAYANAN")
        dgv.Columns.Add("JUMLAH", "JUMLAH")
        dgv.Columns.Add("HARGA", "HARGA")
        dgv.Columns.Add("SUBTOTAL", "SUBTOTAL")
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
    Sub hitungin()
        koneksi()
        cmd = New OdbcCommand("select * from jenis_pakaian where nama='" & cbJenis.SelectedItem & "'and tipe='" & tipe & "'and layanan='" & cbLayanan.SelectedItem & "'and toko='" & Home.LabelNamaToko.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            hargalayanan = dr!harga
            idbahan = dr!id
        End If
        hargatotallayanan = hargatotallayanan + CDbl(Val(hargalayanan) * Val(nmJumlah.Value))
        hargatotals = hargatotallayanan.ToString("N")
    End Sub
    Sub relasilagi()
        koneksi()
        cbLayanan.Items.Clear()
        nmJumlah.Value = 0
        cmd = New OdbcCommand("select * from jenis_pakaian where nama='" & cbJenis.SelectedItem & "'and tipe='" & tipe & "'and toko='" & Home.LabelNamaToko.Text & "'", conn)
        dr = cmd.ExecuteReader
        While dr.Read
            Dim data As String = dr!layanan
            If Not cbJenis.Items.Contains(data) Then
                cbLayanan.Items.Add(data)
            End If
        End While
    End Sub
    Sub relasi()
        koneksi()
        cbLayanan.Items.Clear()
        cmd = New OdbcCommand("select distinct * from jenis_pakaian order by nama", conn)
        dr = cmd.ExecuteReader
        While dr.Read
            Dim data As String = dr!nama
            If Not cbJenis.Items.Contains(data) Then
                cbJenis.Items.Add(data)
            End If
        End While
    End Sub
    Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        relasi()
        bawaan()
        auto()
        buatkolom()
        cbJenis.DropDownStyle = ComboBoxStyle.DropDownList
        cbLayanan.DropDownStyle = ComboBoxStyle.DropDownList

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tanggal = DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss")
        LabelTanggal.Text = DateTime.Now.ToString("dd MM yyyy || HH mm ss")
    End Sub

    Private Sub tbNama_TextChanged(sender As Object, e As EventArgs) Handles tbNama.TextChanged
        If tbNama.Text IsNot "" Then
            cbJenis.Enabled = True
        Else
            cbJenis.Enabled = False
        End If
    End Sub

    Private Sub cbJenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbJenis.SelectedIndexChanged
        If cbJenis.SelectedItem IsNot "" Then
            rKilo.Enabled = True
            rPotong.Enabled = True
            relasilagi()
        Else
            rKilo.Enabled = False
            rPotong.Enabled = False
        End If
    End Sub


    Private Sub rPotong_CheckedChanged(sender As Object, e As EventArgs) Handles rPotong.CheckedChanged
        If rPotong.Enabled = True Then
            tipe = "Perpotong"
            cbLayanan.Enabled = True
            relasilagi()
            nmJumlah.DecimalPlaces = 0
            nmJumlah.Increment = 1
            If cbLayanan.SelectedIndex <> -1 Then
                ' Hapus item yang dipilih
                cbLayanan.Items.RemoveAt(cbLayanan.SelectedIndex)
            End If
        End If
    End Sub

    Private Sub rKilo_CheckedChanged(sender As Object, e As EventArgs) Handles rKilo.CheckedChanged
        If rKilo.Enabled = True Then
            tipe = "Perkilo"
            cbLayanan.Enabled = True
            relasilagi()
            nmJumlah.DecimalPlaces = 2
            nmJumlah.Increment = 0.5
            If cbLayanan.SelectedIndex <> -1 Then
                ' Hapus item yang dipilih
                cbLayanan.Items.RemoveAt(cbLayanan.SelectedIndex)
            End If
        End If
    End Sub
    Private Sub HargaTotal_TextChanged(sender As Object, e As EventArgs) Handles HargaTotal.TextChanged, Kembalian.TextChanged
        If HargaTotal.Text IsNot "" Then
            tbDiskon.Enabled = False
            tbBayar.Enabled = True
        Else
            tbDiskon.Enabled = False
            tbBayar.Enabled = False
        End If
    End Sub

    Private Sub cbLayanan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLayanan.SelectedIndexChanged
        If cbLayanan.SelectedItem IsNot "" Then
            nmJumlah.Enabled = True
        Else
            nmJumlah.Enabled = False
        End If
    End Sub

    Private Sub bTambah_Click(sender As Object, e As EventArgs) Handles bTambah.Click
        hitungin()
        diskonnn()
        dgv.Rows.Add(New String() {id, idbahan, cbJenis.SelectedItem, tipe, cbLayanan.SelectedItem, nmJumlah.Value, hargalayanan, Val(hargalayanan) * Val(nmJumlah.Value)})
        nmJumlah.Value = 0
        tbBayar.Text = ""
    End Sub

    Private Sub nmJumlah_ValueChanged(sender As Object, e As EventArgs) Handles nmJumlah.ValueChanged
        If nmJumlah.Value = 0 Then
            bTambah.Enabled = False
        Else
            bTambah.Enabled = True
        End If
    End Sub
    Private Sub cbMember_CheckedChanged(sender As Object, e As EventArgs) Handles cbMember.CheckedChanged
        If cbMember.Checked = True Then
            tbMember.Enabled = True
            tbNama.Enabled = False
            tbNama.Text = ""
        Else
            tbMember.Enabled = False
            tbNama.Enabled = True
            tbMember.Text = ""
        End If
    End Sub
    Private Sub tbMember_TextChanged(sender As Object, e As EventArgs) Handles tbMember.TextChanged
        koneksi()
        cbLayanan.Items.Clear()
        cmd = New OdbcCommand("select * from member where kode_member='" & tbMember.Text & "'", conn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            tbNama.Text = dr!nama
            alamat = dr!alamat
            telepon = dr!telepon
            kelamin = dr!jenis_kelamin
            jumlahtransaksi = dr!jumlah_transaksi
        End If
    End Sub
    Sub diskonnn()
        If jumlahtransaksi > 4 Then
            ' Diskon bertambah 5% jika jumlah pembelian lebih atau sama dengan 4 dan merupakan kelipatan 4
            diskonawal = 0.05 * (jumlahtransaksi \ 4)
        Else
            diskonawal = 0.00
        End If
        If diskonawal > 0 Then
            hargadiskon = CDbl(hargatotals * CDbl(Val(diskonawal)))
            tbDiskon.Text = hargadiskon.ToString("N")
        Else
            HargaTotal.Text = CDbl(hargatotals).ToString("N")
            tbDiskon.Text = "0"

        End If
    End Sub
    Private Sub tbDiskon_TextChanged(sender As Object, e As EventArgs) Handles tbDiskon.TextChanged
        If tbDiskon.Text IsNot "" Then
            HargaTotal.Text = CDbl(hargatotals - hargadiskon).ToString("N")
        Else
            HargaTotal.Text = CDbl(hargatotals).ToString("N")
        End If
    End Sub

    Private Sub tbBayar_TextChanged(sender As Object, e As EventArgs) Handles tbBayar.TextChanged
        Dim hargabayar As Double
        hargabayar = CDbl(Val(tbBayar.Text)) - CDbl(HargaTotal.Text)
        If tbBayar.Text IsNot "" Then
            Kembalian.Text = hargabayar.ToString("N")
        Else
            Kembalian.Text = "0"
        End If
    End Sub
    Sub simpandatatransaksi()
        Dim simpandata As String
        simpandata = "insert into transaksi values('" & id & "','" & tbMember.Text & "','" & tanggal & "','Proses','" & tbNama.Text & "','" & alamat & "','" & telepon & "','" & kelamin & "','" & CInt(hargatotals) & "','" & CInt(tbDiskon.Text) & "','" & tbBayar.Text & "','" & CInt(Kembalian.Text) & "','" & Home.LabelNamaToko.Text & "')"
        cmd = New OdbcCommand(simpandata, conn)
        cmd.ExecuteNonQuery()
    End Sub
    Sub simpandetailtransaksi()
        For baris As Integer = 0 To dgv.Rows.Count - 1
            Dim simpandetail As String
            simpandetail = "insert into detail_transaksi values('','" & dgv.Rows(baris).Cells("ID").Value & "','" & dgv.Rows(baris).Cells("IDJENIS").Value & "','" & dgv.Rows(baris).Cells("BAHAN").Value & "','" & dgv.Rows(baris).Cells("TIPE").Value & "','" & dgv.Rows(baris).Cells("LAYANAN").Value & "','" & CDbl(dgv.Rows(baris).Cells("JUMLAH").Value) & "','" & dgv.Rows(baris).Cells("HARGA").Value & "','" & dgv.Rows(baris).Cells("SUBTOTAL").Value & "','" & Home.LabelNamaToko.Text & "')"
            cmd = New OdbcCommand(simpandetail, conn)
            cmd.ExecuteNonQuery()

        Next
    End Sub
    Private Sub bSimpan_Click(sender As Object, e As EventArgs) Handles bSimpan.Click
        If dgv.Rows.Count = 0 Then
            MessageBox.Show("Tidak ada data untuk disimpan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If Kembalian.Text < 0 Then
                MessageBox.Show("Uang Kurang", "Pembayaran", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                simpandatatransaksi()
                simpandetailtransaksi()
                Dim result As DialogResult = MessageBox.Show("Mencetak struk!", "Cetak Struk", MessageBoxButtons.OK, MessageBoxIcon.Question)
                If result = DialogResult.OK Then
                    Dim report As ReportDocument = New ReportDocument()
                    Dim reportPath As String = "Transaksi.rpt"
                    report.Load(reportPath)
                    prints.crv.SelectionFormula = ("{transaksi.id_transaksi}='" & id & "'")
                    prints.crv.ReportSource = report
                    prints.crv.RefreshReport()
                    Dim exportOptions As New ExportOptions()
                    exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat

                    ' Menentukan path dan nama file untuk menyimpan laporan PDF
                    Dim saveFileDialog As New SaveFileDialog()
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf"
                    saveFileDialog.FileName = "Transaksi" & id & ".pdf" ' Ganti dengan nama file yang sesuai

                    ' Menyimpan laporan dalam format PDF
                    If saveFileDialog.ShowDialog() = DialogResult.OK Then
                        exportOptions.ExportDestinationType = ExportDestinationType.DiskFile
                        exportOptions.DestinationOptions = New DiskFileDestinationOptions() With {.DiskFileName = saveFileDialog.FileName}
                        report.Export(exportOptions)
                    End If
                    prints.Show()
                    prints.WindowState = FormWindowState.Maximized
                    bawaan()
                End If
            End If

        End If
    End Sub

    Private Sub HargaTotal_Click(sender As Object, e As EventArgs) Handles HargaTotal.Click

    End Sub

    Private Sub tbMember_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbMember.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbBayar.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub
End Class