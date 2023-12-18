namespace kendoTest.Models
{
    public class Report402StocksModel
    {
        public int SNo { get; set; }
        public Report402AssetDetails AssetDetails { get; set; }

        public ValueExcludingVAT ValueExcludingVAT { get; set; }
        public string? Remarks { get; set; }


    }
    public class Report402AssetDetails : ItemsBaseModel
    {
        public double Unit { get; set; }

        public double Quantity { get; set; }
    }
    public class ValueExcludingVAT
    {
        public double Rate { get; set; }

        public double Total { get; set; }
    }
}
