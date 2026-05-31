Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim amount As Decimal

        If Decimal.TryParse(txtAmount.Text, amount) Then
            Dim category As String = cmbCategory.Text

            Dim expenseText As String = category & " - R" & amount.ToString("0.00")
            lstExpenses.Items.Add(expenseText)

            ' Update total
            Dim total As Decimal = 0

            For Each item As String In lstExpenses.Items
                Dim valuePart As String = item.Split("R"c)(1)
                total += Decimal.Parse(valuePart)
            Next

            lblTotal.Text = "Total: R" & total.ToString("0.00")

            ' Clear input
            txtAmount.Clear()
        Else
            MessageBox.Show("Please enter a valid amount.")
        End If
    End Sub
End Class
