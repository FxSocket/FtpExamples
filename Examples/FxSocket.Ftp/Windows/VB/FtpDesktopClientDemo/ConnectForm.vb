Imports System.ComponentModel
Imports System.Text
Imports FxSocket.Net

Namespace FxSocketSamples
	Partial Public Class ConnectForm
		Inherits Form
		Public Sub New()
			InitializeComponent()


			Server = CStr(Common.GetKey("Server", ""))
			Port = Common.GetKey("Port", 21)
			SslMode = CType(Common.GetKey("Ssl", 0), SslMode)

			UserName = CStr(Common.GetKey("User", ""))
			Password = CStr(Common.GetKey("Pass", ""))
			UseUtf8Encoding = Common.GetKey("Utf8", False)
			PassiveMode = Common.GetKey("Passive", True)

			Ccc = Common.GetKey("Ccc", False)
			ClientCert = CStr(Common.GetKey("Cert", ""))

			Protocol = CType(Common.GetKey("Protocol", CInt(TlsVersion.Any)), TlsVersion)
			AllowedSuite = CType(Common.GetKey("AllowedSuite", CLng(TlsCipherSuite.All)), TlsCipherSuite)

			ProxyHost = CStr(Common.GetKey("ProxyHost", ""))
			ProxyPort = Common.GetKey("ProxyPort", 1080)
			ProxyType = CType(Common.GetKey("ProxyType", 0), FtpProxyType)
			ProxyAuthnMethod = CType(Common.GetKey("ProxyAuthnMethod", 0), FtpProxyAuthentication)
			ProxyUser = CStr(Common.GetKey("ProxyUser", ""))
			ProxyPassword = CStr(Common.GetKey("ProxyPassword", ""))
			ProxyDomain = CStr(Common.GetKey("ProxyDomain", ""))
		End Sub

		Public Property Server() As String
			Get
				Return tbServer.Text
			End Get
			Set(ByVal value As String)
				tbServer.Text = value
			End Set
		End Property

		Public Property Port() As Integer
			Get
				Return CInt(Fix(tbPort.Value))
			End Get
			Set(ByVal value As Integer)
				tbPort.Value = value
			End Set
		End Property

		Public Property SslMode() As SslMode
			Get
				Return CType(cbxSslMode.SelectedIndex, SslMode)
			End Get
			Set(ByVal value As SslMode)
				cbxSslMode.SelectedIndex = CInt(value)
			End Set
		End Property

		Public Property UserName() As String
			Get
				Return tbUserName.Text
			End Get
			Set(ByVal value As String)
				tbUserName.Text = value
			End Set
		End Property

		Public Property Password() As String
			Get
				Return tbPassword.Text
			End Get
			Set(ByVal value As String)
				tbPassword.Text = value
			End Set
		End Property

		Public Property UseUtf8Encoding() As Boolean
			Get
				Return cbUtf8Encoding.Checked
			End Get
			Set(ByVal value As Boolean)
				cbUtf8Encoding.Checked = value
			End Set
		End Property

		Public Property PassiveMode() As Boolean
			Get
				Return cbPasv.Checked
			End Get
			Set(ByVal value As Boolean)
				cbPasv.Checked = value
			End Set
		End Property

		#Region "Security"

		Public Property Ccc() As Boolean
			Get
				Return cbClearCommandChannel.Checked
			End Get
			Set(ByVal value As Boolean)
				cbClearCommandChannel.Checked = value
			End Set
		End Property

		Public Property ClientCert() As String
			Get
				Return tbCert.Text
			End Get
			Set(ByVal value As String)
				tbCert.Text = value
			End Set
		End Property

		Public Property AllowedSuite() As TlsCipherSuite
			Get
				If suiteDl.SelectedIndex = 0 Then
					Return TlsCipherSuite.All
				Else
					Return TlsCipherSuite.Secure
				End If
			End Get
			Set(ByVal value As TlsCipherSuite)
				If value = TlsCipherSuite.All Then
					suiteDl.SelectedIndex = 0
				Else
					suiteDl.SelectedIndex = 1
				End If
			End Set
		End Property

		Public Property Protocol() As TlsVersion
			Get
				Dim value As TlsVersion = 0
				If cbTls10.Checked Then
					value = value Or TlsVersion.TLS10
				End If
				If cbTls11.Checked Then
					value = value Or TlsVersion.TLS11
				End If
				If cbTls12.Checked Then
					value = value Or TlsVersion.TLS12
				End If

				If cbSsl30.Checked Then
					value = value Or TlsVersion.SSL30
				End If

				Return value
			End Get
			Set(ByVal value As TlsVersion)
				cbTls10.Checked = ((value And TlsVersion.TLS10) <> 0)
				cbTls11.Checked = ((value And TlsVersion.TLS11) <> 0)
				cbTls12.Checked = ((value And TlsVersion.TLS12) <> 0)

				cbSsl30.Checked = ((value And TlsVersion.SSL30) <> 0)
			End Set
		End Property

		#End Region

		#Region "Proxy"

		Public Property ProxyHost() As String
			Get
				Return tbProxyHost.Text
			End Get
			Set(ByVal value As String)
				tbProxyHost.Text = value
			End Set
		End Property

		Public Property ProxyPort() As Integer
			Get
				Return CInt(Fix(tbProxyPort.Value))
			End Get
			Set(ByVal value As Integer)
				tbProxyPort.Value = value
			End Set
		End Property

		Public Property ProxyUser() As String
			Get
				Return tbProxyUser.Text
			End Get
			Set(ByVal value As String)
				tbProxyUser.Text = value
			End Set
		End Property

		Public Property ProxyPassword() As String
			Get
				Return tbProxyPassword.Text
			End Get
			Set(ByVal value As String)
				tbProxyPassword.Text = value
			End Set
		End Property

		Public Property ProxyDomain() As String
			Get
				Return tbProxyDomain.Text
			End Get
			Set(ByVal value As String)
				tbProxyDomain.Text = value
			End Set
		End Property

		Public Property ProxyType() As FtpProxyType
			Get
				Return CType(cbxProxyType.SelectedIndex, FtpProxyType)
			End Get
			Set(ByVal value As FtpProxyType)
				cbxProxyType.SelectedIndex = CInt(value)
			End Set
		End Property

		Public Property ProxyAuthnMethod() As FtpProxyAuthentication
			Get
				Return CType(cbxProxyMethod.SelectedIndex, FtpProxyAuthentication)
			End Get
			Set(ByVal value As FtpProxyAuthentication)
				cbxProxyMethod.SelectedIndex = CInt(value)
			End Set
		End Property

		#End Region

		Private Sub connectBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles connectBtn.Click
			Common.SetKey("Server", Server)
			Common.SetKey("Port", Port)
			Common.SetKey("Ssl", CInt(SslMode))

			Common.SetKey("User", UserName)
			Common.SetKey("Pass", Password)
			Common.SetKey("Utf8", UseUtf8Encoding)
			Common.SetKey("Passive", PassiveMode)

			Common.SetKey("Ccc", Ccc)
			Common.SetKey("Cert", ClientCert)

			Common.SetKey("Protocol", CInt(Protocol))
			Common.SetKey("AllowedSuite", CInt(AllowedSuite))

			Common.SetKey("ProxyHost", ProxyHost)
			Common.SetKey("ProxyPort", ProxyPort)
			Common.SetKey("ProxyType", ProxyType)
			Common.SetKey("ProxyAuthnMethod", ProxyAuthnMethod)
			Common.SetKey("ProxyUser", ProxyUser)
			Common.SetKey("ProxyPassword", ProxyPassword)
			Common.SetKey("ProxyDomain", ProxyDomain)
		End Sub

		Private Sub sslDropDown_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxSslMode.SelectedIndexChanged
			suiteDl.Enabled = cbxSslMode.SelectedIndex > 0
			cbTls12.Enabled = suiteDl.Enabled
			cbTls11.Enabled = cbTls12.Enabled
			cbTls10.Enabled = cbTls11.Enabled
			cbSsl30.Enabled = cbTls10.Enabled
			tbCert.Enabled = cbSsl30.Enabled
			btCertBrowse.Enabled = tbCert.Enabled
		End Sub

		Private Sub certBrowseBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btCertBrowse.Click
			Try
				Dim dlg As New OpenFileDialog()
				dlg.Title = "Select a private key file"
				dlg.FileName = tbCert.Text
				dlg.Filter = "All files|*.*"
				dlg.FilterIndex = 1
				If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
					tbCert.Text = dlg.FileName
				End If
			Catch ex As Exception
				MessageBox.Show(ex.Message, "Error")
			End Try
		End Sub
	End Class
End Namespace
