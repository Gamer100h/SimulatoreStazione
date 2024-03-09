using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form5 : Form
    {

        int deviata1=0;
        int deviata2=0;
        Form4 f4 = new Form4();

        public string orario1="V";
        public string orario2="V";
        public string orario3="V";
        public Form5()
        {
            InitializeComponent();
            try
            {
                serialPort1.PortName = f4.scelta;
                serialPort1.Open();
            }
            catch
            {
                serialPort1.PortName = "NUL";
            }
            
        }

        private string annuncio(string numeroECategoria, string origine, string destinazione, string orario, string binario)
        {
            if(checkBox1.Checked)
            {
                string annuncio = "Il%20treno%20" + numeroECategoria + ",di%20trenitalia" + ",proveniente%20da%20" + origine + ",e%20diretto%20a%20" + destinazione + ",delle%20ore%20" + orario + ",è%20in%20arrivo%20al%20binario%20" + binario + ",attenzione!%20allontanarsi%20dalla%20linea%20gialla";
                return "https://cache-a.oddcast.com/tts/genB.php?EID=2&LID=7&VID=7&TXT=" + annuncio + "&EXT=mp3&FNAME=&ACC=15679&SceneID=2756155&HTTP_ERR=&cache_flag=3";
            } 
            else
            {
                return "https://cache-a.oddcast.com/tts/genB.php?EID=2&LID=7&VID=7&TXT=" + "Attenzione!Treno%20in%20transito%20al%20binario%20" + binario + ",allontanarsi%20dalla%20linea%20gialla" + "&EXT=mp3&FNAME=&ACC=15679&SceneID=2756155&HTTP_ERR=&cache_flag=3";
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void Gruppo1()
        {
            pictureBox16.Image = Image.FromFile(".\\Grafiche\\circuito bloccato.png");
            pictureBox11.Image = Image.FromFile(".\\Grafiche\\circuito bloccato.png");
            pictureBox12.Image = Image.FromFile(".\\Grafiche\\circuito bloccato.png");
            pictureBox13.Image = Image.FromFile(".\\Grafiche\\circuito bloccato.png");
            pictureBox14.Image = Image.FromFile(".\\Grafiche\\circuito bloccato.png");
            pictureBox17.Image = Image.FromFile(".\\Grafiche\\circuito bloccato.png");
            pictureBox21.Image = Image.FromFile(".\\Grafiche\\circuito bloccato.png");
            pictureBox23.Image = Image.FromFile(".\\Grafiche\\circuito bloccato.png");
        }

        private void Gruppo2()
        {
            pictureBox3.Image = Image.FromFile(".\\Grafiche\\circuito bloccato.png");
            pictureBox4.Image = Image.FromFile(".\\Grafiche\\circuito bloccato.png");
            pictureBox9.Image = Image.FromFile(".\\Grafiche\\circuito bloccato.png");
            pictureBox10.Image = Image.FromFile(".\\Grafiche\\circuito bloccato.png");
        }

        private void Gruppo3()
        {
            pictureBox5.Image = Image.FromFile(".\\Grafiche\\circuito bloccato.png");
            pictureBox6.Image = Image.FromFile(".\\Grafiche\\circuito bloccato.png");
            pictureBox7.Image = Image.FromFile(".\\Grafiche\\circuito bloccato.png");
            pictureBox8.Image = Image.FromFile(".\\Grafiche\\circuito bloccato.png");
        }

        private void Itinerario(string puntoA, string puntoB)
        {
            if(puntoA=="Bologna" && puntoB == "Rimini")
            {
                if(deviata1==0 && deviata2==0)
                {
                    pictureBox27.Image = Image.FromFile(".\\Grafiche\\circuito bloccato.png");
                    pictureBox22.Image = Image.FromFile(".\\Grafiche\\circuito bloccato.png");
                    Gruppo1();
                    pictureBox26.Image = Image.FromFile(".\\Grafiche\\segnale verde.png");
                    pictureBox25.Image = Image.FromFile(".\\Grafiche\\segnale verde.png");
                    if(comboBox1.Text == "Binario 3")
                    {
                        serialPort1.Write("c");
                    }
                }
                if(deviata1==1 && deviata2==1)
                {
                    pictureBox27.Image = Image.FromFile(".\\Grafiche\\circuito bloccato.png");
                    pictureBox22.Image = Image.FromFile(".\\Grafiche\\circuito bloccato.png");
                    Gruppo2();
                    pictureBox2.Image = Image.FromFile(".\\Grafiche\\circuito bloccato.png");
                    pictureBox19.Image = Image.FromFile(".\\Grafiche\\circuito bloccato.png");
                    pictureBox26.Image = Image.FromFile(".\\Grafiche\\segnale rosso giallo.png");
                    pictureBox30.Image = Image.FromFile(".\\Grafiche\\segnale rosso giallo.png");
                }
                if (deviata1 == 2 && deviata2 == 2)
                {
                    pictureBox27.Image = Image.FromFile(".\\Grafiche\\circuito bloccato.png");
                    pictureBox22.Image = Image.FromFile(".\\Grafiche\\circuito bloccato.png");
                    Gruppo3();
                    pictureBox2.Image = Image.FromFile(".\\Grafiche\\circuito bloccato.png");
                    pictureBox19.Image = Image.FromFile(".\\Grafiche\\circuito bloccato.png");
                    pictureBox26.Image = Image.FromFile(".\\Grafiche\\segnale rosso giallo giallo.png");
                    pictureBox31.Image = Image.FromFile(".\\Grafiche\\segnale_rosso.png");
                }

            }

            if (puntoA == "Rimini" && puntoB == "Bologna")
            {
                if (deviata1 == 0 && deviata2== 0)
                {
                    pictureBox2.Image = Image.FromFile(".\\Grafiche\\circuito bloccato.png");
                    pictureBox19.Image = Image.FromFile(".\\Grafiche\\circuito bloccato.png");
                    pictureBox24.Image = Image.FromFile(".\\Grafiche\\circuito bloccato.png");
                    pictureBox28.Image = Image.FromFile(".\\Grafiche\\circuito bloccato.png");
                    pictureBox32.Image = Image.FromFile(".\\Grafiche\\segnale verde.png");
                    pictureBox29.Image = Image.FromFile(".\\Grafiche\\segnale verde.png");
                    Gruppo2();
                }
                if (deviata1 == 1 && deviata2 == 1)
                {
                    pictureBox2.Image = Image.FromFile(".\\Grafiche\\circuito bloccato.png");
                    pictureBox19.Image = Image.FromFile(".\\Grafiche\\circuito bloccato.png");
                    pictureBox24.Image = Image.FromFile(".\\Grafiche\\circuito bloccato.png");
                    pictureBox28.Image = Image.FromFile(".\\Grafiche\\circuito bloccato.png");
                    pictureBox32.Image = Image.FromFile(".\\Grafiche\\segnale rosso giallo.png");
                    pictureBox33.Image = Image.FromFile(".\\Grafiche\\segnale_rosso.png");
                    Gruppo3();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Text == "Segnale 1")
            {
                pictureBox26.Image = Image.FromFile(".\\Grafiche\\segnale_rosso.png");
                if(comboBox1.Text == "Binario 3")
                {
                    serialPort1.Write("d");
                }
            }

            if (listBox1.Text == "Segnale 2")
            {
                pictureBox25.Image = Image.FromFile(".\\Grafiche\\segnale_rosso.png");
                pictureBox26.Image = Image.FromFile(".\\Grafiche\\segnale giallo.png");
                if (comboBox1.Text == "Binario 3")
                {
                    serialPort1.Write("a");
                }
            }
            if (listBox1.Text == "Segnale 3")
            {
                pictureBox29.Image = Image.FromFile(".\\Grafiche\\segnale_rosso.png");
                pictureBox32.Image = Image.FromFile(".\\Grafiche\\segnale giallo.png");
            }
            if (listBox1.Text == "Segnale 4")
            {
                pictureBox32.Image = Image.FromFile(".\\Grafiche\\segnale_rosso.png");
            }
            if (listBox1.Text == "Segnale 5")
            {
                pictureBox31.Image = Image.FromFile(".\\Grafiche\\segnale_rosso.png");
            }
            if (listBox1.Text == "Segnale 6")
            {
                pictureBox35.Image = Image.FromFile(".\\Grafiche\\segnale_rosso.png");
            }
            if (listBox1.Text == "Segnale 7")
            {
                pictureBox30.Image = Image.FromFile(".\\Grafiche\\segnale_rosso.png");
            }
            if (listBox1.Text == "Segnale 8")
            {
                pictureBox33.Image = Image.FromFile(".\\Grafiche\\segnale_rosso.png");
            }
        }

        int listcount = 0;
        private void lista(string NumeroECategoria, string PuntoA, string PuntoB, string orario)
        {
            if(listcount==0)
            {
                label4.Text = NumeroECategoria + " " + PuntoA + " - " + PuntoB + " " + orario;
                listcount++;
            }
            else if (listcount == 1)
            {
                label5.Text = NumeroECategoria + " " + PuntoA + " - " + PuntoB + " " + orario;
                listcount++;
            }

            else if (listcount == 2)
            {
                label6.Text = NumeroECategoria + " " + PuntoA + " - " + PuntoB + " " + orario;
                listcount = 0;
            }
        }

        public bool trenoPartito = false;

        private void orari(string orario)
        {
            if(orario1=="V")
            {
                orario1 = orario;
            }
            else if(orario2=="V")
            {
                orario2 = orario;
            }
            else
            {
                orario3 = orario;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            lista(textBox4.Text, textBox1.Text, textBox2.Text, textBox3.Text);
            Itinerario(textBox1.Text, textBox2.Text);
            wplayer.URL = ".\\EffettiSonori\\firsttype.mp3";
            wplayer.controls.play();
            wplayer.URL = annuncio(textBox4.Text, textBox5.Text, textBox6.Text, textBox3.Text, textBox7.Text);
            wplayer.controls.play();
            orari(textBox3.Text);
            
            

            /*inerario(textBox1.Text, textBox2.Text);
            lista(textBox4.Text, textBox1.Text, textBox2.Text, textBox3.Text);
            string strCmdText;
            strCmdText = "microsoft-edge:" + annuncio(textBox4.Text, textBox5.Text, textBox6.Text, textBox3.Text, textBox7.Text);
            System.Diagnostics.Process.Start(".\\EffettiSonori\\firsttype.mp3");
            System.Diagnostics.Process.Start(strCmdText); */


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (deviata1 + 1 == 3)
            {
                deviata1 = 0;
            }
            else
            {
                deviata1++;
            }  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (deviata2 + 1 == 3)
            {
                deviata2 = 0;
            }
            else
            {
                deviata2++;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.Text == "Segnale 1")
            {
                pictureBox26.Image = Image.FromFile(".\\Grafiche\\segnale giallo.png");
            }

            if (listBox1.Text == "Segnale 2")
            {
                pictureBox25.Image = Image.FromFile(".\\Grafiche\\segnale giallo.png");
                pictureBox26.Image = Image.FromFile(".\\Grafiche\\segnale verde.png");
            }
            if (listBox1.Text == "Segnale 3")
            {
                pictureBox29.Image = Image.FromFile(".\\Grafiche\\segnale giallo.png");
                pictureBox32.Image = Image.FromFile(".\\Grafiche\\segnale verde.png");
            }
            if (listBox1.Text == "Segnale 4")
            {
                pictureBox32.Image = Image.FromFile(".\\Grafiche\\segnale giallo.png");
            }
            if (listBox1.Text == "Segnale 5")
            {
                pictureBox31.Image = Image.FromFile(".\\Grafiche\\segnale giallo.png");
            }
            if (listBox1.Text == "Segnale 6")
            {
                pictureBox35.Image = Image.FromFile(".\\Grafiche\\segnale giallo.png");
            }
            if (listBox1.Text == "Segnale 7")
            {
                pictureBox30.Image = Image.FromFile(".\\Grafiche\\segnale giallo.png");
            }
            if (listBox1.Text == "Segnale 8")
            {
                pictureBox33.Image = Image.FromFile(".\\Grafiche\\segnale giallo.png");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.Text == "Segnale 1")
            {
                pictureBox26.Image = Image.FromFile(".\\Grafiche\\segnale verde.png");
            }

            if (listBox1.Text == "Segnale 2")
            {
                pictureBox25.Image = Image.FromFile(".\\Grafiche\\segnale verde.png");
                pictureBox26.Image = Image.FromFile(".\\Grafiche\\segnale verde.png");
            }
            if (listBox1.Text == "Segnale 3")
            {
                pictureBox29.Image = Image.FromFile(".\\Grafiche\\segnale verde.png");
                pictureBox32.Image = Image.FromFile(".\\Grafiche\\segnale verde.png");
            }
            if (listBox1.Text == "Segnale 4")
            {
                pictureBox32.Image = Image.FromFile(".\\Grafiche\\segnale verde.png");
            }
            if (listBox1.Text == "Segnale 5")
            {
                pictureBox31.Image = Image.FromFile(".\\Grafiche\\segnale verde.png");
            }
            if (listBox1.Text == "Segnale 6")
            {
                pictureBox35.Image = Image.FromFile(".\\Grafiche\\segnale verde.png");
            }
            if (listBox1.Text == "Segnale 7")
            {
                pictureBox30.Image = Image.FromFile(".\\Grafiche\\segnale verde.png");
            }
            if (listBox1.Text == "Segnale 8")
            {
                pictureBox33.Image = Image.FromFile(".\\Grafiche\\segnale verde.png");
            }
        }

        private void Form5_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            serialPort1.Close();
        }

        public void circuitoOccupato(int j)
        {

            if (textBox1.Text == "Bologna")
            {
                if (deviata1 == 0 && deviata2 == 0)
                {
                    if (trenoPartito == true && j == 0)
                    {
                        trenoPartito = false;
                        pictureBox17.Image = Image.FromFile(".\\Grafiche\\circuito libero senza deviatoio.png");
                        pictureBox21.Image = Image.FromFile(".\\Grafiche\\circuito libero senza deviatoio.png");
                        pictureBox23.Image = Image.FromFile(".\\Grafiche\\circuito libero senza deviatoio.png");
                        pictureBox22.Image = Image.FromFile(".\\Grafiche\\circuito libero senza deviatoio.png");
                        orario1 = orario2;
                        orario2 = orario3;
                        orario3 = "V";
                    }
                    else if (j == 1)
                    {

                        pictureBox27.Image = Image.FromFile(".\\Grafiche\\circuito occupato.png");
                        pictureBox16.Image = Image.FromFile(".\\Grafiche\\circuito occupato.png");
                        pictureBox11.Image = Image.FromFile(".\\Grafiche\\circuito occupato.png");
                        pictureBox12.Image = Image.FromFile(".\\Grafiche\\circuito occupato.png");
                        pictureBox13.Image = Image.FromFile(".\\Grafiche\\circuito occupato.png");
                        pictureBox14.Image = Image.FromFile(".\\Grafiche\\circuito occupato.png");
                        
                        pictureBox26.Image = Image.FromFile(".\\Grafiche\\segnale_rosso.png");
                        if(comboBox1.Text == "Binario 3")
                        {
                            serialPort1.Write("d");
                        }
                        
                    }
                    else
                    {

                        pictureBox17.Image = Image.FromFile(".\\Grafiche\\circuito occupato.png");
                        pictureBox21.Image = Image.FromFile(".\\Grafiche\\circuito occupato.png");
                        pictureBox23.Image = Image.FromFile(".\\Grafiche\\circuito occupato.png");
                        pictureBox22.Image = Image.FromFile(".\\Grafiche\\circuito occupato.png");
                        pictureBox25.Image = Image.FromFile(".\\Grafiche\\segnale_rosso.png");
                        pictureBox26.Image = Image.FromFile(".\\Grafiche\\segnale giallo.png");

                        pictureBox27.Image = Image.FromFile(".\\Grafiche\\circuito libero senza deviatoio.png");
                        pictureBox16.Image = Image.FromFile(".\\Grafiche\\circuito libero senza deviatoio.png");
                        pictureBox11.Image = Image.FromFile(".\\Grafiche\\circuito libero senza deviatoio.png");
                        pictureBox12.Image = Image.FromFile(".\\Grafiche\\circuito libero senza deviatoio.png");
                        pictureBox13.Image = Image.FromFile(".\\Grafiche\\circuito libero senza deviatoio.png");
                        pictureBox14.Image = Image.FromFile(".\\Grafiche\\circuito libero senza deviatoio.png");
                        trenoPartito = true;
                        if(comboBox1.Text == "Binario 3")
                        {
                            serialPort1.Write("a");
                        }
                        
                    }
                }
                else if(deviata1==2 && deviata2==2)
                {
                    if(j==0 && trenoPartito==true)
                    {
                        pictureBox5.Image = Image.FromFile(".\\Grafiche\\circuito libero senza deviatoio.png");
                        pictureBox6.Image = Image.FromFile(".\\Grafiche\\circuito libero senza deviatoio.png");
                        pictureBox7.Image = Image.FromFile(".\\Grafiche\\circuito libero senza deviatoio.png");

                        pictureBox8.Image = Image.FromFile(".\\Grafiche\\circuito occupato.png");
                        pictureBox19.Image = Image.FromFile(".\\Grafiche\\circuito occupato.png");
                        pictureBox22.Image = Image.FromFile(".\\Grafiche\\circuito occupato.png");
                        
                        trenoPartito = false;
                    }
                    if(j==1)
                    {
                        pictureBox27.Image = Image.FromFile(".\\Grafiche\\circuito occupato.png");
                        pictureBox2.Image = Image.FromFile(".\\Grafiche\\circuito occupato.png");
                        pictureBox26.Image = Image.FromFile(".\\Grafiche\\segnale_rosso.png");
                        
                    }
                    if(j==2)
                    {
                        pictureBox27.Image = Image.FromFile(".\\Grafiche\\circuito libero senza deviatoio.png");
                        pictureBox2.Image = Image.FromFile(".\\Grafiche\\circuito libero senza deviatoio.png");
                        pictureBox5.Image = Image.FromFile(".\\Grafiche\\circuito occupato.png");
                        pictureBox6.Image = Image.FromFile(".\\Grafiche\\circuito occupato.png");
                        trenoPartito = true;
                        pictureBox7.Image = Image.FromFile(".\\Grafiche\\circuito occupato.png");
                        
                    }

                }
            }
        }
        
    

        bool panel = false;
        private void button7_Click(object sender, EventArgs e)
        {
            if (panel == false)
            {
                panel1.Show();
                panel = true;
            }
            else
            {
                panel1.Hide();
                panel = false;
            }
        }


        bool segnaliIllegali= false;
        bool timer = false;
        private void button7_Click_1(object sender, EventArgs e)
        {
            if (timer == false)
            {
                timer1.Start();
                timer = true;
            }
            else
            {
                timer1.Stop();
                timer = false;
            }
        }
        private void iTINERARIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panel == false)
            {
                panel1.Show();
                panel = true;
            }
            else
            {
                panel1.Hide();
                panel = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (segnaliIllegali == false)
            {
                pictureBox34.Show();
                pictureBox36.Show();
                pictureBox35.Show();
                pictureBox30.Show();
                segnaliIllegali = true;
            }
            else
            {
                pictureBox34.Hide();
                pictureBox36.Hide();
                pictureBox35.Hide();
                pictureBox30.Hide();
                segnaliIllegali = false;
            }
        }
        int i = 0;
        private void button8_Click(object sender, EventArgs e)
        {
            
            i++;
            if(i==3)
            {
                i = 0;
            }
            circuitoOccupato(i);
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
