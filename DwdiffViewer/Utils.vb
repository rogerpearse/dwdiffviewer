Option Explicit On
Option Strict On
Public Class Utils

    Public Function changeString(instr As String, Optional NewDiffNewLine As Boolean = False) As String

        If Trim(instr) = "" Then Return ""

        Dim outstring As String = instr

        '-- Put each difference onto a new line
        If NewDiffNewLine Then
            outstring = outstring.Replace("[-", "<br>[-").Replace("+}", "+}<br>")
            '.Replace(" {+", " <br>{+") _
            '.Replace("-] ", "-]<br> ")
        End If

        outstring = outstring _
            .Replace(vbCrLf, "<br>") _
            .Replace(vbLf, "<br>") _
                                  .Replace("]", "]</span>") _
                                  .Replace("}", "}</span>") _
                                  .Replace("[-", "<span style=""color:green"">[-") _
                                  .Replace("{+", "<span style=""color:red"">{+")


        Return outstring
    End Function


End Class
