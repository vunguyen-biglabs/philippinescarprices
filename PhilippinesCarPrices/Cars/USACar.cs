using System;
using System.Collections.Generic;

namespace PhilippinesCarPrices.Cars
{
    public class UsaCar : Car
    {
        protected override Dictionary<Func<decimal, bool>, decimal> ImportTaxRateTable
        {
            get
            {
                return new Dictionary
                    <Func<decimal, bool>, decimal>
                {
                    {LowCapacityFunc, 75.0m},
                    {MediumCapacityFunc, 90.0m},
                    {BigCapacityFunc, 150.0m}
                };
            }
        }
    }
}