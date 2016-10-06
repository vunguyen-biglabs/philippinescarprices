using NUnit.Framework;
using PhilippinesCarPrices;

namespace UnitTestProject
{
    [TestFixture]
    public class UnitTestCalculation
    {
        [TestCase("Benz G65", 217900, 6.0, StaticData.Country.Germany, TestName = "Test Calculate Europe Car",
            ExpectedResult = 34410768)]
        [TestCase("Honda Jazz", 19490, 1.5, StaticData.Country.Japan, TestName = "Test Calculate Japan Car",
            ExpectedResult = 1744121.12)]
        [TestCase("Jeep wrangler", 36995, 3.6, StaticData.Country.USA, TestName = "Test Calculate USA Car",
            ExpectedResult = 3700091.92)]
        public decimal TestCalculateEndUserPrice(string name, decimal originalPrice, decimal capacity,
            StaticData.Country importFrom)
        {
            var carFactory = new CarFactory();
            var calculator = new Calculator();
            var car = carFactory.CreateCar(name, originalPrice, capacity, importFrom);
            var endUserPrice = calculator.CalculateEndUserPrice(car);
            return endUserPrice;
        }
    }
}