namespace kendoTest.Models
{
    public class Report415Modelcs:Report400BaseModel
    {
        public string NameofProperty { get; set; }
        public DateTime AnnualYear { get; set; }

        public int IdentityNo { get; set; }

        public int model {  get; set; }

        public string specification { get; set; }

        public DateOnly Date {  get; set; }

        public int accomplishedform  { get; set; }

        public string applicantname { get; set; }

        public string renovation {  get; set; }
        public string Expense { get; set; }

        public double TotalCost { get; set;}

        public double LandRevenueTax { get; set; }

        public double LandTotalCost { get;set; }

        public double maintenance {  get; set; }

        public string Remarks { get; set; }

        public double Total { get; set;}

        public List<PreparedByModel> preparedByModels { get; set; }
        public List<AcceptedByModel> acceptedByModels { get; set; }











    }
}
