using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using ProiectPSSC.Domain.Enums;
using ProiectPSSC.Domain.Models;
using ProiectPSSC.Domain.Repositories.Interfaces;

namespace ProiectPSSC.Domain.Repositories
{
    public class LaptopRepository : ILaptopRepository
    {
        private readonly SqlConnection _conn;
        public LaptopRepository()
        {
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        
            var connectionString =
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Beny\Desktop\Pssc\PSSC\ProiectPSSC\ProiectPSSC\Database.mdf;Integrated Security=True";
            
            _conn = new SqlConnection(connectionString);
        }

        public void AddLaptop(Laptop lap)
        {
            _conn.Open();
            using (var com = new SqlCommand("INSERT INTO Laptops VALUES (@created, @creator, @price, @color, @ram, @cpu, @gpu, @year, @model)", _conn))
            {
                com.Parameters.AddWithValue("@created", lap.CreatedDate);
                com.Parameters.AddWithValue("@creator", lap.Creator);
                com.Parameters.AddWithValue("@price", lap.Price);
                com.Parameters.AddWithValue("@color", lap.Color);
                com.Parameters.AddWithValue("@ram", lap.Ram);
                com.Parameters.AddWithValue("@cpu", ((int)lap.Cpu).ToString());
                com.Parameters.AddWithValue("@gpu", ((int)lap.Gpu).ToString());
                com.Parameters.AddWithValue("@year", lap.Year);
                com.Parameters.AddWithValue("@model", lap.Model);
                com.ExecuteNonQuery();
                _conn.Close();
            }


        }

        public Laptop LoadLaptopById(int id)
        {
            _conn.Open();
            Laptop lap;
            var command = "SELECT * FROM Laptops WHERE Id = @id";
            using (var com = new SqlCommand(command, _conn))
            {
                com.Parameters.AddWithValue("@id", id);
                var reader = com.ExecuteReader();
                reader.Read();
                
                var cpu = (TypeCpu)int.Parse(reader["Cpu"].ToString());
                var gpu = (Gpu)int.Parse(reader["GPU"].ToString());
                var model = reader["Model"].ToString();

                lap = new Laptop((decimal) reader["Price"], cpu,
                   gpu, (int) reader["Year"], reader["Creator"].ToString(), (DateTime)reader["CreatedDate"])
                {
                    Color = reader["Color"].ToString(),
                    Ram = (int) reader["RAM"],
                    CreatedDate = (DateTime)reader["CreatedDate"],
                    Creator = reader["Creator"].ToString(),
                    Model = model
                };
                _conn.Close();
            }

            return lap;
        }

        public List<Laptop> QueryLaptops()
        {
            _conn.Open();
            var laptops = new List<Laptop>();
            var query = "SELECT * FROM Laptops";
            using (var com = new SqlCommand(query, _conn))
            {
                var reader = com.ExecuteReader();
                while (reader.Read())
                {
                   
                    var cpu = (TypeCpu)int.Parse(reader["Cpu"].ToString());
                    var gpu = (Gpu)int.Parse(reader["Gpu"].ToString());
                    var modelR = reader["Model"].ToString();

                    var lap = new Laptop((decimal)reader["Price"], cpu, gpu,
                        (int)reader["Year"], reader["Creator"].ToString(), (DateTime)reader["CreatedDate"])
                    {
                        Id = (int)reader["Id"],
                        Color = reader["Color"].ToString(),
                        Ram = (int)reader["RAM"],
                        CreatedDate = (DateTime)reader["CreatedDate"],
                        Creator = reader["Creator"].ToString(),
                        Model = modelR
                    };
                    laptops.Add(lap);
                }
                _conn.Close();
            }

            return laptops;
        }

        public List<Laptop> QueryLaptopsByModel(string model)
        {
            _conn.Open();
            var laptops = new List<Laptop>();
            var command = "SELECT * FROM Laptops WHERE Model = @model";
            using (var com = new SqlCommand(command, _conn))
            {
                com.Parameters.AddWithValue("@model", model.ToString());
                var reader = com.ExecuteReader();
                while (reader.Read())
                {
                    var cpu = (TypeCpu)int.Parse(reader["Cpu"].ToString());
                    var gpu = (Gpu)int.Parse(reader["Gpu"].ToString());
                    var modelR = reader["Model"].ToString();

                    var lap = new Laptop((decimal) reader["Price"], cpu, gpu,
                        (int)reader["Year"], reader["Creator"].ToString(), (DateTime)reader["CreatedDate"])
                    {
                        Color = reader["Color"].ToString(),
                        Ram = (int) reader["RAM"],
                        CreatedDate = (DateTime) reader["CreatedDate"],
                        Creator = reader["Creator"].ToString(),
                        Model = modelR
                    };
                    laptops.Add(lap);
                }
                _conn.Close();
            }

            return laptops;
        }

        public List<Laptop> QueryLaptopsByPrice(decimal minPrice, decimal maxPrice)
        {
            _conn.Open();
            var laptops = new List<Laptop>();
            var command = "SELECT * FROM Laptops WHERE Price >= @min AND Price <= @max";
            using (var com = new SqlCommand(command, _conn))
            {
                com.Parameters.AddWithValue("@min", minPrice);
                com.Parameters.AddWithValue("@max", maxPrice);
                var reader = com.ExecuteReader();
                while (reader.Read())
                {
                    var cpu = (TypeCpu)int.Parse(reader["Cpu"].ToString());
                    var gpu = (Gpu)int.Parse(reader["Gpu"].ToString());
                    var model = reader["Model"].ToString();

                    var lap = new Laptop((decimal)reader["Price"], cpu,
                        gpu, (int)reader["Year"], reader["Creator"].ToString(), (DateTime)reader["CreatedDate"])
                    {
                        Color = reader["Color"].ToString(),
                       Ram = (int)reader["RAM"],
                        CreatedDate = (DateTime)reader["CreatedDate"],
                        Creator = reader["Creator"].ToString(),
                        Model = model
                    };
                    laptops.Add(lap);
                }
                _conn.Close();
            }

            return laptops;
        }

        public List<Laptop> QueryLaptopsByYear(int year)
        {
            _conn.Open();
            var laptops = new List<Laptop>();
            var command = "SELECT * FROM Laptops WHERE Year = @year";
            using (var com = new SqlCommand(command, _conn))
            {
                com.Parameters.AddWithValue("@year", year);
                var reader = com.ExecuteReader();
                while (reader.Read())
                {
                    var price = (decimal)reader["Price"];
                    var cpu = (TypeCpu)int.Parse(reader["CPU"].ToString());
                    var gpu = (Gpu)int.Parse(reader["GPU"].ToString());
                    var model = reader["Model"].ToString();
                    var lap = new Laptop(price, cpu, gpu, (int)reader["Year"], reader["Creator"].ToString(), (DateTime)reader["CreatedDate"])
                    {
                        Color = reader["Color"].ToString(),
                        Ram = (int)reader["RAM"],
                        CreatedDate = (DateTime)reader["CreatedDate"],
                        Creator = reader["Creator"].ToString(),
                        Model = model
                    };
                    laptops.Add(lap);
                }
                _conn.Close();
            }

            return laptops;
        }
    }
}
