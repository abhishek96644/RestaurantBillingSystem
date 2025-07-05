<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class orderForm
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(orderForm))
        dgvMenu = New DataGridView()
        Label4 = New Label()
        lbltotal = New Label()
        Label9 = New Label()
        LVYourOrder = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        BtnClose = New Button()
        Cbtableno = New ComboBox()
        BtnAddTable = New Bunifu.Framework.UI.BunifuThinButton2()
        Panel1 = New Panel()
        lbltotalitem = New Label()
        BtnCancel = New Button()
        Searchlabel = New Label()
        TxtSearch = New TextBox()
        BtnSave = New Button()
        Label1 = New Label()
        Cbordertype = New ComboBox()
        Label2 = New Label()
        TxtOrderId = New TextBox()
        Label3 = New Label()
        CType(dgvMenu, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvMenu
        ' 
        dgvMenu.AllowUserToAddRows = False
        dgvMenu.AllowUserToDeleteRows = False
        dgvMenu.AllowUserToResizeColumns = False
        dgvMenu.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.Black
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dgvMenu.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMenu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvMenu.BackgroundColor = SystemColors.ButtonHighlight
        dgvMenu.BorderStyle = BorderStyle.Fixed3D
        dgvMenu.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal
        dgvMenu.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.Black
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvMenu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvMenu.ColumnHeadersHeight = 29
        dgvMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvMenu.Cursor = Cursors.Hand
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.Black
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvMenu.DefaultCellStyle = DataGridViewCellStyle3
        dgvMenu.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvMenu.GridColor = Color.Black
        dgvMenu.Location = New Point(15, 134)
        dgvMenu.MultiSelect = False
        dgvMenu.Name = "dgvMenu"
        dgvMenu.ReadOnly = True
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.Black
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.Black
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvMenu.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvMenu.RowHeadersVisible = False
        dgvMenu.RowHeadersWidth = 51
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = Color.Black
        DataGridViewCellStyle5.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = Color.White
        dgvMenu.RowsDefaultCellStyle = DataGridViewCellStyle5
        dgvMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMenu.ShowEditingIcon = False
        dgvMenu.ShowRowErrors = False
        dgvMenu.Size = New Size(733, 666)
        dgvMenu.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label4.Location = New Point(379, 36)
        Label4.Name = "Label4"
        Label4.Size = New Size(131, 25)
        Label4.TabIndex = 29
        Label4.Text = "Table Number"
        ' 
        ' lbltotal
        ' 
        lbltotal.AutoSize = True
        lbltotal.BackColor = Color.Black
        lbltotal.Font = New Font("Microsoft YaHei", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbltotal.ForeColor = Color.Yellow
        lbltotal.Location = New Point(520, 9)
        lbltotal.Name = "lbltotal"
        lbltotal.Size = New Size(65, 24)
        lbltotal.TabIndex = 31
        lbltotal.Text = "Label5"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(3, 9)
        Label9.Name = "Label9"
        Label9.Size = New Size(69, 25)
        Label9.TabIndex = 48
        Label9.Text = "Total : "
        ' 
        ' LVYourOrder
        ' 
        LVYourOrder.Activation = ItemActivation.OneClick
        LVYourOrder.BackColor = SystemColors.InactiveCaptionText
        LVYourOrder.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6})
        LVYourOrder.Font = New Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LVYourOrder.ForeColor = Color.White
        LVYourOrder.FullRowSelect = True
        LVYourOrder.HeaderStyle = ColumnHeaderStyle.Nonclickable
        LVYourOrder.ImeMode = ImeMode.On
        LVYourOrder.LabelEdit = True
        LVYourOrder.Location = New Point(782, 80)
        LVYourOrder.MultiSelect = False
        LVYourOrder.Name = "LVYourOrder"
        LVYourOrder.Size = New Size(595, 572)
        LVYourOrder.TabIndex = 55
        LVYourOrder.UseCompatibleStateImageBehavior = False
        LVYourOrder.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "ID"
        ColumnHeader1.Width = 45
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Item Name"
        ColumnHeader2.TextAlign = HorizontalAlignment.Center
        ColumnHeader2.Width = 150
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Price"
        ColumnHeader3.TextAlign = HorizontalAlignment.Center
        ColumnHeader3.Width = 80
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Tag = "%"
        ColumnHeader4.Text = "GST%"
        ColumnHeader4.TextAlign = HorizontalAlignment.Center
        ColumnHeader4.Width = 80
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Quantity"
        ColumnHeader5.TextAlign = HorizontalAlignment.Center
        ColumnHeader5.Width = 80
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Amount"
        ColumnHeader6.Width = 80
        ' 
        ' BtnClose
        ' 
        BtnClose.BackColor = Color.Red
        BtnClose.FlatStyle = FlatStyle.Flat
        BtnClose.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnClose.ForeColor = SystemColors.ButtonHighlight
        BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), Image)
        BtnClose.Location = New Point(1367, 0)
        BtnClose.Name = "BtnClose"
        BtnClose.Size = New Size(30, 26)
        BtnClose.TabIndex = 56
        BtnClose.UseVisualStyleBackColor = False
        ' 
        ' Cbtableno
        ' 
        Cbtableno.FlatStyle = FlatStyle.Popup
        Cbtableno.FormattingEnabled = True
        Cbtableno.Location = New Point(516, 36)
        Cbtableno.Name = "Cbtableno"
        Cbtableno.Size = New Size(129, 28)
        Cbtableno.TabIndex = 58
        ' 
        ' BtnAddTable
        ' 
        BtnAddTable.ActiveBorderThickness = 1
        BtnAddTable.ActiveCornerRadius = 20
        BtnAddTable.ActiveFillColor = Color.SeaGreen
        BtnAddTable.ActiveForecolor = Color.White
        BtnAddTable.ActiveLineColor = Color.SeaGreen
        BtnAddTable.BackColor = Color.Teal
        BtnAddTable.BackgroundImage = CType(resources.GetObject("BtnAddTable.BackgroundImage"), Image)
        BtnAddTable.ButtonText = "Add Table"
        BtnAddTable.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnAddTable.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        BtnAddTable.IdleBorderThickness = 1
        BtnAddTable.IdleCornerRadius = 20
        BtnAddTable.IdleFillColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        BtnAddTable.IdleForecolor = Color.SeaGreen
        BtnAddTable.IdleLineColor = Color.SeaGreen
        BtnAddTable.Location = New Point(655, 33)
        BtnAddTable.Margin = New Padding(4)
        BtnAddTable.Name = "BtnAddTable"
        BtnAddTable.Size = New Size(93, 33)
        BtnAddTable.TabIndex = 59
        BtnAddTable.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(lbltotalitem)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(lbltotal)
        Panel1.Location = New Point(782, 652)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(595, 43)
        Panel1.TabIndex = 61
        ' 
        ' lbltotalitem
        ' 
        lbltotalitem.AutoSize = True
        lbltotalitem.BackColor = Color.Black
        lbltotalitem.Font = New Font("Microsoft YaHei", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbltotalitem.ForeColor = Color.Yellow
        lbltotalitem.Location = New Point(449, 9)
        lbltotalitem.Name = "lbltotalitem"
        lbltotalitem.Size = New Size(65, 24)
        lbltotalitem.TabIndex = 49
        lbltotalitem.Text = "Label5"
        ' 
        ' BtnCancel
        ' 
        BtnCancel.BackColor = Color.White
        BtnCancel.FlatAppearance.BorderSize = 0
        BtnCancel.FlatStyle = FlatStyle.Popup
        BtnCancel.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnCancel.ForeColor = Color.Red
        BtnCancel.Location = New Point(1281, 760)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Size = New Size(94, 40)
        BtnCancel.TabIndex = 60
        BtnCancel.Text = "Cancel"
        BtnCancel.UseVisualStyleBackColor = False
        ' 
        ' Searchlabel
        ' 
        Searchlabel.AutoSize = True
        Searchlabel.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Searchlabel.Location = New Point(13, 96)
        Searchlabel.Name = "Searchlabel"
        Searchlabel.Size = New Size(113, 25)
        Searchlabel.TabIndex = 64
        Searchlabel.Text = "Search Item"
        ' 
        ' TxtSearch
        ' 
        TxtSearch.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtSearch.Location = New Point(132, 95)
        TxtSearch.Name = "TxtSearch"
        TxtSearch.Size = New Size(240, 30)
        TxtSearch.TabIndex = 65
        ' 
        ' BtnSave
        ' 
        BtnSave.BackColor = Color.Red
        BtnSave.FlatAppearance.BorderSize = 0
        BtnSave.FlatStyle = FlatStyle.Popup
        BtnSave.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnSave.ForeColor = Color.White
        BtnSave.Location = New Point(1114, 760)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(131, 40)
        BtnSave.TabIndex = 66
        BtnSave.Text = "Place Order"
        BtnSave.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label1.Location = New Point(16, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(107, 25)
        Label1.TabIndex = 67
        Label1.Text = "Order Type"
        ' 
        ' Cbordertype
        ' 
        Cbordertype.FlatStyle = FlatStyle.Popup
        Cbordertype.FormattingEnabled = True
        Cbordertype.Items.AddRange(New Object() {"Dine in", "Take away", "Home Delivery"})
        Cbordertype.Location = New Point(132, 36)
        Cbordertype.Name = "Cbordertype"
        Cbordertype.Size = New Size(240, 28)
        Cbordertype.TabIndex = 68
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(785, 46)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 31)
        Label2.TabIndex = 69
        Label2.Text = "Your Order"
        ' 
        ' TxtOrderId
        ' 
        TxtOrderId.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtOrderId.Location = New Point(1208, 44)
        TxtOrderId.Name = "TxtOrderId"
        TxtOrderId.ReadOnly = True
        TxtOrderId.Size = New Size(169, 30)
        TxtOrderId.TabIndex = 71
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label3.Location = New Point(1089, 45)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 25)
        Label3.TabIndex = 70
        Label3.Text = "Order Id"
        ' 
        ' orderForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        ClientSize = New Size(1398, 812)
        Controls.Add(TxtOrderId)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Cbordertype)
        Controls.Add(Label1)
        Controls.Add(BtnSave)
        Controls.Add(TxtSearch)
        Controls.Add(Searchlabel)
        Controls.Add(Panel1)
        Controls.Add(BtnCancel)
        Controls.Add(BtnAddTable)
        Controls.Add(Cbtableno)
        Controls.Add(dgvMenu)
        Controls.Add(BtnClose)
        Controls.Add(LVYourOrder)
        Controls.Add(Label4)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "orderForm"
        StartPosition = FormStartPosition.CenterScreen
        CType(dgvMenu, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvMenu As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LVYourOrder As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents BtnClose As Button
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Cbtableno As ComboBox
    Friend WithEvents BtnAddTable As Bunifu.Framework.UI.BunifuThinButton2
    Public Property BtnSaveOrder As Button
    Friend WithEvents SaveOrder As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnOrderSave As Button
    Friend WithEvents lbltotalitem As Label
    Friend WithEvents Searchlabel As Label
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Cbordertype As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtOrderId As TextBox
    Friend WithEvents Label3 As Label
End Class
