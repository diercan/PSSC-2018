using System;
using System.Text;
using System.Windows.Forms;
using ProiectPSSC.Domain.Factories;
using ProiectPSSC.Domain.Models;
using ProiectPSSC.Domain.Services;
using RabbitMQ.Client;

namespace ProiectPSSC.Application.UI
{
    public partial class frmNewOrder : Form
    {
        public frmNewOrder()
        {
            InitializeComponent();
        }

        public frmNewOrder(int laptopId)
        {
            InitializeComponent();

            txtLaptopId.Text = laptopId.ToString();
            txtLaptopId.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                if(!int.TryParse(txtLaptopId.Text, out var id))return;
                var orderBuilder = new OrderBuilder(txtName.Text, txtEmail.Text, txtPhone.Text, id, DateTime.Now );
                orderBuilder.SetAddress(txtAddress.Text);
                var order = orderBuilder.Build();

                var service = new Service();
                var jsonMessage = service.ConvertOrderToJson(order);
                service.SendOrder(jsonMessage);

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool Validation()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtPhone.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtLaptopId.Text)) return false;
            return true;
        }
    }
}
