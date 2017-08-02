using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week10_04_wpf
{
    public partial class frmAverage : Form
    {
        private int NumberOfScores { get; set; }
        private List<int> Scores { get; set; }

        public frmAverage()
        {
            InitializeComponent();
            Scores = new List<int>();
            ResetApp(this, new EventArgs());
        }

        

        private void ResetApp(object sender, EventArgs e)
        {
            txtScore.Text = "";
            txtAverage.Text = "";
            txtNumberScores.Text = "";
            NumberOfScores = 0;
            Scores.Clear();
            txtGrade.Text = "";
            txtScore.Focus();
        }

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            try
            {
                //Validate score
                int oneScore = int.Parse(txtScore.Text);
                if (oneScore < 0 || oneScore > 100)
                {
                    throw new FormatException("Number out of range.  Enter an integer between 0 and 100.");
                }
                //add number to scores
                Scores.Add(oneScore);
                //increase count
                NumberOfScores++;
                //calculate average and set fields
                txtAverage.Text = (Scores.Sum() / NumberOfScores).ToString();
                txtNumberScores.Text = NumberOfScores.ToString();

                //reset data entry for the next score
                txtScore.Text = "";

                txtGrade.Text = GetGrade(int.Parse(txtAverage.Text));
            }
            catch (OverflowException oflowExcep)
            {
                MessageBox.Show("Number should be between 0 and 100.  " + oflowExcep.Message);
                txtScore.Text = "";
            }
            catch (FormatException blankFormExcep) when (String.IsNullOrWhiteSpace(txtScore.Text))
            {
                MessageBox.Show("No value entered.  Enter an integer between 0 and 100.");
                txtScore.Text = "";
            }
            catch (FormatException formExcep)
            {
                MessageBox.Show(formExcep.Message);
                txtScore.Text = "";
            }
            catch (Exception generalExcep)
            {
                MessageBox.Show("An unexpected error has occurred.  " + generalExcep.Message);
                txtScore.Text = "";
            }
            finally
            {
                txtScore.Focus();
            }
        }

        private string GetGrade(int averageScore)
        {
            string retValue;
            if(averageScore > 89)
            {
                retValue = "A";
            }else if (averageScore > 79)
            {
                retValue = "B";
            }
            else if (averageScore > 69)
            {
                retValue = "C";
            }
            else if (averageScore > 59)
            {
                retValue = "D";
            }
            else if (averageScore > -1)
            {
                retValue = "F";
            }
            else 
            {
                throw new FormatException($"Value '{averageScore}' does not convert to a grade value.");
            }
            return retValue;
        }
    }
}
