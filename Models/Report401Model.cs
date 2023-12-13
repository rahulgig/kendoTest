namespace kendoTest.Models
{


    public class Report401Model : Report400BaseModel
    {
        public long Id { get; set; }
        public DateTime FormDate { get; set; }

        public string FormId { get; set; }


        public List<Report401ItemModel> Items { get; set; }

        public RequestMakerModel RequestMaker { get; set; }

        public DateTime RequestDate { get; set; }

        public string RequestPurpose { get; set; }

        public RecommenderModel Recommender { get; set; }


        public DateTime RecommendDate { get; set; }

        public ReceiverModel Receiver { get; set; }

        public DateTime ReceiveDate { get; set; }

        public bool WasInStock { get; set; }

        public Report401Model()
        {
            FormName = "माग फाराम";
            MLPFormNo = 401;
        }
    }
}
