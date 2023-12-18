namespace kendoTest.Models
{
    public class Report413AViewModel:Report400BaseModel
    {
        public string Type { get; set; }
        public int Quater {  get; set; }
        public PreparedByModel PreparedBy { get; set; }
        public RecommendedByModel RecommendedBy { get; set; }
        public CertifiedByModel CertifiedBy { get; set; }

    }
}
