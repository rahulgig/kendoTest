namespace kendoTest.Models
{
    public class Report412ViewModel: Report400BaseModel
    {
        public PersonBaseModel PropertyUserDetails { get; set; }
        public string OfficeBranchLocation { get; set; }

        public List<Report412AssetModel> Assets { get; set; }
        public PersonBaseModel PreparedBy { get; set; }
        public DateTime PreparedDate { get; set; }
        public PersonBaseModel CertifiedBy { get; set; }
        public DateTime CertificationDate { get; set; }

    }
}
