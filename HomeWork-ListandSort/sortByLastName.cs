using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_ListandSort
{
    class sortByLastName : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            return (x.lastName.CompareTo(y.lastName));
        }
    }
}
