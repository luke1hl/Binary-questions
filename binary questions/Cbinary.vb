Public MustInherit Class Cbinary
    Function returnrandomnumber(minim As Integer, maxim As Integer) 'random number generator
        Dim randomnumber As Integer
        Randomize()
        randomnumber = Int((maxim * Rnd()) + minim)
        Return randomnumber

    End Function
    Public MustOverride Function binarytodeanary(bin As String)


    Function generatebinary()
        Dim binarystring As String = ""
        For i = 0 To 7
            Dim oneorzero As Integer = returnrandomnumber(1, 1000)
            binarystring = binarystring & oneorzero Mod 2

        Next
        Return binarystring
    End Function

End Class
