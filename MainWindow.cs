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
    public partial class MainWindow : Form
    {
        private Login _login;
        public string _roleName;
        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(Login login, string role)
        {
            InitializeComponent();
            _login = login;
            _roleName = role;

        }

        private void btnCarRentalSystem_Click(object sender, EventArgs e)
        {
            AddRentalRecord form = new AddRentalRecord();
            form.Show();
            this.Hide();
        }

        private void addRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRentalRecord form = new AddRentalRecord();
            form.MdiParent = this;
            form.Show();
        }

        private void vehicleListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms.Cast<Form>();
            bool isOpen = openForms.Any(q => q.Name == "ManageVehicleListing");
            if (!isOpen)
            {
                var cars = new ManageVehicleListing();
                cars.MdiParent = this;
                cars.Show();
            }
        }

        private void viewArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms.Cast<Form>();
            bool isOpen = openForms.Any(q => q.Name == "ManageRentalRecords");
            if (!isOpen)
            {
                ManageRentalRecords form = new ManageRentalRecords();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms.Cast<Form>();
            bool isOpen = Utils.FormIsOpen("ManageUsers");
            if (!isOpen)
            {
                ManageUsers frm = new ManageUsers();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if(_roleName != "Admin")
            {
                manageUsersToolStripMenuItem.Enabled = false;
            }
            else
            {
                manageUsersToolStripMenuItem.Enabled = true;
            }
        }
    }
}
