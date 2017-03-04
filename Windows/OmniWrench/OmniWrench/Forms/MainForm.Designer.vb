<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"CYRO4S-GOWZ7M", "Online"}, 1)
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"CYRO4S-ASUSPC", "Online"}, 1)
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("CYRO4S-THINKPAD", 1)
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"CYRO4S-SRVCNTC", "Online"}, 0)
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"CYRO4S-SRVCNAL", "Online"}, 0)
        Dim ListViewItem13 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"CYRO4S-SRVUSRH", "Online"}, 0)
        Dim ListViewItem14 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"CYRO4S-SRVHKYP", "Online"}, 0)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.mnuMain = New System.Windows.Forms.ToolStrip()
        Me.DeviceToolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.status = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lst = New System.Windows.Forms.ListView()
        Me.out = New System.Windows.Forms.TextBox()
        Me.cmd = New System.Windows.Forms.TextBox()
        Me.mnuCmd = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AutoCompleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.imgOS = New System.Windows.Forms.ImageList(Me.components)
        Me.FilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DirectoriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.URLsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommandsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SettingsToolStripButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.WorkingModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DirectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HubToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectToolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.HubServerSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TempToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.RemoveStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ServerToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ClientToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Hostname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Online = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mnuMain.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.mnuCmd.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripButton, Me.SettingsToolStripButton, Me.DeviceToolStripSeparator, Me.AddToolStripButton, Me.status, Me.RemoveStripButton, Me.ToolStripSeparator1, Me.ServerToolStripButton, Me.ClientToolStripButton})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(850, 25)
        Me.mnuMain.TabIndex = 0
        '
        'DeviceToolStripSeparator
        '
        Me.DeviceToolStripSeparator.Name = "DeviceToolStripSeparator"
        Me.DeviceToolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'status
        '
        Me.status.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(0, 22)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.lst)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.out)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmd)
        Me.SplitContainer1.Size = New System.Drawing.Size(850, 553)
        Me.SplitContainer1.SplitterDistance = 282
        Me.SplitContainer1.TabIndex = 1
        '
        'lst
        '
        Me.lst.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Hostname, Me.Online})
        Me.lst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lst.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem8, ListViewItem9, ListViewItem10, ListViewItem11, ListViewItem12, ListViewItem13, ListViewItem14})
        Me.lst.LargeImageList = Me.imgOS
        Me.lst.Location = New System.Drawing.Point(0, 0)
        Me.lst.Name = "lst"
        Me.lst.Size = New System.Drawing.Size(282, 553)
        Me.lst.TabIndex = 0
        Me.lst.UseCompatibleStateImageBehavior = False
        Me.lst.View = System.Windows.Forms.View.Tile
        '
        'out
        '
        Me.out.BackColor = System.Drawing.Color.White
        Me.out.Dock = System.Windows.Forms.DockStyle.Fill
        Me.out.Location = New System.Drawing.Point(0, 0)
        Me.out.Multiline = True
        Me.out.Name = "out"
        Me.out.ReadOnly = True
        Me.out.Size = New System.Drawing.Size(564, 527)
        Me.out.TabIndex = 1
        '
        'cmd
        '
        Me.cmd.AutoCompleteCustomSource.AddRange(New String() {"IO.DIRECTORY.CREATE()", "IO.DIRECTORY.REMOVE()", "IO.FILE.CREATE()", "IO.FILE.WRITE(,)", "IO.FILE.REMOVE()", "IO.COPY(,)", "IO.MOVE(,)", "IO.LIST()", "SYS.STATE.HALT", "SYS.STATE.REBOOT", "SYS.PROC.KILLBYPID()", "SYS.PROC.KILLBYNAME()", "SYS.PROC.LIST", "SYS.INFO.LIST", "SYS.INFO.RAM", "SYS.INFO.IP", "SYS.INFO.CPU", "SYS.INFO.OS", "SYS.SHELL()", "NET.FILE.DOWNLOAD(,)", "NET.FILE.UPLOAD(,)", "NET.GET(,)"})
        Me.cmd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmd.ContextMenuStrip = Me.mnuCmd
        Me.cmd.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmd.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd.Location = New System.Drawing.Point(0, 527)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(564, 26)
        Me.cmd.TabIndex = 0
        '
        'mnuCmd
        '
        Me.mnuCmd.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AutoCompleteToolStripMenuItem, Me.ClearTextToolStripMenuItem})
        Me.mnuCmd.Name = "mnuCmd"
        Me.mnuCmd.Size = New System.Drawing.Size(164, 48)
        '
        'AutoCompleteToolStripMenuItem
        '
        Me.AutoCompleteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilesToolStripMenuItem, Me.DirectoriesToolStripMenuItem, Me.URLsToolStripMenuItem, Me.HistoryToolStripMenuItem, Me.CommandsToolStripMenuItem, Me.ToolStripSeparator2, Me.AllToolStripMenuItem})
        Me.AutoCompleteToolStripMenuItem.Name = "AutoCompleteToolStripMenuItem"
        Me.AutoCompleteToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.AutoCompleteToolStripMenuItem.Text = "Auto Complete"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(139, 6)
        '
        'imgOS
        '
        Me.imgOS.ImageStream = CType(resources.GetObject("imgOS.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgOS.TransparentColor = System.Drawing.Color.Transparent
        Me.imgOS.Images.SetKeyName(0, "linux")
        Me.imgOS.Images.SetKeyName(1, "windows")
        '
        'FilesToolStripMenuItem
        '
        Me.FilesToolStripMenuItem.Image = Global.OmniWrench.My.Resources.Resources.Files_7954
        Me.FilesToolStripMenuItem.Name = "FilesToolStripMenuItem"
        Me.FilesToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.FilesToolStripMenuItem.Text = "Files"
        '
        'DirectoriesToolStripMenuItem
        '
        Me.DirectoriesToolStripMenuItem.Image = Global.OmniWrench.My.Resources.Resources.folder_Closed_16xLG
        Me.DirectoriesToolStripMenuItem.Name = "DirectoriesToolStripMenuItem"
        Me.DirectoriesToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.DirectoriesToolStripMenuItem.Text = "Directories"
        '
        'URLsToolStripMenuItem
        '
        Me.URLsToolStripMenuItem.Image = Global.OmniWrench.My.Resources.Resources.WebForm_ASPX__815_16x
        Me.URLsToolStripMenuItem.Name = "URLsToolStripMenuItem"
        Me.URLsToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.URLsToolStripMenuItem.Text = "URLs"
        '
        'HistoryToolStripMenuItem
        '
        Me.HistoryToolStripMenuItem.Image = Global.OmniWrench.My.Resources.Resources.clock_16xLG
        Me.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem"
        Me.HistoryToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.HistoryToolStripMenuItem.Text = "History"
        '
        'CommandsToolStripMenuItem
        '
        Me.CommandsToolStripMenuItem.Checked = True
        Me.CommandsToolStripMenuItem.CheckOnClick = True
        Me.CommandsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CommandsToolStripMenuItem.Image = Global.OmniWrench.My.Resources.Resources.Indent_11692_exp
        Me.CommandsToolStripMenuItem.Name = "CommandsToolStripMenuItem"
        Me.CommandsToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.CommandsToolStripMenuItem.Text = "Commands"
        '
        'AllToolStripMenuItem
        '
        Me.AllToolStripMenuItem.Image = Global.OmniWrench.My.Resources.Resources.Object_554_exp
        Me.AllToolStripMenuItem.Name = "AllToolStripMenuItem"
        Me.AllToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.AllToolStripMenuItem.Text = "All"
        '
        'ClearTextToolStripMenuItem
        '
        Me.ClearTextToolStripMenuItem.Image = Global.OmniWrench.My.Resources.Resources.Clearwindowcontent_6304
        Me.ClearTextToolStripMenuItem.Name = "ClearTextToolStripMenuItem"
        Me.ClearTextToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ClearTextToolStripMenuItem.Text = "Clear Text"
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HelpToolStripButton.Image = Global.OmniWrench.My.Resources.Resources.StatusAnnotations_Information_16xLG_color
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.HelpToolStripButton.Text = "&Help"
        '
        'SettingsToolStripButton
        '
        Me.SettingsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SettingsToolStripButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WorkingModeToolStripMenuItem, Me.TempToolStripMenuItem, Me.ToolStripSeparator5, Me.ExitToolStripMenuItem})
        Me.SettingsToolStripButton.Image = Global.OmniWrench.My.Resources.Resources.gear_16xLG
        Me.SettingsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SettingsToolStripButton.Name = "SettingsToolStripButton"
        Me.SettingsToolStripButton.Size = New System.Drawing.Size(29, 22)
        Me.SettingsToolStripButton.Text = "Settings"
        '
        'WorkingModeToolStripMenuItem
        '
        Me.WorkingModeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DirectToolStripMenuItem, Me.HubToolStripMenuItem, Me.ConnectToolStripSeparator, Me.HubServerSettingsToolStripMenuItem})
        Me.WorkingModeToolStripMenuItem.Image = Global.OmniWrench.My.Resources.Resources.arrow_Sync_16xLG
        Me.WorkingModeToolStripMenuItem.Name = "WorkingModeToolStripMenuItem"
        Me.WorkingModeToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.WorkingModeToolStripMenuItem.Text = "Device Connecting"
        '
        'DirectToolStripMenuItem
        '
        Me.DirectToolStripMenuItem.Checked = True
        Me.DirectToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DirectToolStripMenuItem.Image = Global.OmniWrench.My.Resources.Resources.arrow_Next_16xLG
        Me.DirectToolStripMenuItem.Name = "DirectToolStripMenuItem"
        Me.DirectToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.DirectToolStripMenuItem.Text = "Direct Connect"
        '
        'HubToolStripMenuItem
        '
        Me.HubToolStripMenuItem.Image = Global.OmniWrench.My.Resources.Resources.arrow_open_16xLG
        Me.HubToolStripMenuItem.Name = "HubToolStripMenuItem"
        Me.HubToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.HubToolStripMenuItem.Text = "Hub Server"
        '
        'ConnectToolStripSeparator
        '
        Me.ConnectToolStripSeparator.Name = "ConnectToolStripSeparator"
        Me.ConnectToolStripSeparator.Size = New System.Drawing.Size(201, 6)
        Me.ConnectToolStripSeparator.Visible = False
        '
        'HubServerSettingsToolStripMenuItem
        '
        Me.HubServerSettingsToolStripMenuItem.Name = "HubServerSettingsToolStripMenuItem"
        Me.HubServerSettingsToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.HubServerSettingsToolStripMenuItem.Text = "Hub Server Settings ..."
        Me.HubServerSettingsToolStripMenuItem.Visible = False
        '
        'TempToolStripMenuItem
        '
        Me.TempToolStripMenuItem.Image = Global.OmniWrench.My.Resources.Resources.expander_16xLG
        Me.TempToolStripMenuItem.Name = "TempToolStripMenuItem"
        Me.TempToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.TempToolStripMenuItem.Text = "Local Directory ..."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(180, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ExitToolStripMenuItem.Text = "Exit ..."
        '
        'AddToolStripButton
        '
        Me.AddToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddToolStripButton.Image = Global.OmniWrench.My.Resources.Resources.action_add_16xLG
        Me.AddToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddToolStripButton.Name = "AddToolStripButton"
        Me.AddToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AddToolStripButton.Text = "Add Device"
        '
        'RemoveStripButton
        '
        Me.RemoveStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RemoveStripButton.Image = Global.OmniWrench.My.Resources.Resources.Clearallrequests_8816
        Me.RemoveStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RemoveStripButton.Name = "RemoveStripButton"
        Me.RemoveStripButton.Size = New System.Drawing.Size(23, 22)
        Me.RemoveStripButton.Text = "Remove Device"
        '
        'ServerToolStripButton
        '
        Me.ServerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ServerToolStripButton.Image = Global.OmniWrench.My.Resources.Resources.GenerateMethod_318
        Me.ServerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ServerToolStripButton.Name = "ServerToolStripButton"
        Me.ServerToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ServerToolStripButton.Text = "Generate Server"
        '
        'ClientToolStripButton
        '
        Me.ClientToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClientToolStripButton.Image = Global.OmniWrench.My.Resources.Resources.CubePreview
        Me.ClientToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClientToolStripButton.Name = "ClientToolStripButton"
        Me.ClientToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ClientToolStripButton.Text = "Generate Client"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 578)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.mnuMain)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OmniWrench"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.mnuCmd.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMain As System.Windows.Forms.ToolStrip
    Friend WithEvents AddToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents HelpToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents lst As System.Windows.Forms.ListView
    Friend WithEvents out As System.Windows.Forms.TextBox
    Friend WithEvents cmd As System.Windows.Forms.TextBox
    Friend WithEvents mnuCmd As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AutoCompleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DirectoriesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents URLsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CommandsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearTextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents status As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ServerToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ClientToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents DeviceToolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SettingsToolStripButton As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents WorkingModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DirectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HubToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ConnectToolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HubServerSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TempToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents imgOS As System.Windows.Forms.ImageList
    Friend WithEvents Hostname As System.Windows.Forms.ColumnHeader
    Friend WithEvents Online As System.Windows.Forms.ColumnHeader

End Class
