Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class Billing
    Private conn As New MySqlConnection("server=localhost;userid=root;password=;database=restaurant")
    Private printDoc As New PrintDocument()
    Private printPreview As New PrintPreviewDialog()
    Private billContent As String = ""

    Private Sub Billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler printDoc.PrintPage, AddressOf Me.PrintReceipt
        LoadOrders()
    End Sub

    Private Sub LoadOrders()
        Dim query As String = "SELECT OrderID,Total_Item,TotalAmount,o_tableno FROM orders where Payment_status = 'Not Paid' "
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            adapter.Fill(table)
            dgvOrders.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnSettle_Click(sender As Object, e As EventArgs) Handles BtnSettle.Click
        Dim obj As New Payment
        obj.OrderId = Convert.ToInt32(TxtOrderId.Text)
        obj.Show()
        LoadOrders()
    End Sub

    Private Sub BtnSavePrint_Click(sender As Object, e As EventArgs) Handles BtnSavePrint.Click
        RetrieveTempOrders()
        ShowPrintPreview()
    End Sub

    Private Sub RetrieveTempOrders()
        Try
            conn.Open()
            Dim query As String = "SELECT ItemName, Price, Gst, Quantity, Amount FROM temp_orders WHERE Order_id = @OrderId"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@OrderId", TxtOrderId.Text)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            Dim totalQuantity As Integer = 0
            Dim totalAmount As Decimal = 0

            ' Create a formatted header
            billContent = ""
            billContent &= "                              LAZIZ RESTAURANT                          " & vbCrLf
            billContent &= "               192/10 Vaishali nagar Ajmer, Rajasthan 305001            " & vbCrLf
            billContent &= "                         Phone: (+91) 105 2828699                       " & vbCrLf & vbCrLf & vbCrLf
            billContent &= "------------------------------------------------------------------------" & vbCrLf
            billContent &= String.Format("{0,-20} {1,18} {2,5} {3,7} {4,9}", "Item Name", "Price", "GST", "Qty", "Amount") & vbCrLf
            billContent &= "------------------------------------------------------------------------" & vbCrLf

            While reader.Read()
                Dim itemName As String = reader("ItemName").ToString().PadRight(30)
                Dim price As String = Convert.ToDecimal(reader("Price")).ToString("F2").PadLeft(8)
                Dim gst As String = Convert.ToDecimal(reader("Gst")).ToString("F2").PadLeft(6)
                Dim quantity As String = reader("Quantity").ToString().PadLeft(5)
                Dim amount As String = Convert.ToDecimal(reader("Amount")).ToString("F2").PadLeft(10)

                totalQuantity += Convert.ToInt32(reader("Quantity"))
                totalAmount += Convert.ToDecimal(reader("Amount"))

                billContent &= $"{itemName} {price} {gst} {quantity} {amount}" & vbCrLf
            End While

            ' Footer Section
            billContent &= "-------------------------------------------------------------------------" & vbCrLf
            billContent &= String.Format("Total Quantity: {0,36}", totalQuantity) & vbCrLf
            billContent &= String.Format("Total Amount: ₹{0,48:F2}", totalAmount) & vbCrLf
            billContent &= "-------------------------------------------------------------------------" & vbCrLf & vbCrLf & vbCrLf
            billContent &= "                      Thank You for Dining with Us!                      " & vbCrLf
            billContent &= "                             Visit Again!                                " & vbCrLf

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub PrintReceipt(sender As Object, e As PrintPageEventArgs)
        Dim font As New Font("Courier New", 13, FontStyle.Bold) ' Monospaced for proper alignment
        Dim brush As New SolidBrush(Color.Black)
        Dim layout As New StringFormat()
        layout.Alignment = StringAlignment.Near
        e.Graphics.DrawString(billContent, font, brush, 20, 50, layout)
    End Sub


    Private Sub ShowPrintPreview()
        printPreview.Document = printDoc
        printPreview.ShowDialog()
    End Sub


End Class