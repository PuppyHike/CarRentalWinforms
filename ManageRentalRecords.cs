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
    public partial class ManageRentalRecords : Form
    {
        private readonly CarRentalEntities _db;
        public ManageRentalRecords()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
            PopulateGrid();
        }

        private void PopulateGrid()
        {
            var rentals = _db.CarRentalRecords.Select(u => new
            {
                CustomerName = u.CustomerName,
                DateRented = u.DateRented,
                DateReturned = u.DateReturned,
                Cost = u.Cost,
                TypeOfCarID = u.TypeOfCarID ,
             //   Make = _db.TypeOfCars.Where(c => c.TypeOfCarID == u.TypeOfCarID)
             //   .FirstOrDefault().Make
             Make = u.TypeOfCar.Make
            }).ToList();

           // var makes = _db.TypeOfCars.Select(c => new { Make = c.Make }).ToList();

          //  var joinResult = from CarRentalRecord in rentals
            //    on TypeOfCar in makes on makes.Type 
            gridRentalList.DataSource = rentals;
            gridRentalList.Columns[4].Visible = false;
            gridRentalList.Columns[3].Width = 70;

            foreach (DataGridViewRow row in this.gridRentalList.Rows)
            {
                //int idx = int.Parse((string)row.Cells[4].Value);
              // Int32 idx = (int)row.Cells[4].Value;
                
              // string make = _db.TypeOfCars.Find(idx).Make;
              // row.Cells[5].Value = make;
                switch (row.Cells[5].Value)
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

        private void ColorCodeRows(DataGridViewRow row, Color cMake, Color cRow, Color cForecolor)
        {
            foreach (DataGridViewCell c in row.Cells)
            {
                row.Cells[0].Style.BackColor = cMake;
                c.Style.ForeColor = cForecolor;
                row.DefaultCellStyle.BackColor = cRow;
                break;
            }
        }

        private void btnNewRental_Click(object sender, EventArgs e)
        {
            AddEditVehicle frm = new AddEditVehicle();
            {
                MdiParent = this.MdiParent;
            }
            frm.Show();
        }

        private void ManageRentalRecords_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }
    }
}
