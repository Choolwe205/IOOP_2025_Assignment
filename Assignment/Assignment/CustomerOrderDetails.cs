using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class CustomerOrderDetails : Form
    {
        public CustomerOrderDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All Done? Great!");
            this.Close();
        }
    }
}
