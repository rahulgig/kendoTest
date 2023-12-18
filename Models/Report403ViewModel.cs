namespace kendoTest.Models
{
    public class Report403ViewModel: Report400BaseModel
    {
        public TypeOfProperty TypeOfProperty { get; set; }

        public DateTime SubmissionDate { get; set; }

        public string SubmissionReportNumber { get; set; }
        public List<Report403ItemModel> Items { get; set; }

        public double TotalAmount { get; set; }

        public PersonBaseModel PreparedBy {  get; set; }
        public DateTime PreparedDate { get; set; }
        public PersonBaseModel RecommendedBy { get; set; }
        public DateTime RecommendDate { get; set; }
        public PersonBaseModel ApprovedBy { get; set; }
        public DateTime ApprovedDate { get; set; }


    }

    public enum TypeOfProperty
    {
        Inventory, Asset
    }
}
