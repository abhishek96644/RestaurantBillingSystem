Public Class AddQuantity

    Private mainForm As orderForm ' Reference to main form

    Public Sub New(parentForm As orderForm)
        InitializeComponent()
        mainForm = parentForm
    End Sub

    Private Sub AddQuantity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the TextBox with the current quantity of the selected item
        TextBoxQuantity.Text = mainForm.SelectedItem.SubItems(4).Text
        TxtAmount.Text = mainForm.SelectedItem.SubItems(5).Text
    End Sub

    Private Sub ButtonAdd_Click_1(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        ' Increase quantity in TextBox
        Dim currentQuantity = Integer.Parse(TextBoxQuantity.Text)
        TextBoxQuantity.Text = (currentQuantity + 1).ToString
        TxtAmount.Text = mainForm.SelectedItem.SubItems(5).Text * TextBoxQuantity.Text
    End Sub

    Private Sub ButtonReduce_Click_1(sender As Object, e As EventArgs) Handles ButtonReduce.Click
        ' Decrease quantity in TextBox if greater than zero
        Dim currentQuantity = Integer.Parse(TextBoxQuantity.Text)
        If currentQuantity > 1 Then
            TextBoxQuantity.Text = (currentQuantity - 1).ToString
            TxtAmount.Text = mainForm.SelectedItem.SubItems(5).Text * TextBoxQuantity.Text
        Else
            MessageBox.Show("Quantity cannot be less than One.")
        End If
    End Sub


    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        ' Save the updated quantity to the selected ListView item
        mainForm.SelectedItem.SubItems(4).Text = TextBoxQuantity.Text
        mainForm.SelectedItem.SubItems(5).Text = TxtAmount.Text
        Close() ' Close the form
    End Sub
End Class