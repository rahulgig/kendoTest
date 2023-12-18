namespace kendoTest.Models
{
    public class Report411AssetModel
    {
        public Report411AssetDetails Report411AssetDetails { get; set; }
        public BalanceAsPerStock BalanceAsPerStock { get; set; }
        public AccordingToSpecifications AccordingToSpecifications { get; set; }
        
        public AfterPhysicalExamination AfterPhysicalTesting { get; set; }
        public ConditionAndQuantity conditionAndQuantity { get; set; }
        public double TotalQuantityAsPerPhysicalExamination { get; set; }
        public string Remarks { get; set; }

    }
    public class Report411AssetDetails : ItemsBaseModel
    {
        public double Unit { get; set; }

    }
    public class AccordingToSpecifications
    {
        public double QuantityAccordingToSpecifications { get; set; }
        public double QuantityNotAccordingToSpecifications { get; set; }
    }
    public class BalanceAsPerStock
    {
        public double Quantity { get; set; }
        public double Price { get; set; }
    }
    public class AfterPhysicalExamination
    {
        public double LessAmount { get; set; }
        public double MoreAmount { get; set; }

        public double DifferenceAmount { get; set; }
    }
    public class ConditionAndQuantity
    {
        public double InWorkingCondition { get; set; }
        public double ToBeRepaired { get; set; }
        public double ToBeAuctioned { get; set; }
        public double ToBeDisposed { get; set; }
        public double ToBePreserved { get; set; }
    }
}
