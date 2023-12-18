using Microsoft.AspNetCore.Routing.Constraints;
using System.ComponentModel.DataAnnotations;

namespace kendoTest.Models
{
    public class LedgerEntry416
    {
        public int SNO { get; set; }

        public DateOnly Date { get; set; }

        public string quantity { get; set; }

        [Display(Name = "Rent Order/Contract Approval Date")]

        public DateOnly ApprovalDate { get; set; }

        public double TimebasedRate { get; set; }

        public double TotalRentAmount { get; set; }

        public double ReceiptNumber { get; set; }

        [Display(Name = "Received/Return Date")]
        [DataType(DataType.Date)]
        public DateTime? ReceivedReturnDate { get; set; }

        public string Remarks { get; set; }






    }
    public class RentPayment
    {
        public string Name { get; set; }
        public string Address { get; set; }

    }




}
