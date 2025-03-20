using System;
using System.Data;
using System.Windows.Forms;

namespace Assignment.Manager
{
    public partial class Form3 : Form
    {
        private HallManager hallManager = new HallManager(); // Create an instance of HallManager

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iOOP_DatabaseDataSet2.Halls' table. You can move, or remove it, as needed.
            this.hallsTableAdapter2.Fill(this.iOOP_DatabaseDataSet2.Halls);
            // TODO: This line of code loads data into the 'iOOP_DatabaseDataSet1.Halls' table. You can move, or remove it, as needed.
            LoadHalls();
        }

        // Method to load halls into the DataGridView
        private void LoadHalls()
        {
            dataGridView1.DataSource = hallManager.GetAllHalls();
           
        }

        // 🟢 Add Hall
        private void btnSaveAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCapacity1.Text))
                {
                    MessageBox.Show("Please enter the hall capacity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int capacity = int.Parse(txtCapacity1.Text);
                hallManager.AddHall(capacity);

                LoadHalls(); // Refresh DataGridView
                MessageBox.Show("Hall added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCapacity1.Clear();
                panelAdd.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 🟡 Edit Hall (Uses TextBox instead of ComboBox)
        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtHallID2.Text) ||
                    string.IsNullOrWhiteSpace(txtCapacity2.Text) ||
                    comboAvailability2.SelectedItem == null)
                {
                    MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Convert Hall ID safely
                if (!int.TryParse(txtHallID2.Text, out int hallID))
                {
                    MessageBox.Show("Invalid Hall ID. Please enter a numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Convert Capacity safely
                if (!int.TryParse(txtCapacity2.Text, out int capacity))
                {
                    MessageBox.Show("Invalid capacity value. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string availability = comboAvailability2.SelectedItem.ToString();

                // Check if Hall ID exists before updating
                DataTable dt = hallManager.GetHallByID(hallID);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Hall ID not found. Please enter a valid Hall ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                hallManager.EditHall(hallID, capacity, availability);

                LoadHalls();  // Refresh DataGridView
                MessageBox.Show("Hall details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtHallID2.Clear();
                txtCapacity2.Clear();
                comboAvailability2.SelectedIndex = -1;
                panelEdit.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 🔴 Delete Hall
        private void btnSaveDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtHallID3.Text))
                {
                    MessageBox.Show("Please enter the Hall ID to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int hallID = int.Parse(txtHallID3.Text);

                hallManager.DeleteHall(hallID);

                LoadHalls(); // Refresh DataGridView
                MessageBox.Show("Hall deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtHallID3.Clear();
                panelDelete.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtHallID2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtHallID2.Text, out int hallID))
            {
                DataTable dt = hallManager.GetHallByID(hallID);

                if (dt.Rows.Count > 0)
                {
                    txtCapacity2.Text = dt.Rows[0]["Capacity"].ToString();
                    comboAvailability2.SelectedItem = dt.Rows[0]["Availability"].ToString();
                }
                else
                {
                    txtCapacity2.Clear();
                    comboAvailability2.SelectedIndex = -1;
                }
            }
        }
        private void btnAddHalls_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = true;
           
        }

        private void btnEditHall_Click(object sender, EventArgs e)
        {
            panelEdit.Visible = true;
        }

        private void btnDeleteHall_Click(object sender, EventArgs e)
        {
            panelDelete.Visible = true;
        }


        private void btnSaveEdit_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtHallID2.Text) ||
                    string.IsNullOrWhiteSpace(txtCapacity2.Text) ||
                    comboAvailability2.SelectedItem == null)
                {
                    MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Convert Hall ID safely
                if (!int.TryParse(txtHallID2.Text, out int hallID))
                {
                    MessageBox.Show("Invalid Hall ID. Please enter a numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Convert Capacity safely
                if (!int.TryParse(txtCapacity2.Text, out int capacity))
                {
                    MessageBox.Show("Invalid capacity value. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string availability = comboAvailability2.SelectedItem.ToString();

                // Check if Hall ID exists before updating
                DataTable dt = hallManager.GetHallByID(hallID);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Hall ID not found. Please enter a valid Hall ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                hallManager.EditHall(hallID, capacity, availability);

                LoadHalls();  // Refresh DataGridView
                MessageBox.Show("Hall details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear inputs
                txtHallID2.Clear();
                txtCapacity2.Clear();
                comboAvailability2.SelectedIndex = -1;
                panelEdit.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveDelete_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHallID3.Text))
            {
                MessageBox.Show("Please enter a Hall ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtHallID3.Text, out int hallID))
            {
                MessageBox.Show("Invalid Hall ID. Please enter a numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure you want to delete Hall ID {hallID}?",
                                                  "Confirm Deletion",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                HallManager hallManager = new HallManager();
                hallManager.DeleteHall(hallID);
                MessageBox.Show("Hall deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the text field after deletion
                txtHallID3.Text = "";

                // Refresh DataGridView if needed
                dataGridView1.DataSource = hallManager.GetAllHalls();
                panelDelete.Visible = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
