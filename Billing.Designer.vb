<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Billing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Billing))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label6 = New Label()
        TxtOrderId = New TextBox()
        Label3 = New Label()
        BtnSettle = New Button()
        BtnSavePrint = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        dgvOrders = New DataGridView()
        Label1 = New Label()
        CType(dgvOrders, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(684, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(101, 31)
        Label6.TabIndex = 17
        Label6.Text = "BILLING"
        ' 
        ' TxtOrderId
        ' 
        TxtOrderId.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtOrderId.Location = New Point(230, 201)
        TxtOrderId.Name = "TxtOrderId"
        TxtOrderId.Size = New Size(309, 30)
        TxtOrderId.TabIndex = 73
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label3.Location = New Point(111, 202)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 25)
        Label3.TabIndex = 72
        Label3.Text = "Order Id"
        ' 
        ' BtnSettle
        ' 
        BtnSettle.BackColor = Color.Red
        BtnSettle.FlatAppearance.BorderSize = 0
        BtnSettle.FlatStyle = FlatStyle.Popup
        BtnSettle.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnSettle.ForeColor = Color.White
        BtnSettle.Location = New Point(331, 452)
        BtnSettle.Name = "BtnSettle"
        BtnSettle.Size = New Size(171, 40)
        BtnSettle.TabIndex = 74
        BtnSettle.Text = "Settle AND Save"
        BtnSettle.UseVisualStyleBackColor = False
        ' 
        ' BtnSavePrint
        ' 
        BtnSavePrint.BackColor = Color.Red
        BtnSavePrint.FlatAppearance.BorderSize = 0
        BtnSavePrint.FlatStyle = FlatStyle.Popup
        BtnSavePrint.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnSavePrint.ForeColor = Color.White
        BtnSavePrint.Location = New Point(151, 452)
        BtnSavePrint.Name = "BtnSavePrint"
        BtnSavePrint.Size = New Size(159, 40)
        BtnSavePrint.TabIndex = 75
        BtnSavePrint.Text = "Save AND Print"
        BtnSavePrint.UseVisualStyleBackColor = False
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' dgvOrders
        ' 
        dgvOrders.AllowUserToAddRows = False
        dgvOrders.AllowUserToDeleteRows = False
        dgvOrders.AllowUserToResizeColumns = False
        dgvOrders.AllowUserToResizeRows = False
        dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvOrders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvOrders.BackgroundColor = SystemColors.ControlLightLight
        dgvOrders.BorderStyle = BorderStyle.Fixed3D
        dgvOrders.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.InactiveCaptionText
        DataGridViewCellStyle1.Padding = New Padding(5)
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvOrders.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvOrders.Cursor = Cursors.Hand
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvOrders.DefaultCellStyle = DataGridViewCellStyle2
        dgvOrders.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvOrders.EnableHeadersVisualStyles = False
        dgvOrders.GridColor = Color.Black
        dgvOrders.ImeMode = ImeMode.On
        dgvOrders.Location = New Point(635, 122)
        dgvOrders.Name = "dgvOrders"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvOrders.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvOrders.RowHeadersVisible = False
        dgvOrders.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvOrders.ShowEditingIcon = False
        dgvOrders.Size = New Size(733, 598)
        dgvOrders.TabIndex = 76
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label1.Location = New Point(956, 85)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 25)
        Label1.TabIndex = 77
        Label1.Text = "Orders"
        ' 
        ' Billing
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        ClientSize = New Size(1380, 765)
        ControlBox = False
        Controls.Add(Label1)
        Controls.Add(dgvOrders)
        Controls.Add(BtnSettle)
        Controls.Add(BtnSavePrint)
        Controls.Add(TxtOrderId)
        Controls.Add(Label3)
        Controls.Add(Label6)
        FormBorderStyle = FormBorderStyle.None
        Name = "Billing"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Billing"
        CType(dgvOrders, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents TxtOrderId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnSettle As Button
    Friend WithEvents BtnSavePrint As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents dgvOrders As DataGridView
    Friend WithEvents Label1 As Label
End Class
