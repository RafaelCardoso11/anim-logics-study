using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KCLEAN
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            hideShow_lateral();
            efeitoImagemOFF();
            efeito_Boxlimpeza.Visible = false;
            efeito_BoxHD.Visible = false;
        }
        private void hideShow_lateral()
        {
            panelShow_limpeza.Visible = false;
            panelShow_hd.Visible = false;
            panelShow_driver.Visible = false;
            panelShow_net.Visible = false;
            panelShow_Booster.Visible = false;

        }
        private void efeitoImagemOFF()
        {
            efeito_Boxlimpeza.Visible = false;
            efeito_BoxHD.Visible = false;
            efeito_BoxInternet.Visible = false;
            efeito_boxDrivers.Visible = false;
            efeito_BoxBooster.Visible = false;
        }
        private void panel6_MouseHover(object sender, EventArgs e) // PRIMEIRO LUGAR (LIMPEZA)
        {
            hideShow_lateral();
            efeitoImagemOFF();
            efeito_Boxlimpeza.Visible = true;
            panelShow_limpeza.Visible = true;

        }
        private void panel24_MouseHover(object sender, EventArgs e) // SEGUNDO LUGAR (HD)
        {
            efeitoImagemOFF();
            hideShow_lateral();
            efeito_BoxHD.Visible = true;
            panelShow_hd.Visible = true;
        }
        private void panel27_MouseHover(object sender, EventArgs e) // TERCEIRO LUGAR (BOOSTER)
        {
            efeitoImagemOFF();
            hideShow_lateral();
            efeito_BoxBooster.Visible = true;
            panelShow_Booster.Visible = true;
        }

        private void panel34_MouseHover(object sender, EventArgs e) // QUARTO LUGAR (INTERNET)
        {
            efeitoImagemOFF();
            hideShow_lateral();
            efeito_BoxInternet.Visible = true;
            panelShow_net.Visible = true;
        }

        private void panel41_MouseHover(object sender, EventArgs e) // QUINTO LUGAR (DRIVERS)
        {
            efeitoImagemOFF();
            hideShow_lateral();
            efeito_boxDrivers.Visible = true;
            panelShow_driver.Visible = true;
        }
        private void pictureBox1_MouseClick_1(object sender, MouseEventArgs e) // MODO GAMER
        {
            Form2 f = new Form2();
           
            this.Hide();
            f.Closed += (s, args) => this.Close();
            f.Show();
         
           
        }

        private void pictureBox2_Click(object sender, EventArgs e) // MAXIMIZAR
        {

            windowsSize();
        }

        private void pictureBox3_Click(object sender, EventArgs e) //MINIMIZAR
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void windowsSize() //MAXIMIZAR
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

       
      
        private void panel11_MouseHover(object sender, EventArgs e)  
        {

            if (borderLateral_limpeza1.BackColor == Color.FromArgb(255, 198, 0))
            {
                this.borderLateral_limpeza1.BackColor = Color.FromArgb(255, 198, 0);

            }
            else
            {
                this.borderLateral_limpeza1.BackColor = Color.FromArgb(60, 60, 60);
                this.panel11.BackColor = Color.FromArgb(60, 60, 60);
            }

        }
       
        private void panel11_MouseLeave(object sender, EventArgs e)
        {
            
            if (borderLateral_limpeza1.BackColor == Color.FromArgb(255, 198, 0))
            {
                this.borderLateral_limpeza1.BackColor = Color.FromArgb(255, 198, 0);
                this.panel11.BackColor = Color.FromArgb(60, 60, 60);
            }
            else
            {
                this.borderLateral_limpeza1.BackColor = Color.FromArgb(50, 50, 50);
                this.panel11.BackColor = Color.FromArgb(50, 50, 50);

            }

        }

        private void panel13_MouseHover(object sender, EventArgs e)
        {
            if (borderLateral_limpeza2.BackColor == Color.FromArgb(255, 198, 0))
            {
                this.borderLateral_limpeza2.BackColor = Color.FromArgb(255, 198, 0);

            }
            else 
            {
                this.borderLateral_limpeza2.BackColor = Color.FromArgb(60, 60, 60);
                this.panel13.BackColor = Color.FromArgb(60, 60, 60);
            }
          
           
        }

        private void panel13_MouseLeave(object sender, EventArgs e)
        {
            if (borderLateral_limpeza2.BackColor == Color.FromArgb(255, 198, 0))
            {
                this.borderLateral_limpeza2.BackColor = Color.FromArgb(255, 198, 0);
                this.panel13.BackColor = Color.FromArgb(60, 60, 60);

            }
            else
            {
                this.borderLateral_limpeza2.BackColor = Color.FromArgb(50, 50, 50);
                this.panel13.BackColor = Color.FromArgb(50, 50, 50);

            }
         
        }

       

      
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox1.BackColor = Color.Red;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox1.BackColor = Color.FromArgb(25, 25, 25);
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox2.BackColor = Color.FromArgb(70, 70, 70);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox2.BackColor = Color.FromArgb(25, 25, 25);
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox3.BackColor = Color.FromArgb(70, 70, 70);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox3.BackColor = Color.FromArgb(25, 25, 25); 
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox5.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox5.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox9.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox9.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox7.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox7.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox6.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox6.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/kodarbr/");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCH8KLYSlSruUmuNK_axvO_w");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.kodarbr.com/");

        }
      
            
            private void panel11_MouseClick(object sender, MouseEventArgs e)
            {


                this.panel13.BackColor = Color.FromArgb(50, 50, 50);
                this.panel11.BackColor = Color.FromArgb(60, 60, 60);
                this.borderLateral_driver2.BackColor = Color.FromArgb(50, 50, 50);
                this.borderLateral_driver1.BackColor = Color.FromArgb(50, 50, 50);
                this.borderLateral_limpeza2.BackColor = Color.FromArgb(50, 50, 50);
                this.borderLateral_limpeza1.BackColor = Color.FromArgb(255, 198, 0);
            }

            private void panel13_MouseClick(object sender, MouseEventArgs e)
            {


                this.panel11.BackColor = Color.FromArgb(50, 50, 50);
                this.panel13.BackColor = Color.FromArgb(60, 60, 60);
                this.borderLateral_driver1.BackColor = Color.FromArgb(50, 50, 50);
                this.borderLateral_driver2.BackColor = Color.FromArgb(50, 50, 50);
                this.borderLateral_limpeza1.BackColor = Color.FromArgb(50, 50, 50);
                this.borderLateral_limpeza2.BackColor = Color.FromArgb(255, 198, 0);
            }
            private void panel35_MouseHover(object sender, EventArgs e)
            {
                this.panel35.BackColor = Color.FromArgb(60, 60, 60);
                this.borderLateral_limpeza3.BackColor = Color.FromArgb(60, 60, 60);


            }

            private void panel35_MouseLeave(object sender, EventArgs e)
            {
                this.panel35.BackColor = Color.FromArgb(50, 50, 50);
                this.borderLateral_limpeza3.BackColor = Color.FromArgb(50, 50, 50);
            }

            private void panel35_MouseClick(object sender, MouseEventArgs e)
            {
                this.panel35.BackColor = Color.FromArgb(60, 60, 60);
                this.borderLateral_limpeza3.BackColor = Color.FromArgb(60, 60, 60);
                this.borderLateral_limpeza3.BackColor = Color.FromArgb(255, 198, 0);
            }
        
       
        
        
            private void panel22_MouseHover(object sender, EventArgs e)
            {
                if (borderLateral_driver1.BackColor == Color.FromArgb(255, 198, 0))
                {
                    borderLateral_driver1.BackColor = Color.FromArgb(255, 198, 0);

                }
                else
                {
                    borderLateral_driver1.BackColor = Color.FromArgb(60, 60, 60);
                    this.panel22.BackColor = Color.FromArgb(60, 60, 60);
                }
            }

            private void panel22_MouseLeave(object sender, EventArgs e)
            {
                if (borderLateral_driver1.BackColor == Color.FromArgb(255, 198, 0))
                {
                    this.borderLateral_driver1.BackColor = Color.FromArgb(255, 198, 0);
                    this.panel22.BackColor = Color.FromArgb(60, 60, 60);
                }
                else
                {
                    this.borderLateral_driver1.BackColor = Color.FromArgb(50, 50, 50);
                    this.panel22.BackColor = Color.FromArgb(50, 50, 50);
                }

            }

            private void panel10_MouseHover(object sender, EventArgs e)
            {
                if (borderLateral_driver2.BackColor == Color.FromArgb(255, 198, 0))
                {
                    this.borderLateral_driver2.BackColor = Color.FromArgb(255, 198, 0);

                }
                else
                {
                    this.borderLateral_driver2.BackColor = Color.FromArgb(60, 60, 60);
                    this.panel10.BackColor = Color.FromArgb(60, 60, 60);
                }

            }

            private void panel10_MouseLeave(object sender, EventArgs e)
            {
                if (borderLateral_driver2.BackColor == Color.FromArgb(255, 198, 0))
                {
                    this.borderLateral_driver2.BackColor = Color.FromArgb(255, 198, 0);
                    this.panel10.BackColor = Color.FromArgb(60, 60, 60);
                }
                else
                {
                    this.borderLateral_driver2.BackColor = Color.FromArgb(50, 50, 50);
                    this.panel10.BackColor = Color.FromArgb(50, 50, 50);
                }
            }

            private void panel22_MouseClick(object sender, MouseEventArgs e)
            {
                this.panel10.BackColor = Color.FromArgb(50, 50, 50);
                this.panel22.BackColor = Color.FromArgb(60, 60, 60);
                this.borderLateral_limpeza1.BackColor = Color.FromArgb(50, 50, 50);
                this.borderLateral_limpeza2.BackColor = Color.FromArgb(50, 50, 50);
                this.borderLateral_driver2.BackColor = Color.FromArgb(50, 50, 50);
                this.borderLateral_driver1.BackColor = Color.FromArgb(255, 198, 0);
            }

            private void panel10_MouseClick(object sender, MouseEventArgs e)
            {
                this.panel22.BackColor = Color.FromArgb(50, 50, 50);
                this.panel10.BackColor = Color.FromArgb(60, 60, 60);
                this.borderLateral_limpeza1.BackColor = Color.FromArgb(50, 50, 50);
                this.borderLateral_limpeza2.BackColor = Color.FromArgb(50, 50, 50);
                this.borderLateral_driver1.BackColor = Color.FromArgb(50, 50, 50);
                this.borderLateral_driver2.BackColor = Color.FromArgb(255, 198, 0);
            }

        private void panel25_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel15_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel25_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void panel15_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void panel32_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel29_MouseHover(object sender, EventArgs e)
        {

        }
        private void panel32_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void panel29_MouseClick(object sender, MouseEventArgs e)
        {

        }

       

        private void panel36_MouseHover(object sender, EventArgs e)
        {

        }
        private void panel37_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel37_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void panel36_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
