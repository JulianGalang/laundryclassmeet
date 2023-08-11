Imports System.Data.Odbc
Imports System.Windows.Input

Public Class DashboardPesenan
    Dim jumlahtransaksi As String

    Sub bawaan()
        lbIDTransaksi.Text = ""
        LabelTanggal.Text = ""
        lbKodeMember.Text = ""
        lbNama.Text = ""
        lbHargatotal.Text = "0"
        lbBayar.Text = "0"
        lbKembalian.Text = "0"
        tbbayar.Text = ""
        lbstatus.Text = ""
        tbbayar.Enabled = False

    End Sub
    Sub tampil()
        koneksi()
        dgv.Refresh()
        cmd = New OdbcCommand("Select id_transaksi,kode_member,tanggal_transaksi,status,nama_pelanggan,harga_total,potongan_harga,bayar,kembalian from transaksi where status='Proses' and toko='" & Home.LabelNamaToko.Text & "'", conn)
        da = New OdbcDataAdapter(cmd)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "transaksi")
        dgv.DataSource = (ds.Tables("transaksi"))
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
    Private Sub DashboardPesenan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
        bawaan()
    End Sub
    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        Dim i As Integer = 0
        Dim hargatotal As Double
        Dim lbayar As Double
        Dim lkembalian As Double
        Dim diskon As Double
        i = dgv.CurrentRow.Index
        lbIDTransaksi.Text = dgv(0, i).Value
        lbKodeMember.Text = dgv(1, i).Value
        LabelTanggal.Text = dgv(2, i).Value
        lbstatus.Text = dgv(3, i).Value
        lbNama.Text = dgv(4, i).Value
        hargatotal = dgv(5, i).Value
        diskon = dgv(6, i).Value
        lbayar = dgv(7, i).Value
        lkembalian = dgv(8, i).Value
        lbHargatotal.Text = CDbl(hargatotal - diskon).ToString("N")
        lbBayar.Text = lbayar.ToString("N")
        lbKembalian.Text = lkembalian.ToString("N")
        If lbBayar.Text = "0,00" Then
            tbbayar.Enabled = True
        Else
            tbbayar.Enabled = False
        End If
        tbbayar.Text = ""

    End Sub
    Sub selesai1()

    End Sub
    Sub selesai2()
        Dim simpanselesai As String
        simpanselesai = "update transaksi set status='" & lbstatus.Text & "',bayar='" & CInt(Val(tbbayar.Text)) & "',kembalian='" & CInt(Val(lbKembalian.Text)) & "'where id_transaksi='" & lbIDTransaksi.Text & "'and toko='" & Home.LabelNamaToko.Text & "'"
        cmd = New OdbcCommand(simpanselesai, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Laundry selesai")
        tampil()
        bawaan()
    End Sub
    Private Sub bbatal_Click(sender As Object, e As EventArgs) Handles bbatal.Click
        If lbIDTransaksi.Text IsNot "" Then
            Dim simpanbatal As String
            simpanbatal = "update transaksi set status='Batal' where id_transaksi='" & lbIDTransaksi.Text & "'and toko='" & Home.LabelNamaToko.Text & "'"
            cmd = New OdbcCommand(simpanbatal, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Laundry dibatalkan")
            tampil()
            bawaan()
        End If
    End Sub
    Private Sub BCetak_Click(sender As Object, e As EventArgs) Handles BCetak.Click
        LaporanTransaksi.ShowDialog()
    End Sub
    Private Sub Guna2ButtonSelesai_Click(sender As Object, e As EventArgs) Handles Guna2ButtonSelesai.Click
        Dim jumlah As Integer = 0
        If lbKembalian.Text < 0 Then
            MessageBox.Show("Jumlah uang yang dibayar kurang dari total harga pembelian.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If lbKodeMember.Text IsNot "" Then
                Dim carimember As String = "select * from member where kode_member='" & lbKodeMember.Text & "' and toko='" & Home.LabelNamaToko.Text & "'"
                Dim cmdcari As New OdbcCommand(carimember, conn)
                Dim baca As OdbcDataReader
                baca = cmdcari.ExecuteReader
                baca.Read()
                If baca.HasRows Then
                    Dim simpanbatal As String
                    Dim simpanaja As String
                    Dim cmdsimpanada As OdbcCommand
                    simpanaja = "update member set jumlah_transaksi='" & baca!jumlah_transaksi + 1 & "'where kode_member='" & lbKodeMember.Text & "'and toko='" & Home.LabelNamaToko.Text & "'"
                    simpanbatal = "update transaksi set status='Selesai' where id_transaksi='" & lbIDTransaksi.Text & "'and toko='" & Home.LabelNamaToko.Text & "'"
                    cmd = New OdbcCommand(simpanbatal, conn)
                    cmdsimpanada = New OdbcCommand(simpanaja, conn)
                    cmdsimpanada.ExecuteNonQuery()
                    cmd.ExecuteNonQuery()
                    MsgBox("Laundry Selesai")
                    tampil()
                    bawaan()
                End If
            Else
                Dim simpanbatal As String
                simpanbatal = "update transaksi set status='Selesai' where id_transaksi='" & lbIDTransaksi.Text & "'and toko='" & Home.LabelNamaToko.Text & "'"
                cmd = New OdbcCommand(simpanbatal, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Laundry Selesai")
                tampil()
                bawaan()
            End If
        End If
    End Sub
    Private Sub tbbayar_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles tbbayar.KeyDown
        If e.KeyCode = Keys.Enter Then
            If tbbayar.Text IsNot "" Then
                Dim hargabayar As Double
                lbBayar.Text = CDbl(tbbayar.Text).ToString("N")
                hargabayar = CDbl(Val(tbbayar.Text)) - CDbl(lbHargatotal.Text)
                If tbbayar.Text IsNot "" Then
                    lbKembalian.Text = hargabayar.ToString("N")
                Else
                    lbKembalian.Text = "0"
                End If
            Else
                lbBayar.Text = "0"
            End If
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Home.bukaformlain(New Dashboard)

    End Sub
End Class