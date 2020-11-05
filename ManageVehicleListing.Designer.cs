namespace CarRentalWinforms
{
    partial class ManageVehicleListing
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
            this.gridvVehicleList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnEditCar = new System.Windows.Forms.Button();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridvVehicleList)).BeginInit();
            this.SuspendLayout();
            // 
            // gridvVehicleList
            // 
            this.gridvVehicleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridvVehicleList.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.gridvVehicleList.Location = new System.Drawing.Point(12, 97);
            this.gridvVehicleList.Name = "gridvVehicleList";
            this.gridvVehicleList.RowHeadersWidth = 82;
            this.gridvVehicleList.RowTemplate.Height = 33;
            this.gridvVehicleList.Size = new System.Drawing.Size(1055, 425);
            this.gridvVehicleList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(111, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(603, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Vehicle Listing";
            // 
            // btnAddCar
            // 
            this.btnAddCar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddCar.Font = new System.Drawing.Font("Jokerman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddCar.Location = new System.Drawing.Point(1103, 127);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(211, 54);
            this.btnAddCar.TabIndex = 2;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = false;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnEditCar
            // 
            this.btnEditCar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditCar.Font = new System.Drawing.Font("Jokerman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditCar.Location = new System.Drawing.Point(1103, 231);
            this.btnEditCar.Name = "btnEditCar";
            this.btnEditCar.Size = new System.Drawing.Size(211, 54);
            this.btnEditCar.TabIndex = 3;
            this.btnEditCar.Text = "Edit Car";
            this.btnEditCar.UseVisualStyleBackColor = false;
            this.btnEditCar.Click += new System.EventHandler(this.btnEditCar_Click);
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteCar.Font = new System.Drawing.Font("Jokerman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteCar.Location = new System.Drawing.Point(1103, 330);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(211, 54);
            this.btnDeleteCar.TabIndex = 4;
            this.btnDeleteCar.Text = "Delete Car";
            this.btnDeleteCar.UseVisualStyleBackColor = false;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefresh.Font = new System.Drawing.Font("Jokerman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefresh.Location = new System.Drawing.Point(1103, 438);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(211, 54);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh Grid";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ManageVehicleListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 629);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeleteCar);
            this.Controls.Add(this.btnEditCar);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridvVehicleList);
            this.Name = "ManageVehicleListing";
            this.Text = "ManageVehicleListing";
            this.Load += new System.EventHandler(this.ManageVehicleListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridvVehicleList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridvVehicleList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnEditCar;
        private System.Windows.Forms.Button btnDeleteCar;
        private System.Windows.Forms.Button btnRefresh;
    }
}