Imports MySql.Data.MySqlClient

Public Class LoginForm

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=restaurant")
        Dim cmd As New MySqlCommand("SELECT * FROM Users WHERE Username=@Username AND Password=@Password", conn)
        cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
        cmd.Parameters.AddWithValue("@Password", txtPassword.Text)

        Try
            conn.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                Dim role As String = reader("Role").ToString()
                Me.Hide()
                Dim dashboard As New Dashboard(role)
                dashboard.Show()
            Else
                MessageBox.Show("Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        txtPassword.PasswordChar = "*"
        BunifuFlatButton1.Visible = False
        BunifuFlatButton2.Visible = True

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        txtPassword.PasswordChar = ""
        BunifuFlatButton2.Visible = False
        BunifuFlatButton1.Visible = True
    End Sub
End Class

