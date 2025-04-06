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
    public partial class ProfileEditCustomer : Form
    {
        public ProfileEditCustomer()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email_id="choolwe205@gmail.com";
            ProfileEditClass view=new ProfileEditClass("","","");
            string details = view.ViewProfileDetails(email_id);
            details = details.Trim();
            label9.Text=details;

        }
    }
}
