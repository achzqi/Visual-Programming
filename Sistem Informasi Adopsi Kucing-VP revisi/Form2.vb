Imports MySql.Data.MySqlClient

Public Class Form2
    Public id_user As Integer
    Public level As String

    Sub koneksi()
        conn = New MySqlConnection("server=localhost;user id=root;password=;database=dbkucing")
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Function SEARCH(ByRef x As String, ByRef y As String) As Boolean
        koneksi()
        cmd = New MySqlCommand("SELECT id_user, role FROM user WHERE username = @username AND password = @password", conn)
        cmd.Parameters.AddWithValue("@username", x)
        cmd.Parameters.AddWithValue("@password", y)

        dr = cmd.ExecuteReader()
        If dr.Read() Then
            id_user = dr("id_user")
            level = dr("role").ToString()
            dr.Close()
            Return True
        End If

        dr.Close()
        Return False
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user = TextBox1.Text
        Dim pass = TextBox2.Text

        koneksi()
        ' Cek apakah username ada
        Dim cmdUser As New MySqlCommand("SELECT * FROM user WHERE username = @username", conn)
        cmdUser.Parameters.AddWithValue("@username", user)
        Dim drUser As MySqlDataReader = cmdUser.ExecuteReader()

        If drUser.Read() Then
            drUser.Close()
            ' Username ada, sekarang cek password
            If SEARCH(user, pass) Then
                If level = "ADMIN" Then
                    Form1.Show()
                    Me.Hide()
                ElseIf level = "USER" Then
                    Form4.BerhasilLogin()
                    Form4.Show()
                    Me.Hide()
                End If
            Else
                MessageBox.Show("Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Label3.Visible = True
                TextBox2.Clear()
                TextBox2.Focus()
            End If
        Else
            drUser.Close()
            MessageBox.Show("Username tidak ditemukan!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Label3.Visible = True
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox1.Focus()
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Visible = False
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

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
