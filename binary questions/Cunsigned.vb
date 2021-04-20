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

End Class


