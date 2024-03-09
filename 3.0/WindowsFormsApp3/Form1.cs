using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Tabellone table = new Tabellone();
        public Form3 f3 = new Form3();
        Form4 f4 = new Form4();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Rosso_Click(object sender, EventArgs e)
        {
            if(f4.seriale==true)
            {
                serialPort1.PortName = f4.SerialPortName;
                serialPort1.Open();
                serialPort1.Write("a");
                
                serialPort1.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(f4.seriale==true)
            {
                serialPort1.Open();
                serialPort1.Write("b");
                serialPort1.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(f4.seriale==true)
            {
                serialPort1.Open();
                serialPort1.Write("c");
                serialPort1.Close();
            }
            
            if(checkBox1.Checked)
            {
                string strCmdText;
                strCmdText = "microsoft-edge:" + textBox2.Text;
                System.Diagnostics.Process.Start(strCmdText);
                Thread.Sleep(120000);
                System.Diagnostics.Process.Start(strCmdText);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            table.inserimentoDati(textBox1.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, comboBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = "microsoft-edge:" + textBox2.Text;
            System.Diagnostics.Process.Start(strCmdText);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button6_Click(object sender, EventArgs e)
        {
            if (f4.seriale == true)
            {
                serialPort1.Open();
                serialPort1.Write("d");
                serialPort1.Close();
            }
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table.Show();
        }

        private void simulazioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3.Show();
        }

        private void impostazioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f4.Show();
        }

        private void aCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void impostaTabelloneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlloTabellone f7 = new ControlloTabellone();
            f7.Show();
        }
    }
}
