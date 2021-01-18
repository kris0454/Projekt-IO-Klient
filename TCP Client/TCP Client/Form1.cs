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

namespace TCP_Client
{
    public partial class Form1 : Form
    {
        TcpClient tcpclient = new TcpClient();
        IPAddress ipAd = IPAddress.Parse("127.1.1.0");
        int PortNumber = 2048;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Connecting....");
            try
            {
                tcpclient.Connect(ipAd, PortNumber);
                
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                if(textBox2.Text != "")
                {
                    //send
                    if (true)//tu powinno być odbieranie
                    {
                        //recive
                        MessageBox.Show("Zalogowano!");
                        Form2 f = new Form2();
                        f.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Błędny login lub hasło.");
                    }
                }
                else
                {
                    MessageBox.Show("Podaj hasło.");
                }
            }
            else
            {
                MessageBox.Show("Podaj login.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox2.Text != "")
                {
                    //wysyłanie ,że info o nowym koncie
                    if (true)//sprawdzanie czy istnieje
                    {
                        MessageBox.Show("Założono nowe konto!");
                        // przejscie dalej czy trzeba się zalogować?
                    }
                    else
                    {
                        MessageBox.Show("Konto już istnieje!");
                    }
                }
                else
                {
                    MessageBox.Show("Podaj hasło.");
                }
            }
            else
            {
                MessageBox.Show("Podaj login.");
            }
        }
    }
}
