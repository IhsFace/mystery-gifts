Public Class Form1
    Dim strSelectedCategory As String
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intNumGifts As Integer = Val(txtNumGifts.Text)
        Dim intPrice As Integer
        Dim strSelectedCategoryName As String

        ' If an invalid amount of gifts is entered then an error is returned in a message box
        If intNumGifts <= 0 Then
            MsgBox("Please input the number of gifts you wish to purchase.")
            txtNumGifts.Focus()
            Return
        End If

        ' The total price is set depending on the category selected in the combo box
        Select Case strSelectedCategory
            Case "B"
                strSelectedCategoryName = "Budget"
                intPrice = intNumGifts * 10
            Case "M"
                strSelectedCategoryName = "Medium"
                intPrice = intNumGifts * 25
            Case "L"
                strSelectedCategoryName = "Luxury"
                intPrice = intNumGifts * 50
            Case Else
                MsgBox("Please select a price category.")
                cbxCategory.Focus()
                Return
        End Select

        ' Text is added to the list box
        lstDisplay.Items.Add("You wish to purchase " & intNumGifts & " gifts.")
        lstDisplay.Items.Add("Your selected price category is: " & strSelectedCategoryName)
        lstDisplay.Items.Add("The total price of your selection is $" & intPrice)
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' All text is cleared and the selected category is deselected when the clear button is clicked
        txtNumGifts.Clear()
        cbxCategory.SelectedIndex = -1
        lstDisplay.Items.Clear()
        txtNumGifts.Focus()
    End Sub
    Private Sub cbxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategory.SelectedIndexChanged
        ' If a category is selected then the selected category is set to a variable
        If cbxCategory.SelectedIndex <> -1 Then
            strSelectedCategory = cbxCategory.SelectedItem.ToString()
        End If
    End Sub
End Class
