using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_Client
{
    public partial class Form1 : Form
    {
        MyTcpClient _client;

        // Modern Theme Colors
        private readonly Color BackColorDark = Color.FromArgb(19, 19, 19);
        private readonly Color SurfaceColor = Color.FromArgb(27, 27, 27);
        private readonly Color InputBackColor = Color.FromArgb(14, 14, 14);
        private readonly Color PrimaryColor = Color.FromArgb(163, 201, 255);
        private readonly Color AccentColor = Color.FromArgb(0, 120, 212);
        private readonly Color TextColor = Color.FromArgb(229, 226, 225);
        private readonly Color TextDimColor = Color.FromArgb(192, 199, 212);

        public Form1()
        {
            InitializeComponent();

            // Enable Double Buffering to reduce flickering
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
            
            _client = new MyTcpClient();
            _client.MessageReceived += Server_MessageReceived;

            ApplyModernTheme();
        }

        private void ApplyModernTheme()
        {
            this.BackColor = BackColorDark;
            this.ForeColor = TextColor;
            
            // Use Segoe UI for a cleaner look
            this.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);

            // Side Panel Styling
            sidebarPanel.BackColor = SurfaceColor;
            sidebarHeaderLabel.ForeColor = PrimaryColor;
            sidebarHeaderLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            sidebarSubLabel.ForeColor = TextDimColor;
            
            connectionNavLabel.ForeColor = TextDimColor;
            terminalNavLabel.ForeColor = PrimaryColor;
            terminalNavLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            ledNavLabel.ForeColor = TextDimColor;
            settingsNavLabel.ForeColor = TextDimColor;

            // Header Styling
            headerPanel.BackColor = Color.FromArgb(25, 25, 25);
            headerTitleLabel.ForeColor = TextColor;
            headerTitleLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);

            // Footer Styling
            footerPanel.BackColor = Color.FromArgb(14, 14, 14);
            statusLabel.ForeColor = TextDimColor;

            // Main Content Styling
            StyleGroupBox(groupBox1);
            StyleGroupBox(groupBox2);
            
            StyleTextBox(hostTextBox);
            StyleTextBox(portTextBox);
            StyleTextBox(nicknameTextBox);
            StyleTextBox(sendTextBox);
            
            StyleRichTextBox(messageTextBox);

            StyleButton(connectButton, true);
            StyleButton(disconnectButton, false);
            StyleButton(button2, true);

            StyleCheckBox(ledToggleCheckBox);
            StyleCheckBox(themeToggleCheckBox);
        }

        private void StyleGroupBox(GroupBox gb)
        {
            gb.ForeColor = PrimaryColor;
            gb.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        }

        private void StyleTextBox(TextBox tb)
        {
            tb.BackColor = InputBackColor;
            tb.ForeColor = TextColor;
            tb.BorderStyle = BorderStyle.FixedSingle;
            tb.Font = new Font("Segoe UI", 10F);
        }

        private void StyleRichTextBox(RichTextBox rtb)
        {
            rtb.BackColor = InputBackColor;
            rtb.ForeColor = TextColor;
            rtb.BorderStyle = BorderStyle.None;
            rtb.Font = new Font("Cascadia Code", 10F);
        }

        private void StyleButton(Button btn, bool isPrimary)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 60);
            if (isPrimary)
            {
                btn.BackColor = AccentColor;
                btn.ForeColor = Color.White;
            }
            else
            {
                btn.BackColor = Color.FromArgb(40, 40, 40);
                btn.ForeColor = TextColor;
            }
            btn.Cursor = Cursors.Hand;
        }

        private void StyleCheckBox(CheckBox cb)
        {
            cb.ForeColor = TextColor;
        }

        private void themeToggleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // For now, keep it fixed to dark or implement a toggle if needed
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ipAddress = hostTextBox.Text;
            var port = int.Parse(portTextBox.Text);
            _client.Nickname = nicknameTextBox.Text;
            try
            {
                _client.Connect(ipAddress, port);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            statusLabel.Text = $@"Connected to {ipAddress}:{port}";
            hostTextBox.Enabled = false;
            portTextBox.Enabled = false;
            nicknameTextBox.Enabled = false;
            disconnectButton.Enabled = true;
            connectButton.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _client.SendMessage(sendTextBox.Text);
        }
        
        private void Server_MessageReceived(object sender, string message)
        {
            // Update the TextBox control with the received message
            // 'Marshalled' to the UI thread using MethodInvoker
            // NOTE: MethodInvoker can also be replaced with Action (like in slide 8, pg 27)
            // According to SO, MethodInvoker is better use case than Action
            // https://stackoverflow.com/questions/1167771/methodinvoker-vs-action-for-control-begininvoke
            messageTextBox.Invoke((MethodInvoker)(() =>
            {
                AppendTextWithMentions(messageTextBox, message);
            }));
        }

        private void AppendTextWithMentions(RichTextBox box, string text)
        {
            int startIndex = box.TextLength;
            box.AppendText(text);
            
            int index = startIndex;
            while (index < box.TextLength)
            {
                int wordStartIndex = box.Text.IndexOf('@', index);
                if (wordStartIndex == -1) break;
                
                int wordEndIndex = box.TextLength;
                for (int i = wordStartIndex + 1; i < box.TextLength; i++)
                {
                    char c = box.Text[i];
                    if (char.IsWhiteSpace(c) || char.IsPunctuation(c))
                    {
                        wordEndIndex = i;
                        break;
                    }
                }
                
                if (wordEndIndex > wordStartIndex + 1)
                {
                    box.Select(wordStartIndex, wordEndIndex - wordStartIndex);
                    box.SelectionColor = Color.DeepSkyBlue;
                    box.SelectionFont = new Font(box.Font, FontStyle.Bold);
                }
                
                index = wordEndIndex;
            }
            
            box.Select(box.TextLength, 0);
            box.SelectionColor = box.ForeColor;
            box.SelectionFont = box.Font;
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            _client.Disconnect();
            statusLabel.Text = @"Disconnected";
            hostTextBox.Enabled = true;
            portTextBox.Enabled = true;
            nicknameTextBox.Enabled = true;
            connectButton.Enabled = true;
            disconnectButton.Enabled = false;
        }

        private void ledToggleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Send LED ON/OFF command to the server
            _client.SendMessage(ledToggleCheckBox.Checked ? "LED ON" : "LED OFF");
        }
    }
}