<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuForm))
        dgvMenu = New DataGridView()
        txtCategory = New TextBox()
        Label5 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Button2 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        txtPrice = New TextBox()
        txtItemName = New TextBox()
        ComboboxCategory = New ComboBox()
        Label8 = New Label()
        TxtGST = New TextBox()
        TxtItemId = New TextBox()
        Label4 = New Label()
        BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        BunifuThinButton23 = New Bunifu.Framework.UI.BunifuThinButton2()
        BunifuThinButton24 = New Bunifu.Framework.UI.BunifuThinButton2()
        Panel1 = New Panel()
        BunifuThinButton25 = New Bunifu.Framework.UI.BunifuThinButton2()
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
        dgvMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMenu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvMenu.BackgroundColor = SystemColors.ControlLightLight
        dgvMenu.BorderStyle = BorderStyle.Fixed3D
        dgvMenu.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.InactiveCaptionText
        DataGridViewCellStyle1.Padding = New Padding(5)
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvMenu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMenu.Cursor = Cursors.Hand
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvMenu.DefaultCellStyle = DataGridViewCellStyle2
        dgvMenu.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvMenu.EnableHeadersVisualStyles = False
        dgvMenu.GridColor = Color.Black
        dgvMenu.ImeMode = ImeMode.On
        dgvMenu.Location = New Point(1, 363)
        dgvMenu.Name = "dgvMenu"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvMenu.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvMenu.RowHeadersVisible = False
        dgvMenu.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        dgvMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMenu.ShowEditingIcon = False
        dgvMenu.Size = New Size(1334, 382)
        dgvMenu.TabIndex = 0
        ' 
        ' txtCategory
        ' 
        txtCategory.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        txtCategory.Location = New Point(179, 38)
        txtCategory.Name = "txtCategory"
        txtCategory.Size = New Size(201, 31)
        txtCategory.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(629, 328)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 28)
        Label5.TabIndex = 14
        Label5.Text = "Item List"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label7.Location = New Point(27, 41)
        Label7.Name = "Label7"
        Label7.Size = New Size(145, 25)
        Label7.TabIndex = 18
        Label7.Text = "Category Name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(582, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(187, 31)
        Label6.TabIndex = 16
        Label6.Text = "MANAGE ITEMS"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(1305, -1)
        Button2.Name = "Button2"
        Button2.Size = New Size(30, 26)
        Button2.TabIndex = 57
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label2.Location = New Point(716, 26)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 25)
        Label2.TabIndex = 5
        Label2.Text = "Category : "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label3.Location = New Point(10, 99)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 25)
        Label3.TabIndex = 7
        Label3.Text = "Price : "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label1.Location = New Point(335, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 25)
        Label1.TabIndex = 3
        Label1.Text = "Item Name : "
        ' 
        ' txtPrice
        ' 
        txtPrice.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        txtPrice.Location = New Point(90, 96)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(201, 31)
        txtPrice.TabIndex = 6
        ' 
        ' txtItemName
        ' 
        txtItemName.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        txtItemName.Location = New Point(462, 20)
        txtItemName.Name = "txtItemName"
        txtItemName.Size = New Size(201, 31)
        txtItemName.TabIndex = 2
        ' 
        ' ComboboxCategory
        ' 
        ComboboxCategory.FlatStyle = FlatStyle.Popup
        ComboboxCategory.FormattingEnabled = True
        ComboboxCategory.Location = New Point(827, 24)
        ComboboxCategory.Name = "ComboboxCategory"
        ComboboxCategory.Size = New Size(223, 28)
        ComboboxCategory.TabIndex = 0
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label8.Location = New Point(335, 95)
        Label8.Name = "Label8"
        Label8.Size = New Size(66, 25)
        Label8.TabIndex = 20
        Label8.Text = "GST  : "
        ' 
        ' TxtGST
        ' 
        TxtGST.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        TxtGST.Location = New Point(462, 92)
        TxtGST.Name = "TxtGST"
        TxtGST.Size = New Size(201, 31)
        TxtGST.TabIndex = 21
        ' 
        ' TxtItemId
        ' 
        TxtItemId.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        TxtItemId.Location = New Point(90, 20)
        TxtItemId.Name = "TxtItemId"
        TxtItemId.ReadOnly = True
        TxtItemId.Size = New Size(201, 31)
        TxtItemId.TabIndex = 20
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label4.Location = New Point(3, 23)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 25)
        Label4.TabIndex = 21
        Label4.Text = "Item ID :"
        ' 
        ' BunifuThinButton21
        ' 
        BunifuThinButton21.ActiveBorderThickness = 1
        BunifuThinButton21.ActiveCornerRadius = 20
        BunifuThinButton21.ActiveFillColor = Color.SeaGreen
        BunifuThinButton21.ActiveForecolor = Color.White
        BunifuThinButton21.ActiveLineColor = Color.SeaGreen
        BunifuThinButton21.BackColor = Color.Teal
        BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), Image)
        BunifuThinButton21.ButtonText = "Add Item"
        BunifuThinButton21.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BunifuThinButton21.ForeColor = Color.MidnightBlue
        BunifuThinButton21.IdleBorderThickness = 1
        BunifuThinButton21.IdleCornerRadius = 20
        BunifuThinButton21.IdleFillColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        BunifuThinButton21.IdleForecolor = Color.SeaGreen
        BunifuThinButton21.IdleLineColor = Color.SeaGreen
        BunifuThinButton21.Location = New Point(254, 185)
        BunifuThinButton21.Margin = New Padding(6, 5, 6, 5)
        BunifuThinButton21.Name = "BunifuThinButton21"
        BunifuThinButton21.Size = New Size(147, 56)
        BunifuThinButton21.TabIndex = 23
        BunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BunifuThinButton22
        ' 
        BunifuThinButton22.ActiveBorderThickness = 1
        BunifuThinButton22.ActiveCornerRadius = 20
        BunifuThinButton22.ActiveFillColor = Color.SeaGreen
        BunifuThinButton22.ActiveForecolor = Color.White
        BunifuThinButton22.ActiveLineColor = Color.SeaGreen
        BunifuThinButton22.BackColor = Color.Teal
        BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), Image)
        BunifuThinButton22.ButtonText = "Delete"
        BunifuThinButton22.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BunifuThinButton22.ForeColor = Color.MidnightBlue
        BunifuThinButton22.IdleBorderThickness = 1
        BunifuThinButton22.IdleCornerRadius = 20
        BunifuThinButton22.IdleFillColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        BunifuThinButton22.IdleForecolor = Color.SeaGreen
        BunifuThinButton22.IdleLineColor = Color.SeaGreen
        BunifuThinButton22.Location = New Point(650, 185)
        BunifuThinButton22.Margin = New Padding(6, 5, 6, 5)
        BunifuThinButton22.Name = "BunifuThinButton22"
        BunifuThinButton22.Size = New Size(147, 56)
        BunifuThinButton22.TabIndex = 24
        BunifuThinButton22.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BunifuThinButton23
        ' 
        BunifuThinButton23.ActiveBorderThickness = 1
        BunifuThinButton23.ActiveCornerRadius = 20
        BunifuThinButton23.ActiveFillColor = Color.SeaGreen
        BunifuThinButton23.ActiveForecolor = Color.White
        BunifuThinButton23.ActiveLineColor = Color.SeaGreen
        BunifuThinButton23.BackColor = Color.Teal
        BunifuThinButton23.BackgroundImage = CType(resources.GetObject("BunifuThinButton23.BackgroundImage"), Image)
        BunifuThinButton23.ButtonText = "Update"
        BunifuThinButton23.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BunifuThinButton23.ForeColor = Color.MidnightBlue
        BunifuThinButton23.IdleBorderThickness = 1
        BunifuThinButton23.IdleCornerRadius = 20
        BunifuThinButton23.IdleFillColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        BunifuThinButton23.IdleForecolor = Color.SeaGreen
        BunifuThinButton23.IdleLineColor = Color.SeaGreen
        BunifuThinButton23.Location = New Point(449, 185)
        BunifuThinButton23.Margin = New Padding(6, 5, 6, 5)
        BunifuThinButton23.Name = "BunifuThinButton23"
        BunifuThinButton23.Size = New Size(147, 56)
        BunifuThinButton23.TabIndex = 25
        BunifuThinButton23.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BunifuThinButton24
        ' 
        BunifuThinButton24.ActiveBorderThickness = 1
        BunifuThinButton24.ActiveCornerRadius = 20
        BunifuThinButton24.ActiveFillColor = Color.SeaGreen
        BunifuThinButton24.ActiveForecolor = Color.White
        BunifuThinButton24.ActiveLineColor = Color.SeaGreen
        BunifuThinButton24.BackColor = Color.Teal
        BunifuThinButton24.BackgroundImage = CType(resources.GetObject("BunifuThinButton24.BackgroundImage"), Image)
        BunifuThinButton24.ButtonText = "Clear"
        BunifuThinButton24.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BunifuThinButton24.ForeColor = Color.MidnightBlue
        BunifuThinButton24.IdleBorderThickness = 1
        BunifuThinButton24.IdleCornerRadius = 20
        BunifuThinButton24.IdleFillColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        BunifuThinButton24.IdleForecolor = Color.SeaGreen
        BunifuThinButton24.IdleLineColor = Color.SeaGreen
        BunifuThinButton24.Location = New Point(839, 185)
        BunifuThinButton24.Margin = New Padding(6, 5, 6, 5)
        BunifuThinButton24.Name = "BunifuThinButton24"
        BunifuThinButton24.Size = New Size(160, 56)
        BunifuThinButton24.TabIndex = 26
        BunifuThinButton24.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(BunifuThinButton24)
        Panel1.Controls.Add(BunifuThinButton23)
        Panel1.Controls.Add(BunifuThinButton22)
        Panel1.Controls.Add(BunifuThinButton21)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(TxtItemId)
        Panel1.Controls.Add(TxtGST)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(ComboboxCategory)
        Panel1.Controls.Add(txtItemName)
        Panel1.Controls.Add(txtPrice)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(12, 75)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1311, 246)
        Panel1.TabIndex = 15
        ' 
        ' BunifuThinButton25
        ' 
        BunifuThinButton25.ActiveBorderThickness = 1
        BunifuThinButton25.ActiveCornerRadius = 20
        BunifuThinButton25.ActiveFillColor = Color.SeaGreen
        BunifuThinButton25.ActiveForecolor = Color.White
        BunifuThinButton25.ActiveLineColor = Color.SeaGreen
        BunifuThinButton25.BackColor = Color.Teal
        BunifuThinButton25.BackgroundImage = CType(resources.GetObject("BunifuThinButton25.BackgroundImage"), Image)
        BunifuThinButton25.ButtonText = "Add Category"
        BunifuThinButton25.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BunifuThinButton25.ForeColor = Color.MidnightBlue
        BunifuThinButton25.IdleBorderThickness = 1
        BunifuThinButton25.IdleCornerRadius = 20
        BunifuThinButton25.IdleFillColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        BunifuThinButton25.IdleForecolor = Color.SeaGreen
        BunifuThinButton25.IdleLineColor = Color.SeaGreen
        BunifuThinButton25.Location = New Point(387, 29)
        BunifuThinButton25.Margin = New Padding(4)
        BunifuThinButton25.Name = "BunifuThinButton25"
        BunifuThinButton25.Size = New Size(122, 45)
        BunifuThinButton25.TabIndex = 27
        BunifuThinButton25.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' menuForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        CausesValidation = False
        ClientSize = New Size(1335, 745)
        Controls.Add(BunifuThinButton25)
        Controls.Add(Button2)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(dgvMenu)
        Controls.Add(Label7)
        Controls.Add(Panel1)
        Controls.Add(txtCategory)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "menuForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RESTAURANT MANAGEMENT SYSTEM"
        CType(dgvMenu, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvMenu As DataGridView
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents ComboboxCategory As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtGST As TextBox
    Friend WithEvents TxtItemId As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton23 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton24 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuThinButton25 As Bunifu.Framework.UI.BunifuThinButton2
End Class
