namespace kendoTest.Models
{
    public class Report407Model : Report400BaseModel
    {
        public string NameoftheGoods { get; set; }
        public int Unit { get; set; }
        public int ReferenceNumber { get; set; }
        public string Specification{ get; set; }

        public List<Iteam407> Items { get; set; }

        public List<LedgerEntry407> LedgerEntries { get; set;}



    }
}
