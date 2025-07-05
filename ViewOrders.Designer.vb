<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reportForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reportForm))
        dgvReports = New DataGridView()
        Label6 = New Label()
        btnExportToCSV = New Button()
        Button2 = New Button()
        BtnFilter = New Button()
        CType(dgvReports, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvReports
        ' 
        dgvReports.AllowUserToAddRows = False
        dgvReports.AllowUserToDeleteRows = False
        dgvReports.AllowUserToResizeColumns = False
        dgvReports.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.Blue
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        dgvReports.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvReports.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvReports.BackgroundColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        dgvReports.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.Blue
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvReports.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = SystemColors.Window
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvReports.DefaultCellStyle = DataGridViewCellStyle3
        dgvReports.Location = New Point(12, 110)
        dgvReports.MultiSelect = False
        dgvReports.Name = "dgvReports"
        dgvReports.ReadOnly = True
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = Color.White
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.Black
        DataGridViewCellStyle4.SelectionBackColor = Color.Blue
        DataGridViewCellStyle4.SelectionForeColor = Color.Black
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvReports.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvReports.RowHeadersVisible = False
        dgvReports.RowHeadersWidth = 51
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = Color.White
        DataGridViewCellStyle5.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = Color.Black
        DataGridViewCellStyle5.SelectionBackColor = Color.Blue
        DataGridViewCellStyle5.SelectionForeColor = Color.White
        dgvReports.RowsDefaultCellStyle = DataGridViewCellStyle5
        dgvReports.Size = New Size(1293, 576)
        dgvReports.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(625, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(166, 31)
        Label6.TabIndex = 18
        Label6.Text = "VIEW ORDERS"
        ' 
        ' btnExportToCSV
        ' 
        btnExportToCSV.Location = New Point(1200, 59)
        btnExportToCSV.Name = "btnExportToCSV"
        btnExportToCSV.Size = New Size(94, 29)
        btnExportToCSV.TabIndex = 41
        btnExportToCSV.Text = "Export"
        btnExportToCSV.UseVisualStyleBackColor = True
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
        Button2.TabIndex = 57
        Button2.UseVisualStyleBackColor = False
        ' 
        ' BtnFilter
        ' 
        BtnFilter.Location = New Point(1024, 60)
        BtnFilter.Name = "BtnFilter"
        BtnFilter.Size = New Size(153, 29)
        BtnFilter.TabIndex = 58
        BtnFilter.Text = "Filter Colorwise"
        BtnFilter.UseVisualStyleBackColor = True
        ' 
        ' reportForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        ClientSize = New Size(1317, 698)
        Controls.Add(BtnFilter)
        Controls.Add(Button2)
        Controls.Add(btnExportToCSV)
        Controls.Add(Label6)
        Controls.Add(dgvReports)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "reportForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "View Orders"
        CType(dgvReports, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvReports As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents btnExportToCSV As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnFilter As Button
End Class
