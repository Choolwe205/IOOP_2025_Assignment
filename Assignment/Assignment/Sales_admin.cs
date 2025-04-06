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
    public partial class Sales_admin : Form
    {
        string monthly_sale;
        string month_string = DateTime.Now.ToString("MM");
        string year_string = DateTime.Now.ToString("yyyy");
        

        public Sales_admin()
        {
            InitializeComponent();

            Sales sale = new Sales(month_string, year_string);
            SalesDisplay_lbl.Text = (sale.view_sales()).ToString() + "RM";
            orders_number.Text = (sale.view_total_orders()).ToString() + "RM"; 
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Sales_admin_Load(object sender, EventArgs e)
        {

        }

        private void chef_btn_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales(month_string, year_string);
            chef_lbl.Text = (sales.view_chef_sales(textBox1.Text)).ToString() + "RM";
        }

        private void chef_lbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void increase_btn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
