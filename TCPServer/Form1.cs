using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            server.Start();
            textmessage.Text += $"Starting...{Environment.NewLine}";
            buttonstart.Enabled = false;
            buttonsend.Enabled = true;
        }

        SimpleTcpServer server;


        private void label3_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonsend.Enabled = false;
            server = new SimpleTcpServer(textip.Text);
            server.Events.ClientConnected += Events_ClientConnected;

            server.Events.ClientDisconnected += Events_ClientDisconnected;

            server.Events.DataReceived += Events_DataReceived;

        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            textinf.Text += $"{e.IpPort}: {Encoding.UTF8.GetString(e.Data.Array)}{Environment.NewLine}";
        }

        private void Events_ClientDisconnected(object sender, ConnectionEventArgs e)
        {
            textinf.Text += $"{e.IpPort} disconnected.{Environment.NewLine}";
            lstClientip.Items.Remove(e.IpPort);
        }

        private void Events_ClientConnected(object sender, ConnectionEventArgs e)
        {
            textinf.Text += $"{e.IpPort} connected.{Environment.NewLine}";
            lstClientip.Items.Add(e.IpPort);
        }

       
        private void buttonsend_Click(object sender, EventArgs e)
        {
            if (server.IsListening)
            { 
              if (!string.IsNullOrEmpty(textmessage.Text) && lstClientip.SelectedItems != null)
              {
                    server.Send(lstClientip.SelectedItems.ToString(),textmessage.Text);
                    textinf.Text = string.Empty;

              }
            }

        }
    }
}
