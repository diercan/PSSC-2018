using System;
using System.Collections.Generic;
using ProiectPSSC.Domain.Enums;
using ProiectPSSC.Domain.Models;

namespace ProiectPSSC.Domain.Services
{
    public interface IService
    {
        void AddLaptop(Laptop lap);
        Laptop GetLaptop(int id);
        List<Laptop> GetLaptops();
        List<Laptop> GetLaptops(string model);
        List<Laptop> GetLaptops(int year);
        List<Laptop> GetLaptops(decimal minPrice, decimal maxPrice);

        Employer GetEmployer(string name, string password);
        void AddEmployer(Employer employer);

        void AddOrder(Order order);
        List<Order> GetOrders();

        decimal GetTaxCalculation(decimal price, int ram, int year, string gpu);

        void SendOrder(string message);
        string ReceiveOrder();

        Order ConvertJsonToOrder(string message);
    }
}
