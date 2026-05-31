<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        lblAmount = New Label()
        txtAmount = New TextBox()
        lblCategory = New Label()
        cmbCategory = New ComboBox()
        btnAdd = New Button()
        lstExpenses = New ListBox()
        lblTotal = New Label()
        SuspendLayout()
        ' 
        ' lblAmount
        ' 
        lblAmount.AutoSize = True
        lblAmount.Location = New Point(34, 28)
        lblAmount.Margin = New Padding(4, 0, 4, 0)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(51, 15)
        lblAmount.TabIndex = 0
        lblAmount.Text = "Amount"
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(150, 25)
        txtAmount.Margin = New Padding(4, 3, 4, 3)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(121, 23)
        txtAmount.TabIndex = 1
        ' 
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.Location = New Point(34, 57)
        lblCategory.Margin = New Padding(4, 0, 4, 0)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(55, 15)
        lblCategory.TabIndex = 2
        lblCategory.Text = "Category"
        ' 
        ' cmbCategory
        ' 
        cmbCategory.FormattingEnabled = True
        cmbCategory.Items.AddRange(New Object() {"Food", "Transport", "Entertainment", "Other"})
        cmbCategory.Location = New Point(150, 54)
        cmbCategory.Margin = New Padding(4, 3, 4, 3)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(121, 23)
        cmbCategory.TabIndex = 3
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(34, 82)
        btnAdd.Margin = New Padding(4, 3, 4, 3)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(102, 23)
        btnAdd.TabIndex = 4
        btnAdd.Text = "Add Expense"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' lstExpenses
        ' 
        lstExpenses.FormattingEnabled = True
        lstExpenses.Location = New Point(34, 111)
        lstExpenses.Margin = New Padding(4, 3, 4, 3)
        lstExpenses.Name = "lstExpenses"
        lstExpenses.Size = New Size(178, 124)
        lstExpenses.TabIndex = 5
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(33, 238)
        lblTotal.Margin = New Padding(4, 0, 4, 0)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(52, 15)
        lblTotal.TabIndex = 6
        lblTotal.Text = "Total: R0"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(284, 265)
        Controls.Add(lblTotal)
        Controls.Add(lstExpenses)
        Controls.Add(btnAdd)
        Controls.Add(cmbCategory)
        Controls.Add(lblCategory)
        Controls.Add(txtAmount)
        Controls.Add(lblAmount)
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        Text = "Expense Tracker"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblAmount As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents lstExpenses As ListBox
    Friend WithEvents lblTotal As Label

End Class
