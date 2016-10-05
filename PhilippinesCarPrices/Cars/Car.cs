using System;
using System.Collections.Generic;
using System.Linq;

namespace PhilippinesCarPrices
{
    public abstract class Car
    {
        public string Name { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal Capacity { get; set; }
        public StaticData.Country ImportedFrom { get; set; }

        public decimal ImportTaxRate
        {
            get { return ImportTaxRateTable[ImportTaxRateTable.Keys.Single(x => x(Capacity))]; }
        }

        protected abstract Dictionary<Func<decimal, bool>, decimal> ImportTaxRateTable { get; }

        protected static Func<decimal, bool> LowCapacityFunc = c => c <= 2.0m;
        protected static Func<decimal, bool> MediumCapacityFunc = c => 2 < c & c <= 5.0m;
        protected static Func<decimal, bool> BigCapacityFunc = c => 5 < c;
        public Car Init(string name, decimal originalPrice, decimal capacity, StaticData.Country importFrom)
        {
            Name = name;
            OriginalPrice = originalPrice;
            Capacity = capacity;
            ImportedFrom = importFrom;
            return this;
        }
    }
}