Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class Form3
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand

    Sub koneksi()
        conn = New MySqlConnection("server=localhost;user id=root;password=;database=dbkucing")
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Private Sub FormRegistrasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "SISTEM INFORMASI ADOPSI AWIWI"
        Me.BackColor = Color.White
        CenterToScreen()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim username As String = TextBox1.Text.Trim()
        Dim password As String = TextBox2.Text.Trim()
        Dim level As String = "USER"

        If username = "" OrElse password = "" Then
            MessageBox.Show("Username dan Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            koneksi()
            ' Cek apakah username sudah digunakan
            cmd = New MySqlCommand("SELECT COUNT(*) FROM user WHERE username = @username", conn)
            cmd.Parameters.AddWithValue("@username", username)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then
                MessageBox.Show("Username sudah digunakan! Silakan buat username yang lain.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TextBox1.Clear()
                TextBox1.Focus()
                Return
            End If

            ' Insert ke tabel user
            cmd = New MySqlCommand("INSERT INTO user (username, password, role) VALUES (@username, @password, @role)", conn)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)
            cmd.Parameters.AddWithValue("@role", level)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Registrasi berhasil untuk user: " & username, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Bersihkan input
            TextBox1.Clear()
            TextBox2.Clear()
            Me.Hide()
            Form4.Show()

        Catch ex As Exception
            MessageBox.Show("Gagal registrasi: " & ex.Message)
        End Try
    End Sub

    Private isPasswordVisible As Boolean = False
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles picEye.Click
        If isPasswordVisible Then
            TextBox2.UseSystemPasswordChar = True
            picEye.Image = My.Resources.eye_closed ' Ganti dengan ikon mata tertutup
            isPasswordVisible = False
        Else
            TextBox2.UseSystemPasswordChar = False
            picEye.Image = My.Resources.eye_open ' Ganti dengan ikon mata terbuka
            isPasswordVisible = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()
        Me.Hide()
    End Sub

End Class