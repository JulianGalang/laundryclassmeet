Imports System.Data.Odbc
Public Class Pilih
    Dim namalaundry As New List(Of String)()
    Dim cabanglaundry As New List(Of String)()
    Dim gambarlaundry As New List(Of String)()
    Dim currentindex As Integer = 0
    Private Sub Pilih_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Dim query As String = "select nama,cabang,gambar from outlet where owner='" & LabelOwner.Text & "' order by nama asc"
        cmd = New OdbcCommand(query, conn)
        dr = cmd.ExecuteReader()

        While dr.Read()
            namalaundry.Add(dr("nama").ToString())
            cabanglaundry.Add(dr("cabang").ToString())
            gambarlaundry.Add(dr("gambar").ToString.Replace("@", "/"))
        End While

        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        ShowImage()
    End Sub
    Private Sub ShowImage()
        ' Cek validasi indeks saat ini
        If currentindex >= 0 AndAlso currentindex < gambarlaundry.Count Then
            Dim imagePath As String = gambarlaundry(currentindex)

            ' Cek validasi path gambar
            If System.IO.File.Exists(imagePath) Then
                ' Tampilkan gambar dari database
                PictureBox1.Image = Image.FromFile(imagePath)
                Home.LogoPicture.Image = Image.FromFile(imagePath)
            Else
                ' Tampilkan gambar default
                PictureBox1.Image = My.Resources.image_correction
                Home.LogoPicture.Image = My.Resources.image_correction
            End If
        End If
        If currentindex >= 0 AndAlso currentindex < namalaundry.Count Then
            LbNama.Text = namalaundry(currentindex)
        End If
        If currentindex >= 0 AndAlso currentindex < cabanglaundry.Count Then
            LbCabang.Text = cabanglaundry(currentindex)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        ' Mengurangi indeks
        currentindex -= 1

        ' Cek apakah mencapai awal koleksi gambar
        If currentindex < 0 Then
            currentindex = gambarlaundry.Count - 1 ' Kembali ke akhir koleksi gambar
            currentindex = namalaundry.Count - 1
            currentindex = cabanglaundry.Count - 1
        End If

        ' Tampilkan gambar sebelumnya
        ShowImage()
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        ' Meningkatkan indeks
        currentindex += 1

        ' Cek apakah mencapai akhir koleksi gambar
        If currentindex >= gambarlaundry.Count Then
            currentindex = 0 ' Kembali ke awal koleksi gambar
        End If
        If currentindex >= namalaundry.Count Then
            currentindex = 0 ' Kembali ke awal koleksi gambar
        End If
        If currentindex >= cabanglaundry.Count Then
            currentindex = 0 ' Kembali ke awal koleksi gambar
        End If
        ' Tampilkan gambar berikutnya
        ShowImage()
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        Outlet.Show()
        Outlet.lbOwner.Text = LabelOwner.Text
        Me.Close()
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        koneksi()
        cmd = New OdbcCommand("select * from user where username='" & LabelOwner.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Home.LabelUsername.Text = LabelOwner.Text
            Home.LabelNamaToko.Text = LbNama.Text
            Home.LabelCabang.Text = LbCabang.Text
            Home.LabelNama.Text = dr!nama
            Home.LabelLevel.Text = dr!level
            MsgBox("Outlet yang dipilih " & LbNama.Text)
            Home.Show()
            Me.Close()
        End If
    End Sub

    Private Sub bLogout_Click(sender As Object, e As EventArgs) Handles bLogout.Click
        Dim result As DialogResult = MessageBox.Show("Anda ingin logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            MsgBox("Berhasil Logout")
            Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub bUbah_Click(sender As Object, e As EventArgs) Handles bUbah.Click
        UbahOutlet.lbOwner.Text = LabelOwner.Text
        UbahOutlet.Show()
        Me.Close()
    End Sub
End Class