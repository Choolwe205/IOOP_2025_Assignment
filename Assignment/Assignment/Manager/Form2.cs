using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Assignment.Manager
{
    public partial class Form2 : Form
    {
        private MenuManager MenuManager = new MenuManager();
        private byte[] selectedImageBytes = null;


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iOOP_DatabaseDataSet3.Menu' table. You can move, or remove it, as needed.
            //this.menuTableAdapter2.Fill(this.iOOP_DatabaseDataSet3.Menu);




            LoadMenuItems();

        }
        private void LoadMenuItems()
        {
            dgvMenu.DataSource = MenuManager.GetAllMenuItems(); // Assuming you have a method to get data
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            pnlEditItem.Visible = true;
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            pnlAddItem.Visible = true;
        }

        private void btnSaveAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddItem.Text) ||
                string.IsNullOrWhiteSpace(txtDescription1.Text) ||
                string.IsNullOrWhiteSpace(txtPrice1.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string foodID = txtAddItem.Text;
            decimal price;

            if (!decimal.TryParse(txtPrice1.Text, out price))
            {
                MessageBox.Show("Invalid price. Enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool success = MenuManager.AddMenuItem(foodID, txtDescription1.Text, price, selectedImageBytes);

            if (success)
            {
                MessageBox.Show("Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMenuItems();
                txtAddItem.Clear();
                txtDescription1.Clear();
                txtPrice1.Clear();
                pictureBoxAdd.Image = null; // Clear Image
                selectedImageBytes = null;
                pnlAddItem.Visible = false;
            }
            else
            {
                MessageBox.Show("Error adding item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtSaveEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEditID.Text) ||
                string.IsNullOrWhiteSpace(txtEditDescription.Text) ||
                string.IsNullOrWhiteSpace(txtEditPrice.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string foodID = txtEditID.Text;
            decimal price;

            if (!decimal.TryParse(txtEditPrice.Text, out price))
            {
                MessageBox.Show("Invalid price. Enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool success = MenuManager.UpdateMenuItem(foodID, txtEditDescription.Text, price, selectedImageBytes);

            if (success)
            {
                MessageBox.Show("Item updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMenuItems(); // Refresh menu list
                pictureBoxEdit.Image = null; // Clear image after update
                selectedImageBytes = null; // Reset image bytes
                pnlEditItem.Visible = false;
            }
            else
            {
                MessageBox.Show("Error updating item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteItem1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDeleteItem.Text))
            {
                MessageBox.Show("Please enter the Food ID to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string foodID = txtDeleteItem.Text;

            DialogResult confirm = MessageBox.Show($"Are you sure you want to delete Food ID {foodID}?",
                                                   "Confirm Delete",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                bool success = MenuManager.DeleteMenuItem(foodID);

                if (success)
                {
                    MessageBox.Show("Item deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMenuItems(); // Refresh menu list
                    txtDeleteItem.Clear();
                }
                else
                {
                    MessageBox.Show("Error deleting item. Make sure the Food ID exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            pnlDeleteItem.Visible = false;
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            pnlDeleteItem.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Select an Image"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                selectedImageBytes = File.ReadAllBytes(imagePath); // Convert image to byte array
                pictureBoxAdd.Image = Image.FromFile(imagePath); // Display image in PictureBox
            }
        }

        private void btnEditImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Select an Image"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                selectedImageBytes = File.ReadAllBytes(imagePath); // Convert image to byte array
                pictureBoxEdit.Image = Image.FromFile(imagePath); // Display new image in PictureBox
            }
        }
    }
}
