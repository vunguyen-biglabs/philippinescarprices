namespace PhilippinesCarPrices
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var carFactory = new CarFactory();
            var calculator = new Calculator();
            /*
             * 1. Benz G65 from Germany (Europe county), 6.0L, original price $217,900USD
2. Honda Jazz 1.5L (Japan) original price $19,490 USD
3. Jeep wrangler 3.6L (USA) original price, $36,995USD
4. Chery QQ 1.0L (China) original price, $6,000USD
             */         

            var benzG65 = carFactory.CreateCar("Benz G65", 217900m, 6.0m, StaticData.Country.Germany);
            var benzG65EndUserPrice = calculator.CalculateEndUserPrice(benzG65);

            var hondaJazz = carFactory.CreateCar("Honda Jazz", 19490m, 1.5m, StaticData.Country.Japan);
            var hondaJazzEndUserPrice = calculator.CalculateEndUserPrice(hondaJazz);

            var jeepWrangler = carFactory.CreateCar("Jeep wrangler", 36995m, 3.6m, StaticData.Country.USA);
            var jeepWranglerEndUserPrice = calculator.CalculateEndUserPrice(jeepWrangler);

            //throw Exception
            var cheryQq = carFactory.CreateCar("Chery QQ", 6000m, 1.0m, StaticData.Country.China);
            var cheryQqEndUserPrice = calculator.CalculateEndUserPrice(cheryQq);
        }
    }
}