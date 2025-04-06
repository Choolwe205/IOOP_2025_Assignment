using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form2 : Form
    {
        string email;
        string name;
        string phone_number;
        string password;
        public event Action Close_program;


        public Form2(string Email_ID)
        {
            InitializeComponent();

            email = Email_ID;
            run();
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            email_lbl.Visible = true;
        }

        private void email_edit_Click(object sender, EventArgs e)
        {
            
        }

        private void password_edit_Click(object sender, EventArgs e)
        {
            password_txtbox.Visible = true;
        }

        private void phone_number_edit_Click(object sender, EventArgs e)
        {
            phone_number_txtbox.Visible = true;
        }

        private void name_edit_Click(object sender, EventArgs e)
        {
            name_txtbox.Visible = true;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (name_txtbox.Visible == true)
            {
                name = name_txtbox.Text;
            }
            else
            {
                name = name_lbl.Text;
            }


            if (password_txtbox.Visible == true)
            {
                password = password_txtbox.Text;
            }
            else
            {
                password = password_lbl.Text;
            }


            if (phone_number_txtbox.Visible == true)
            {
                phone_number = phone_number_txtbox.Text;
            }
            else
            {
                phone_number = phone_number_lbl.Text;
            }


            Add_users user = new Add_users(email_lbl.Text, name, password, phone_number);
            string security = user.Secure_password();
            string number = user.valid_number();

            if (security == "strong" && number == "valid")
            {
                Edit_Users edit_user = new Edit_Users(email_lbl.Text, name, password, phone_number);
                edit_user.edit_Users();
                if (name_txtbox.Visible || phone_number_txtbox.Visible || password_txtbox.Visible)
                {
                    MessageBox.Show("Successfully Updated");
                }
                else
                {
                    MessageBox.Show("No changes have been made");
                }
            }

            run();
        }

        private void run()
        {
            Retrieve_user_info user_info = new Retrieve_user_info(email);
            email_lbl.Text = email;
            name_lbl.Text = user_info.get_name();
            password_lbl.Text = user_info.get_password();
            phone_number_lbl.Text = user_info.get_phonenumber();

            name_txtbox.Visible = false;
            password_txtbox.Visible = false;
            phone_number_txtbox.Visible = false;
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
