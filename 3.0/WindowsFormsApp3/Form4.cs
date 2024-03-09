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
    public partial class Form4 : Form
    {
        public bool seriale = false;
        public string SerialPortName;
        public Form4()
        {
            InitializeComponent();
        }

        public string scelta;
        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                seriale = true;
                SerialPortName = listBox1.Text;
                scelta = listBox1.Text;

            }
            else
            {
                seriale = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = listBox1.Text;
            
            try 
            {
                if(!(serialPort1.IsOpen))
                {
                    serialPort1.Open();
                    MessageBox.Show("La connessione è stata stabilita con successo", "Test connessione" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    serialPort1.Close();
                }
                
            }
            catch
            {
                serialPort1.Close();
                MessageBox.Show("Errore nello stabilire una connessione con la seriale", "Test connessione", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
