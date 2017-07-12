using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_8_Student
{
    public class Student
    {
        public string Name { get; set; }
        public string Id { get; set; }

        public Student()
        {
        }

        public Student(string name, string id)
        {
            Name = name;
            Id = id;
        }

        public override string ToString()
        {
            return $"Student Name:\t{Name}" +
                $"\r\nStudent ID:\t{Id}";

        }
    }
}
