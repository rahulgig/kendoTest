namespace kendoTest.Models
{
    public class Report410ViewModel : Report400BaseModel
    {
        public string DecisionDescription { get; set; }

        public DateTime DateOfAuctionSale { get; set; }

        public PersonBaseModel DecisionMakingOfficial { get; set; }

        public DateTime FormDate { get; set; }

        public List<Report410AssetModel> PropertyAndAssets { get; set; }

        public PersonBaseModel PreparedBy {  get; set; }
        public DateTime PreparedDate {  get; set; }
        public PersonBaseModel RecommendedBy { get; set; }
        public DateTime RecommendDate { get; set; }
        public PersonBaseModel AcceptedBy { get; set; }
        public DateTime AcceptedDate { get; set;}

    }
}
