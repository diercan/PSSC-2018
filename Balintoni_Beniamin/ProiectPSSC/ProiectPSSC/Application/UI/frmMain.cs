using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using ProiectPSSC.Domain.Models;
using ProiectPSSC.Domain.Repositories;
using ProiectPSSC.Domain.Repositories.Interfaces;
using ProiectPSSC.Domain.Services;

namespace ProiectPSSC.Application.UI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private string _employerName;

        private bool _employerUser;

        public bool EmployerUser
        {
            get
            {
                return _employerUser;
            }
            set
            {
                _employerUser = value;
                if (value)
                {
                    lblLogin.Hide();
                    lblLogout.Show();
                    btnNewLaptop.Show();
                    btnNewEmployer.Show();
                    btnNewOrder.Hide();
                    btnViewOrders.Show();
                }
                else
                {
                    lblLogin.Show();
                    lblLogout.Hide();
                    btnNewLaptop.Hide();
                    btnNewEmployer.Hide();
                    btnNewOrder.Show();
                    btnViewOrders.Hide();
                }
            }
        }

        private int _timerIndex = 1;
        private IService _service;

        private void FrmMain_Load(object sender, System.EventArgs e)
        {
            InitializeUI();

            _service = new Service();
            EmployerUser = false;
        }

        private void InitializeUI()
        {
            grdLaptops.RowHeadersVisible = false;
            grdLaptops.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            grdLaptops.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            grdLaptops.EnableHeadersVisualStyles = false;
            grdLaptops.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdLaptops.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdLaptops.CellClick += grdLaptops_CellClick;
            
            timerMain.Enabled = true;
        }

        private void grdLaptops_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = grdLaptops.Rows[e.RowIndex];
            var lap = (Laptop)row.DataBoundItem;
            if (e.ColumnIndex == grdLaptops.ColumnCount - 1)
            {
                MessageBox.Show(lap.Id.ToString());
            }
            if (e.ColumnIndex == grdLaptops.ColumnCount - 2)
            {
                var tax = _service.GetTaxCalculation(lap.Price, lap.Ram, lap.Year, lap.Gpu.ToString());
                MessageBox.Show("Score for this laptop is: " + tax);
            }
        }

        private void timerMain_Tick(object sender, System.EventArgs e)
        {
            if (_timerIndex == 3) _timerIndex = 0;
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            pboMain.Image = Image.FromFile(path + @"\Application\Resources\main" + _timerIndex++ + ".bmp");
        }

        private void btnShowAllLaptops_Click(object sender, System.EventArgs e)
        {
            ILaptopRepository lapRepository = new LaptopRepository();
            _service = new Service(lapRepository);
            var laptops = _service.GetLaptops();
            if (laptops.Count > 0)
            {
                LoadLaptopsToGrid(laptops);
            }
        }

        private void btnFilter_Click(object sender, System.EventArgs e)
        {
            var filter = new FrmFilter();
            if (filter.ShowDialog() == DialogResult.OK)
            {
                LoadLaptopsToGrid(filter.FilteredLaptops);
                lblFilter.Text = filter.FilterMessage;
            }
        }

        private void LoadLaptopsToGrid(List<Laptop> laptops)
        {
            grdLaptops.Columns.Clear();
            grdLaptops.DataSource = laptops;
            grdLaptops.Columns["Id"].Visible = false;
            grdLaptops.Columns["CreatedDate"].Visible = false;
            grdLaptops.Columns["Creator"].Visible = false;

            var orderColumn =
                new DataGridViewButtonColumn
                {
                    HeaderText = "New Order",
                    Text = "Order",
                    FillWeight = 50,
                    UseColumnTextForButtonValue = true
                };
            var taxColumn =
                new DataGridViewButtonColumn
                {
                    HeaderText = "Score calculation",
                    Text = "Calculate",
                    FillWeight = 60,
                    UseColumnTextForButtonValue = true
                };
            grdLaptops.Columns.Add(taxColumn);
            grdLaptops.Columns.Add(orderColumn);
        }

        private void lblLogin_Click(object sender, System.EventArgs e)
        {
            var login = new frmLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                EmployerUser = true;
                _employerName = login.EmployerName;
            }
        }

        private void lblLogout_Click(object sender, System.EventArgs e)
        {
            EmployerUser = false;
        }

        private void btnNewEmployer_Click(object sender, System.EventArgs e)
        {
            var newEmployer = new frmNewEmployer();
            if (newEmployer.ShowDialog() == DialogResult.OK)
                MessageBox.Show("The employer was created!");
        }

        private void btnNewOrder_Click(object sender, System.EventArgs e)
        {
            var newOrder = new frmNewOrder();
            if (newOrder.ShowDialog() == DialogResult.OK)
                MessageBox.Show("The order has been processed");
        }

        private void btnNewLaptop_Click(object sender, System.EventArgs e)
        {
            var newLaptop = new frmNewLaptop(_employerName);
            if (newLaptop.ShowDialog() == DialogResult.OK)
                MessageBox.Show("The laptop was added!");
        }

        private void btnViewOrders_Click(object sender, System.EventArgs e)
        { 
            var json = _service.ReceiveOrder();
            var order = _service.ConvertJsonToOrder(json);
        }

        private void lblTitle_Click(object sender, System.EventArgs e)
        {

        }
    }
}
