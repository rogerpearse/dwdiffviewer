Imports System.Text
Imports DwdiffViewer

<TestClass()>
Public Class UnitTest1

    Dim u As New Utils

    <TestMethod()>
    Public Sub TestEmptyString()
        Assert.AreEqual("", u.changeString(""))
        Assert.AreEqual("", u.changeString("        "))
        Assert.AreEqual("        " & "<br>", u.changeString("        " & vbCrLf))   '-- vbcrlf not empty string
    End Sub

    <TestMethod()>
    Public Sub TestPlaintext()
        Assert.AreEqual("1", u.changeString("1"))
    End Sub

    <TestMethod()>
    Public Sub TestGreen()
        Dim ts As String = "[-uita sancti-]"
        Assert.AreEqual("<span style=""color:green"">" + ts + "</span>", u.changeString(ts))
    End Sub

    <TestMethod()>
    Public Sub TestRed()
        Dim ts As String = "{+uita sancti+}"
        Assert.AreEqual("<span style=""color:red"">" + ts + "</span>", u.changeString(ts))
    End Sub

    <TestMethod()>
    Public Sub TestNewDiffNewLine()
        Dim ts As String = "[-uita sancti-]{+prologus in uitam beati+} nicolai"
        Assert.AreEqual("<br><span style=""color:green"">[-uita sancti-]</span><span style=""color:red"">{+prologus in uitam beati+}</span><br> nicolai", u.changeString(ts, True))
    End Sub

End Class
