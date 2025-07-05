<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KOTForm
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
        Label3 = New Label()
        LVKOT = New ListView()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(652, 9)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 28)
        Label3.TabIndex = 1
        Label3.Text = "KOT"
        ' 
        ' LVKOT
        ' 
        LVKOT.Location = New Point(451, 63)
        LVKOT.Name = "LVKOT"
        LVKOT.Size = New Size(391, 365)
        LVKOT.TabIndex = 2
        LVKOT.UseCompatibleStateImageBehavior = False
        ' 
        ' KOTForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        ClientSize = New Size(1317, 698)
        Controls.Add(LVKOT)
        Controls.Add(Label3)
        Name = "KOTForm"
        Text = "KOTForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents LVKOT As ListView
End Class
