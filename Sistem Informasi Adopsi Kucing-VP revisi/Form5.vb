Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing.Printing

Public Class FormDetailKucing
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=dbkucing")
    Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader
    Dim docToPrint As New PrintDocument()

    Public Property idKucingTerpilih As Integer = -1

    Private Sub FormDetailKucing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler docToPrint.PrintPage, AddressOf Me.PrintPageHandler

        If idKucingTerpilih <> -1 Then
            tampilkanData(idKucingTerpilih)
        Else
            MessageBox.Show("ID kucing tidak valid.")
            Me.Close()
        End If
    End Sub

    Sub tampilkanData(ByVal idKucing As Integer)
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM kucing WHERE id_kucing = @id", conn)
            cmd.Parameters.AddWithValue("@id", idKucing)
            dr = cmd.ExecuteReader

            If dr.Read Then
                LabelNama.Text = dr("nama").ToString()
                LabelRas.Text = dr("ras").ToString()
                LabelUmur.Text = dr("umur").ToString()
                LabelJK.Text = dr("jenis_kelamin").ToString()
                LabelVaksin.Text = dr("status_vaksinasi").ToString()

                ' Tampilkan gambar dari BLOB
                If Not IsDBNull(dr("foto")) Then
                    Dim bytes() As Byte = CType(dr("foto"), Byte())
                    Dim ms As New MemoryStream(bytes)
                    PictureBox1.Image = Image.FromStream(ms)
                    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                End If
            Else
                MessageBox.Show("Data tidak ditemukan.")
            End If

            dr.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim preview As New PrintPreviewDialog()
        preview.Document = docToPrint
        preview.ShowDialog()
    End Sub

    Private Sub PrintPageHandler(sender As Object, e As PrintPageEventArgs)
        Dim g As Graphics = e.Graphics
        Dim yPos As Single = 100
        Dim leftMargin As Single = 80
        Dim lineHeight As Single = 25
        Dim boldFont As New Font("Times New Roman", 12, FontStyle.Bold)
        Dim italicBoldFont As New Font("Times New Roman", 12, FontStyle.Bold Or FontStyle.Italic)
        Dim regularFont As New Font("Times New Roman", 12)

        g.DrawString("SURAT PERJANJIAN ADOPSI KUCING", boldFont, Brushes.Black, leftMargin + 100, yPos)
        yPos += lineHeight * 2

        g.DrawString("Pada hari ini ….. tanggal …./…./….. telah terjadi perjanjian antara;", regularFont, Brushes.Black, leftMargin, yPos)
        yPos += lineHeight
        g.DrawString("Pihak Pertama (Tempat Adopsi Kucing):", boldFont, Brushes.Black, leftMargin, yPos)
        yPos += lineHeight
        g.DrawString("Nama Tempat: PawPaw Shelter", regularFont, Brushes.Black, leftMargin + 20, yPos)
        yPos += lineHeight
        g.DrawString("Alamat: Jl. Sambaliung, Sempaja Sel., Kec. Samarinda, Kalimantan Timur", regularFont, Brushes.Black, leftMargin + 20, yPos)
        yPos += lineHeight
        g.DrawString("No. Telepon: 081234567890", regularFont, Brushes.Black, leftMargin + 20, yPos)
        yPos += lineHeight
        g.DrawString("Diwakili oleh:", regularFont, Brushes.Black, leftMargin + 20, yPos)
        yPos += lineHeight * 2
        g.DrawString("Pihak Kedua (Pengadopsi Kucing):", boldFont, Brushes.Black, leftMargin, yPos)
        yPos += lineHeight
        g.DrawString("Nama:", regularFont, Brushes.Black, leftMargin + 20, yPos)
        yPos += lineHeight
        g.DrawString("Alamat:", regularFont, Brushes.Black, leftMargin + 20, yPos)
        yPos += lineHeight
        g.DrawString("No. Telepon:", regularFont, Brushes.Black, leftMargin + 20, yPos)
        yPos += lineHeight * 2

        g.DrawString("Dengan ini, kedua belah pihak sepakat untuk mengikat perjanjian adopsi kucing dengan syarat dan ketentuan sebagai berikut:", regularFont, Brushes.Black, leftMargin, yPos)
        yPos += lineHeight * 2

        g.DrawString("Pasal 1", italicBoldFont, Brushes.Black, leftMargin, yPos)
        yPos += lineHeight
        g.DrawString("Objek Adopsi", boldFont, Brushes.Black, leftMargin, yPos)
        yPos += lineHeight
        g.DrawString("Pihak Pertama menyerahkan seekor kucing kepada Pihak Kedua dengan keterangan sebagai berikut:", regularFont, Brushes.Black, leftMargin, yPos)
        yPos += lineHeight
        g.DrawString("Nama Kucing:", regularFont, Brushes.Black, leftMargin + 20, yPos)
        yPos += lineHeight
        g.DrawString("Umur:", regularFont, Brushes.Black, leftMargin + 20, yPos)
        yPos += lineHeight
        g.DrawString("Jenis:", regularFont, Brushes.Black, leftMargin + 20, yPos)
        yPos += lineHeight * 2

        g.DrawString("Pasal 2", italicBoldFont, Brushes.Black, leftMargin, yPos)
        yPos += lineHeight
        g.DrawString("Tanggung Jawab Pihak Kedua", boldFont, Brushes.Black, leftMargin, yPos)
        yPos += lineHeight
        g.DrawString("Pihak Kedua berjanji untuk merawat kucing dengan penuh kasih sayang, memberikan makanan, air bersih, dan tempat tinggal yang layak.", regularFont, Brushes.Black, leftMargin, yPos)
        yPos += lineHeight
        g.DrawString("Pihak Kedua tidak diperbolehkan menjual atau mengalihkan kepemilikan kucing tanpa izin dari Pihak Pertama.", regularFont, Brushes.Black, leftMargin, yPos)
        yPos += lineHeight
        g.DrawString("Pihak Kedua wajib memberikan perawatan kesehatan secara berkala, termasuk vaksinasi dan pengobatan jika sakit.", regularFont, Brushes.Black, leftMargin, yPos)
        yPos += lineHeight
        g.DrawString("Pihak Kedua dilarang melakukan kekerasan atau penelantaran terhadap kucing.", regularFont, Brushes.Black, leftMargin, yPos)
        yPos += lineHeight * 2

        g.DrawString("Pasal 3", italicBoldFont, Brushes.Black, leftMargin, yPos)
        yPos += lineHeight
        g.DrawString("Pemantauan dan Penarikan Hak", boldFont, Brushes.Black, leftMargin, yPos)
        yPos += lineHeight
        g.DrawString("Pihak Pertama berhak melakukan pemantauan terhadap kondisi kucing setelah diadopsi.", regularFont, Brushes.Black, leftMargin, yPos)
        yPos += lineHeight
        g.DrawString("Jika terbukti Pihak Kedua melanggar kesepakatan, maka Pihak Pertama berhak menarik kembali kucing tanpa pengembalian biaya apa pun.", regularFont, Brushes.Black, leftMargin, yPos)
        yPos += lineHeight * 2

        g.DrawString("Pasal 4", italicBoldFont, Brushes.Black, leftMargin, yPos)
        yPos += lineHeight
        g.DrawString("Lain-lain", boldFont, Brushes.Black, leftMargin, yPos)
        yPos += lineHeight
        g.DrawString("Perjanjian ini dibuat secara sukarela tanpa paksaan dari pihak mana pun.", regularFont, Brushes.Black, leftMargin, yPos)
        yPos += lineHeight
        g.DrawString("Segala hal yang belum tercantum dalam perjanjian ini akan diselesaikan secara musyawarah.", regularFont, Brushes.Black, leftMargin, yPos)
        yPos += lineHeight * 2

        g.DrawString("Demikian surat perjanjian ini dibuat dalam dua rangkap bermaterai cukup dan ditandatangani oleh kedua belah pihak dalam keadaan sadar dan tanpa tekanan.", regularFont, Brushes.Black, leftMargin, yPos)
        yPos += lineHeight * 4

        g.DrawString("Samarinda, .…/…./…..", regularFont, Brushes.Black, leftMargin + 300, yPos)
        yPos += lineHeight
        g.DrawString("Pihak Pertama (Tempat Adopsi)", boldFont, Brushes.Black, leftMargin, yPos)
        g.DrawString("Pihak Kedua (Pengadopsi)", boldFont, Brushes.Black, leftMargin + 300, yPos)
        yPos += lineHeight
        g.DrawString("PawPaw Shelter", regularFont, Brushes.Black, leftMargin, yPos)
        yPos += lineHeight
        g.DrawString("Diwakili oleh:", regularFont, Brushes.Black, leftMargin, yPos)
        yPos += lineHeight
        g.DrawString("Nama:", regularFont, Brushes.Black, leftMargin, yPos)
    End Sub
End Class
