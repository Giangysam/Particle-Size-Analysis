using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SoluzioneTest
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
          
           
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void AggiornaDati()
        {
            decimal somma =
                numericUpDown1.Value +
                numericUpDown2.Value +
                numericUpDown3.Value +
                numericUpDown4.Value +
                numericUpDown5.Value +
                numericUpDown6.Value;
            label9.Text = somma.ToString("0");

            if (somma > 0)
            {
                decimal totale = decimal.Parse(label9.Text); // Per convertire il testo in numero
                decimal rapporto1 = ((numericUpDown1.Value / totale) * 100);
                decimal rapporto2 = ((numericUpDown2.Value / totale) * 100);
                decimal rapporto3 = ((numericUpDown3.Value / totale) * 100);
                decimal rapporto4 = ((numericUpDown4.Value / totale) * 100);
                decimal rapporto5 = ((numericUpDown5.Value / totale) * 100);
                decimal rapporto6 = ((numericUpDown6.Value / totale) * 100);
                label11.Text = rapporto1.ToString("0.00"); // Formatta il risultato 
                label12.Text = rapporto2.ToString("0.00");
                label13.Text = rapporto3.ToString("0.00");
                label19.Text = rapporto4.ToString("0.00");
                label20.Text = rapporto5.ToString("0.00");
                label16.Text = rapporto6.ToString("0.00");
                
                decimal totale_percentuale =
                        rapporto1 +
                        rapporto2 +
                        rapporto3 +
                        rapporto4 +
                        rapporto5 +
                        rapporto6;
                label38.Text = totale_percentuale.ToString("0.00");

                decimal coeff1 = (rapporto1 * 1.2m);
                decimal coeff2 = (rapporto2 * 0.9m);
                decimal coeff3 = (rapporto3 * 0.65m);
                decimal coeff4 = (rapporto4 * 0.4m);
                decimal coeff5 = (rapporto5 * 0.25m);
                decimal coeff6 = (rapporto6 * 0.15m);
                label18.Text = coeff1.ToString("0.00");
                label14.Text = coeff2.ToString("0.00");
                label15.Text = coeff3.ToString("0.00");
                label21.Text = coeff4.ToString("0.00");
                label22.Text = coeff5.ToString("0.00");
                label23.Text = coeff6.ToString("0.00");

                decimal totale_coeff =
                    coeff1 + coeff2 + coeff3 + coeff4 + coeff5 + coeff6;
                label24.Text = totale_coeff.ToString("0.00");
                

            }
            else
            {
                label11.Text = ("0");
                label12.Text = ("0");
                label13.Text = ("0");
                label19.Text = ("0");
                label20.Text = ("0");
                label16.Text = ("0");
                label38.Text = ("0");
                label24.Text = ("0");
            }
        }

        private void Label19_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCalcola_Click(object sender, EventArgs e)
        {
            AggiornaDati();
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            AggiornaDati();
            
        }

        

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }
        private void AzzeraDati()
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
            numericUpDown6.Value = 0;
            label18.Text = ("0");
            label14.Text = ("0");
            label15.Text = ("0");
            label21.Text = ("0");
            label22.Text = ("0");
            label23.Text = ("0");

        }
        private void Button2_Click(object sender, EventArgs e)
        {
           AzzeraDati();
        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }
        
        private void Label38_Click(object sender, EventArgs e)
        {
           
        }
    }
}
