Public Class Cfloatingpoint
    Inherits Cbinary
    Dim unsigned As New Cunsigned
    Dim fixed As New Cfixedpoint
    Public Overrides Function binarytodeanary(bin As String) As Object
        Dim isnegative As Boolean = False
        Dim mantissa As String
        Dim exponent As String
        Dim mantissainteger As Double
        Dim exponentinteger As Integer
        Dim holder As String = ""
        For i = 0 To 7
            mantissa &= bin(i)

        Next
        For i = 8 To bin.Length - 1
            exponent &= bin(i)
        Next
        ' MsgBox(exponent)
        'MsgBox(mantissa)
        If exponent(0) = "1" Then
            holder = "0"
            For i = 1 To 3
                holder &= exponent(i)
            Next
            exponentinteger = unsigned.BinaryToDeanary(holder) - 8
        Else
            exponentinteger = unsigned.BinaryToDeanary(exponent)
        End If

        holder = mantissa(0)
        holder &= "·"
        For i = 1 To mantissa.Length - 1
            holder &= mantissa(i)

        Next
        mantissainteger = fixed.binarytodeanary(holder)
        Return mantissainteger & "*2^" & exponentinteger
    End Function
End Class
