using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classespractice
{
    public partial class Customer_Menu : Form
    {
        public Customer_Menu()
        {
            InitializeComponent();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            frmMalaysianMenu fourthform = new frmMalaysianMenu();
            fourthform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmWesternMenu sixthform=new frmWesternMenu(); 
            sixthform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmChineseMenu chineseform=new frmChineseMenu();   
            chineseform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmIndianMenu indianform=new FrmIndianMenu();
            indianform.Show();
        }
    }
}
