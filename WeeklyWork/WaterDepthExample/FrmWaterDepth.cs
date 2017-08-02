using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WaterDepthExample
{
    public partial class frmWaterDepth : Form
    {
        private ShoalArea anArea { get; set; }
        private StreamWriter fil;

        
        public frmWaterDepth()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            double[] lowTides = new double[4];
            double[] hiTides = new double[4];
            anArea.Location = txtLocation.Text;
            lblError.Text = "";
            try
            {
                lowTides[0] = double.Parse(txtLow1.Text);
                lowTides[1] = double.Parse(txtLow2.Text);
                lowTides[2] = double.Parse(txtLow3.Text);
                lowTides[3] = double.Parse(txtLow4.Text);
                hiTides[0] = double.Parse(txtHigh1.Text);
                hiTides[1] = double.Parse(txtHigh2.Text);
                hiTides[2] = double.Parse(txtHigh3.Text);
                hiTides[3] = double.Parse(txtHigh4.Text);
                anArea.State = txtState.Text;
                anArea.MileMarker = double.Parse(txtMileMarker.Text);
                anArea.LowTideDepth = lowTides;
                anArea.HiTideDepth = hiTides;
                MessageBox.Show(anArea.ToString(), "ICW Problem Area");
            }
            catch (TestOfStateException ex)
            {
                Trace.WriteLine($"\nException: {ex.Message}");
                lblError.Text += $"\nException: {ex.Message}";
            }
            catch (FormatException ex)
            {
                Trace.WriteLine("Method\'s actual argument does not match formatl parameter" +
                    $"\nException: {ex.Message}");
                lblError.Text += $"\nException: {ex.Message}";
            }
            catch (ArithmeticException ex)
            {
                Trace.WriteLine("Errors in an arithmetic, casting, or converion." +
                    $"\nException: {ex.Message}");
                lblError.Text += $"\nException: {ex.Message}";
            }
            catch (ArrayTypeMismatchException ex)
            {
                Trace.WriteLine("Trying to store an element of wrong type in an array." +
                    $"\nException: {ex.Message}");
                lblError.Text += $"\nException: {ex.Message}";
            }
            catch (IndexOutOfRangeException ex)
            {
                Trace.WriteLine("Trying to access element of an array with index outside bounds of the array." +
                    $"\nException: {ex.Message}");
                lblError.Text += $"\nException: {ex.Message}";
            }
            catch (Exception ex)
            {
                Trace.WriteLine($"\nException: {ex.Message}");
                lblError.Text += $"\nException: {ex.Message}";
            }
        }

        private void frmWaterDepth_Load(object sender, EventArgs e)
        {
            anArea = new ShoalArea();
            try
            {
                fil = new StreamWriter("WaterData.txt");
            }
            catch (DirectoryNotFoundException exc)
            {
                lblError.Text = "Invalid directory" + exc.Message;
            }
            catch (System.IO.IOException exc)
            {
                lblError.Text = exc.Message;
            }

            
        }
        private void StoreDataInFile(ShoalArea a2Area)
        {
            try
            {
                fil.WriteLine(a2Area.ShoalAreaRecord);
            }
            catch (DirectoryNotFoundException exc)
            {
                lblError.Text = "Invalid directory" + exc.Message;
            }
            catch (InvalidDataException exc)
            {
                lblError.Text = "Invalid format in data stream " + exc.Message;
            }
            catch (System.IO.IOException exc)
            {
                lblError.Text = exc.Message;
            }
        }

        private void frmWaterDepth_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                fil.Close();
            }
            catch (IOException exc)
            {
                lblError.Text = exc.Message;
            }
        }
    }
}
