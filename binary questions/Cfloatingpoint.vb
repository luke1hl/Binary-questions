Public Class Cfloatingpoint
    Inherits Cbinary
    Dim unsigned As Cunsigned
    Dim fixed As Cfixedpoint
    Public Overrides Function binarytodeanary(bin As String) As Object
        Dim isnegative As Boolean = False
        Dim mantissa As String
        Dim exponent As String
        Dim exponentinteger As Integer
        Dim holder As String = ""
        For i = 0 To 7
            mantissa &= bin(i)

        Next
        For i = 8 To bin.Length - 1
            exponent &= bin(i)
        Next

        If exponent(0) = "1" Then
            holder = "0"
            For i = 1 To 3
                holder &= exponent(i)
            Next
            exponentinteger = unsigned.BinaryToDeanary(holder) - 8
        Else
            exponentinteger = unsigned.BinaryToDeanary(exponent)
        End If

        If exponentinteger >= 0 Then
            exponentinteger += 1
            holder = ""
            For i = 0 To exponentinteger
                holder = holder & mantissa(i)
            Next
            holder &= "·"
            For i = exponentinteger + 1 To mantissa.Length - 1
                holder = holder & mantissa(i)

            Next
            mantissa = holder
            Return fixed.binarytodeanary(mantissa)
        Else
            holder = ""
            For i = 0 To exponentinteger * -1

            Next
        End If
    End Function
End Class
