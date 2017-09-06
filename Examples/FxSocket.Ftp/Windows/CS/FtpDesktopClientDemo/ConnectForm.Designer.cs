namespace FxSocketSamples
{
    partial class ConnectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbUtf8Encoding = new System.Windows.Forms.CheckBox();
            this.lbSsl = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.cbxSslMode = new System.Windows.Forms.ComboBox();
            this.lblFtpPassword = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.lblFtpUserName = new System.Windows.Forms.Label();
            this.cbClearCommandChannel = new System.Windows.Forms.CheckBox();
            this.lblCert = new System.Windows.Forms.Label();
            this.cbPasv = new System.Windows.Forms.CheckBox();
            this.btCertBrowse = new System.Windows.Forms.Button();
            this.tbCert = new System.Windows.Forms.TextBox();
            this.grConnection = new System.Windows.Forms.GroupBox();
            this.suiteDl = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbSsl30 = new System.Windows.Forms.CheckBox();
            this.cbTls10 = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.NumericUpDown();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbProxyPort = new System.Windows.Forms.NumericUpDown();
            this.tbProxyDomain = new System.Windows.Forms.TextBox();
            this.lblDomain = new System.Windows.Forms.Label();
            this.lblMethod = new System.Windows.Forms.Label();
            this.cbxProxyMethod = new System.Windows.Forms.ComboBox();
            this.lblProxyPort = new System.Windows.Forms.Label();
            this.tbProxyHost = new System.Windows.Forms.TextBox();
            this.lblProxyServer = new System.Windows.Forms.Label();
            this.cbxProxyType = new System.Windows.Forms.ComboBox();
            this.tbProxyPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbProxyUser = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.connectBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.cbTls11 = new System.Windows.Forms.CheckBox();
            this.cbTls12 = new System.Windows.Forms.CheckBox();
            this.grConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPort)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProxyPort)).BeginInit();
            this.SuspendLayout();
            // 
            // cbUtf8Encoding
            // 
            this.cbUtf8Encoding.AutoSize = true;
            this.cbUtf8Encoding.Location = new System.Drawing.Point(84, 99);
            this.cbUtf8Encoding.Name = "cbUtf8Encoding";
            this.cbUtf8Encoding.Size = new System.Drawing.Size(94, 17);
            this.cbUtf8Encoding.TabIndex = 6;
            this.cbUtf8Encoding.Text = "Utf8 Encoding";
            // 
            // lbSsl
            // 
            this.lbSsl.Location = new System.Drawing.Point(376, 23);
            this.lbSsl.Name = "lbSsl";
            this.lbSsl.Size = new System.Drawing.Size(83, 13);
            this.lbSsl.TabIndex = 58;
            this.lbSsl.Text = "SSL Mode:";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(84, 48);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(123, 20);
            this.tbUserName.TabIndex = 4;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(84, 73);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(123, 20);
            this.tbPassword.TabIndex = 5;
            // 
            // cbxSslMode
            // 
            this.cbxSslMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSslMode.FormattingEnabled = true;
            this.cbxSslMode.Items.AddRange(new object[] {
            "None",
            "Implicit",
            "Explicit"});
            this.cbxSslMode.Location = new System.Drawing.Point(465, 19);
            this.cbxSslMode.Name = "cbxSslMode";
            this.cbxSslMode.Size = new System.Drawing.Size(99, 21);
            this.cbxSslMode.TabIndex = 3;
            this.cbxSslMode.SelectedIndexChanged += new System.EventHandler(this.sslDropDown_SelectedIndexChanged);
            // 
            // lblFtpPassword
            // 
            this.lblFtpPassword.Location = new System.Drawing.Point(11, 76);
            this.lblFtpPassword.Name = "lblFtpPassword";
            this.lblFtpPassword.Size = new System.Drawing.Size(56, 13);
            this.lblFtpPassword.TabIndex = 66;
            this.lblFtpPassword.Text = "Password:";
            // 
            // lblPort
            // 
            this.lblPort.Location = new System.Drawing.Point(221, 23);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(37, 13);
            this.lblPort.TabIndex = 64;
            this.lblPort.Text = "Port:";
            // 
            // lblServer
            // 
            this.lblServer.Location = new System.Drawing.Point(11, 23);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(59, 13);
            this.lblServer.TabIndex = 63;
            this.lblServer.Text = "Server:";
            // 
            // lblFtpUserName
            // 
            this.lblFtpUserName.Location = new System.Drawing.Point(11, 50);
            this.lblFtpUserName.Name = "lblFtpUserName";
            this.lblFtpUserName.Size = new System.Drawing.Size(63, 13);
            this.lblFtpUserName.TabIndex = 65;
            this.lblFtpUserName.Text = "User Name:";
            // 
            // cbClearCommandChannel
            // 
            this.cbClearCommandChannel.AutoSize = true;
            this.cbClearCommandChannel.Checked = true;
            this.cbClearCommandChannel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbClearCommandChannel.Location = new System.Drawing.Point(287, 99);
            this.cbClearCommandChannel.Name = "cbClearCommandChannel";
            this.cbClearCommandChannel.Size = new System.Drawing.Size(142, 17);
            this.cbClearCommandChannel.TabIndex = 8;
            this.cbClearCommandChannel.Text = "Clear Command Channel";
            // 
            // lblCert
            // 
            this.lblCert.Location = new System.Drawing.Point(8, 118);
            this.lblCert.Name = "lblCert";
            this.lblCert.Size = new System.Drawing.Size(63, 29);
            this.lblCert.TabIndex = 67;
            this.lblCert.Text = "Client\r\nCertificate:";
            // 
            // cbPasv
            // 
            this.cbPasv.AutoSize = true;
            this.cbPasv.BackColor = System.Drawing.SystemColors.Control;
            this.cbPasv.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbPasv.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPasv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbPasv.Location = new System.Drawing.Point(184, 99);
            this.cbPasv.Name = "cbPasv";
            this.cbPasv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbPasv.Size = new System.Drawing.Size(93, 18);
            this.cbPasv.TabIndex = 7;
            this.cbPasv.Text = "Passive Mode";
            this.cbPasv.UseVisualStyleBackColor = false;
            // 
            // btCertBrowse
            // 
            this.btCertBrowse.Location = new System.Drawing.Point(465, 119);
            this.btCertBrowse.Name = "btCertBrowse";
            this.btCertBrowse.Size = new System.Drawing.Size(26, 20);
            this.btCertBrowse.TabIndex = 10;
            this.btCertBrowse.Text = "...";
            this.btCertBrowse.Click += new System.EventHandler(this.certBrowseBtn_Click);
            // 
            // tbCert
            // 
            this.tbCert.Location = new System.Drawing.Point(84, 120);
            this.tbCert.Name = "tbCert";
            this.tbCert.Size = new System.Drawing.Size(368, 20);
            this.tbCert.TabIndex = 9;
            // 
            // grConnection
            // 
            this.grConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grConnection.Controls.Add(this.cbTls12);
            this.grConnection.Controls.Add(this.cbTls11);
            this.grConnection.Controls.Add(this.suiteDl);
            this.grConnection.Controls.Add(this.label14);
            this.grConnection.Controls.Add(this.cbSsl30);
            this.grConnection.Controls.Add(this.cbTls10);
            this.grConnection.Controls.Add(this.label13);
            this.grConnection.Controls.Add(this.tbPort);
            this.grConnection.Controls.Add(this.tbServer);
            this.grConnection.Controls.Add(this.cbUtf8Encoding);
            this.grConnection.Controls.Add(this.tbCert);
            this.grConnection.Controls.Add(this.lbSsl);
            this.grConnection.Controls.Add(this.btCertBrowse);
            this.grConnection.Controls.Add(this.tbUserName);
            this.grConnection.Controls.Add(this.cbPasv);
            this.grConnection.Controls.Add(this.tbPassword);
            this.grConnection.Controls.Add(this.lblCert);
            this.grConnection.Controls.Add(this.cbxSslMode);
            this.grConnection.Controls.Add(this.cbClearCommandChannel);
            this.grConnection.Controls.Add(this.lblFtpPassword);
            this.grConnection.Controls.Add(this.lblFtpUserName);
            this.grConnection.Controls.Add(this.lblServer);
            this.grConnection.Controls.Add(this.lblPort);
            this.grConnection.Location = new System.Drawing.Point(12, 8);
            this.grConnection.Name = "grConnection";
            this.grConnection.Size = new System.Drawing.Size(577, 218);
            this.grConnection.TabIndex = 68;
            this.grConnection.TabStop = false;
            this.grConnection.Text = "Connection";
            // 
            // suiteDl
            // 
            this.suiteDl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suiteDl.Items.AddRange(new object[] {
            "All ciphers",
            "Secure only"});
            this.suiteDl.Location = new System.Drawing.Point(85, 191);
            this.suiteDl.Name = "suiteDl";
            this.suiteDl.Size = new System.Drawing.Size(132, 21);
            this.suiteDl.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 194);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 71;
            this.label14.Text = "Allowed suites:";
            // 
            // cbSsl30
            // 
            this.cbSsl30.Checked = true;
            this.cbSsl30.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSsl30.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbSsl30.Location = new System.Drawing.Point(280, 147);
            this.cbSsl30.Name = "cbSsl30";
            this.cbSsl30.Size = new System.Drawing.Size(64, 24);
            this.cbSsl30.TabIndex = 23;
            this.cbSsl30.Text = "SSL 3.0";
            // 
            // cbTls10
            // 
            this.cbTls10.Checked = true;
            this.cbTls10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTls10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbTls10.Location = new System.Drawing.Point(85, 147);
            this.cbTls10.Name = "cbTls10";
            this.cbTls10.Size = new System.Drawing.Size(72, 24);
            this.cbTls10.TabIndex = 20;
            this.cbTls10.Text = "TLS 1.0";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(11, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 36);
            this.label13.TabIndex = 68;
            this.label13.Text = "Allowed \r\nprotocol:";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(264, 20);
            this.tbPort.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.tbPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(89, 20);
            this.tbPort.TabIndex = 2;
            this.tbPort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(84, 21);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(123, 20);
            this.tbServer.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbProxyPort);
            this.groupBox1.Controls.Add(this.tbProxyDomain);
            this.groupBox1.Controls.Add(this.lblDomain);
            this.groupBox1.Controls.Add(this.lblMethod);
            this.groupBox1.Controls.Add(this.cbxProxyMethod);
            this.groupBox1.Controls.Add(this.lblProxyPort);
            this.groupBox1.Controls.Add(this.tbProxyHost);
            this.groupBox1.Controls.Add(this.lblProxyServer);
            this.groupBox1.Controls.Add(this.cbxProxyType);
            this.groupBox1.Controls.Add(this.tbProxyPassword);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.tbProxyUser);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Location = new System.Drawing.Point(13, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 126);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proxy";
            // 
            // tbProxyPort
            // 
            this.tbProxyPort.Location = new System.Drawing.Point(319, 17);
            this.tbProxyPort.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.tbProxyPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbProxyPort.Name = "tbProxyPort";
            this.tbProxyPort.Size = new System.Drawing.Size(89, 20);
            this.tbProxyPort.TabIndex = 31;
            this.tbProxyPort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbProxyDomain
            // 
            this.tbProxyDomain.Enabled = false;
            this.tbProxyDomain.Location = new System.Drawing.Point(83, 91);
            this.tbProxyDomain.Name = "tbProxyDomain";
            this.tbProxyDomain.Size = new System.Drawing.Size(126, 20);
            this.tbProxyDomain.TabIndex = 36;
            // 
            // lblDomain
            // 
            this.lblDomain.Location = new System.Drawing.Point(10, 93);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(46, 13);
            this.lblDomain.TabIndex = 45;
            this.lblDomain.Text = "Domain:";
            // 
            // lblMethod
            // 
            this.lblMethod.Location = new System.Drawing.Point(236, 69);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(80, 13);
            this.lblMethod.TabIndex = 44;
            this.lblMethod.Text = "Authn Method:";
            // 
            // cbxProxyMethod
            // 
            this.cbxProxyMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProxyMethod.Enabled = false;
            this.cbxProxyMethod.FormattingEnabled = true;
            this.cbxProxyMethod.Items.AddRange(new object[] {
            "Basic",
            "Ntlm"});
            this.cbxProxyMethod.Location = new System.Drawing.Point(319, 67);
            this.cbxProxyMethod.Name = "cbxProxyMethod";
            this.cbxProxyMethod.Size = new System.Drawing.Size(104, 21);
            this.cbxProxyMethod.TabIndex = 35;
            // 
            // lblProxyPort
            // 
            this.lblProxyPort.Location = new System.Drawing.Point(236, 21);
            this.lblProxyPort.Name = "lblProxyPort";
            this.lblProxyPort.Size = new System.Drawing.Size(92, 13);
            this.lblProxyPort.TabIndex = 42;
            this.lblProxyPort.Text = "Port:";
            // 
            // tbProxyHost
            // 
            this.tbProxyHost.Location = new System.Drawing.Point(83, 19);
            this.tbProxyHost.Name = "tbProxyHost";
            this.tbProxyHost.Size = new System.Drawing.Size(126, 20);
            this.tbProxyHost.TabIndex = 30;
            // 
            // lblProxyServer
            // 
            this.lblProxyServer.Location = new System.Drawing.Point(10, 21);
            this.lblProxyServer.Name = "lblProxyServer";
            this.lblProxyServer.Size = new System.Drawing.Size(70, 13);
            this.lblProxyServer.TabIndex = 41;
            this.lblProxyServer.Text = "Host:";
            // 
            // cbxProxyType
            // 
            this.cbxProxyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProxyType.FormattingEnabled = true;
            this.cbxProxyType.Items.AddRange(new object[] {
            "Never",
            "Socks4",
            "Socks4A",
            "Socks5",
            "HttpConnect",
            "SITE Site",
            "USER user@site",
            "OPEN site"});
            this.cbxProxyType.Location = new System.Drawing.Point(319, 43);
            this.cbxProxyType.Name = "cbxProxyType";
            this.cbxProxyType.Size = new System.Drawing.Size(104, 21);
            this.cbxProxyType.TabIndex = 33;
            // 
            // tbProxyPassword
            // 
            this.tbProxyPassword.Enabled = false;
            this.tbProxyPassword.Location = new System.Drawing.Point(83, 67);
            this.tbProxyPassword.Name = "tbProxyPassword";
            this.tbProxyPassword.PasswordChar = '*';
            this.tbProxyPassword.Size = new System.Drawing.Size(126, 20);
            this.tbProxyPassword.TabIndex = 34;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(10, 69);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 40;
            this.lblPassword.Text = "Password:";
            // 
            // tbProxyUser
            // 
            this.tbProxyUser.Location = new System.Drawing.Point(83, 43);
            this.tbProxyUser.Name = "tbProxyUser";
            this.tbProxyUser.Size = new System.Drawing.Size(126, 20);
            this.tbProxyUser.TabIndex = 32;
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(10, 45);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(63, 13);
            this.lblUserName.TabIndex = 39;
            this.lblUserName.Text = "Proxy User:";
            // 
            // lblType
            // 
            this.lblType.Location = new System.Drawing.Point(236, 45);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(97, 13);
            this.lblType.TabIndex = 43;
            this.lblType.Text = "Proxy type:";
            // 
            // connectBtn
            // 
            this.connectBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.connectBtn.Location = new System.Drawing.Point(433, 360);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(75, 23);
            this.connectBtn.TabIndex = 70;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(514, 360);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 71;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // cbTls11
            // 
            this.cbTls11.AutoSize = true;
            this.cbTls11.Checked = true;
            this.cbTls11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTls11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbTls11.Location = new System.Drawing.Point(145, 150);
            this.cbTls11.Name = "cbTls11";
            this.cbTls11.Size = new System.Drawing.Size(70, 18);
            this.cbTls11.TabIndex = 21;
            this.cbTls11.Text = "TLS 1.1";
            // 
            // cbTls12
            // 
            this.cbTls12.AutoSize = true;
            this.cbTls12.Checked = true;
            this.cbTls12.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTls12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbTls12.Location = new System.Drawing.Point(205, 150);
            this.cbTls12.Name = "cbTls12";
            this.cbTls12.Size = new System.Drawing.Size(70, 18);
            this.cbTls12.TabIndex = 22;
            this.cbTls12.Text = "TLS 1.2";
            // 
            // ConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 395);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grConnection);
            this.Name = "ConnectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect to Server";
            this.grConnection.ResumeLayout(false);
            this.grConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPort)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProxyPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbUtf8Encoding;
        private System.Windows.Forms.Label lbSsl;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.ComboBox cbxSslMode;
        private System.Windows.Forms.Label lblFtpPassword;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblFtpUserName;
        private System.Windows.Forms.CheckBox cbClearCommandChannel;
        private System.Windows.Forms.Label lblCert;
        public System.Windows.Forms.CheckBox cbPasv;
        private System.Windows.Forms.Button btCertBrowse;
        private System.Windows.Forms.TextBox tbCert;
        private System.Windows.Forms.GroupBox grConnection;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbProxyDomain;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.ComboBox cbxProxyMethod;
        private System.Windows.Forms.Label lblProxyPort;
        private System.Windows.Forms.TextBox tbProxyHost;
        private System.Windows.Forms.Label lblProxyServer;
        private System.Windows.Forms.ComboBox cbxProxyType;
        private System.Windows.Forms.TextBox tbProxyPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbProxyUser;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.NumericUpDown tbPort;
        private System.Windows.Forms.NumericUpDown tbProxyPort;
        private System.Windows.Forms.ComboBox suiteDl;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox cbSsl30;
        private System.Windows.Forms.CheckBox cbTls10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox cbTls12;
        private System.Windows.Forms.CheckBox cbTls11;
    }
}