namespace kendoTest.Models
{
    public class Report405ViewModel:Report400BaseModel
    {
       
        public long StockReturnFormNo { get; set; }
        public DateOnly Date {  get; set; }
        public  List<Report405ModelSubField> Report405SubFields { get; set; }
        public PersonBase ReturnedBy { get; set; }
        public DateTime DateOfReturn { get; set; }
        public PersonBase PreparedBy { get; set; }
        public DateTime DateOfPreperation { get; set; }
        public PersonBase RecommendedBy  { get; set;}
        public  DateTime DateOfRecommendation { get; set; }
        public PersonBase  ApprovedBy { get; set; }
        public DateTime DateOfApproved { get; set; }




    }
}
