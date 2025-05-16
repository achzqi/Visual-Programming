Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Form6
    Dim connectionString As String = "server=localhost;user id=root;password=;database=dbkucing"
    Dim selectedID As String = ""

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
    End Sub

    Private Sub TampilData()
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
            selectedID = DataGridView1.Rows(e.RowIndex).Cells("idkucing").Value.ToString()
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
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
            .TextBox2.Text = selectedRow.Cells("nama").Value.ToString()
            .TextBox3.Text = selectedRow.Cells("ras").Value.ToString()
            .TextBox4.Text = selectedRow.Cells("umur").Value.ToString()
            .ComboBox4.Text = selectedRow.Cells("jk").Value.ToString()
            .DateTimePicker1.Value = Convert.ToDateTime(selectedRow.Cells("tgl").Value)
            .ComboBox1.Text = selectedRow.Cells("vaksin").Value.ToString()
            .ComboBox2.Text = selectedRow.Cells("adopsi").Value.ToString()
            .ComboBox3.Text = selectedRow.Cells("steril").Value.ToString()
            .RichTextBox1.Text = selectedRow.Cells("deskripsi").Value.ToString()

            Dim fotoPath As String = Path.Combine(Application.StartupPath, "temp_foto.jpg")
            File.WriteAllBytes(fotoPath, CType(selectedRow.Cells("foto").Value, Byte()))
            .PictureBox1.ImageLocation = fotoPath

            Dim dataPath As String = Path.Combine(Application.StartupPath, "temp_data.pdf")
            File.WriteAllBytes(dataPath, CType(selectedRow.Cells("data").Value, Byte()))
            .OpenFileDialog1.FileName = dataPath

            .btnTambah.Enabled = False
            .btnUbah.Enabled = True
            .Tag = selectedID
        End With

        Form1.ShowDialog()
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
                    Dim cmd As New MySqlCommand("DELETE FROM tabel_kucing WHERE idkucing = @id", conn)
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
End Class
