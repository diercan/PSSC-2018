using ProiectPSSC.Domain.Enums;

namespace ProiectPSSC.Domain.Models.ValueObjects
{
    public class Money
    {
        public decimal Amount { get; set; }
        public Currency Currency { get; set; }
    }
}
