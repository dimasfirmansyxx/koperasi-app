Imports MySql.Data.MySqlClient
Module mdlkoneksi
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public reader As MySqlDataReader
    Public adapter As MySqlDataAdapter
    Public dataset As DataSet
    Public username_log As String

    Sub konek()
        Try
            conn = New MySqlConnection("Server=localhost;user id=root;password=;database=dbkoperasi;sslmode=none")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Module
