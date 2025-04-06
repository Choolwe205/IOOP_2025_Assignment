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

            Application.Run(new CustomerMainPanel("choolwe205@gmail.com"));

            Application.Run(new Main_Dashboard("mwilachibesa@gmail.com"));

            Application.Run(new ChefPage());

        }
    }
}