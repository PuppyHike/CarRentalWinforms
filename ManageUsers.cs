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
    public partial class ManageUsers : Form
    {
        private CarRentalEntities _db;
        public ManageUsers()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
            var src = _db.Users.ToList();
            gridUserList.DataSource = src;

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            
        }
    }
}
