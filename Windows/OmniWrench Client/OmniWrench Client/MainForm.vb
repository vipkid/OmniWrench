Public Class MainForm

    Private Sub radHub_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radHub.CheckedChanged
        If radHub.Checked = True Then
            txtIP.Enabled = True
        Else
            txtIP.Enabled = False
        End If
    End Sub

    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Hide()
        icoTray.ShowBalloonTip(5000)
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IO.File.Exists(Application.StartupPath & "\Config.ini") Then
            txtPassword.Text = ReadINI("General", "Password", "", Application.StartupPath & "\Config.ini")
            txtPort.Value = CInt(ReadINI("General", "Port", "", Application.StartupPath & "\Config.ini"))
            Dim intDirect As Integer = ReadINI("General", "Direct", True, Application.StartupPath & "\Config.ini")
            If intDirect = 1 Then
                radDirect.Checked = True
                txtIP.Enabled = False
            ElseIf intDirect = 0 Then
                radHub.Checked = True
                txtIP.Enabled = True
                txtIP.Text = ReadINI("General", "IP", True, Application.StartupPath & "\Config.ini")
            End If
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    'Save
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        WriteINI("General", "Port", txtPort.Value, Application.StartupPath & "\Config.ini")
        WriteINI("General", "Password", txtPassword.Text, Application.StartupPath & "\Config.ini")
        If radDirect.Checked = True Then
            WriteINI("General", "Direct", "1", Application.StartupPath & "\Config.ini")
        ElseIf radHub.Checked = True Then
            WriteINI("General", "Direct", "0", Application.StartupPath & "\Config.ini")
            WriteINI("General", "IP", txtIP.Text, Application.StartupPath & "\Config.ini")
        End If
        Me.Hide()
        icoTray.ShowBalloonTip(5000)
    End Sub

    'Cancel
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Hide()
        icoTray.ShowBalloonTip(5000)
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        Me.Show()
    End Sub
End Class
