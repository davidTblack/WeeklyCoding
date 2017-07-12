using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week7_8.Reading;

namespace Week7_8
{
    public partial class Form1 : Form
    {
        private List<ReadingMaterial> readingLibrary;

        public Form1()
        {
            InitializeComponent();
        }

        private void ResetEntryControls()
        {
            txtTitle.Text = "";
            txtIssue.Text = "";
            txtAuthor.Text = "";
            txtLanguage.Text = "";
            txtPages.Text = "";
            txtPrice.Text = "";
            chkbxIsHardCover.Checked = false;
            radBtnBook.Checked = false;
            radBtnMagazine.Checked = false;
            radBtnOnline.Checked = false;
            radBtnWeekly.Checked = false;
            radBtnMonthly.Checked = false;
        }


        private void FillLastEntryControls(Book lastItem)
        {
            //Start by resetting everything to blank/unselected
            txtTitleDisplay.Text = "";
            txtIssueDisplay.Text = "";
            txtAuthorDisplay.Text = "";
            txtLanguageDisplay.Text = "";
            txtPagesDisplay.Text = "";
            txtPriceDisplay.Text = "";
            chkBxIsHardCoverDisplay.Checked = false;
            radBtnBookDisplay.Checked = false;
            radBtnMagazineDisplay.Checked = false;
            radBtnOnlineDisplay.Checked = false;
            radBtnWeeklyDisplay.Checked = false;
            radBtnMonthlyDisplay.Checked = false;

            //fill in fields
            txtAuthorDisplay.Text = lastItem.Author;
            txtLanguageDisplay.Text = lastItem.Language;
            txtPagesDisplay.Text = lastItem.NumberOfPages.ToString();
            txtPriceDisplay.Text = lastItem.Price.ToString();


            //fill in specific fields
            SetLastBook(lastItem);
            
        }

        private void FillLastEntryControls(Magazine lastItem)
        {
            //Start by resetting everything to blank/unselected
            txtTitleDisplay.Text = "";
            txtIssueDisplay.Text = "";
            txtAuthorDisplay.Text = "";
            txtLanguageDisplay.Text = "";
            txtPagesDisplay.Text = "";
            txtPriceDisplay.Text = "";
            chkBxIsHardCoverDisplay.Checked = false;
            radBtnBookDisplay.Checked = false;
            radBtnMagazineDisplay.Checked = false;
            radBtnOnlineDisplay.Checked = false;
            radBtnWeeklyDisplay.Checked = false;
            radBtnMonthlyDisplay.Checked = false;

            //fill in fields
            txtAuthorDisplay.Text = lastItem.Author;
            txtLanguageDisplay.Text = lastItem.Language;
            txtPagesDisplay.Text = lastItem.NumberOfPages.ToString();
            txtPriceDisplay.Text = lastItem.Price.ToString();


            //fill in specific fields
            SetLastMagazine(lastItem);
        }

        private void FillLastEntryControls(Online lastItem)
        {
            //Start by resetting everything to blank/unselected
            txtTitleDisplay.Text = "";
            txtIssueDisplay.Text = "";
            txtAuthorDisplay.Text = "";
            txtLanguageDisplay.Text = "";
            txtPagesDisplay.Text = "";
            txtPriceDisplay.Text = "";
            chkBxIsHardCoverDisplay.Checked = false;
            radBtnBookDisplay.Checked = false;
            radBtnMagazineDisplay.Checked = false;
            radBtnOnlineDisplay.Checked = false;
            radBtnWeeklyDisplay.Checked = false;
            radBtnMonthlyDisplay.Checked = false;

            //fill in fields
            txtAuthorDisplay.Text = lastItem.Author;
            txtLanguageDisplay.Text = lastItem.Language;
            txtPagesDisplay.Text = lastItem.NumberOfPages.ToString();
            txtPriceDisplay.Text = lastItem.Price.ToString();

            //fill in specific fields
            SetLastOnline(lastItem);
        }

        private void SetLastBook(Book bookItem)
        {
            radBtnBookDisplay.Checked = true;
            txtTitleDisplay.Text = bookItem.BookTitle;
            chkBxIsHardCoverDisplay.Checked = bookItem.IsHardCover;
            txtCopySourceDisplay.Text = bookItem.HardCopySource();

        }

        private void SetLastMagazine(Magazine magazineItem)
        {
            radBtnMagazineDisplay.Checked = true;
            txtIssueDisplay.Text = magazineItem.IssueNumber.ToString();
            switch (magazineItem.IssueFrequency)
            {
                case "Weekly":
                    radBtnWeeklyDisplay.Checked = true;
                    break;
                case "Monthly":
                    radBtnMonthlyDisplay.Checked = true;
                    break;
                default:
                    throw new ArgumentException("No Radio button for frequency");
                    break;
            }
            txtCopySourceDisplay.Text = magazineItem.HardCopySource();
        }

        private void SetLastOnline(Online onlineItem)
        {
            txtTitleDisplay.Text = onlineItem.PostTitle;
            radBtnOnlineDisplay.Checked = true;
            txtCopySourceDisplay.Text = onlineItem.HardCopySource();
        }

        private void btnAddNewMaterial_Click(object sender, EventArgs e)
        {
            bool validInputs = true;
            //verify fields
            while (validInputs && String.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("Author is required.");
                txtAuthor.Text = ".";
                validInputs = false;
                txtAuthor.Focus();
            }
            while (validInputs && String.IsNullOrWhiteSpace(txtLanguage.Text))
            {
                MessageBox.Show("Language is required.");
                txtLanguage.Text = ".";
                validInputs = false;
                txtLanguage.Focus();
            }
            while (validInputs && int.TryParse(txtPages.Text, out int dummy) == false)
            {
                MessageBox.Show("Pages must have a number.");
                txtPages.Text = ".";
                validInputs = false;
                txtPages.Focus();
            }
            while (validInputs && decimal.TryParse(txtPrice.Text, out decimal dummy2) == false)
            {
                MessageBox.Show("Price must have a number.");
                txtPrice.Text = ".";
                validInputs = false;
                txtPrice.Focus();
            }
            while(validInputs && radBtnBook.Checked == false && radBtnMagazine.Checked == false && radBtnOnline.Checked == false)
            {
                MessageBox.Show("Select a Reading Material Type.");
                radBtnBook.Checked = true;
                validInputs = false;
                radBtnBook.Focus();
            }
            while(validInputs && radBtnMagazine.Checked && radBtnWeekly.Checked == false && radBtnMonthly.Checked == false)
            {
                MessageBox.Show("Must select a magazine frequency.");
                radBtnWeekly.Checked = true;
                validInputs = false;
                radBtnWeekly.Focus();
            }

            //ReadingMaterial newMaterial;
            Book newBook;
            Magazine newMagazine;
            Online newOnline;

            if (validInputs)
            {

                //Create object
                if (radBtnBook.Checked)
                {
                    newBook = new Book(chkbxIsHardCover.Checked, 
                        txtTitle.Text, 
                        txtAuthor.Text, 
                        txtLanguage.Text, 
                        int.Parse(txtPages.Text), 
                        decimal.Parse(txtPrice.Text));

                    FillLastEntryControls(newBook);
                }
                else if (radBtnMagazine.Checked)
                {
                    newMagazine = new Magazine((radBtnWeekly.Checked?"Weekly": "Monthly"), 
                        int.Parse(txtIssue.Text),
                        txtTitle.Text, 
                        txtAuthor.Text, 
                        txtLanguage.Text, 
                        int.Parse(txtPages.Text), 
                        decimal.Parse(txtPrice.Text));

                    FillLastEntryControls(newMagazine);
                }
                else if (radBtnOnline.Checked)
                {
                    newOnline = new Online(txtTitle.Text,
                        txtAuthor.Text,
                        txtLanguage.Text,
                        int.Parse(txtPages.Text),
                        decimal.Parse(txtPrice.Text));

                    FillLastEntryControls(newOnline);
                }
                else
                {
                    throw new ArgumentException("No valid radio button type selected");
                }

                //add to collection
                //readingLibrary.Add(newMaterial);

                //display last item

                //reset
                ResetEntryControls();
            }


        }

        private void radBtnBook_CheckedChanged(object sender, EventArgs e)
        {
            txtIssue.Enabled = false;
            radBtnWeekly.Enabled = false;
            radBtnMonthly.Enabled = false;
            chkbxIsHardCover.Enabled = true;
        }

        private void radBtnMagazine_CheckedChanged(object sender, EventArgs e)
        {
            txtIssue.Enabled = true;
            radBtnWeekly.Enabled = true;
            radBtnMonthly.Enabled = true;
            chkbxIsHardCover.Enabled = false;
        }

        private void radBtnOnline_CheckedChanged(object sender, EventArgs e)
        {
            txtIssue.Enabled = false;
            radBtnWeekly.Enabled = false;
            radBtnMonthly.Enabled = false;
            chkbxIsHardCover.Enabled = false;
        }
    }
}
