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
        
        Form2 f2 = new Form2();
        Form3 f3 = new Form3();

        public Form1()
        {
            InitializeComponent();
            

            f2.Show();
            
            f3.Show();


        }

        private void Rosso_Click(object sender, EventArgs e)
        {
            if(f3.condizioneSeriale==true)
            {
                serialPort1.Write("a");
                f2.Traslazione();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(f3.condizioneSeriale==true)
            {
                serialPort1.Write("b");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(f3.condizioneSeriale==true)
            {
                serialPort1.Write("c");
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
            f2.riga1 = textBox1.Text;
            f2.riga2 = textBox4.Text;
            f2.riga3 = textBox5.Text;
            f2.riga4 = textBox6.Text;
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

        private void button5_Click(object sender, EventArgs e)
        {
            if (f3.condizioneSeriale == false)
            {
                serialPort1.Open();
                f3.condizioneSeriale = true;
            }
            else
            {
                f3.condizioneSeriale = false;
                serialPort1.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            serialPort1.Write("d");
        }
    }
}
