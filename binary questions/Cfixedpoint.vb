Public Class Cfixedpoint
    Inherits Cbinary

    Public Overrides Function binarytodeanary(bin As String) As Object
        Dim wholenumberstring As String
        Dim binarypoint As Integer
        Dim factorsnumberstring As String
        For i = 0 To bin.Length - 1
            If bin(i) = "·" Then
                binarypoint = i
            End If
        Next
        For i = 0 To 8 - binarypoint - 1

        Next
    End Function
End Class
