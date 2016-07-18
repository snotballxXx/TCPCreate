namespace TCPTest
{
    partial class ClientServer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.rbServer = new System.Windows.Forms.RadioButton();
            this.rbClient = new System.Windows.Forms.RadioButton();
            this.tabControlClientServer = new System.Windows.Forms.TabControl();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelServerText = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.cbAutoReconnect = new System.Windows.Forms.CheckBox();
            this.timerReconnect = new System.Windows.Forms.Timer(this.components);
            this.cbEcho = new System.Windows.Forms.CheckBox();
            this.cbUDP = new System.Windows.Forms.CheckBox();
            this.tbListenerPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(385, 60);
            this.buttonDisconnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(147, 35);
            this.buttonDisconnect.TabIndex = 3;
            this.buttonDisconnect.Text = "Shutdown";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(385, 22);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(147, 35);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Listen";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "IP Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Port";
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(182, 65);
            this.tbIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(148, 26);
            this.tbIP.TabIndex = 1;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(182, 25);
            this.tbPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(148, 26);
            this.tbPort.TabIndex = 0;
            // 
            // rbServer
            // 
            this.rbServer.AutoSize = true;
            this.rbServer.Checked = true;
            this.rbServer.Location = new System.Drawing.Point(540, 5);
            this.rbServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbServer.Name = "rbServer";
            this.rbServer.Size = new System.Drawing.Size(80, 24);
            this.rbServer.TabIndex = 5;
            this.rbServer.TabStop = true;
            this.rbServer.Text = "Server";
            this.rbServer.UseVisualStyleBackColor = true;
            this.rbServer.Visible = false;
            this.rbServer.CheckedChanged += new System.EventHandler(this.rbServer_CheckedChanged);
            // 
            // rbClient
            // 
            this.rbClient.AutoSize = true;
            this.rbClient.Location = new System.Drawing.Point(633, 5);
            this.rbClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbClient.Name = "rbClient";
            this.rbClient.Size = new System.Drawing.Size(74, 24);
            this.rbClient.TabIndex = 6;
            this.rbClient.Text = "Client";
            this.rbClient.UseVisualStyleBackColor = true;
            this.rbClient.Visible = false;
            // 
            // tabControlClientServer
            // 
            this.tabControlClientServer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlClientServer.Location = new System.Drawing.Point(27, 137);
            this.tabControlClientServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControlClientServer.Name = "tabControlClientServer";
            this.tabControlClientServer.SelectedIndex = 0;
            this.tabControlClientServer.Size = new System.Drawing.Size(736, 88);
            this.tabControlClientServer.TabIndex = 4;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Image = global::TCPTest.Properties.Resources.MT2_16x16;
            this.buttonClose.Location = new System.Drawing.Point(762, -2);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(30, 31);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelServerText
            // 
            this.labelServerText.AutoSize = true;
            this.labelServerText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelServerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServerText.ForeColor = System.Drawing.Color.Red;
            this.labelServerText.Location = new System.Drawing.Point(45, 160);
            this.labelServerText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelServerText.Name = "labelServerText";
            this.labelServerText.Size = new System.Drawing.Size(73, 42);
            this.labelServerText.TabIndex = 12;
            this.labelServerText.Text = "xxx";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(28, 112);
            this.labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 20);
            this.labelError.TabIndex = 9;
            // 
            // cbAutoReconnect
            // 
            this.cbAutoReconnect.AutoSize = true;
            this.cbAutoReconnect.Location = new System.Drawing.Point(549, 28);
            this.cbAutoReconnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbAutoReconnect.Name = "cbAutoReconnect";
            this.cbAutoReconnect.Size = new System.Drawing.Size(215, 24);
            this.cbAutoReconnect.TabIndex = 13;
            this.cbAutoReconnect.Text = "Auto Reconnect On Error";
            this.cbAutoReconnect.UseVisualStyleBackColor = true;
            // 
            // timerReconnect
            // 
            this.timerReconnect.Interval = 5000;
            this.timerReconnect.Tick += new System.EventHandler(this.timerReconnect_Tick);
            // 
            // cbEcho
            // 
            this.cbEcho.AutoSize = true;
            this.cbEcho.Location = new System.Drawing.Point(549, 29);
            this.cbEcho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbEcho.Name = "cbEcho";
            this.cbEcho.Size = new System.Drawing.Size(164, 24);
            this.cbEcho.TabIndex = 13;
            this.cbEcho.Text = "Set Auto Echo On";
            this.cbEcho.UseVisualStyleBackColor = true;
            this.cbEcho.CheckedChanged += new System.EventHandler(this.cbAutoReconnect_CheckedChanged);
            // 
            // cbUDP
            // 
            this.cbUDP.AutoSize = true;
            this.cbUDP.Location = new System.Drawing.Point(549, 67);
            this.cbUDP.Name = "cbUDP";
            this.cbUDP.Size = new System.Drawing.Size(69, 24);
            this.cbUDP.TabIndex = 14;
            this.cbUDP.Text = "UDP";
            this.cbUDP.UseVisualStyleBackColor = true;
            this.cbUDP.CheckedChanged += new System.EventHandler(this.cbUDP_CheckedChanged);
            // 
            // tbListenerPort
            // 
            this.tbListenerPort.Location = new System.Drawing.Point(180, 101);
            this.tbListenerPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbListenerPort.Name = "tbListenerPort";
            this.tbListenerPort.Size = new System.Drawing.Size(148, 26);
            this.tbListenerPort.TabIndex = 0;
            this.tbListenerPort.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Listening UDP Port";
            this.label3.Visible = false;
            // 
            // ClientServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbUDP);
            this.Controls.Add(this.cbEcho);
            this.Controls.Add(this.cbAutoReconnect);
            this.Controls.Add(this.labelServerText);
            this.Controls.Add(this.tabControlClientServer);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.tbListenerPort);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.rbServer);
            this.Controls.Add(this.rbClient);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClientServer";
            this.Size = new System.Drawing.Size(790, 252);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.RadioButton rbServer;
        private System.Windows.Forms.RadioButton rbClient;
        private System.Windows.Forms.TabControl tabControlClientServer;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelServerText;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.CheckBox cbAutoReconnect;
        private System.Windows.Forms.Timer timerReconnect;
        private System.Windows.Forms.CheckBox cbEcho;
        private System.Windows.Forms.CheckBox cbUDP;
        private System.Windows.Forms.TextBox tbListenerPort;
        private System.Windows.Forms.Label label3;
    }
}
