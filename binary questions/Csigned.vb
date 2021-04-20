Public Class Csigned
    Inherits Cbinary
    Private converter As New Cunsigned
    Private holder As String
    Overrides Function binarytodeanary(bin As String)
        If bin(0) = "1" Then
            holder = "0"
            For i = 1 To bin.Length - 1
                holder = holder & bin(i)
            Next
            binarytodeanary(holder)
            Return converter.BinaryToDeanary(holder) - 128
        Else
            Return converter.BinaryToDeanary(bin)
        End If
    End Function
    Public Overrides Function deanarytobinary(dec As Double)

    End Function
End Class
