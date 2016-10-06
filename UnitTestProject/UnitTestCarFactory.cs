using System;
using NUnit.Framework;
using PhilippinesCarPrices;

namespace UnitTestProject
{
    public class UnitTestCarFactory
    {
        [TestCase("Benz G65", 217900, 6.0, StaticData.Country.Germany, TestName = "Test Europe Car 6.0L Import Tax Rate",
            ExpectedResult = 2)]
        [TestCase("Benz G65", 217900, 5.0, StaticData.Country.Germany, TestName = "Test Europe Car 5.0L Import Tax Rate",
            ExpectedResult = 1.2)]
        [TestCase("Benz G65", 217900, 1.0, StaticData.Country.Germany, TestName = "Test Europe Car 1.0L Import Tax Rate",
            ExpectedResult = 1)]
        [TestCase("Honda Jazz", 19490, 1.5, StaticData.Country.Japan, TestName = "Test Japan Car 1.5L Import Tax Rate",
            ExpectedResult = 0.7)]
        [TestCase("Honda Jazz", 19490, 3.5, StaticData.Country.Japan, TestName = "Test Japan Car 3.5L Import Tax Rate",
            ExpectedResult = 0.8)]
        [TestCase("Honda Jazz", 19490, 10.8, StaticData.Country.Japan, TestName = "Test Japan Car 10.8L Import Tax Rate",
            ExpectedResult = 1.35)]
        [TestCase("Jeep wrangler", 36995, 3.6, StaticData.Country.USA, TestName = "Test USA Car 3.6L Import Tax Rate",
            ExpectedResult = 0.9)]
        [TestCase("Jeep wrangler", 36995, 9.6, StaticData.Country.USA, TestName = "Test USA Car 9.6L Import Tax Rate",
            ExpectedResult = 1.5)]
        [TestCase("Jeep wrangler", 36995, 1.2, StaticData.Country.USA, TestName = "Test USA Car 1.2L Import Tax Rate",
            ExpectedResult = 0.75)]
        public decimal TestCarImportTaxRate(string name, decimal originalPrice, decimal capacity,
            StaticData.Country importFrom)
        {
            var carFactory = new CarFactory();
            var car = carFactory.CreateCar(name, originalPrice, capacity, importFrom);
            return car.ImportTaxRate;
        }

        [TestCase("Chery QQ", 6000, 1.0, StaticData.Country.China, TestName = "Test Create China Car")]
        public void TestCreateChinaCar(string name, decimal originalPrice, decimal capacity,
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