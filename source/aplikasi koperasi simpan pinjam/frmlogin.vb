Imports MySql.Data.MySqlClient
Public Class frmlogin

    Private Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call konek()
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim user, pass As String
        user = txtuname.Text
        pass = txtpass.Text
        If user = "" Then
            MessageBox.Show("Isikan Username!")
        ElseIf pass = "" Then
            MessageBox.Show("Isikan Password!")
        Else
            conn.Close()
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM tbluser WHERE username = '" & user & "'", conn)
            reader = cmd.ExecuteReader
            reader.Read()
            If reader.HasRows Then
                If reader.Item("password") = pass Then
                    frmmaster.Show()
                    username_log = user
                    Me.Hide()
                    txtuname.Clear()
                    txtpass.Clear()
                Else
                    MessageBox.Show("Password salah!")
                End If
            Else
                MessageBox.Show("Username tidak ada!")
            End If
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub

End Class
