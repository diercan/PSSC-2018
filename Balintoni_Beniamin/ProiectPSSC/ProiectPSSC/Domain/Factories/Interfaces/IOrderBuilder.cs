using ProiectPSSC.Domain.Enums;
using ProiectPSSC.Domain.Models;

namespace ProiectPSSC.Domain.Factories.Interfaces
{
    public interface IOrderBuilder
    {
        void SetClientName(string name);
        void SetEmail(string email);
        void SetPhone(string phone);
        void SetAddress(string address);
        void SetLaptopId(int laptopId);

        Order Build();
    }
}
