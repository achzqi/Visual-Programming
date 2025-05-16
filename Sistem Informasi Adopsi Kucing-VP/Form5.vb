Imports MySql.Data.MySqlClient
Imports System.IO

Public Class FormDetailKucing
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=dbkucing")
    Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader

    Private Sub FormDetailKucing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilkanData(3) ' Ganti 3 dengan ID kucing yang diinginkan
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

                ' Tampilkan gambar
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

    Private Sub ButtonTutup_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
