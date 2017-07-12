using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week7_8_Student;
using Week7_8_GraduateStudent;
using Week7_8_UndergraduateStudent;

namespace Week7_9
{
    public partial class Form1 : Form
    {
        private Student genericStudent = new Student("Joe", "334");
        private Student grad1 = new GraduateStudent("Sally", "336", "B.A.", "Michigan State University");
        private Student undergrad2 = new UndergraduateStudent("Kim", "344", "Senior", "Popeye", "123 Sailor's Lane");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStudent1_Click(object sender, EventArgs e)
        {
            txtStudentName.Text = genericStudent.Name;
            txtStudentId.Text = genericStudent.Id;
            txtStudentInfo.Text = genericStudent.ToString();
        }

        private void btnStudent2_Click(object sender, EventArgs e)
        {
            txtStudentName.Text = grad1.Name;
            txtStudentId.Text = grad1.Id;
            txtStudentInfo.Text = grad1.ToString();
        }

        private void btnStudent3_Click(object sender, EventArgs e)
        {
            txtStudentName.Text = undergrad2.Name;
            txtStudentId.Text = undergrad2.Id;
            txtStudentInfo.Text = undergrad2.ToString();
        }
    }
}
