using Microsoft.AspNetCore.Routing.Constraints;

namespace kendoTest.Models
{
    public class LedgerEntry416
    {
        public int SNO {  get; set; }

        public DateOnly Date {  get; set; }

        public string quantity { get; set; }

        public DateOnly ApprovalDate { get; set; }

        public double TimebasedRate { get; set; }

        public double TotalRentAmount { get; set; }

        public double ReceiptNumber { get; set; }






    }
    public class RentPayment
    {
        public string Name { get; set; }
        public string Address { get; set; }

    }

    


}
