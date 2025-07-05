Imports MySql.Data.MySqlClient

Public Class ReportForm
    Private conn As New MySqlConnection("server=localhost;userid=root;password=;database=restaurant")

    Private Sub ReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSalesReport()
        ColorizeRows()
    End Sub

    Private Sub LoadSalesReport()
        Dim query As String = "SELECT * FROM orders"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            adapter.Fill(table)
            dgvReports.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ColorizeRows()
        For Each row As DataGridViewRow In dgvReports.Rows
            If row.Cells("Payment_status").Value.ToString() = "Paid" Then
                row.DefaultCellStyle.BackColor = Color.LightGreen
            ElseIf row.Cells("Payment_status").Value.ToString() = "Not Paid" Then
                row.DefaultCellStyle.BackColor = Color.Orange
            End If
        Next
    End Sub

    Private Sub btnExportToCSV_Click(sender As Object, e As EventArgs) Handles btnExportToCSV.Click
        If dgvReports.Rows.Count > 0 Then
            Dim saveFileDialog As New SaveFileDialog With {
                .Filter = "CSV Files (*.csv)|*.csv",
                .Title = "Save Report as CSV"
            }

            If saveFileDialog.ShowDialog = DialogResult.OK Then
                Using writer As New IO.StreamWriter(saveFileDialog.FileName)
                    For Each col As DataGridViewColumn In dgvReports.Columns
                        writer.Write(col.HeaderText & ",")
                    Next
                    writer.WriteLine()

                    For Each row As DataGridViewRow In dgvReports.Rows
                        For Each cell As DataGridViewCell In row.Cells
                            writer.Write(cell.Value?.ToString & ",")
                        Next
                        writer.WriteLine()
                    Next
                End Using
                MessageBox.Show("Report exported successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("No data available to export!", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub DateTimePicker_ValueChanged(sender As Object, e As EventArgs)
        LoadSalesReport()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub BtnFilter_Click(sender As Object, e As EventArgs) Handles BtnFilter.Click
        ColorizeRows()
    End Sub
End Class
