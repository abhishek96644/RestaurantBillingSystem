Public Class Dashboard
    Private UserRole As String

    Public Sub New(role As String)
        InitializeComponent()
        UserRole = role
        lblRole.Text = "Welcome, " & role
        If role <> "Admin" Then
            BtnAddStaff.Enabled = False
            BtnRoles.Enabled = False

        End If
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        menuForm.Show()
        menuForm.MdiParent = Me
        orderForm.Close()
        reportForm.Close()
        Billing.Close()
        SignUpForm.Close()
        AddRoles.Close()
    End Sub

    Private Sub btnOrders_Click(sender As Object, e As EventArgs) Handles btnOrders.Click

        orderForm.Show()
        orderForm.MdiParent = Me
        menuForm.Close()
        reportForm.Close()
        Billing.Close()
        SignUpForm.Close()
        AddRoles.Close()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click

        reportForm.Show()
        reportForm.MdiParent = Me
        orderForm.Close()
        menuForm.Close()
        Billing.Close()
        SignUpForm.Close()
        AddRoles.Close()
    End Sub
    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        LoginForm.Show()
        orderForm.Close()
        reportForm.Close()
        menuForm.Close()
        Billing.Close()
        SignUpForm.Close()
        AddRoles.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Billing.Show()
        Billing.MdiParent = Me
        orderForm.Close()
        reportForm.Close()
        menuForm.Close()
        SignUpForm.Close()
        AddRoles.Close()
    End Sub

    Private Sub BtnAddStaff_Click(sender As Object, e As EventArgs) Handles BtnAddStaff.Click
        SignUpForm.Show()
        SignUpForm.MdiParent = Me
        orderForm.Close()
        reportForm.Close()
        menuForm.Close()
        Billing.Close()
        AddRoles.Close()
    End Sub

    Private Sub BtnRoles_Click_1(sender As Object, e As EventArgs) Handles BtnRoles.Click
        AddRoles.Show()
        AddRoles.MdiParent = Me
        orderForm.Close()
        reportForm.Close()
        menuForm.Close()
        Billing.Close()
        SignUpForm.Close()
    End Sub

    
End Class