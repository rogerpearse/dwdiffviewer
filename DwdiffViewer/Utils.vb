Option Explicit On
Option Strict On
Public Class Utils

    Public Function changeString(instr As String) As String

        If Trim(instr) = "" Then Return ""

        Dim outstring As String = instr _
                                  .Replace(vbCrLf, "<br>") _
                                  .Replace(vbLf, "<br>") _
                                  .Replace("]", "]</span>") _
                                  .Replace("}", "}</span>") _
                                  .Replace("[-", "<span style=""color:green"">[-") _
                                  .Replace("{+", "<span style=""color:red"">{+")

        Return outstring
    End Function


End Class
