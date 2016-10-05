using System;

namespace PhilippinesCarPrices
{
    public class CarFactory
    {
        public Car CreateCar(string name, decimal originalPrice, decimal capacity,
            StaticData.Country importFrom)
        {
            var importedRegion = GetImportedRegion(importFrom);
            var car = GetCar(importedRegion);
            return car.Init(name, originalPrice, capacity, importFrom);
        }

        private static Car GetCar(StaticData.ImportedRegion importedRegion)
        {
            return StaticData.RegionCars[importedRegion];
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