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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Assignment
{
    public partial class UserFeedback : UserControl
    {
        private string username;
        private string feedback;
        public string user_username
        {
            get { return username; }
            set { username = value; username_lbl.Text = value; }
        }

        public string user_feedback
        {
            get { return feedback; }
            set { feedback = value; label2.Text = value; }
        }


        public UserFeedback()
        {
            InitializeComponent();


            



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
