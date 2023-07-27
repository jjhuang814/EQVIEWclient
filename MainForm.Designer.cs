namespace EQVIWEclient
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>


        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>


        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblServerIP = new System.Windows.Forms.Label();
            this.lblServerPort = new System.Windows.Forms.Label();
            this.tbxServerIP = new System.Windows.Forms.TextBox();
            this.tbxServerPort = new System.Windows.Forms.TextBox();
            this.btnTcpConnect = new System.Windows.Forms.Button();
            this.btnTcpDisconnect = new System.Windows.Forms.Button();
            this.btnTcpState = new System.Windows.Forms.Button();
            this.lblTcpState = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxCommand = new System.Windows.Forms.TextBox();
            this.btnCommandSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnResponseClear = new System.Windows.Forms.Button();
            this.lstResponse = new System.Windows.Forms.ListBox();
            this.lblHostIP = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lstState = new System.Windows.Forms.ListBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblPLCType = new System.Windows.Forms.Label();
            this.btnPLCType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::EQVIWEclient.Properties.Resources.HIWIN_Logo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 61);
            this.panel1.TabIndex = 0;
            // 
            // lblServerIP
            // 
            this.lblServerIP.AutoSize = true;
            this.lblServerIP.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblServerIP.Location = new System.Drawing.Point(274, 12);
            this.lblServerIP.Name = "lblServerIP";
            this.lblServerIP.Size = new System.Drawing.Size(100, 21);
            this.lblServerIP.TabIndex = 1;
            this.lblServerIP.Text = "IP Address :";
            // 
            // lblServerPort
            // 
            this.lblServerPort.AutoSize = true;
            this.lblServerPort.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblServerPort.Location = new System.Drawing.Point(275, 47);
            this.lblServerPort.Name = "lblServerPort";
            this.lblServerPort.Size = new System.Drawing.Size(50, 21);
            this.lblServerPort.TabIndex = 2;
            this.lblServerPort.Text = "Port :";
            // 
            // tbxServerIP
            // 
            this.tbxServerIP.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxServerIP.Location = new System.Drawing.Point(373, 8);
            this.tbxServerIP.Name = "tbxServerIP";
            this.tbxServerIP.Size = new System.Drawing.Size(120, 29);
            this.tbxServerIP.TabIndex = 4;
            this.tbxServerIP.Text = "192.168.1.20";
            // 
            // tbxServerPort
            // 
            this.tbxServerPort.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxServerPort.Location = new System.Drawing.Point(373, 43);
            this.tbxServerPort.Name = "tbxServerPort";
            this.tbxServerPort.Size = new System.Drawing.Size(120, 29);
            this.tbxServerPort.TabIndex = 5;
            this.tbxServerPort.Text = "10001";
            // 
            // btnTcpConnect
            // 
            this.btnTcpConnect.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTcpConnect.Location = new System.Drawing.Point(233, 83);
            this.btnTcpConnect.Name = "btnTcpConnect";
            this.btnTcpConnect.Size = new System.Drawing.Size(127, 29);
            this.btnTcpConnect.TabIndex = 6;
            this.btnTcpConnect.Text = "Connect";
            this.btnTcpConnect.UseVisualStyleBackColor = true;
            this.btnTcpConnect.Click += new System.EventHandler(this.btnTcpConnect_Click);
            // 
            // btnTcpDisconnect
            // 
            this.btnTcpDisconnect.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTcpDisconnect.Location = new System.Drawing.Point(366, 83);
            this.btnTcpDisconnect.Name = "btnTcpDisconnect";
            this.btnTcpDisconnect.Size = new System.Drawing.Size(127, 29);
            this.btnTcpDisconnect.TabIndex = 7;
            this.btnTcpDisconnect.Text = "Disconnect";
            this.btnTcpDisconnect.UseVisualStyleBackColor = true;
            this.btnTcpDisconnect.Click += new System.EventHandler(this.btnTcpDisconnect_Click);
            // 
            // btnTcpState
            // 
            this.btnTcpState.BackColor = System.Drawing.Color.Red;
            this.btnTcpState.Location = new System.Drawing.Point(137, 82);
            this.btnTcpState.Name = "btnTcpState";
            this.btnTcpState.Size = new System.Drawing.Size(30, 30);
            this.btnTcpState.TabIndex = 8;
            this.btnTcpState.UseVisualStyleBackColor = false;
            // 
            // lblTcpState
            // 
            this.lblTcpState.AutoSize = true;
            this.lblTcpState.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTcpState.Location = new System.Drawing.Point(12, 87);
            this.lblTcpState.Name = "lblTcpState";
            this.lblTcpState.Size = new System.Drawing.Size(125, 21);
            this.lblTcpState.TabIndex = 9;
            this.lblTcpState.Text = "Connect State :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "※ Command package : PC -> PLC-FX3U";
            // 
            // tbxCommand
            // 
            this.tbxCommand.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxCommand.Location = new System.Drawing.Point(17, 264);
            this.tbxCommand.Name = "tbxCommand";
            this.tbxCommand.Size = new System.Drawing.Size(378, 29);
            this.tbxCommand.TabIndex = 12;
            this.tbxCommand.Text = "13FF000A";
            // 
            // btnCommandSend
            // 
            this.btnCommandSend.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCommandSend.Location = new System.Drawing.Point(401, 264);
            this.btnCommandSend.Name = "btnCommandSend";
            this.btnCommandSend.Size = new System.Drawing.Size(92, 29);
            this.btnCommandSend.TabIndex = 13;
            this.btnCommandSend.Text = "Send";
            this.btnCommandSend.UseVisualStyleBackColor = true;
            this.btnCommandSend.Click += new System.EventHandler(this.btnCommandSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(13, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "※ Response package : PC<-PLC-FX3U";
            // 
            // btnResponseClear
            // 
            this.btnResponseClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnResponseClear.Location = new System.Drawing.Point(401, 409);
            this.btnResponseClear.Name = "btnResponseClear";
            this.btnResponseClear.Size = new System.Drawing.Size(92, 29);
            this.btnResponseClear.TabIndex = 16;
            this.btnResponseClear.Text = "Clear";
            this.btnResponseClear.UseVisualStyleBackColor = true;
            this.btnResponseClear.Click += new System.EventHandler(this.btnResponseClear_Click);
            // 
            // lstResponse
            // 
            this.lstResponse.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstResponse.FormattingEnabled = true;
            this.lstResponse.ItemHeight = 20;
            this.lstResponse.Location = new System.Drawing.Point(17, 319);
            this.lstResponse.Name = "lstResponse";
            this.lstResponse.Size = new System.Drawing.Size(476, 84);
            this.lstResponse.TabIndex = 15;
            // 
            // lblHostIP
            // 
            this.lblHostIP.AutoSize = true;
            this.lblHostIP.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblHostIP.Location = new System.Drawing.Point(14, 450);
            this.lblHostIP.Name = "lblHostIP";
            this.lblHostIP.Size = new System.Drawing.Size(118, 17);
            this.lblHostIP.TabIndex = 17;
            this.lblHostIP.Text = "Host IP : 127.0.0.1";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblState.Location = new System.Drawing.Point(12, 148);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(183, 21);
            this.lblState.TabIndex = 18;
            this.lblState.Text = "※ Connected Message";
            // 
            // lstState
            // 
            this.lstState.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstState.FormattingEnabled = true;
            this.lstState.ItemHeight = 20;
            this.lstState.Location = new System.Drawing.Point(17, 172);
            this.lstState.Name = "lstState";
            this.lstState.Size = new System.Drawing.Size(476, 64);
            this.lstState.TabIndex = 19;
            // 
            // txtResponse
            // 
            this.txtResponse.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtResponse.Location = new System.Drawing.Point(16, 409);
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(379, 29);
            this.txtResponse.TabIndex = 20;
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRun.Location = new System.Drawing.Point(233, 118);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(78, 29);
            this.btnRun.TabIndex = 21;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStop.Location = new System.Drawing.Point(317, 118);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(78, 29);
            this.btnStop.TabIndex = 22;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblPLCType
            // 
            this.lblPLCType.AutoSize = true;
            this.lblPLCType.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPLCType.Location = new System.Drawing.Point(15, 471);
            this.lblPLCType.Name = "lblPLCType";
            this.lblPLCType.Size = new System.Drawing.Size(108, 17);
            this.lblPLCType.TabIndex = 23;
            this.lblPLCType.Text = "PLC Type : None";
            // 
            // btnPLCType
            // 
            this.btnPLCType.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPLCType.Location = new System.Drawing.Point(401, 118);
            this.btnPLCType.Name = "btnPLCType";
            this.btnPLCType.Size = new System.Drawing.Size(92, 29);
            this.btnPLCType.TabIndex = 24;
            this.btnPLCType.Text = "PLC Type";
            this.btnPLCType.UseVisualStyleBackColor = true;
            this.btnPLCType.Click += new System.EventHandler(this.btnPLCType_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(510, 501);
            this.Controls.Add(this.btnPLCType);
            this.Controls.Add(this.lblPLCType);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.lstState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblHostIP);
            this.Controls.Add(this.btnResponseClear);
            this.Controls.Add(this.lstResponse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCommandSend);
            this.Controls.Add(this.tbxCommand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTcpState);
            this.Controls.Add(this.btnTcpState);
            this.Controls.Add(this.btnTcpDisconnect);
            this.Controls.Add(this.btnTcpConnect);
            this.Controls.Add(this.tbxServerPort);
            this.Controls.Add(this.tbxServerIP);
            this.Controls.Add(this.lblServerPort);
            this.Controls.Add(this.lblServerIP);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "EQVIEW-Client";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblServerIP;
        private System.Windows.Forms.Label lblServerPort;
        private System.Windows.Forms.TextBox tbxServerIP;
        private System.Windows.Forms.TextBox tbxServerPort;
        private System.Windows.Forms.Button btnTcpConnect;
        private System.Windows.Forms.Button btnTcpDisconnect;
        private System.Windows.Forms.Button btnTcpState;
        private System.Windows.Forms.Label lblTcpState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxCommand;
        private System.Windows.Forms.Button btnCommandSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnResponseClear;
        private System.Windows.Forms.ListBox lstResponse;
        private System.Windows.Forms.Label lblHostIP;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ListBox lstState;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnStop;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Label lblPLCType;
        private System.Windows.Forms.Button btnPLCType;
    }
}

