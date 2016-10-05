using System;
using System.Collections.Generic;

namespace PhilippinesCarPrices
{
    public class EuropeCar : Car
    {
        protected override Dictionary<Func<decimal, bool>, decimal> ImportTaxRateTable
        {
            get
            {
                return new Dictionary
                    <Func<decimal, bool>, decimal>
                {
                    {LowCapacityFunc, 100.0m},
                    {MediumCapacityFunc, 120.0m},
                    {BigCapacityFunc, 200.0m}
                };
            }
        }
    }
}