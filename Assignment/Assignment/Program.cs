using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment.Resources;


namespace Assignment
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new Main_Dashboard("mwilachibesa@gmail.com"));
=======
            Application.Run(new ChefPage());
>>>>>>> bf2eb99ddeb26b81d92b39f6931456da329eb1d8
        }
    }
}