namespace TCP_Client
{
    partial class Form1
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
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.settingsNavLabel = new System.Windows.Forms.Label();
            this.ledNavLabel = new System.Windows.Forms.Label();
            this.terminalNavLabel = new System.Windows.Forms.Label();
            this.connectionNavLabel = new System.Windows.Forms.Label();
            this.sidebarSubLabel = new System.Windows.Forms.Label();
            this.sidebarHeaderLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerTitleLabel = new System.Windows.Forms.Label();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.messageTextBox = new System.Windows.Forms.RichTextBox();
            this.terminalInputPanel = new System.Windows.Forms.Panel();
            this.sendTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.terminalHeaderPanel = new System.Windows.Forms.Panel();
            this.terminalTitleLabel = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ledToggleCheckBox = new System.Windows.Forms.CheckBox();
            this.themeToggleCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nicknameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.sidebarPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.terminalInputPanel.SuspendLayout();
            this.terminalHeaderPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.Controls.Add(this.settingsNavLabel);
            this.sidebarPanel.Controls.Add(this.ledNavLabel);
            this.sidebarPanel.Controls.Add(this.terminalNavLabel);
            this.sidebarPanel.Controls.Add(this.connectionNavLabel);
            this.sidebarPanel.Controls.Add(this.sidebarSubLabel);
            this.sidebarPanel.Controls.Add(this.sidebarHeaderLabel);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 60);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Padding = new System.Windows.Forms.Padding(20);
            this.sidebarPanel.Size = new System.Drawing.Size(200, 485);
            this.sidebarPanel.TabIndex = 0;
            // 
            // settingsNavLabel
            // 
            this.settingsNavLabel.AutoSize = true;
            this.settingsNavLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.settingsNavLabel.Location = new System.Drawing.Point(20, 220);
            this.settingsNavLabel.Name = "settingsNavLabel";
            this.settingsNavLabel.Size = new System.Drawing.Size(58, 19);
            this.settingsNavLabel.TabIndex = 5;
            this.settingsNavLabel.Text = "Settings";
            // 
            // ledNavLabel
            // 
            this.ledNavLabel.AutoSize = true;
            this.ledNavLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ledNavLabel.Location = new System.Drawing.Point(20, 180);
            this.ledNavLabel.Name = "ledNavLabel";
            this.ledNavLabel.Size = new System.Drawing.Size(83, 19);
            this.ledNavLabel.TabIndex = 4;
            this.ledNavLabel.Text = "LED Control";
            // 
            // terminalNavLabel
            // 
            this.terminalNavLabel.AutoSize = true;
            this.terminalNavLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.terminalNavLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.terminalNavLabel.Location = new System.Drawing.Point(20, 140);
            this.terminalNavLabel.Name = "terminalNavLabel";
            this.terminalNavLabel.Size = new System.Drawing.Size(64, 19);
            this.terminalNavLabel.TabIndex = 3;
            this.terminalNavLabel.Text = "Terminal";
            // 
            // connectionNavLabel
            // 
            this.connectionNavLabel.AutoSize = true;
            this.connectionNavLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.connectionNavLabel.Location = new System.Drawing.Point(20, 100);
            this.connectionNavLabel.Name = "connectionNavLabel";
            this.connectionNavLabel.Size = new System.Drawing.Size(79, 19);
            this.connectionNavLabel.TabIndex = 2;
            this.connectionNavLabel.Text = "Connection";
            // 
            // sidebarSubLabel
            // 
            this.sidebarSubLabel.AutoSize = true;
            this.sidebarSubLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.sidebarSubLabel.Location = new System.Drawing.Point(20, 45);
            this.sidebarSubLabel.Name = "sidebarSubLabel";
            this.sidebarSubLabel.Size = new System.Drawing.Size(64, 13);
            this.sidebarSubLabel.TabIndex = 1;
            this.sidebarSubLabel.Text = "TCP/IP v4";
            // 
            // sidebarHeaderLabel
            // 
            this.sidebarHeaderLabel.AutoSize = true;
            this.sidebarHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.sidebarHeaderLabel.Location = new System.Drawing.Point(20, 20);
            this.sidebarHeaderLabel.Name = "sidebarHeaderLabel";
            this.sidebarHeaderLabel.Size = new System.Drawing.Size(124, 21);
            this.sidebarHeaderLabel.TabIndex = 0;
            this.sidebarHeaderLabel.Text = "Client Console";
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.headerTitleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(900, 60);
            this.headerPanel.TabIndex = 1;
            // 
            // headerTitleLabel
            // 
            this.headerTitleLabel.AutoSize = true;
            this.headerTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.headerTitleLabel.Location = new System.Drawing.Point(20, 15);
            this.headerTitleLabel.Name = "headerTitleLabel";
            this.headerTitleLabel.Size = new System.Drawing.Size(120, 30);
            this.headerTitleLabel.TabIndex = 0;
            this.headerTitleLabel.Text = "TCP Client";
            // 
            // footerPanel
            // 
            this.footerPanel.Controls.Add(this.statusLabel);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 545);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.footerPanel.Size = new System.Drawing.Size(900, 30);
            this.footerPanel.TabIndex = 2;
            // 
            // statusLabel
            // 
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.statusLabel.Location = new System.Drawing.Point(20, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(400, 30);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "System Status: Ready";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.rightPanel);
            this.mainPanel.Controls.Add(this.leftPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(200, 60);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(20);
            this.mainPanel.Size = new System.Drawing.Size(700, 485);
            this.mainPanel.TabIndex = 3;
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.messageTextBox);
            this.rightPanel.Controls.Add(this.terminalInputPanel);
            this.rightPanel.Controls.Add(this.terminalHeaderPanel);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(320, 20);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(360, 445);
            this.rightPanel.TabIndex = 1;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageTextBox.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            this.messageTextBox.Location = new System.Drawing.Point(0, 40);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(360, 355);
            this.messageTextBox.TabIndex = 2;
            this.messageTextBox.Text = "";
            // 
            // terminalInputPanel
            // 
            this.terminalInputPanel.Controls.Add(this.sendTextBox);
            this.terminalInputPanel.Controls.Add(this.button2);
            this.terminalInputPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.terminalInputPanel.Location = new System.Drawing.Point(0, 395);
            this.terminalInputPanel.Name = "terminalInputPanel";
            this.terminalInputPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.terminalInputPanel.Size = new System.Drawing.Size(360, 50);
            this.terminalInputPanel.TabIndex = 1;
            // 
            // sendTextBox
            // 
            this.sendTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sendTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.sendTextBox.Location = new System.Drawing.Point(0, 10);
            this.sendTextBox.Name = "sendTextBox";
            this.sendTextBox.Size = new System.Drawing.Size(280, 29);
            this.sendTextBox.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Location = new System.Drawing.Point(280, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // terminalHeaderPanel
            // 
            this.terminalHeaderPanel.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.terminalHeaderPanel.Controls.Add(this.terminalTitleLabel);
            this.terminalHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.terminalHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.terminalHeaderPanel.Name = "terminalHeaderPanel";
            this.terminalHeaderPanel.Size = new System.Drawing.Size(360, 40);
            this.terminalHeaderPanel.TabIndex = 0;
            // 
            // terminalTitleLabel
            // 
            this.terminalTitleLabel.AutoSize = true;
            this.terminalTitleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.terminalTitleLabel.ForeColor = System.Drawing.Color.White;
            this.terminalTitleLabel.Location = new System.Drawing.Point(10, 12);
            this.terminalTitleLabel.Name = "terminalTitleLabel";
            this.terminalTitleLabel.Size = new System.Drawing.Size(158, 15);
            this.terminalTitleLabel.TabIndex = 0;
            this.terminalTitleLabel.Text = "user@tcp-client: ~terminal";
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.groupBox2);
            this.leftPanel.Controls.Add(this.themeToggleCheckBox);
            this.leftPanel.Controls.Add(this.groupBox1);
            this.leftPanel.Controls.Add(this.connectButton);
            this.leftPanel.Controls.Add(this.disconnectButton);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(20, 20);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(300, 445);
            this.leftPanel.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ledToggleCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(3, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 80);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LED DEMO";
            // 
            // ledToggleCheckBox
            // 
            this.ledToggleCheckBox.Location = new System.Drawing.Point(15, 30);
            this.ledToggleCheckBox.Name = "ledToggleCheckBox";
            this.ledToggleCheckBox.Size = new System.Drawing.Size(250, 30);
            this.ledToggleCheckBox.TabIndex = 0;
            this.ledToggleCheckBox.Text = "LED ON";
            this.ledToggleCheckBox.UseVisualStyleBackColor = true;
            this.ledToggleCheckBox.CheckedChanged += new System.EventHandler(this.ledToggleCheckBox_CheckedChanged);
            // 
            // themeToggleCheckBox
            // 
            this.themeToggleCheckBox.AutoSize = true;
            this.themeToggleCheckBox.Checked = true;
            this.themeToggleCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.themeToggleCheckBox.Location = new System.Drawing.Point(3, 360);
            this.themeToggleCheckBox.Name = "themeToggleCheckBox";
            this.themeToggleCheckBox.Size = new System.Drawing.Size(103, 21);
            this.themeToggleCheckBox.TabIndex = 4;
            this.themeToggleCheckBox.Text = "Dark Theme";
            this.themeToggleCheckBox.UseVisualStyleBackColor = true;
            this.themeToggleCheckBox.CheckedChanged += new System.EventHandler(this.themeToggleCheckBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nicknameTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.portTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.hostTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SERVER DETAILS";
            // 
            // nicknameTextBox
            // 
            this.nicknameTextBox.Location = new System.Drawing.Point(15, 140);
            this.nicknameTextBox.Name = "nicknameTextBox";
            this.nicknameTextBox.Size = new System.Drawing.Size(250, 23);
            this.nicknameTextBox.TabIndex = 5;
            this.nicknameTextBox.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nick";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(15, 90);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(250, 23);
            this.portTextBox.TabIndex = 3;
            this.portTextBox.Text = "8083";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // hostTextBox
            // 
            this.hostTextBox.Location = new System.Drawing.Point(15, 40);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(250, 23);
            this.hostTextBox.TabIndex = 1;
            this.hostTextBox.Text = "localhost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(3, 200);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(135, 50);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Location = new System.Drawing.Point(148, 200);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(135, 50);
            this.disconnectButton.TabIndex = 2;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 575);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.footerPanel);
            this.Name = "Form1";
            this.Text = "TCP Client";
            this.sidebarPanel.ResumeLayout(false);
            this.sidebarPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.footerPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.terminalInputPanel.ResumeLayout(false);
            this.terminalInputPanel.PerformLayout();
            this.terminalHeaderPanel.ResumeLayout(false);
            this.terminalHeaderPanel.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Label sidebarHeaderLabel;
        private System.Windows.Forms.Label sidebarSubLabel;
        private System.Windows.Forms.Label connectionNavLabel;
        private System.Windows.Forms.Label terminalNavLabel;
        private System.Windows.Forms.Label ledNavLabel;
        private System.Windows.Forms.Label settingsNavLabel;
        
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label headerTitleLabel;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel terminalHeaderPanel;
        private System.Windows.Forms.Label terminalTitleLabel;
        private System.Windows.Forms.Panel terminalInputPanel;

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ledToggleCheckBox;
        private System.Windows.Forms.CheckBox themeToggleCheckBox;

        private System.Windows.Forms.TextBox sendTextBox;

        private System.Windows.Forms.Button disconnectButton;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hostTextBox;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.RichTextBox messageTextBox;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox nicknameTextBox;
        private System.Windows.Forms.Label label3;

        #endregion
    }
}
