namespace kendoTest.Models
{
    public class Report403ItemModel: ItemsBaseModel
    {
        public string PurchaseOrderNo { get; set; }

        public string SignalNumber { get; set; }
        public string Model { get; set; }
        public string IdentificationNumber { get; set; }
        public string ManufacturerCompany {  get; set; }
        public float EstimatedAge { get; set; }
        public string SourceOfIncome { get; set; }

        public QuantitiesModel Quantities { get; set; }
        public float Rate { get; set; }
        public float TotalValueExcludingVAT { get; set; }
        public float VAT { get; set; }
        public float TotalValue {  get; set; }
        public float OtherExpenses { get; set; }
        public float TotalValueIncludingOtherExpenses { get; set; }



    }
}
