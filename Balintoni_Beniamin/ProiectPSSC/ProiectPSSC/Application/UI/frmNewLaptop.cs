using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProiectPSSC.Domain.Enums;
using ProiectPSSC.Domain.Factories;
using ProiectPSSC.Domain.Repositories;
using ProiectPSSC.Domain.Repositories.Interfaces;
using ProiectPSSC.Domain.Services;

namespace ProiectPSSC.Application.UI
{
    public partial class frmNewLaptop : Form
    {
        private string _employerName;

        public frmNewLaptop(string employer)
        {
            InitializeComponent();

            _employerName = employer;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                if (!decimal.TryParse(txtPrice.Text, out var price)) return;
                var cpu = (TypeCpu)cboTransmission.SelectedIndex + 1;
                var gpu = (Gpu)cboFuel.SelectedIndex + 1;
                if (!int.TryParse(txtYear.Text, out var year)) return;

                var laptopBuilder = new LaptopBuilder(price, cpu, gpu, year, _employerName, DateTime.Now);
                if (!string.IsNullOrWhiteSpace(txtColor.Text)) laptopBuilder.SetColor(txtColor.Text);
                if (!string.IsNullOrWhiteSpace(txtModel.Text)) laptopBuilder.SetModel(txtModel.Text);
                if (!string.IsNullOrWhiteSpace(txtPower.Text)) laptopBuilder.SetRAM(int.Parse(txtPower.Text));
                var lap = laptopBuilder.Build();

                ILaptopRepository repository = new LaptopRepository();
                var service = new Service(repository);

                service.AddLaptop(lap);

                DialogResult = DialogResult.OK;
                Close();
            }
        }

       
        private bool Validation()
        {
            if (string.IsNullOrWhiteSpace(txtPrice.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtYear.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtModel.Text)) return false;
            return true;
        }
    }
}
