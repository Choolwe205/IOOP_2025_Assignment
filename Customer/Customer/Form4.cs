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
    public partial class frmMalaysianMenu : Form
    {
        public frmMalaysianMenu()
        {
            InitializeComponent();
        }

        private void frmMalaysianMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Customer_Menu thirdForm = new Customer_Menu();
            thirdForm.Show();
        }
    }
}
