using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week10_06
{
    public partial class frmConvertWeights : Form
    {
        public frmConvertWeights()
        {
            InitializeComponent();
            cmboFrom.Items.AddRange(WeightConverter.WeightMeasures());
            cmboFrom.SelectedIndex = 1;
            cmboTo.Items.AddRange(WeightConverter.WeightMeasures());
            cmboTo.SelectedIndex = 0;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmboFrom.Text == "Ounces")
                {
                    switch (cmboTo.Text)
                    {
                        case "Ounces":
                            MessageBox.Show("No conversion from Ounces to Ounces.");
                            //txtTo.Text = double.Parse(txtFrom.Text).ToString();
                            break;
                        case "Pounds":
                            txtTo.Text = WeightConverter.OuncesToPounds(double.Parse(txtFrom.Text)).ToString("0.0000");
                            break;
                        case "Grams":
                            txtTo.Text = WeightConverter.OuncesToGrams(double.Parse(txtFrom.Text)).ToString("0.0000");
                            break;
                        case "Kilograms":
                            txtTo.Text = WeightConverter.OuncesToKilograms(double.Parse(txtFrom.Text)).ToString("0.0000");
                            break;
                        default:
                            cmboTo.Focus();
                            throw new ArgumentOutOfRangeException("Unhandled 'To' measurement type: " + cmboTo.Text);
                    }
                } else if (cmboFrom.Text == "Pounds")
                {
                    switch (cmboTo.Text)
                    {
                        case "Ounces":
                            txtTo.Text = WeightConverter.PoundsToOunces(double.Parse(txtFrom.Text)).ToString("0.0000");
                            break;
                        case "Pounds":
                            MessageBox.Show("No conversion from Pounds to Pounds.");
                            //txtTo.Text = double.Parse(txtFrom.Text).ToString();
                            break;
                        case "Grams":
                            txtTo.Text = WeightConverter.PoundsToGrams(double.Parse(txtFrom.Text)).ToString("0.0000");
                            break;
                        case "Kilograms":
                            txtTo.Text = WeightConverter.PoundsToKilograms(double.Parse(txtFrom.Text)).ToString("0.0000");
                            break;
                        default:
                            cmboTo.Focus();
                            throw new ArgumentOutOfRangeException("Unhandled 'To' measurement type: " + cmboTo.Text);
                    }
                } else if (cmboFrom.Text == "Grams")
                {
                    switch (cmboTo.Text)
                    {
                        case "Ounces":
                            txtTo.Text = WeightConverter.GramsToOunces(double.Parse(txtFrom.Text)).ToString("0.0000");
                            break;
                        case "Pounds":
                            txtTo.Text = WeightConverter.GramsToPounds(double.Parse(txtFrom.Text)).ToString("0.0000");
                            break;
                        case "Grams":
                            MessageBox.Show("No conversion from Grams to Grams.");
                            //txtTo.Text = double.Parse(txtFrom.Text).ToString();
                            break;
                        case "Kilograms":
                            txtTo.Text = WeightConverter.GramsToKilograms(double.Parse(txtFrom.Text)).ToString("0.0000");
                            break;
                        default:
                            cmboTo.Focus();
                            throw new ArgumentOutOfRangeException("Unhandled 'To' measurement type: " + cmboTo.Text);
                    }
                } else if (cmboFrom.Text == "Kilograms")
                {
                    switch (cmboTo.Text)
                    {
                        case "Ounces":
                            txtTo.Text = WeightConverter.KilogramsToOunces(double.Parse(txtFrom.Text)).ToString("0.0000");
                            break;
                        case "Pounds":
                            txtTo.Text = WeightConverter.KilogramsToPounds(double.Parse(txtFrom.Text)).ToString("0.0000");
                            break;
                        case "Grams":
                            txtTo.Text = WeightConverter.KilogramsToGrams(double.Parse(txtFrom.Text)).ToString("0.0000");
                            break;
                        case "Kilograms":
                            MessageBox.Show("No conversion from Kilograms to Kilograms.");
                            //txtTo.Text = double.Parse(txtFrom.Text).ToString();
                            break;
                        default:
                            cmboTo.Focus();
                            throw new ArgumentOutOfRangeException("Unhandled 'To' measurement type: " + cmboTo.Text);
                    }
                }
                else
                {
                    cmboFrom.Focus();
                    throw new ArgumentOutOfRangeException("Unhandled 'From' measurement type: " + cmboTo.Text);
                }
            }
            catch (ArgumentOutOfRangeException argOutExcep)
            {
                MessageBox.Show(argOutExcep.Message);
            }
            catch (FormatException formatExcep)
            {
                MessageBox.Show("Invalid Input.  Enter a number to convert.  " + formatExcep.Message);
                txtFrom.Text = "";
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
            
        }
    }
}
