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
        public frmBagOrder()
        {
            InitializeComponent();
        }

        private void SelectionMade(object sender, EventArgs e)
        {
            if(lstBxTypes.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please select a bag type.");
                lstBxTypes.Focus();
            }
            else
            {
                MessageBox.Show($"Selected {cmboQuantity.Text} bag(s) of type {lstBxTypes.Text}");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstBxTypes.ClearSelected();
        }
    }
}
