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
    public partial class AddUsers : Form
    {
        int page;

        public AddUsers(int page_no)
        {
            InitializeComponent();
            page = page_no;

            if (page == 1)
            {
                role_lbl.Text = "Add Admin";
            }
            else if (page == 2)
            {
                role_lbl.Text = "Add Manager";
            }
            else if (page == 3)
            {
                role_lbl.Text = "Add Reservation Coordinator";
            }
            else if (page == 4)
            {
                role_lbl.Text = "Add Chef";
            }
            else if (page == 5)
            {
                role_lbl.Text = "Add Customer";
            }
        }

        private void AddUsers_Load(object sender, EventArgs e)
        {

        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                add_user("Admin");
            }
            else if (page == 2)
            {
                add_user("Manager");
            }
            else if (page == 3)
            {
                add_user("Reservation Coordinator");
            }
            else if (page == 4)
            {
                add_user("Chef");
            }
            else if (page == 5)
            {
                add_user("Customer");
            }
        }

        private void add_user(string role)
        {
            Add_users add = new Add_users(Email_txtbox.Text, name_txtbox.Text, password_txtbox.Text, phone_number_txtbox.Text);
            string Email_Validity = add.Valid_Email();
            string Password_Validity = add.Secure_password();
            string Phone_Number = add.valid_number();
            
            if (Email_Validity == "valid" &&  Password_Validity == "strong" &&  Phone_Number == "valid")
            {
                if (role == "Admin")
                {
                    add.add_admin();
                    MessageBox.Show("Admin Added Successfully");
                }
                else if (role == "Manager")
                {
                    add.add_manager();
                    MessageBox.Show("Manager Added Successfully");
                }
                else if (role == "Reservation Coordinator")
                {
                    add.add_reservation_coordinator();
                    MessageBox.Show("Reservation Coordinator Added Successfully");
                }
                else if (role == "Chef")
                {
                    add.add_chef();
                    MessageBox.Show("Chef Added Successfully");
                }
                else if (role == "Customer")
                {
                    add.add_customers();
                    MessageBox.Show("Customer Added Successfully");
                }
            }
            else
            {
                MessageBox.Show("The Details Are Not In the Desired Order, Please Recheck");
            }
        }

        private void role_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void phone_number_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
