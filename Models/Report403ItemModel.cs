namespace kendoTest.Models
{
    public class Report403ItemModel
    {
        public int SNo { get; set; }
        public string PurchaseOrderNo { get; set; }

        public Report403AssetDetails AssetDetails { get; set; }

        public ValuationAccordingToExpert ValuationAccordingToExpert { get; set; }
        public double OtherExpenses { get; set; }
        public double TotalValueIncludingOtherExpenses { get; set; }

        public string? Remarks { get; set; }
    }
    public class Report403AssetDetails : ItemsBaseModel
    {
        public string ManufacturerCompany { get; set; }
        public double EstimatedAge { get; set; }
        public string SourceOfIncome { get; set; }
    }
    public class ValuationAccordingToExpert
    {
        public double Unit { get; set; }

        public double Quantity { get; set; }
        public double Rate { get; set; }
        public double TotalValueExcludingVAT { get; set; }
        public double VAT { get; set; }
        public double TotalValue { get; set; }
    }
}
