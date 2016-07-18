using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.Xml.Linq;
using BCS.Library.Logging;
using BCS.Library.Logging.Log4Net;

namespace TCPTest
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Delegate for selection of a tab that will be called via the message loop processing
        /// </summary>
        /// <param name="tab"></param>
        public delegate void selectTab(TabPage tab);

        readonly ILogger _Logger = new NullLogger();

        /// <summary>
        /// Logging panel appender
        /// </summary>
        readonly BCS.Library.WinFormsUI.OutputPanel _OutputPanel = new BCS.Library.WinFormsUI.OutputPanel();

        /// <summary>
        /// Constants
        /// </summary>
        const String _ConfigFile = "config.xml";
        const String _AddTab = "New Client Socket";
        const String _BaseName = "Socket ";
        const String _XmlRootName = "Sockets";
        public static String DefaultIP = LoopBackIP;
        public const String LoopBackIP = "127.0.0.1"; 
        public const String ServerIP = "Server"; 

        public MainForm()
        {
            log4net.Config.XmlConfigurator.Configure();
            _Logger = Log4NetManager.GetLogger("TCPTestForm");

            _Logger.Debug("Start up MainForm"); 

            InitializeComponent();

            _OutputPanel.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(_OutputPanel);
        }

        /// <summary>
        /// Load the config file if it exists
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFormLoad(object sender, EventArgs e)
        {
            try
            {
                XDocument xml = XDocument.Load(_ConfigFile);
                var root = xml.Elements(_XmlRootName);

                foreach (var socket in root.Elements(ClientServer.XmlRootName))
                    AddTab(socket);
            }
            catch (Exception)
            {
            }
        }
        
        /// <summary>
        /// Callback delegate used to select a newly added tab
        /// </summary>
        /// <param name="tab"></param>
        public void SelectTab(TabPage tab)
        {
            tabControlMain.SelectedTab = tab;
        }

        TabPage AddTab(XElement xml)
        {
            ClientServer ctrl = new ClientServer("", new Message(OnMessage));
            ctrl.FromXml(xml);
            return AddTab(ctrl);
        }

        TabPage AddTab(String name, bool server, String ip, int port, bool startServer)
        {
            ClientServer ctrl = new ClientServer(name, new Message(OnMessage));            
            ctrl.Server = server;
            ctrl.Port = port.ToString();
            ctrl.IPAddress = ip;
            return AddTab(ctrl);
        }

        TabPage AddTab(ClientServer ctrl)
        {
            tabControlMain.TabPages.Add(ctrl.SocketName, ctrl.SocketName);
            TabPage tab = tabControlMain.TabPages[ctrl.SocketName];

            tab.Controls.Add(ctrl);
            return tab;
        }

        /// <summary>
        /// Called when the app exits, writes the socket config to file and closes sockets
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFormClosing(object sender, FormClosingEventArgs e)
        {
            XElement root = new XElement(_XmlRootName);

            foreach (TabPage tab in tabControlMain.TabPages)
            {
                if (tab.Controls.Count > 0 && ((tab.Controls[0] as ClientServer) != null))
                {
                    ClientServer server = tab.Controls[0] as ClientServer;
                    server.CloseSockets();
                    root.Add(server.ToXml());
                }
            }

            XDocument xml = new XDocument();
            xml.Add(root);
            xml.Save(_ConfigFile);
        }

        /// <summary>
        /// Custom drawing of the tab, this provides feedback for socket state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabControlMainDrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage page = tabControlMain.TabPages[e.Index];
            e.Graphics.FillRectangle(new SolidBrush(page.BackColor), e.Bounds);

            Color TextColor = page.ForeColor;

            if (page.Controls.Count > 0)
            {
                ClientServer socket = page.Controls[0] as ClientServer;

                if (socket != null && !socket.Server)
                    TextColor = (socket.Connected) ? Color.Green : Color.Red;
            }

            Rectangle paddedBounds = e.Bounds;
            int yOffset = (e.State == DrawItemState.Selected) ? -2 : 1;
            paddedBounds.Offset(1, yOffset);
            TextRenderer.DrawText(e.Graphics, page.Text, this.Font, paddedBounds, TextColor);
        }

        /// <summary>
        /// Callback for a socket event
        /// </summary>
        /// <param name="code"></param>
        /// <param name="msg"></param>
        /// <param name="obj"></param>
        public void OnMessage(String source, CommsCode code, String msg, Object obj)
        {
            switch (code)
            {
                case CommsCode.Connected:

                    if (!String.IsNullOrEmpty(source) && tabControlMain.TabPages.ContainsKey(source))
                    {
                        tabControlMain.Invalidate();
                    }
                    break;

                case CommsCode.Disconnected:
                case CommsCode.Error:
                    if (!String.IsNullOrEmpty(source) && tabControlMain.TabPages.ContainsKey(source))
                    {
                        tabControlMain.Invalidate();
                    }
                    break;
                case CommsCode.Received:

                    break;
            }
        }

        /// <summary>
        /// Called when the text changes for the default IP address
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DefaultIPTextChanged(object sender, EventArgs e)
        {
            DefaultIP = tbDefaultIP.Text;

            if (String.IsNullOrEmpty(DefaultIP))
                DefaultIP = LoopBackIP;
        }

        private void buttonAllClientConnect_Click(object sender, EventArgs e)
        {
            foreach (TabPage tab in tabControlMain.TabPages)
            {
                if (tab.Controls.Count > 0 && ((tab.Controls[0] as ClientServer) != null))
                {
                    ClientServer socket = tab.Controls[0] as ClientServer;
                    if (!socket.Server && !socket.Connected)
                        socket.Start();
                }
            }
        }

        private void buttonAllClientDisconnect_Click(object sender, EventArgs e)
        {
            foreach (TabPage tab in tabControlMain.TabPages)
            {
                if (tab.Controls.Count > 0 && ((tab.Controls[0] as ClientServer) != null))
                {
                    ClientServer socket = tab.Controls[0] as ClientServer;
                    if (!socket.Server && socket.Connected)
                        socket.Stop();
                }
            }
        }

        private void buttonStartServers_Click(object sender, EventArgs e)
        {
            foreach (TabPage tab in tabControlMain.TabPages)
            {
                if (tab.Controls.Count > 0 && ((tab.Controls[0] as ClientServer) != null))
                {
                    ClientServer socket = tab.Controls[0] as ClientServer;
                    if (socket.Server)
                        socket.Start();
                }
            }
        }

        private void buttonStopServers_Click(object sender, EventArgs e)
        {
            foreach (TabPage tab in tabControlMain.TabPages)
            {
                if (tab.Controls.Count > 0 && ((tab.Controls[0] as ClientServer) != null))
                {
                    ClientServer socket = tab.Controls[0] as ClientServer;
                    if (socket.Server)
                        socket.Stop();
                }
            }
        }

        private void buttonNewServer_Click(object sender, EventArgs e)
        {
            //calculate the name of the new tab
            Int32 idx = 0;
            while (true)
            {
                idx++;
                if (tabControlMain.TabPages.ContainsKey(_BaseName + idx.ToString()))
                    continue;
                break;
            }

            TabPage tab = AddTab(_BaseName + idx.ToString(), true, ServerIP, 3300, false);
            tabControlMain.SelectedTab = tab;
        }

        private void buttonNewClient_Click(object sender, EventArgs e)
        {
            //resolve the IP address based on a user supplied default or server
            String IP = tbDefaultIP.Text;
            if (String.IsNullOrEmpty(IP))
                IP = DefaultIP;

            //calculate the name of the new tab
            Int32 idx = 0;
            while (true)
            {
                idx++;
                if (tabControlMain.TabPages.ContainsKey(_BaseName + idx.ToString()))
                    continue;
                break;
            }

            TabPage tab = AddTab(_BaseName + idx.ToString(), false, IP, 3300, false);
            tabControlMain.SelectedTab = tab;
        }

        private void cbAutoReconnect_CheckedChanged(object sender, EventArgs e)
        {
            foreach (TabPage tab in tabControlMain.TabPages)
            {
                if (tab.Controls.Count > 0 && ((tab.Controls[0] as ClientServer) != null))
                {
                    ClientServer socket = tab.Controls[0] as ClientServer;
                    socket.AutoConnect = cbAutoReconnect.Checked;
                }
            }
        }

        private void tabControlMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                tabControlMain.SelectedTab.Text = "test";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nonprint = new NonPrintable();
            nonprint.Show();
        }
    }
}
