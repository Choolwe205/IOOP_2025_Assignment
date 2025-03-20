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
    public partial class MainCustomerPanel : Form
    {
        public MainCustomerPanel()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomerReservation newForm = new CustomerReservation();
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.TopLevel = false; // Allows the form to be embedded in a container
            newForm.Dock = DockStyle.Fill; // Makes it fill the panel
            pmainpanel.Controls.Clear(); // Removes previous content
            pmainpanel.Controls.Add(newForm);
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CustomerViewReservation newForm = new CustomerViewReservation();
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.TopLevel = false; // Allows the form to be embedded in a container
            newForm.Dock = DockStyle.Fill; // Makes it fill the panel
            pmainpanel.Controls.Clear(); // Removes previous content
            pmainpanel.Controls.Add(newForm);
            newForm.Show();

        }

        private void ViewOrder_Click(object sender, EventArgs e)
        {
            CustomerViewOrder newForm = new CustomerViewOrder();
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.TopLevel = false; // Allows the form to be embedded in a container
            newForm.Dock = DockStyle.Fill; // Makes it fill the panel
            pmainpanel.Controls.Clear(); // Removes previous content
            pmainpanel.Controls.Add(newForm);
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CustomerEditDetails newForm = new CustomerEditDetails();
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.TopLevel = false; // Allows the form to be embedded in a container
            newForm.Dock = DockStyle.Fill; // Makes it fill the panel
            pmainpanel.Controls.Clear(); // Removes previous content
            pmainpanel.Controls.Add(newForm);
            newForm.Show();
        }

        private void Order_Click(object sender, EventArgs e)
        {
            CustomerOrder newForm = new CustomerOrder();
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.TopLevel = false; // Allows the form to be embedded in a container
            newForm.Dock = DockStyle.Fill; // Makes it fill the panel
            pmainpanel.Controls.Clear(); // Removes previous content
            pmainpanel.Controls.Add(newForm);
            newForm.Show();
        }
    }
}
