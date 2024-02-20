<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtNumGifts = New TextBox()
        btnCalculate = New Button()
        btnClear = New Button()
        lstDisplay = New ListBox()
        cbxCategory = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Control
        Label1.Font = New Font("Segoe UI", 16F)
        Label1.Location = New Point(202, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(388, 59)
        Label1.TabIndex = 0
        Label1.Text = "Mystery Gift Giving"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(100, 129)
        Label2.Name = "Label2"
        Label2.Size = New Size(182, 45)
        Label2.TabIndex = 1
        Label2.Text = "No. of Gifts"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(74, 202)
        Label3.Name = "Label3"
        Label3.Size = New Size(208, 45)
        Label3.TabIndex = 2
        Label3.Text = "Gift Category"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F)
        Label4.Location = New Point(197, 287)
        Label4.Name = "Label4"
        Label4.Size = New Size(150, 37)
        Label4.TabIndex = 3
        Label4.Text = "B = budget"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F)
        Label5.Location = New Point(176, 360)
        Label5.Name = "Label5"
        Label5.Size = New Size(171, 37)
        Label5.TabIndex = 4
        Label5.Text = "M = medium"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F)
        Label6.Location = New Point(214, 430)
        Label6.Name = "Label6"
        Label6.Size = New Size(133, 37)
        Label6.TabIndex = 5
        Label6.Text = "L = luxury"
        ' 
        ' txtNumGifts
        ' 
        txtNumGifts.Location = New Point(467, 141)
        txtNumGifts.Name = "txtNumGifts"
        txtNumGifts.Size = New Size(242, 39)
        txtNumGifts.TabIndex = 6
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(489, 321)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(150, 46)
        btnCalculate.TabIndex = 8
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(489, 421)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(150, 46)
        btnClear.TabIndex = 9
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' lstDisplay
        ' 
        lstDisplay.FormattingEnabled = True
        lstDisplay.Location = New Point(74, 490)
        lstDisplay.Name = "lstDisplay"
        lstDisplay.Size = New Size(593, 196)
        lstDisplay.TabIndex = 10
        ' 
        ' cbxCategory
        ' 
        cbxCategory.FormattingEnabled = True
        cbxCategory.Items.AddRange(New Object() {"B", "M", "L"})
        cbxCategory.Location = New Point(467, 209)
        cbxCategory.Name = "cbxCategory"
        cbxCategory.Size = New Size(242, 40)
        cbxCategory.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PaleTurquoise
        ClientSize = New Size(774, 729)
        Controls.Add(cbxCategory)
        Controls.Add(lstDisplay)
        Controls.Add(btnClear)
        Controls.Add(btnCalculate)
        Controls.Add(txtNumGifts)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Mystery Gifts"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNumGifts As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lstDisplay As ListBox
    Friend WithEvents cbxCategory As ComboBox

End Class
