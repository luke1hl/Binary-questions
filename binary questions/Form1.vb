Public Class Form1
    Private unsigned As New Cunsigned
    Private signed As New Csigned
    Private fixed As New Cfixedpoint
    Private floating As New Cfloatingpoint
    Private answer As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        newquestion()
        answerbox.Text = ""
        answerbox.ReadOnly = False
        Button3.Enabled = True
        Button2.Enabled = True
        confirm.Enabled = True
    End Sub
    Private Sub newquestion()
        Dim binorden As Integer
        binorden = unsigned.returnrandomnumber(1, 2)
        Dim binary As String
        Dim deanary As String
        Select Case unsigned.returnrandomnumber(1, 4)

            Case 1 'unsigned
                binary = unsigned.generatebinary(8)
                deanary = unsigned.BinaryToDeanary(binary)
                If binorden = 1 Then
                    answer = binary
                    Label1.Text = "using unsigned binary convert " & deanary & " to binary"

                Else
                    answer = deanary
                    Label1.Text = "using unsigned binary convert " & binary & " to deanary"

                End If
            Case 2 'signed
                binary = signed.generatebinary(8)
                deanary = signed.binarytodeanary(binary)
                If binorden = 1 Then
                    answer = binary
                    Label1.Text = "using twos complement convert " & deanary & " to binary"

                Else
                    answer = deanary
                    Label1.Text = "using twos complement convert " & binary & " to deanary"

                End If

            Case 3 'fixed point
                binary = fixed.generatefixedpoint()
                deanary = fixed.binarytodeanary(binary)
                If binorden = 1 Then
                    answer = binary
                    Label1.Text = "using fixed point convert " & deanary & " to binary"

                Else
                    answer = deanary
                    Label1.Text = "using signed binary convert " & binary & " to deanary"

                End If

            Case 4 'floatingpoint
                binary = floating.generatefloatingpoint()
                deanary = floating.binarytodeanary(binary)
                If binorden = 1 Then
                    answer = binary
                    Label1.Text = "using floating point binary convert " & deanary & " to binary"

                Else
                    answer = deanary
                    Label1.Text = "using floating point binary convert " & binary & " to deanary"

                End If

        End Select
        My.Computer.Clipboard.SetText(answer)
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        answerbox.Text &= "*2^"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        answerbox.Text &= "·"
    End Sub

    Private Sub confirm_Click(sender As Object, e As EventArgs) Handles confirm.Click
        If answerbox.Text = answer Then
            Label1.Text = "well done you got it correct"
            correct.Text += 1
        Else
            Label1.Text = "unlucky, the correct answer is " & answer
            incorrect.Text += 1

        End If
        answerbox.ReadOnly = True
        Button3.Enabled = False
        confirm.Enabled = False
        Button2.Enabled = False
    End Sub
End Class
