using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week8_4
{
    /// <summary>
    /// Programming exercises for week 8 - CITP180 Summer 2017; this is CHAPTER 9
    /// Exercise 4 is an application to create a form that moved based on location
    /// values the user enters
    /// Author: David Black
    /// Date: 7/11/2017
    /// </summary>
    public partial class frmMagicMover : Form
    {
        public frmMagicMover()
        {
            InitializeComponent();
        }

        private void txtXPosition_TextChanged(object sender, EventArgs e)
        {
            int x;
            while (int.TryParse(txtXPosition.Text, out x) == false)
            {
                MessageBox.Show("Must enter a number (integer) for new X position.");
                txtXPosition.Text = "0";
                txtXPosition.Focus();
            }
        }

        private void txtYPosition_TextChanged(object sender, EventArgs e)
        {
            int y;
            while (int.TryParse(txtYPosition.Text, out y) == false)
            {
                MessageBox.Show("Must enter a number (integer) for new Y position.");
                txtYPosition.Text = "0";
                txtYPosition.Focus();
            }
        }

        private void btnMoveIt_Click(object sender, EventArgs e)
        {
            
            Point newWindowLocation = new Point(int.Parse(txtXPosition.Text), int.Parse(txtYPosition.Text));

            int screenWidth = SystemInformation.VirtualScreen.Width;
            int screenHeight = SystemInformation.VirtualScreen.Height;
            
            if (newWindowLocation.X > -1 && newWindowLocation.Y > -1)
            {
                if (Width + newWindowLocation.X > screenWidth)
                {
                    newWindowLocation.X = screenWidth - Width;
                }
                if (Height + newWindowLocation.Y > screenHeight)
                {
                    newWindowLocation.Y = screenHeight - Height;
                }
                Location = newWindowLocation;
                //SetDesktopLocation(newWindowLocation.X, newWindowLocation.Y);
            }
            
        }
    }
}
