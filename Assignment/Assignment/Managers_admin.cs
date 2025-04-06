using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment.Manager;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment
{
    public partial class Managers_admin : Form
    {
        int count;
        string search_user;
        int page_number;

        public Managers_admin(int page)
        {
            InitializeComponent();
            page_number = page;


            if (page_number == 1)
            {
                Flow_Pannel_Show("Admin", search_user);
            }
            else if (page_number == 2)
            {
                Flow_Pannel_Show("Manager", search_user);
            }
            else if (page_number == 3)
            {
                Flow_Pannel_Show("Reservation Coordinator", search_user);
            }
            else if (page_number == 4)
            {
                Flow_Pannel_Show("Chef", search_user);
            }
            else if (page_number == 5)
            {
                Flow_Pannel_Show("Customer", search_user);
            }
        }

            
        

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Flow_Pannel_Show(string role, string search)
        {
            Each_User_class Each_user = new Each_User_class();

            count = Each_user.number_of_rows("Users");

            

            int count_2 = 1;
            Admin_users[] admin_Users = new Admin_users[count + 1];
            string username;
            if (search == null)
            {
                while (count_2 <= (count))
                {
                    int modulus = count_2 % 2;
                    username = Each_user.display_user(role, count_2);

                    if (username != "NOT IN ROLE")
                    {
                        admin_Users[count_2] = new Admin_users();
                        admin_Users[count_2].user_username = username;
                        admin_Users[count_2].LoadForm += Change_pannel;
                        flowLayoutPanel1.Controls.Add(admin_Users[count_2]);
                        if (modulus == 0)
                        {
                            admin_Users[count_2].BackColor = Color.DarkCyan;
                        }

                    }


                    count_2 += 1;
                }
            }
            else 
            {
                while (count_2 <= (count))
                {
                    int number_of_letters = search.Count();
                    int modulus = count_2 % 2;


                    username = Each_user.display_user(role, count_2);
                    string search_username = username.Substring(0, number_of_letters);


                    if (username != "NOT IN ROLE" && search_username == search_user)
                    {
                        admin_Users[count_2] = new Admin_users();
                        admin_Users[count_2].user_username = username;
                        admin_Users[count_2].LoadForm += Change_pannel;
                        
                        flowLayoutPanel1.Controls.Add(admin_Users[count_2]);
                        if (modulus == 0)
                        {
                            admin_Users[count_2].BackColor = Color.DarkCyan;
                        }

                    }


                    count_2 += 1;
                }
            }
        }

        private void Change_pannel(string username)
        {
            panel1. Controls.Clear();
            Form2 form2 = new Form2(username);
            form2.TopLevel = false;
            panel1.Controls.Add(form2);
            panel1.Visible = true;
            form2.BringToFront();
            form2.Show();
        }

        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search_user = textBox1.Text;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            search_user = textBox1.Text;

            flowLayoutPanel1.Controls.Clear();
            if (page_number == 1)
            {
                Flow_Pannel_Show("Admin", search_user);
            }
            else if (page_number == 2)
            {
                Flow_Pannel_Show("Manager", search_user);
            }
            else if (page_number == 3)
            {
                Flow_Pannel_Show("Reservation Coordinator", search_user);
            }
            else if (page_number == 4)
            {
                Flow_Pannel_Show("Chef", search_user);
            }
            else if (page_number == 5)
            {
                Flow_Pannel_Show("Customer", search_user);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Visible = true;
            AddUsers user_add = new AddUsers(page_number);
            user_add.TopLevel = false;
            panel1.Controls.Add(user_add);
            user_add.BringToFront();
            user_add.Show();
        }
    }
}
