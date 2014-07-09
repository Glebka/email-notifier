<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Tray = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Context = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmnuCheckMail = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmnuOptions = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.cmnuExit = New System.Windows.Forms.ToolStripMenuItem
        Me.TimerUpdater = New System.Windows.Forms.Timer(Me.components)
        Me.TimerR = New System.Windows.Forms.Timer(Me.components)
        Me.Context.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tray
        '
        Me.Tray.ContextMenuStrip = Me.Context
        Me.Tray.Icon = CType(resources.GetObject("Tray.Icon"), System.Drawing.Icon)
        Me.Tray.Text = "eMailNotifier"
        Me.Tray.Visible = True
        '
        'Context
        '
        Me.Context.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuCheckMail, Me.ToolStripMenuItem1, Me.cmnuOptions, Me.ToolStripMenuItem2, Me.cmnuExit})
        Me.Context.Name = "Context"
        Me.Context.Size = New System.Drawing.Size(170, 82)
        '
        'cmnuCheckMail
        '
        Me.cmnuCheckMail.Name = "cmnuCheckMail"
        Me.cmnuCheckMail.Size = New System.Drawing.Size(169, 22)
        Me.cmnuCheckMail.Text = "Проверить почту"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(166, 6)
        '
        'cmnuOptions
        '
        Me.cmnuOptions.Name = "cmnuOptions"
        Me.cmnuOptions.Size = New System.Drawing.Size(169, 22)
        Me.cmnuOptions.Text = "Настройки..."
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(166, 6)
        '
        'cmnuExit
        '
        Me.cmnuExit.Name = "cmnuExit"
        Me.cmnuExit.Size = New System.Drawing.Size(169, 22)
        Me.cmnuExit.Text = "Выход"
        '
        'TimerUpdater
        '
        '
        'TimerR
        '
        Me.TimerR.Interval = 1000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(219, 90)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "1"
        Me.Text = "eMailNotifier"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.Context.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tray As System.Windows.Forms.NotifyIcon
    Friend WithEvents TimerUpdater As System.Windows.Forms.Timer
    Friend WithEvents TimerR As System.Windows.Forms.Timer
    Friend WithEvents Context As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmnuCheckMail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmnuOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmnuExit As System.Windows.Forms.ToolStripMenuItem

End Class
