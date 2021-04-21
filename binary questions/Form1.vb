Public Class Form1
    Private unsigned As New Cunsigned
    Private signed As New Csigned
    Private fixed As New Cfixedpoint
    Private floating As New Cfloatingpoint
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = floating.generatefloatingpoint()
        MsgBox(floating.binarytodeanary(Label1.Text))
    End Sub
    Private Sub newquestion()
        Dim binorden As Integer
        binorden = unsigned.returnrandomnumber(1, 2)
        Dim binary As String
        Dim deanary As String
        Dim answer As String
        Select Case unsigned.returnrandomnumber(1, 4)

            Case 1 'unsigned
                binary = unsigned.generatebinary(8)
                deanary = unsigned.BinaryToDeanary(binary)
                If binorden = 1 Then

                Else

                End If

            Case 2 'signed


            Case 3 'fixed point


            Case 4 'floatingpoint


        End Select

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
