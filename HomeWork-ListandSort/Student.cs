using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_ListandSort
{
    class Student
    {
        public string firsName { get; set; }
        public string lastName { get; set; }
        public int grade { get; set; }

        public Student(string firsName, string lastName, int grade)
        {
            this.firsName = firsName;
            this.lastName = lastName;
            this.grade = grade;
        }

    }
}
