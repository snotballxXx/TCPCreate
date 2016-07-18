using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace TCPTest
{
    public partial class DeviceGUI : UserControl
    {
        String _Name;
        const String _RxCountFormat = "Total of {0} message(s) {1} bytes";
        const String _TxCountFormat = "Total of {0} message(s) sent";
        Int32 _RxCount = 0;
        Int32 _ByteCount = 0;
        Int32 _TxCount = 0;
        static Dictionary<String, String> _NonPrintables = new Dictionary<String, String>();
        static Dictionary<String, char> _NonPrintablesChars = new Dictionary<String, char>();

        public TCPClientDevice Device { get; protected set; }


        public Boolean AutoSend
        {
            get;
            set;
        }

        public String AutoSendFrequency
        {
            get;
            set;
        }

        public Boolean AutoSendTypeBinary
        {
            get;
            set;
        }

        public Boolean Echo
        {
            get;
            set;
        }

        public String AutoSendMessage
        {
            get;
            set;
        }


        public DeviceGUI(String name)
        {
            if (_NonPrintables.Count() == 0)
            {
                _NonPrintables["<NUL>"] = " 0x00 ";
                _NonPrintables["<SOH>"] = " 0x01 ";
                _NonPrintables["<STX>"] = " 0x02 ";
                _NonPrintables["<ETX>"] = " 0x03 ";
                _NonPrintables["<EOT>"] = " 0x04 ";
                _NonPrintables["<ENQ>"] = " 0x05 ";
                _NonPrintables["<ACK>"] = " 0x06 ";
                _NonPrintables["<BEL>"] = " 0x07 ";
                _NonPrintables["<BS>"]  = " 0x08 ";
                _NonPrintables["<TAB>"] = " 0x09 ";
                _NonPrintables["<LF>"]  = " 0x0A ";
                _NonPrintables["<VT>"]  = " 0x0B ";
                _NonPrintables["<FF>"]  = " 0x0C ";
                _NonPrintables["<CR>"]  = " 0x0D ";
                _NonPrintables["<S0>"]  = " 0x0E ";
                _NonPrintables["<SI>"]  = " 0x0F ";
                _NonPrintables["<DLE>"] = " 0x10 ";
                _NonPrintables["<DC1>"] = " 0x11 ";
                _NonPrintables["<DC2>"] = " 0x12 ";
                _NonPrintables["<DC3>"] = " 0x13 ";
                _NonPrintables["<DC4>"] = " 0x14 ";
                _NonPrintables["<NAK>"] = " 0x15 ";
                _NonPrintables["<SYN>"] = " 0x16 ";
                _NonPrintables["<ETB>"] = " 0x17 ";
                _NonPrintables["<CAN>"] = " 0x18 ";
                _NonPrintables["<EM>"]  = " 0x19 ";
                _NonPrintables["<SUB>"] = " 0x1A ";
                _NonPrintables["<ESC>"] = " 0x1B ";
                _NonPrintables["<FS>"]  = " 0x1C ";
                _NonPrintables["<GS>"]  = " 0x1D ";
                _NonPrintables["<RS>"]  = " 0x1E ";
                _NonPrintables["<US>"]  = " 0x1F ";
                _NonPrintables["<SPC>"] = " 0x20 ";

                _NonPrintablesChars["<NUL>"] = (char)0;
                _NonPrintablesChars["<SOH>"] = (char)1;
                _NonPrintablesChars["<STX>"] = (char)2;
                _NonPrintablesChars["<ETX>"] = (char)3;
                _NonPrintablesChars["<EOT>"] = (char)4;
                _NonPrintablesChars["<ENQ>"] = (char)5;
                _NonPrintablesChars["<ACK>"] = (char)6;
                _NonPrintablesChars["<BEL>"] = (char)7;
                _NonPrintablesChars["<BS>"]  = (char)8;
                _NonPrintablesChars["<TAB>"] = (char)9;
                _NonPrintablesChars["<LF>"]  = (char)10;
                _NonPrintablesChars["<VT>"]  = (char)11;
                _NonPrintablesChars["<FF>"]  = (char)12;
                _NonPrintablesChars["<CR>"]  = (char)13;
                _NonPrintablesChars["<S0>"]  = (char)14;
                _NonPrintablesChars["<SI>"]  = (char)15;
                _NonPrintablesChars["<DLE>"] = (char)16;
                _NonPrintablesChars["<DC1>"] = (char)17;
                _NonPrintablesChars["<DC2>"] = (char)18;
                _NonPrintablesChars["<DC3>"] = (char)19;
                _NonPrintablesChars["<DC4>"] = (char)20;
                _NonPrintablesChars["<NAK>"] = (char)21;
                _NonPrintablesChars["<SYN>"] = (char)22;
                _NonPrintablesChars["<ETB>"] = (char)23;
                _NonPrintablesChars["<CAN>"] = (char)24;
                _NonPrintablesChars["<EM>"]  = (char)25;
                _NonPrintablesChars["<SUB>"] = (char)26;
                _NonPrintablesChars["<ESC>"] = (char)27;
                _NonPrintablesChars["<FS>"]  = (char)28;
                _NonPrintablesChars["<GS>"]  = (char)29;
                _NonPrintablesChars["<RS>"]  = (char)30;
                _NonPrintablesChars["<US>"]  = (char)31;
                _NonPrintablesChars["<SPC>"] = (char)32;
            }

            AutoSendMessage = "";
            AutoSendFrequency = "5000";

            InitializeComponent();
            _Name = name;
            if (!String.IsNullOrEmpty(name))
            {
                panelConnected.BackColor = Color.Red;
                pictureBox1.Enabled = false;
                cbBroadcast.Visible = buttonClose.Visible = false;
            }
            else
            {
                panelConnected.Visible = false;
                cbBroadcast.Visible = buttonClose.Visible = true;
            }      
      
            cbAutoSend.DataBindings.Add(new Binding("Checked", this, "AutoSend"));
            rbBinary.DataBindings.Add(new Binding("Checked", this, "AutoSendTypeBinary"));
            cbEcho.DataBindings.Add(new Binding("Checked", this, "Echo"));
            tbAuto.DataBindings.Add(new Binding("Text", this, "AutoSendMessage"));
            tbAutoSendPeriod.DataBindings.Add(new Binding("Text", this, "AutoSendFrequency"));
        }

        public void Connect(String IP, Int32 port, Int32 udpPort, Message messageDelegate)
        {
            Device = new TCPClientDevice(_Name);
            Device.OnMessage += new Message(OnMessage);
            Device.OnMessage += messageDelegate;
            Device.Connect(IP, port, udpPort);
        }

        public void Connected(TCPClientDevice device)
        {
            Device = device;
            Device.OnMessage += new Message(OnMessage);
        }

        public void Close()
        {
            if (Device != null)
                Device.Close();
        }

        public void OnMessage(String source, CommsCode code, String msg, Object obj)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Message(OnMessage), new Object[] { source, code, msg, obj });
            }
            else
            {
                switch (code)
                {
                    case CommsCode.Connected:
                        panelConnected.BackColor = Color.Green;
                        pictureBox1.Enabled = true;
                        tbReceive.Text = "";
                        break;
                    case CommsCode.Received:
                        Byte[] buffer = obj as byte[];
                        StringBuilder sb = new StringBuilder();
                        StringBuilder sbText = new StringBuilder();
                        sbText.Append("\nPrintable Text\n");
                        DateTime d = DateTime.Now;
                        sb.AppendFormat("\nMessage is {0} byte(s) long received at {1:D2}:{2:D2}:{3:D2}.{4:D3}\n", buffer.Length, d.Hour, d.Minute, d.Second, d.Millisecond);
                        //sb.AppendLine("Raw Data");
                        //sb.AppendLine(Encoding.ASCII.GetString(buffer));

                        _ByteCount += buffer.Length;
                        for (Int32 i = 0; i < buffer.Length; ++i)
                        {
                            if (cbBinary.Checked)
                            {
                                if (i == 0)
                                    sb.Append("\nBinary");
                                if ((i % 10) == 0)
                                    sb.Append("\n");
                                sb.AppendFormat("  0x{0:X2}", buffer[i]);
                            }
                            if (buffer[i] >= 32 || buffer[i] == 10 || buffer[i] == 13)                                
                                sbText.Append(Convert.ToChar(buffer[i]));
                        }
                        if (cbText.Checked)
                            sb.Append("\n" + sbText.ToString());
                        AddTextToTopRxTextBox(sb.ToString());

                        labelRxCount.Text = String.Format(_RxCountFormat, ++_RxCount, _ByteCount);

                        if (cbEcho.Checked || Echo)
                            Send(buffer);

                        if (cbAutoSend.Checked && cbOnReceipt.Checked)
                            tbAuto.Text = CalculateBinaryString(tbAuto.Text);

                        if (cbWriteToFile.Checked)
                        {                             
                            if (String.IsNullOrEmpty(labelDiskFile.Text))
                            {                            
                                var assemblyName = Assembly.GetExecutingAssembly().Location;
                                var fileName = Path.Combine(assemblyName.Substring(0, assemblyName.LastIndexOf("\\")),String.Concat(_Name,".txt"));
                                labelDiskFile.Text = fileName;
                            }

                            using (var sw = new StreamWriter(new FileStream(labelDiskFile.Text, FileMode.Append)))
                            {
                                sw.WriteLine(sb.ToString());
                            }
                        }
                        break;

                    case CommsCode.Error:
                        AddTextToTopRxTextBox(msg + " - " + obj.ToString());
                        if (Device != null)
                            Device.Close();
                        break;

                    case CommsCode.Disconnected:
                        TCPClientDevice dev = obj as TCPClientDevice;
                        dev.OnMessage -= new Message(OnMessage);
                        panelConnected.BackColor = Color.Red;
                        pictureBox1.Enabled = false;
                        labelRxCount.Text = labelTxCount.Text = "";
                        _RxCount = _TxCount = _ByteCount = 0;
                        break;                        
                }
            }
        }

        private void AddTextToTopRxTextBox(String str)
        {
            if (cbSnapshot.Checked)
            {
                if (String.IsNullOrEmpty(tbReceive.Text))
                    tbReceive.Text = str;
                return;
            }

            String old = (cbAppend.Checked) ? tbReceive.Text : "";
            tbReceive.Text = str + "\n";
            tbReceive.AppendText(old);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            SendText(tbSend.Text);
        }

        private void buttonClearSend_Click(object sender, EventArgs e)
        {
            tbSend.Text = "";
        }

        private void buttonClearRx_Click(object sender, EventArgs e)
        {
            tbReceive.Text = "";
        }

        private void SendBinary(String text)
        {
            if (Device == null) return;

            String[] tokens = text.Split(' ', '\n');

            byte[] buffer = new byte[text.Length];

            Int32 idx = 0;
            //binary send can be a string of text or number prefixed with 0x,
            //example below
            // Hello 0x10 0x13 0x20 0x20 0x20 0x57 111 0x72 0x6C 0x64 0x21
            foreach (String s in tokens)
            {
                Byte b;
                if (s.StartsWith("0x"))
                {
                    if (Byte.TryParse(s.Substring(2), System.Globalization.NumberStyles.AllowHexSpecifier, null, out b))
                    {
                        buffer[idx] = b;
                        idx++;
                    }
                    continue;
                }
                if (Byte.TryParse(s, out b))
                {
                    buffer[idx] = b;
                    idx++;
                    continue;
                }
                //must be a string
                foreach (Char c in s)
                {
                    buffer[idx] = (Byte)c;
                    idx++;
                }
            }

            Byte[] buf = new byte[idx];

            for (int i = 0; i < idx; ++i)
                buf[i] = buffer[i];

            if (cbBroadcast.Checked)
                (Parent.Parent.Parent as ClientServer).Broadcast(buf);
            else
                Send(buf);
        }

        private void SendText(String text)
        {
            if (Device == null) return;

            //foreach (var item in _NonPrintablesChars)
            //    text = text.Replace(item.Key, item.Value.ToString());

            ASCIIEncoding encoder = new ASCIIEncoding();
            byte[] buffer = encoder.GetBytes(text);

            if (cbBroadcast.Checked)
                (Parent.Parent.Parent as ClientServer).Broadcast(buffer);
            else
                Send(buffer);
        }


        private void buttonBinarySend_Click(object sender, EventArgs e)
        {
            tbSend.Text = CalculateBinaryString(tbSend.Text);
        }

        private String CalculateBinaryString(String input)
        {
            var sendData = input;
            sendData = sendData.Replace("<INC>", "");
            sendData = sendData.Replace("</INC>", "");

            foreach (var item in _NonPrintables)
                sendData = sendData.Replace(item.Key, item.Value);

            //go through and filter comments, they start with //
            StringBuilder sb = new StringBuilder();
            var lines = sendData.Split('\n');
            foreach (var l in lines)
            {
                if (!l.Trim().StartsWith("//"))
                    sb.Append(String.Concat(l," \n"));
            }
            SendBinary(sb.ToString());

            //<INC>0x00</INC>
            var temp = new StringBuilder(input);

            var idx = input.IndexOf("<INC>");
            while (idx != -1)
            {
                var value = input.Substring(idx + 7, 2);
                var numeric = Convert.ToInt32(value, 16) + 1;
                var numericAsHex = String.Format("{0:X2}", numeric);

                temp[idx + 7] = numericAsHex[0];
                temp[idx + 8] = numericAsHex[1];
                idx = input.IndexOf("<INC>", idx + 1);
            }

            return temp.ToString();
        }

        private void cbSnapshot_CheckedChanged(object sender, EventArgs e)
        {
            tbReceive.Text = "";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            TabControl container = Parent.Parent as TabControl;
            container.TabPages.Remove(Parent as TabPage);
            Close();
        }

        public void Send(Byte[] buf)
        {
            Device.Send(buf);
            labelTxCount.Text = String.Format(_TxCountFormat, ++_TxCount);
        }

        private void tbAutoSendPeriod_TextChanged(object sender, EventArgs e)
        {
            Int32 i;
            if (!Int32.TryParse(tbAutoSendPeriod.Text, out i))
            {
                AutoSendFrequency = tbAutoSendPeriod.Text = "5000";
                timerAutoSend.Interval = 5000;
            }
            else
            {
                if (i < 10)
                    return;
                timerAutoSend.Interval = i;
                AutoSendFrequency = i.ToString();
            }
        }

        private void cbAutoSend_CheckedChanged(object sender, EventArgs e)
        {
            splitContainer2.Panel2Collapsed = !cbAutoSend.Checked;
            timerAutoSend.Interval = Convert.ToInt32(tbAutoSendPeriod.Text);
            timerAutoSend.Enabled = cbAutoSend.Checked;
        }

        private void timerAutoSend_Tick(object sender, EventArgs e)
        {
            if (rbOn.Checked && !String.IsNullOrEmpty(tbAuto.Text) && panelConnected.BackColor == Color.Green)
            {
                if (rbBinary.Checked)
                {
                    tbAuto.Text = CalculateBinaryString(tbAuto.Text);
                }
                else
                    SendText(tbAuto.Text);
            }
        }

        private void DeviceGUI_Load(object sender, EventArgs e)
        {
            splitContainer2.Panel2Collapsed = !cbAutoSend.Checked;
            timerAutoSend.Interval = Convert.ToInt32( AutoSendFrequency );
            timerAutoSend.Enabled = cbAutoSend.Checked;

            rbBinary.Checked = AutoSendTypeBinary;
            rbText.Checked = !rbBinary.Checked;
        }

        private void rbBinary_CheckedChanged(object sender, EventArgs e)
        {
            AutoSendTypeBinary = rbBinary.Checked;
        }

        private void rbText_CheckedChanged(object sender, EventArgs e)
        {
            AutoSendTypeBinary = rbBinary.Checked;
        }

        private void tbSend_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void buttonTextColour_Click(object sender, EventArgs e)
        {
            var dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ChangeTextColour(tbSend, dlg.Color);
                ChangeTextColour(tbReceive, dlg.Color);
                ChangeTextColour(tbAuto, dlg.Color);
            }
        }

        private void ChangeTextColour(RichTextBox richTextBox, Color color)
        {
            int length = richTextBox.TextLength;  // at end of text
            richTextBox.SelectionStart = 0;
            richTextBox.SelectionLength = richTextBox.TextLength;
            richTextBox.SelectionColor = color;
        }

        private void buttonBackColour_Click(object sender, EventArgs e)
        {
            var dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tbSend.BackColor = dlg.Color;
                tbReceive.BackColor = dlg.Color;
                tbAuto.BackColor = dlg.Color;
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog();
            
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                labelDiskFile.Text = dlg.FileName;
            }
        }
    }
}
