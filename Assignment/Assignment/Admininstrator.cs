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
    public partial class Admininstrator : Form
    {

        int sideBar_width;
        int max_sideBar_width = 274;
        int min_sideBar_width = 48;
        bool expand_condition = true;



        public Admininstrator(string Email_ID)
        {
            InitializeComponent();
            Email_ID_lbl.Text = Email_ID;   
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void sales_btn_Click(object sender, EventArgs e)
        {
            Main_view_pannel.Controls.Clear();
            Sales_admin sales_form = new Sales_admin();
            sales_form.TopLevel = false;
            Main_view_pannel.Controls.Add(sales_form);
            sales_form.BringToFront();
            sales_form.Show();

        }

        private void Chef_btn_Click(object sender, EventArgs e)
        {

        }

        private void res_btn_Click(object sender, EventArgs e)
        {

        }

        private void users_btn_Click(object sender, EventArgs e)
        {

        }




        //MENU BAR CONTROLS 
        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Maximize_Click(object sender, EventArgs e)
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

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Main_view_pannel.Controls.Clear();
            Form2 form2 = new Form2(Email_ID_lbl.Text);
            form2.TopLevel = false;
            Main_view_pannel.Controls.Add(form2);
            form2.BringToFront();
            form2.Show();
        }

        private void SideBar_Timer_Tick(object sender, EventArgs e)
        {
            if (expand_condition == false)
            {
                SideBar.Width -= 4;
                if (SideBar.Width == 48)
                {
                    SideBar_Timer.Stop();
                }
            }
            else if (expand_condition == true)
            {
                SideBar.Width += 4;
                if (SideBar.Width == 280)
                {
                    SideBar_Timer.Stop();
                }
            }
        }

        private void Expand_Click(object sender, EventArgs e)
        {
            sideBar_width = SideBar.Width;


            if (sideBar_width == 280)
            {
                expand_condition = false;
            }
            else if (sideBar_width == 48)
            {
                expand_condition = true;
            }


            SideBar_Timer.Start();
        }

        private void Admininstrator_Load(object sender, EventArgs e)
        {
            
        }

        private void Main_view_pannel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main_view_pannel.Controls.Clear();
            Managers_admin managers_admin = new Managers_admin(2);
            managers_admin.TopLevel = false;
            Main_view_pannel.Controls.Add(managers_admin);
            managers_admin.BringToFront();
            managers_admin.Show();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Main_view_pannel.Controls.Clear();
            Managers_admin managers_admin = new Managers_admin(4);
            managers_admin.TopLevel = false;
            Main_view_pannel.Controls.Add(managers_admin);
            managers_admin.BringToFront();
            managers_admin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main_view_pannel.Controls.Clear();
            Managers_admin managers_admin = new Managers_admin(3);
            managers_admin.TopLevel = false;
            Main_view_pannel.Controls.Add(managers_admin);
            managers_admin.BringToFront();
            managers_admin.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main_view_pannel.Controls.Clear();
            Managers_admin managers_admin = new Managers_admin(5);
            managers_admin.TopLevel = false;
            Main_view_pannel.Controls.Add(managers_admin);
            managers_admin.BringToFront();
            managers_admin.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Main_view_pannel.Controls.Clear();
            FeedbackForm Form = new FeedbackForm();
            Form.TopLevel = false;
            Main_view_pannel.Controls.Add(Form);
            Form.BringToFront();
            Form.Show();
        }
    }
}
