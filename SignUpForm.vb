Imports MySql.Data.MySqlClient

Public Class SignUpForm
    Private conn As New MySqlConnection("server=localhost;userid=root;password=;database=restaurant")

    Private Sub LoadStaffList()
        Dim query As String = "SELECT Username,Email,Phone_no,Salary FROM users where Role != 'Admin'"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            adapter.Fill(table)
            dgvMenu.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub LoadRole()
        Dim query As String = "SELECT * FROM role"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            adapter.Fill(table)
            CbStaffRole.DataSource = table
            CbStaffRole.DisplayMember = "role"
            CbStaffRole.ValueMember = "role"
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        If txtName.Text = "" Or txtEmail.Text = "" Or txtPhone.Text = "" Or txtPass.Text = "" Or CbStaffRole.Text = "" Or TxtSalary.Text = "" Then
            MsgBox("Please enter the all fields")
        Else
            Dim cmd As New MySqlCommand("INSERT INTO users (Username, Email, Phone_no, Password,Role,Salary) VALUES (@name, @email, @phone, @pass,@Role,@Salary)", conn)
            cmd.Parameters.AddWithValue("@name", txtName.Text)
            cmd.Parameters.AddWithValue("@email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text)
            cmd.Parameters.AddWithValue("@pass", txtPass.Text)
            cmd.Parameters.AddWithValue("@Role", CbStaffRole.Text)
            cmd.Parameters.AddWithValue("@Salary", TxtSalary.Text)

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Staff Added Successfully")
                LoadStaffList()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        txtPass.PasswordChar = "*"
        BunifuFlatButton1.Visible = False
        BunifuFlatButton2.Visible = True

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        txtPass.PasswordChar = ""
        BunifuFlatButton2.Visible = False
        BunifuFlatButton1.Visible = True
    End Sub

    Private Sub SignUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStaffList()
        LoadRole()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class