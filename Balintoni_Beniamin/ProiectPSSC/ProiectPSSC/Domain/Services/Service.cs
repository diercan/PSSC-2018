using System.Collections.Generic;
using ProiectPSSC.Domain.Models;
using ProiectPSSC.Domain.Repositories.Interfaces;
using ProiectPSSC.Infrastructure;
using Newtonsoft.Json;

namespace ProiectPSSC.Domain.Services
{
    public class Service : IService
    {
        private readonly ILaptopRepository _lapRepository;
        private readonly IEmployerRepository _employerRepository;
        private readonly IOrderRepository _orderRepository;

        public Service()
        {
            
        }

        public Service(ILaptopRepository lapRepository)
        {
            _lapRepository = lapRepository;
        }

        public Service(IEmployerRepository employerRepository)
        {
            _employerRepository = employerRepository;
        }

        public Service(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void AddLaptop(Laptop lap)
        {
            _lapRepository.AddLaptop(lap);
        }

        public void AddEmployer(Employer employer)
        {
            _employerRepository.AddEmployer(employer);
        }

        public void AddOrder(Order order)
        {
            _orderRepository.AddOrder(order);
        }

        public Laptop GetLaptop(int id)
        {
            return _lapRepository.LoadLaptopById(id);
        }

        public List<Laptop> GetLaptops(string model)
        {
            return _lapRepository.QueryLaptopsByModel(model);
        }

        public List<Laptop> GetLaptops(int year)
        {
            return _lapRepository.QueryLaptopsByYear(year);
        }

        public List<Laptop> GetLaptops(decimal minPrice, decimal maxPrice)
        {
            return _lapRepository.QueryLaptopsByPrice(minPrice, maxPrice);
        }

        public List<Laptop> GetLaptops()
        {
            return _lapRepository.QueryLaptops();
        }

        public Employer GetEmployer(string name, string password)
        {
            return _employerRepository.LoadEmployer(name, password);
        }

        public List<Order> GetOrders()
        {
            return _orderRepository.QueryOrders();
        }

        public decimal GetTaxCalculation(decimal price, int ram, int year, string gpu)
        {
            var calculator = new CalculatorManager(price, ram, year, gpu);
            return calculator.CalculateScor();
        }

        public void SendOrder(string message)
        {
            var sender = new SenderManager();
            sender.SendMessage(message);
        }

        public string ReceiveOrder()
        {
            var sender = new SenderManager();
            return sender.ReceiveMessage();
        }

        public string ConvertOrderToJson(Order order)
        {
            return JsonConvert.SerializeObject(order);
        }

        public Order ConvertJsonToOrder(string message)
        {
            return JsonConvert.DeserializeObject<Order>(message);
        }
    }
}
