using System;
using System.Windows.Forms;
using ProiectPSSC.Domain.Repositories;
using ProiectPSSC.Domain.Repositories.Interfaces;
using ProiectPSSC.Domain.Services;

namespace ProiectPSSC.Application.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
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
            var name = txtName.Text;
            var pass = txtPassword.Text;

            IEmployerRepository employerRepository = new EmployerRepository();
            var service = new Service(employerRepository);

            var employer = service.GetEmployer(name, pass);
            if (employer == null)
            {
                MessageBox.Show("Your name or password is not correct!");
                return;
            }

            EmployerName = name;
            DialogResult = DialogResult.OK;
            Close();
        }

        public string EmployerName { get; set; }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
