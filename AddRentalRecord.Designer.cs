namespace CarRentalWinforms
{
    partial class AddRentalRecord
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtDateRented = new System.Windows.Forms.DateTimePicker();
            this.dtDateReturned = new System.Windows.Forms.DateTimePicker();
            this.cboTypeOfCar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblCost = new System.Windows.Forms.Label();
            this.tbmCost = new System.Windows.Forms.MaskedTextBox();
            this.btnLaunchMainWindow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(252, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Rental Record";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomerName.Location = new System.Drawing.Point(50, 147);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(400, 44);
            this.tbCustomerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rental Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(477, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "Return Date";
            // 
            // dtDateRented
            // 
            this.dtDateRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateRented.Location = new System.Drawing.Point(52, 256);
            this.dtDateRented.Name = "dtDateRented";
            this.dtDateRented.Size = new System.Drawing.Size(365, 44);
            this.dtDateRented.TabIndex = 5;
            // 
            // dtDateReturned
            // 
            this.dtDateReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateReturned.Location = new System.Drawing.Point(478, 256);
            this.dtDateReturned.MinDate = new System.DateTime(2020, 10, 31, 0, 0, 0, 0);
            this.dtDateReturned.Name = "dtDateReturned";
            this.dtDateReturned.Size = new System.Drawing.Size(365, 44);
            this.dtDateReturned.TabIndex = 6;
            // 
            // cboTypeOfCar
            // 
            this.cboTypeOfCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTypeOfCar.FormattingEnabled = true;
            this.cboTypeOfCar.Location = new System.Drawing.Point(52, 375);
            this.cboTypeOfCar.Name = "cboTypeOfCar";
            this.cboTypeOfCar.Size = new System.Drawing.Size(365, 45);
            this.cboTypeOfCar.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 37);
            this.label5.TabIndex = 8;
            this.label5.Text = "Type of Car";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubmit.Font = new System.Drawing.Font("Jokerman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(535, 375);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(223, 89);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(477, 101);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(83, 37);
            this.lblCost.TabIndex = 11;
            this.lblCost.Text = "Cost";
            // 
            // tbmCost
            // 
            this.tbmCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmCost.Location = new System.Drawing.Point(484, 147);
            this.tbmCost.Mask = "000.00";
            this.tbmCost.Name = "tbmCost";
            this.tbmCost.Size = new System.Drawing.Size(148, 44);
            this.tbmCost.TabIndex = 12;
            this.tbmCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnLaunchMainWindow
            // 
            this.btnLaunchMainWindow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLaunchMainWindow.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunchMainWindow.Location = new System.Drawing.Point(52, 451);
            this.btnLaunchMainWindow.Name = "btnLaunchMainWindow";
            this.btnLaunchMainWindow.Size = new System.Drawing.Size(377, 57);
            this.btnLaunchMainWindow.TabIndex = 13;
            this.btnLaunchMainWindow.Text = "Launch Main Window";
            this.btnLaunchMainWindow.UseVisualStyleBackColor = false;
            this.btnLaunchMainWindow.Click += new System.EventHandler(this.btnLaunchMainWindow_Click);
            // 
            // AddRentalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 546);
            this.Controls.Add(this.btnLaunchMainWindow);
            this.Controls.Add(this.tbmCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboTypeOfCar);
            this.Controls.Add(this.dtDateReturned);
            this.Controls.Add(this.dtDateRented);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.label1);
            this.Name = "AddRentalRecord";
            this.Text = "Car Rental System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtDateRented;
        private System.Windows.Forms.DateTimePicker dtDateReturned;
        private System.Windows.Forms.ComboBox cboTypeOfCar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.MaskedTextBox tbmCost;
        private System.Windows.Forms.Button btnLaunchMainWindow;
    }
}

