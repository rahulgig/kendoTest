namespace kendoTest.Models
{


    public class Report401Model : Report400BaseModel
    {
        public long Id { get; set; }
        public DateOnly FormDate { get; set; }

        public string FormId { get; set; }


        public List<Report401ItemModel> Items { get; set; }

        public RequestMakerModel RequestMaker { get; set; }

        public DateOnly RequestDate { get; set; }

        public string RequestPurpose { get; set; }

        public RecommenderModel Recommender { get; set; }


        public DateOnly RecommendDate { get; set; }

        public Report401Model()
        {
            FormName = "माग फाराम";
            MLPFormNo = 401;
        }
    }
}
