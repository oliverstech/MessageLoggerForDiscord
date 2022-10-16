using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Discord_Message_Logger_Utility
{
    public partial class Form1 : Form
    {
        int userPeriodTimeSpan = 1;
        int i = 0;
        TimeSpan startTimeSpan;
        TimeSpan periodTimeSpan;
        string logtype = "none";

        public Form1()
        {
            InitializeComponent();

        }

        public async void Form1_Load(object sender, EventArgs e)
        {
            DmRadio.Select();

            Process.Start("py", "-m pip uninstall discord.py discord discord.py-self -y");
            await PutTaskDelay(5000);
            Process.Start("py", "-m pip install discord.py-self");
            MessageLogBox.ScrollBars = ScrollBars.Vertical;
            MessageLogBox.WordWrap = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                
                userPeriodTimeSpan = Convert.ToInt32(LogUpdateIntBox.Text);
                startTimeSpan = TimeSpan.FromSeconds(0);
                periodTimeSpan = TimeSpan.FromSeconds(userPeriodTimeSpan);


                if (userPeriodTimeSpan == 1)
                {
                    MessageBox.Show("Log interval set to " + userPeriodTimeSpan + " second");
                    CurrentlySetToLabel.Text = "Currently set to: " + userPeriodTimeSpan + " second";
                }   
                else
                {
                    MessageBox.Show("Log interval set to " + userPeriodTimeSpan + " seconds");
                    CurrentlySetToLabel.Text = "Currently set to: " + userPeriodTimeSpan + " seconds";
                }

            }
            catch (System.FormatException)
            {
                MessageBox.Show("Must be a number!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool idInvalid = false;
            string id = "0";
            if (AllRadio.Checked == true)
            {
                logtype = "all";
            }
            else if (ChannelRadio.Checked == true)
            {

                id = Interaction.InputBox("Please enter the ID of the channel you'd like to log. This is the end part of the URL on the web-client of Discord.");
                if (id == null || id == string.Empty || id == "" || id == " ")
                {
                    idInvalid = true;
                }
                logtype = "id";
            }
            else if (DmRadio.Checked == true)
            {
                logtype = "dm";
            }
            
            if (tokenBox.Text == "" || tokenBox.Text == " " || tokenBox.Text == String.Empty)
            {
                MessageBox.Show("You need to specify your token first!");
            }
            else if (logtype == "none")
            {
                MessageBox.Show("You need to specify which messages to log first!");
            }
            else
            {
                string arg = null;
                if (logtype == "id")
                {
                    arg = logtype + " " + "\"" + tokenBox.Text + "\" \"" + id + "\"";

                    Process.Start("helper.pyw", arg);
                }
                else
                {
                    arg = logtype + " " + "\"" + tokenBox.Text + "\"";
                    Process.Start("helper.pyw", arg);
                }


                if (idInvalid == false)
                {
                    LogUpdateIntBox.Visible = false;
                    SetLogUpdateButton.Visible = false;
                    BeginButton.Visible = false;
                    AllRadio.Visible = false;
                    ChannelRadio.Visible = false;
                    DmRadio.Visible = false;
                    label3.Visible = false;
                    CurrentlySetToLabel.Visible = false;
                    label4.Visible = false;
                    tokenBox.Visible = false;

                    startTimeSpan = TimeSpan.FromSeconds(0);
                    periodTimeSpan = TimeSpan.FromSeconds(userPeriodTimeSpan);
                    
                    var timer = new System.Threading.Timer((a) =>
                    {
                        var logtext = File.ReadAllText("log.txt");

                        MessageLogBox.Invoke((MethodInvoker)delegate
                        {
                            // Running on the UI thread
                            MessageLogBox.Text = logtext;
                        });
                    }, null, startTimeSpan, periodTimeSpan);
                }
            }

        }
        async Task PutTaskDelay(int a)
        {
            await Task.Delay(a);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.Start("taskkill", "/f /im pythonw3.10.exe");
            Process.Start("taskkill", "/f /im python.exe");
            MessageBox.Show("You may need to manually terminate 'Python (Windowed)' and 'Python' to stop the message logger fully.", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
