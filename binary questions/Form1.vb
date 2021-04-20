Public Class Form1
    Private unsigned As New Cunsigned
    Private signed As New Csigned
    Private fixed As New Cfixedpoint
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = fixed.generatefixedpoint()
        MsgBox(fixed.binarytodeanary(Label1.Text))
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
