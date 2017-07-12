using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonNamespace;

namespace StudentNamespace
{
    public class Student : Person
    {
        private string major;
        private string studentId;

        public Student()
            : base()
        {
        }

        public Student(string id, string fname, string lname, string maj, string sId)
            :base(id, lname, fname)
        {
            major = maj;
            studentId = sId;
        }

        public string StudientId { get { return studentId; } }
        public string Major { get { return major; } set { major = value; } }

        public override int GetSleepAmt()
        {
            return 6;
        }

        public int CallOverriddenGetSleepAmt()
        {
            return base.GetSleepAmt();
        }
    }
}
