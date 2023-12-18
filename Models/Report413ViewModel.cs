namespace kendoTest.Models
{
    public class Report413ViewModel:Report400BaseModel
    {
        public string TypeOf {  get; set; }
        public List<Report413ModelSubField> SubField { get; set; }
        public PreparedByModel PreparedBy {  get; set; }
        public RecommendedByModel RecommendedBy { get; set; }
        public AcceptedByModel AcceptedBy { get; set; }

    }
}
