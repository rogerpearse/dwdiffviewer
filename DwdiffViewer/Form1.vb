Option Explicit On
Option Strict On
Public Class Form1

    Dim u As New Utils

    Private Sub OpenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenToolStripMenuItem.Click

        OpenFileDialog1.Title = "Please select a file"
        OpenFileDialog1.InitialDirectory = "C:\users\roger\Desktop"
        OpenFileDialog1.Filter = "Dwdiff Output Files|*.txt"
        OpenFileDialog1.FileName = "*.txt"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK And OpenFileDialog1.FileName <> "" Then
            'Do things here, the path is stored in openFileDialog1.Filename
            'If no files were selected, openFileDialog1.Filename is ""  

            Dim fileString As String = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)

            WebBrowser1.DocumentText = u.changeString(fileString)
        End If
    End Sub


End Class
