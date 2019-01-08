using System.Collections.Generic;
using ProiectPSSC.Domain.Enums;
using ProiectPSSC.Domain.Models;

namespace ProiectPSSC.Domain.Repositories.Interfaces
{
    public interface ILaptopRepository
    {
        Laptop LoadLaptopById(int id);
        void AddLaptop(Laptop lap);

        List<Laptop> QueryLaptops();
        List<Laptop> QueryLaptopsByModel(string model);
        List<Laptop> QueryLaptopsByYear(int year);
        List<Laptop> QueryLaptopsByPrice(decimal minPrice, decimal maxPrice);
    }
}
