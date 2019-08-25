Public Class frmAddTwoNumbers
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        btnAdd.Text = CInt(txtFirst.Text) + CInt(txtSecond.Text)
    End Sub
End Class
