using Microsoft.AspNetCore.Routing.Constraints;

namespace kendoTest.Models
{
    public class Report410AssetModel
    {

        public Report410AssetDetails Report410AssetDetails { get; set; }



        public double TotalAmount { get; set; }

        public TypeOfAction TypeOfAction { get; set; }
        public AssetPropertyValue AssetPropertyValue { get; set; }

        public string ReasonForAction { get; set; }
        public string Remarks {  get; set; }
        

    }
    public class Report410AssetDetails : ItemsBaseModel
    {
        public DateTime ReceiveStartDate { get; set; }
        public string UsedYear { get; set; }
        public double Quantity { get; set; }

    }
    public enum TypeOfAction
    {
        Auction, Disposal
    }

    public class AssetPropertyValue
    {
        public double ValuatedAmount { get; set; }
        public double SoldAmount { get; set; }
    }
}
