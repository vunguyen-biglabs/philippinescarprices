using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhilippinesCarPrices.Cars
{
    public class JavCar : Car
    {
        protected override Dictionary<Func<decimal, bool>, decimal> ImportTaxRateTable
        {
            get
            {
                return new Dictionary
                  <Func<decimal, bool>, decimal>
                {
                    {LowCapacityFunc, 70.0m},
                    {MediumCapacityFunc, 80.0m},
                    {BigCapacityFunc, 135.0m}
                };
            }
        }
    }
}
