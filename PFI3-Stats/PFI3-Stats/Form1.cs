using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFI3_Stats
{
    public partial class Form1 : Form
    {
        double YMax = 5.0;
        public Form1()
        {
            InitializeComponent();
            Calculf1();
        }

        #region Calcul
        private void Calculf1()
        {

            //Estimateur ponctuel de pi
            int NbPointsDedans = 0;
            Random r = new Random();
            for (int i = 0; i < 10000; i++)
            {
                double x = 11.0 * r.NextDouble();
                double y = YMax * r.NextDouble();
                double z = Math.Pow(x,2.0) - (16.0*x) + 63.0;
                double Formule;
                if (z > 0)
                    Formule = -Math.Pow(z, 1.0 / 3.0) + 4.0;
                else
                    Formule = Math.Pow(Math.Abs(z), 1.0 / 3.0) + 4.0;
                if (y <= Formule && x >= float.Parse(TB_a.Text) && x <= float.Parse(TB_b.Text))
                {
                    NbPointsDedans++;
                }
            }
            double Pi = NbPointsDedans /10000.0;
            TB_Pi.Text = (Pi).ToString();

            //Aire 
            double Zab = 1.96;
            double ME = Math.Sqrt(Pi * (1.0 - Pi)/100.0);
            TB_Aire.Text = 11*YMax*Pi + " +/- " + (Zab*ME).ToString();
        } 
        private void Calculf2()
        {
            int NbPointsDedans = 0;
            Random r = new Random();
            for (int i = 0; i < 10000; i++)
            {
                double x = 11.0 * r.NextDouble();
                double y = YMax * r.NextDouble();

                double Formule = ((3 * Math.Pow((x - 7) / 5, 5)) - (5 * Math.Pow((x - 7) / 5, 3))) + 3;
                if (y <= Formule && x >= float.Parse(TB_a.Text) && x <= float.Parse(TB_b.Text))
                {
                    NbPointsDedans++;
                }
            }
            double Pi = NbPointsDedans / 10000.0;
            TB_Pi.Text = (Pi).ToString();

            //Aire 
            double Zab = 1.96;
            double ME = Math.Sqrt(Pi * (1.0 - Pi)/100.0);
            TB_Aire.Text = 11 * YMax * Pi + " +/- " + (Zab * ME).ToString();
        }
        private void Calculf3()
        {
            int NbPointsDedans = 0;
            Random r = new Random();
            for (int i = 0; i < 10000; i++)
            {
                double x = 11.0 * r.NextDouble();
                double y = YMax * r.NextDouble();

                double Formule = (-(1.0/3.0)*Math.Pow(x-6,2)) + 12;
                if (y <= Formule && x >= float.Parse(TB_a.Text) && x <= float.Parse(TB_b.Text))
                {
                    NbPointsDedans++;
                }
            }
            double Pi = NbPointsDedans / 10000.0;
            TB_Pi.Text = (Pi).ToString();

            //Aire 
            double Zab = 1.96;
            double ME = Math.Sqrt(Pi * (1.0 - Pi)/100.0);
            TB_Aire.Text = 11 * YMax * Pi + " +/- " + (Zab * ME).ToString();
        }
        private void Calculf4()
        {
            int NbPointsDedans = 0;
            Random r = new Random();
            for (int i = 0; i < 10000; i++)
            {
                double x = 11.0 * r.NextDouble();
                double y = YMax * r.NextDouble();

                double Formule = x + Math.Sin(x);
                if (y <= Formule && x >= float.Parse(TB_a.Text) && x <= float.Parse(TB_b.Text))
                {
                    NbPointsDedans++;
                }
            }
            double Pi = NbPointsDedans / 10000.0;
            TB_Pi.Text = (Pi).ToString();

            //Aire 
            double Zab = 1.96;
            double ME = Math.Sqrt(Pi * (1.0 - Pi)/100.0);
            TB_Aire.Text = 11 * YMax * Pi + " +/- " + (Zab * ME).ToString();
        }
        private void Calculf5()
        {

            //Estimateur ponctuel de pi
            int NbPointsDedans = 0;
            Random r = new Random();
            for (int i = 0; i < 10000; i++)
            {
                double x = r.NextDouble() * 11.0;
                double y = r.NextDouble() * YMax;
                double Formule = Math.Cos(x) + 3;

                if (y <= Formule && x >= float.Parse(TB_a.Text) && x <= float.Parse(TB_b.Text))
                {
                    NbPointsDedans++;
                }
            }

            double Pi = NbPointsDedans / 10000.0;
            TB_Pi.Text = (Pi).ToString();

            //Aire 
            double Zab = 1.96;
            double ME = Math.Sqrt(Pi * (1.0 - Pi)/100.0);
            TB_Aire.Text = 11 * YMax * Pi + " +/- " + (Zab * ME).ToString();
        }
#endregion

        #region TextBox
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (TB_a.Text == "")
            {
                TB_a.Text = "0";
            }
            else if (double.Parse(TB_a.Text) > 11)
            {
                TB_a.Text = "11";
            }
        }
        private void TB_b_TextChanged(object sender, EventArgs e)
        {
            if (TB_b.Text == "")
            {
                TB_b.Text = "0";
            }
            else if (double.Parse(TB_b.Text) > 11)
            {
                TB_b.Text = "11";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region RadioButton
        private void RB_f1_CheckedChanged(object sender, EventArgs e)
        {
            YMax = 5;
        }

        private void RB_f2_CheckedChanged(object sender, EventArgs e)
        {
            YMax = 5;
        }

        private void RB_f3_CheckedChanged(object sender, EventArgs e)
        {
            YMax = 12;
        }

        private void RB_f4_CheckedChanged(object sender, EventArgs e)
        {
            YMax = 10;
        }

        private void RB_f5_CheckedChanged(object sender, EventArgs e)
        {
            YMax = 4;
        }
        #endregion

        private void BTN_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Calculer_Click(object sender, EventArgs e)
        {
            if (RB_f1.Checked)
                Calculf1();
            else if (RB_f2.Checked)
                Calculf2();
            else if (RB_f3.Checked)
                Calculf3();
            else if (RB_f4.Checked)
                Calculf4();
            else if (RB_f5.Checked)
                Calculf5();
        }
    }
}
