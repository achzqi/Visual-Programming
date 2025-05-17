Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Module Module1
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet

    Public Sub koneksi()
        Dim server As String = "localhost"
        Dim user As String = "root"
        Dim pass As String = ""
        Dim db As String = "dbkucing"

        Dim connectionString As String = $"server={server};user id={user};password={pass};database={db}"
        conn = New MySqlConnection(connectionString)

        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Koneksi Gagal: " & ex.Message)
        End Try
    End Sub
End Module
