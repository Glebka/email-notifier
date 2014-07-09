Imports System.Net.Sockets
Imports System.Net.Sockets.TcpClient
Imports System.Text.Encoding
Imports System.Convert
Public Class frmMain
    Dim msgnew As New Collection
    Public Structure Message
        Public sender As String
        Public topic As String
    End Structure
    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        My.Settings.Reload()
        With My.Settings
            If .Server = vbNullString Or .User = vbNullString Or .Password = vbNullString Then
                If frmOptions.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
                    Me.Close()
                    Exit Sub
                End If
            End If
            Tray.Icon = My.Resources.mail
            Tray.Tag = ""
            Tray.Text = "eMailNotifier"
            CheckMail()
            If My.Settings.isSec Then
                TimerUpdater.Interval = My.Settings.RefreshTime * 1000
            Else
                TimerUpdater.Interval = My.Settings.RefreshTime * 1000 * 60
            End If
            TimerUpdater.Enabled = True
        End With
    End Sub
    Public Sub CheckMail()
        Dim server As String = My.Settings.Server.Split(":")(0)
        Dim port As Integer = CInt(My.Settings.Server.Split(":")(1))
        Dim client As ImapX.ImapClient = New ImapX.ImapClient(server, port, My.Settings.isSSL)
        Dim count As Integer = 0
        Dim lastMessage As Message
        Dim lastSender As String = ""
        Dim lastTopic As String = ""
        Try
            If Tray.Tag = "msg" Then
                If My.Settings.isSound Then
                    My.Computer.Audio.Play(My.Settings.soundPath)
                    'Dim mp3 As Microsoft.DirectX.AudioVideoPlayback.Audio = New Microsoft.DirectX.AudioVideoPlayback.Audio(My.Settings.soundPath)
                    'mp3.Play()
                End If
                ' Exit Sub
            End If
            If client.Connection() Then
                If client.LogIn(My.Settings.User, My.Settings.Password) Then
                    For Each msg As ImapX.Message In client.Folders.Item("INBOX").Messages
                        msg.ProcessFlags()
                        If msg.Flags.Count = 0 Then
                            msg.ProcessHeader()
                            Dim enc As String
                            Dim enc2 As String = ""
                            Dim coded2subject As String = ""
                            Dim encodedsubject As String = ""
                            If msg.Subject <> "" Then
                                If msg.Subject.StartsWith("=?") And msg.Subject <> "" Then
                                    enc = msg.Subject.Split("?")(1)
                                    enc2 = msg.Subject.Split("?")(2)
                                    coded2subject = msg.Subject.Split("?")(3)
                                    If enc2 = "B" Or enc2 = "b" Then
                                        Dim menc As System.Text.Encoding
                                        enc = enc.Replace("CP1251", "windows-1251")
                                        menc = System.Text.Encoding.GetEncoding(enc)
                                        encodedsubject = System.Text.Encoding.GetEncoding(enc).GetString(System.Convert.FromBase64String(coded2subject))
                                    Else
                                        encodedsubject = "{Q}" 'coded2subject
                                    End If
                                Else
                                    enc = "utf-8"
                                    encodedsubject = msg.Subject
                                End If
                            End If
                            If My.Settings.isFilterLetterTopic Or My.Settings.isFilterSenderAddr Then
                                If My.Settings.isFilterSenderAddr Then
                                    If msg.From.Item(0).Address.Contains(My.Settings.FilterSender) Then
                                        count = count + 1
                                        lastSender = msg.From.Item(0).Address
                                        lastTopic = encodedsubject
                                        lastMessage.sender = msg.From.Item(0).Address
                                        lastMessage.topic = encodedsubject
                                        msgnew.Add(lastMessage)
                                    End If
                                End If
                                If My.Settings.isFilterLetterTopic Then
                                    If encodedsubject.Contains(My.Settings.FilterTopic) Then
                                        count = count + 1
                                        lastSender = msg.From.Item(0).Address
                                        lastTopic = encodedsubject
                                        lastMessage.sender = msg.From.Item(0).Address
                                        lastMessage.topic = encodedsubject
                                        msgnew.Add(lastMessage)
                                    End If
                                End If
                            Else
                                count = count + 1
                                lastSender = msg.From.Item(0).Address
                                lastTopic = encodedsubject
                                lastMessage.sender = msg.From.Item(0).Address
                                lastMessage.topic = encodedsubject
                                msgnew.Add(lastMessage)
                            End If
                            'Debug.Print(msg.From.Item(0).Address + ":" + encodedsubject)
                        End If
                    Next
                    If msgnew.Count > 0 Then


                        Tray.Icon = My.Resources.email_envelope_n
                        TimerR.Enabled = True
                        Tray.Tag = "msg"
                        Dim tmp As Message = msgnew.Item(msgnew.Count)
                        lastSender = tmp.sender
                        lastTopic = tmp.topic
                        If My.Settings.isTip Then
                            Dim temp As String = "Сообщений: " + CStr(msgnew.Count) + vbNewLine + "Посл. от: " + lastSender + vbNewLine + lastTopic
                            If temp.Length >= 64 Then
                                temp = temp.Substring(0, 60)
                                temp = temp + "..."
                            End If
                            Tray.Text = temp '"Сообщений: " + CStr(count) + vbNewLine + "Посл. от: " + lastSender + vbNewLine + lastTopic
                        End If
                        If My.Settings.isBaloon Then
                            Tray.BalloonTipIcon = ToolTipIcon.Info
                            Tray.BalloonTipTitle = My.Settings.BaloonHeader
                            Dim txt As String = My.Settings.BaloonText.Replace("{#COUNT#}", CStr(msgnew.Count))
                            txt = txt.Replace("{#SENDER#}", lastSender)
                            txt = txt.Replace("{#TOPIC#}", lastTopic)
                            Tray.BalloonTipText = txt
                            Tray.ShowBalloonTip(10000)
                        End If
                        If My.Settings.isSound Then
                            My.Computer.Audio.Play(My.Settings.soundPath)
                            'Dim mp3 As Microsoft.DirectX.AudioVideoPlayback.Audio = New Microsoft.DirectX.AudioVideoPlayback.Audio("alert.mp3")
                            'mp3.Play()
                        End If
                    End If
                Else
                    Tray.Icon = My.Resources.warning
                    Tray.Tag = "error"
                    If My.Settings.isTip Then
                        Tray.Text = "Неправильные имя пользователя или(и) пароль"
                    End If
                    If My.Settings.isBaloon Then
                        Tray.BalloonTipIcon = ToolTipIcon.Error
                        Tray.BalloonTipTitle = "eMailNotifier - Неправильные имя пользователя или(и) пароль"
                        Tray.BalloonTipText = "Проверьте правильность имени пользователя и пароль." + vbNewLine + "Щелкните по этому сообщению для изменения настроек."
                        Tray.ShowBalloonTip(10000)
                    End If
                End If
            Else
                Tray.Icon = My.Resources.warning
                Tray.Tag = "error"
                If My.Settings.isTip Then
                    Tray.Text = "Ошибка подключения"
                End If
                If My.Settings.isBaloon Then
                    Tray.BalloonTipIcon = ToolTipIcon.Error
                    Tray.BalloonTipTitle = "eMailNotifier - Ошибка подключения"
                    Tray.BalloonTipText = "Не могу подключиться к серверу " + server + "." + vbNewLine + "Щелкните по этому сообщению для изменения настроек."
                    Tray.ShowBalloonTip(50000)
                End If
            End If
            client.LogOut()
            client.Disconnect()
        Catch ex As Exception
            MsgBox("Непредвиденная ошибка:" + vbNewLine + ex.Message, MsgBoxStyle.Critical, "Ошибка")
        End Try
    End Sub

    Private Sub Tray_BalloonTipClicked(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tray.BalloonTipClicked
        If Tray.BalloonTipIcon = ToolTipIcon.Error Then
            frmOptions.ShowDialog()
        Else
            If Tray.Tag <> "error" Then
                TimerR.Enabled = False
                Tray.Tag = ""
                Tray.Icon = My.Resources.mail
                Tray.Text = "eMailNotifier"
                msgnew.Clear()
            End If
        End If
    End Sub

    Private Sub Tray_BalloonTipClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tray.BalloonTipClosed
        
    End Sub

    Private Sub Tray_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tray.Click
        If Tray.Tag <> "error" Then
            TimerR.Enabled = False
            Tray.Tag = ""
            Tray.Icon = My.Resources.mail
            Tray.Text = "eMailNotifier"
            msgnew.Clear()
        End If
    End Sub

    Private Sub TimerR_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerR.Tick
        If Me.Tag = "1" Then
            Me.Tag = "2"
            Tray.Icon = My.Resources.email_envelope_r
        Else
            Me.Tag = "1"
            Tray.Icon = My.Resources.email_envelope_n
        End If
    End Sub

    Private Sub cmnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuExit.Click
        On Error Resume Next
        frmOptions.Close()
        Me.Close()
    End Sub

    Private Sub cmnuCheckMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuCheckMail.Click
        CheckMail()
    End Sub

    Private Sub cmnuOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuOptions.Click
        frmOptions.ShowDialog()
    End Sub

    Private Sub TimerUpdater_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerUpdater.Tick
        CheckMail()
    End Sub

    Private Sub Tray_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Tray.MouseDoubleClick
        If My.Settings.isStartClient Then
            Call Shell(My.Settings.clientPath, AppWinStyle.NormalFocus)
        End If
    End Sub

    Private Sub frmMain_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.Hide()
    End Sub
End Class
