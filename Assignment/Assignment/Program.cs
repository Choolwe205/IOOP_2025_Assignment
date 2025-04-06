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
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD

            Application.Run(new Main_Dashboard("mwilachibesa@gmail.com"));

           

=======
            Application.Run(new CustomerMainPanel("choolwe205@gmail.com"));
>>>>>>> fa7cc008cdf32852436075a77be73e3a2c048018
        }
    }
}