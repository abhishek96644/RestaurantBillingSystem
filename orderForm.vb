Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class OrderForm
    Dim ItemId, TotalAmount, TotalItem, Item, Amount, Order_Id As New Integer
    Dim OrderType As String
    Private conn As New MySqlConnection("server=localhost;userid=root;password=;database=restaurant")
    Public SelectedItem As ListViewItem ' To hold the selected item
    Private Sub OrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbltotal.Text = "0.00"
        LoadMenuItems()
        OrderId()
        FillTableno()
        If TxtSearch.Text = "" Then
            LoadMenuItems()
        End If
    End Sub

    ' Load available table numbers from your database
    Private Sub FillTableno()
        Dim query As String = "SELECT * FROM Tables where Available = true"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            adapter.Fill(table)
            Cbtableno.DataSource = table
            Cbtableno.DisplayMember = "table_no"
            Cbtableno.ValueMember = "table_no"
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub OrderId()
        Dim query As String = "SELECT max(OrderID) FROM orders"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            adapter.Fill(table)
            Order_Id = (table.Rows(0).Item(0)) + 1
            TxtOrderId.Text = Order_Id.ToString()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub UpdatetableStatus()
        If Cbordertype.SelectedIndex = 0 Then
            Dim cmd As New MySqlCommand("Update tables set Available = False  where table_id = '" & Cbtableno.Text & "'", conn)

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Count()
        TotalItem = 0
        TotalAmount = 0
        For Each lvItem As ListViewItem In LVYourOrder.Items
            ' Sum up the quantity and total price
            TotalItem += Convert.ToInt32(lvItem.SubItems(4).Text) ' Quantity (Column 2)
            TotalAmount += Convert.ToDouble(lvItem.SubItems(5).Text) ' Total Price (Column 3)
        Next

        ' Update the labels with the total values
        lbltotalitem.Text = TotalItem.ToString()
        lbltotal.Text = TotalAmount.ToString() ' Format as currency
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

    Private Sub Clear()
        LVYourOrder.Items.Clear()
        TotalAmount = 0
        lbltotal.Text = 0
        Cbtableno.Text = ""
        lbltotalitem.Text = 0
        Cbordertype.Text = ""
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub LVYourOrder_MouseClick(sender As Object, e As MouseEventArgs) Handles LVYourOrder.MouseClick
        If LVYourOrder.SelectedItems.Count > 0 Then
            SelectedItem = LVYourOrder.SelectedItems(0) ' Store selected item
            Dim Form2 As New AddQuantity(Me) ' Pass reference of orderForm
            Form2.ShowDialog() ' Show Form2 as a dialog
            Count()
        Else
            MessageBox.Show("Please select an item to Add Quantity.")
        End If
    End Sub

    Private Sub dgvMenu_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvMenu.CellMouseClick
        If dgvMenu.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvMenu.Rows(e.RowIndex)
            ItemId = row.Cells(0).Value
            Try
                conn.Open()
                Dim query As String = "SELECT ItemName,Price,GST FROM MenuItems where ItemID = '" & ItemId & "'"
                Dim command As New MySqlCommand(query, conn)
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    Dim itemFound As Boolean = False
                    ' Loop through each item in the ListView
                    For Each lvItem As ListViewItem In LVYourOrder.Items
                        ' Check if the item ID matches
                        If lvItem.SubItems(0).Text = ItemId Then
                            MsgBox("Item Already Added")
                            itemFound = True
                            Exit For
                        End If
                    Next
                    ' If item not found, add a new item to the ListView
                    If Not itemFound Then
                        Dim itm As New ListViewItem(ItemId)
                        itm.SubItems.Add(reader("ItemName"))
                        itm.SubItems.Add(reader("Price"))
                        itm.SubItems.Add(reader("GST"))
                        itm.SubItems.Add(1)
                        Dim Item As New Integer
                        Item = reader("Price") + ((reader("Price") * reader("GST")) / 100)
                        itm.SubItems.Add(Item)
                        LVYourOrder.Items.Add(itm)
                        Count()
                    End If
                    'If Item is not present in menu
                Else
                    MsgBox("In Menu, Item is not Available")
                    conn.Close()
                End If
            Catch ex As Exception
                MessageBox.Show("Error loading product details: " & ex.Message)
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("Please select an item to Add.")
        End If
    End Sub

    Private Sub BtnAddTable_Click(sender As Object, e As EventArgs) Handles BtnAddTable.Click
        Dim query As String = "SELECT max(table_no) FROM Tables"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            adapter.Fill(table)
            Dim Current_table_no As Integer
            Dim new_table_no As Integer
            Current_table_no = table.Rows(0).Item(0)
            new_table_no = Current_table_no + 1
            Dim cmd As New MySqlCommand("INSERT INTO Tables(table_no) VALUE (@table)", conn)
            cmd.Parameters.AddWithValue("@table", new_table_no)

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("New Table added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FillTableno()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Clear()
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        Dim query As String = "SELECT * FROM MenuItems where ItemName like '%" & TxtSearch.Text & "%'"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            adapter.Fill(table)
            dgvMenu.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub OrderSave()
        If Cbordertype.SelectedIndex = 0 Then
            Try
                conn.Open()

                ' Insert new order
                Dim query As String = "INSERT INTO orders (Total_Item,TotalAmount,o_tableno,Order_type) VALUES (@Total_Item,@TotalAmount,@o_tableno,@Order_type)"
                Dim command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@Total_Item", lbltotalitem.Text)
                command.Parameters.AddWithValue("@TotalAmount", lbltotal.Text)
                command.Parameters.AddWithValue("@o_tableno", Cbtableno.SelectedValue)
                command.Parameters.AddWithValue("@Order_type", Cbordertype.SelectedItem)
                command.ExecuteNonQuery()

                ' Insert each item from LVYourOrder into temp_orders table
                For Each lvItem As ListViewItem In LVYourOrder.Items
                    Dim itemQuery As String = "INSERT INTO temp_orders(Order_id,ItemID,ItemName,Price,GST,Quantity,Amount) VALUES (@OrderID,@ItemID,@ItemName,@Price,@GST,@Quantity,@Amount)"
                    Dim itemCommand As New MySqlCommand(itemQuery, conn)

                    itemCommand.Parameters.AddWithValue("@OrderID", TxtOrderId.Text)
                    itemCommand.Parameters.AddWithValue("@ItemID", lvItem.SubItems(0).Text)
                    itemCommand.Parameters.AddWithValue("@ItemName", lvItem.SubItems(1).Text)
                    itemCommand.Parameters.AddWithValue("@Price", lvItem.SubItems(2).Text)
                    itemCommand.Parameters.AddWithValue("@GST", lvItem.SubItems(3).Text)
                    itemCommand.Parameters.AddWithValue("@Quantity", lvItem.SubItems(4).Text)
                    itemCommand.Parameters.AddWithValue("@Amount", lvItem.SubItems(5).Text)
                    itemCommand.ExecuteNonQuery()
                Next
                UpdatetableStatus()
                FillTableno()
                Clear()
                OrderId()
                MessageBox.Show("Order Placed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error saving order: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        Else
            Try
                conn.Open()

                ' Insert new order
                Dim query As String = "INSERT INTO orders (Total_Item,TotalAmount,Order_type) VALUES (@Total_Item,@TotalAmount,@Order_type)"
                Dim command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@Total_Item", lbltotalitem.Text)
                command.Parameters.AddWithValue("@TotalAmount", lbltotal.Text)
                command.Parameters.AddWithValue("@Order_type", Cbordertype.SelectedItem)
                command.ExecuteNonQuery()

                ' Insert each item from LVYourOrder into temp_orders table
                For Each lvItem As ListViewItem In LVYourOrder.Items
                    Dim itemQuery As String = "INSERT INTO temp_orders(Order_id,ItemID,ItemName,Price,GST,Quantity,Amount) VALUES (@OrderID,@ItemID,@ItemName,@Price,@GST,@Quantity,@Amount)"
                    Dim itemCommand As New MySqlCommand(itemQuery, conn)

                    itemCommand.Parameters.AddWithValue("@OrderID", TxtOrderId.Text)
                    itemCommand.Parameters.AddWithValue("@ItemID", lvItem.SubItems(0).Text)
                    itemCommand.Parameters.AddWithValue("@ItemName", lvItem.SubItems(1).Text)
                    itemCommand.Parameters.AddWithValue("@Price", lvItem.SubItems(2).Text)
                    itemCommand.Parameters.AddWithValue("@GST", lvItem.SubItems(3).Text)
                    itemCommand.Parameters.AddWithValue("@Quantity", lvItem.SubItems(4).Text)
                    itemCommand.Parameters.AddWithValue("@Amount", lvItem.SubItems(5).Text)
                    itemCommand.ExecuteNonQuery()
                Next
                UpdatetableStatus()
                FillTableno()
                Clear()
                OrderId()
                MessageBox.Show("Order Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error saving order: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try

        End If
    End Sub

    Private Sub Cbordertype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbordertype.SelectedIndexChanged
        If Cbordertype.SelectedIndex = 0 Then
            BtnAddTable.Visible = True
            Cbtableno.Visible = True
            Label4.Visible = True
            OrderType = "Dine in"
        ElseIf Cbordertype.SelectedIndex = 1 Then
            BtnAddTable.Visible = False
            Cbtableno.Visible = False
            Label4.Visible = False
            OrderType = "Take away"
        ElseIf Cbordertype.SelectedIndex = 2 Then
            BtnAddTable.Visible = False
            Cbtableno.Visible = False
            Label4.Visible = False
            OrderType = "Home Delivery"
        End If
    End Sub


    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If TotalItem = 0 Then
            MsgBox("Please Select an Item to Place Order")
        Else
            OrderSave()
            ' Create an instance of KOTForm
            Dim kotForm As New KOTForm

            ' Pass the order items to KOTForm
            For Each lvItem As ListViewItem In LVYourOrder.Items
                Dim newItem As New ListViewItem(lvItem.SubItems(0).Text) ' Item ID
                newItem.SubItems.Add(lvItem.SubItems(1).Text) ' Item Name
                newItem.SubItems.Add(lvItem.SubItems(4).Text) ' Quantity
                kotForm.LVKOT.Items.Add(newItem)
            Next
            ' Show KOTForm
            kotForm.Show()
        End If
    End Sub
End Class