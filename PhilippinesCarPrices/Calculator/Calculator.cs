namespace PhilippinesCarPrices
{
    public class Calculator
    {
        public decimal CalculateEndUserPrice(Car car)
        {
            var endUserPrice = StaticData.UsdToPesoExchangeRata*1.12m*car.OriginalPrice*
                               (car.ImportTaxRate + 1);
            return endUserPrice;
        }
    }
}