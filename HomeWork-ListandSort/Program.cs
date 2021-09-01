using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork_ListandSort
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Student> list = new List<Student>(3);

            list.Add(new Student("yakir", "gigi", 90));
            list.Add(new Student("hai", "ben david", 89));
            list.Add(new Student("dudu", "boaron", 68));

            #region Targil1
            list.Sort(new sortByLastName());
            #endregion

            #region Targil2
            list.Sort(new SortBygrade());
            #endregion

            #region Targil3
            list.Sort(new sortByLastName());
            list.Sort(new sortByFirstName());
            #endregion

            #region Targil4
            list.Sort(new sortByLastName());
            list.Sort(new sortByFirstName());
            list.Sort(new SortBygrade());
            #endregion
            Console.WriteLine(list);

           
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
