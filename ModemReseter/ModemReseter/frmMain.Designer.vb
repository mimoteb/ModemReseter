<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.nftyIco = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cms = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsPingAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsToggleAutomation = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsManuallyRestart = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmsSaveData = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPing = New System.Windows.Forms.Button()
        Me.tmrAutomation = New System.Windows.Forms.Timer(Me.components)
        Me.grpAutomation = New System.Windows.Forms.GroupBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblMinute = New System.Windows.Forms.Label()
        Me.lblHour = New System.Windows.Forms.Label()
        Me.txtPasswordlst = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtusernamelst = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPortlst = New System.Windows.Forms.TextBox()
        Me.txtIPlst = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMinute = New System.Windows.Forms.TextBox()
        Me.txtHour = New System.Windows.Forms.TextBox()
        Me.lstModems = New System.Windows.Forms.ListBox()
        Me.dgvQueue = New System.Windows.Forms.DataGridView()
        Me.clmIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPort = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmUserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPassword = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPing = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.tmrStatus = New System.Windows.Forms.Timer(Me.components)
        Me.lblAutmation = New System.Windows.Forms.Label()
        Me.btnToggle = New System.Windows.Forms.Button()
        Me.btnDonate = New System.Windows.Forms.Button()
        Me.cms.SuspendLayout()
        Me.grpAutomation.SuspendLayout()
        CType(Me.dgvQueue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nftyIco
        '
        Me.nftyIco.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.nftyIco.ContextMenuStrip = Me.cms
        Me.nftyIco.Icon = CType(resources.GetObject("nftyIco.Icon"), System.Drawing.Icon)
        Me.nftyIco.Text = "Modem Reseter"
        Me.nftyIco.Visible = True
        '
        'cms
        '
        Me.cms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsPingAll, Me.cmsToggleAutomation, Me.cmsManuallyRestart, Me.ToolStripMenuItem1, Me.cmsSaveData, Me.cmsExit})
        Me.cms.Name = "cms"
        Me.cms.Size = New System.Drawing.Size(163, 120)
        '
        'cmsPingAll
        '
        Me.cmsPingAll.Name = "cmsPingAll"
        Me.cmsPingAll.Size = New System.Drawing.Size(162, 22)
        Me.cmsPingAll.Text = "Ping &All"
        '
        'cmsToggleAutomation
        '
        Me.cmsToggleAutomation.Checked = True
        Me.cmsToggleAutomation.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cmsToggleAutomation.Name = "cmsToggleAutomation"
        Me.cmsToggleAutomation.Size = New System.Drawing.Size(162, 22)
        Me.cmsToggleAutomation.Text = "Turn &Off"
        '
        'cmsManuallyRestart
        '
        Me.cmsManuallyRestart.Name = "cmsManuallyRestart"
        Me.cmsManuallyRestart.Size = New System.Drawing.Size(162, 22)
        Me.cmsManuallyRestart.Text = "Man&ually Restart"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(159, 6)
        '
        'cmsSaveData
        '
        Me.cmsSaveData.Name = "cmsSaveData"
        Me.cmsSaveData.Size = New System.Drawing.Size(162, 22)
        Me.cmsSaveData.Text = "&Save"
        '
        'cmsExit
        '
        Me.cmsExit.Name = "cmsExit"
        Me.cmsExit.Size = New System.Drawing.Size(162, 22)
        Me.cmsExit.Text = "E&xit"
        '
        'btnPing
        '
        Me.btnPing.BackColor = System.Drawing.Color.Purple
        Me.btnPing.ForeColor = System.Drawing.Color.Yellow
        Me.btnPing.Location = New System.Drawing.Point(957, 288)
        Me.btnPing.Name = "btnPing"
        Me.btnPing.Size = New System.Drawing.Size(75, 23)
        Me.btnPing.TabIndex = 9
        Me.btnPing.Text = "Ping"
        Me.btnPing.UseVisualStyleBackColor = False
        '
        'tmrAutomation
        '
        Me.tmrAutomation.Interval = 2000
        '
        'grpAutomation
        '
        Me.grpAutomation.Controls.Add(Me.btnRemove)
        Me.grpAutomation.Controls.Add(Me.btnAdd)
        Me.grpAutomation.Controls.Add(Me.Label5)
        Me.grpAutomation.Controls.Add(Me.lblMinute)
        Me.grpAutomation.Controls.Add(Me.lblHour)
        Me.grpAutomation.Controls.Add(Me.txtPasswordlst)
        Me.grpAutomation.Controls.Add(Me.Label3)
        Me.grpAutomation.Controls.Add(Me.txtusernamelst)
        Me.grpAutomation.Controls.Add(Me.Label4)
        Me.grpAutomation.Controls.Add(Me.txtPortlst)
        Me.grpAutomation.Controls.Add(Me.txtIPlst)
        Me.grpAutomation.Controls.Add(Me.Label1)
        Me.grpAutomation.Controls.Add(Me.Label2)
        Me.grpAutomation.Controls.Add(Me.txtMinute)
        Me.grpAutomation.Controls.Add(Me.txtHour)
        Me.grpAutomation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.grpAutomation.ForeColor = System.Drawing.Color.Yellow
        Me.grpAutomation.Location = New System.Drawing.Point(12, 19)
        Me.grpAutomation.Name = "grpAutomation"
        Me.grpAutomation.Size = New System.Drawing.Size(369, 261)
        Me.grpAutomation.TabIndex = 12
        Me.grpAutomation.TabStop = False
        Me.grpAutomation.Text = "Automation"
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.Purple
        Me.btnRemove.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.Yellow
        Me.btnRemove.Location = New System.Drawing.Point(264, 104)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(99, 61)
        Me.btnRemove.TabIndex = 17
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Purple
        Me.btnAdd.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Yellow
        Me.btnAdd.Location = New System.Drawing.Point(264, 37)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(99, 61)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "Add/Edit"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(189, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 23)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = ":"
        '
        'lblMinute
        '
        Me.lblMinute.AutoSize = True
        Me.lblMinute.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblMinute.Location = New System.Drawing.Point(213, 217)
        Me.lblMinute.Name = "lblMinute"
        Me.lblMinute.Size = New System.Drawing.Size(40, 23)
        Me.lblMinute.TabIndex = 15
        Me.lblMinute.Text = "MM"
        '
        'lblHour
        '
        Me.lblHour.AutoSize = True
        Me.lblHour.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblHour.Location = New System.Drawing.Point(138, 217)
        Me.lblHour.Name = "lblHour"
        Me.lblHour.Size = New System.Drawing.Size(36, 23)
        Me.lblHour.TabIndex = 14
        Me.lblHour.Text = "HH"
        '
        'txtPasswordlst
        '
        Me.txtPasswordlst.BackColor = System.Drawing.Color.Yellow
        Me.txtPasswordlst.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtPasswordlst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPasswordlst.Location = New System.Drawing.Point(132, 145)
        Me.txtPasswordlst.Name = "txtPasswordlst"
        Me.txtPasswordlst.Size = New System.Drawing.Size(126, 30)
        Me.txtPasswordlst.TabIndex = 13
        Me.txtPasswordlst.Text = "Turbo123"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 23)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Password:"
        '
        'txtusernamelst
        '
        Me.txtusernamelst.BackColor = System.Drawing.Color.Yellow
        Me.txtusernamelst.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtusernamelst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtusernamelst.Location = New System.Drawing.Point(132, 106)
        Me.txtusernamelst.Name = "txtusernamelst"
        Me.txtusernamelst.Size = New System.Drawing.Size(126, 30)
        Me.txtusernamelst.TabIndex = 11
        Me.txtusernamelst.Text = "root"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 23)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Username:"
        '
        'txtPortlst
        '
        Me.txtPortlst.BackColor = System.Drawing.Color.Yellow
        Me.txtPortlst.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtPortlst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPortlst.Location = New System.Drawing.Point(132, 69)
        Me.txtPortlst.Name = "txtPortlst"
        Me.txtPortlst.Size = New System.Drawing.Size(126, 30)
        Me.txtPortlst.TabIndex = 8
        Me.txtPortlst.Text = "23"
        '
        'txtIPlst
        '
        Me.txtIPlst.BackColor = System.Drawing.Color.Yellow
        Me.txtIPlst.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtIPlst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtIPlst.Location = New System.Drawing.Point(132, 29)
        Me.txtIPlst.Name = "txtIPlst"
        Me.txtIPlst.Size = New System.Drawing.Size(126, 30)
        Me.txtIPlst.TabIndex = 9
        Me.txtIPlst.Text = "192.168.2.1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Modem Port:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Modem IP:"
        '
        'txtMinute
        '
        Me.txtMinute.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMinute.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtMinute.ForeColor = System.Drawing.Color.Yellow
        Me.txtMinute.Location = New System.Drawing.Point(207, 183)
        Me.txtMinute.MaxLength = 2
        Me.txtMinute.Name = "txtMinute"
        Me.txtMinute.Size = New System.Drawing.Size(51, 30)
        Me.txtMinute.TabIndex = 1
        Me.txtMinute.Text = "00"
        Me.txtMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHour
        '
        Me.txtHour.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtHour.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtHour.ForeColor = System.Drawing.Color.Yellow
        Me.txtHour.Location = New System.Drawing.Point(132, 183)
        Me.txtHour.MaxLength = 2
        Me.txtHour.Name = "txtHour"
        Me.txtHour.Size = New System.Drawing.Size(51, 30)
        Me.txtHour.TabIndex = 0
        Me.txtHour.Text = "06"
        Me.txtHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lstModems
        '
        Me.lstModems.FormattingEnabled = True
        Me.lstModems.Location = New System.Drawing.Point(99, 463)
        Me.lstModems.Name = "lstModems"
        Me.lstModems.Size = New System.Drawing.Size(185, 251)
        Me.lstModems.TabIndex = 13
        '
        'dgvQueue
        '
        Me.dgvQueue.AllowUserToAddRows = False
        Me.dgvQueue.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQueue.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIP, Me.clmPort, Me.clmUserName, Me.clmPassword, Me.clmTime, Me.clmPing, Me.clmDate})
        Me.dgvQueue.GridColor = System.Drawing.Color.White
        Me.dgvQueue.Location = New System.Drawing.Point(387, 19)
        Me.dgvQueue.Name = "dgvQueue"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Violet
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow
        Me.dgvQueue.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvQueue.Size = New System.Drawing.Size(728, 261)
        Me.dgvQueue.TabIndex = 14
        '
        'clmIP
        '
        Me.clmIP.HeaderText = "IP"
        Me.clmIP.Name = "clmIP"
        Me.clmIP.Width = 120
        '
        'clmPort
        '
        Me.clmPort.HeaderText = "Port"
        Me.clmPort.Name = "clmPort"
        Me.clmPort.Width = 50
        '
        'clmUserName
        '
        Me.clmUserName.HeaderText = "UesrName"
        Me.clmUserName.Name = "clmUserName"
        Me.clmUserName.Width = 120
        '
        'clmPassword
        '
        Me.clmPassword.HeaderText = "Password"
        Me.clmPassword.Name = "clmPassword"
        Me.clmPassword.Width = 130
        '
        'clmTime
        '
        Me.clmTime.HeaderText = "Time"
        Me.clmTime.Name = "clmTime"
        Me.clmTime.Width = 75
        '
        'clmPing
        '
        Me.clmPing.HeaderText = "Ping"
        Me.clmPing.Name = "clmPing"
        Me.clmPing.Width = 65
        '
        'clmDate
        '
        Me.clmDate.HeaderText = "NextReset"
        Me.clmDate.Name = "clmDate"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Purple
        Me.btnSave.ForeColor = System.Drawing.Color.Yellow
        Me.btnSave.Location = New System.Drawing.Point(1038, 288)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(61, 23)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'tmrStatus
        '
        Me.tmrStatus.Enabled = True
        Me.tmrStatus.Interval = 1000
        '
        'lblAutmation
        '
        Me.lblAutmation.AutoSize = True
        Me.lblAutmation.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblAutmation.ForeColor = System.Drawing.Color.Yellow
        Me.lblAutmation.Location = New System.Drawing.Point(421, 293)
        Me.lblAutmation.Name = "lblAutmation"
        Me.lblAutmation.Size = New System.Drawing.Size(154, 19)
        Me.lblAutmation.TabIndex = 20
        Me.lblAutmation.Text = "Automation System:"
        '
        'btnToggle
        '
        Me.btnToggle.BackColor = System.Drawing.Color.Purple
        Me.btnToggle.ForeColor = System.Drawing.Color.Yellow
        Me.btnToggle.Location = New System.Drawing.Point(844, 288)
        Me.btnToggle.Name = "btnToggle"
        Me.btnToggle.Size = New System.Drawing.Size(107, 23)
        Me.btnToggle.TabIndex = 21
        Me.btnToggle.Text = "Turn Off"
        Me.btnToggle.UseVisualStyleBackColor = False
        '
        'btnDonate
        '
        Me.btnDonate.BackColor = System.Drawing.Color.Purple
        Me.btnDonate.ForeColor = System.Drawing.Color.Yellow
        Me.btnDonate.Location = New System.Drawing.Point(22, 289)
        Me.btnDonate.Name = "btnDonate"
        Me.btnDonate.Size = New System.Drawing.Size(75, 23)
        Me.btnDonate.TabIndex = 9
        Me.btnDonate.Text = "Donate!"
        Me.btnDonate.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1127, 321)
        Me.Controls.Add(Me.btnToggle)
        Me.Controls.Add(Me.lblAutmation)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dgvQueue)
        Me.Controls.Add(Me.lstModems)
        Me.Controls.Add(Me.grpAutomation)
        Me.Controls.Add(Me.btnDonate)
        Me.Controls.Add(Me.btnPing)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.ShowInTaskbar = False
        Me.Text = "Modem Reseter"
        Me.cms.ResumeLayout(False)
        Me.grpAutomation.ResumeLayout(False)
        Me.grpAutomation.PerformLayout()
        CType(Me.dgvQueue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nftyIco As NotifyIcon
    Friend WithEvents btnPing As Button
    Friend WithEvents tmrAutomation As Timer
    Friend WithEvents grpAutomation As GroupBox
    Friend WithEvents txtMinute As TextBox
    Friend WithEvents txtHour As TextBox
    Friend WithEvents txtPasswordlst As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtusernamelst As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPortlst As TextBox
    Friend WithEvents txtIPlst As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblMinute As Label
    Friend WithEvents lblHour As Label
    Friend WithEvents lstModems As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents dgvQueue As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents tmrStatus As Timer
    Friend WithEvents lblAutmation As Label
    Friend WithEvents btnToggle As Button
    Friend WithEvents cms As ContextMenuStrip
    Friend WithEvents cmsExit As ToolStripMenuItem
    Friend WithEvents cmsToggleAutomation As ToolStripMenuItem
    Friend WithEvents cmsPingAll As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents cmsSaveData As ToolStripMenuItem
    Friend WithEvents cmsManuallyRestart As ToolStripMenuItem
    Friend WithEvents clmIP As DataGridViewTextBoxColumn
    Friend WithEvents clmPort As DataGridViewTextBoxColumn
    Friend WithEvents clmUserName As DataGridViewTextBoxColumn
    Friend WithEvents clmPassword As DataGridViewTextBoxColumn
    Friend WithEvents clmTime As DataGridViewTextBoxColumn
    Friend WithEvents clmPing As DataGridViewTextBoxColumn
    Friend WithEvents clmDate As DataGridViewTextBoxColumn
    Friend WithEvents btnDonate As Button
End Class
