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
using static TCP_Client.Program;

namespace TCP_Client
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                if(textBox2.Text != "")
                {
                    //send
                    string user = textBox1.Text;
                    string pass = textBox2.Text;
                    Shared.writer.WriteLine(user+";"+pass);
                    string logged = Shared.reader.ReadLine();
                    if (logged == "1")//tu powinno być odbieranie
                    {
                        //recive
                        MessageBox.Show("Zalogowano!");
                        Form oldForm = Program.appC.MainForm;
                        Program.appC.MainForm = new Form2();
                        Program.appC.MainForm.Show();
                        oldForm.Dispose();
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
