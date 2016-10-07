using System;
using System.Collections.Generic;

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

        public const decimal UsdToPesoExchangeRate = 47.0m;

        public static readonly Dictionary<Country, ImportedRegion> CountryRegions = new Dictionary
            <Country, ImportedRegion>
        {
            {Country.Germany, ImportedRegion.Europe},
            {Country.Japan, ImportedRegion.Japan},
            {Country.USA, ImportedRegion.USA}
        };

        private static readonly Func<decimal, bool> LowCapacityFunc = c => c <= 2.0m;
        private static readonly Func<decimal, bool> MediumCapacityFunc = c => 2 < c & c <= 5.0m;
        private static readonly Func<decimal, bool> BigCapacityFunc = c => 5 < c;

        public static Dictionary<ImportedRegion, Dictionary<Func<decimal, bool>, decimal>> RegionImportTaxRateTable = new Dictionary
            <ImportedRegion, Dictionary<Func<decimal, bool>, decimal>>
        {
            {
                ImportedRegion.Europe, new Dictionary
                    <Func<decimal, bool>, decimal>
                {
                    {LowCapacityFunc, 1.0m},
                    {MediumCapacityFunc, 1.2m},
                    {BigCapacityFunc, 2.0m}
                }
            },
            {
                ImportedRegion.USA, new Dictionary
                    <Func<decimal, bool>, decimal>
                {
                    {LowCapacityFunc, 0.75m},
                    {MediumCapacityFunc, 0.9m},
                    {BigCapacityFunc, 1.5m}
                }
            },
            {
                ImportedRegion.Japan, new Dictionary
                    <Func<decimal, bool>, decimal>
                {
                    {LowCapacityFunc, 0.7m},
                    {MediumCapacityFunc, 0.8m},
                    {BigCapacityFunc, 1.35m}
                }
            }
        };
    }
}