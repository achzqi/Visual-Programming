Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Form1
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String

    Sub koneksi()
        conn = New MySqlConnection("server=localhost;user id=root;password=;database=dbkucing")
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Sub kosongkan()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        ComboBox4.SelectedIndex = -1
        RichTextBox1.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        PictureBox1.Image = Nothing
        DateTimePicker1.Value = Date.Today
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> " "c Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> " "c Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        ' Validasi data wajib diisi
        If String.IsNullOrWhiteSpace(TextBox2.Text) OrElse
       String.IsNullOrWhiteSpace(TextBox3.Text) OrElse
       String.IsNullOrWhiteSpace(TextBox4.Text) OrElse
       ComboBox4.SelectedIndex = -1 OrElse
       ComboBox1.SelectedIndex = -1 OrElse
       ComboBox2.SelectedIndex = -1 OrElse
       ComboBox3.SelectedIndex = -1 OrElse
       String.IsNullOrWhiteSpace(RichTextBox1.Text) OrElse
       PictureBox1.ImageLocation Is Nothing OrElse
       String.IsNullOrWhiteSpace(OpenFileDialog1.FileName) Then

            MessageBox.Show("Data belum lengkap dibuat.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            koneksi()
            sql = "INSERT INTO kucing (nama, ras, umur, jenis_kelamin, tanggal_masuk, status_vaksinasi, status_adopsi, status_steril, deskripsi, foto, data_pengadopsi) VALUES (@nama,@ras,@umur,@jk,@tgl,@vaksin,@adopsi, @steril, @deskripsi, @foto, @data)"
            cmd = New MySqlCommand(sql, conn)
            With cmd.Parameters
                .AddWithValue("@nama", TextBox2.Text)
                .AddWithValue("@ras", TextBox3.Text)
                .AddWithValue("@umur", TextBox4.Text)
                .AddWithValue("@jk", ComboBox4.Text)
                .AddWithValue("@tgl", DateTimePicker1.Value.ToString("yyyy-MM-dd"))
                .AddWithValue("@vaksin", ComboBox1.Text)
                .AddWithValue("@adopsi", ComboBox2.Text)
                .AddWithValue("@steril", ComboBox3.Text)
                .AddWithValue("@deskripsi", RichTextBox1.Text)
                .AddWithValue("@foto", File.ReadAllBytes(PictureBox1.ImageLocation))
                .AddWithValue("@data", File.ReadAllBytes(OpenFileDialog1.FileName))
            End With
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            kosongkan()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat menyimpan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MessageBox.Show("Data belum lengkap.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        koneksi()
        Try
            sql = "UPDATE kucing SET nama=@nama, ras=@ras, umur=@umur, jenis_kelamin=@jk, tanggal_masuk=@tgl, status_vaksinasi=@vaksin, status_adopsi=@adopsi, status_steril=@steril, deskripsi=@deskripsi, foto=@foto, data_pengadopsi=@data WHERE id_kucing=@idkucing"
            cmd = New MySqlCommand(sql, conn)
            With cmd.Parameters
                .AddWithValue("@nama", TextBox2.Text)
                .AddWithValue("@ras", TextBox3.Text)
                .AddWithValue("@umur", TextBox4.Text)
                .AddWithValue("@jk", ComboBox4.Text)
                .AddWithValue("@tgl", DateTimePicker1.Value.ToString("yyyy-MM-dd"))
                .AddWithValue("@vaksin", ComboBox1.Text)
                .AddWithValue("@adopsi", ComboBox2.Text)
                .AddWithValue("@steril", ComboBox3.Text)
                .AddWithValue("@deskripsi", RichTextBox1.Text)
                .AddWithValue("@foto", File.ReadAllBytes(PictureBox1.ImageLocation))
                .AddWithValue("@data", File.ReadAllBytes(OpenFileDialog1.FileName))
                .AddWithValue("@idkucing", Form6.id_kucing)
            End With

            cmd.ExecuteNonQuery()

            MessageBox.Show("Data berhasil diubah.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            kosongkan()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub



    Private Sub btnTambahFoto_Click(sender As Object, e As EventArgs) Handles btnTambahFoto.Click
        With OpenFileDialog1
            .Filter = "File Gambar|*.jpg;*.jpeg;*.png;*.bmp"
            .Title = "Pilih Foto Kucing"
            If .ShowDialog = DialogResult.OK Then
                PictureBox1.ImageLocation = .FileName
            End If
        End With
    End Sub

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        OpenFileDialog1.Filter = "PDF Files (.pdf)|.pdf"
        OpenFileDialog1.Title = "Pilih File"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            TextBox9.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        'kode jika diperlukan
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        'kode jika diperlukan
    End Sub
    Private Sub DataKucingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataKucingToolStripMenuItem.Click
        Form6.Show()
        Form6.TampilData()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class