Imports System.Windows.Forms
Imports System
Imports Microsoft.Win32

Public Class frmOptions

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If txtServer.Text = "" Or Not txtServer.Text.Contains(":") Or txtUser.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Следует заполнить все поля верно.", MsgBoxStyle.Exclamation, "Внимание!")
        Else
            With My.Settings
                .BaloonHeader = txtHeader.Text
                .BaloonText = txtMsg.Text
                .FilterSender = txtAddr.Text
                .FilterTopic = txtTopic.Text
                .isBaloon = chBaloon.Checked
                .isFilterLetterTopic = chTopic.Checked
                .isFilterSenderAddr = chAddr.Checked
                If cmbMinSec.SelectedIndex = 0 Then
                    .isMin = True
                    .isSec = False
                Else
                    .isMin = False
                    .isSec = True
                End If
                .isSound = chSound.Checked
                .isSSL = chSSL.Checked
                .isTip = chToolTip.Checked
                .Password = txtPassword.Text
                .RefreshTime = numPeriod.Value
                .Server = txtServer.Text
                .User = txtUser.Text
                .isStartClient = chClientStart.Checked
                .clientPath = txtClientPath.Text
                If My.Settings.isSec Then
                    frmMain.TimerUpdater.Interval = My.Settings.RefreshTime * 1000
                Else
                    frmMain.TimerUpdater.Interval = My.Settings.RefreshTime * 1000 * 60
                End If
                .Save()
                .Reload()
            End With
        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Function getClientPath(ByVal name As String) As String
        Try
            Dim mailClient As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Clients\Mail\" + name + "\shell\open\command", False)
            Return mailClient.GetValue("")
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Private Sub frmOptions_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'MsgBox(subkeys(0))
    End Sub

    Private Sub frmOptions_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim mailClientsNode As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE", False).OpenSubKey("Clients", False).OpenSubKey("Mail", False)
        Dim subkeys As String() = mailClientsNode.GetSubKeyNames
        txtClientPath.Items.Clear()
        For i As Integer = 0 To mailClientsNode.SubKeyCount - 1
            If getClientPath(subkeys(i)) <> "" Then
                txtClientPath.Items.Add(getClientPath(subkeys(i)))
            End If
        Next
        With My.Settings
            txtServer.Text = .Server
            txtUser.Text = .User
            txtPassword.Text = .Password
            txtAddr.Text = .FilterSender
            txtTopic.Text = .FilterTopic
            txtHeader.Text = .BaloonHeader
            txtMsg.Text = .BaloonText
            numPeriod.Value = .RefreshTime
            chAddr.Checked = .isFilterSenderAddr
            chBaloon.Checked = .isBaloon
            chSound.Checked = .isSound
            chSSL.Checked = .isSSL
            chToolTip.Checked = .isTip
            chTopic.Checked = .isFilterLetterTopic
            If .clientPath = "" Then
                txtClientPath.SelectedIndex = 0
            Else
                txtClientPath.Text = .clientPath
            End If
            chClientStart.Checked = .isStartClient
            If chClientStart.Checked = True Then
                txtClientPath.Enabled = True
                btnBrowseClient.Enabled = True
            Else
                txtClientPath.Enabled = False
                btnBrowseClient.Enabled = False
            End If
            If .isMin Then
                cmbMinSec.SelectedIndex = 0
            Else
                cmbMinSec.SelectedIndex = 1
            End If
            If chAddr.Checked = True Then
                txtAddr.Enabled = True
            Else
                txtAddr.Enabled = False
            End If
            If chTopic.Checked = True Then
                txtTopic.Enabled = True
            Else
                txtTopic.Enabled = False
            End If
            If chBaloon.Checked = True Then
                txtHeader.Enabled = True
                txtMsg.Enabled = True
            Else
                txtHeader.Enabled = False
                txtMsg.Enabled = False
            End If
        End With
    End Sub

    Private Sub chAddr_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chAddr.CheckStateChanged
        If chAddr.Checked = True Then
            txtAddr.Enabled = True
        Else
            txtAddr.Enabled = False
        End If
    End Sub

    Private Sub chTopic_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chTopic.CheckStateChanged
        If chTopic.Checked = True Then
            txtTopic.Enabled = True
        Else
            txtTopic.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If My.Settings.soundPath.Contains("\") Then
            OFD.Title = "Выберите звук уведомления"
            OFD.RestoreDirectory = True
            OFD.InitialDirectory = My.Settings.soundPath
            OFD.FileName = ""
            OFD.Filter = "Wave audio (*.wav)|*.wav"
            If OFD.ShowDialog() = Windows.Forms.DialogResult.OK Then
                My.Settings.soundPath = OFD.FileName
            End If
        Else
            OFD.Title = "Выберите звук уведомления"
            OFD.RestoreDirectory = True
            OFD.InitialDirectory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location())
            'OFD.FileName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location())
            OFD.FileName = ""
            OFD.Filter = "Wave audio (*.Wave)|*.wav"
            If OFD.ShowDialog() = Windows.Forms.DialogResult.OK Then
                My.Settings.soundPath = OFD.FileName
            End If
        End If
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub chClientStart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chClientStart.CheckedChanged
        If chClientStart.Checked = True Then
            txtClientPath.Enabled = True
            btnBrowseClient.Enabled = True
        Else
            txtClientPath.Enabled = False
            btnBrowseClient.Enabled = False
        End If
    End Sub

    Private Sub btnBrowseClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseClient.Click
        OFD.Title = "Выберите программу почтового клиента"
        OFD.RestoreDirectory = True
        OFD.FileName = ""
        OFD.Filter = "Executable file (*.EXE)|*.exe"
        If OFD.ShowDialog() = Windows.Forms.DialogResult.OK Then
            My.Settings.clientPath = OFD.FileName
            txtClientPath.Text = OFD.FileName
        End If
        My.Settings.Save()
        My.Settings.Reload()
    End Sub
End Class
