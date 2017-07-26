using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week9_09_wf
{
    public partial class frmFlooring : Form
    {
        public frmFlooring()
        {
            InitializeComponent();
            ResetForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabCtrl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            txtLenFeet.Text = "";
            txtLenInches.Text = "";
            txtWidFeet.Text = "";
            txtWidInches.Text = "";
            radBtnOak.Checked = false;
            radBtnMaple.Checked = false;
            radBtnWalnut.Checked = false;
            radBtnCherry.Checked = false;
            radBtnShag.Checked = false;
            radBtnStandard.Checked = false;
            radBtnSolidLaminate.Checked = false;
            radBtnTiledLaminate.Checked = false;

            txtTotalCost.Text = "";
        }

        private bool ValidateFeet(TextBox box)
        {
            bool retValue = true;
            if (int.TryParse(box.Text, out int dummy) == false)
            {
                box.Text = "";
                box.Focus();
                retValue = false;
            }
            else if (dummy < 0)
            {
                box.Text = "";
                box.Focus();
                retValue = false;
            }
            return retValue;
        }

        private bool ValidateInches(TextBox box)
        {
            bool retValue = true;
            if (int.TryParse(box.Text, out int dummy) == false)
            {
                box.Text = "";
                box.Focus();
                retValue = false;
            }
            else if (dummy < 0 || dummy > 11)
            {
                box.Text = "";
                box.Focus();
                retValue = false;
            }
            return retValue;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal length, width;
            //validate fields
            if (ValidateMeasurements() && ValidateTabSelection(out RadioButton selectedBtn))
            {
                //Calculate and total cost: L X W X pricer per yard
                length = (FeetInchesToYard(int.Parse(txtLenFeet.Text), int.Parse(txtLenInches.Text)));
                width = (FeetInchesToYard(int.Parse(txtWidFeet.Text), int.Parse(txtWidInches.Text)));

                //Set cost
                txtTotalCost.Text = "$" + Math.Round(length * width * GetPrice(selectedBtn.Text), 2).ToString();
            }
        }

        private decimal FeetInchesToYard(int feet, int inches)
        {
            feet += ((1 / 12) * inches);
            return feet * 0.3333m;
        }


        private bool ValidateTabSelection(out RadioButton selectedButton)
        {
            bool retValue = true;
            selectedButton = new RadioButton();
            switch (tabCtrl.SelectedTab.Text)
            {
                case "Hardwood":
                    if (radBtnOak.Checked)
                    {
                        selectedButton = radBtnOak;
                    }
                    else if  (radBtnOak.Checked)
                    {
                        selectedButton = radBtnOak;
                    }
                    else if (radBtnMaple.Checked)
                            {
                        selectedButton = radBtnMaple;
                    }
                    else if (radBtnWalnut.Checked)
                    {
                        selectedButton = radBtnWalnut;
                    }
                    else if (radBtnCherry.Checked)
                    {
                        selectedButton = radBtnCherry;
                    }
                    else
                    {
                        MessageBox.Show("No hardwood flooring selected");
                        retValue = false;
                    }
                    break;
                case "Carpet":
                    if (radBtnShag.Checked)
                    {
                        selectedButton = radBtnShag;
                    }
                    else if (radBtnStandard.Checked)
                    {
                        selectedButton = radBtnStandard;
                    }
                    else
                    {
                        MessageBox.Show("No carpet flooring selected");
                        retValue = false;
                    }
                    break;
                case "Laminate":
                    if (radBtnSolidLaminate.Checked)
                    {
                        selectedButton = radBtnSolidLaminate;
                    }
                    else if (radBtnTiledLaminate.Checked)
                    {
                        selectedButton = radBtnTiledLaminate;
                    }
                    else
                    {
                        MessageBox.Show("No laminate flooring selected");
                        retValue = false;
                    }
                    break;
                default:
                    retValue = false;
                    break;
            }
            return retValue;
            
        }

        private bool ValidateMeasurements()
        {
            bool passValidation = false;

            //validate fields
            if (ValidateFeet(txtLenFeet) == false)
            {
                MessageBox.Show("Length in feet must be a number.");
            }
            else if (ValidateInches(txtLenInches) == false)
            {
                MessageBox.Show("Lenfth in inches must be a number 0-11.");
            }
            else if (ValidateFeet(txtWidFeet) == false)
            {
                MessageBox.Show("Width in feet must be a number.");
            }
            else if (ValidateInches(txtWidInches) == false)
            {
                MessageBox.Show("Width in inches must be a number 0-11.");
            }
            else
            {
                passValidation = true;
            }
            return passValidation;
        }

        private decimal GetPrice(string descriptionWithPrice)
        {
            string temp = descriptionWithPrice.Substring(descriptionWithPrice.IndexOf('$') + 1);
            temp = temp.Substring(0, temp.IndexOf(' ') );
            return decimal.Parse(temp);
        }
    }
}
