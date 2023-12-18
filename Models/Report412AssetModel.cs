namespace kendoTest.Models
{
    public class Report412AssetModel
    {
        public DateTime Date { get; set; }
        public string RequestFormNo { get; set; }

       public Report412AssetDetails Report412AssetDetails { get; set; }
        
        public AssetReceiversDetails AssetReceiversDetails { get; set; }
        public AssetReturnDetails ReturnDetails { get; set; }
        
    }
    public class Report412AssetDetails : ItemsBaseModel
    {
        public string EstimatedAge { get; set; }

        public string ManufacturerCompanyOrCountry { get; set; }
        public string SourceOfIncome { get; set; }
        public double Unit { get; set; }

    }
    public class AssetReceiversDetails
    {
        public double Quantity { get; set; }
        public double TotalAccumulatedValue { get; set; }
        public DateTime Date { get; set; }
        //signature

    } 
    public class AssetReturnDetails
    {
        public double Quantity { get; set; }
        public DateTime Date { get; set; }
        //signature

    }
}
