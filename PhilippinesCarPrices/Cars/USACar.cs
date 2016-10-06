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
                    {LowCapacityFunc, 0.75m},
                    {MediumCapacityFunc, 0.9m},
                    {BigCapacityFunc, 1.5m}
                };
            }
        }
    }
}