using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week9_02_wf
{
    public partial class frmTShirt : Form
    {
        public frmTShirt()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void displayOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Validate fields
            bool allValid = ValidateFields();

            //display
            if (allValid)
            {
                if(int.Parse(txtQuantity.Text) > 1)
                {
                    MessageBox.Show($"Order includes {txtQuantity.Text} T-Shirts, size {cmbSize.Text}");
                }
                else
                {
                    MessageBox.Show($"Order includes {txtQuantity.Text} T-Shirt, size {cmbSize.Text}");
                }
                
            }

        }

        /// <summary>
        /// Run validation on all the fields before processing
        /// </summary>
        /// <returns></returns>
        private bool ValidateFields()
        {
            bool retValue = true;

            if (cmbSize.Text == "")
            {
                retValue = false;
                MessageBox.Show("Please select a size from the list");
                cmbSize.Focus();
            } else if (int.TryParse(txtQuantity.Text, out int quantity) ==  false || quantity < 1)
            {
                retValue = false;
                MessageBox.Show("Please select a valid number of shirts to order");
                txtQuantity.Focus();
            }
            return retValue;
            
        }
    }
}
