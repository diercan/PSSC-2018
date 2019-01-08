using ProiectPSSC.Infrastructure;
using System;
using Xunit;

namespace ProiectPSSC.Tests
{
    public class CalculatorManagerTest
    {
        [Fact]
        public void TestConstructor_success()
        {
            var expextedTax = 1477m;
            var calculator = new CalculatorManager(7000, 8000, 2019, "nVIDIA");

            var result = calculator.CalculateScor();

            Assert.Equal(expextedTax, result);
        }
        [Fact]
        public void TestConstructor_failed()
        {
            var expextedException = new Exception("Error");
            Exception e = null;
            try
            {
                var calculator = new CalculatorManager(5000, 4000, 2018, "-");
            }
            catch (Exception ex)
            {
                e = ex;
            }

            Assert.NotNull(e);
            Assert.Equal(expextedException.Message, e.Message);
        }
    }
}
