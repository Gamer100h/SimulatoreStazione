using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        int i = 0;
        public bool condizioneSeriale = false;
        Form2 f2 = new Form2();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(i==0)
            {
                i++;
                pictureBox3.Hide();
                serialPort1.Write("c");
                pictureBox1.Show();
                if(checkBox1.Checked)
                {
                    string strCmdText;
                    strCmdText = "microsoft-edge:" + textBox1.Text;
                    System.Diagnostics.Process.Start(strCmdText);
                }
            } 
            else if(i==1)
            {
                i++;
                serialPort1.Write("d");
                pictureBox1.Hide();
                pictureBox2.Show();


            }
            else
            {
                serialPort1.Write("a");
                i = 0;
                pictureBox3.Show();
                pictureBox2.Hide();
                f2.Traslazione();

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(condizioneSeriale==false)
            {
                serialPort1.Open();
                condizioneSeriale = true;
            }
            else
            {
                condizioneSeriale = false;
                serialPort1.Close();
            }
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = "microsoft-edge:" + textBox1.Text;
            System.Diagnostics.Process.Start(strCmdText);
        }
    }
}
