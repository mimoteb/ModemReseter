Imports System.ComponentModel
Imports System.Net.Sockets
Imports System.Text

Public Class frmMain
    Private Function deco(ByRef text As String) As String
        Return Encoding.UTF8.GetString(Convert.FromBase64String(text))
    End Function
    Private Function inco(ByRef text As String) As String
        Return Convert.ToBase64String(Encoding.UTF8.GetBytes(text))
    End Function
    Private config As String = My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\configurations.cfg"
    Private spltConfigurations As String = "<becoconfig>"
#Region "Modem Reseter"
    ' thread start
    'Dim t1 As System.Threading.Thread = New System.Threading.Thread(AddressOf RestartModem)
    'Private Sub RestartModem()

    'End Sub
    ' install telnet pkgmgr /iu:"TelnetClient"
    Private _client As TcpClient
    Private _data As String
    Private dilmtr As String = "#/"
    Private _sendbuffer(128) As Byte
    Private _readbuffer(128) As Byte
    Private _bytecount As Integer
    Dim sleepTime As Integer = 500
    Private _stream As NetworkStream

    Private Sub Send(ByVal Text As String)
        _sendbuffer = Encoding.ASCII.GetBytes(Text)
        _stream.Write(_sendbuffer, 0, _sendbuffer.Length)
    End Sub

    Private Sub Read()
        _bytecount = _stream.Read(_readbuffer, 0, _readbuffer.Length)
        _data = Encoding.ASCII.GetString(_readbuffer)
        Debug.WriteLine(_data & vbNewLine)
    End Sub
    Private Sub resetModem(ByRef ip As String, ByRef port As String, ByRef username As String, ByRef password As String)
        If My.Computer.Network.Ping(ip) = False Then
            tmrAutomation.Enabled = True
            Exit Sub
        End If
        nftyIco.ShowBalloonTip(10000, "RESTARTING...", "Restarting " & ip, ToolTipIcon.Info)
        Try
            _client = New TcpClient(ip, port)
            _stream = _client.GetStream
            Threading.Thread.Sleep(sleepTime)
            Send(username & vbNewLine)
            Threading.Thread.Sleep(sleepTime)
            Read()
            Send(password & vbNewLine)
            Threading.Thread.Sleep(sleepTime)

            Read()
            Send("reboot" & vbNewLine)
            'Read()
            _stream.Close()
            _client.Close()
            For Each row As DataGridViewRow In dgvQueue.Rows
                If row.Cells.Item(0).Value = ip Then
                    row.Cells.Item(6).Value = DateTime.Parse(Now.ToString("dd.MM.yyyy")).AddDays(1).ToString("dd.MM.yyyy")
                End If
            Next
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
        tmrAutomation.Enabled = True
    End Sub
    Private Function IsValidIPAddress(ByRef strIPAddress As String) As Boolean
        Return System.Net.IPAddress.TryParse(strIPAddress, Nothing)
    End Function
#End Region
#Region "Interface"
    Private Sub saveData()
        If IO.File.Exists(config) = False Then
            Try
                IO.File.Create(config)
            Catch ex As Exception
                Debug.WriteLine(ex.Message)
            End Try
        Else
            Try
                Dim sw As New IO.StreamWriter(config, False)
                For Each row As DataGridViewRow In dgvQueue.Rows
                    Dim line As String = String.Empty
                    line = inco(row.Cells.Item(0).Value) & spltConfigurations & inco(row.Cells.Item(1).Value) & spltConfigurations & inco(row.Cells.Item(2).Value) & spltConfigurations & inco(row.Cells.Item(3).Value) & spltConfigurations & inco(row.Cells.Item(4).Value) & spltConfigurations & inco(row.Cells.Item(6).Value)
                    sw.WriteLine(line)
                Next
                sw.Flush()
                sw.Close()
            Catch ex As Exception
                Debug.WriteLine(ex.Message)
            End Try

        End If

    End Sub
    Private Sub frmMain_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        nftyIco.Dispose()
    End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nftyIco.Visible = True
        txtHour.Text = Now.ToString("HH")
        txtMinute.Text = Now.ToString("mm")
        Try
            If IO.File.Exists(config) = True Then
                Dim sr As New IO.StreamReader(config)
                Do Until sr.EndOfStream = True
                    Dim item As String = sr.ReadLine
                    If item.Length > 0 Then
                        Dim items As String() = Strings.Split(item, spltConfigurations, -1, CompareMethod.Text)
                        Dim row As String() = New String() {deco(items.GetValue(0)), deco(items.GetValue(1)), deco(items.GetValue(2)), deco(items.GetValue(3)), deco(items.GetValue(4)), False, deco(items.GetValue(5))}
                        dgvQueue.Rows.Add(row)
                    End If
                Loop
                sr.Close()
            Else
                IO.File.Create(config)
            End If
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
        dgvQueue.ForeColor = Color.Yellow
        dgvQueue.Font = txtIPlst.Font
        addModems()

    End Sub
    Private Sub txtHour_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHour.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtMinute_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMinute.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtIPlst_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIPlst.KeyPress
        txtIPlst.Text.LastIndexOf(".")
        If e.KeyChar = "." And Strings.Split(txtIPlst.Text, ".", -1, CompareMethod.Text).GetUpperBound(0) < 3 Then
            txtIPlst.AppendText(e.KeyChar)
            e.Handled = True
            Exit Sub
        End If
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtPort_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPortlst.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub BtnPing_Click(sender As Object, e As EventArgs) Handles btnPing.Click
        For i As Integer = 0 To dgvQueue.Rows.Count - 1
            dgvQueue.Item(5, i).Value = My.Computer.Network.Ping(dgvQueue.Item(0, i).Value)
        Next
    End Sub

    Private Sub tmrAutomation_Tick(sender As Object, e As EventArgs) Handles tmrAutomation.Tick
        For Each row As DataGridViewRow In dgvQueue.Rows
            If row.Cells.Item(4).Value = Now.ToString("HH:mm") And row.Cells.Item(6).Value = Now.ToString("dd.MM.yyyy") Then
                tmrAutomation.Enabled = False
                Me.Text = "Modem Reseter, restarting (" & row.Cells.Item(0).Value & ")"
                Dim ip As String = String.Empty, port As String = String.Empty, username As String = String.Empty, password As String = String.Empty
                ip = row.Cells.Item(0).Value
                If My.Computer.Network.Ping(ip) = False Then Exit Sub
                port = row.Cells.Item(1).Value
                username = row.Cells.Item(2).Value
                password = row.Cells.Item(3).Value
                resetModem(ip, port, username, password)
                Me.Text = "Modem Reseter"
            End If
        Next

    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If My.Computer.Network.Ping(txtIPlst.Text) = False Then
            Dim msgResult As MsgBoxResult = MsgBox("This modem is offline! Do you want to add it anyway?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Error!")
            If msgResult = MsgBoxResult.No Then Exit Sub
        End If
        Dim dubI As Integer = 0, IsDub As Boolean = False
        On Error Resume Next
        For i As Integer = 0 To dgvQueue.Rows.Count - 1
            If dgvQueue.Item(0, i).Value.ToString = txtIPlst.Text Then
                IsDub = True
                dubI = i
                Exit For
            End If
        Next
        If IsDub = False Then
            Dim row As String() = New String() {txtIPlst.Text, txtPortlst.Text, txtusernamelst.Text, txtPasswordlst.Text, txtHour.Text & ":" & txtMinute.Text, False, Now.ToString("dd.MM.yyyy")}
            dgvQueue.Rows.Add(row)
        Else
            dgvQueue.Item(0, dubI).Value = txtIPlst.Text
            dgvQueue.Item(1, dubI).Value = txtPortlst.Text
            dgvQueue.Item(2, dubI).Value = txtusernamelst.Text
            dgvQueue.Item(3, dubI).Value = txtPasswordlst.Text
            dgvQueue.Item(4, dubI).Value = txtHour.Text & ":" & txtMinute.Text
            dgvQueue.Item(5, dubI).Value = False
        End If
        addModems()
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        For i As Integer = 0 To dgvQueue.Rows.Count - 1
            If dgvQueue.Item(0, i).Value = txtIPlst.Text Then
                dgvQueue.Rows.RemoveAt(i)
                MsgBox("The modem " & txtIPlst.Text & " has been removed from the schedule", MsgBoxStyle.Information, "Info")
            End If
        Next
        addModems()
    End Sub
    Private Sub tmrStatus_Tick(sender As Object, e As EventArgs) Handles tmrStatus.Tick
        lblAutmation.Text = "Automation System: " & tmrAutomation.Enabled
        cmsToggleAutomation.Checked = tmrAutomation.Enabled
        If tmrAutomation.Enabled Then
            btnToggle.Text = "Turn Off"

        Else
            btnToggle.Text = "Turn On"
        End If
        cmsToggleAutomation.Text = btnToggle.Text
    End Sub

    Private Sub btnToggle_Click(sender As Object, e As EventArgs) Handles btnToggle.Click, cmsToggleAutomation.Click
        If tmrAutomation.Enabled Then tmrAutomation.Enabled = False Else tmrAutomation.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        saveData()
    End Sub

    Private Sub cmsPingAll_Click(sender As Object, e As EventArgs) Handles cmsPingAll.Click
        Dim strMessage As String = String.Empty
        For Each row As DataGridViewRow In dgvQueue.Rows
            strMessage &= row.Cells.Item(0).Value & ": " & My.Computer.Network.Ping(row.Cells.Item(0).Value).ToString & vbNewLine
        Next
        MsgBox(strMessage, MsgBoxStyle.Information, "Ping")
    End Sub
    Private Sub addModems()
        cmsManuallyRestart.DropDownItems.Clear()
        Dim ip As String = String.Empty
        For Each row As DataGridViewRow In dgvQueue.Rows
            ip = row.Cells.Item(0).Value
            'Add a submenu to Menu 1
            Dim mnu As New ToolStripMenuItem() With {.Text = ip}
            'We have a reference to menu1 already, but here's how you can find the menu item by name...
            cmsManuallyRestart.DropDownItems.Add(mnu)
            AddHandler mnu.Click, AddressOf mnuItem_Clicked
        Next

    End Sub
    Private Sub mnuItem_Clicked(sender As Object, e As EventArgs)
        Dim ip As String = sender.ToString
        For Each row As DataGridViewRow In dgvQueue.Rows
            If row.Cells.Item(0).Value = ip Then
                resetModem(ip, row.Cells.Item(1).Value, row.Cells.Item(2).Value, row.Cells.Item(3).Value)
            End If
        Next
    End Sub

    Private Sub btnDonate_Click(sender As Object, e As EventArgs) Handles btnDonate.Click
        Process.Start("www.paypal.me/sissona")
        MsgBox("This software designed by Solomon Samuel, for further information you can contact me at mrsissona@gmail.com" & vbNewLine & "Thanks for using it", MsgBoxStyle.Information, "Sissona")
    End Sub

    Private Sub cmsSaveData_Click(sender As Object, e As EventArgs) Handles cmsSaveData.Click
        btnSave.PerformClick()
    End Sub

    Private Sub cmsExit_Click(sender As Object, e As EventArgs) Handles cmsExit.Click
        btnSave.PerformClick()
        Application.Exit()
        End
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub
    Private Sub nftyIco_MouseClick(sender As Object, e As MouseEventArgs) Handles nftyIco.MouseClick
        If e.Button = MouseButtons.Left Then
            If Me.Visible Then Me.Visible = False Else Me.Visible = True
        End If
    End Sub


#End Region

End Class
