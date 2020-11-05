using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalWinforms
{
    public partial class Login : Form
    {
        private readonly CarRentalEntities _db;
        public Login()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtUserName.Text.Trim();
                string pwd = txtPwd.Text.Trim();
                var usr = _db.Users.FirstOrDefault(u => u.UserName == userName && u.Password == pwd);
                string role = usr.Users_Roles.FirstOrDefault().Role.Role1;

                if (usr == null || usr.IsActive == false)
                {
                    MessageBox.Show("Invalid credentials.\n\rPlease try again.");
                }
                else
                {
                    var main = new MainWindow(this, role);
                    main.Show();
                    this.Hide();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
