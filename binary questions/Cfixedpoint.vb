Public Class Cfixedpoint
    Inherits Cbinary
    Dim converter As New Cunsigned
    Public Overrides Function binarytodeanary(bin As String) As Object
        Dim wholenumberstring As String
        Dim totalnumber As Double
        Dim binarypoint As Integer
        Dim factorsnumberstring As String = ""
        For i = 0 To bin.Length - 1
            If bin(i) = "·" Then
                binarypoint = i
            End If
        Next


        For i = 0 To 8 - binarypoint - 1
            wholenumberstring = wholenumberstring & "0"

        Next
        For i = 0 To binarypoint - 1
            wholenumberstring = wholenumberstring & bin(i)
        Next


        For i = binarypoint + 1 To 8
            factorsnumberstring = factorsnumberstring & bin(i)
            ' MsgBox(factorsnumberstring)
        Next
        For i = factorsnumberstring.Length To 7
            factorsnumberstring = factorsnumberstring & "0"
        Next

        totalnumber += converter.BinaryToDeanary(wholenumberstring)

        For i = 0 To factorsnumberstring.Length - 1
            If factorsnumberstring(i) = "1" Then
                totalnumber += 0.5 ^ i + 1
            End If
        Next
        Return totalnumber
    End Function
End Class
