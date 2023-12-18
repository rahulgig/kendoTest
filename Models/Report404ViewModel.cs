using kendoTest.Models;
using System.ComponentModel.DataAnnotations;


namespace kendoTest.Models
{
    public class Report404ViewModel : Report400BaseModel
    {

        [Key]
        public long ReportId { get; set; }
        public string ExpenditureClaimFormNo { get; set; }
        public DateOnly Date { get; set; }
        public ICollection<Report404ModelSubField> SubForms { get; set; }
        public PreparedByModel ?PrepareredBy { get; set; }
        public RecommendedByModel? RecomendedBy { get; set; }
        public AcceptedByModel? AcceptedBy { get; set; }
      
    }
}