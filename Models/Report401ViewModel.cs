namespace kendoTest.Models
{
    public class Report401ViewModel: Report400BaseModel
    {
        public string RequestFormNo { get; set; }
        public DateTime FormDate { get; set; }
        public List<Report401ItemModel> Items { get; set; }
        public PersonBaseModel RequestedBy { get; set; }
        public DateTime RequestDate { get; set; }
        public string RequestPurpose { get; set; }

        public PersonBaseModel RecommendedBy { get; set; }
        public DateTime RecommendDate { get; set; }

        public PersonBaseModel Storekeeper { get; set; }
        public bool WasInStock { get; set; }


        public PersonBaseModel ReceivedBy { get; set; }

        public DateTime ReceiveDate { get; set; }

        public PersonBaseModel ExpenseRecordedBy { get; set; }

        public DateTime ExpenseRecordDate { get; set; }

        public PersonBaseModel AcceptedBy { get; set; }

        public DateTime AcceptedDate { get; set; }
    }
}
