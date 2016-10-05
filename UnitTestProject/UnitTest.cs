using System;
using NUnit.Framework;
using PhilippinesCarPrices;

namespace UnitTestProject
{
    [TestFixture]
    public class UnitTest
    {
        [TestCase("Benz G65", 217900, 6.0, StaticData.Country.Germany, TestName = "Test Europe Car",
            ExpectedResult = 2305521456)]
        [TestCase("Honda Jazz", 19490, 1.5, StaticData.Country.Japan, TestName = "Test Japan Car",
            ExpectedResult = 72842705.6)]
        [TestCase("Jeep wrangler", 36995, 3.6, StaticData.Country.USA, TestName = "Test USA Car",
            ExpectedResult = 177214928.8)]
        public decimal TestCalculateEndUserPrice(string name, decimal originalPrice, decimal capacity,
            StaticData.Country importFrom)
        {
            var carFactory = new CarFactory();
            var calculator = new Calculator();
            var car = carFactory.CreateCar(name, originalPrice, capacity, importFrom);
            var endUserPrice = calculator.CalculateEndUserPrice(car);
            return endUserPrice;
        }

        [TestCase("Chery QQ", 6000, 1.0, StaticData.Country.China, TestName = "Test China Car")]
        public void TestCalculateEndUserPriceChinaCar(string name, decimal originalPrice, decimal capacity,
            StaticData.Country importFrom)
        {
            var carFactory = new CarFactory();

            var ex = Assert.Throws<Exception>(
                () => carFactory.CreateCar(name, originalPrice, capacity, importFrom)
                );
            StringAssert.Contains("Not support this country", ex.Message);
        }
    }
}