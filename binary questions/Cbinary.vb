Public MustInherit Class Cbinary
    Function returnrandomnumber(minim As Integer, maxim As Integer) 'random number generator
        Dim randomnumber As Integer
        Randomize()
        randomnumber = Int((maxim * Rnd()) + minim)
        Return randomnumber

    End Function
    Public MustOverride Function binarytodeanary(bin As String)


    Function generatebinary(length As Integer)
        Dim binarystring As String = ""
        For i = 0 To length - 1
            Dim oneorzero As Integer = returnrandomnumber(1, 1000)
            binarystring = binarystring & oneorzero Mod 2

        Next
        Return binarystring
    End Function
    Function generatefixedpoint()
        Dim pointinstring As Integer = returnrandomnumber(1, 6)
        Dim binarynum As String
        Dim properbinarystring As String = ""
        binarynum = generatebinary(8)
        For i = 0 To pointinstring
            properbinarystring = properbinarystring & binarynum(i)

        Next
        properbinarystring = properbinarystring & "·"
        For i = pointinstring + 1 To binarynum.Length - 1
            properbinarystring = properbinarystring & binarynum(pointinstring)
        Next
        Return properbinarystring
    End Function

    Function generatefloatingpoint()
        Dim exponent As String = generatebinary(4)
        Dim mantissa As String = generatebinary(8)

    End Function
End Class
