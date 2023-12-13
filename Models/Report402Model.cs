namespace kendoTest.Models
{
    public class Report402Model: Report400BaseModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PAN { get; set; }
        public string PhoneNumber { get; set; }
        public int PurchaseOrderNo { get; set; }
        public DateTime PurchaseOrderDate { get; set; }
        public string PurchaseDecisionNo { get; set; }

        public DateTime PurchaseDecisionDate { get; set; }

        public List<Report402StocksModel> StocksAndAssets { get; set; }

        public float TotalAmount { get; set; }

        public PreparerModel PreparedBy {  get; set; }

        public DateTime PreparedDate { get; set; }

        public RecommenderModel RecommendedBy { get; set; }

        public DateTime RecommendDate { get; set; }





    }
}
