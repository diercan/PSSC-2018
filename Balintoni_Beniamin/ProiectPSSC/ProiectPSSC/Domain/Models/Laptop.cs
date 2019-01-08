using System;
using ProiectPSSC.Domain.Enums;
using ProiectPSSC.Domain.Services.Entities;

namespace ProiectPSSC.Domain.Models
{
    public class Laptop : LaptopEntity
    {
        public Laptop(decimal price, TypeCpu cpu, Gpu gpu, int year, string employerName, DateTime createdDate):base(createdDate, employerName)
        {
            Price = price;
            Gpu = gpu;
            Cpu = cpu;
            Year = year;

            Color = "White";
            Ram = 4;
        }

        public decimal Price { get; set; }
        public string Color { get; set; }
        public int Ram { get; set; }
        public TypeCpu Cpu { get; set; }
        public Gpu Gpu { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
    }
}
