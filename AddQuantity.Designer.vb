<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddQuantity
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddQuantity))
        ButtonReduce = New Button()
        TextBoxQuantity = New TextBox()
        ButtonAdd = New Button()
        TxtAmount = New TextBox()
        BtnSave = New Button()
        SuspendLayout()
        ' 
        ' ButtonReduce
        ' 
        ButtonReduce.BackColor = Color.Red
        ButtonReduce.BackgroundImage = CType(resources.GetObject("ButtonReduce.BackgroundImage"), Image)
        ButtonReduce.BackgroundImageLayout = ImageLayout.Zoom
        ButtonReduce.FlatStyle = FlatStyle.Popup
        ButtonReduce.Location = New Point(80, 100)
        ButtonReduce.Name = "ButtonReduce"
        ButtonReduce.Size = New Size(68, 40)
        ButtonReduce.TabIndex = 0
        ButtonReduce.UseVisualStyleBackColor = False
        ' 
        ' TextBoxQuantity
        ' 
        TextBoxQuantity.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBoxQuantity.Location = New Point(174, 101)
        TextBoxQuantity.Name = "TextBoxQuantity"
        TextBoxQuantity.Size = New Size(112, 43)
        TextBoxQuantity.TabIndex = 2
        ' 
        ' ButtonAdd
        ' 
        ButtonAdd.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        ButtonAdd.BackgroundImage = CType(resources.GetObject("ButtonAdd.BackgroundImage"), Image)
        ButtonAdd.BackgroundImageLayout = ImageLayout.Zoom
        ButtonAdd.FlatStyle = FlatStyle.Popup
        ButtonAdd.Location = New Point(310, 99)
        ButtonAdd.Name = "ButtonAdd"
        ButtonAdd.Size = New Size(66, 41)
        ButtonAdd.TabIndex = 3
        ButtonAdd.UseVisualStyleBackColor = False
        ' 
        ' TxtAmount
        ' 
        TxtAmount.Location = New Point(189, 114)
        TxtAmount.Name = "TxtAmount"
        TxtAmount.Size = New Size(77, 27)
        TxtAmount.TabIndex = 4
        ' 
        ' BtnSave
        ' 
        BtnSave.BackColor = Color.Turquoise
        BtnSave.FlatAppearance.BorderSize = 0
        BtnSave.FlatStyle = FlatStyle.Popup
        BtnSave.Location = New Point(327, 185)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(94, 29)
        BtnSave.TabIndex = 5
        BtnSave.Text = "Save"
        BtnSave.UseVisualStyleBackColor = False
        ' 
        ' AddQuantity
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        ClientSize = New Size(478, 282)
        ControlBox = False
        Controls.Add(TextBoxQuantity)
        Controls.Add(BtnSave)
        Controls.Add(ButtonAdd)
        Controls.Add(ButtonReduce)
        Controls.Add(TxtAmount)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "AddQuantity"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "AddQuantity"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ButtonReduce As Button
    Friend WithEvents TextBoxQuantity As TextBox
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents TxtAmount As TextBox
    Friend WithEvents BtnSave As Button
End Class
