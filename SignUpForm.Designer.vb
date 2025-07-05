<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUpForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUpForm))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        txtName = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        txtPass = New TextBox()
        btnSignUp = New Button()
        BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        txtEmail = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        txtPhone = New TextBox()
        dgvMenu = New DataGridView()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        TxtSalary = New TextBox()
        CbStaffRole = New ComboBox()
        Label3 = New Label()
        Button2 = New Button()
        CType(dgvMenu, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BunifuFlatButton1
        ' 
        BunifuFlatButton1.Active = False
        BunifuFlatButton1.Activecolor = Color.White
        BunifuFlatButton1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        BunifuFlatButton1.BackColor = Color.White
        BunifuFlatButton1.BackgroundImage = CType(resources.GetObject("BunifuFlatButton1.BackgroundImage"), Image)
        BunifuFlatButton1.BackgroundImageLayout = ImageLayout.Zoom
        BunifuFlatButton1.BorderRadius = 0
        BunifuFlatButton1.ButtonText = ""
        BunifuFlatButton1.Cursor = Cursors.Hand
        BunifuFlatButton1.DisabledColor = Color.Gray
        BunifuFlatButton1.Iconcolor = Color.Transparent
        BunifuFlatButton1.Iconimage = Nothing
        BunifuFlatButton1.Iconimage_right = Nothing
        BunifuFlatButton1.Iconimage_right_Selected = Nothing
        BunifuFlatButton1.Iconimage_Selected = Nothing
        BunifuFlatButton1.IconMarginLeft = 0
        BunifuFlatButton1.IconMarginRight = 0
        BunifuFlatButton1.IconRightVisible = True
        BunifuFlatButton1.IconRightZoom = 0R
        BunifuFlatButton1.IconVisible = True
        BunifuFlatButton1.IconZoom = 90R
        BunifuFlatButton1.IsTab = False
        BunifuFlatButton1.Location = New Point(1226, 356)
        BunifuFlatButton1.Margin = New Padding(4, 5, 4, 5)
        BunifuFlatButton1.Name = "BunifuFlatButton1"
        BunifuFlatButton1.Normalcolor = Color.White
        BunifuFlatButton1.OnHovercolor = Color.White
        BunifuFlatButton1.OnHoverTextColor = Color.White
        BunifuFlatButton1.selected = False
        BunifuFlatButton1.Size = New Size(43, 27)
        BunifuFlatButton1.TabIndex = 17
        BunifuFlatButton1.TextAlign = ContentAlignment.MiddleLeft
        BunifuFlatButton1.Textcolor = Color.White
        BunifuFlatButton1.TextFont = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BunifuFlatButton1.Visible = False
        ' 
        ' txtName
        ' 
        txtName.Cursor = Cursors.Hand
        txtName.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtName.Location = New Point(735, 251)
        txtName.Margin = New Padding(4)
        txtName.Name = "txtName"
        txtName.Size = New Size(215, 30)
        txtName.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Cursor = Cursors.Hand
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label2.Location = New Point(1012, 327)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(168, 25)
        Label2.TabIndex = 13
        Label2.Text = "Account Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Cursor = Cursors.Hand
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label1.Location = New Point(735, 221)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(143, 25)
        Label1.TabIndex = 14
        Label1.Text = "Staff Username"
        ' 
        ' txtPass
        ' 
        txtPass.Cursor = Cursors.Hand
        txtPass.Location = New Point(1008, 356)
        txtPass.Margin = New Padding(4)
        txtPass.Name = "txtPass"
        txtPass.PasswordChar = "*"c
        txtPass.Size = New Size(215, 27)
        txtPass.TabIndex = 12
        ' 
        ' btnSignUp
        ' 
        btnSignUp.AutoEllipsis = True
        btnSignUp.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        btnSignUp.Cursor = Cursors.Hand
        btnSignUp.FlatAppearance.BorderSize = 0
        btnSignUp.FlatAppearance.MouseOverBackColor = Color.Black
        btnSignUp.FlatStyle = FlatStyle.Popup
        btnSignUp.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSignUp.ForeColor = Color.White
        btnSignUp.Location = New Point(911, 577)
        btnSignUp.Margin = New Padding(4)
        btnSignUp.Name = "btnSignUp"
        btnSignUp.Size = New Size(168, 54)
        btnSignUp.TabIndex = 10
        btnSignUp.Text = "Add Staff"
        btnSignUp.UseVisualStyleBackColor = False
        ' 
        ' BunifuFlatButton2
        ' 
        BunifuFlatButton2.Active = False
        BunifuFlatButton2.Activecolor = Color.White
        BunifuFlatButton2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        BunifuFlatButton2.BackColor = Color.White
        BunifuFlatButton2.BackgroundImage = CType(resources.GetObject("BunifuFlatButton2.BackgroundImage"), Image)
        BunifuFlatButton2.BackgroundImageLayout = ImageLayout.Zoom
        BunifuFlatButton2.BorderRadius = 0
        BunifuFlatButton2.ButtonText = ""
        BunifuFlatButton2.Cursor = Cursors.Hand
        BunifuFlatButton2.DisabledColor = Color.Gray
        BunifuFlatButton2.Iconcolor = Color.Transparent
        BunifuFlatButton2.Iconimage = Nothing
        BunifuFlatButton2.Iconimage_right = Nothing
        BunifuFlatButton2.Iconimage_right_Selected = Nothing
        BunifuFlatButton2.Iconimage_Selected = Nothing
        BunifuFlatButton2.IconMarginLeft = 0
        BunifuFlatButton2.IconMarginRight = 0
        BunifuFlatButton2.IconRightVisible = True
        BunifuFlatButton2.IconRightZoom = 0R
        BunifuFlatButton2.IconVisible = True
        BunifuFlatButton2.IconZoom = 90R
        BunifuFlatButton2.IsTab = False
        BunifuFlatButton2.Location = New Point(1226, 356)
        BunifuFlatButton2.Margin = New Padding(4, 5, 4, 5)
        BunifuFlatButton2.Name = "BunifuFlatButton2"
        BunifuFlatButton2.Normalcolor = Color.White
        BunifuFlatButton2.OnHovercolor = Color.White
        BunifuFlatButton2.OnHoverTextColor = Color.White
        BunifuFlatButton2.selected = False
        BunifuFlatButton2.Size = New Size(43, 27)
        BunifuFlatButton2.TabIndex = 18
        BunifuFlatButton2.TextAlign = ContentAlignment.MiddleLeft
        BunifuFlatButton2.Textcolor = Color.White
        BunifuFlatButton2.TextFont = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' txtEmail
        ' 
        txtEmail.Cursor = Cursors.Hand
        txtEmail.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmail.Location = New Point(1008, 251)
        txtEmail.Margin = New Padding(4)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(215, 30)
        txtEmail.TabIndex = 19
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Cursor = Cursors.Hand
        Label4.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label4.Location = New Point(735, 327)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(139, 25)
        Label4.TabIndex = 21
        Label4.Text = "Staff Phone no"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Cursor = Cursors.Hand
        Label5.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label5.Location = New Point(1014, 221)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(104, 25)
        Label5.TabIndex = 22
        Label5.Text = "Staff Email"
        ' 
        ' txtPhone
        ' 
        txtPhone.Cursor = Cursors.Hand
        txtPhone.Location = New Point(735, 356)
        txtPhone.Margin = New Padding(4)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(215, 27)
        txtPhone.TabIndex = 20
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
        dgvMenu.Location = New Point(32, 37)
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
        dgvMenu.Size = New Size(604, 649)
        dgvMenu.TabIndex = 23
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Cursor = Cursors.Hand
        Label6.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label6.Location = New Point(250, 6)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(87, 25)
        Label6.TabIndex = 24
        Label6.Text = "Staff List"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Cursor = Cursors.Hand
        Label7.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label7.Location = New Point(735, 422)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(96, 25)
        Label7.TabIndex = 14
        Label7.Text = "Staff Role"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Cursor = Cursors.Hand
        Label8.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label8.Location = New Point(1014, 422)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(65, 25)
        Label8.TabIndex = 22
        Label8.Text = "Salary"
        ' 
        ' TxtSalary
        ' 
        TxtSalary.Cursor = Cursors.Hand
        TxtSalary.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtSalary.Location = New Point(1008, 452)
        TxtSalary.Margin = New Padding(4)
        TxtSalary.Name = "TxtSalary"
        TxtSalary.Size = New Size(215, 30)
        TxtSalary.TabIndex = 19
        ' 
        ' CbStaffRole
        ' 
        CbStaffRole.FormattingEnabled = True
        CbStaffRole.Location = New Point(734, 455)
        CbStaffRole.Name = "CbStaffRole"
        CbStaffRole.Size = New Size(216, 28)
        CbStaffRole.TabIndex = 26
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(940, 26)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(118, 28)
        Label3.TabIndex = 0
        Label3.Text = "ADD STAFF"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(1287, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(30, 26)
        Button2.TabIndex = 59
        Button2.UseVisualStyleBackColor = False
        ' 
        ' SignUpForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        ClientSize = New Size(1317, 698)
        ControlBox = False
        Controls.Add(Button2)
        Controls.Add(Label3)
        Controls.Add(CbStaffRole)
        Controls.Add(Label6)
        Controls.Add(dgvMenu)
        Controls.Add(TxtSalary)
        Controls.Add(txtEmail)
        Controls.Add(Label4)
        Controls.Add(Label8)
        Controls.Add(Label5)
        Controls.Add(txtPhone)
        Controls.Add(BunifuFlatButton1)
        Controls.Add(txtName)
        Controls.Add(Label7)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtPass)
        Controls.Add(btnSignUp)
        Controls.Add(BunifuFlatButton2)
        FormBorderStyle = FormBorderStyle.None
        Name = "SignUpForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SignUpForm"
        CType(dgvMenu, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents btnSignUp As Button
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents dgvMenu As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtSalary As TextBox
    Friend WithEvents CbStaffRole As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
End Class
