using static System.Runtime.InteropServices.JavaScript.JSType;

namespace kendoTest.Models
{
    public class Report406ViewModel:Report400BaseModel
    {
        public DateTime DateOfHandover { get; set; }
        public int HandoverFormNo { get; set; }
        public int DecisionNo { get; set; }
        public DateTime DecisionDate { get; set; }
        public  string NameOfReceivingOffice { get; set; }
        public List<Report406ModelSubField> report406ModelSubField { get; set; }
        public PersonBase PreparedByTransfer { get; set; }
        public DateTime DateOfPreperationTransfer {  get; set; }
        public PersonBase ApprovedByTransfer { get; set; }
        public DateTime DateOfApprovalTransfer { get; set; }
        public PersonBase PreparedByReciever { get; set; }
        public DateTime  DateOfPreperationReviever { get; set; }
        public PersonBase ApprovedByReviever { get; set; }
        public DateTime DateOfApprovalReciever { get; set; }


    }
}
