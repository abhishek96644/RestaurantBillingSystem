<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRoles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddRoles))
        dgvRoles = New DataGridView()
        Label4 = New Label()
        Label1 = New Label()
        BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        BtnUpdate = New Bunifu.Framework.UI.BunifuThinButton2()
        BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        TxtRole = New TextBox()
        BunifuThinButton24 = New Bunifu.Framework.UI.BunifuThinButton2()
        Button2 = New Button()
        CType(dgvRoles, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvRoles
        ' 
        dgvRoles.AllowUserToAddRows = False
        dgvRoles.AllowUserToDeleteRows = False
        dgvRoles.AllowUserToResizeColumns = False
        dgvRoles.AllowUserToResizeRows = False
        dgvRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRoles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvRoles.BackgroundColor = SystemColors.ControlLightLight
        dgvRoles.BorderStyle = BorderStyle.Fixed3D
        dgvRoles.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.InactiveCaptionText
        DataGridViewCellStyle1.Padding = New Padding(5)
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvRoles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRoles.Cursor = Cursors.Hand
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvRoles.DefaultCellStyle = DataGridViewCellStyle2
        dgvRoles.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvRoles.EnableHeadersVisualStyles = False
        dgvRoles.GridColor = Color.Black
        dgvRoles.ImeMode = ImeMode.On
        dgvRoles.Location = New Point(852, 39)
        dgvRoles.Name = "dgvRoles"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvRoles.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvRoles.RowHeadersVisible = False
        dgvRoles.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        dgvRoles.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRoles.ShowEditingIcon = False
        dgvRoles.Size = New Size(453, 647)
        dgvRoles.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label4.Location = New Point(1045, 8)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 25)
        Label4.TabIndex = 22
        Label4.Text = "Roles List:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label1.Location = New Point(69, 90)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 25)
        Label1.TabIndex = 22
        Label1.Text = "Role"
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
        BunifuThinButton21.ButtonText = "Add"
        BunifuThinButton21.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BunifuThinButton21.ForeColor = Color.MidnightBlue
        BunifuThinButton21.IdleBorderThickness = 1
        BunifuThinButton21.IdleCornerRadius = 20
        BunifuThinButton21.IdleFillColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        BunifuThinButton21.IdleForecolor = Color.SeaGreen
        BunifuThinButton21.IdleLineColor = Color.SeaGreen
        BunifuThinButton21.Location = New Point(33, 365)
        BunifuThinButton21.Margin = New Padding(6, 5, 6, 5)
        BunifuThinButton21.Name = "BunifuThinButton21"
        BunifuThinButton21.Size = New Size(147, 56)
        BunifuThinButton21.TabIndex = 24
        BunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnUpdate
        ' 
        BtnUpdate.ActiveBorderThickness = 1
        BtnUpdate.ActiveCornerRadius = 20
        BtnUpdate.ActiveFillColor = Color.SeaGreen
        BtnUpdate.ActiveForecolor = Color.White
        BtnUpdate.ActiveLineColor = Color.SeaGreen
        BtnUpdate.BackColor = Color.Teal
        BtnUpdate.BackgroundImage = CType(resources.GetObject("BtnUpdate.BackgroundImage"), Image)
        BtnUpdate.ButtonText = "Update"
        BtnUpdate.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnUpdate.ForeColor = Color.MidnightBlue
        BtnUpdate.IdleBorderThickness = 1
        BtnUpdate.IdleCornerRadius = 20
        BtnUpdate.IdleFillColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        BtnUpdate.IdleForecolor = Color.SeaGreen
        BtnUpdate.IdleLineColor = Color.SeaGreen
        BtnUpdate.Location = New Point(203, 364)
        BtnUpdate.Margin = New Padding(6, 5, 6, 5)
        BtnUpdate.Name = "BtnUpdate"
        BtnUpdate.Size = New Size(147, 56)
        BtnUpdate.TabIndex = 26
        BtnUpdate.TextAlign = ContentAlignment.MiddleCenter
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
        BunifuThinButton22.Location = New Point(382, 364)
        BunifuThinButton22.Margin = New Padding(6, 5, 6, 5)
        BunifuThinButton22.Name = "BunifuThinButton22"
        BunifuThinButton22.Size = New Size(147, 56)
        BunifuThinButton22.TabIndex = 27
        BunifuThinButton22.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TxtRole
        ' 
        TxtRole.Location = New Point(69, 118)
        TxtRole.Name = "TxtRole"
        TxtRole.Size = New Size(303, 27)
        TxtRole.TabIndex = 28
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
        BunifuThinButton24.Location = New Point(560, 364)
        BunifuThinButton24.Margin = New Padding(6, 5, 6, 5)
        BunifuThinButton24.Name = "BunifuThinButton24"
        BunifuThinButton24.Size = New Size(160, 56)
        BunifuThinButton24.TabIndex = 29
        BunifuThinButton24.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(1286, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(30, 26)
        Button2.TabIndex = 58
        Button2.UseVisualStyleBackColor = False
        ' 
        ' AddRoles
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        ClientSize = New Size(1317, 698)
        Controls.Add(Button2)
        Controls.Add(BunifuThinButton24)
        Controls.Add(TxtRole)
        Controls.Add(BunifuThinButton22)
        Controls.Add(BtnUpdate)
        Controls.Add(BunifuThinButton21)
        Controls.Add(Label1)
        Controls.Add(Label4)
        Controls.Add(dgvRoles)
        FormBorderStyle = FormBorderStyle.None
        Name = "AddRoles"
        Text = "AddRoles"
        CType(dgvRoles, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvRoles As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BtnUpdate As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents TxtRole As TextBox
    Friend WithEvents BunifuThinButton24 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Button2 As Button
End Class
