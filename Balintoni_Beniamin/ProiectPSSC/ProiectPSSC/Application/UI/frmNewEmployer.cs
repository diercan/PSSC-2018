using System;
using System.Windows.Forms;
using ProiectPSSC.Domain.Models;
using ProiectPSSC.Domain.Repositories;
using ProiectPSSC.Domain.Repositories.Interfaces;
using ProiectPSSC.Domain.Services;

namespace ProiectPSSC.Application.UI
{
    public partial class frmNewEmployer : Form
    {
        public frmNewEmployer()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("You have to set a valid username!");
                return;
            }
            if ((txtPassword.Text != txtConfirm.Text) || txtPassword.Text.Length < 3)
            {
                MessageBox.Show("Check your password! ");
                return;
            }

            var employer = new Employer(txtName.Text)
            {
                EmployerGuid = Guid.NewGuid(),
                Password = txtPassword.Text,
                Phone = txtPhone.Text
            };

            IEmployerRepository repository = new EmployerRepository();
            var service = new Service(repository);

            service.AddEmployer(employer);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
