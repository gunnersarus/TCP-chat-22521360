using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_chat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpClient client;


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonconnect_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect();
                buttonsend.Enabled = true;
                buttonconnect.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient(textip.Text);
            client.Events.Connected += Events_Connected;
            client.Events.Disconnected += Events_Disconnected;
            client.Events.DataReceived += Events_DataReceived;
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            textinf.Text += $"Server: {Encoding.UTF8.GetString(e.Data.Array)}{Environment.NewLine}";
        }

        private void Events_Disconnected(object sender, ConnectionEventArgs e)
        {
            textinf.Text += $"Server disconected.{Environment.NewLine}";

        }

        private void Events_Connected(object sender, ConnectionEventArgs e)
        {
            textinf.Text += $"Server conected.{Environment.NewLine}";
        }

        private void buttonsend_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                if (!string.IsNullOrEmpty(textmessage.Text))
                {
                    client.Send(textmessage.Text);
                    textinf.Text += $"Me: {textmessage.Text}{Environment.NewLine}";
                    textmessage.Text = string.Empty;
                }
            }
        }
    }
}

