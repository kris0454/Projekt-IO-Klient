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
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
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
                textBox7.Text += textBox1.Text+", ";
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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // wysyłanie listy liter i odbieranie jej
        }
    }
}
