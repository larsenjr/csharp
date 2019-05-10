using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oppgave2AlderFarge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBoxAlder_TextChanged(object sender, EventArgs e)
        {

        }
        // Method - KalkulerAlder
        public int KalkulerAlder (int AarsTall)
        {
            // Konverterer dagens årstall
            return Convert.ToInt32(DateTime.Today.Year) - AarsTall;
        }

        // Method HentFarge.
        private Color HentFarge(int alder)
        {

            // Rød farge hvis de er under 18 år. 17 år eller yngre
            if (alder <= 17)
            {
                return Color.Red;
            }

            // Hvis alderen er mellom 18 og 29 år. 
            if (alder >= 18 && alder <= 29)
            {
                return Color.Yellow;
            }

            // Hvis alderen er mellom 30 og 69 år. 
            if (alder >= 30 && alder <= 69)
            {
                return Color.Green;
            }

            // Hvis alderen er mellom 70 og 149 returner den blå farge. 
            if (alder >= 70 && alder <= 149)
            {
                return Color.Blue;
            }

            // Alt annet. Jeg satte verdien til 150, men det er usannsynlig hvis man tenker på år.
            return Color.Black;

        }
        
        private void ButtonVisAlderOgFarge_Click(object sender, EventArgs e)
        {
            // Definerer string som textboxfodselsAar
            string TextFodselsAar = textBoxFodselsAar.Text;
            // Definerer fodselsAar til 0. 
            int fodselsAar = 0;

            try
            {
                fodselsAar = int.Parse(TextFodselsAar);
            }
            // Format er feil. Skriver ut ugyldig tallverdi og hvilken feiltype det kommer fram. 
                catch (FormatException ex)
                {
                    MessageBox.Show("Ugyldig tallverdi \n" + ex.GetType());
                }
            // Kan ikke være tomme verdier
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("Det må være en verdi! \n" + ex.GetType());
                }
            // Generell catch for feilmeldinger. 
                catch (Exception ex)
                {
                    MessageBox.Show("En feil oppstod, prøv igjen \n" + ex.GetType());
                }
            // Definerer metoden KalkulerAlder som er over samtidig man konverterer textboxAlder til string og textboxfarge til farge.
            // Fargen endres når alderen kalkuleres med KalkulerAlder
            int alder = KalkulerAlder(fodselsAar);
            textBoxAlder.Text = alder.ToString();
            textBoxFarge.BackColor = HentFarge(alder);
        }
    }

}
