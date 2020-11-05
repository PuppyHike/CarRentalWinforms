namespace CarRentalWinforms
{
    partial class ManageRentalRecords
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDeleteRental = new System.Windows.Forms.Button();
            this.btnEditRental = new System.Windows.Forms.Button();
            this.btnNewRental = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gridRentalList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridRentalList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefresh.Font = new System.Drawing.Font("Jokerman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefresh.Location = new System.Drawing.Point(1112, 491);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(211, 54);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh Grid";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnDeleteRental
            // 
            this.btnDeleteRental.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteRental.Font = new System.Drawing.Font("Jokerman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRental.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteRental.Location = new System.Drawing.Point(1112, 383);
            this.btnDeleteRental.Name = "btnDeleteRental";
            this.btnDeleteRental.Size = new System.Drawing.Size(211, 54);
            this.btnDeleteRental.TabIndex = 10;
            this.btnDeleteRental.Text = "Delete Rental";
            this.btnDeleteRental.UseVisualStyleBackColor = false;
            // 
            // btnEditRental
            // 
            this.btnEditRental.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditRental.Font = new System.Drawing.Font("Jokerman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRental.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditRental.Location = new System.Drawing.Point(1112, 284);
            this.btnEditRental.Name = "btnEditRental";
            this.btnEditRental.Size = new System.Drawing.Size(211, 54);
            this.btnEditRental.TabIndex = 9;
            this.btnEditRental.Text = "Edit Rental";
            this.btnEditRental.UseVisualStyleBackColor = false;
            // 
            // btnNewRental
            // 
            this.btnNewRental.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNewRental.Font = new System.Drawing.Font("Jokerman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRental.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNewRental.Location = new System.Drawing.Point(1112, 180);
            this.btnNewRental.Name = "btnNewRental";
            this.btnNewRental.Size = new System.Drawing.Size(211, 54);
            this.btnNewRental.TabIndex = 8;
            this.btnNewRental.Text = "New Rental";
            this.btnNewRental.UseVisualStyleBackColor = false;
            this.btnNewRental.Click += new System.EventHandler(this.btnNewRental_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(120, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(607, 70);
            this.label1.TabIndex = 7;
            this.label1.Text = "Manage Rental Records";
            // 
            // gridRentalList
            // 
            this.gridRentalList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRentalList.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.gridRentalList.Location = new System.Drawing.Point(21, 150);
            this.gridRentalList.Name = "gridRentalList";
            this.gridRentalList.RowHeadersWidth = 82;
            this.gridRentalList.RowTemplate.Height = 33;
            this.gridRentalList.Size = new System.Drawing.Size(1055, 425);
            this.gridRentalList.TabIndex = 6;
            // 
            // ManageRentalRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 629);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeleteRental);
            this.Controls.Add(this.btnEditRental);
            this.Controls.Add(this.btnNewRental);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridRentalList);
            this.Name = "ManageRentalRecords";
            this.Text = "ManageRentalRecords";
            this.Load += new System.EventHandler(this.ManageRentalRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRentalList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDeleteRental;
        private System.Windows.Forms.Button btnEditRental;
        private System.Windows.Forms.Button btnNewRental;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridRentalList;
    }
}