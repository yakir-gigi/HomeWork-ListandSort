using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_ListandSort
{
    class SortBygrade :IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            return (x.grade.CompareTo(y.grade));
        }
    }
}
