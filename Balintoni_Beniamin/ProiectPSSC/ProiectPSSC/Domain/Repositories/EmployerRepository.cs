using System;
using System.Data.SqlClient;
using ProiectPSSC.Domain.Models;
using ProiectPSSC.Domain.Repositories.Interfaces;

namespace ProiectPSSC.Domain.Repositories
{
    public class EmployerRepository : IEmployerRepository
    {
        private readonly SqlConnection _conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Beny\Desktop\Pssc\PSSC\ProiectPSSC\ProiectPSSC\Database.mdf;Integrated Security=True");


        public void AddEmployer(Employer employer)
        {
            _conn.Open();
            using (var com = new SqlCommand("INSERT INTO Employers  VALUES (@guid, @name, @phone, @pass)", _conn))
            {
                com.Parameters.AddWithValue("@guid", Guid.NewGuid());
                com.Parameters.AddWithValue("@name", employer.Name);
                com.Parameters.AddWithValue("@phone", employer.Phone);
                com.Parameters.AddWithValue("@pass", employer.Password);

                com.ExecuteNonQuery();
                _conn.Close();
            }
        }

        public Employer LoadEmployer(string name, string pass)
        {
            _conn.Open();
            Employer employer;
            var command = "SELECT * FROM Employers WHERE Name = @name AND Password = @pass";
            using (var com = new SqlCommand(command, _conn))
            {
                com.Parameters.AddWithValue("@name", name);
                com.Parameters.AddWithValue("@pass", pass);
                var reader = com.ExecuteReader();
                reader.Read();
                employer = new Employer(reader["Name"].ToString())
                {
                    EmployerGuid = (Guid)reader["EmployerGuid"],
           
                    Phone = reader["Phone"].ToString()
                };
                _conn.Close();
            }

            return employer;
        }
    }
}
