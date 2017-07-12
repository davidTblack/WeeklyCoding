using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week7_10
{
    public partial class Form1 : Form
    {

        private SingleFamily family = new SingleFamily("111 Mystery Ln", 1956, 2000, true);
        private MultiUnit mUnit = new MultiUnit("222 Boxy Rd", 2000, 10);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = family.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = mUnit.ToString();

        }
    }
}
