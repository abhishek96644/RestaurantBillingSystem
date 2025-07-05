<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        btnReports = New Button()
        btnMenu = New Button()
        btnOrders = New Button()
        Panel1 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        BtnAddStaff = New Button()
        Button2 = New Button()
        BtnRoles = New Button()
        btnlogout = New Button()
        lblRole = New Label()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnReports
        ' 
        btnReports.FlatAppearance.BorderSize = 0
        btnReports.FlatStyle = FlatStyle.Flat
        btnReports.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        btnReports.Image = CType(resources.GetObject("btnReports.Image"), Image)
        btnReports.ImageAlign = ContentAlignment.MiddleLeft
        btnReports.Location = New Point(3, 336)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(238, 76)
        btnReports.TabIndex = 1
        btnReports.Text = "Reports"
        btnReports.TextAlign = ContentAlignment.MiddleLeft
        btnReports.TextImageRelation = TextImageRelation.ImageBeforeText
        btnReports.UseVisualStyleBackColor = True
        ' 
        ' btnMenu
        ' 
        btnMenu.FlatAppearance.BorderSize = 0
        btnMenu.FlatStyle = FlatStyle.Flat
        btnMenu.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        btnMenu.Image = CType(resources.GetObject("btnMenu.Image"), Image)
        btnMenu.ImageAlign = ContentAlignment.MiddleLeft
        btnMenu.Location = New Point(0, 84)
        btnMenu.Name = "btnMenu"
        btnMenu.Size = New Size(238, 76)
        btnMenu.TabIndex = 3
        btnMenu.Text = "Manage Items"
        btnMenu.TextAlign = ContentAlignment.MiddleLeft
        btnMenu.TextImageRelation = TextImageRelation.ImageBeforeText
        btnMenu.UseVisualStyleBackColor = True
        ' 
        ' btnOrders
        ' 
        btnOrders.FlatAppearance.BorderSize = 0
        btnOrders.FlatStyle = FlatStyle.Flat
        btnOrders.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        btnOrders.Image = CType(resources.GetObject("btnOrders.Image"), Image)
        btnOrders.ImageAlign = ContentAlignment.MiddleLeft
        btnOrders.Location = New Point(0, 168)
        btnOrders.Name = "btnOrders"
        btnOrders.Size = New Size(238, 76)
        btnOrders.TabIndex = 4
        btnOrders.Text = "Manage Orders"
        btnOrders.TextAlign = ContentAlignment.MiddleLeft
        btnOrders.TextImageRelation = TextImageRelation.ImageBeforeText
        btnOrders.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(BtnAddStaff)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(BtnRoles)
        Panel1.Controls.Add(btnlogout)
        Panel1.Controls.Add(btnReports)
        Panel1.Controls.Add(btnOrders)
        Panel1.Controls.Add(btnMenu)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(238, 874)
        Panel1.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Teal
        Label1.Font = New Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Lavender
        Label1.Location = New Point(66, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(165, 21)
        Label1.TabIndex = 10
        Label1.Text = "Laziz Restaurant"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(58, 62)
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' BtnAddStaff
        ' 
        BtnAddStaff.FlatAppearance.BorderSize = 0
        BtnAddStaff.FlatStyle = FlatStyle.Flat
        BtnAddStaff.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        BtnAddStaff.Image = CType(resources.GetObject("BtnAddStaff.Image"), Image)
        BtnAddStaff.ImageAlign = ContentAlignment.MiddleLeft
        BtnAddStaff.Location = New Point(0, 420)
        BtnAddStaff.Name = "BtnAddStaff"
        BtnAddStaff.Size = New Size(238, 76)
        BtnAddStaff.TabIndex = 8
        BtnAddStaff.Text = "Add Staff"
        BtnAddStaff.TextAlign = ContentAlignment.MiddleLeft
        BtnAddStaff.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnAddStaff.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(3, 252)
        Button2.Name = "Button2"
        Button2.Size = New Size(238, 76)
        Button2.TabIndex = 7
        Button2.Text = "Billing"
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.TextImageRelation = TextImageRelation.ImageBeforeText
        Button2.UseVisualStyleBackColor = True
        ' 
        ' BtnRoles
        ' 
        BtnRoles.FlatAppearance.BorderSize = 0
        BtnRoles.FlatStyle = FlatStyle.Flat
        BtnRoles.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        BtnRoles.Image = CType(resources.GetObject("BtnRoles.Image"), Image)
        BtnRoles.ImageAlign = ContentAlignment.MiddleLeft
        BtnRoles.Location = New Point(0, 504)
        BtnRoles.Name = "BtnRoles"
        BtnRoles.Size = New Size(238, 76)
        BtnRoles.TabIndex = 5
        BtnRoles.Text = "Roles"
        BtnRoles.TextAlign = ContentAlignment.MiddleLeft
        BtnRoles.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnRoles.UseVisualStyleBackColor = True
        ' 
        ' btnlogout
        ' 
        btnlogout.FlatAppearance.BorderSize = 0
        btnlogout.FlatStyle = FlatStyle.Flat
        btnlogout.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        btnlogout.Image = CType(resources.GetObject("btnlogout.Image"), Image)
        btnlogout.ImageAlign = ContentAlignment.MiddleLeft
        btnlogout.Location = New Point(-3, 588)
        btnlogout.Name = "btnlogout"
        btnlogout.Size = New Size(238, 76)
        btnlogout.TabIndex = 5
        btnlogout.Text = "Logout"
        btnlogout.TextAlign = ContentAlignment.MiddleLeft
        btnlogout.TextImageRelation = TextImageRelation.ImageBeforeText
        btnlogout.UseVisualStyleBackColor = True
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Font = New Font("Perpetua Titling MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRole.Location = New Point(1289, 14)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(96, 28)
        lblRole.TabIndex = 0
        lblRole.Text = "Label1"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Lavender
        Panel2.Controls.Add(lblRole)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(238, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1425, 59)
        Panel2.TabIndex = 6
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1663, 874)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        IsMdiContainer = True
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RESTAURANT BILLING SYSTEM"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnReports As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents btnOrders As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnlogout As Button
    Friend WithEvents lblRole As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnAddStaff As Button
    Friend WithEvents BtnRoles As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
