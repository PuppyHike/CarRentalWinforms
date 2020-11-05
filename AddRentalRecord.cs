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
    public partial class AddRentalRecord : Form
    {
        private const double V = 350.00;
        private readonly CarRentalEntities carRentalEntities;
        public AddRentalRecord()
        {
            InitializeComponent();
            tbmCost.Text = "350.00";
            carRentalEntities = new CarRentalEntities();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var cars = carRentalEntities.TypeOfCars.ToList();
            cboTypeOfCar.DisplayMember = "Name";
            cboTypeOfCar.ValueMember = "TypeOfCarID";
            cboTypeOfCar.DataSource = cars;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string custName = tbCustomerName.Text;
                string carType = cboTypeOfCar.Text;
                var dateOut = dtDateRented.Value;
                var dateIn = dtDateReturned.Value;
                var isValid = true;
                var errormsg = "Please enter\n\r";

                if (string.IsNullOrWhiteSpace(tbmCost.Text))
                {
                    isValid = false;
                    errormsg += " a cost.\n\r";
                }
                else
                {
                    double cost = Convert.ToDouble(tbmCost.Text);
                }

                if (string.IsNullOrWhiteSpace(custName) || string.IsNullOrWhiteSpace(carType))
                {
                    isValid = false;
                    errormsg += " both Customer Name and Car Type.\n\r";
                }
                 if (dateOut > dateIn)
                {
                    isValid = false;
                    errormsg += "Return date must be after check out date.\n\r";
                }
                if (isValid)
                {
                    var carRentalRecord = new CarRentalRecord();
                    carRentalRecord.CustomerName = custName;
                    carRentalRecord.DateRented = dateOut;
                    carRentalRecord.DateReturned = dateIn;
                    carRentalRecord.TypeOfCarID = (int)cboTypeOfCar.SelectedValue;
                    carRentalRecord.Cost = Convert.ToDecimal(tbmCost.Text);
                    carRentalEntities.CarRentalRecords.Add(carRentalRecord);
                    carRentalEntities.SaveChanges();

                    
                    MessageBox.Show(tbCustomerName.Text + ", thank you for renting a " + cboTypeOfCar.Text + "\nstarting on: " + dtDateRented.Text + " to " + dtDateReturned.Text + "!");
                }
                else
                {
                    MessageBox.Show(errormsg);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw ends the program
            }
        }

        private void btnLaunchMainWindow_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }
    }
}
