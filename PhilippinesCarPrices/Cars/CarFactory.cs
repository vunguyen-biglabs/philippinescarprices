using System;
using System.Linq;

namespace PhilippinesCarPrices
{
    public class CarFactory
    {
        public Car CreateCar(string name, decimal originalPrice, decimal capacity,
            StaticData.Country importFrom)
        {
            var importedRegion = GetImportedRegion(importFrom);
            var importTaxRateTable = StaticData.RegionImportTaxRateTable[importedRegion];
            var importTaxRate = importTaxRateTable[importTaxRateTable.Keys.Single(x => x(capacity))];
            var car = new Car(name, originalPrice, capacity, importFrom, importTaxRate);
            return car;
        }

        private static StaticData.ImportedRegion GetImportedRegion(StaticData.Country importFrom)
        {
            try
            {
                return StaticData.CountryRegions[importFrom];
            }
            catch
            {
                throw new Exception("Not support this country");
            }
        }
    }
}