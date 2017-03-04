Imports System.Net
Imports System.IO

Public Class MainForm

#Region "Command Input"

    Private Sub FilesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilesToolStripMenuItem.Click
        cmd.AutoCompleteSource = AutoCompleteSource.FileSystem
        FilesToolStripMenuItem.Checked = True
        DirectoriesToolStripMenuItem.Checked = False
        URLsToolStripMenuItem.Checked = False
        HistoryToolStripMenuItem.Checked = False
        CommandsToolStripMenuItem.Checked = False
        AllToolStripMenuItem.Checked = False
    End Sub

    Private Sub DirectoriesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DirectoriesToolStripMenuItem.Click
        cmd.AutoCompleteSource = AutoCompleteSource.FileSystemDirectories
        FilesToolStripMenuItem.Checked = False
        DirectoriesToolStripMenuItem.Checked = True
        URLsToolStripMenuItem.Checked = False
        HistoryToolStripMenuItem.Checked = False
        CommandsToolStripMenuItem.Checked = False
        AllToolStripMenuItem.Checked = False
    End Sub

    Private Sub URLsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles URLsToolStripMenuItem.Click
        cmd.AutoCompleteSource = AutoCompleteSource.AllUrl
        FilesToolStripMenuItem.Checked = False
        DirectoriesToolStripMenuItem.Checked = False
        URLsToolStripMenuItem.Checked = True
        HistoryToolStripMenuItem.Checked = False
        CommandsToolStripMenuItem.Checked = False
        AllToolStripMenuItem.Checked = False
    End Sub

    Private Sub HistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistoryToolStripMenuItem.Click
        cmd.AutoCompleteSource = AutoCompleteSource.HistoryList
        FilesToolStripMenuItem.Checked = False
        DirectoriesToolStripMenuItem.Checked = False
        URLsToolStripMenuItem.Checked = False
        HistoryToolStripMenuItem.Checked = True
        CommandsToolStripMenuItem.Checked = False
        AllToolStripMenuItem.Checked = False
    End Sub

    Private Sub CommandsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandsToolStripMenuItem.Click
        cmd.AutoCompleteSource = AutoCompleteSource.CustomSource
        FilesToolStripMenuItem.Checked = False
        DirectoriesToolStripMenuItem.Checked = False
        URLsToolStripMenuItem.Checked = False
        HistoryToolStripMenuItem.Checked = False
        CommandsToolStripMenuItem.Checked = True
        AllToolStripMenuItem.Checked = False
    End Sub

    Private Sub AllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllToolStripMenuItem.Click
        cmd.AutoCompleteSource = AutoCompleteSource.AllSystemSources
        FilesToolStripMenuItem.Checked = False
        DirectoriesToolStripMenuItem.Checked = False
        URLsToolStripMenuItem.Checked = False
        HistoryToolStripMenuItem.Checked = False
        CommandsToolStripMenuItem.Checked = False
        AllToolStripMenuItem.Checked = True
    End Sub

    Private Sub ClearTextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearTextToolStripMenuItem.Click
        cmd.Clear()
    End Sub

#End Region

#Region "General Fuctions"
    Public Sub Print(ByVal Prompt As String)
        out.AppendText(Prompt & vbCrLf)
    End Sub
#End Region

#Region "Menu Bar"

    Private Sub HelpToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripButton.Click
        HelpForm.Show()
    End Sub

    Private Sub AddToolStripButton_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles AddToolStripButton.MouseEnter
        AddToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
    End Sub

    Private Sub AddToolStripButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles AddToolStripButton.MouseLeave
        AddToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
    End Sub

    Private Sub ServerToolStripButton_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ServerToolStripButton.MouseEnter
        ServerToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
    End Sub

    Private Sub ServerToolStripButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ServerToolStripButton.MouseLeave
        ServerToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
    End Sub

    Private Sub ClientToolStripButton_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ClientToolStripButton.MouseEnter
        ClientToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
    End Sub

    Private Sub ClientToolStripButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ClientToolStripButton.MouseLeave
        ClientToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
    End Sub

    Private Sub RemoveStripButton_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RemoveStripButton.MouseEnter
        RemoveStripButton.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
    End Sub

    Private Sub RemoveStripButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles RemoveStripButton.MouseLeave
        RemoveStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
    End Sub

    Private Sub DirectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DirectToolStripMenuItem.Click
        DirectToolStripMenuItem.Checked = True
        HubToolStripMenuItem.Checked = False
        HubServerSettingsToolStripMenuItem.Visible = False
        ConnectToolStripSeparator.Visible = False
        DeviceToolStripSeparator.Visible = True
        AddToolStripButton.Visible = True
        RemoveStripButton.Visible = True
    End Sub

    Private Sub HubToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HubToolStripMenuItem.Click
        DirectToolStripMenuItem.Checked = False
        HubToolStripMenuItem.Checked = True
        HubServerSettingsToolStripMenuItem.Visible = True
        ConnectToolStripSeparator.Visible = True
        DeviceToolStripSeparator.Visible = False
        AddToolStripButton.Visible = False
        RemoveStripButton.Visible = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AddToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripButton.Click
        AddForm.ShowDialog()
    End Sub

    Private Sub HubServerSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HubServerSettingsToolStripMenuItem.Click
        AddForm.ShowDialog()
    End Sub


#End Region

#Region "Form"
    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Exit OmniWrench?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
#End Region

End Class
