namespace kendoTest.Models
{
    public class Report401ItemModel: ItemsBaseModel
    {
        public int SNo { get; set; }
        public RequestedQuantities RequestedQuantities { get; set; }


        public string? Remarks { get; set; }

    }
    public class RequestedQuantities
    {
        public double Unit { get; set; }

        public double Quantity { get; set; }
    }
}
