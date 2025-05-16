Imports System.Data.SqlClient
Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class Form4

    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim reader As MySqlDataReader
    Dim loggedIn As Boolean = False ' Status login
    Dim selectedCatId As String = ""

    Sub koneksi()
        conn = New MySqlConnection("server=localhost;user id=root;password=;database=dbkucing")
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Sub tampilData()
        koneksi()
        dt = New DataTable()
        da = New MySqlDataAdapter("SELECT * FROM kucing", conn)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilData()
        PrintDocument1 = New Printing.PrintDocument()
        AddHandler PrintDocument1.PrintPage, AddressOf PrintDocument1_PrintPage
    End Sub

    ' Tombol Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Form2.Show()
        Me.Hide()
    End Sub

    ' Tombol Sign Up
    Private Sub btnRegis_Click(sender As Object, e As EventArgs) Handles btnRegis.Click
        Me.Hide()
        Form3.Show()
    End Sub

    ' Fungsi Logout
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        loggedIn = False
        btnLogin.Visible = True
        btnRegis.Visible = True
        btnLogout.Visible = False
        MessageBox.Show("Berhasil logout.")
    End Sub

    ' Fungsi saat user berhasil login
    Public Sub BerhasilLogin()
        loggedIn = True
        btnLogin.Visible = False
        btnRegis.Visible = False
        btnLogout.Visible = True
    End Sub

    ' Tombol Adopsi
    Private Sub btnAdopsi_Click(sender As Object, e As EventArgs) Handles btnAdopsi.Click
        If Not loggedIn Then
            MessageBox.Show("Silakan login atau registrasi terlebih dahulu.")
        Else
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim idKucing As String = DataGridView1.SelectedRows(0).Cells("id").Value.ToString()

                koneksi()
                Dim sql As String = "INSERT INTO adopsi (id_kucing, tanggal) VALUES (@id, NOW())"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", idKucing)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Permintaan adopsi telah dikirim.")
            Else
                MessageBox.Show("Pilih data kucing terlebih dahulu.")
            End If
        End If
    End Sub

    ' Tombol PRINT
    Private Sub btnPrint_Click(sender As Object, e As EventArgs)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        Dim fontJudul As New Font("Arial", 16, FontStyle.Bold)
        Dim fontIsi As New Font("Arial", 12)
        Dim yPos As Integer = 100

        e.Graphics.DrawString("Laporan Data Kucing", fontJudul, Brushes.Black, 100, yPos)
        yPos += 40

        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                Dim nama = row.Cells("nama").Value.ToString()
                Dim umur = row.Cells("umur").Value.ToString()
                Dim jenis = row.Cells("jenis").Value.ToString()

                e.Graphics.DrawString($"Nama: {nama} | Umur: {umur} | Jenis: {jenis}", fontIsi, Brushes.Black, 100, yPos)
                yPos += 25
            End If
        Next
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            ' Ambil data dari kolom-kolom
            Dim nama As String = row.Cells("nama").Value.ToString()
            Dim ras As String = row.Cells("ras").Value.ToString()
            Dim umur As String = row.Cells("umur").Value.ToString()
            Dim jenisKelamin As String = row.Cells("jenis_kelamin").Value.ToString()
            Dim vaksin As String = row.Cells("status_vaksinasi").Value.ToString()
            Dim fotoPath As String = row.Cells("foto").Value.ToString() ' path gambar di database (kalau ada)

            ' Tampilkan ke form detail
            Dim formDetail As New FormDetailKucing()
            formDetail.LabelNama.Text = nama
            formDetail.LabelRas.Text = ras
            formDetail.LabelUmur.Text = umur
            formDetail.LabelJK.Text = jenisKelamin
            formDetail.LabelVaksin.Text = vaksin

            ' Jika ada path gambar valid, tampilkan
            If System.IO.File.Exists(fotoPath) Then
                formDetail.PictureBox1.Image = Image.FromFile(fotoPath)
            Else
                formDetail.PictureBox1.Image = Nothing
            End If

            formDetail.ShowDialog()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
