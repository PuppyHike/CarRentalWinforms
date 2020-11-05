namespace CarRentalWinforms
{
    partial class ManageUsers
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDeactivateUser = new System.Windows.Forms.Button();
            this.btnResetPwd = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.gridUserList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(99, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 70);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Users";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefresh.Font = new System.Drawing.Font("Jokerman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefresh.Location = new System.Drawing.Point(840, 424);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(211, 54);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh Grid";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnDeactivateUser
            // 
            this.btnDeactivateUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeactivateUser.Font = new System.Drawing.Font("Jokerman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeactivateUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeactivateUser.Location = new System.Drawing.Point(840, 288);
            this.btnDeactivateUser.Name = "btnDeactivateUser";
            this.btnDeactivateUser.Size = new System.Drawing.Size(211, 102);
            this.btnDeactivateUser.TabIndex = 9;
            this.btnDeactivateUser.Text = "Deactivate User";
            this.btnDeactivateUser.UseVisualStyleBackColor = false;
            // 
            // btnResetPwd
            // 
            this.btnResetPwd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnResetPwd.Font = new System.Drawing.Font("Jokerman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPwd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnResetPwd.Location = new System.Drawing.Point(840, 170);
            this.btnResetPwd.Name = "btnResetPwd";
            this.btnResetPwd.Size = new System.Drawing.Size(211, 93);
            this.btnResetPwd.TabIndex = 8;
            this.btnResetPwd.Text = "Reset Password";
            this.btnResetPwd.UseVisualStyleBackColor = false;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddUser.Font = new System.Drawing.Font("Jokerman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddUser.Location = new System.Drawing.Point(840, 85);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(211, 54);
            this.btnAddUser.TabIndex = 7;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // gridUserList
            // 
            this.gridUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUserList.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.gridUserList.Location = new System.Drawing.Point(21, 81);
            this.gridUserList.Name = "gridUserList";
            this.gridUserList.RowHeadersWidth = 82;
            this.gridUserList.RowTemplate.Height = 33;
            this.gridUserList.Size = new System.Drawing.Size(762, 425);
            this.gridUserList.TabIndex = 6;
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 538);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeactivateUser);
            this.Controls.Add(this.btnResetPwd);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.gridUserList);
            this.Controls.Add(this.label1);
            this.Name = "ManageUsers";
            this.Text = "ManageUsers";
            ((System.ComponentModel.ISupportInitialize)(this.gridUserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDeactivateUser;
        private System.Windows.Forms.Button btnResetPwd;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.DataGridView gridUserList;
    }
}