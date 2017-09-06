Namespace FxSocketSamples
	Partial Public Class ConnectForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.cbUtf8Encoding = New System.Windows.Forms.CheckBox()
			Me.lbSsl = New System.Windows.Forms.Label()
			Me.tbUserName = New System.Windows.Forms.TextBox()
			Me.tbPassword = New System.Windows.Forms.TextBox()
			Me.cbxSslMode = New System.Windows.Forms.ComboBox()
			Me.lblFtpPassword = New System.Windows.Forms.Label()
			Me.lblPort = New System.Windows.Forms.Label()
			Me.lblServer = New System.Windows.Forms.Label()
			Me.lblFtpUserName = New System.Windows.Forms.Label()
			Me.cbClearCommandChannel = New System.Windows.Forms.CheckBox()
			Me.lblCert = New System.Windows.Forms.Label()
			Me.cbPasv = New System.Windows.Forms.CheckBox()
			Me.btCertBrowse = New System.Windows.Forms.Button()
			Me.tbCert = New System.Windows.Forms.TextBox()
			Me.grConnection = New System.Windows.Forms.GroupBox()
			Me.suiteDl = New System.Windows.Forms.ComboBox()
			Me.label14 = New System.Windows.Forms.Label()
			Me.cbSsl30 = New System.Windows.Forms.CheckBox()
			Me.cbTls10 = New System.Windows.Forms.CheckBox()
			Me.label13 = New System.Windows.Forms.Label()
			Me.tbPort = New System.Windows.Forms.NumericUpDown()
			Me.tbServer = New System.Windows.Forms.TextBox()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.tbProxyPort = New System.Windows.Forms.NumericUpDown()
			Me.tbProxyDomain = New System.Windows.Forms.TextBox()
			Me.lblDomain = New System.Windows.Forms.Label()
			Me.lblMethod = New System.Windows.Forms.Label()
			Me.cbxProxyMethod = New System.Windows.Forms.ComboBox()
			Me.lblProxyPort = New System.Windows.Forms.Label()
			Me.tbProxyHost = New System.Windows.Forms.TextBox()
			Me.lblProxyServer = New System.Windows.Forms.Label()
			Me.cbxProxyType = New System.Windows.Forms.ComboBox()
			Me.tbProxyPassword = New System.Windows.Forms.TextBox()
			Me.lblPassword = New System.Windows.Forms.Label()
			Me.tbProxyUser = New System.Windows.Forms.TextBox()
			Me.lblUserName = New System.Windows.Forms.Label()
			Me.lblType = New System.Windows.Forms.Label()
			Me.connectBtn = New System.Windows.Forms.Button()
			Me.cancelBtn = New System.Windows.Forms.Button()
			Me.cbTls11 = New System.Windows.Forms.CheckBox()
			Me.cbTls12 = New System.Windows.Forms.CheckBox()
			Me.grConnection.SuspendLayout()
			CType(Me.tbPort, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox1.SuspendLayout()
			CType(Me.tbProxyPort, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' cbUtf8Encoding
			' 
			Me.cbUtf8Encoding.AutoSize = True
			Me.cbUtf8Encoding.Location = New System.Drawing.Point(84, 99)
			Me.cbUtf8Encoding.Name = "cbUtf8Encoding"
			Me.cbUtf8Encoding.Size = New System.Drawing.Size(94, 17)
			Me.cbUtf8Encoding.TabIndex = 6
			Me.cbUtf8Encoding.Text = "Utf8 Encoding"
			' 
			' lbSsl
			' 
			Me.lbSsl.Location = New System.Drawing.Point(376, 23)
			Me.lbSsl.Name = "lbSsl"
			Me.lbSsl.Size = New System.Drawing.Size(83, 13)
			Me.lbSsl.TabIndex = 58
			Me.lbSsl.Text = "SSL Mode:"
			' 
			' tbUserName
			' 
			Me.tbUserName.Location = New System.Drawing.Point(84, 48)
			Me.tbUserName.Name = "tbUserName"
			Me.tbUserName.Size = New System.Drawing.Size(123, 20)
			Me.tbUserName.TabIndex = 4
			' 
			' tbPassword
			' 
			Me.tbPassword.Location = New System.Drawing.Point(84, 73)
			Me.tbPassword.Name = "tbPassword"
			Me.tbPassword.PasswordChar = "*"c
			Me.tbPassword.Size = New System.Drawing.Size(123, 20)
			Me.tbPassword.TabIndex = 5
			' 
			' cbxSslMode
			' 
			Me.cbxSslMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cbxSslMode.FormattingEnabled = True
			Me.cbxSslMode.Items.AddRange(New Object() { "None", "Implicit", "Explicit"})
			Me.cbxSslMode.Location = New System.Drawing.Point(465, 19)
			Me.cbxSslMode.Name = "cbxSslMode"
			Me.cbxSslMode.Size = New System.Drawing.Size(99, 21)
			Me.cbxSslMode.TabIndex = 3
'			Me.cbxSslMode.SelectedIndexChanged += New System.EventHandler(Me.sslDropDown_SelectedIndexChanged)
			' 
			' lblFtpPassword
			' 
			Me.lblFtpPassword.Location = New System.Drawing.Point(11, 76)
			Me.lblFtpPassword.Name = "lblFtpPassword"
			Me.lblFtpPassword.Size = New System.Drawing.Size(56, 13)
			Me.lblFtpPassword.TabIndex = 66
			Me.lblFtpPassword.Text = "Password:"
			' 
			' lblPort
			' 
			Me.lblPort.Location = New System.Drawing.Point(221, 23)
			Me.lblPort.Name = "lblPort"
			Me.lblPort.Size = New System.Drawing.Size(37, 13)
			Me.lblPort.TabIndex = 64
			Me.lblPort.Text = "Port:"
			' 
			' lblServer
			' 
			Me.lblServer.Location = New System.Drawing.Point(11, 23)
			Me.lblServer.Name = "lblServer"
			Me.lblServer.Size = New System.Drawing.Size(59, 13)
			Me.lblServer.TabIndex = 63
			Me.lblServer.Text = "Server:"
			' 
			' lblFtpUserName
			' 
			Me.lblFtpUserName.Location = New System.Drawing.Point(11, 50)
			Me.lblFtpUserName.Name = "lblFtpUserName"
			Me.lblFtpUserName.Size = New System.Drawing.Size(63, 13)
			Me.lblFtpUserName.TabIndex = 65
			Me.lblFtpUserName.Text = "User Name:"
			' 
			' cbClearCommandChannel
			' 
			Me.cbClearCommandChannel.AutoSize = True
			Me.cbClearCommandChannel.Checked = True
			Me.cbClearCommandChannel.CheckState = System.Windows.Forms.CheckState.Checked
			Me.cbClearCommandChannel.Location = New System.Drawing.Point(287, 99)
			Me.cbClearCommandChannel.Name = "cbClearCommandChannel"
			Me.cbClearCommandChannel.Size = New System.Drawing.Size(142, 17)
			Me.cbClearCommandChannel.TabIndex = 8
			Me.cbClearCommandChannel.Text = "Clear Command Channel"
			' 
			' lblCert
			' 
			Me.lblCert.Location = New System.Drawing.Point(8, 118)
			Me.lblCert.Name = "lblCert"
			Me.lblCert.Size = New System.Drawing.Size(63, 29)
			Me.lblCert.TabIndex = 67
			Me.lblCert.Text = "Client" & vbCrLf & "Certificate:"
			' 
			' cbPasv
			' 
			Me.cbPasv.AutoSize = True
			Me.cbPasv.BackColor = System.Drawing.SystemColors.Control
			Me.cbPasv.Cursor = System.Windows.Forms.Cursors.Default
			Me.cbPasv.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.cbPasv.ForeColor = System.Drawing.SystemColors.ControlText
			Me.cbPasv.Location = New System.Drawing.Point(184, 99)
			Me.cbPasv.Name = "cbPasv"
			Me.cbPasv.RightToLeft = System.Windows.Forms.RightToLeft.No
			Me.cbPasv.Size = New System.Drawing.Size(93, 18)
			Me.cbPasv.TabIndex = 7
			Me.cbPasv.Text = "Passive Mode"
			Me.cbPasv.UseVisualStyleBackColor = False
			' 
			' btCertBrowse
			' 
			Me.btCertBrowse.Location = New System.Drawing.Point(465, 119)
			Me.btCertBrowse.Name = "btCertBrowse"
			Me.btCertBrowse.Size = New System.Drawing.Size(26, 20)
			Me.btCertBrowse.TabIndex = 10
			Me.btCertBrowse.Text = "..."
'			Me.btCertBrowse.Click += New System.EventHandler(Me.certBrowseBtn_Click)
			' 
			' tbCert
			' 
			Me.tbCert.Location = New System.Drawing.Point(84, 120)
			Me.tbCert.Name = "tbCert"
			Me.tbCert.Size = New System.Drawing.Size(368, 20)
			Me.tbCert.TabIndex = 9
			' 
			' grConnection
			' 
			Me.grConnection.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.grConnection.Controls.Add(Me.cbTls12)
			Me.grConnection.Controls.Add(Me.cbTls11)
			Me.grConnection.Controls.Add(Me.suiteDl)
			Me.grConnection.Controls.Add(Me.label14)
			Me.grConnection.Controls.Add(Me.cbSsl30)
			Me.grConnection.Controls.Add(Me.cbTls10)
			Me.grConnection.Controls.Add(Me.label13)
			Me.grConnection.Controls.Add(Me.tbPort)
			Me.grConnection.Controls.Add(Me.tbServer)
			Me.grConnection.Controls.Add(Me.cbUtf8Encoding)
			Me.grConnection.Controls.Add(Me.tbCert)
			Me.grConnection.Controls.Add(Me.lbSsl)
			Me.grConnection.Controls.Add(Me.btCertBrowse)
			Me.grConnection.Controls.Add(Me.tbUserName)
			Me.grConnection.Controls.Add(Me.cbPasv)
			Me.grConnection.Controls.Add(Me.tbPassword)
			Me.grConnection.Controls.Add(Me.lblCert)
			Me.grConnection.Controls.Add(Me.cbxSslMode)
			Me.grConnection.Controls.Add(Me.cbClearCommandChannel)
			Me.grConnection.Controls.Add(Me.lblFtpPassword)
			Me.grConnection.Controls.Add(Me.lblFtpUserName)
			Me.grConnection.Controls.Add(Me.lblServer)
			Me.grConnection.Controls.Add(Me.lblPort)
			Me.grConnection.Location = New System.Drawing.Point(12, 8)
			Me.grConnection.Name = "grConnection"
			Me.grConnection.Size = New System.Drawing.Size(577, 218)
			Me.grConnection.TabIndex = 68
			Me.grConnection.TabStop = False
			Me.grConnection.Text = "Connection"
			' 
			' suiteDl
			' 
			Me.suiteDl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.suiteDl.Items.AddRange(New Object() { "All ciphers", "Secure only"})
			Me.suiteDl.Location = New System.Drawing.Point(85, 191)
			Me.suiteDl.Name = "suiteDl"
			Me.suiteDl.Size = New System.Drawing.Size(132, 21)
			Me.suiteDl.TabIndex = 24
			' 
			' label14
			' 
			Me.label14.AutoSize = True
			Me.label14.Location = New System.Drawing.Point(5, 194)
			Me.label14.Name = "label14"
			Me.label14.Size = New System.Drawing.Size(77, 13)
			Me.label14.TabIndex = 71
			Me.label14.Text = "Allowed suites:"
			' 
			' cbSsl30
			' 
			Me.cbSsl30.Checked = True
			Me.cbSsl30.CheckState = System.Windows.Forms.CheckState.Checked
			Me.cbSsl30.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.cbSsl30.Location = New System.Drawing.Point(280, 147)
			Me.cbSsl30.Name = "cbSsl30"
			Me.cbSsl30.Size = New System.Drawing.Size(64, 24)
			Me.cbSsl30.TabIndex = 23
			Me.cbSsl30.Text = "SSL 3.0"
			' 
			' cbTls10
			' 
			Me.cbTls10.Checked = True
			Me.cbTls10.CheckState = System.Windows.Forms.CheckState.Checked
			Me.cbTls10.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.cbTls10.Location = New System.Drawing.Point(85, 147)
			Me.cbTls10.Name = "cbTls10"
			Me.cbTls10.Size = New System.Drawing.Size(72, 24)
			Me.cbTls10.TabIndex = 20
			Me.cbTls10.Text = "TLS 1.0"
			' 
			' label13
			' 
			Me.label13.Location = New System.Drawing.Point(11, 147)
			Me.label13.Name = "label13"
			Me.label13.Size = New System.Drawing.Size(70, 36)
			Me.label13.TabIndex = 68
			Me.label13.Text = "Allowed " & vbCrLf & "protocol:"
			' 
			' tbPort
			' 
			Me.tbPort.Location = New System.Drawing.Point(264, 20)
			Me.tbPort.Maximum = New Decimal(New Integer() { 1000000, 0, 0, 0})
			Me.tbPort.Minimum = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.tbPort.Name = "tbPort"
			Me.tbPort.Size = New System.Drawing.Size(89, 20)
			Me.tbPort.TabIndex = 2
			Me.tbPort.Value = New Decimal(New Integer() { 1, 0, 0, 0})
			' 
			' tbServer
			' 
			Me.tbServer.Location = New System.Drawing.Point(84, 21)
			Me.tbServer.Name = "tbServer"
			Me.tbServer.Size = New System.Drawing.Size(123, 20)
			Me.tbServer.TabIndex = 1
			' 
			' groupBox1
			' 
			Me.groupBox1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.groupBox1.Controls.Add(Me.tbProxyPort)
			Me.groupBox1.Controls.Add(Me.tbProxyDomain)
			Me.groupBox1.Controls.Add(Me.lblDomain)
			Me.groupBox1.Controls.Add(Me.lblMethod)
			Me.groupBox1.Controls.Add(Me.cbxProxyMethod)
			Me.groupBox1.Controls.Add(Me.lblProxyPort)
			Me.groupBox1.Controls.Add(Me.tbProxyHost)
			Me.groupBox1.Controls.Add(Me.lblProxyServer)
			Me.groupBox1.Controls.Add(Me.cbxProxyType)
			Me.groupBox1.Controls.Add(Me.tbProxyPassword)
			Me.groupBox1.Controls.Add(Me.lblPassword)
			Me.groupBox1.Controls.Add(Me.tbProxyUser)
			Me.groupBox1.Controls.Add(Me.lblUserName)
			Me.groupBox1.Controls.Add(Me.lblType)
			Me.groupBox1.Location = New System.Drawing.Point(13, 231)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(576, 126)
			Me.groupBox1.TabIndex = 69
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Proxy"
			' 
			' tbProxyPort
			' 
			Me.tbProxyPort.Location = New System.Drawing.Point(319, 17)
			Me.tbProxyPort.Maximum = New Decimal(New Integer() { 1000000, 0, 0, 0})
			Me.tbProxyPort.Minimum = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.tbProxyPort.Name = "tbProxyPort"
			Me.tbProxyPort.Size = New System.Drawing.Size(89, 20)
			Me.tbProxyPort.TabIndex = 31
			Me.tbProxyPort.Value = New Decimal(New Integer() { 1, 0, 0, 0})
			' 
			' tbProxyDomain
			' 
			Me.tbProxyDomain.Enabled = False
			Me.tbProxyDomain.Location = New System.Drawing.Point(83, 91)
			Me.tbProxyDomain.Name = "tbProxyDomain"
			Me.tbProxyDomain.Size = New System.Drawing.Size(126, 20)
			Me.tbProxyDomain.TabIndex = 36
			' 
			' lblDomain
			' 
			Me.lblDomain.Location = New System.Drawing.Point(10, 93)
			Me.lblDomain.Name = "lblDomain"
			Me.lblDomain.Size = New System.Drawing.Size(46, 13)
			Me.lblDomain.TabIndex = 45
			Me.lblDomain.Text = "Domain:"
			' 
			' lblMethod
			' 
			Me.lblMethod.Location = New System.Drawing.Point(236, 69)
			Me.lblMethod.Name = "lblMethod"
			Me.lblMethod.Size = New System.Drawing.Size(80, 13)
			Me.lblMethod.TabIndex = 44
			Me.lblMethod.Text = "Authn Method:"
			' 
			' cbxProxyMethod
			' 
			Me.cbxProxyMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cbxProxyMethod.Enabled = False
			Me.cbxProxyMethod.FormattingEnabled = True
			Me.cbxProxyMethod.Items.AddRange(New Object() { "Basic", "Ntlm"})
			Me.cbxProxyMethod.Location = New System.Drawing.Point(319, 67)
			Me.cbxProxyMethod.Name = "cbxProxyMethod"
			Me.cbxProxyMethod.Size = New System.Drawing.Size(104, 21)
			Me.cbxProxyMethod.TabIndex = 35
			' 
			' lblProxyPort
			' 
			Me.lblProxyPort.Location = New System.Drawing.Point(236, 21)
			Me.lblProxyPort.Name = "lblProxyPort"
			Me.lblProxyPort.Size = New System.Drawing.Size(92, 13)
			Me.lblProxyPort.TabIndex = 42
			Me.lblProxyPort.Text = "Port:"
			' 
			' tbProxyHost
			' 
			Me.tbProxyHost.Location = New System.Drawing.Point(83, 19)
			Me.tbProxyHost.Name = "tbProxyHost"
			Me.tbProxyHost.Size = New System.Drawing.Size(126, 20)
			Me.tbProxyHost.TabIndex = 30
			' 
			' lblProxyServer
			' 
			Me.lblProxyServer.Location = New System.Drawing.Point(10, 21)
			Me.lblProxyServer.Name = "lblProxyServer"
			Me.lblProxyServer.Size = New System.Drawing.Size(70, 13)
			Me.lblProxyServer.TabIndex = 41
			Me.lblProxyServer.Text = "Host:"
			' 
			' cbxProxyType
			' 
			Me.cbxProxyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cbxProxyType.FormattingEnabled = True
			Me.cbxProxyType.Items.AddRange(New Object() { "Never", "Socks4", "Socks4A", "Socks5", "HttpConnect", "SITE Site", "USER user@site", "OPEN site"})
			Me.cbxProxyType.Location = New System.Drawing.Point(319, 43)
			Me.cbxProxyType.Name = "cbxProxyType"
			Me.cbxProxyType.Size = New System.Drawing.Size(104, 21)
			Me.cbxProxyType.TabIndex = 33
			' 
			' tbProxyPassword
			' 
			Me.tbProxyPassword.Enabled = False
			Me.tbProxyPassword.Location = New System.Drawing.Point(83, 67)
			Me.tbProxyPassword.Name = "tbProxyPassword"
			Me.tbProxyPassword.PasswordChar = "*"c
			Me.tbProxyPassword.Size = New System.Drawing.Size(126, 20)
			Me.tbProxyPassword.TabIndex = 34
			' 
			' lblPassword
			' 
			Me.lblPassword.Location = New System.Drawing.Point(10, 69)
			Me.lblPassword.Name = "lblPassword"
			Me.lblPassword.Size = New System.Drawing.Size(56, 13)
			Me.lblPassword.TabIndex = 40
			Me.lblPassword.Text = "Password:"
			' 
			' tbProxyUser
			' 
			Me.tbProxyUser.Location = New System.Drawing.Point(83, 43)
			Me.tbProxyUser.Name = "tbProxyUser"
			Me.tbProxyUser.Size = New System.Drawing.Size(126, 20)
			Me.tbProxyUser.TabIndex = 32
			' 
			' lblUserName
			' 
			Me.lblUserName.Location = New System.Drawing.Point(10, 45)
			Me.lblUserName.Name = "lblUserName"
			Me.lblUserName.Size = New System.Drawing.Size(63, 13)
			Me.lblUserName.TabIndex = 39
			Me.lblUserName.Text = "Proxy User:"
			' 
			' lblType
			' 
			Me.lblType.Location = New System.Drawing.Point(236, 45)
			Me.lblType.Name = "lblType"
			Me.lblType.Size = New System.Drawing.Size(97, 13)
			Me.lblType.TabIndex = 43
			Me.lblType.Text = "Proxy type:"
			' 
			' connectBtn
			' 
			Me.connectBtn.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.connectBtn.Location = New System.Drawing.Point(433, 360)
			Me.connectBtn.Name = "connectBtn"
			Me.connectBtn.Size = New System.Drawing.Size(75, 23)
			Me.connectBtn.TabIndex = 70
			Me.connectBtn.Text = "Connect"
			Me.connectBtn.UseVisualStyleBackColor = True
'			Me.connectBtn.Click += New System.EventHandler(Me.connectBtn_Click)
			' 
			' cancelBtn
			' 
			Me.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.cancelBtn.Location = New System.Drawing.Point(514, 360)
			Me.cancelBtn.Name = "cancelBtn"
			Me.cancelBtn.Size = New System.Drawing.Size(75, 23)
			Me.cancelBtn.TabIndex = 71
			Me.cancelBtn.Text = "Cancel"
			Me.cancelBtn.UseVisualStyleBackColor = True
			' 
			' cbTls11
			' 
			Me.cbTls11.AutoSize = True
			Me.cbTls11.Checked = True
			Me.cbTls11.CheckState = System.Windows.Forms.CheckState.Checked
			Me.cbTls11.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.cbTls11.Location = New System.Drawing.Point(145, 150)
			Me.cbTls11.Name = "cbTls11"
			Me.cbTls11.Size = New System.Drawing.Size(70, 18)
			Me.cbTls11.TabIndex = 21
			Me.cbTls11.Text = "TLS 1.1"
			' 
			' cbTls12
			' 
			Me.cbTls12.AutoSize = True
			Me.cbTls12.Checked = True
			Me.cbTls12.CheckState = System.Windows.Forms.CheckState.Checked
			Me.cbTls12.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.cbTls12.Location = New System.Drawing.Point(205, 150)
			Me.cbTls12.Name = "cbTls12"
			Me.cbTls12.Size = New System.Drawing.Size(70, 18)
			Me.cbTls12.TabIndex = 22
			Me.cbTls12.Text = "TLS 1.2"
			' 
			' ConnectForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(601, 395)
			Me.Controls.Add(Me.cancelBtn)
			Me.Controls.Add(Me.connectBtn)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.grConnection)
			Me.Name = "ConnectForm"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Connect to Server"
			Me.grConnection.ResumeLayout(False)
			Me.grConnection.PerformLayout()
			CType(Me.tbPort, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			CType(Me.tbProxyPort, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private cbUtf8Encoding As System.Windows.Forms.CheckBox
		Private lbSsl As System.Windows.Forms.Label
		Private tbUserName As System.Windows.Forms.TextBox
		Private tbPassword As System.Windows.Forms.TextBox
		Private WithEvents cbxSslMode As System.Windows.Forms.ComboBox
		Private lblFtpPassword As System.Windows.Forms.Label
		Private lblPort As System.Windows.Forms.Label
		Private lblServer As System.Windows.Forms.Label
		Private lblFtpUserName As System.Windows.Forms.Label
		Private cbClearCommandChannel As System.Windows.Forms.CheckBox
		Private lblCert As System.Windows.Forms.Label
		Public cbPasv As System.Windows.Forms.CheckBox
		Private WithEvents btCertBrowse As System.Windows.Forms.Button
		Private tbCert As System.Windows.Forms.TextBox
		Private grConnection As System.Windows.Forms.GroupBox
		Private tbServer As System.Windows.Forms.TextBox
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private tbProxyDomain As System.Windows.Forms.TextBox
		Private lblDomain As System.Windows.Forms.Label
		Private lblMethod As System.Windows.Forms.Label
		Private cbxProxyMethod As System.Windows.Forms.ComboBox
		Private lblProxyPort As System.Windows.Forms.Label
		Private tbProxyHost As System.Windows.Forms.TextBox
		Private lblProxyServer As System.Windows.Forms.Label
		Private cbxProxyType As System.Windows.Forms.ComboBox
		Private tbProxyPassword As System.Windows.Forms.TextBox
		Private lblPassword As System.Windows.Forms.Label
		Private tbProxyUser As System.Windows.Forms.TextBox
		Private lblUserName As System.Windows.Forms.Label
		Private lblType As System.Windows.Forms.Label
		Private WithEvents connectBtn As System.Windows.Forms.Button
		Private cancelBtn As System.Windows.Forms.Button
		Private tbPort As System.Windows.Forms.NumericUpDown
		Private tbProxyPort As System.Windows.Forms.NumericUpDown
		Private suiteDl As System.Windows.Forms.ComboBox
		Private label14 As System.Windows.Forms.Label
		Private cbSsl30 As System.Windows.Forms.CheckBox
		Private cbTls10 As System.Windows.Forms.CheckBox
		Private label13 As System.Windows.Forms.Label
		Private cbTls12 As System.Windows.Forms.CheckBox
		Private cbTls11 As System.Windows.Forms.CheckBox
	End Class
End Namespace