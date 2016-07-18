namespace TCPTest
{
    partial class DeviceGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceGUI));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tbSend = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbOnReceipt = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbText = new System.Windows.Forms.RadioButton();
            this.rbBinary = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbOff = new System.Windows.Forms.RadioButton();
            this.rbOn = new System.Windows.Forms.RadioButton();
            this.tbAutoSendPeriod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAuto = new System.Windows.Forms.RichTextBox();
            this.tbReceive = new System.Windows.Forms.RichTextBox();
            this.buttonClearRx = new System.Windows.Forms.Button();
            this.buttonClearSend = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.cbAppend = new System.Windows.Forms.CheckBox();
            this.labelRxCount = new System.Windows.Forms.Label();
            this.labelTxCount = new System.Windows.Forms.Label();
            this.panelConnected = new System.Windows.Forms.Panel();
            this.buttonBinarySend = new System.Windows.Forms.Button();
            this.cbBinary = new System.Windows.Forms.CheckBox();
            this.cbText = new System.Windows.Forms.CheckBox();
            this.cbSnapshot = new System.Windows.Forms.CheckBox();
            this.cbBroadcast = new System.Windows.Forms.CheckBox();
            this.cbAutoSend = new System.Windows.Forms.CheckBox();
            this.timerAutoSend = new System.Windows.Forms.Timer(this.components);
            this.cbEcho = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.cbWriteToFile = new System.Windows.Forms.CheckBox();
            this.buttonTextColour = new System.Windows.Forms.Button();
            this.buttonBackColour = new System.Windows.Forms.Button();
            this.labelDiskFile = new System.Windows.Forms.Label();
            this.buttonBrowse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 528);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Receive";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Send";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(13, 29);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbReceive);
            this.splitContainer1.Size = new System.Drawing.Size(612, 494);
            this.splitContainer1.SplitterDistance = 269;
            this.splitContainer1.TabIndex = 11;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tbSend);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer2.Panel1MinSize = 50;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel1);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer2.Panel2MinSize = 50;
            this.splitContainer2.Size = new System.Drawing.Size(612, 269);
            this.splitContainer2.SplitterDistance = 120;
            this.splitContainer2.SplitterWidth = 10;
            this.splitContainer2.TabIndex = 1;
            // 
            // tbSend
            // 
            this.tbSend.BackColor = System.Drawing.Color.Black;
            this.tbSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSend.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSend.ForeColor = System.Drawing.Color.Red;
            this.tbSend.Location = new System.Drawing.Point(0, 0);
            this.tbSend.Name = "tbSend";
            this.tbSend.Size = new System.Drawing.Size(612, 120);
            this.tbSend.TabIndex = 0;
            this.tbSend.Text = "";
            this.tbSend.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSend_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbOnReceipt);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tbAutoSendPeriod);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbAuto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 139);
            this.panel1.TabIndex = 3;
            // 
            // cbOnReceipt
            // 
            this.cbOnReceipt.AutoSize = true;
            this.cbOnReceipt.Location = new System.Drawing.Point(376, 8);
            this.cbOnReceipt.Name = "cbOnReceipt";
            this.cbOnReceipt.Size = new System.Drawing.Size(80, 17);
            this.cbOnReceipt.TabIndex = 9;
            this.cbOnReceipt.Text = "On Receipt";
            this.cbOnReceipt.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.rbText);
            this.panel3.Controls.Add(this.rbBinary);
            this.panel3.Location = new System.Drawing.Point(250, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(111, 22);
            this.panel3.TabIndex = 8;
            // 
            // rbText
            // 
            this.rbText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbText.AutoSize = true;
            this.rbText.Location = new System.Drawing.Point(6, 1);
            this.rbText.Name = "rbText";
            this.rbText.Size = new System.Drawing.Size(46, 17);
            this.rbText.TabIndex = 4;
            this.rbText.Text = "Text";
            this.rbText.UseVisualStyleBackColor = true;
            this.rbText.CheckedChanged += new System.EventHandler(this.rbText_CheckedChanged);
            // 
            // rbBinary
            // 
            this.rbBinary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbBinary.AutoSize = true;
            this.rbBinary.Checked = true;
            this.rbBinary.Location = new System.Drawing.Point(54, 1);
            this.rbBinary.Name = "rbBinary";
            this.rbBinary.Size = new System.Drawing.Size(54, 17);
            this.rbBinary.TabIndex = 5;
            this.rbBinary.TabStop = true;
            this.rbBinary.Text = "Binary";
            this.rbBinary.UseVisualStyleBackColor = true;
            this.rbBinary.CheckedChanged += new System.EventHandler(this.rbBinary_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rbOff);
            this.panel2.Controls.Add(this.rbOn);
            this.panel2.Location = new System.Drawing.Point(159, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(86, 22);
            this.panel2.TabIndex = 7;
            // 
            // rbOff
            // 
            this.rbOff.AutoSize = true;
            this.rbOff.Checked = true;
            this.rbOff.Location = new System.Drawing.Point(45, 1);
            this.rbOff.Name = "rbOff";
            this.rbOff.Size = new System.Drawing.Size(39, 17);
            this.rbOff.TabIndex = 6;
            this.rbOff.TabStop = true;
            this.rbOff.Text = "Off";
            this.rbOff.UseVisualStyleBackColor = true;
            // 
            // rbOn
            // 
            this.rbOn.AutoSize = true;
            this.rbOn.Location = new System.Drawing.Point(4, 1);
            this.rbOn.Name = "rbOn";
            this.rbOn.Size = new System.Drawing.Size(39, 17);
            this.rbOn.TabIndex = 6;
            this.rbOn.Text = "On";
            this.rbOn.UseVisualStyleBackColor = true;
            // 
            // tbAutoSendPeriod
            // 
            this.tbAutoSendPeriod.Location = new System.Drawing.Point(108, 4);
            this.tbAutoSendPeriod.Name = "tbAutoSendPeriod";
            this.tbAutoSendPeriod.Size = new System.Drawing.Size(45, 20);
            this.tbAutoSendPeriod.TabIndex = 2;
            this.tbAutoSendPeriod.Text = "5000";
            this.tbAutoSendPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbAutoSendPeriod.TextChanged += new System.EventHandler(this.tbAutoSendPeriod_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Frequency (millisec)";
            // 
            // tbAuto
            // 
            this.tbAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAuto.BackColor = System.Drawing.Color.Black;
            this.tbAuto.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAuto.ForeColor = System.Drawing.Color.Red;
            this.tbAuto.Location = new System.Drawing.Point(0, 27);
            this.tbAuto.Name = "tbAuto";
            this.tbAuto.Size = new System.Drawing.Size(612, 109);
            this.tbAuto.TabIndex = 0;
            this.tbAuto.Text = "";
            // 
            // tbReceive
            // 
            this.tbReceive.BackColor = System.Drawing.Color.Black;
            this.tbReceive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbReceive.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReceive.ForeColor = System.Drawing.Color.Red;
            this.tbReceive.Location = new System.Drawing.Point(0, 0);
            this.tbReceive.Name = "tbReceive";
            this.tbReceive.Size = new System.Drawing.Size(612, 221);
            this.tbReceive.TabIndex = 0;
            this.tbReceive.Text = "";
            // 
            // buttonClearRx
            // 
            this.buttonClearRx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearRx.Location = new System.Drawing.Point(632, 383);
            this.buttonClearRx.Name = "buttonClearRx";
            this.buttonClearRx.Size = new System.Drawing.Size(74, 23);
            this.buttonClearRx.TabIndex = 2;
            this.buttonClearRx.Text = "Clear";
            this.buttonClearRx.UseVisualStyleBackColor = true;
            this.buttonClearRx.Click += new System.EventHandler(this.buttonClearRx_Click);
            // 
            // buttonClearSend
            // 
            this.buttonClearSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearSend.Location = new System.Drawing.Point(632, 83);
            this.buttonClearSend.Name = "buttonClearSend";
            this.buttonClearSend.Size = new System.Drawing.Size(74, 23);
            this.buttonClearSend.TabIndex = 1;
            this.buttonClearSend.Text = "Clear";
            this.buttonClearSend.UseVisualStyleBackColor = true;
            this.buttonClearSend.Click += new System.EventHandler(this.buttonClearSend_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSend.Location = new System.Drawing.Point(632, 29);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(74, 23);
            this.buttonSend.TabIndex = 0;
            this.buttonSend.Text = "Send Text";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // cbAppend
            // 
            this.cbAppend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbAppend.AutoSize = true;
            this.cbAppend.Location = new System.Drawing.Point(284, 544);
            this.cbAppend.Name = "cbAppend";
            this.cbAppend.Size = new System.Drawing.Size(63, 17);
            this.cbAppend.TabIndex = 14;
            this.cbAppend.Text = "Append";
            this.cbAppend.UseVisualStyleBackColor = true;
            // 
            // labelRxCount
            // 
            this.labelRxCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelRxCount.AutoSize = true;
            this.labelRxCount.Location = new System.Drawing.Point(65, 528);
            this.labelRxCount.Name = "labelRxCount";
            this.labelRxCount.Size = new System.Drawing.Size(0, 13);
            this.labelRxCount.TabIndex = 15;
            // 
            // labelTxCount
            // 
            this.labelTxCount.AutoSize = true;
            this.labelTxCount.Location = new System.Drawing.Point(97, 10);
            this.labelTxCount.Name = "labelTxCount";
            this.labelTxCount.Size = new System.Drawing.Size(0, 13);
            this.labelTxCount.TabIndex = 15;
            // 
            // panelConnected
            // 
            this.panelConnected.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelConnected.Location = new System.Drawing.Point(47, 7);
            this.panelConnected.Name = "panelConnected";
            this.panelConnected.Size = new System.Drawing.Size(37, 19);
            this.panelConnected.TabIndex = 16;
            // 
            // buttonBinarySend
            // 
            this.buttonBinarySend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBinarySend.Location = new System.Drawing.Point(632, 56);
            this.buttonBinarySend.Name = "buttonBinarySend";
            this.buttonBinarySend.Size = new System.Drawing.Size(74, 23);
            this.buttonBinarySend.TabIndex = 0;
            this.buttonBinarySend.Text = "Send Binary";
            this.buttonBinarySend.UseVisualStyleBackColor = true;
            this.buttonBinarySend.Click += new System.EventHandler(this.buttonBinarySend_Click);
            // 
            // cbBinary
            // 
            this.cbBinary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbBinary.AutoSize = true;
            this.cbBinary.Checked = true;
            this.cbBinary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBinary.Location = new System.Drawing.Point(17, 545);
            this.cbBinary.Name = "cbBinary";
            this.cbBinary.Size = new System.Drawing.Size(55, 17);
            this.cbBinary.TabIndex = 17;
            this.cbBinary.Text = "Binary";
            this.cbBinary.UseVisualStyleBackColor = true;
            // 
            // cbText
            // 
            this.cbText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbText.AutoSize = true;
            this.cbText.Checked = true;
            this.cbText.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbText.Location = new System.Drawing.Point(84, 545);
            this.cbText.Name = "cbText";
            this.cbText.Size = new System.Drawing.Size(47, 17);
            this.cbText.TabIndex = 17;
            this.cbText.Text = "Text";
            this.cbText.UseVisualStyleBackColor = true;
            // 
            // cbSnapshot
            // 
            this.cbSnapshot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbSnapshot.AutoSize = true;
            this.cbSnapshot.Location = new System.Drawing.Point(144, 545);
            this.cbSnapshot.Name = "cbSnapshot";
            this.cbSnapshot.Size = new System.Drawing.Size(76, 17);
            this.cbSnapshot.TabIndex = 17;
            this.cbSnapshot.Text = "Snap Shot";
            this.cbSnapshot.UseVisualStyleBackColor = true;
            this.cbSnapshot.CheckedChanged += new System.EventHandler(this.cbSnapshot_CheckedChanged);
            // 
            // cbBroadcast
            // 
            this.cbBroadcast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBroadcast.AutoSize = true;
            this.cbBroadcast.Location = new System.Drawing.Point(551, 9);
            this.cbBroadcast.Name = "cbBroadcast";
            this.cbBroadcast.Size = new System.Drawing.Size(74, 17);
            this.cbBroadcast.TabIndex = 17;
            this.cbBroadcast.Text = "Broadcast";
            this.cbBroadcast.UseVisualStyleBackColor = true;
            // 
            // cbAutoSend
            // 
            this.cbAutoSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAutoSend.AutoSize = true;
            this.cbAutoSend.Location = new System.Drawing.Point(633, 110);
            this.cbAutoSend.Name = "cbAutoSend";
            this.cbAutoSend.Size = new System.Drawing.Size(76, 17);
            this.cbAutoSend.TabIndex = 1;
            this.cbAutoSend.Text = "Auto Send";
            this.cbAutoSend.UseVisualStyleBackColor = true;
            this.cbAutoSend.CheckedChanged += new System.EventHandler(this.cbAutoSend_CheckedChanged);
            // 
            // timerAutoSend
            // 
            this.timerAutoSend.Interval = 5000;
            this.timerAutoSend.Tick += new System.EventHandler(this.timerAutoSend_Tick);
            // 
            // cbEcho
            // 
            this.cbEcho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbEcho.AutoSize = true;
            this.cbEcho.Location = new System.Drawing.Point(233, 545);
            this.cbEcho.Name = "cbEcho";
            this.cbEcho.Size = new System.Drawing.Size(51, 17);
            this.cbEcho.TabIndex = 17;
            this.cbEcho.Text = "Echo";
            this.cbEcho.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::TCPTest.Properties.Resources.jaoscorreo_e0;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(495, 529);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Image = global::TCPTest.Properties.Resources.MT2_16x16;
            this.buttonClose.Location = new System.Drawing.Point(692, 0);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(20, 20);
            this.buttonClose.TabIndex = 18;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // cbWriteToFile
            // 
            this.cbWriteToFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbWriteToFile.AutoSize = true;
            this.cbWriteToFile.Location = new System.Drawing.Point(17, 568);
            this.cbWriteToFile.Name = "cbWriteToFile";
            this.cbWriteToFile.Size = new System.Drawing.Size(63, 17);
            this.cbWriteToFile.TabIndex = 20;
            this.cbWriteToFile.Text = "To Disk";
            this.cbWriteToFile.UseVisualStyleBackColor = true;
            // 
            // buttonTextColour
            // 
            this.buttonTextColour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTextColour.Location = new System.Drawing.Point(633, 134);
            this.buttonTextColour.Name = "buttonTextColour";
            this.buttonTextColour.Size = new System.Drawing.Size(75, 23);
            this.buttonTextColour.TabIndex = 21;
            this.buttonTextColour.Text = "Text Colour";
            this.buttonTextColour.UseVisualStyleBackColor = true;
            this.buttonTextColour.Click += new System.EventHandler(this.buttonTextColour_Click);
            // 
            // buttonBackColour
            // 
            this.buttonBackColour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBackColour.Location = new System.Drawing.Point(633, 163);
            this.buttonBackColour.Name = "buttonBackColour";
            this.buttonBackColour.Size = new System.Drawing.Size(75, 23);
            this.buttonBackColour.TabIndex = 21;
            this.buttonBackColour.Text = "Back Colour";
            this.buttonBackColour.UseVisualStyleBackColor = true;
            this.buttonBackColour.Click += new System.EventHandler(this.buttonBackColour_Click);
            // 
            // labelDiskFile
            // 
            this.labelDiskFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDiskFile.AutoSize = true;
            this.labelDiskFile.Location = new System.Drawing.Point(131, 567);
            this.labelDiskFile.Name = "labelDiskFile";
            this.labelDiskFile.Size = new System.Drawing.Size(0, 13);
            this.labelDiskFile.TabIndex = 22;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonBrowse.Location = new System.Drawing.Point(84, 562);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(26, 23);
            this.buttonBrowse.TabIndex = 23;
            this.buttonBrowse.Text = "...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // DeviceGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.labelDiskFile);
            this.Controls.Add(this.buttonBackColour);
            this.Controls.Add(this.buttonTextColour);
            this.Controls.Add(this.cbWriteToFile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.cbText);
            this.Controls.Add(this.cbBroadcast);
            this.Controls.Add(this.cbAutoSend);
            this.Controls.Add(this.cbEcho);
            this.Controls.Add(this.cbSnapshot);
            this.Controls.Add(this.cbBinary);
            this.Controls.Add(this.panelConnected);
            this.Controls.Add(this.labelRxCount);
            this.Controls.Add(this.labelTxCount);
            this.Controls.Add(this.cbAppend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.buttonClearRx);
            this.Controls.Add(this.buttonClearSend);
            this.Controls.Add(this.buttonBinarySend);
            this.Controls.Add(this.buttonSend);
            this.Name = "DeviceGUI";
            this.Size = new System.Drawing.Size(713, 595);
            this.Load += new System.EventHandler(this.DeviceGUI_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox tbReceive;
        private System.Windows.Forms.RichTextBox tbSend;
        private System.Windows.Forms.Button buttonClearRx;
        private System.Windows.Forms.Button buttonClearSend;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.CheckBox cbAppend;
        private System.Windows.Forms.Label labelRxCount;
        private System.Windows.Forms.Label labelTxCount;
        private System.Windows.Forms.Panel panelConnected;
        private System.Windows.Forms.Button buttonBinarySend;
        private System.Windows.Forms.CheckBox cbBinary;
        private System.Windows.Forms.CheckBox cbText;
        private System.Windows.Forms.CheckBox cbSnapshot;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.CheckBox cbBroadcast;
        private System.Windows.Forms.TextBox tbAutoSendPeriod;
        private System.Windows.Forms.CheckBox cbAutoSend;
        private System.Windows.Forms.RichTextBox tbAuto;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbBinary;
        private System.Windows.Forms.RadioButton rbText;
        private System.Windows.Forms.Timer timerAutoSend;
        private System.Windows.Forms.CheckBox cbEcho;
        private System.Windows.Forms.RadioButton rbOff;
        private System.Windows.Forms.RadioButton rbOn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbOnReceipt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox cbWriteToFile;
        private System.Windows.Forms.Button buttonTextColour;
        private System.Windows.Forms.Button buttonBackColour;
        private System.Windows.Forms.Label labelDiskFile;
        private System.Windows.Forms.Button buttonBrowse;
    }
}
