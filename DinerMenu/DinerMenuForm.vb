'Joshua Makuch
'RCET 0265
'Spring 2023
'Diner Menu Program
'https://github.com/JoshuaMakuch/DinerMenu.git

Option Strict On
Option Explicit On

Public Class DinerMenuForm

    'Exit Button
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    'Displays the soup of the day
    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        DisplaySpecialLabel.Text = $"~ Soup of the Day ~{vbCrLf}{vbCrLf}Literally Just Borscht"
    End Sub

    'Displays the chef's special
    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        DisplaySpecialLabel.Text = $"~ Special Artisanal Salad ~{vbCrLf}{vbCrLf}Machine picked, processed and plated head of iceberg lettuce, that's it :)"
    End Sub

    'Displays the daily fish
    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        DisplaySpecialLabel.Text = $"~ Fish, Possibly Fresh ~{vbCrLf}{vbCrLf}This flounder was found in the basement cellar of the restraunt, we cooked it, it tastes like wood glue, good luck!"
    End Sub

End Class
