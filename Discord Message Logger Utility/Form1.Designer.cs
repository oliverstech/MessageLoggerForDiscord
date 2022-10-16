namespace Discord_Message_Logger_Utility
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AllRadio = new System.Windows.Forms.RadioButton();
            this.ChannelRadio = new System.Windows.Forms.RadioButton();
            this.DmRadio = new System.Windows.Forms.RadioButton();
            this.MessageLogBox = new System.Windows.Forms.TextBox();
            this.LogUpdateIntBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SetLogUpdateButton = new System.Windows.Forms.Button();
            this.CurrentlySetToLabel = new System.Windows.Forms.Label();
            this.BeginButton = new System.Windows.Forms.Button();
            this.tokenBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "OTC\'s Discord Message Logger";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Made with <3 by Oliver\'s Tech Corner";
            // 
            // AllRadio
            // 
            this.AllRadio.AutoSize = true;
            this.AllRadio.Location = new System.Drawing.Point(649, 12);
            this.AllRadio.Name = "AllRadio";
            this.AllRadio.Size = new System.Drawing.Size(86, 17);
            this.AllRadio.TabIndex = 2;
            this.AllRadio.TabStop = true;
            this.AllRadio.Text = "All messages";
            this.AllRadio.UseVisualStyleBackColor = true;
            // 
            // ChannelRadio
            // 
            this.ChannelRadio.AutoSize = true;
            this.ChannelRadio.Location = new System.Drawing.Point(649, 35);
            this.ChannelRadio.Name = "ChannelRadio";
            this.ChannelRadio.Size = new System.Drawing.Size(139, 17);
            this.ChannelRadio.TabIndex = 3;
            this.ChannelRadio.TabStop = true;
            this.ChannelRadio.Text = "Messages in channel ID";
            this.ChannelRadio.UseVisualStyleBackColor = true;
            // 
            // DmRadio
            // 
            this.DmRadio.AutoSize = true;
            this.DmRadio.Checked = true;
            this.DmRadio.Location = new System.Drawing.Point(650, 58);
            this.DmRadio.Name = "DmRadio";
            this.DmRadio.Size = new System.Drawing.Size(61, 17);
            this.DmRadio.TabIndex = 4;
            this.DmRadio.TabStop = true;
            this.DmRadio.Text = "All DMs";
            this.DmRadio.UseVisualStyleBackColor = true;
            // 
            // MessageLogBox
            // 
            this.MessageLogBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(87)))), ((int)(((byte)(94)))));
            this.MessageLogBox.ForeColor = System.Drawing.Color.White;
            this.MessageLogBox.Location = new System.Drawing.Point(19, 81);
            this.MessageLogBox.Multiline = true;
            this.MessageLogBox.Name = "MessageLogBox";
            this.MessageLogBox.ReadOnly = true;
            this.MessageLogBox.Size = new System.Drawing.Size(759, 343);
            this.MessageLogBox.TabIndex = 5;
            this.MessageLogBox.Text = "Messages will appear here!";
            // 
            // LogUpdateIntBox
            // 
            this.LogUpdateIntBox.Location = new System.Drawing.Point(497, 32);
            this.LogUpdateIntBox.Name = "LogUpdateIntBox";
            this.LogUpdateIntBox.Size = new System.Drawing.Size(51, 20);
            this.LogUpdateIntBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Log Update Interval (sec)";
            // 
            // SetLogUpdateButton
            // 
            this.SetLogUpdateButton.ForeColor = System.Drawing.Color.Black;
            this.SetLogUpdateButton.Location = new System.Drawing.Point(554, 30);
            this.SetLogUpdateButton.Name = "SetLogUpdateButton";
            this.SetLogUpdateButton.Size = new System.Drawing.Size(41, 23);
            this.SetLogUpdateButton.TabIndex = 8;
            this.SetLogUpdateButton.Text = "Set";
            this.SetLogUpdateButton.UseVisualStyleBackColor = true;
            this.SetLogUpdateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CurrentlySetToLabel
            // 
            this.CurrentlySetToLabel.AutoSize = true;
            this.CurrentlySetToLabel.Location = new System.Drawing.Point(494, 55);
            this.CurrentlySetToLabel.Name = "CurrentlySetToLabel";
            this.CurrentlySetToLabel.Size = new System.Drawing.Size(127, 13);
            this.CurrentlySetToLabel.TabIndex = 9;
            this.CurrentlySetToLabel.Text = "Currently set to: 1 second";
            // 
            // BeginButton
            // 
            this.BeginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BeginButton.ForeColor = System.Drawing.Color.Black;
            this.BeginButton.Location = new System.Drawing.Point(574, 426);
            this.BeginButton.Name = "BeginButton";
            this.BeginButton.Size = new System.Drawing.Size(75, 25);
            this.BeginButton.TabIndex = 10;
            this.BeginButton.Text = "Begin";
            this.BeginButton.UseVisualStyleBackColor = true;
            this.BeginButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // tokenBox
            // 
            this.tokenBox.Location = new System.Drawing.Point(139, 429);
            this.tokenBox.Name = "tokenBox";
            this.tokenBox.Size = new System.Drawing.Size(409, 20);
            this.tokenBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Discord Token:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tokenBox);
            this.Controls.Add(this.BeginButton);
            this.Controls.Add(this.CurrentlySetToLabel);
            this.Controls.Add(this.SetLogUpdateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LogUpdateIntBox);
            this.Controls.Add(this.MessageLogBox);
            this.Controls.Add(this.DmRadio);
            this.Controls.Add(this.ChannelRadio);
            this.Controls.Add(this.AllRadio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "OTC\'s Discord Message Logger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton AllRadio;
        private System.Windows.Forms.RadioButton ChannelRadio;
        private System.Windows.Forms.RadioButton DmRadio;
        private System.Windows.Forms.TextBox MessageLogBox;
        private System.Windows.Forms.TextBox LogUpdateIntBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SetLogUpdateButton;
        private System.Windows.Forms.Label CurrentlySetToLabel;
        private System.Windows.Forms.Button BeginButton;
        private System.Windows.Forms.TextBox tokenBox;
        private System.Windows.Forms.Label label4;
    }
}

