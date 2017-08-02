using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week10_09
{
    public partial class frmCharacterCounter : Form
    {
        private Dictionary<char, int> CharacterDict { get; set; }
        private char[] UserContent { get; set; }
        private const int MAX_CHARACTER_CONTENT_SIZE = 500;

        public frmCharacterCounter()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Array.Clear(UserContent, 0, MAX_CHARACTER_CONTENT_SIZE);
            txtCharacterEntry.Text = "";
            txtCharCount.Text = "";
            txtCharCountBreakdown.Text = "";
            txtCharRemaining.Text = "";
        }

        private void frmCharacterCounter_Load(object sender, EventArgs e)
        {
            CharacterDict = new Dictionary<char, int>();
            UserContent = new char[MAX_CHARACTER_CONTENT_SIZE];
            lblCountDown.Text = $"Max Char {MAX_CHARACTER_CONTENT_SIZE}.  Remaining: ";
        }

        private void txtCharacterEntry_SizeChanged(object sender, EventArgs e)
        {
            txtCharCount.Text = txtCharacterEntry.Text.Length.ToString();
            txtCharRemaining.Text = $"{MAX_CHARACTER_CONTENT_SIZE - txtCharacterEntry.Text.Length}";
        }

        private void btnCaclulateCounts_Click(object sender, EventArgs e)
        {
            CharacterDict.Clear();
            try
            {
                UserContent = txtCharacterEntry.Text.ToCharArray(0, txtCharacterEntry.Text.Length);
                if (UserContent.Length > MAX_CHARACTER_CONTENT_SIZE)
                {
                    throw new IndexOutOfRangeException($"Max size is {MAX_CHARACTER_CONTENT_SIZE} and you have exceeded it.  Delete some characters.");
                }
                foreach (char aChar in UserContent)
                {
                    if (CharacterDict.ContainsKey(aChar))
                    {
                        CharacterDict[aChar]++;
                    }
                    else
                    {
                        if (aChar != '0' && String.IsNullOrWhiteSpace(aChar.ToString()) == false)
                        {
                            CharacterDict.Add(aChar, 1);
                        }
                    }
                }
                txtCharCountBreakdown.Text = "";

                foreach (KeyValuePair < char, int> pair in CharacterDict)
                {
                    txtCharCountBreakdown.Text += "'" + pair.Key.ToString() + "' - " + pair.Value.ToString();
                    txtCharCountBreakdown.Text += Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error has occurred.\nError: " + ex.Message);
            }

        }
    }
}
