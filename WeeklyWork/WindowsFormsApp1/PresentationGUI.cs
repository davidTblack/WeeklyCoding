using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentNamespace;

namespace PresentationAppNamespace
{
    public partial class PresentationGUI : System.Windows.Forms.Form
    {
        private Student aStudent;

        public PresentationGUI()
        {
            //InitializeComponent();
        }

        private void PresentationGUI_Load(object sender, EventArgs e)
        {
            aStudent = new Student("1234456789", "Maria", "Woo", "CS", "1111");
        }
        
        private void btnShow_Click(object sender, EventArgs e)
        {
            aStudent.Age = 25;

            //txtBxName.Text = aStudent.ToString();
            //txtBxAge.Text = aStudent.Age.ToString();
            //txtBxID.Text = aStudent.StudientId;

            //txtBxStudentSleep.Text = Convert.ToString(aStudent.GetSleepAmt());
            //textBxPersonSleep.Text = Convert.ToString(aStudent.CallOverriddenGetSleepAmt());
        }
    }
}
