using ProiectPSSC.Domain.Enums;
using ProiectPSSC.Domain.Models;

namespace ProiectPSSC.Domain.Factories.Interfaces
{
    public interface ILaptopBuilder
    {
        void SetModel(string model);
        void SetPrice(decimal price);
        void SetColor(string color);
        void SetRAM(int ram);
        void SetCPU(TypeCpu cpu);
        void SetGPU(Gpu gpu);
        void SetYear(int year);

        Laptop Build();
    }
}
