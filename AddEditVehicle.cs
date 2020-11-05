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
    public partial class AddEditVehicle : Form
    {
        private bool isEditMode;
        public ManageVehicleListing _manageVehicleListing;

        //private readonly int _formWidth = 355;
        //private readonly int _formHt = 663;
        public AddEditVehicle(ManageVehicleListing manageVehicleListing = null)
        {
            InitializeComponent();
            lbFormTitle.Text = "Add a Car";
            isEditMode = false;
            //this.Width = _formWidth;
            //this.Height = _formHt;
            _manageVehicleListing = manageVehicleListing;
            CarRentalEntities _db = new CarRentalEntities();
        }

        public AddEditVehicle(TypeOfCar car2Edit, ManageVehicleListing manageVehicleListing = null)
        {
            InitializeComponent();
            lbFormTitle.Text = "Edit a Car";
            PopulateFields(car2Edit);
            _manageVehicleListing = manageVehicleListing;
            isEditMode = true;
        }
        private void PopulateFields(TypeOfCar car)
        {
            try
            {
                if (car != null)
                {
                    txtMake.Text = car.Make;
                    txtModel.Text = car.Model;
                    txtVIN.Text = "n/a";
                    txtYear.Text = car.Year.ToString();
                    lbID.Text = car.TypeOfCarID.ToString();
                    if (car.LicensePlateNum != null)
                    {
                        txtLicensePlateNum.Text = car.LicensePlateNum;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw new NotImplementedException();
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            CarRentalEntities _db = new CarRentalEntities();

                var newCar = new TypeOfCar
                {
                    Make = txtMake.Text,
                    Model = txtModel.Text,
                    Year = int.Parse(txtYear.Text),
                    LicensePlateNum = txtLicensePlateNum.Text
                };
            if (isEditMode == false)
            {
                //Add
                _db.TypeOfCars.Add(newCar);
          
            }
            else
            {
                // Edit

                int id = int.Parse(lbID.Text);
                var car = _db.TypeOfCars.Find(id);
                if (car != null)
                {
                    car.Make = txtMake.Text;
                    car.Model = txtModel.Text;
                    car.Year = int.Parse(txtYear.Text);
                    car.LicensePlateNum = txtLicensePlateNum.Text;
                
                    
                }
            }
            _db.SaveChanges();
            _manageVehicleListing.PopulateGrid();

           // ManageVehicleListing gridPage = new ManageVehicleListing();
           // gridPage.PopulateGrid();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
