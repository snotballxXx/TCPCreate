using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TCPTest
{
    public partial class ClientServer : UserControl
    {
        const String _NoConnections = "No Client Connections";
        const String _NotOpen = "Server socket is NOT open";
        //Socket object 
        TCPServerDevice _Server = null;
        Boolean _Connected = false;
        UInt32 _ReconnectTime = 5000;
        //Callback to the main form for socket events
        public Message OnMessageReceivedParentSubscriber;
        //Used for writing to file
        public const String XmlRootName = "Socket";

        Boolean _AutoEchoOn;

        /// <summary>
        /// IP Address for the socket connection
        /// </summary>
        public String IPAddress 
        {
            get { return tbIP.Text; }
            set { tbIP.Text = value;  } 
        }
        /// <summary>
        /// Indicates whether this is client or server socket
        /// </summary>
        public Boolean Server
        {
            get { return rbServer.Checked; }
            set 
            {
                rbServer.Checked = value;
                rbClient.Checked = !rbServer.Checked;
                cbAutoReconnect.Visible = !rbServer.Checked;
                cbEcho.Visible = rbServer.Checked;
            }
        }
        /// <summary>
        /// Port number to connect to or listen on
        /// </summary>
        public String Port
        {
            get { return tbPort.Text; }
            set { tbPort.Text = value; }
        }
        /// <summary>
        /// UDP Port number to listen on
        /// </summary>
        public String UDPListenerPort
        {
            get { return tbListenerPort.Text; }
            set { tbListenerPort.Text = value; }
        }
        /// <summary>
        /// Indicates if auto reconnect is active
        /// </summary>
        public Boolean UDP
        {
            set { cbUDP.Checked = value; }
            get { return cbUDP.Checked; }
        }
        /// <summary>
        /// Indicates if auto reconnect is active
        /// </summary>
        public Boolean AutoConnect
        {
            set { cbAutoReconnect.Checked = value; }
            get { return cbAutoReconnect.Checked; }
        }
        /// <summary>
        /// flag to indicate connection
        /// </summary>
        public Boolean Connected
        {
            get { return _Connected; }
        }
        /// <summary>
        /// Instance name, this is teh tab name
        /// </summary>
        public String SocketName { get; set; }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="name">Tab name</param>
        /// <param name="cb">Main form socket event callback</param>
        public ClientServer(String name, Message cb)
        {
            InitializeComponent();

            SocketName = name;
            OnMessageReceivedParentSubscriber = cb;
            //bind the controls for visibility/enable
            
            rbClient.DataBindings.Add(new Binding("Enabled", buttonConnect, "Enabled"));
            rbServer.DataBindings.Add(new Binding("Enabled", buttonConnect, "Enabled"));
            tbPort.DataBindings.Add(new Binding("Enabled", buttonConnect, "Enabled"));
            tbIP.Enabled = false;
            buttonDisconnect.Enabled = false;
            buttonConnect.Enabled = true;            
            Dock = DockStyle.Fill;
            labelServerText.Text = _NotOpen;
        }
        /// <summary>
        /// Close the contained socket object
        /// </summary>
        public void CloseSockets()
        {
            if (_Server != null)
                _Server.Close();

            _Server = null;

            if (tabControlClientServer.TabPages["Client"] != null)
            {
                DeviceGUI devClient = tabControlClientServer.TabPages["Client"].Controls[0] as DeviceGUI;
                if (devClient != null)
                {
                    devClient.Close();
                }
            }
        }
        /// <summary>
        /// Creates a socket object based on configuration
        /// </summary>
        /// <param name="xml"></param>
        public void FromXml(XElement xml)
        {
            SocketName = xml.Element("Name").Value;

            XElement ip = xml.Element("IPAddress");

            if (ip != null)
            {
                Server = false;
                IPAddress = ip.Value;
            }
            else
                Server = true; 

            Port = xml.Element("Port").Value;

            var ele = xml.Element("Reconnect");
            if (ele != null)
                cbAutoReconnect.Checked = ele.Value.ToLower() == "true";

            ele = xml.Element("AutoEcho");
            if (ele != null)
            {
                cbEcho.Checked = ele.Value.ToLower() == "true";
                _AutoEchoOn = cbEcho.Checked;
            }

            if (tabControlClientServer.TabCount != 0)
            {
                DeviceGUI dev = tabControlClientServer.TabPages["Client"].Controls[0] as DeviceGUI;

                ele = xml.Element("AutoSend");
                if (ele != null) dev.AutoSend = ele.Value == "true";
                ele = xml.Element("AutoSendTypeBinary");
                if (ele != null) dev.AutoSendTypeBinary = ele.Value == "true";
                ele = xml.Element("Echo");
                if (ele != null) dev.Echo = ele.Value == "true";
                ele = xml.Element("AutoSendMessage");
                if (ele != null) dev.AutoSendMessage = ele.Value;
                ele = xml.Element("AutoSendFrequency");
                if (ele != null) dev.AutoSendFrequency = ele.Value;
            }

        }
        /// <summary>
        /// Serializes the object to xml
        /// </summary>
        /// <returns></returns>
        public XElement ToXml()
        {
            XElement xml = null;

            if (Server)
                xml = new XElement(XmlRootName,
                    new XElement("Name", SocketName),
                    new XElement("Port", Port.ToString()),
                    new XElement("AutoEcho", cbEcho.Checked.ToString())
                    );
            else
            {
                DeviceGUI dev = tabControlClientServer.TabPages["Client"].Controls[0] as DeviceGUI;
                
                xml = new XElement(XmlRootName,
                    new XElement("Name", SocketName),
                    new XElement("IPAddress", IPAddress),
                    new XElement("Port", Port.ToString()),
                    new XElement("Reconnect", (cbAutoReconnect.Checked) ? "true" : "false"),
                    new XElement("AutoSend", (dev.AutoSend) ? "true" : "false"),
                    new XElement("AutoSendTypeBinary", (dev.AutoSendTypeBinary) ? "true" : "false"),
                    new XElement("Echo", (dev.Echo) ? "true" : "false"),
                    new XElement("AutoSendMessage", (String.IsNullOrEmpty(dev.AutoSendMessage)) ? "" : dev.AutoSendMessage),
                    new XElement("AutoSendFrequency", dev.AutoSendFrequency.ToString())
                    );
            }
            return xml;
        }

        private void rbServer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbServer.Checked)
            {
                tabControlClientServer.TabPages.Clear();
                buttonConnect.Text = "Listen";
                buttonDisconnect.Text = "Shutdown";
                tbIP.Text = MainForm.ServerIP;

                labelServerText.Text = _NotOpen;
                labelServerText.Visible = true;
            }
            else
            {
                labelServerText.Visible = false;
                buttonConnect.Text = "Connect";
                buttonDisconnect.Text = "Disconnect";
                tbIP.Text = MainForm.DefaultIP;
                tbIP.Enabled = true;

                if (tabControlClientServer.TabCount == 0)
                {
                    Control ctrl = new DeviceGUI(SocketName);
                    tabControlClientServer.TabPages.Add("Client", "Client");
                    TabPage tab = tabControlClientServer.TabPages["Client"];
                    tab.Controls.Add(ctrl);
                    ctrl.Dock = DockStyle.Fill;
                }
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            Start();
        }

        public void OnMessage(String source, CommsCode code, String msg, Object obj )
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Message(OnMessage), new Object[] { source, code, msg, obj });
            }
            else
            {
                if (OnMessageReceivedParentSubscriber != null)
                    OnMessageReceivedParentSubscriber(source, code, msg, obj);

                switch (code)
                {
                    case CommsCode.Connected:
                        if (rbServer.Checked)
                        {
                            TCPClientDevice device = obj as TCPClientDevice;
                            //add a new page as we have a new connection from a client
                            DeviceGUI ctrl = new DeviceGUI("");
                            ctrl.Echo = _AutoEchoOn;

                            Int32 idx = 0;
                            while (true)
                            {
                                idx++;
                                if (tabControlClientServer.TabPages.ContainsKey(idx.ToString()))
                                    continue;
                                break;
                            }

                            tabControlClientServer.TabPages.Add(idx.ToString(), msg);

                            TabPage tab = tabControlClientServer.TabPages[idx.ToString()];
                            tab.Controls.Add(ctrl);
                            ctrl.Dock = DockStyle.Fill;
                            ctrl.Connected(device);

                            device.OnMessage += new Message(OnMessage);

                            labelServerText.Visible = false;
                        }
                        else
                        {
                            _Connected = true;
                        }
                        break;

                    case CommsCode.Disconnected:
                        TCPClientDevice dev = obj as TCPClientDevice;
                        dev.OnMessage -= new Message(OnMessage);

                        if (rbServer.Checked)
                        {
                            TabPage deletePage = null;
                            foreach (TabPage page in tabControlClientServer.TabPages)
                            {
                                if ((page.Controls[0] as DeviceGUI).Device == dev)
                                {
                                    deletePage = page;
                                    break;
                                }
                            }

                            if (deletePage != null)
                                tabControlClientServer.TabPages.Remove(deletePage);

                            labelServerText.Visible = tabControlClientServer.TabPages.Count == 0;
                        }
                        else
                        {
                            if (!buttonConnect.Enabled && cbAutoReconnect.Checked)
                            {
                                //if we are here this is not a shutdown as a result of a user request
                                //schedule reconnect if required
                                timerReconnect.Interval = (int)_ReconnectTime;
                                timerReconnect.Enabled = true;
                            }

                            Stop();
                            _Connected = false;
                            buttonDisconnect.Enabled = false;
                            buttonConnect.Enabled = true;
                            labelServerText.Text = _NotOpen;
                        }
                        break;
                    case CommsCode.Error:
                        if (rbServer.Checked)
                        {
                            String error = obj.ToString();

                            if (!error.Contains("WSACancelBlockingCall"))
                            {
                               labelError.Text = obj.ToString();
                               // Stop();                            
                            }
                        }
                        break;
                }
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            Stop();
        }

        public void Start()
        {
            if (buttonConnect.Enabled == false)
                return;

            buttonDisconnect.Enabled = true;
            buttonConnect.Enabled = false;
            tbIP.Enabled = false;

            if (rbServer.Checked)
            {
                _Server = new TCPServerDevice(SocketName, Convert.ToInt32(tbPort.Text), new Message(OnMessage));
                labelServerText.Text = _NoConnections;
                labelError.Text = "";
            }
            else
            {
                if (tabControlClientServer.TabCount == 1)
                {
                    DeviceGUI dev = (tabControlClientServer.TabPages["Client"].Controls[0] as DeviceGUI);
                    //dev.Device.OnMessage += new Message(OnMessage);
                    Int32 updPort = 0;
                    Int32.TryParse(tbListenerPort.Text, out updPort);

                    dev.Connect(tbIP.Text, Convert.ToInt32(tbPort.Text), updPort, new Message(OnMessage));
                }
            }
        }

        public void Stop()
        {
            if (buttonConnect.Enabled == true)
                return;

            buttonDisconnect.Enabled = false;
            buttonConnect.Enabled = true;

            CloseSockets();
            if (!rbClient.Checked)
                tabControlClientServer.TabPages.Clear();
            else
                tbIP.Enabled = true;


            labelServerText.Text = _NotOpen;
        }

        public void Broadcast(Byte[] buffer)
        {
            foreach (TabPage tab in tabControlClientServer.TabPages)
            {
                (tab.Controls[0] as DeviceGUI).Send(buffer);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            TabControl container = Parent.Parent as TabControl;
            Stop();
            container.TabPages.Remove(Parent as TabPage);
        }

        private void cbAutoReconnect_CheckedChanged(object sender, EventArgs e)
        {
            _AutoEchoOn = cbEcho.Checked;
        }

        private void timerReconnect_Tick(object sender, EventArgs e)
        {
            timerReconnect.Enabled = false;
            if (buttonConnect.Enabled == true)
                Start();
        }

        private void cbUDP_CheckedChanged(object sender, EventArgs e)
        {
            tbListenerPort.Visible = cbUDP.Checked;
            label3.Visible = cbUDP.Checked;

            buttonConnect.Text = (cbUDP.Checked) ? "Start Monitor" : "Connect";
            buttonDisconnect.Text = (cbUDP.Checked) ? "Stop Monitor" : "Disconnect";
        }
    }
}
