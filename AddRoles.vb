Imports MySql.Data.MySqlClient

Public Class AddRoles
    Private conn As New MySqlConnection("server=localhost;userid=root;password=;database=restaurant")
    Dim role_id As Integer
    Private Sub LoadRole()
        Dim query As String = "SELECT * FROM role"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            adapter.Fill(table)
            dgvRoles.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If TxtRole.Text = "" Then
            MsgBox("Please Enter role")

        ElseIf TxtRole.Text = "role" Then
            MsgBox("role Already Present")

        Else

            Dim cmd As New MySqlCommand("INSERT INTO role(role) VALUE (@role)", conn)
            cmd.Parameters.AddWithValue("@role", TxtRole.Text)

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Role added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadRole()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try

        End If
        TxtRole.Text = ""
    End Sub





    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        If role_id = 0 Then
            MsgBox("Select role to Delete")
        Else

            Dim cmd As New MySqlCommand("Delete from role where r_id = '" & TxtRole.Text & "'", conn)

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Role Deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadRole()

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If TxtRole.Text = "" Then
            MsgBox("Enter Role Name to Update")
        Else
            Dim cmd As New MySqlCommand("UPDATE `role` SET `role`='" & TxtRole.Text & "' WHERE id = " & role_id & " ", conn)

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Role Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadRole()
                TxtRole.Text = ""
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub AddRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRole()
    End Sub

    Private Sub dgvRoles_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvRoles.CellMouseClick
        Dim row As DataGridViewRow = dgvRoles.Rows(e.RowIndex)
        role_id = row.Cells(0).Value
        TxtRole.Text = row.Cells(1).Value.ToString
    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        role_id = 0
        TxtRole.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class