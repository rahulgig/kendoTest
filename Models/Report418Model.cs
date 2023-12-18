namespace kendoTest.Models
{
    public class Report418Model:Report400BaseModel
    {
        public List<LedgerEntry418> ledgerEntry418s { get; set; }

        public int Year { get; set; }
        public int Month { get; set; }

    }
    public class PropertyModel
    {
        public string PropertyName { get; set; }

        public string Unit { get; set; }

        public string SymbolNumber { get; set; }

        public decimal DepreciationRate { get; set; }
    }
}
