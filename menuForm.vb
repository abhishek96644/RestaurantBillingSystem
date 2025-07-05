Imports MySql.Data.MySqlClient

Public Class MenuForm
    Private conn As New MySqlConnection("server=localhost;userid=root;password=;database=restaurant")

    Private Sub MenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMenuItems()
        FillCategory()
        LoadItemId()
    End Sub

    Private Sub LoadMenuItems()
        Dim query As String = "SELECT * FROM MenuItems"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            adapter.Fill(table)
            dgvMenu.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadItemId()
        Dim query As String = "SELECT max(ItemID) FROM MenuItems"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            adapter.Fill(table)
            Dim pro_id As Double
            pro_id = table.Rows(0).Item(0)
            TxtItemId.Text = pro_id + 1
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub FillCategory()
        Dim query As String = "SELECT * FROM Category"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            adapter.Fill(table)
            ComboboxCategory.DataSource = table
            ComboboxCategory.DisplayMember = "Cat_name"
            ComboboxCategory.ValueMember = "Cat_name"
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Resets()
        LoadItemId()
        txtItemName.Text = ""
        ComboboxCategory.SelectedValue = ""
        txtPrice.Text = ""
        TxtGST.Text = ""
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If txtItemName.Text = "" Or ComboboxCategory.SelectedValue.ToString = "" Or txtPrice.Text = "" Or TxtGST.Text = "" Then
            MsgBox("Please enter the all fields")
        Else
            Dim cmd As New MySqlCommand("INSERT INTO menuItems (ItemName, Category, Price, GST) VALUES (@ItemName, @Category, @Price, @GST)", conn)
            cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text)
            cmd.Parameters.AddWithValue("@Category", ComboboxCategory.SelectedValue.ToString)
            cmd.Parameters.AddWithValue("@Price", txtPrice.Text)
            cmd.Parameters.AddWithValue("@GST", TxtGST.Text)

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadMenuItems()
                Resets()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        If TxtItemId.Text = "" Or txtItemName.Text = "" Or ComboboxCategory.SelectedValue.ToString() = "" Or txtPrice.Text = "" Or TxtGST.Text = "" Then
            MsgBox("Missing some Information")
        Else
            Dim cmd As New MySqlCommand("Update MenuItems set ItemName = '" & txtItemName.Text & "', Category = '" & ComboboxCategory.SelectedValue.ToString() & "', Price = '" & txtPrice.Text & "', GST = '" & TxtGST.Text & "' where ItemID ='" & TxtItemId.Text & "' ", conn)

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Item Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadMenuItems()
                Resets()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        If TxtItemId.Text = 0 Then
            MsgBox("Enter Item ID to Delete")
        Else

            Dim cmd As New MySqlCommand("Delete from MenuItems where ItemID =" & TxtItemId.Text & "", conn)

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Item Deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadMenuItems()

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try

        End If
    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        Resets()
    End Sub

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        If txtCategory.Text = "" Then
            MsgBox("Please Enter category name")

        ElseIf txtCategory.Text = "Cat_name" Then
            MsgBox("Category Already Present")

        Else

            Dim cmd As New MySqlCommand("INSERT INTO Category (Cat_name) VALUE (@Category)", conn)
            cmd.Parameters.AddWithValue("@Category", txtCategory.Text)

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FillCategory()
                Resets()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try

        End If
        txtCategory.Text = ""
    End Sub

    Private Sub dgvMenu_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvMenu.CellMouseClick
        Dim row As DataGridViewRow = dgvMenu.Rows(e.RowIndex)
        TxtItemId.Text = row.Cells(0).Value.ToString
        txtItemName.Text = row.Cells(1).Value.ToString
        ComboboxCategory.SelectedValue = row.Cells(2).Value.ToString
        txtPrice.Text = row.Cells(3).Value.ToString
        TxtGST.Text = row.Cells(4).Value.ToString
    End Sub
End Class
