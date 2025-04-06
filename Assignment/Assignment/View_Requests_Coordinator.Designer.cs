namespace Assignment
{
    partial class View_Requests_Coordinator
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iOOPDatabaseDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iOOP_DatabaseDataSet1 = new Assignment.IOOP_DatabaseDataSet1();
            this.iOOP_DatabaseDataSet = new Assignment.IOOP_DatabaseDataSet();
            this.iOOPDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkHallnotAV = new System.Windows.Forms.CheckBox();
            this.btnaddreserve = new System.Windows.Forms.Button();
            this.txtassighned = new System.Windows.Forms.TextBox();
            this.txtdatewhen = new System.Windows.Forms.TextBox();
            this.txtbookdate = new System.Windows.Forms.TextBox();
            this.txthallid = new System.Windows.Forms.TextBox();
            this.txtemailid = new System.Windows.Forms.TextBox();
            this.txtreservationid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.reservation_btn = new System.Windows.Forms.Button();
            this.btnbackVR = new System.Windows.Forms.Button();
            this.dataGridHalls = new System.Windows.Forms.DataGridView();
            this.Lblrequests = new System.Windows.Forms.Label();
            this.lblHalls = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOPDatabaseDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOPDatabaseDataSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHalls)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(349, 372);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iOOPDatabaseDataSet1BindingSource
            // 
            this.iOOPDatabaseDataSet1BindingSource.DataSource = this.iOOP_DatabaseDataSet1;
            this.iOOPDatabaseDataSet1BindingSource.Position = 0;
            // 
            // iOOP_DatabaseDataSet1
            // 
            this.iOOP_DatabaseDataSet1.DataSetName = "IOOP_DatabaseDataSet1";
            this.iOOP_DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.checkHallnotAV);
            this.panel1.Controls.Add(this.btnaddreserve);
            this.panel1.Controls.Add(this.txtassighned);
            this.panel1.Controls.Add(this.txtdatewhen);
            this.panel1.Controls.Add(this.txtbookdate);
            this.panel1.Controls.Add(this.txthallid);
            this.panel1.Controls.Add(this.txtemailid);
            this.panel1.Controls.Add(this.txtreservationid);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Location = new System.Drawing.Point(371, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 262);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // checkHallnotAV
            // 
            this.checkHallnotAV.AutoSize = true;
            this.checkHallnotAV.BackColor = System.Drawing.Color.OrangeRed;
            this.checkHallnotAV.ForeColor = System.Drawing.Color.White;
            this.checkHallnotAV.Location = new System.Drawing.Point(330, 17);
            this.checkHallnotAV.Name = "checkHallnotAV";
            this.checkHallnotAV.Size = new System.Drawing.Size(158, 24);
            this.checkHallnotAV.TabIndex = 15;
            this.checkHallnotAV.Text = "Hall Not Available";
            this.checkHallnotAV.UseVisualStyleBackColor = false;
            // 
            // btnaddreserve
            // 
            this.btnaddreserve.BackColor = System.Drawing.Color.OrangeRed;
            this.btnaddreserve.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnaddreserve.Location = new System.Drawing.Point(349, 196);
            this.btnaddreserve.Name = "btnaddreserve";
            this.btnaddreserve.Size = new System.Drawing.Size(154, 35);
            this.btnaddreserve.TabIndex = 14;
            this.btnaddreserve.Text = "Confirm";
            this.btnaddreserve.UseVisualStyleBackColor = false;
            this.btnaddreserve.Click += new System.EventHandler(this.btnaddreserve_Click);
            // 
            // txtassighned
            // 
            this.txtassighned.BackColor = System.Drawing.Color.White;
            this.txtassighned.Location = new System.Drawing.Point(166, 203);
            this.txtassighned.Name = "txtassighned";
            this.txtassighned.Size = new System.Drawing.Size(100, 26);
            this.txtassighned.TabIndex = 13;
            // 
            // txtdatewhen
            // 
            this.txtdatewhen.BackColor = System.Drawing.Color.White;
            this.txtdatewhen.Location = new System.Drawing.Point(166, 167);
            this.txtdatewhen.Name = "txtdatewhen";
            this.txtdatewhen.Size = new System.Drawing.Size(100, 26);
            this.txtdatewhen.TabIndex = 12;
            // 
            // txtbookdate
            // 
            this.txtbookdate.BackColor = System.Drawing.Color.White;
            this.txtbookdate.Location = new System.Drawing.Point(166, 127);
            this.txtbookdate.Name = "txtbookdate";
            this.txtbookdate.Size = new System.Drawing.Size(100, 26);
            this.txtbookdate.TabIndex = 11;
            this.txtbookdate.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txthallid
            // 
            this.txthallid.BackColor = System.Drawing.Color.White;
            this.txthallid.Location = new System.Drawing.Point(166, 90);
            this.txthallid.Name = "txthallid";
            this.txthallid.Size = new System.Drawing.Size(100, 26);
            this.txthallid.TabIndex = 10;
            // 
            // txtemailid
            // 
            this.txtemailid.BackColor = System.Drawing.Color.White;
            this.txtemailid.Location = new System.Drawing.Point(166, 54);
            this.txtemailid.Name = "txtemailid";
            this.txtemailid.Size = new System.Drawing.Size(100, 26);
            this.txtemailid.TabIndex = 9;
            // 
            // txtreservationid
            // 
            this.txtreservationid.BackColor = System.Drawing.Color.White;
            this.txtreservationid.Location = new System.Drawing.Point(166, 15);
            this.txtreservationid.Name = "txtreservationid";
            this.txtreservationid.Size = new System.Drawing.Size(100, 26);
            this.txtreservationid.TabIndex = 8;
            this.txtreservationid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Assigned by";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date when booked";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Booking Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hall ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email ID";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(17, 15);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(111, 20);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "ReservationID";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // reservation_btn
            // 
            this.reservation_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.reservation_btn.ForeColor = System.Drawing.Color.DarkGreen;
            this.reservation_btn.Location = new System.Drawing.Point(468, 483);
            this.reservation_btn.Name = "reservation_btn";
            this.reservation_btn.Size = new System.Drawing.Size(154, 35);
            this.reservation_btn.TabIndex = 15;
            this.reservation_btn.Text = "Add Reservation";
            this.reservation_btn.UseVisualStyleBackColor = false;
            this.reservation_btn.Click += new System.EventHandler(this.reservation_btn_Click);
            // 
            // btnbackVR
            // 
            this.btnbackVR.BackColor = System.Drawing.Color.OrangeRed;
            this.btnbackVR.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnbackVR.Location = new System.Drawing.Point(745, 483);
            this.btnbackVR.Name = "btnbackVR";
            this.btnbackVR.Size = new System.Drawing.Size(75, 35);
            this.btnbackVR.TabIndex = 15;
            this.btnbackVR.Text = "Back";
            this.btnbackVR.UseVisualStyleBackColor = false;
            this.btnbackVR.Click += new System.EventHandler(this.btnbackVR_Click);
            // 
            // dataGridHalls
            // 
            this.dataGridHalls.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dataGridHalls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHalls.Location = new System.Drawing.Point(925, 66);
            this.dataGridHalls.Name = "dataGridHalls";
            this.dataGridHalls.RowHeadersWidth = 62;
            this.dataGridHalls.RowTemplate.Height = 28;
            this.dataGridHalls.Size = new System.Drawing.Size(271, 190);
            this.dataGridHalls.TabIndex = 16;
            // 
            // Lblrequests
            // 
            this.Lblrequests.AutoSize = true;
            this.Lblrequests.BackColor = System.Drawing.Color.OrangeRed;
            this.Lblrequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblrequests.ForeColor = System.Drawing.Color.White;
            this.Lblrequests.Location = new System.Drawing.Point(70, 26);
            this.Lblrequests.Name = "Lblrequests";
            this.Lblrequests.Size = new System.Drawing.Size(199, 37);
            this.Lblrequests.TabIndex = 17;
            this.Lblrequests.Text = "REQUESTS";
            // 
            // lblHalls
            // 
            this.lblHalls.AutoSize = true;
            this.lblHalls.BackColor = System.Drawing.Color.OrangeRed;
            this.lblHalls.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHalls.ForeColor = System.Drawing.Color.White;
            this.lblHalls.Location = new System.Drawing.Point(1006, 26);
            this.lblHalls.Name = "lblHalls";
            this.lblHalls.Size = new System.Drawing.Size(124, 37);
            this.lblHalls.TabIndex = 18;
            this.lblHalls.Text = "HALLS";
            // 
            // View_Requests_Coordinator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment.Properties.Resources.cover;
            this.ClientSize = new System.Drawing.Size(1208, 560);
            this.Controls.Add(this.lblHalls);
            this.Controls.Add(this.Lblrequests);
            this.Controls.Add(this.dataGridHalls);
            this.Controls.Add(this.btnbackVR);
            this.Controls.Add(this.reservation_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "View_Requests_Coordinator";
            this.Text = "View_Requests_Coordinator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOPDatabaseDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOPDatabaseDataSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHalls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource iOOPDatabaseDataSetBindingSource;
        private IOOP_DatabaseDataSet iOOP_DatabaseDataSet;
        private System.Windows.Forms.BindingSource iOOPDatabaseDataSet1BindingSource;
        private IOOP_DatabaseDataSet1 iOOP_DatabaseDataSet1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtassighned;
        private System.Windows.Forms.TextBox txtdatewhen;
        private System.Windows.Forms.TextBox txtbookdate;
        private System.Windows.Forms.TextBox txthallid;
        private System.Windows.Forms.TextBox txtemailid;
        private System.Windows.Forms.TextBox txtreservationid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnaddreserve;
        private System.Windows.Forms.Button reservation_btn;
        private System.Windows.Forms.Button btnbackVR;
        private System.Windows.Forms.DataGridView dataGridHalls;
        private System.Windows.Forms.CheckBox checkHallnotAV;
        private System.Windows.Forms.Label Lblrequests;
        private System.Windows.Forms.Label lblHalls;
    }
}