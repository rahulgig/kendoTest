namespace kendoTest.Models
{
    public class Report411ViewModel: Report400BaseModel
    {
        public TypeOfProperty TypeOfProperty { get; set; }
        public List<Report411AssetModel> Assets { get; set; }

        public DateTime InspectionCommitteeFormationDate { get; set; }
        public DateTime InspectionReportSubmissionDate { get; set; }
        public List<PersonBaseModel> InspectionCommitteeDetails { get; set; }

    }
    
}
