using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week9_06_wf
{
    public partial class frmBagOrder : Form
    {
        bool canTriggerOrder = true;
        public frmBagOrder()
        {
            InitializeComponent();
        }

 
        private void SelectionMade(object sender, EventArgs e)
        {
            //tracking in class with a flag so we can use the reset button without triggering error message
            if (canTriggerOrder)
            {
                if (lstBxTypes.SelectedIndices.Count == 0)
                {
                    MessageBox.Show("Please select a bag type.");
                    lstBxTypes.Focus();
                }
                else
                {
                    //Calculate subtotal before shipping
                    decimal subtotal = GetBagTypeCost() * decimal.Parse(cmboQuantity.Text);
                    //determine shipping charge
                    decimal shippingCharge = DetermineShipping(subtotal);

                    //Display order
                    string orderMessage = $"Bag Type:\t\t{lstBxTypes.Text}"
                        + $"\nQuantity:\t\t{cmboQuantity.Text,10 }"
                        + $"\nShipping:\t\t {shippingCharge,10:c2}"
                        + $"\nTotal Price:\t{(subtotal + shippingCharge),10:c2}";
                    MessageBox.Show(orderMessage);
                }
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            canTriggerOrder = false;
            //Reset type selection
            lstBxTypes.ClearSelected();

            //Reset checkbox
            radBtnOvernight.Checked = false;
            radBtn3Day.Checked = false;
            radBtnStandard.Checked = true;

            //reset quantity
            cmboQuantity.Text = "1";
            canTriggerOrder = true;
        }

        private decimal DetermineShipping(decimal subTot)
        {
            decimal shippingPercentage = 0m;
            if (radBtnOvernight.Checked)
            {
                shippingPercentage = 0.1m;
            }
            else if (radBtn3Day.Checked)
            {
                shippingPercentage = 0.07m;
            }
            else if (radBtnStandard.Checked)
            {
                shippingPercentage = 0.05m;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Shipping percentage unknown");
            }

            return shippingPercentage * subTot;
        }

        private decimal GetBagTypeCost()
        {
            string temp = lstBxTypes.SelectedItem.ToString();
            temp = temp.Substring(temp.LastIndexOf('$') + 1);
            return decimal.Parse(temp);
        }

        
    }
}
