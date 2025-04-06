using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Data;
using System.Windows.Forms;

namespace Assignment
{
    public partial class ChefIngredients : Form
    {
        private IngredientManager ingredientManager;

        public ChefIngredients(string Email_ID)
        {
            InitializeComponent();
            ingredientManager = new IngredientManager();
            LoadData();
        }

        private void ChefIngredients_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.DataSource = ingredientManager.LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool success = ingredientManager.AddIngredient(txtIngredientID.Text, txtIngredientName.Text, txtQuantity.Text);
            if (success)
            {
                MessageBox.Show("Ingredient added successfully!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Ingredient ID already exists. Cannot add duplicate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool success = ingredientManager.UpdateIngredient(txtIngredientID.Text, txtIngredientName.Text, txtQuantity.Text);
            if (success)
            {
                MessageBox.Show("Ingredient updated successfully!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Ingredient ID does not exist. Cannot update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool success = ingredientManager.DeleteIngredient(txtIngredientID.Text);
            if (success)
            {
                MessageBox.Show("Ingredient deleted successfully!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Ingredient ID does not exist. Cannot delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ingredientManager.SearchIngredient(txtSearch.Text);
        }

        private void grpModify_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
