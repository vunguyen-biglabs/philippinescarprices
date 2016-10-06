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
                    {LowCapacityFunc, 1.0m},
                    {MediumCapacityFunc, 1.2m},
                    {BigCapacityFunc, 2.0m}
                };
            }
        }
    }
}