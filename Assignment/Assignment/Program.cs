using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



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
            Application.Run(new Admininstrator("SharafMo@gmail.com"));   
=======

            Application.Run(new Main_Dashboard("mwilachibesa@gmail.com"));
            Application.Run(new CustomerMainPanel());

           

>>>>>>> eff118ccd83c85c75188db7f7ba5d9c7e0b1142c
        }
    }
}