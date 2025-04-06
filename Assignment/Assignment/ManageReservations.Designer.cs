namespace Assignment
{
    partial class ManageReservations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReservationID_txtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.ReservationType_txtbox = new System.Windows.Forms.TextBox();
            this.status_txtbox = new System.Windows.Forms.TextBox();
            this.date_txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Edit_btn = new System.Windows.Forms.Button();
            this.confirm_btn2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtreserveidDelete = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.btnbackMR = new System.Windows.Forms.Button();
            this.lblReservations = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(405, 373);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.ReservationID_txtbox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.confirm_btn);
            this.panel1.Controls.Add(this.ReservationType_txtbox);
            this.panel1.Controls.Add(this.status_txtbox);
            this.panel1.Controls.Add(this.date_txtbox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(412, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 315);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ReservationID_txtbox
            // 
            this.ReservationID_txtbox.BackColor = System.Drawing.Color.White;
            this.ReservationID_txtbox.Location = new System.Drawing.Point(186, 17);
            this.ReservationID_txtbox.Name = "ReservationID_txtbox";
            this.ReservationID_txtbox.Size = new System.Drawing.Size(232, 26);
            this.ReservationID_txtbox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(61, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Reservation ID:";
            // 
            // confirm_btn
            // 
            this.confirm_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.confirm_btn.ForeColor = System.Drawing.Color.DarkGreen;
            this.confirm_btn.Location = new System.Drawing.Point(92, 240);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(114, 55);
            this.confirm_btn.TabIndex = 7;
            this.confirm_btn.Text = "confirm";
            this.confirm_btn.UseVisualStyleBackColor = false;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // ReservationType_txtbox
            // 
            this.ReservationType_txtbox.BackColor = System.Drawing.Color.White;
            this.ReservationType_txtbox.Location = new System.Drawing.Point(187, 161);
            this.ReservationType_txtbox.Name = "ReservationType_txtbox";
            this.ReservationType_txtbox.Size = new System.Drawing.Size(232, 26);
            this.ReservationType_txtbox.TabIndex = 6;
            // 
            // status_txtbox
            // 
            this.status_txtbox.BackColor = System.Drawing.Color.White;
            this.status_txtbox.Location = new System.Drawing.Point(186, 109);
            this.status_txtbox.Name = "status_txtbox";
            this.status_txtbox.Size = new System.Drawing.Size(232, 26);
            this.status_txtbox.TabIndex = 5;
            // 
            // date_txtbox
            // 
            this.date_txtbox.BackColor = System.Drawing.Color.White;
            this.date_txtbox.Location = new System.Drawing.Point(186, 61);
            this.date_txtbox.Name = "date_txtbox";
            this.date_txtbox.Size = new System.Drawing.Size(232, 26);
            this.date_txtbox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(44, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reservation Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(120, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date of Event:";
            // 
            // Edit_btn
            // 
            this.Edit_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.Edit_btn.ForeColor = System.Drawing.Color.DarkGreen;
            this.Edit_btn.Location = new System.Drawing.Point(440, 526);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.Size = new System.Drawing.Size(114, 55);
            this.Edit_btn.TabIndex = 8;
            this.Edit_btn.Text = "Edit";
            this.Edit_btn.UseVisualStyleBackColor = false;
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
            // 
            // confirm_btn2
            // 
            this.confirm_btn2.BackColor = System.Drawing.Color.OrangeRed;
            this.confirm_btn2.ForeColor = System.Drawing.Color.DarkGreen;
            this.confirm_btn2.Location = new System.Drawing.Point(144, 223);
            this.confirm_btn2.Name = "confirm_btn2";
            this.confirm_btn2.Size = new System.Drawing.Size(114, 55);
            this.confirm_btn2.TabIndex = 8;
            this.confirm_btn2.Text = "confirm";
            this.confirm_btn2.UseVisualStyleBackColor = false;
            this.confirm_btn2.Click += new System.EventHandler(this.confirm_btn2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Controls.Add(this.confirm_btn2);
            this.panel2.Controls.Add(this.txtreserveidDelete);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(860, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 319);
            this.panel2.TabIndex = 10;
            this.panel2.Visible = false;
            // 
            // txtreserveidDelete
            // 
            this.txtreserveidDelete.BackColor = System.Drawing.Color.White;
            this.txtreserveidDelete.Location = new System.Drawing.Point(144, 26);
            this.txtreserveidDelete.Name = "txtreserveidDelete";
            this.txtreserveidDelete.Size = new System.Drawing.Size(232, 26);
            this.txtreserveidDelete.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Reservation ID:";
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.Delete_btn.ForeColor = System.Drawing.Color.DarkGreen;
            this.Delete_btn.Location = new System.Drawing.Point(587, 526);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(114, 55);
            this.Delete_btn.TabIndex = 12;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // btnbackMR
            // 
            this.btnbackMR.BackColor = System.Drawing.Color.OrangeRed;
            this.btnbackMR.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnbackMR.Location = new System.Drawing.Point(736, 526);
            this.btnbackMR.Name = "btnbackMR";
            this.btnbackMR.Size = new System.Drawing.Size(94, 55);
            this.btnbackMR.TabIndex = 10;
            this.btnbackMR.Text = "back";
            this.btnbackMR.UseVisualStyleBackColor = false;
            this.btnbackMR.Click += new System.EventHandler(this.btnbackMR_Click);
            // 
            // lblReservations
            // 
            this.lblReservations.AutoSize = true;
            this.lblReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservations.Location = new System.Drawing.Point(60, 39);
            this.lblReservations.Name = "lblReservations";
            this.lblReservations.Size = new System.Drawing.Size(278, 37);
            this.lblReservations.TabIndex = 13;
            this.lblReservations.Text = "RESERVATIONS";
            // 
            // ManageReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.BackgroundImage = global::Assignment.Properties.Resources.cover;
            this.ClientSize = new System.Drawing.Size(1206, 652);
            this.Controls.Add(this.lblReservations);
            this.Controls.Add(this.btnbackMR);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Edit_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ManageReservations";
            this.Text = "ManageReservations";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.TextBox ReservationType_txtbox;
        private System.Windows.Forms.TextBox status_txtbox;
        private System.Windows.Forms.TextBox date_txtbox;
        private System.Windows.Forms.Button Edit_btn;
        private System.Windows.Forms.Button confirm_btn2;
        private System.Windows.Forms.TextBox txtreserveidDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ReservationID_txtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Delete_btn;
        protected System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnbackMR;
        private System.Windows.Forms.Label lblReservations;
    }
}