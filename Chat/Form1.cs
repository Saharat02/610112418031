using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    public partial class Form1 : Form
    {
        private TcpClient Client;
        private StreamReader str;
        private StreamWriter Stw;
        private string receive;
        private string Textsent;

        public Form1()
        {
            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress IPV in localIP)
            {
                if (IPV.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    A1.Text = IPV.ToString();
                }
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(A2.Text));
            listener.Start();
            Client = listener.AcceptTcpClient();
            str = new StreamReader(Client.GetStream());
            Stw = new StreamWriter(Client.GetStream());
            Stw.AutoFlush = true;
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;
        }

        private void B2_Click(object sender, EventArgs e)
        {
            Client = new TcpClient();
            IPEndPoint ip_end = new IPEndPoint(IPAddress.Parse(A3.Text), int.Parse(A4.Text));
            try
            {
                Client.Connect(ip_end);
                    if (Client.Connected) 
                {
                    A5.AppendText("เชื่อมต่อเเล้ว \n");
                    Stw = new StreamWriter(Client.GetStream());
                    str = new StreamReader(Client.GetStream());
                    Stw.AutoFlush = true;
                    backgroundWorker1.RunWorkerAsync();
                    backgroundWorker2.WorkerSupportsCancellation = true;
                }

            }catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void B3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(A6.Text))
            {
                Textsent = A6.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            A6.Text = "";
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (Client.Connected)
            {
                    try 
                    {
                        receive = str.ReadLine();
                    this.A5.Invoke(new MethodInvoker(delegate()
                    {
                        this.A6.AppendText("คุณ:" +receive+ "\n");
                    }));
                    }catch(Exception ex)
                        {
                    MessageBox.Show(ex.Message);
                        }
                }
            }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (Client.Connected)
            {
                Stw.WriteLine(Textsent);
                this.A5.Invoke(new MethodInvoker(delegate ()
                {
                    this.A5.AppendText("ME:" + Textsent + "\n");
                }));
            }
        }
    }
    }
    

