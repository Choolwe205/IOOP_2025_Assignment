using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.Manager
{
    public partial class Form2 : Form
    {
        private MenuManager MenuManager = new MenuManager();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
         
            LoadMenuItems();

        }
        private void LoadMenuItems()
        {
            dgvMenu.DataSource = MenuManager.GetAllMenuItems(); // Assuming you have a method to get data
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            pnlAddItem.Visible = true;
        }

        private void btnSaveAdd_Click(object sender, EventArgs e)
        {
            string description = txtDescription1.Text;
            if (string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(txtPrice1.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal price;
            if (!decimal.TryParse(txtPrice1.Text, out price))
            {
                MessageBox.Show("Invalid price. Enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool success = MenuManager.AddMenuItem(description, price);
            if (success)
            {
                MessageBox.Show("Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMenuItems(); // Refresh menu list
                txtDescription1.Clear();
                txtPrice1.Clear();
                pnlAddItem.Visible = false;
            }
            else
            {
                MessageBox.Show("Error adding item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
