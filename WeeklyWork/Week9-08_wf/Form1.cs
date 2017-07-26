using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week9_08_wf
{
    public partial class frmTShirt : Form
    {
        private Dictionary<string, int> cart;
        //decimal[,] cart = new decimal[6, 2];

        public frmTShirt()
        {
            InitializeComponent();
            //Set up cart
            cart = new Dictionary<string, int>();
            CartSetup();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //display items already in cart
        private void displayOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cart.Values.Sum() == 0)
            {
                MessageBox.Show("No items have been added to the cart.  Use the menu to add items.");
            }
            else
            {
                //display
                StringBuilder orderDisplay = new StringBuilder("");
                orderDisplay.AppendLine("These items are currently in your cart:");
                orderDisplay.AppendLine("--------------------------------");
                orderDisplay.AppendLine("Size\t     Quantity");
                decimal totalPrice = 0m;

                //display all cart items
                //total the cost
                foreach (KeyValuePair<string, int> aPair in cart)
                {
                    if (aPair.Value != 0)
                    {
                        switch (aPair.Key)
                        {
                            case "S":
                            case "M":
                            case "L":
                            case "XL":
                                totalPrice += aPair.Value * 16m;
                                break;
                            case "XSmall":
                            case "XXLarge":
                                totalPrice += aPair.Value * 20m;
                                break;
                            default:
                                throw new DataException("Unknown Size");
                        }
                        orderDisplay.AppendLine($"{aPair.Key}\t{aPair.Value,7}");
                    }
                }
                orderDisplay.AppendLine("--------------------------------");
                orderDisplay.AppendLine($"Total Price:\t{totalPrice:c2}");
                MessageBox.Show(orderDisplay.ToString());
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

        private void addToCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Validate fields
            bool allValid = ValidateFields();

            //display
            if (allValid)
            {
                cart[cmbSize.Text] += int.Parse(txtQuantity.Text);
                MessageBox.Show($"Added {txtQuantity.Text} T-Shirts of size {cmbSize.Text}");
            }
        }
        
        private void CartSetup()
        {             
            foreach (string item in cmbSize.Items)
            {
                //add new or just reset value
                if (cart.ContainsKey(item) == false)
                {
                    cart.Add(item, 0);
                }
                else
                {
                    cart[item] = 0;
                }
            }            
        }

        private void emptyCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CartSetup();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Make selections and add items to the cart.  Display items with the Display Order menu option.");
        }
    }
}
