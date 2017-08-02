using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week10_05
{
    public partial class frmFractions : Form
    {
        Fraction currentFraction;

        public frmFractions()
        {
            InitializeComponent();
            currentFraction = new Fraction();
        }
        

        private void btnSetFraction_Click(object sender, EventArgs e)
        {
            int numerator, denominator;
            try
            {
                numerator = int.Parse(txtNumerator.Text);
                denominator = int.Parse(txtDenominator.Text);
                switch (Math.Sign(denominator))
                {
                    case 0:
                        throw new DivideByZeroException("A fraction cannot have zero in the denominator.  Enter a new number.");
                    case -1:
                        //a negative numerator and denominator make a positive number
                        if (Math.Sign(numerator) == -1)
                        {
                            numerator *= -1;
                            denominator *= -1;
                        }
                        break;
                }
                currentFraction.Numerator = numerator;
                currentFraction.Denominator = denominator;
                txtFractionDisplay.Text = currentFraction.ToString();

                //Reset Data Entry Fields
                txtNumerator.Text = "";
                txtDenominator.Text = "";
                btnReduceFraction.Focus();
            }

            catch (DivideByZeroException divExcep)
            {
                MessageBox.Show(divExcep.Message);
                txtDenominator.Text = "";
                txtDenominator.Focus();
            }
            catch (FormatException formExcep)
            {
                MessageBox.Show(formExcep.Message);
                txtNumerator.Text = "";
                txtDenominator.Text = "";
                txtNumerator.Focus();
            }
            catch (Exception excep)
            {
                MessageBox.Show("An unexpected error has occurred.  Try entering new numbers.  " + excep.Message);
                txtNumerator.Text = "";
                txtDenominator.Text = "";
                txtNumerator.Focus();
            }
        }

        private void btnReduceFraction_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtFractionDisplay.Text))
            {
                MessageBox.Show("Please enter a fraction.");
            }
            else
            {
                currentFraction.ReduceToLowestTerms();
                txtFractionDisplay.Text = currentFraction.ToString();
            }
        }
    }
}
