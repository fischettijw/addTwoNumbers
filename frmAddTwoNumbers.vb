Public Class frmAddTwoNumbers
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        btnAdd.Text = CInt(txtFirst.Text) + CInt(txtSecond.Text)
    End Sub

    Private Sub FrmAddTwoNumbers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As Integer
    End Sub
End Class
