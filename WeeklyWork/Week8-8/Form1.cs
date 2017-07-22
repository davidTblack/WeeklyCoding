using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week8_8
{
    /// <summary>
    /// Programming exercises for week 8 - CITP180 Summer 2017; this is CHAPTER 9
    /// Exercise 8 is an application to calculate distance based on speed and time
    /// Author: David Black
    /// Date: 7/11/2017
    /// </summary>
    public partial class frmDistanceApp : Form
    {
        public frmDistanceApp()
        {
            InitializeComponent();
        }

        private void frmDistanceApp_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculateDistance_Click(object sender, EventArgs e)
        {
            bool validFlag = true;
            validFlag = ValidateSpeed();
            validFlag = validFlag ? ValidateTime() : false;
            if (validFlag)
            {
                txtCalculatedDistance.Text = $"{(double.Parse(txtSpeed.Text) * double.Parse(txtTime.Text)):f2} Miles";

            }
        }

        private bool ValidateTime()
        {
            bool retValue = true;
            if (double.TryParse(txtTime.Text, out double dummy) == false)
            {
                MessageBox.Show("Please enter a numeric value for Time in hours");
                txtTime.Focus();
                retValue = false;
            }
            return retValue;
        }

        private bool ValidateSpeed()
        {
            bool retValue = true;
            if (double.TryParse(txtSpeed.Text, out double dummy) == false)
            {
                MessageBox.Show("Please enter a numeric value for Speed Miles Per Hour");
                txtSpeed.Focus();
                retValue = false;
            }
            return retValue;
        }
        
    }
}
