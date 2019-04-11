using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textInkMva_TextChanged(object sender, EventArgs e)
        {
            double incVat;
            string txtincVat = textInkMva.Text;

            try
            {
                incVat = Convert.ToDouble(txtincVat);

                double exVat = incVat / 1.25;
                textExVat.Text = exVat.ToString();
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Verdien er 0! \n " + ex.GetType());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Du har skrevet inn tekst! \n" + ex.GetType());
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            /**if (double.TryParse(textInkMva.Text, out incVat))
            {
                double exVat = (incVat / 125) * 100;
                textExVat.Text = exVat.ToString();
            }*/

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textExVat_TextChanged(object sender, EventArgs e)
        {
            //textInkMva.Text = Convert.ToString(Convert.ToDouble(textExVat.Text) * 1.25);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcU_Click(object sender, EventArgs e)
        {
            double r, i, u;
            r = Convert.ToDouble(cboR.Text);
            i = Convert.ToDouble(textI.Text);
            u = r * i;
            txtU.Text = Convert.ToString(u);
        }

        private void txtU_TextChanged(object sender, EventArgs e)
        {
            double r, i, u;
            string txtUtext = txtU.Text;
            if (double.TryParse(cboR.Text, out r) && double.TryParse(textI.Text, out i))
            {
                u = r * i;
                txtU.Text = u.ToString();
            }
        }
        private void cboR_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcVo2Max_Click(object sender, EventArgs e)
        {
            double val12, voMax;
            val12 = Convert.ToDouble(txtDistance.Text);
            voMax = (val12 - 504.9) / 44.73;
            txtCooper.Text = Convert.ToString(voMax);
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            int Total, minutes, sec;
            Total = Convert.ToInt32(txtTotalSec.Text);
            minutes = Total / 60;
            sec = Total % 60;
            txtMinutes.Text = Convert.ToString(minutes);
            txtSec.Text = Convert.ToString(sec);
        }

        private void btnBmi_Click(object sender, EventArgs e)
        {
            double height, weight, bmi;
            height = Convert.ToDouble(txtHeight.Text);
            weight = Convert.ToDouble(txtWeight.Text);
            bmi = weight / (height * height);
            txtBmi.Text = Convert.ToString(bmi);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] ByteArray = new byte[] {1, 2, 4, 8, 16, 32, 64, 128};
            var Index = textBoxIndex.Text;
            var TxtArrayVal = textBoxNumberArray.Text;

            try
            {
                var NumIndex = Convert.ToInt16(Index);
                var ArrayVal = Convert.ToByte(TxtArrayVal);
                ByteArray [NumIndex] = ArrayVal;
                txtBoxValues.Text = string.Join("\t", ByteArray);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Er for stort for Byte! \n " + ex.GetType());
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Nummeret du skrev inn er for stort! \n " + ex.GetType());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                MessageBox.Show("Omgjøring utført!");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxIndex_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
