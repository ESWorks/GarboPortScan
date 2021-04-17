using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortScan
{
    public partial class PortScan : Form
    {
        private Thread scanner;
        private ProtocolType typing;
        public PortScan()
        {
            InitializeComponent();
            typing = ProtocolType.Udp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (scanner == null)
            {
                if (neport.Value < nsport.Value)
                {
                    neport.Value = nsport.Value + 1;
                }
                portProg.Maximum = (int)neport.Value;
                portProg.Minimum = (int)nsport.Value;
                fscan.Maximum = (int)neport.Value;
                fscan.Minimum = (int)nsport.Value;
                sscan.Maximum = (int)neport.Value;
                sscan.Minimum = (int)nsport.Value;
                scanner = new Thread(RunScan);
                scanner.Start();
            }
        }

        private void RunScan()
        {

            for (int i = (int) nsport.Value; i <= neport.Value; i++)
            {
                tport.Invoke((MethodInvoker)(() => tport.Text = "Port - " + i));
                if (ScanPort(typing, ipadr.Text, i, (int) timeout.Value))
                {
                    sscan.Invoke((MethodInvoker)(() => sscan.Value = i));
                }
                else
                {
                    fscan.Invoke((MethodInvoker)(() => fscan.Value = i));
                }
                portProg.Invoke((MethodInvoker)(() => portProg.Value = i));
            }
            button2_Click(null,null);
            Process.Start("PortScan.exe");
            Close();
        }

        bool ScanPort(ProtocolType type, string IP, int port, int timeout = 5000)
        {
            Socket socket = (type == ProtocolType.Tcp) ? new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp) : new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            // Connect using a timeout (5 seconds)

            IAsyncResult result = socket.BeginConnect(IP, port, null, null);

            bool success = result.AsyncWaitHandle.WaitOne(timeout, true);

            if (!success)
            {
                // NOTE, MUST CLOSE THE SOCKET

                socket.Close();

            }
            return success;
        }

        private void port_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            typing = port_type.Text == "UDP" ? ProtocolType.Udp : ProtocolType.Tcp;
            label1.Text = "Port Type: ("+typing+")";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (scanner != null)
            {
                sscan.Value = 0;
                fscan.Value = 0;
                portProg.Value = 0;
                scanner.Join(5);
                scanner.Abort();
                scanner = null;
            }
        }
    }
}
