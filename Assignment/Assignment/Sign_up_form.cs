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
using System.Threading;



namespace Assignment
{
    public partial class Sign_up_form : Form
    {



        public Sign_up_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string Email = Email_textbox.Text;
            string Name = Name_textbox.Text;
            string Password = Password_textbox.Text;
            string Phone_number = Phonenumber_textbox.Text;
            string Password_again = Password_again_textbox.Text;

            Check_and_add_credentials(Email, Name, Password, Phone_number, Password_again);


        }

        private void Return_Click(object sender, EventArgs e)
        {

        }

        private bool Check_and_add_credentials(string Email, string Name, string Password, string Phone_number, string Password_again)
        {
            bool proceed = false;




            Add_users Add_customers_class = new Add_users(Email, Name, Password, Phone_number);
            string Email_validity = Add_customers_class.Valid_Email();
            string Password_security = Add_customers_class.Secure_password();
            int Email_existence = Add_customers_class.Email_existence();
            string Number_Validity = Add_customers_class.valid_number();
            string Name_written = Add_customers_class.Name_check();




            if (Email_validity == "Invalid")
            {
                MessageBox.Show("Enter a Valid Email");
            }
            else if (Password_security == "Has spaces")
            {
                MessageBox.Show("Spaces are not allowed");
            }
            else if (Name_written == "null")
            {
                MessageBox.Show("Name field is empty");
            }
            else if (Password_security == "weak")
            {
                MessageBox.Show("Password is not secure, Make sure you use numbers and symbols to secure it");
            }
            else if (Password_security == "Password too Short")
            {
                MessageBox.Show("Password Too Short");
            }
            else if (Password != Password_again)
            {
                MessageBox.Show("Password does not match");
            }
            else if (Number_Validity == "invalid")
            {
                MessageBox.Show("Enter a valid Phone Number");
            }
            else if (Email_existence > 0)
            {
                MessageBox.Show("Email has already been used to Sign In, Please use a different Email");
            }
            else
            {
                Add_customers_class.add_customers();
                MessageBox.Show("Sign up successful");
            }
            return proceed;
        }
    }
}