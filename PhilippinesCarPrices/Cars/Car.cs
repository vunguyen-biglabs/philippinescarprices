namespace PhilippinesCarPrices
{
    public class Car
    {
        public Car(string name, decimal originalPrice, decimal capacity, StaticData.Country importFrom,
            decimal importTaxRate)
        {
            Name = name;
            OriginalPrice = originalPrice;
            Capacity = capacity;
            ImportedFrom = importFrom;
            ImportTaxRate = importTaxRate;
        }

        public string Name { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal Capacity { get; set; }
        public StaticData.Country ImportedFrom { get; set; }
        public decimal ImportTaxRate { get; set; }
    }
}