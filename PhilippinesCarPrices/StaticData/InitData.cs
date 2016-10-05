using System.Collections.Generic;
using PhilippinesCarPrices.Cars;

namespace PhilippinesCarPrices
{
    public static class StaticData
    {
        public enum Country
        {
            Germany = 0,
            Japan = 1,
            USA = 2,
            China = 3
        }

        public enum ImportedRegion
        {
            Europe = 0,
            USA = 1,
            Japan = 2
        }

        public const decimal UsdToPesoExchangeRata = 47.0m;

        public static readonly Dictionary<Country, ImportedRegion> CountryRegions = new Dictionary
            <Country, ImportedRegion>
        {
            {Country.Germany, ImportedRegion.Europe},
            {Country.Japan, ImportedRegion.Japan},
            {Country.USA, ImportedRegion.USA}
        };

        public static readonly Dictionary<ImportedRegion, Car> RegionCars = new Dictionary<ImportedRegion, Car>
        {
            {ImportedRegion.Europe, new EuropeCar()},
            {ImportedRegion.USA, new UsaCar()},
            {ImportedRegion.Japan, new JavCar()},
        };
    }
}