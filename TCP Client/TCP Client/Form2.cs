using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TCP_Client.Program;

namespace TCP_Client
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Shared.writer.WriteLine("logout");
            //wysyłanie do serwera, ze koniec logowania
            Form oldForm = Program.appC.MainForm;
            Program.appC.MainForm = new Form1();
            Program.appC.MainForm.Show();
            oldForm.Dispose();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                string temp = textBox1.Text;
                if (temp.Length > 1)
                {
                    for (int i = 0; i < temp.Length; i++)
                    {
                        textBox7.Text += temp[i] + ", ";
                    }
                }
                else
                {
                    textBox7.Text += textBox1.Text + ", ";
                }
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Brak litery.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                string s = textBox1.Text;
                string s1 = textBox7.Text;
                textBox7.Text = s1.Replace(s+", ", "");
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Brak litery.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // wysyłanie listy liter i odbieranie jej
            textBox2.Clear();
            textBox3.Clear();
            string temp = textBox7.Text;
            Shared.writer.WriteLine(temp);
            ArrayList listslow = new ArrayList();
            ArrayList listapunkt = new ArrayList();
            do
            {
                temp = Shared.reader.ReadLine();
                listslow.Add(temp);
            } while (temp != "-");
            for(int i = 0; i < listslow.Count-1; i++)
            {
                temp = listslow[i] + "\r\n";
                textBox2.Text += temp;
            }
            do
            {
                temp = Shared.reader.ReadLine();
                listapunkt.Add(temp);
            } while (temp != "-");
            for (int i = 0; i < listapunkt.Count-1; i++)
            {
                temp = listapunkt[i] + "\r\n";
                textBox3.Text += temp;
            }

        }
    }
}
