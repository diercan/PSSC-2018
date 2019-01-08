using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProiectPSSC.Domain.Models;
using ProiectPSSC.Domain.Repositories;
using ProiectPSSC.Domain.Repositories.Interfaces;
using ProiectPSSC.Domain.Services;

namespace ProiectPSSC.Application.UI
{
    public partial class FrmFilter : Form
    {
        public FrmFilter()
        {
            InitializeComponent();
        }

        public List<Laptop> FilteredLaptops { get; set; }
        public string FilterMessage { get; set; }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ILaptopRepository lapRepository = new LaptopRepository();
            var service = new Service(lapRepository);
            FilteredLaptops = service.GetLaptops();
            FilterMessage = "No Filter";

            if (rdoId.Checked)
            {
                if (!int.TryParse(txtId.Text, out var id))
                {
                    MessageBox.Show("Id field must be an integer!");
                    return;
                }
                var lap = service.GetLaptop(id);
                FilteredLaptops = new List<Laptop>() { lap };
                FilterMessage = "Filtered by id: " + id;
            }
            if (rdoModel.Checked)
            {
                FilteredLaptops = service.GetLaptops(txtModel.Text);
                FilterMessage = "Filtered by model: " + txtModel.Text;
            }
            if (rdoPrice.Checked)
            {
                if (!decimal.TryParse(txtPriceFrom.Text, out var from))
                {
                    MessageBox.Show("From field must be a decimal value!");
                    return;
                }
                if (!decimal.TryParse(txtPriceTo.Text, out var to))
                {
                    MessageBox.Show("To field must be a decimal value!");
                    return;
                }
                FilteredLaptops = service.GetLaptops(from, to);
                FilterMessage = "Filtered by price: from " + from + " to " + to;
            }
            if (rdoYear.Checked)
            {
                if (!int.TryParse(txtYear.Text, out var year))
                {
                    MessageBox.Show("Year field must be an integer!");
                    return;
                }
                FilteredLaptops = service.GetLaptops(year);
                FilterMessage = "Filtered by year: " + year;
            }

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
