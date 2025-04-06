namespace Assignment
{
    partial class ViewReservationCustomer
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRequestID = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEmail_ID = new System.Windows.Forms.TextBox();
            this.txtReservationId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.iOOP_DatabaseDataSet = new Assignment.IOOP_DatabaseDataSet();
            this.iOOPDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iOOPDatabaseDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iOOP_DatabaseDataSet1 = new Assignment.IOOP_DatabaseDataSet1();
            this.resrvationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resrvationsTableAdapter = new Assignment.IOOP_DatabaseDataSet1TableAdapters.ResrvationsTableAdapter();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOPDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOPDatabaseDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resrvationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(961, 630);
            this.panel2.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(457, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 608);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 32);
            this.label1.TabIndex = 51;
            this.label1.Text = "                                           ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(49)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(173, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 38);
            this.button1.TabIndex = 42;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtRequestID);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtEmail_ID);
            this.groupBox1.Controls.Add(this.txtReservationId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.Confirm);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 608);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reservation Details";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(49)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(130, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 37);
            this.button2.TabIndex = 51;
            this.button2.Text = "Confirm";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(288, 32);
            this.label7.TabIndex = 50;
            this.label7.Text = "Request Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(338, 32);
            this.label6.TabIndex = 49;
            this.label6.Text = "Reservation Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Enter Your Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 492);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Reservation ID";
            // 
            // txtRequestID
            // 
            this.txtRequestID.Location = new System.Drawing.Point(175, 279);
            this.txtRequestID.Name = "txtRequestID";
            this.txtRequestID.Size = new System.Drawing.Size(235, 27);
            this.txtRequestID.TabIndex = 48;
            this.txtRequestID.TextChanged += new System.EventHandler(this.txtRequestID_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(181, 427);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(235, 27);
            this.txtEmail.TabIndex = 34;
            // 
            // txtEmail_ID
            // 
            this.txtEmail_ID.Location = new System.Drawing.Point(175, 221);
            this.txtEmail_ID.Name = "txtEmail_ID";
            this.txtEmail_ID.Size = new System.Drawing.Size(235, 27);
            this.txtEmail_ID.TabIndex = 46;
            // 
            // txtReservationId
            // 
            this.txtReservationId.Location = new System.Drawing.Point(181, 485);
            this.txtReservationId.Name = "txtReservationId";
            this.txtReservationId.Size = new System.Drawing.Size(235, 27);
            this.txtReservationId.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Request ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Enter Your Email";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Assignment.Properties.Resources.icons8_reservation_100;
            this.pictureBox4.Location = new System.Drawing.Point(153, 44);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(121, 114);
            this.pictureBox4.TabIndex = 44;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(49)))));
            this.Confirm.FlatAppearance.BorderSize = 0;
            this.Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirm.Location = new System.Drawing.Point(130, 540);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(175, 37);
            this.Confirm.TabIndex = 41;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = false;
            this.Confirm.Click += new System.EventHandler(this.Return_Click);
            // 
            // iOOP_DatabaseDataSet
            // 
            this.iOOP_DatabaseDataSet.DataSetName = "IOOP_DatabaseDataSet";
            this.iOOP_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iOOPDatabaseDataSetBindingSource
            // 
            this.iOOPDatabaseDataSetBindingSource.DataSource = this.iOOP_DatabaseDataSet;
            this.iOOPDatabaseDataSetBindingSource.Position = 0;
            // 
            // iOOPDatabaseDataSetBindingSource1
            // 
            this.iOOPDatabaseDataSetBindingSource1.DataSource = this.iOOP_DatabaseDataSet;
            this.iOOPDatabaseDataSetBindingSource1.Position = 0;
            // 
            // iOOP_DatabaseDataSet1
            // 
            this.iOOP_DatabaseDataSet1.DataSetName = "IOOP_DatabaseDataSet1";
            this.iOOP_DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resrvationsBindingSource
            // 
            this.resrvationsBindingSource.DataMember = "Resrvations";
            this.resrvationsBindingSource.DataSource = this.iOOP_DatabaseDataSet1;
            // 
            // resrvationsTableAdapter
            // 
            this.resrvationsTableAdapter.ClearBeforeFill = true;
            // 
            // ViewReservationCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 630);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewReservationCustomer";
            this.Text = "ViewReservationCustomer";
            this.Load += new System.EventHandler(this.ViewReservationCustomer_Load);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOPDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOPDatabaseDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resrvationsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReservationId;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource iOOPDatabaseDataSetBindingSource1;
        private IOOP_DatabaseDataSet iOOP_DatabaseDataSet;
        private System.Windows.Forms.BindingSource iOOPDatabaseDataSetBindingSource;
        private IOOP_DatabaseDataSet1 iOOP_DatabaseDataSet1;
        private System.Windows.Forms.BindingSource resrvationsBindingSource;
        private IOOP_DatabaseDataSet1TableAdapters.ResrvationsTableAdapter resrvationsTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRequestID;
        private System.Windows.Forms.TextBox txtEmail_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}