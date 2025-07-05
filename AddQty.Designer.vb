<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payment))
        Label1 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Panel1 = New Panel()
        txtTotalAmount = New TextBox()
        Label3 = New Label()
        TxtPaidAmt = New TextBox()
        TxtChangeAmt = New TextBox()
        TxtMobileNo = New TextBox()
        TxtCustName = New TextBox()
        CbPayBy = New ComboBox()
        Label10 = New Label()
        Lbmobileno = New Label()
        LbCustName = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        BtnSave = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(18, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 20)
        Label1.TabIndex = 5
        Label1.Text = "Order Date"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Enabled = False
        DateTimePicker1.Location = New Point(15, 36)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(385, 27)
        DateTimePicker1.TabIndex = 6
        DateTimePicker1.Value = New Date(2025, 2, 10, 0, 0, 0, 0)
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Panel1.Controls.Add(txtTotalAmount)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(TxtPaidAmt)
        Panel1.Controls.Add(TxtChangeAmt)
        Panel1.Controls.Add(TxtMobileNo)
        Panel1.Controls.Add(TxtCustName)
        Panel1.Controls.Add(CbPayBy)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Lbmobileno)
        Panel1.Controls.Add(LbCustName)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(17, 73)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(382, 392)
        Panel1.TabIndex = 7
        ' 
        ' txtTotalAmount
        ' 
        txtTotalAmount.Location = New Point(144, 93)
        txtTotalAmount.Name = "txtTotalAmount"
        txtTotalAmount.ReadOnly = True
        txtTotalAmount.Size = New Size(151, 27)
        txtTotalAmount.TabIndex = 12
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 97)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 20)
        Label3.TabIndex = 11
        Label3.Text = "Total Amount : "
        ' 
        ' TxtPaidAmt
        ' 
        TxtPaidAmt.Location = New Point(144, 140)
        TxtPaidAmt.Name = "TxtPaidAmt"
        TxtPaidAmt.Size = New Size(151, 27)
        TxtPaidAmt.TabIndex = 10
        ' 
        ' TxtChangeAmt
        ' 
        TxtChangeAmt.Location = New Point(144, 200)
        TxtChangeAmt.Name = "TxtChangeAmt"
        TxtChangeAmt.ReadOnly = True
        TxtChangeAmt.Size = New Size(151, 27)
        TxtChangeAmt.TabIndex = 10
        ' 
        ' TxtMobileNo
        ' 
        TxtMobileNo.Location = New Point(145, 309)
        TxtMobileNo.Name = "TxtMobileNo"
        TxtMobileNo.Size = New Size(151, 27)
        TxtMobileNo.TabIndex = 10
        ' 
        ' TxtCustName
        ' 
        TxtCustName.Location = New Point(145, 258)
        TxtCustName.Name = "TxtCustName"
        TxtCustName.Size = New Size(151, 27)
        TxtCustName.TabIndex = 10
        ' 
        ' CbPayBy
        ' 
        CbPayBy.FormattingEnabled = True
        CbPayBy.Items.AddRange(New Object() {"Cash", "Credit/Debit Card", "UPI", "", ""})
        CbPayBy.Location = New Point(144, 46)
        CbPayBy.Name = "CbPayBy"
        CbPayBy.Size = New Size(151, 28)
        CbPayBy.TabIndex = 9
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(14, 47)
        Label10.Name = "Label10"
        Label10.Size = New Size(73, 23)
        Label10.TabIndex = 8
        Label10.Text = "Pay by : "
        ' 
        ' Lbmobileno
        ' 
        Lbmobileno.AutoSize = True
        Lbmobileno.Location = New Point(18, 309)
        Lbmobileno.Name = "Lbmobileno"
        Lbmobileno.Size = New Size(125, 20)
        Lbmobileno.TabIndex = 7
        Lbmobileno.Text = "Mobile Number : "
        ' 
        ' LbCustName
        ' 
        LbCustName.AutoSize = True
        LbCustName.Location = New Point(15, 261)
        LbCustName.Name = "LbCustName"
        LbCustName.Size = New Size(127, 20)
        LbCustName.TabIndex = 6
        LbCustName.Text = "Customer Name : "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(14, 204)
        Label6.Name = "Label6"
        Label6.Size = New Size(127, 20)
        Label6.TabIndex = 4
        Label6.Text = "Change Amount : "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(17, 162)
        Label5.Name = "Label5"
        Label5.Size = New Size(113, 12)
        Label5.TabIndex = 3
        Label5.Text = "Insert Customer Amount"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(14, 140)
        Label4.Name = "Label4"
        Label4.Size = New Size(123, 23)
        Label4.TabIndex = 2
        Label4.Text = "Paid Amount : "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(14, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 20)
        Label2.TabIndex = 0
        Label2.Text = "Payment Receive"
        ' 
        ' BtnSave
        ' 
        BtnSave.BackColor = Color.Red
        BtnSave.FlatAppearance.BorderSize = 0
        BtnSave.FlatStyle = FlatStyle.Popup
        BtnSave.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnSave.ForeColor = Color.White
        BtnSave.Location = New Point(133, 482)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(131, 40)
        BtnSave.TabIndex = 67
        BtnSave.Text = "Save"
        BtnSave.UseVisualStyleBackColor = False
        ' 
        ' Payment
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(412, 547)
        Controls.Add(BtnSave)
        Controls.Add(Panel1)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Payment"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Payment"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPaidAmt As TextBox
    Friend WithEvents TxtChangeAmt As TextBox
    Friend WithEvents TxtDue As TextBox
    Friend WithEvents TxtMobileNo As TextBox
    Friend WithEvents TxtCustName As TextBox
    Friend WithEvents CbPayBy As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Lbmobileno As Label
    Friend WithEvents LbCustName As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnSave As Button

End Class
