<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOptions))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtServer = New System.Windows.Forms.TextBox
        Me.txtUser = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chSSL = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtAddr = New System.Windows.Forms.TextBox
        Me.chAddr = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtTopic = New System.Windows.Forms.TextBox
        Me.chTopic = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtMsg = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtHeader = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.numPeriod = New System.Windows.Forms.NumericUpDown
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbMinSec = New System.Windows.Forms.ComboBox
        Me.chToolTip = New System.Windows.Forms.CheckBox
        Me.chBaloon = New System.Windows.Forms.CheckBox
        Me.chSound = New System.Windows.Forms.CheckBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtClientPath = New System.Windows.Forms.ComboBox
        Me.btnBrowseClient = New System.Windows.Forms.Button
        Me.chClientStart = New System.Windows.Forms.CheckBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.OFD = New System.Windows.Forms.OpenFileDialog
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.numPeriod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnOK, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(423, 295)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.Location = New System.Drawing.Point(3, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(67, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(76, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(67, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Отмена"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Почт. сервер:"
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(93, 20)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(168, 20)
        Me.txtServer.TabIndex = 0
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(93, 46)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(168, 20)
        Me.txtUser.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Пользователь:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(93, 72)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(168, 20)
        Me.txtPassword.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Пароль:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chSSL)
        Me.GroupBox1.Controls.Add(Me.txtUser)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtServer)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(269, 125)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Подключение"
        '
        'chSSL
        '
        Me.chSSL.AutoSize = True
        Me.chSSL.Location = New System.Drawing.Point(9, 102)
        Me.chSSL.Name = "chSSL"
        Me.chSSL.Size = New System.Drawing.Size(186, 17)
        Me.chSSL.TabIndex = 3
        Me.chSSL.Text = "Безопасное подключение (SSL)"
        Me.chSSL.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtAddr)
        Me.GroupBox2.Controls.Add(Me.chAddr)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtTopic)
        Me.GroupBox2.Controls.Add(Me.chTopic)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(287, 220)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(283, 69)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Фильтры"
        '
        'txtAddr
        '
        Me.txtAddr.Location = New System.Drawing.Point(162, 40)
        Me.txtAddr.Name = "txtAddr"
        Me.txtAddr.Size = New System.Drawing.Size(111, 20)
        Me.txtAddr.TabIndex = 3
        '
        'chAddr
        '
        Me.chAddr.AutoSize = True
        Me.chAddr.Location = New System.Drawing.Point(141, 47)
        Me.chAddr.Name = "chAddr"
        Me.chAddr.Size = New System.Drawing.Size(15, 14)
        Me.chAddr.TabIndex = 2
        Me.chAddr.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "По адресу отправителя:"
        '
        'txtTopic
        '
        Me.txtTopic.Location = New System.Drawing.Point(85, 16)
        Me.txtTopic.Name = "txtTopic"
        Me.txtTopic.Size = New System.Drawing.Size(188, 20)
        Me.txtTopic.TabIndex = 1
        '
        'chTopic
        '
        Me.chTopic.AutoSize = True
        Me.chTopic.Location = New System.Drawing.Point(64, 22)
        Me.chTopic.Name = "chTopic"
        Me.chTopic.Size = New System.Drawing.Size(15, 14)
        Me.chTopic.TabIndex = 0
        Me.chTopic.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "По теме:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtMsg)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtHeader)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 143)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(269, 175)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Уведомление"
        '
        'txtMsg
        '
        Me.txtMsg.Location = New System.Drawing.Point(112, 37)
        Me.txtMsg.Multiline = True
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.Size = New System.Drawing.Size(149, 126)
        Me.txtMsg.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Текст сообщения:"
        '
        'txtHeader
        '
        Me.txtHeader.Location = New System.Drawing.Point(112, 13)
        Me.txtHeader.Name = "txtHeader"
        Me.txtHeader.Size = New System.Drawing.Size(149, 20)
        Me.txtHeader.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Текст заголовка:"
        '
        'numPeriod
        '
        Me.numPeriod.Location = New System.Drawing.Point(376, 37)
        Me.numPeriod.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.numPeriod.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numPeriod.Name = "numPeriod"
        Me.numPeriod.Size = New System.Drawing.Size(52, 20)
        Me.numPeriod.TabIndex = 1
        Me.numPeriod.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(293, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 29)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Проверять с интервалом в"
        '
        'cmbMinSec
        '
        Me.cmbMinSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMinSec.FormattingEnabled = True
        Me.cmbMinSec.Items.AddRange(New Object() {"минут", "секунд"})
        Me.cmbMinSec.Location = New System.Drawing.Point(434, 37)
        Me.cmbMinSec.Name = "cmbMinSec"
        Me.cmbMinSec.Size = New System.Drawing.Size(62, 21)
        Me.cmbMinSec.TabIndex = 2
        '
        'chToolTip
        '
        Me.chToolTip.AutoSize = True
        Me.chToolTip.Location = New System.Drawing.Point(296, 61)
        Me.chToolTip.Name = "chToolTip"
        Me.chToolTip.Size = New System.Drawing.Size(131, 17)
        Me.chToolTip.TabIndex = 3
        Me.chToolTip.Text = "Показывать Tool Tip"
        Me.chToolTip.UseVisualStyleBackColor = True
        '
        'chBaloon
        '
        Me.chBaloon.AutoSize = True
        Me.chBaloon.Location = New System.Drawing.Point(296, 84)
        Me.chBaloon.Name = "chBaloon"
        Me.chBaloon.Size = New System.Drawing.Size(167, 17)
        Me.chBaloon.TabIndex = 4
        Me.chBaloon.Text = "Показывать Baloon Tool Tip"
        Me.chBaloon.UseVisualStyleBackColor = True
        '
        'chSound
        '
        Me.chSound.AutoSize = True
        Me.chSound.Location = New System.Drawing.Point(9, 95)
        Me.chSound.Name = "chSound"
        Me.chSound.Size = New System.Drawing.Size(120, 17)
        Me.chSound.TabIndex = 5
        Me.chSound.Text = "Проигрывать звук"
        Me.chSound.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtClientPath)
        Me.GroupBox4.Controls.Add(Me.btnBrowseClient)
        Me.GroupBox4.Controls.Add(Me.chClientStart)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.chSound)
        Me.GroupBox4.Location = New System.Drawing.Point(287, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(283, 202)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Разное"
        '
        'txtClientPath
        '
        Me.txtClientPath.FormattingEnabled = True
        Me.txtClientPath.Location = New System.Drawing.Point(9, 162)
        Me.txtClientPath.Name = "txtClientPath"
        Me.txtClientPath.Size = New System.Drawing.Size(230, 21)
        Me.txtClientPath.TabIndex = 11
        '
        'btnBrowseClient
        '
        Me.btnBrowseClient.Location = New System.Drawing.Point(245, 162)
        Me.btnBrowseClient.Name = "btnBrowseClient"
        Me.btnBrowseClient.Size = New System.Drawing.Size(28, 23)
        Me.btnBrowseClient.TabIndex = 9
        Me.btnBrowseClient.Text = "..."
        Me.btnBrowseClient.UseVisualStyleBackColor = True
        '
        'chClientStart
        '
        Me.chClientStart.Location = New System.Drawing.Point(9, 119)
        Me.chClientStart.Name = "chClientStart"
        Me.chClientStart.Size = New System.Drawing.Size(264, 40)
        Me.chClientStart.TabIndex = 7
        Me.chClientStart.Text = "Запускать почтовый клиент при двойном щелчке по значку в трее"
        Me.chClientStart.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(133, 91)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Обзор..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        '
        'frmOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(581, 324)
        Me.Controls.Add(Me.chBaloon)
        Me.Controls.Add(Me.chToolTip)
        Me.Controls.Add(Me.cmbMinSec)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.numPeriod)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOptions"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "eMailNotifier - Настройки"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.numPeriod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAddr As System.Windows.Forms.TextBox
    Friend WithEvents chAddr As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTopic As System.Windows.Forms.TextBox
    Friend WithEvents chTopic As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtHeader As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMsg As System.Windows.Forms.TextBox
    Friend WithEvents numPeriod As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbMinSec As System.Windows.Forms.ComboBox
    Friend WithEvents chToolTip As System.Windows.Forms.CheckBox
    Friend WithEvents chBaloon As System.Windows.Forms.CheckBox
    Friend WithEvents chSound As System.Windows.Forms.CheckBox
    Friend WithEvents chSSL As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents chClientStart As System.Windows.Forms.CheckBox
    Friend WithEvents btnBrowseClient As System.Windows.Forms.Button
    Friend WithEvents txtClientPath As System.Windows.Forms.ComboBox

End Class
