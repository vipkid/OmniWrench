<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelpForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HelpForm))
        Me.tabHelp = New System.Windows.Forms.TabControl()
        Me.tabCommands = New System.Windows.Forms.TabPage()
        Me.brwCommands = New System.Windows.Forms.WebBrowser()
        Me.tabConnection = New System.Windows.Forms.TabPage()
        Me.tabDevices = New System.Windows.Forms.TabPage()
        Me.tabAbout = New System.Windows.Forms.TabPage()
        Me.tabHelp.SuspendLayout()
        Me.tabCommands.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabHelp
        '
        Me.tabHelp.Controls.Add(Me.tabCommands)
        Me.tabHelp.Controls.Add(Me.tabConnection)
        Me.tabHelp.Controls.Add(Me.tabDevices)
        Me.tabHelp.Controls.Add(Me.tabAbout)
        Me.tabHelp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabHelp.Location = New System.Drawing.Point(0, 0)
        Me.tabHelp.Name = "tabHelp"
        Me.tabHelp.SelectedIndex = 0
        Me.tabHelp.Size = New System.Drawing.Size(609, 467)
        Me.tabHelp.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabHelp.TabIndex = 0
        '
        'tabCommands
        '
        Me.tabCommands.Controls.Add(Me.brwCommands)
        Me.tabCommands.Location = New System.Drawing.Point(4, 26)
        Me.tabCommands.Name = "tabCommands"
        Me.tabCommands.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCommands.Size = New System.Drawing.Size(601, 437)
        Me.tabCommands.TabIndex = 0
        Me.tabCommands.Text = "Commands"
        Me.tabCommands.UseVisualStyleBackColor = True
        '
        'brwCommands
        '
        Me.brwCommands.Dock = System.Windows.Forms.DockStyle.Fill
        Me.brwCommands.IsWebBrowserContextMenuEnabled = False
        Me.brwCommands.Location = New System.Drawing.Point(3, 3)
        Me.brwCommands.MinimumSize = New System.Drawing.Size(20, 20)
        Me.brwCommands.Name = "brwCommands"
        Me.brwCommands.Size = New System.Drawing.Size(595, 431)
        Me.brwCommands.TabIndex = 0
        '
        'tabConnection
        '
        Me.tabConnection.Location = New System.Drawing.Point(4, 26)
        Me.tabConnection.Name = "tabConnection"
        Me.tabConnection.Padding = New System.Windows.Forms.Padding(3)
        Me.tabConnection.Size = New System.Drawing.Size(601, 437)
        Me.tabConnection.TabIndex = 3
        Me.tabConnection.Text = "Connection"
        Me.tabConnection.UseVisualStyleBackColor = True
        '
        'tabDevices
        '
        Me.tabDevices.Location = New System.Drawing.Point(4, 26)
        Me.tabDevices.Name = "tabDevices"
        Me.tabDevices.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDevices.Size = New System.Drawing.Size(601, 437)
        Me.tabDevices.TabIndex = 1
        Me.tabDevices.Text = "Devices"
        Me.tabDevices.UseVisualStyleBackColor = True
        '
        'tabAbout
        '
        Me.tabAbout.Location = New System.Drawing.Point(4, 26)
        Me.tabAbout.Name = "tabAbout"
        Me.tabAbout.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAbout.Size = New System.Drawing.Size(601, 437)
        Me.tabAbout.TabIndex = 2
        Me.tabAbout.Text = "About"
        Me.tabAbout.UseVisualStyleBackColor = True
        '
        'HelpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 467)
        Me.Controls.Add(Me.tabHelp)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "HelpForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Help"
        Me.tabHelp.ResumeLayout(False)
        Me.tabCommands.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabHelp As System.Windows.Forms.TabControl
    Friend WithEvents tabCommands As System.Windows.Forms.TabPage
    Friend WithEvents brwCommands As System.Windows.Forms.WebBrowser
    Friend WithEvents tabDevices As System.Windows.Forms.TabPage
    Friend WithEvents tabAbout As System.Windows.Forms.TabPage
    Friend WithEvents tabConnection As System.Windows.Forms.TabPage
End Class
