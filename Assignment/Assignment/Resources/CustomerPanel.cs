using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.Resources
{
    public partial class CustomerMainPanel : Form
    {
        public CustomerMainPanel()
        {
            InitializeComponent();
        }

        private void CustomerMainPanel_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
       
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) 
            
            { 
                WindowState = FormWindowState.Maximized;
            }
            else 
            {
                WindowState = FormWindowState.Normal;            
            }
         
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState= FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Signing Out Already? Come Again!");
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
            MessageBox.Show("Exited");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();

            // Create a new instance of the child form
            ViewOrderCustomer vieworderCustomer = new ViewOrderCustomer();

            // Set it as a non-top-level control
            vieworderCustomer.TopLevel = false;

            // Dock the form inside the panel
            vieworderCustomer.Dock = DockStyle.Fill;

            // Add the form to the panel and show it
            mainpanel.Controls.Add(vieworderCustomer);
            vieworderCustomer.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();

            // Create a new instance of the child form
            ViewReservationCustomer viewReservation = new ViewReservationCustomer();

            // Set it as a non-top-level control
            viewReservation.TopLevel = false;

            // Dock the form inside the panel
            viewReservation.Dock = DockStyle.Fill;

            // Add the form to the panel and show it
            mainpanel.Controls.Add(viewReservation);
            viewReservation.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Check if the panel already has a child form and remove it
            mainpanel.Controls.Clear();

            // Create a new instance of the child form
            OrderCustomer orderCustomer = new OrderCustomer();

            // Set it as a non-top-level control
            orderCustomer.TopLevel = false;

            // Dock the form inside the panel
            orderCustomer.Dock = DockStyle.Fill;

            // Add the form to the panel and show it
            mainpanel.Controls.Add(orderCustomer);
            orderCustomer.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Check if the panel already has a child form and remove it
            mainpanel.Controls.Clear();

            // Create a new instance of the child form
            ProfileEditCustomer profileEditCustomer = new ProfileEditCustomer();

            // Set it as a non-top-level control
            profileEditCustomer.TopLevel = false;

            // Dock the form inside the panel
            profileEditCustomer.Dock = DockStyle.Fill;

            // Add the form to the panel and show it
            mainpanel.Controls.Add(profileEditCustomer);
            profileEditCustomer.Show();
        }
    }
}
