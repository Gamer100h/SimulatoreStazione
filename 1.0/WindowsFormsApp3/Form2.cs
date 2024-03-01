using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public string riga1 = "i";
        public string riga2 = "i";
        public string riga3 = "i";
        public string riga4 = "i";
        public Form2()
        {
            InitializeComponent();

        }

        public void Traslazione()
        {
            label4.Text = label10.Text;
            label10.Text = label9.Text;
            label9.Text = label11.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = riga1;
            label10.Text = riga2;
            label9.Text = riga3;
            label11.Text = riga4;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
