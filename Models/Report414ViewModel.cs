namespace kendoTest.Models
{
    public class Report414ViewModel:Report400BaseModel
    {
        public string RepairPropertyName { get; set; }
        public long SymbolNo { get; set; }
        public long IdentificationNo { get; set; }
        public long SignalNo { get; set; }
        public string ReasonOfRepairance { get; set; }
        public DateTime Date {  get; set; }
        public long RepairApplicationOrderNo { get; set; }
        public long ExpenditureNo { get; set; }
        public Report414ModelSubField SubFields { get; set; }
        public float TotalAmount { get; set; }
        public PersonBase MaintainanceApplicator { get; set; }
        public DateTime MaintinanceApplicationDate { get; set; }
        public DateTime PreviousMaintainedDate { get; set; }
        public float PreviousMaintainedAmount { get; set;}
        public string Remarks { get; set; }
        public PreparedByModel PreparedBy {  get; set; }
        public RecommendedByModel RecommendedBy { get; set; }
        public long SubtitleNo { get; set; }
        public long TitleNo { get; set; }
        public long ActivityNo { get; set; }
        public PersonBase FinancialAdmin { get; set; }
        public DateTime DateAdmin { get; set; }
        public AcceptedByModel AcceptedBy { get; set; }
        public DateTime DateOfSubmit {  get; set; }
        public string OfficeName { get; set; }
        public PersonBase OrderGiver { get; set; }
        public string OrderGiverAddress { get; set; }
        public string OrderGiverPAN { get; set; }

    }

}
