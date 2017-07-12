using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7_8_Student;

namespace Week7_8_GraduateStudent
{
    public class GraduateStudent : Student
    {
        public string Degree { get; set; }
        public string DegreeInstitution { get; set; }

        public GraduateStudent()
        {
        }

        public GraduateStudent(string name, string id, string degree, string institution)
            : base(name, id)
        {
            Degree = degree;
            DegreeInstitution = institution;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\r\nDegree:\t\t{Degree}" +
                $"\r\nDegree Institution:\t{DegreeInstitution}";
        }
    }
}
