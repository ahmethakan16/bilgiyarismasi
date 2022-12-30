using System.Security.Cryptography.X509Certificates;

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogruno = 0, yanlissayisi = 0;

        private void buttonB_Click(object sender, EventArgs e)
        {
            buttonA.Enabled= false;
            buttonB.Enabled= false; 
            buttonC.Enabled= false;
            buttonD.Enabled= false;
            buttonNext.Enabled = true;
            label8.Text = buttonB.Text;
            if(label7.Text==label8.Text)
            {
                dogruno++;
                label8.Text = dogruno.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlissayisi++;
                label6.Text= yanlissayisi.ToString();
                pictureBox2.Visible= true;

            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonNext.Enabled = true;
            label8.Text = buttonC.Text;
            if (label7.Text == label8.Text)
            {
                dogruno++;
                label5.Text = dogruno.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlissayisi++;
                label6.Text = yanlissayisi.ToString();
                pictureBox2.Visible = true;

            }
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonNext.Enabled = true;
            label8.Text = buttonD.Text;
            if (label7.Text == label8.Text)
            {
                dogruno++;
                label5.Text = dogruno.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlissayisi++;
                label6.Text = yanlissayisi.ToString();
                pictureBox2.Visible = true;

            }
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            buttonA.Enabled= false;
            buttonB.Enabled= false;
            buttonC.Enabled= false;
            buttonD.Enabled= false;
            buttonNext.Enabled = true;
            label8.Text = buttonA.Text;
            if(label7.Text==label8.Text)
            {
                dogruno++;
                label5.Text=dogruno.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlissayisi++;
                label6.Text=yanlissayisi.ToString();
                pictureBox2.Visible = true;

            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = true;
            buttonB.Enabled= true;
            buttonC.Enabled= true;
            buttonD.Enabled= true;
            buttonNext.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible=false;
            soruno++;
            label4.Text= soruno.ToString();
            if(soruno==1)
            {
                richTextBox1.Text = "Halifelik Ne Zaman Kald�r�ld�?";
                buttonA.Text = "1924";
                buttonB.Text = "1923";
                buttonC.Text = "1922";
                buttonD.Text = "1921";
                label7.Text = "1924";
                
            }
            if(soruno==2)
            {
                richTextBox1.Text = "Cumhuriyet Ka� Y�l�nda Kurulmu�tur?";
                buttonA.Text = "1923";
                buttonB.Text = "1920";
                buttonC.Text = "1921";
                buttonD.Text = "1922";
                label7.Text = "1923";
            }
            if(soruno==3)
            {
                richTextBox1.Text = "Saltanat Ka� Y�l�nda Kald�r�lm��t�r?";
                buttonA.Text = "1921";
                buttonB.Text = "1923";
                buttonC.Text = "1924";
                buttonD.Text = "1922";
                label7.Text = "1922";
            }
            if(soruno==4)
            {
                richTextBox1.Text = "Atat�rk Ne Zaman Samsuna ��km��t�r?";
                buttonA.Text = "19 May�s 1919";
                buttonB.Text = "19 May�s 1920";
                buttonC.Text = "19 May�s 1921";
                buttonD.Text = "19 May�s 1922";
                label7.Text = "19 May�s 1919";
                buttonNext.Text = "Sonu�lar";

            }
            if(soruno==5)
            {
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;    
                buttonD.Enabled = false;
                buttonNext.Enabled = false;
                MessageBox.Show("Do�ru:  " + dogruno +"\n"+ "Yanl��:  " + yanlissayisi);
            }
        }
    }
}