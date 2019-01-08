using System;
using ProiectPSSC.Domain.Enums;
using ProiectPSSC.Domain.Factories.Interfaces;
using ProiectPSSC.Domain.Models;

namespace ProiectPSSC.Domain.Factories
{
    public class LaptopBuilder : ILaptopBuilder
    {
        private readonly Laptop _lap;

        public LaptopBuilder(decimal price, TypeCpu cpu, Gpu gpu, int year, string employer, DateTime createdDate)
        {
            if(year < 1990) throw new Exception("Year Error");
            _lap = new Laptop(price, cpu, gpu, year, employer, createdDate);
        }

        public Laptop Build()
        {
            return _lap;
        }

        public void SetColor(string color)
        {
            _lap.Color = color;
        }

        public void SetGPU(Gpu gpu)
        {
            _lap.Gpu = gpu;
        }

        public void SetModel(string model)
        {
            _lap.Model = model;
        }

        public void SetRAM(int ram)
        {
            _lap.Ram = ram;
        }

        public void SetPrice(decimal price)
        {
            _lap.Price = price;
        }

        public void SetCPU(TypeCpu cpu)
        {
            _lap.Cpu = cpu;
        }

        public void SetYear(int year)
        {
            _lap.Year = year;
        }
    }
}
