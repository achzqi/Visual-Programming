Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Form6
    Dim connectionString As String = "server=localhost;user id=root;password=;database=dbkucing"
    Dim selectedID As String = ""
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Public id_kucing As Integer

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
    End Sub

    Public Sub TampilData()
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM kucing"
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                DataGridView1.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Gagal menampilkan data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            selectedID = DataGridView1.Rows(e.RowIndex).Cells("id_kucing").Value.ToString()
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs)
        Form1.kosongkan()
        Form1.btnTambah.Enabled = True
        Form1.btnUbah.Enabled = False
        Form1.ShowDialog()
        TampilData()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If selectedID = "" Then
            MessageBox.Show("Pilih data yang ingin diedit terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRow As DataGridViewRow = DataGridView1.Rows(DataGridView1.CurrentRow.Index)

        With Form1
            id_kucing = selectedRow.Cells("id_kucing").Value.ToString()
            .TextBox2.Text = selectedRow.Cells("nama").Value.ToString()
            .TextBox3.Text = selectedRow.Cells("ras").Value.ToString()
            .TextBox4.Text = selectedRow.Cells("umur").Value.ToString()
            .ComboBox4.Text = selectedRow.Cells("jenis_kelamin").Value.ToString()
            .DateTimePicker1.Value = Convert.ToDateTime(selectedRow.Cells("tanggal_masuk").Value)
            .ComboBox1.Text = selectedRow.Cells("status_vaksinasi").Value.ToString()
            .ComboBox2.Text = selectedRow.Cells("status_adopsi").Value.ToString()
            .ComboBox3.Text = selectedRow.Cells("status_steril").Value.ToString()
            .RichTextBox1.Text = selectedRow.Cells("deskripsi").Value.ToString()

            Dim fotoPath As String = Path.Combine(Application.StartupPath, "temp_foto.jpg")
            File.WriteAllBytes(fotoPath, CType(selectedRow.Cells("foto").Value, Byte()))
            .PictureBox1.ImageLocation = fotoPath

            Dim dataPath As String = Path.Combine(Application.StartupPath, "temp_data.pdf")
            File.WriteAllBytes(dataPath, CType(selectedRow.Cells("data_pengadopsi").Value, Byte()))
            .OpenFileDialog1.FileName = dataPath

            .btnTambah.Enabled = False
            .btnUbah.Enabled = True
            .Tag = selectedID
        End With

        TampilData()
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedID = "" Then
            MessageBox.Show("Pilih data yang ingin dihapus terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("Yakin ingin menghapus data dengan ID: " & selectedID & "?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Using conn As New MySqlConnection(connectionString)
                Try
                    conn.Open()
                    Dim cmd As New MySqlCommand("DELETE FROM kucing WHERE id_kucing = @id", conn)
                    cmd.Parameters.AddWithValue("@id", selectedID)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Data berhasil dihapus.")
                Catch ex As Exception
                    MessageBox.Show("Gagal menghapus data: " & ex.Message)
                End Try
            End Using

            selectedID = ""
            TampilData()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim keyword As String = TextBox7.Text.Trim()

        If keyword = "" Then
            TampilData() ' Jika kosong, tampilkan semua data
            Return
        End If

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim sql As String = "SELECT * FROM kucing WHERE id_kucing LIKE @keyword OR nama LIKE @keyword"
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@keyword", "%" & keyword & "%")

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                DataGridView1.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Gagal melakukan pencarian: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub ManajemenSistemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManajemenSistemToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class