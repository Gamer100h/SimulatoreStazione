using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Tabellone : Form
    {
        public bool valore1;
        public bool valore2;
        public bool valore3;
        Form5 f5 = new Form5();
        public Tabellone()
        {
            InitializeComponent();
        }

        public void inserimentoDati(string treno, string destinazione, string orario, string ritardo, string informazioni, string binario, string riga)
        {
            if(riga=="1")
            {
                label8.Text = treno;
                label9.Text = destinazione;
                label10.Text = orario;
                label11.Text = ritardo;
                label12.Text = informazioni;
                label13.Text = binario;
            }
            if(riga=="2")
            {
                label14.Text = treno;
                label15.Text = destinazione;
                label16.Text = orario;
                label17.Text = ritardo;
                label18.Text = informazioni;
                label19.Text = binario;
            }
            if(riga=="3")
            {
                label20.Text = treno;
                label21.Text = destinazione;
                label22.Text = orario;
                label23.Text = ritardo;
                label24.Text = informazioni;
                label25.Text = binario;
            }
        }

        public void traslazione(int i)
        {
            if(i==1)
            {
                label8.Text = label14.Text;
                label9.Text = label15.Text;
                label10.Text = label16.Text;
                label11.Text = label17.Text;
                label12.Text = label18.Text;
                label13.Text = label19.Text;
                //SECONDA LINEA
                label14.Text = label20.Text;
                label15.Text = label21.Text;
                label16.Text = label22.Text;
                label17.Text = label23.Text;
                label18.Text = label24.Text;
                label19.Text = label25.Text;
                //TERZA LINEA
                label20.Text = " ";
                label21.Text=" ";
                label22.Text= " ";
                label23.Text= " ";
                label24.Text= " ";
                label25.Text=" ";
            }
        }

        private void Tabellone_Load(object sender, EventArgs e)
        {
            f5.Show();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (f5.orario1 == label10.Text && f5.trenoPartito == true)
            {
                valore1 = true;
                traslazione(1);
                valore1 = false;
            }
        }
    }
}
