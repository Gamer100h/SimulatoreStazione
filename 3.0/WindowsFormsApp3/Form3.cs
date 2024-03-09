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
        
        public int i = 0;
        Form5 f7 = new Form5();
        
        bool seriale = false;
        public Form3()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(i==0)
            {
                
                pictureBox3.Hide();


                serialPort1.Write("c");
                
                
                pictureBox1.Show();
                if(checkBox1.Checked)
                {
                    string strCmdText;
                    strCmdText = "microsoft-edge:" + textBox1.Text;
                    System.Diagnostics.Process.Start(strCmdText);
                }
                f7.circuitoOccupato(i);
                i++;

            } 
            else if(i==1)
            {
                


                f7.circuitoOccupato(i);
                serialPort1.Write("d");
                i++;



                pictureBox1.Hide();
                pictureBox2.Show();

                
            }
            else
            {


                f7.circuitoOccupato(i);
                serialPort1.Write("a");
                    
                
                i = 0;
                pictureBox3.Show();
                pictureBox2.Hide();
                
                
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

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
        }
    }
}
