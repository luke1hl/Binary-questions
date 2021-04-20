Public Class Form1
    Private unsigned As New Cunsigned
    Private signed As New Csigned
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = unsigned.generatebinary()
        MsgBox(signed.binarytodeanary(Label1.Text))
    End Sub
End Class
