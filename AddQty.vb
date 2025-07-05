Imports System.Windows.Forms.VisualStyles
Imports MySql.Data.MySqlClient

Public Class Payment
    Private conn As New MySqlConnection("server=localhost;userid=root;password=;database=restaurant")
    Dim OrderType As String
    Dim Tableno As Integer
    Public Property OrderId As Integer

    Private Sub Order_details()
        Dim query As String = "SELECT * FROM orders where OrderID = " & OrderId & ""
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            adapter.Fill(table)
            txtTotalAmount.Text = table.Rows(0).Item(2)
            Tableno = table.Rows(0).Item(4)
            OrderType = table.Rows(0).Item(5)


        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub UpdatetableStatus()
        If OrderType = "Dine in" Then
            Dim cmd As New MySqlCommand("Update tables set Available = True  where table_id = '" & Tableno & "'", conn)

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Order_details()
        If OrderType = "Dine in" Then
            TxtCustName.Visible = False
            TxtMobileNo.Visible = False
            LbCustName.Visible = False
            Lbmobileno.Visible = False
        End If
    End Sub

    Private Sub TxtPaidAmt_TextChanged(sender As Object, e As EventArgs) Handles TxtPaidAmt.TextChanged
        TxtChangeAmt.Text = TxtPaidAmt.Text - txtTotalAmount.Text
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If OrderType = "Dine in" Then
            If CbPayBy.Text = "" Or txtTotalAmount.Text = "" Then
                MsgBox("Missing some Information")
            Else
                Dim cmd As New MySqlCommand("Update orders set Payment_status = 'Paid', Payment_method = '" & CbPayBy.Text & "', Paid_Amount = '" & TxtPaidAmt.Text & "', Returned_Amount = '" & TxtChangeAmt.Text & "' where OrderID ='" & OrderId & "' ", conn)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    UpdatetableStatus()
                    MessageBox.Show(" Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                Finally
                    conn.Close()
                End Try
            End If
        Else
            If CbPayBy.Text = "" Or txtTotalAmount.Text = "" Or TxtCustName.Text = "" Or TxtMobileNo.Text = "" Then
                MsgBox("Missing some Information")
            Else
                Dim cmd As New MySqlCommand("Update orders set Payment_status = 'Paid', Payment_method = '" & CbPayBy.Text & "', Paid_Amount = '" & TxtPaidAmt.Text & "', Returned_Amount = '" & TxtChangeAmt.Text & "',Customer_name = '" & TxtCustName.Text & "',Customer_Phone = '" & TxtMobileNo.Text & "' where OrderID ='" & OrderId & "' ", conn)
                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show(" Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                Finally
                    conn.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub CbPayBy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbPayBy.SelectedIndexChanged
        If CbPayBy.SelectedItem = "UPI" Or CbPayBy.SelectedItem = "Credit/Debit Card" Then
            TxtPaidAmt.ReadOnly = True
            TxtChangeAmt.Text = ""
            TxtPaidAmt.Text = ""
            Label3.ForeColor = Color.Gray
            Label4.ForeColor = Color.Gray
            Label5.ForeColor = Color.Gray
            Label6.ForeColor = Color.Gray
        ElseIf CbPayBy.SelectedItem = "Cash" Then
            TxtPaidAmt.ReadOnly = False
            Label3.ForeColor = Color.Black
            Label4.ForeColor = Color.Black
            Label5.ForeColor = Color.Black
            Label6.ForeColor = Color.Black
        End If
    End Sub
End Class