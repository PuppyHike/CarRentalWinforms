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

    public partial class AddEditCar : Form
    {
        private bool isEditMode;
        private readonly int _formWidth = 355;
        private readonly int _formHt = 663;
        public AddEditCar()
        {
            InitializeComponent();
            lbFormTitle.Text = "Add a Car";
            isEditMode = false;
            this.Width = _formWidth;
            this.Height = _formHt;
            CarRentalEntities _db = new CarRentalEntities();
        }

        //Overloaded function
        public AddEditCar(TypeOfCar car2Edit)
        {
            lbFormTitle.Text = "Edit a Car";
            PopulateFields(car2Edit);
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
            if (isEditMode)
            {
                //Add
                var newCar = new TypeOfCar
                {
                    Make = txtMake.Text,
                    Model = txtModel.Text,
                    Year = int.Parse(txtYear.Text),
                    LicensePlateNum = txtLicensePlateNum.Text
                };
                _db.TypeOfCars.Add(newCar);
                _db.SaveChanges();
            }
            else
            {
                // Edit
                
                int id = int.Parse(lblID.Text);
                var car = _db.TypeOfCars.Find(id);
                if(car != null)
                {
                    car.Make = txtMake.Text;
                    car.Model = txtModel.Text;
                    car.Year = int.Parse(txtYear.Text);
                    car.LicensePlateNum = txtLicensePlateNum.Text;
                    _db.SaveChanges();

                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
