namespace kendoTest.Models
{
    public class Report417ViewModel: Report400BaseModel
    {
        public List<Report417LandDetails> Report417LandDetails { get; set; } 
        public PersonBaseModel PreparedBy {  get; set; }
        public DateTime PreparedDate { get; set; }
        public PersonBaseModel VerifiedBy { get; set; }
        public DateTime VerifiedDate { get; set;}
    }

}
