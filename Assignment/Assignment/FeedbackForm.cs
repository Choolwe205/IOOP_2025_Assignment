using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Assignment
{
    public partial class FeedbackForm : Form
    {
        string search_user;


        public FeedbackForm()
        {
            InitializeComponent();

            flow_panel_stuff(null);
            
        }

        private void FeedbackForm_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flow_panel_stuff(string search)
        {
            flowLayoutPanel1.Controls.Clear();
            Each_User_class user = new Each_User_class();
            int number_of_rows = user.number_of_rows("Feedback_Table");

            int count = 1;
            UserFeedback[] form = new UserFeedback[number_of_rows + 1];
            string name;
            string feedback;
            if (search == null)
            {
                
                while (count <= (number_of_rows))
                {
                    int modulus = count % 2;
                    name = user.Display_general_users("Feedback_Table", count);
                    string message = user.side_content("Feedback_Table", "Message", name);
                    form[count] = new UserFeedback();
                    form[count].user_username = name;
                    form[count].user_feedback = $"' {message} '";
                    flowLayoutPanel1.Controls.Add(form[count]);
                    if (modulus == 0)
                    {
                        form[count].BackColor = Color.DarkCyan;
                    }
                    count += 1;
                }
            }
            else
            {
                while (count <= (number_of_rows))
                {
                    int number_of_letters = search.Count();
                    int modulus = count % 2;
                    name = user.Display_general_users("Feedback_Table", count);
                    string search_username = name.Substring(0, number_of_letters);
                    string message = user.side_content("Feedback_Table", "Message", name);
                    if (search_username == search)
                    {
                        form[count] = new UserFeedback();
                        form[count].user_username = name;
                        form[count].user_feedback = $"' {message} '";
                        flowLayoutPanel1.Controls.Add(form[count]);
                        if (modulus == 0)
                        {
                            form[count].BackColor = Color.DarkCyan;
                        }
                    }
                    
                    count += 1;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            search_user = textBox1.Text;

            flow_panel_stuff(search_user);
        }
    }
}
