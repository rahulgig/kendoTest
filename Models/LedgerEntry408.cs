namespace kendoTest.Models
{
    public class LedgerEntry408
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Remarks { get; set; }

        // Navigation properties
        public List<ProductionCost> ProductionCosts { get; set; }
        public List<Income> Incomes { get; set; }
        public List<Sell> Sells { get; set; }
        public List<Remaining> Remainings { get; set; }

        public class ProductionCost
        {
            public int Id { get; set; }
            public string Specification { get; set; }
            public int Model { get; set; }
            public int PropertyRecordId { get; set; }
            public string ProductionCountryName { get; set; }
            public DateOnly EstimatedAge { get; set; }
            public string Source { get; set; }

            // Navigation property
        }

        public class Income
        {
            public int Quantity { get; set; }
            public int Price { get; set; }
            public double Total { get; set; }

            // Navigation property
            public LedgerEntry408 LedgerEntry { get; set; }
        }

        public class Sell
        {
            public int Quantity { get; set; }
            public int Price { get; set; }
            public double Total { get; set; }

            // Navigation property
            public LedgerEntry408 LedgerEntry { get; set; }
        }

        public class Remaining
        {
            public int Quantity { get; set; }
            public int Price { get; set; }
            public double Total { get; set; }

            // Navigation property
            public LedgerEntry408 LedgerEntry { get; set; }
        }
    }
}
