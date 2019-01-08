using System;

namespace ProiectPSSC.Infrastructure
{
    public class CalculatorManager
    {
        private readonly decimal _gpuValue;
        private readonly decimal _ramValue;
        private readonly decimal _yearValue;
        private readonly decimal _price;

        public CalculatorManager(decimal price, int ram, int year, string gpu)
        {
            _price = price;
            _gpuValue = (gpu == "nVIDIA") ? 2 : (gpu == "Radeon") ? 1 : -1;
            if(_gpuValue == -1) throw new Exception("Erorr");
            _ramValue = Convert.ToDecimal(ram / 10);
            _yearValue = Convert.ToDecimal((DateTime.Now.Year - year) / 3);
        }

        public decimal CalculateScor()
        {
            return (_price + _gpuValue + _yearValue + _ramValue);
        }
    }
}
