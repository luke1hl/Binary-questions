Public Class Cunsigned
    Inherits Cbinary
    Overrides Function BinaryToDeanary(bin As String)
        Dim dig As String, p As Integer
        Dim dec, B, d As Integer
        p = 0
        For x As Integer = bin.Length - 1 To 0 Step -1
            dig = bin.Substring(x, 1)
            If Not (dig = "0" Or dig = "1") Then
                dec = 0
                MsgBox("Incorrect entry.  ")
                Exit For
            End If
            Double.TryParse(dig, B)
            d = B * (2 ^ p)
            dec = dec + d
            p = p + 1
        Next x
        Return dec 
    End Function
    Overrides Function deanarytobinary(dec As Double)
        Dim filler As String = ""
        Dim bin As Integer
        Dim output As String
        While dec <> 0
            If dec Mod 2 = 0 Then
                bin = 0
            Else
                bin = 1
            End If
            dec = dec \ 2
            output = Convert.ToString(bin) & output
        End While
        If output Is Nothing Then
            Return "0"
        Else
            If Len(output) <> 8 Then
                For i = Len(output) To 7
                    filler = filler & "0"
                Next
                output = filler & output
            End If
            Return output
        End If
    End Function
End Class


