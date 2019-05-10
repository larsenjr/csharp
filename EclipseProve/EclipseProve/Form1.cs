using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EclipseProve
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonSirkel_Click(object sender, EventArgs e)
        {
            try
            {
                // Definerer r1 som radius 1, r2 som radius 2 og areal som doubles. Bruker double for å få desimalverdier. 
                    double r1, r2, areal;
                // Konverterer verdiene i r1 og r2 til tekstboksene til double.
                    r1 = Convert.ToDouble(textBoxR1.Text);
                    r2 = Convert.ToDouble(textBoxR2.Text);
                // Beregner verdiene som puttes inn i tekstboksene og ganger med Math.PI for å få riktig svar.
                    areal = r1 * r2 * Math.PI;
                // Skriver ut "svar" eller verdi i textboxAreal og konverterer verdien til string. 
                    textBoxAreal.Text = Convert.ToString(areal);
                // Sjekker om begge er true og skriver ut tallverdien til tekst. 
                if (double.TryParse(textBoxR1.Text, out r1) && double.TryParse(textBoxR2.Text, out r2))
                {
                    textBoxAreal.Text = (Math.PI * (r1 * r2)).ToString();
                }
                // Hvis den ikke kan konvertere R1 og R2 setter den boksen blank og skriver ut "Ugyldig tallverdi". 
                else
                {
                    textBoxAreal.Text = "";
                }
            }
            // Format slik at det kan konverteres til double. 
                catch (FormatException ex)
                {
                    MessageBox.Show("Ugyldig tallverdi");
                }
            // kan ikke være tomme verdier. 
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("Verdien kan ikke være null!" + ex.GetType());
                }
            // Generell exception for generelle feilmeldinger. Skriver ut feilmelding i meldingsboks. 
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

            Console.ReadLine();
        }

        private void ButtonEclipse_Click(object sender, EventArgs e)
        {
            try
            {
                // Definerer r1 som radius 1, r2 som radius 2 og areal som doubles. Bruker double for å få desimalverdier. 
                    double r1, r2, areal;
                // Konverterer verdiene i r1 og r2 til tekstboksene til double.
                    r1 = Convert.ToDouble(textBoxR1.Text);
                    r2 = Convert.ToDouble(textBoxR2.Text);
                // Beregner verdiene som puttes inn i tekstboksene og ganger med Math.PI for å få riktig svar.
                    areal = Math.PI * r1 * r1;
                // Skriver ut "svar" eller verdi i textboxAreal og konverterer verdien til string. 
                    textBoxAreal.Text = Convert.ToString(areal);

                // Sjekker om begge er "true" og skriver ut tallverdien til tekst. 
                    if (double.TryParse(textBoxR1.Text, out r1) && double.TryParse(textBoxR2.Text, out r2))
                    {
                        textBoxAreal.Text = (Math.PI * (r1 * r2)).ToString();
                    }
                // Hvis den ikke kan konvertere R1 og R2 setter den boksen blank og skriver ut Ugyldig tallverdi. 
                    else
                    {
                        textBoxAreal.Text = "";
                    }

            }
            // Format slik at det kan konverteres til double. 
            catch (FormatException ex)
            {
                MessageBox.Show("Ugyldig tallverdi");
            }
            // kan ikke være tomme verdier. 
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Verdien kan ikke være null \n" + ex.GetType());
            }
            // Generell exception for generelle feilmeldinger. Skriver ut feilmelding i meldingsboks.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
