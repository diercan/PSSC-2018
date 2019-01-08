using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ProiectPSSC.Domain.Models;
using ProiectPSSC.Domain.Repositories.Interfaces;

namespace ProiectPSSC.Domain.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly SqlConnection _conn = new SqlConnection("Data Source = Database.mdf");

    

        public void AddOrder(Order order)
        {
            _conn.Open();
            using (var com = new SqlCommand("INSERT INTO Laptops VALUES (@name, @email, @phone, @laptopId, @address, @date)", _conn))
            {
                com.Parameters.AddWithValue("@name", order.ClientName);
                com.Parameters.AddWithValue("@email", order.Email);
                com.Parameters.AddWithValue("@phone", order.Phone);
                com.Parameters.AddWithValue("@laptopId", order.LaptopId);
                com.Parameters.AddWithValue("@address", order.Address);
                com.Parameters.AddWithValue("@date", order.Date);

                com.ExecuteNonQuery();
                _conn.Close();
            }
        }

        public List<Order> QueryOrders()
        {
            _conn.Open();
            var laptops = new List<Order>();
            var command = "SELECT * FROM Orders";
            using (var com = new SqlCommand(command, _conn))
            {
                var reader = com.ExecuteReader();
                while (reader.Read())
                {
                    var lap = new Order(reader["ClientName"].ToString(), reader["Email"].ToString(), reader["Phone"].ToString(),(int)reader["LaptopId"], (DateTime)reader["Date"])
                    {
                        Id = (int)reader["Id"],
                        Address = reader["Address"].ToString(),
                        Date = (DateTime)reader["Date"]
                    };
                    laptops.Add(lap);
                }
                _conn.Close();
            }

            return laptops;
        }
    }
}
