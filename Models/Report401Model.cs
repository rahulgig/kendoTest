namespace kendoTest.Models
{


    public class Report401Model : Report400BaseModel
    {
        public long Id { get; set; }
        public DateOnly FormDate { get; set; }

        public string FormId { get; set; }


        public List<Item> Items { get; set; }

        public RequestMaker RequestMaker { get; set; }

        public DateOnly RequestDate { get; set; }

        public string RequestPurpose { get; set; }

        public Recommender Recommender { get; set; }


        public DateOnly RecommendDate { get; set; }

    }
}
