<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        btnLogin = New Button()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label3 = New Label()
        Button2 = New Button()
        BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.AutoEllipsis = True
        btnLogin.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        btnLogin.Cursor = Cursors.Hand
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatAppearance.MouseOverBackColor = Color.Black
        btnLogin.FlatStyle = FlatStyle.Popup
        btnLogin.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(891, 542)
        btnLogin.Margin = New Padding(4)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(206, 66)
        btnLogin.TabIndex = 0
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' txtUsername
        ' 
        txtUsername.Cursor = Cursors.Hand
        txtUsername.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(750, 316)
        txtUsername.Margin = New Padding(4)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(488, 30)
        txtUsername.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.Cursor = Cursors.Hand
        txtPassword.Location = New Point(750, 450)
        txtPassword.Margin = New Padding(4)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(488, 31)
        txtPassword.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Cursor = Cursors.Hand
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label1.Location = New Point(750, 275)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 25)
        Label1.TabIndex = 3
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Cursor = Cursors.Hand
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label2.Location = New Point(750, 415)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 25)
        Label2.TabIndex = 3
        Label2.Text = "Password"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(1672, -1)
        Button1.Margin = New Padding(4)
        Button1.Name = "Button1"
        Button1.Size = New Size(58, 46)
        Button1.TabIndex = 4
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Panel1.Location = New Point(-1, 0)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(648, 796)
        Panel1.TabIndex = 5
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Teal
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(673, 45)
        Panel2.Margin = New Padding(4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(649, 117)
        Panel2.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(156, 42)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(375, 28)
        Label3.TabIndex = 0
        Label3.Text = "RESTAURANT MANAGEMENT SYSTEM"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(1292, -3)
        Button2.Name = "Button2"
        Button2.Size = New Size(47, 43)
        Button2.TabIndex = 7
        Button2.UseVisualStyleBackColor = False
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
        BunifuFlatButton1.Location = New Point(1240, 455)
        BunifuFlatButton1.Margin = New Padding(4, 5, 4, 5)
        BunifuFlatButton1.Name = "BunifuFlatButton1"
        BunifuFlatButton1.Normalcolor = Color.White
        BunifuFlatButton1.OnHovercolor = Color.White
        BunifuFlatButton1.OnHoverTextColor = Color.White
        BunifuFlatButton1.selected = False
        BunifuFlatButton1.Size = New Size(43, 23)
        BunifuFlatButton1.TabIndex = 8
        BunifuFlatButton1.TextAlign = ContentAlignment.MiddleLeft
        BunifuFlatButton1.Textcolor = Color.White
        BunifuFlatButton1.TextFont = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BunifuFlatButton1.Visible = False
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
        BunifuFlatButton2.Location = New Point(1240, 454)
        BunifuFlatButton2.Margin = New Padding(4, 5, 4, 5)
        BunifuFlatButton2.Name = "BunifuFlatButton2"
        BunifuFlatButton2.Normalcolor = Color.White
        BunifuFlatButton2.OnHovercolor = Color.White
        BunifuFlatButton2.OnHoverTextColor = Color.White
        BunifuFlatButton2.selected = False
        BunifuFlatButton2.Size = New Size(43, 23)
        BunifuFlatButton2.TabIndex = 9
        BunifuFlatButton2.TextAlign = ContentAlignment.MiddleLeft
        BunifuFlatButton2.Textcolor = Color.White
        BunifuFlatButton2.TextFont = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(11F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1335, 745)
        Controls.Add(BunifuFlatButton1)
        Controls.Add(Button2)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Button1)
        Controls.Add(txtUsername)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtPassword)
        Controls.Add(btnLogin)
        Controls.Add(BunifuFlatButton2)
        Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4)
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RESTAURANT MANAGEMENT SYSTEM"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton

End Class
