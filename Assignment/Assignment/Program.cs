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
            Application.Run(new CustomerMainPanel("choolwe205@gmail.com"));
=======
            Application.Run(new Admininstrator("SharafMo@gmail.com"));   
            Application.Run(new Main_Dashboard("mwilachibesa@gmail.com"));
            Application.Run(new CustomerMainPanel());

           

>>>>>>> 8a823e2d1baac09cf0d645422ca31ba959f6b9c9
        }
    }
}