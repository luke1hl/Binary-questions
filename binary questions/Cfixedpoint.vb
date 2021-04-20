Public Class Cfixedpoint
    Inherits Cbinary
    Dim converter As New Cunsigned
    Public Overrides Function binarytodeanary(bin As String) As Object
        Dim wholenumberstring As String
        Dim totalnumber As Double
        Dim isnegative As Boolean = False
        Dim binarypoint As Integer
        Dim factorsnumberstring As String = ""
        For i = 0 To bin.Length - 1
            If bin(i) = "·" Then
                binarypoint = i - 1
            End If
        Next

        If bin(0) = "1" Then
            isnegative = True
            wholenumberstring = "0"
            For i = 1 To bin.Length - 1

                wholenumberstring = wholenumberstring & bin(i)

            Next
            bin = wholenumberstring
            wholenumberstring = ""
        End If
        MsgBox(bin)

        For i = 0 To binarypoint
            wholenumberstring = wholenumberstring & bin(i)
        Next


        For i = binarypoint + 2 To bin.Length - 1
            factorsnumberstring = factorsnumberstring & bin(i)
            ' MsgBox(factorsnumberstring)
        Next

        MsgBox(wholenumberstring)
        totalnumber += converter.BinaryToDeanary(wholenumberstring)
        MsgBox(totalnumber)
        For i = 0 To factorsnumberstring.Length - 1
            If factorsnumberstring(i) = "1" Then
                totalnumber += 0.5 ^ (i + 1)
            End If
        Next
        If isnegative = True Then
            totalnumber -= 2 ^ binarypoint

        End If
        Return totalnumber
    End Function
End Class
