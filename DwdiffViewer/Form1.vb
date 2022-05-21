Option Explicit On
Option Strict On
Public Class Form1

    Dim u As New Utils

    Dim fileString As String = ""

    Private Sub OpenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenToolStripMenuItem.Click

        OpenFileDialog1.Title = "Please select a file"
        OpenFileDialog1.InitialDirectory = "C:\users\roger\Desktop"
        OpenFileDialog1.Filter = "Dwdiff Output Files|*.txt"
        OpenFileDialog1.FileName = "*.txt"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK And OpenFileDialog1.FileName <> "" Then
            'Do things here, the path is stored in openFileDialog1.Filename
            'If no files were selected, openFileDialog1.Filename is ""  

            fileString = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            displayFile(My.Settings.NewDiffNewLine)
        End If
    End Sub

    ''' <summary>
    ''' Load the file into the browser with the new setting.  Each difference may be on a new line.
    ''' </summary>
    Private Sub displayFile(NewDiffNewLine As Boolean)

        If NewDiffNewLine Then
            WebBrowser1.DocumentText = u.changeString(fileString, NewDiffNewLine)
        Else
            WebBrowser1.DocumentText = u.changeString(fileString)
        End If
    End Sub

    Private Sub NewLineEachDiffToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewLineEachDiffToolStripMenuItem.Click

        '-- Change the menu tick
        NewLineEachDiffToolStripMenuItem.Checked = Not NewLineEachDiffToolStripMenuItem.Checked

        '-- Save to settings
        My.Settings.NewDiffNewLine = NewLineEachDiffToolStripMenuItem.Checked

        '-- Refresh display
        displayFile(My.Settings.NewDiffNewLine)
    End Sub

    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        NewLineEachDiffToolStripMenuItem.Checked = My.Settings.NewDiffNewLine
    End Sub
End Class
