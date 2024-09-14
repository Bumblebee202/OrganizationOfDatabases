namespace SalesApplication.Models
{
    public class SalesPerson
    {
        public static decimal TargetSales { get; set; } = 200_000m;

        public string Name { get; set; }
        public decimal TotalSales { get; private set; }
        private int NumberOfSales { get; set; }

        public SalesPerson(string name)
        {
            Name = name;
        }

        public decimal AvgSale
        {
            get
            {
                if (NumberOfSales == 0)
                {
                    return 0m;
                }

                return TotalSales / NumberOfSales;
            }
        }

        public void AddSale(decimal sale)
        {
            TotalSales += sale;
            NumberOfSales++;
        }

    }
}