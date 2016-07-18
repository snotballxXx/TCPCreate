namespace TCPTest
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.LoggerTab = new System.Windows.Forms.TabPage();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.tbDefaultIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAllClientConnect = new System.Windows.Forms.Button();
            this.buttonStartServers = new System.Windows.Forms.Button();
            this.buttonAllClientDisconnect = new System.Windows.Forms.Button();
            this.buttonStopServers = new System.Windows.Forms.Button();
            this.buttonNewServer = new System.Windows.Forms.Button();
            this.buttonNewClient = new System.Windows.Forms.Button();
            this.cbAutoReconnect = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.LoggerTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.LoggerTab);
            this.tabControlMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlMain.Location = new System.Drawing.Point(0, 88);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(687, 301);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.TabControlMainDrawItem);
            this.tabControlMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControlMain_MouseClick);
            // 
            // LoggerTab
            // 
            this.LoggerTab.Controls.Add(this.panelContainer);
            this.LoggerTab.Location = new System.Drawing.Point(4, 22);
            this.LoggerTab.Name = "LoggerTab";
            this.LoggerTab.Size = new System.Drawing.Size(679, 275);
            this.LoggerTab.TabIndex = 0;
            this.LoggerTab.Text = "Logs";
            this.LoggerTab.UseVisualStyleBackColor = true;
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.Location = new System.Drawing.Point(8, 11);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(663, 255);
            this.panelContainer.TabIndex = 0;
            // 
            // tbDefaultIP
            // 
            this.tbDefaultIP.Location = new System.Drawing.Point(435, 21);
            this.tbDefaultIP.Name = "tbDefaultIP";
            this.tbDefaultIP.Size = new System.Drawing.Size(100, 20);
            this.tbDefaultIP.TabIndex = 1;
            this.tbDefaultIP.TextChanged += new System.EventHandler(this.DefaultIPTextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Default Client IP Address";
            // 
            // buttonAllClientConnect
            // 
            this.buttonAllClientConnect.Location = new System.Drawing.Point(9, 19);
            this.buttonAllClientConnect.Name = "buttonAllClientConnect";
            this.buttonAllClientConnect.Size = new System.Drawing.Size(132, 23);
            this.buttonAllClientConnect.TabIndex = 4;
            this.buttonAllClientConnect.Text = "Connect All Clients";
            this.buttonAllClientConnect.UseVisualStyleBackColor = true;
            this.buttonAllClientConnect.Click += new System.EventHandler(this.buttonAllClientConnect_Click);
            // 
            // buttonStartServers
            // 
            this.buttonStartServers.Location = new System.Drawing.Point(9, 48);
            this.buttonStartServers.Name = "buttonStartServers";
            this.buttonStartServers.Size = new System.Drawing.Size(132, 23);
            this.buttonStartServers.TabIndex = 4;
            this.buttonStartServers.Text = "Start All Servers";
            this.buttonStartServers.UseVisualStyleBackColor = true;
            this.buttonStartServers.Click += new System.EventHandler(this.buttonStartServers_Click);
            // 
            // buttonAllClientDisconnect
            // 
            this.buttonAllClientDisconnect.Location = new System.Drawing.Point(147, 19);
            this.buttonAllClientDisconnect.Name = "buttonAllClientDisconnect";
            this.buttonAllClientDisconnect.Size = new System.Drawing.Size(132, 23);
            this.buttonAllClientDisconnect.TabIndex = 4;
            this.buttonAllClientDisconnect.Text = "Disconnect All Clients";
            this.buttonAllClientDisconnect.UseVisualStyleBackColor = true;
            this.buttonAllClientDisconnect.Click += new System.EventHandler(this.buttonAllClientDisconnect_Click);
            // 
            // buttonStopServers
            // 
            this.buttonStopServers.Location = new System.Drawing.Point(147, 48);
            this.buttonStopServers.Name = "buttonStopServers";
            this.buttonStopServers.Size = new System.Drawing.Size(132, 23);
            this.buttonStopServers.TabIndex = 4;
            this.buttonStopServers.Text = "Stop All Servers";
            this.buttonStopServers.UseVisualStyleBackColor = true;
            this.buttonStopServers.Click += new System.EventHandler(this.buttonStopServers_Click);
            // 
            // buttonNewServer
            // 
            this.buttonNewServer.Location = new System.Drawing.Point(308, 48);
            this.buttonNewServer.Name = "buttonNewServer";
            this.buttonNewServer.Size = new System.Drawing.Size(86, 23);
            this.buttonNewServer.TabIndex = 4;
            this.buttonNewServer.Text = "New Server";
            this.buttonNewServer.UseVisualStyleBackColor = true;
            this.buttonNewServer.Click += new System.EventHandler(this.buttonNewServer_Click);
            // 
            // buttonNewClient
            // 
            this.buttonNewClient.Location = new System.Drawing.Point(399, 48);
            this.buttonNewClient.Name = "buttonNewClient";
            this.buttonNewClient.Size = new System.Drawing.Size(86, 23);
            this.buttonNewClient.TabIndex = 4;
            this.buttonNewClient.Text = "New Client";
            this.buttonNewClient.UseVisualStyleBackColor = true;
            this.buttonNewClient.Click += new System.EventHandler(this.buttonNewClient_Click);
            // 
            // cbAutoReconnect
            // 
            this.cbAutoReconnect.AutoSize = true;
            this.cbAutoReconnect.Location = new System.Drawing.Point(554, 23);
            this.cbAutoReconnect.Name = "cbAutoReconnect";
            this.cbAutoReconnect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbAutoReconnect.Size = new System.Drawing.Size(152, 17);
            this.cbAutoReconnect.TabIndex = 5;
            this.cbAutoReconnect.Text = "Auto Reconnect All Clients";
            this.cbAutoReconnect.UseVisualStyleBackColor = true;
            this.cbAutoReconnect.CheckedChanged += new System.EventHandler(this.cbAutoReconnect_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(491, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Non Printable Shortcuts";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 388);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbAutoReconnect);
            this.Controls.Add(this.buttonStopServers);
            this.Controls.Add(this.buttonNewClient);
            this.Controls.Add(this.buttonNewServer);
            this.Controls.Add(this.buttonStartServers);
            this.Controls.Add(this.buttonAllClientDisconnect);
            this.Controls.Add(this.buttonAllClientConnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDefaultIP);
            this.Controls.Add(this.tabControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "TCP Socket Creator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormClosing);
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.tabControlMain.ResumeLayout(false);
            this.LoggerTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TextBox tbDefaultIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAllClientConnect;
        private System.Windows.Forms.Button buttonStartServers;
        private System.Windows.Forms.Button buttonAllClientDisconnect;
        private System.Windows.Forms.Button buttonStopServers;
        private System.Windows.Forms.Button buttonNewServer;
        private System.Windows.Forms.Button buttonNewClient;
        private System.Windows.Forms.CheckBox cbAutoReconnect;
        private System.Windows.Forms.TabPage LoggerTab;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button button1;

    }
}

