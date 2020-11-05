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
    public partial class ManageVehicleListing : Form
    {
        private readonly CarRentalEntities _db;
        private readonly Color HeaderBgColor = Color.LightBlue;
        public ManageVehicleListing()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void ManageVehicleListing_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        public void PopulateGrid()
        { 
            var cars = _db.TypeOfCars.Select(u => new {
                Make = u.Make,
                Model = u.Model ,
                Year = u.Year,
                LicensePlateNum = u.LicensePlateNum, 
                ID = u.TypeOfCarID}).ToList();
            gridvVehicleList.DataSource = cars;

           // gridvVehicleList.Columns["Model"].DefaultCellStyle.BackColor = Color.Linen;

            gridvVehicleList.Columns[4].Visible = false;
            gridvVehicleList.Columns[2].Width = 50;
         
            gridvVehicleList.Columns[0].HeaderText = "Make";
            //gridvVehicleList.Columns[0].
            gridvVehicleList.Columns[1].HeaderText = "Model";
            gridvVehicleList.Columns[2].HeaderText = "Year";
            gridvVehicleList.Columns[3].HeaderText = "License Plate #";

            foreach (DataGridViewRow row in this.gridvVehicleList.Rows)
            {
                switch (row.Cells[0].Value)
                {
                    case "Nissan":
                        ColorCodeRows(row, Color.LightGoldenrodYellow, Color.Goldenrod, Color.DarkMagenta);
                        break;
                    case "Toyota":
                        ColorCodeRows(row, Color.LightBlue, Color.CadetBlue, Color.BlueViolet);
                        break;
                    case "Subaru":
                        ColorCodeRows(row, Color.LightGreen, Color.SeaGreen, Color.ForestGreen);
                        break;
                    case "Honda":
                        ColorCodeRows(row, Color.Beige, Color.AntiqueWhite, Color.Sienna);
                        break;
                    default:
                        row.Cells[0].Style.ForeColor = Color.BlueViolet;
                        break;
                }
            }
        }

        private void ColorCodeRows( DataGridViewRow row, Color cMake, Color cRow, Color cForecolor)
        {
            foreach (DataGridViewCell c in row.Cells)
            {
                row.Cells[0].Style.BackColor = cMake;
                c.Style.ForeColor = cForecolor;
                row.DefaultCellStyle.BackColor = cRow;
                break;
            }
        }
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            AddEditVehicle frm = new AddEditVehicle(this);

            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            var rowIdx = gridvVehicleList.SelectedRows[0].Cells["ID"].Value;
            var car = _db.TypeOfCars.FirstOrDefault(u => u.TypeOfCarID == (int)rowIdx);

            //Launch AddEditVehicle form with this record
            AddEditVehicle frm = new AddEditVehicle(car,this);
            frm.Name = "EditCar";
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            var rowIdx = gridvVehicleList.SelectedRows[0].Cells["ID"].Value;
            var car = _db.TypeOfCars.FirstOrDefault(u => u.TypeOfCarID == (int)rowIdx);

            //delete this car
            _db.TypeOfCars.Remove(car);
            _db.SaveChanges();
            PopulateGrid();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }
    }
}
