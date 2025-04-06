namespace Assignment
{
    partial class ChefUpdateOrder
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
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gboxStatus = new System.Windows.Forms.GroupBox();
            this.radInProgress = new System.Windows.Forms.RadioButton();
            this.radCompleted = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gboxStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(68, 317);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(252, 77);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(68, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(387, 179);
            this.dataGridView1.TabIndex = 1;
            // 
            // gboxStatus
            // 
            this.gboxStatus.Controls.Add(this.radCompleted);
            this.gboxStatus.Controls.Add(this.radInProgress);
            this.gboxStatus.Location = new System.Drawing.Point(531, 90);
            this.gboxStatus.Name = "gboxStatus";
            this.gboxStatus.Size = new System.Drawing.Size(216, 176);
            this.gboxStatus.TabIndex = 2;
            this.gboxStatus.TabStop = false;
            this.gboxStatus.Text = "Status";
            this.gboxStatus.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radInProgress
            // 
            this.radInProgress.AutoSize = true;
            this.radInProgress.Location = new System.Drawing.Point(24, 41);
            this.radInProgress.Name = "radInProgress";
            this.radInProgress.Size = new System.Drawing.Size(93, 20);
            this.radInProgress.TabIndex = 0;
            this.radInProgress.TabStop = true;
            this.radInProgress.Text = "InProgress";
            this.radInProgress.UseVisualStyleBackColor = true;
            // 
            // radCompleted
            // 
            this.radCompleted.AutoSize = true;
            this.radCompleted.Location = new System.Drawing.Point(24, 83);
            this.radCompleted.Name = "radCompleted";
            this.radCompleted.Size = new System.Drawing.Size(94, 20);
            this.radCompleted.TabIndex = 1;
            this.radCompleted.TabStop = true;
            this.radCompleted.Text = "Completed";
            this.radCompleted.UseVisualStyleBackColor = true;
            // 
            // ChefUpdateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gboxStatus);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSave);
            this.Name = "ChefUpdateOrder";
            this.Text = "ChefUpdateOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gboxStatus.ResumeLayout(false);
            this.gboxStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gboxStatus;
        private System.Windows.Forms.RadioButton radCompleted;
        private System.Windows.Forms.RadioButton radInProgress;
    }
}