using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week8_5
{
    /// <summary>
    /// Programming exercises for week 8 - CITP180 Summer 2017; this is CHAPTER 9
    /// Exercise 5 is an application to Create a trip Calculater of MPG
    /// Author: David Black
    /// Date: 7/11/2017
    /// </summary>
    public partial class frmTripCalculator : Form
    {
        public frmTripCalculator()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            bool validFlag = true;
            validFlag = validFlag ? ValidateAddress() : false;
            validFlag = validFlag ? ValidateMiles() : false;
            validFlag = validFlag ? ValidateGallons() : false;
            
            if (validFlag)
            {
                txtMpg.Text = $"{(double.Parse(txtMiles.Text) / double.Parse(txtGallons.Text)):f2}";
                btnReset.Focus();
            }
        }

        private bool ValidateMiles()
        {
            bool retValue = true;
            if (double.TryParse(txtMiles.Text, out double dummy) == false)
            {
                MessageBox.Show("Please enter a numeric value for Miles");
                txtMiles.Focus();
                retValue = false;
            }
            return retValue;
        }

        private bool ValidateGallons()
        {
            bool retValue = true;
            if (double.TryParse(txtGallons.Text, out double dummy) == false)
            {
                MessageBox.Show("Please enter a numeric value for Gallons");
                txtGallons.Focus();
                retValue = false;
            }
            return retValue;
        }

        private bool ValidateAddress()
        {
            bool retValue = true;
            if(txtDestination.Text == "")
            {
                MessageBox.Show("Please enter a valid address");
                txtDestination.Focus();
                retValue = false;
            }
            return retValue;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtGallons.Text = "";
            txtDestination.Text = "";
            txtMiles.Text = "";
            txtMpg.Text = "";
            txtDestination.Focus();
        }
    }
}
