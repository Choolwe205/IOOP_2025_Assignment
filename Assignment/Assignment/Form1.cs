using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Assignment.Manager;



namespace Assignment
{
    public partial class FormLogin : Form
    {
        int count = 0;


        private int logging_in(int counter)
        {
            Login login = new Login(txtUsername.Text, txtPassword.Text);
            string page = login.Login_algorithm();
            if (page == "Customer")
            {
                MessageBox.Show("You are Customer");
                return counter = 19;

            }
            else if (page == "Chef")
            {
                MessageBox.Show("You are a Chef");
                return counter = 19;
            }
            else if (page == "Reservation Coordinator")
            {
                MessageBox.Show("You are a Reservation Coorrdinator");
                return counter = 19;
            }
            else if (page == "Manager")
            {
                Form1 form1 = new Form1(txtUsername.Text);
                form1.Show();
                return counter = 19;
            }
            else if (page == "Admin")
            {
                Admininstrator admin = new Admininstrator(txtUsername.Text);
                admin.Show();
                return counter = 19;
            }
            else if (page == "Doesn't Exist")
            {
                MessageBox.Show("The Given Email Does Not Exist");
                return counter += 1;
            }
            else if (page == "Invalid Password")
            {
                MessageBox.Show("The Password Is Invalid");
                return counter += 1;
            }
            else
            {
                return counter;
            }
        }





        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (count < 5)
            {
                count = logging_in(count);
            }
            else if (count >= 5)
            {
                MessageBox.Show("Multiple Log In Detected");
                this.Close();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Sign_up_button_Click(object sender, EventArgs e)
        {
             
            Sign_up_form Sign_Up_Form = new Sign_up_form();
            Sign_Up_Form.Show();
            this.Hide();
            
            
        }
    }
}
