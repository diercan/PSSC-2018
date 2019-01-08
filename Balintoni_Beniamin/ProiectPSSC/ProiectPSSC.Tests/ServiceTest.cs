using System;
using System.Collections.Generic;
using ProiectPSSC.Domain.Enums;
using ProiectPSSC.Domain.Models;
using ProiectPSSC.Domain.Repositories;
using ProiectPSSC.Domain.Repositories.Interfaces;
using ProiectPSSC.Domain.Services;
using Moq;
using Xunit;

namespace ProiectPSSC.Tests
{
    public class ServiceTest
    {
        [Fact]
        public void TestAddLaptop_success()
        {
            var lap = new Laptop(1000, TypeCpu.AMD, Gpu.nVIDIA, 2005, "Dell", DateTime.Now);
            ILaptopRepository repository = new LaptopRepository();
            var service = new Service(repository);
            var laptops = service.GetLaptops(2005);
            
            service.AddLaptop(lap);

            Assert.Equal(laptops.Count + 1, service.GetLaptops(2005).Count);
        }

        [Fact]
        public void TestGetLaptopsByYear_success()
        {
            var mockRepository = new Mock<ILaptopRepository>();
            mockRepository.Setup(m => m.QueryLaptopsByYear(2005)).Returns(new List<Laptop>());
            var service = new Service(mockRepository.Object);
            var laptops = service.GetLaptops(2005);

            Assert.Empty(laptops);
        }

        [Fact]
        public void TestGetLaptopsByModel_success()
        {
            var lap = new Laptop(1000, TypeCpu.AMD, Gpu.nVIDIA, 2005, "Dell", DateTime.Now){Model = "Dell J5000"};
            var mockRepository = new Mock<ILaptopRepository>();
            mockRepository.Setup(m => m.QueryLaptopsByModel("Dell J5000")).Returns(new List<Laptop>(){lap});
            var service = new Service(mockRepository.Object);
            var laptops = service.GetLaptops("Dell J5000");

            Assert.Single(laptops);
        }

        [Fact]
        public void TestGetLaptopsByPrice_success()
        {
            var laptop1 = new Laptop(2000, TypeCpu.AMD, Gpu.nVIDIA, 2010, "Dell", DateTime.Now);
            var laptop2 = new Laptop(2500, TypeCpu.Intel, Gpu.Radeon, 2005, "Dell", DateTime.Now);
            var mockRepository = new Mock<ILaptopRepository>();
            mockRepository.Setup(m => m.QueryLaptopsByPrice(100, 2000)).Returns(new List<Laptop>(){laptop1, laptop2});
            var service = new Service(mockRepository.Object);
            var laptops= service.GetLaptops(100, 2000);

            Assert.Equal(2, laptops.Count);
        }
    }
}
