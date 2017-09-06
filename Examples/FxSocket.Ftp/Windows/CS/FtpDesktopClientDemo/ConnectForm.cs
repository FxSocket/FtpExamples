using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FxSocket.Net;

namespace FxSocketSamples
{
    public partial class ConnectForm : Form
    {
        public ConnectForm()
        {
            InitializeComponent();


            Server = (string)Common.GetKey("Server", "");
            Port = Common.GetKey("Port", 21);
            SslMode = (SslMode)Common.GetKey("Ssl", 0);

            UserName = (string)Common.GetKey("User", "");
            Password = (string)Common.GetKey("Pass", "");
            UseUtf8Encoding = Common.GetKey("Utf8", false);
            PassiveMode = Common.GetKey("Passive", true);

            Ccc = Common.GetKey("Ccc", false);
            ClientCert = (string)Common.GetKey("Cert", "");

            Protocol = (TlsVersion)Common.GetKey("Protocol", (int)TlsVersion.Any);
            AllowedSuite = (TlsCipherSuite)Common.GetKey("AllowedSuite", (long)TlsCipherSuite.All);

            ProxyHost = (string)Common.GetKey("ProxyHost", "");
            ProxyPort = Common.GetKey("ProxyPort", 1080);
            ProxyType = (FtpProxyType)Common.GetKey("ProxyType", 0);
            ProxyAuthnMethod = (FtpProxyAuthentication)Common.GetKey("ProxyAuthnMethod", 0);
            ProxyUser = (string)Common.GetKey("ProxyUser", "");
            ProxyPassword = (string)Common.GetKey("ProxyPassword", "");
            ProxyDomain = (string)Common.GetKey("ProxyDomain", "");
        }

        public string Server
        {
            get { return tbServer.Text; }
            set { tbServer.Text = value; }
        }

        public int Port
        {
            get { return (int)tbPort.Value; }
            set { tbPort.Value = value; }
        }

        public SslMode SslMode
        {
            get { return (SslMode)cbxSslMode.SelectedIndex; }
            set { cbxSslMode.SelectedIndex = (int)value; }
        }

        public string UserName
        {
            get { return tbUserName.Text; }
            set { tbUserName.Text = value; }
        }

        public string Password
        {
            get { return tbPassword.Text; }
            set { tbPassword.Text = value; }
        }

        public bool UseUtf8Encoding
        {
            get { return cbUtf8Encoding.Checked; }
            set { cbUtf8Encoding.Checked = value; }
        }

        public bool PassiveMode
        {
            get { return cbPasv.Checked; }
            set { cbPasv.Checked = value; }
        }

        #region Security

        public bool Ccc
        {
            get { return cbClearCommandChannel.Checked; }
            set { cbClearCommandChannel.Checked = value; }
        }

        public string ClientCert
        {
            get { return tbCert.Text; }
            set { tbCert.Text = value; }
        }

        public TlsCipherSuite AllowedSuite
        {
            get
            {
                if (suiteDl.SelectedIndex == 0)
                    return TlsCipherSuite.All;
                else
                    return TlsCipherSuite.Secure;
            }
            set
            {
                if (value == TlsCipherSuite.All)
                    suiteDl.SelectedIndex = 0;
                else
                    suiteDl.SelectedIndex = 1;
            }
        }

        public TlsVersion Protocol
        {
            get
            {
                TlsVersion value = 0;
                if (cbTls10.Checked)
                    value |= TlsVersion.TLS10;
                if (cbTls11.Checked)
                    value |= TlsVersion.TLS11;
                if (cbTls12.Checked)
                    value |= TlsVersion.TLS12;

                if (cbSsl30.Checked)
                    value |= TlsVersion.SSL30;

                return value;
            }
            set
            {
                cbTls10.Checked = ((value & TlsVersion.TLS10) != 0);
                cbTls11.Checked = ((value & TlsVersion.TLS11) != 0);
                cbTls12.Checked = ((value & TlsVersion.TLS12) != 0);

                cbSsl30.Checked = ((value & TlsVersion.SSL30) != 0);
            }
        }

        #endregion

        #region Proxy

        public string ProxyHost
        {
            get { return tbProxyHost.Text; }
            set { tbProxyHost.Text = value; }
        }

        public int ProxyPort
        {
            get { return (int)tbProxyPort.Value; }
            set { tbProxyPort.Value = value; }
        }

        public string ProxyUser
        {
            get { return tbProxyUser.Text; }
            set { tbProxyUser.Text = value; }
        }

        public string ProxyPassword
        {
            get { return tbProxyPassword.Text; }
            set { tbProxyPassword.Text = value; }
        }

        public string ProxyDomain
        {
            get { return tbProxyDomain.Text; }
            set { tbProxyDomain.Text = value; }
        }

        public FtpProxyType ProxyType
        {
            get { return (FtpProxyType)cbxProxyType.SelectedIndex; }
            set { cbxProxyType.SelectedIndex = (int)value; }
        }

        public FtpProxyAuthentication ProxyAuthnMethod
        {
            get { return (FtpProxyAuthentication)cbxProxyMethod.SelectedIndex; }
            set { cbxProxyMethod.SelectedIndex = (int)value; }
        }

        #endregion

        private void connectBtn_Click(object sender, EventArgs e)
        {
            Common.SetKey("Server", Server);
            Common.SetKey("Port", Port);
            Common.SetKey("Ssl", (int)SslMode);

            Common.SetKey("User", UserName);
            Common.SetKey("Pass", Password);
            Common.SetKey("Utf8", UseUtf8Encoding);
            Common.SetKey("Passive", PassiveMode);

            Common.SetKey("Ccc", Ccc);
            Common.SetKey("Cert", ClientCert);

            Common.SetKey("Protocol", (int)Protocol);
            Common.SetKey("AllowedSuite", (int)AllowedSuite);

            Common.SetKey("ProxyHost", ProxyHost);
            Common.SetKey("ProxyPort", ProxyPort);
            Common.SetKey("ProxyType", ProxyType);
            Common.SetKey("ProxyAuthnMethod", ProxyAuthnMethod);
            Common.SetKey("ProxyUser", ProxyUser);
            Common.SetKey("ProxyPassword", ProxyPassword);
            Common.SetKey("ProxyDomain", ProxyDomain);
        }

        private void sslDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            btCertBrowse.Enabled = tbCert.Enabled = cbSsl30.Enabled = cbTls10.Enabled = cbTls11.Enabled = cbTls12.Enabled = suiteDl.Enabled = cbxSslMode.SelectedIndex > 0;
        }

        private void certBrowseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Title = "Select a private key file";
                dlg.FileName = tbCert.Text;
                dlg.Filter = "All files|*.*";
                dlg.FilterIndex = 1;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    tbCert.Text = dlg.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
